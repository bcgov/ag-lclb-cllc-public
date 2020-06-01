﻿using Gov.Lclb.Cllb.Interfaces;
using Gov.Lclb.Cllb.Interfaces.Models;
using Hangfire;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Rest;
using System;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Xml;
using System.Xml.Serialization;

namespace Gov.Lclb.Cllb.OneStopService
{
    public class ReceiveFromHubService : IReceiveFromHubService
    {
        IDynamicsClient _dynamicsClient;

        public ILogger _logger{ get; }
        private readonly IConfiguration Configuration;

        public ReceiveFromHubService(IDynamicsClient dynamicsClient, ILogger logger, IConfiguration configuration)
        {
            _dynamicsClient = dynamicsClient;
            _logger = logger;
            Configuration = configuration;
        }

        /// <summary>
        /// Get the name of the root node.
        /// </summary>
        /// <param name="inputXML"></param>
        /// <returns></returns>
        private string GetRootNodeName(string inputXML)
        {
            string result = null;
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(inputXML);
            // node 0 is going to be "xml", so get the next node.
            if (xmlDocument.ChildNodes.Count > 1)
            {
                result = xmlDocument.ChildNodes[1].Name;
            }            
            return result;
        }

        private string HandleSBNCreateProgramAccountResponse(string inputXML)
        {
            _logger.LogDebug($"Reached HandleSBNCreateProgramAccountResponse inputXML is: {inputXML}");

            string httpStatusCode = "200";

            // deserialize the inputXML
            var serializer = new XmlSerializer(typeof(SBNCreateProgramAccountResponse1));
            SBNCreateProgramAccountResponse1 licenseData;
            using (TextReader reader = new StringReader(inputXML))
            {
                licenseData = (SBNCreateProgramAccountResponse1)serializer.Deserialize(reader);
                _logger.LogDebug(inputXML);
            }


            string licenceNumber = OneStopUtils.GetLicenceNumberFromPartnerNote(licenseData.header.partnerNote);
            _logger.LogInformation($"Getting licence with number of {licenceNumber}");

            // Get licence from dynamics
            var filter = $"adoxio_licencenumber eq '{licenceNumber}'";
            MicrosoftDynamicsCRMadoxioLicences licence = _dynamicsClient.Licenceses.Get(filter: filter).Value.FirstOrDefault();
            if (licence == null)
            {
                _logger.LogInformation("licence is null - returning 400.");
                httpStatusCode = "400";
            }
            else
            {
                _logger.LogInformation($"Licence record retrieved from Dynamics.");
                //save the program account number to dynamics
                var businessProgramAccountNumber = licenseData.body.businessProgramAccountNumber.businessProgramAccountReferenceNumber;
                MicrosoftDynamicsCRMadoxioLicences pathLicence = new MicrosoftDynamicsCRMadoxioLicences()
                {
                    AdoxioBusinessprogramaccountreferencenumber = businessProgramAccountNumber
                };
                _logger.LogInformation($"Sending update to Dynamics for BusinessProgramAccountNumber.");
                try
                {
                    _dynamicsClient.Licenceses.Update(licence.AdoxioLicencesid, pathLicence);
                    _logger.LogInformation($"Updated Licence record {licence.AdoxioLicencesid} to {businessProgramAccountNumber}");
                }
                catch (HttpOperationException odee)
                {
                    _logger.LogError("Error updating Licence {licence.AdoxioLicencesid}");
                    _logger.LogDebug(odee, "Error updating Licence {licence.AdoxioLicencesid}");
                    // fail if we can't get results.
                    throw (odee);
                }

                //Trigger the Send ProgramAccountDetailsBroadcast Message                
                BackgroundJob.Enqueue(() => new OneStopUtils(Configuration, _logger).SendProgramAccountDetailsBroadcastMessageREST(null, licence.AdoxioLicencesid));

                _logger.LogInformation("send program account details broadcast done.");
            }

            return httpStatusCode;
            
        }

        private string HandleSBNErrorNotification(string inputXML)
        {
            string result = "200";
            // deserialize the inputXML
            var serializer = new XmlSerializer(typeof(SBNErrorNotification1));
            SBNErrorNotification1 errorNotification;

            using (TextReader reader = new StringReader(inputXML))
            {
                errorNotification = (SBNErrorNotification1)serializer.Deserialize(reader);                
            }
            

            // check to see if it is simply a problem with an old account number.
            if (errorNotification.body.validationErrors[0].errorMessageNumber.Equals("11845")) // Transaction not allowed - Duplicate Client event exists )
            {
                _logger.LogError($"Received error notification for record with partner note {errorNotification.header.partnerNote}");
                _logger.LogDebug(inputXML);

                _logger.LogError("****************************************************");
                _logger.LogError("CRA has rejected the message due to an incorrect business number.  The business in question may have had multiple business numbers in the past and the number in the record is no longer valid.  Please correct the business number.");
                _logger.LogError("****************************************************");                

            }
            else if (errorNotification.body.validationErrors[0].errorMessageNumber.Equals("11409")) // Old account number.               
            {
                _logger.LogInformation("Error is old account number is already associated with another account.  Retrying.");
                // retry the request with a higher increment.

                string licenceGuid = OneStopUtils.GetGuidFromPartnerNote(errorNotification.header.partnerNote);
                int currentSuffix = OneStopUtils.GetSuffixFromPartnerNote(errorNotification.header.partnerNote, _logger);

                // sanity check
                if (currentSuffix < 50)
                {
                    currentSuffix++;
                    _logger.LogInformation($"Starting resend of licence creation message, with new value of {currentSuffix}");
                    BackgroundJob.Schedule(() => new OneStopUtils(Configuration, _logger).SendLicenceCreationMessageREST(null, licenceGuid, currentSuffix.ToString("D3"))// zero pad 3 digit.
                    , TimeSpan.FromSeconds(30)); // Try again after 30 seconds
                }                
                else
                {
                    _logger.LogInformation($"Skipping resend of licence creation message as there have been too many tries({currentSuffix})");
                    _logger.LogError($"Received error notification for record with partner note {errorNotification.header.partnerNote}");
                    _logger.LogDebug(inputXML);
                }
            }
            else
            {
                _logger.LogError($"Received error notification for record with partner note {errorNotification.header.partnerNote}");
                _logger.LogDebug(inputXML);
            }

            return result;

        }


        public string receiveFromHub(string inputXML)
        {
            string result = "200";
            _logger.LogInformation($">>>> Reached receiveFromHub method: { DateTime.Now.ToString() }");

            if (string.IsNullOrEmpty(inputXML))
            {
                _logger.LogInformation("inputXML is empty - returning 400.");
                return "400";
            }

            try
            {
                // sanitize inputXML.
                inputXML = inputXML.Trim();                

                // determine the type of XML.
                string rootNodeName = GetRootNodeName(inputXML);

                _logger.LogInformation("ONESTOP ReceiveFromHub Message {rootNodeName} {inputXML}");

                switch (rootNodeName)
                {
                    case "SBNCreateProgramAccountResponse":
                        result = HandleSBNCreateProgramAccountResponse(inputXML);
                        break;
                    case "SBNErrorNotification":
                        result = HandleSBNErrorNotification(inputXML);
                        break;
                    default:
                        _logger.LogInformation($"Unknown Root Node encountered: {rootNodeName}");
                        break;
                }


                

            }
            catch (Exception ex)
            {
                _logger.LogError("Exception occured during processing of SOAP message");
                _logger.LogError(ex.Message);
                return "500";
            }

            return result;

        }
    }


    [ServiceContract]
    public interface IReceiveFromHubService
    {
        [OperationContract]
        string receiveFromHub(string inputXML);
    }
}
