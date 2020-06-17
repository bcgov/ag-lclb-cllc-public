﻿using Gov.Lclb.Cllb.Interfaces;
using Gov.Lclb.Cllb.Interfaces.Models;
using Gov.Lclb.Cllb.Public.Utils;
using Gov.Lclb.Cllb.Public.ViewModels;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gov.Lclb.Cllb.Public.Models
{
    /// <summary>
    /// ViewModel transforms.
    /// </summary>
    public static class ApplicationExtensions
    {
        public static void CopyValues(this MicrosoftDynamicsCRMadoxioApplication to, ViewModels.Application from)
        {
            to.AdoxioName = from.Name;
            //to.Adoxio_jobnumber = from.jobNumber;            
            to.AdoxioEstablishmentpropsedname = from.EstablishmentName;
            to.AdoxioEstablishmentaddressstreet = from.EstablishmentAddressStreet;
            to.AdoxioEstablishmentaddresscity = from.EstablishmentAddressCity;
            to.AdoxioEstablishmentaddresspostalcode = from.EstablishmentAddressPostalCode;
            // 12-10-2019 - Removed the update to AdoxioAddressCity as the Dynamics workflow handles that.

            to.AdoxioEstablishmentparcelid = from.EstablishmentParcelId;
            to.AdoxioEstablishmentphone = from.EstablishmentPhone;
            to.AdoxioEstablishmentemail = from.EstablishmentEmail;

            to.AdoxioContactpersonfirstname = from.ContactPersonFirstName;
            to.AdoxioContactpersonlastname = from.ContactPersonLastName;
            to.AdoxioRole = from.ContactPersonRole;
            to.AdoxioEmail = from.ContactPersonEmail;
            to.AdoxioContactpersonphone = from.ContactPersonPhone;
            to.AdoxioAuthorizedtosubmit = from.AuthorizedToSubmit;
            to.AdoxioSignatureagreement = from.SignatureAgreement;
            to.AdoxioAdditionalpropertyinformation = from.AdditionalPropertyInformation;
            to.AdoxioFederalproducernames = from.FederalProducerNames;

            // standard service hours are 9 to 11, 7 days a week.
            if (
                from.ServiceHoursSundayOpen != ServiceHours.sh0900 ||
                from.ServiceHoursSundayClose != ServiceHours.sh2300 ||
                from.ServiceHoursMondayOpen != ServiceHours.sh0900 ||
                from.ServiceHoursMondayClose != ServiceHours.sh2300 ||
                from.ServiceHoursTuesdayOpen != ServiceHours.sh0900 ||
                from.ServiceHoursTuesdayClose != ServiceHours.sh2300 ||
                from.ServiceHoursWednesdayOpen != ServiceHours.sh0900 ||
                from.ServiceHoursWednesdayClose != ServiceHours.sh2300 ||
                from.ServiceHoursThursdayOpen != ServiceHours.sh0900 ||
                from.ServiceHoursThursdayClose != ServiceHours.sh2300 ||
                from.ServiceHoursFridayOpen != ServiceHours.sh0900 ||
                from.ServiceHoursFridayClose != ServiceHours.sh2300 ||
                from.ServiceHoursSaturdayOpen != ServiceHours.sh0900 ||
                from.ServiceHoursSaturdayClose != ServiceHours.sh2300

                )
            {
                to.AdoxioServicehoursstandardhours = false;
            }
            else
            {
                to.AdoxioServicehoursstandardhours = true;
            }

            to.AdoxioServicehoursmondayopen = (int?)from.ServiceHoursMondayOpen;
            to.AdoxioServicehoursmondayclose = (int?)from.ServiceHoursMondayClose;
            to.AdoxioServicehourstuesdayopen = (int?)from.ServiceHoursTuesdayOpen;
            to.AdoxioServicehourstuesdayclose = (int?)from.ServiceHoursTuesdayClose;
            to.AdoxioServicehourswednesdayopen = (int?)from.ServiceHoursWednesdayOpen;
            to.AdoxioServicehourswednesdayclose = (int?)from.ServiceHoursWednesdayClose;
            to.AdoxioServicehoursthursdayopen = (int?)from.ServiceHoursThursdayOpen;
            to.AdoxioServicehoursthursdayclose = (int?)from.ServiceHoursThursdayClose;
            to.AdoxioServicehoursfridayopen = (int?)from.ServiceHoursFridayOpen;
            to.AdoxioServicehoursfridayclose = (int?)from.ServiceHoursFridayClose;
            to.AdoxioServicehourssaturdayopen = (int?)from.ServiceHoursSaturdayOpen;
            to.AdoxioServicehourssaturdayclose = (int?)from.ServiceHoursSaturdayClose;
            to.AdoxioServicehourssundayopen = (int?)from.ServiceHoursSundayOpen;
            to.AdoxioServicehourssundayclose = (int?)from.ServiceHoursSundayClose;
            to.AdoxioInvoicetrigger = (int?)from.InvoiceTrigger;

            to.AdoxioRenewalcriminaloffencecheck = (int?)from.RenewalCriminalOffenceCheck;
            to.AdoxioRenewalunreportedsaleofbusiness = (int?)from.RenewalUnreportedSaleOfBusiness;
            to.AdoxioRenewalbusinesstype = (int?)from.RenewalBusinessType;
            to.AdoxioRenewaltiedhouse = (int?)from.RenewalTiedhouse;
            to.AdoxioRenewalorgleadership = (int?)from.RenewalOrgLeadership;
            to.AdoxioRenewalkeypersonnel = (int?)from.Renewalkeypersonnel;
            to.AdoxioRenewalshareholders = (int?)from.RenewalShareholders;
            to.AdoxioRenewaloutstandingfines = (int?)from.RenewalOutstandingFines;
            to.AdoxioRenewalbranding = (int?)from.RenewalBranding;
            to.AdoxioRenewalsignage = (int?)from.RenewalSignage;
            to.AdoxioRenewalestablishmentaddress = (int?)from.RenewalEstablishmentAddress;
            to.AdoxioRenewalvalidinterest = (int?)from.RenewalValidInterest;
            to.AdoxioRenewalzoning = (int?)from.RenewalZoning;
            to.AdoxioRenewalfloorplan = (int?)from.RenewalFloorPlan;
            to.AdoxioRenewalsitemap = (int?)from.RenewalSiteMap;
            to.AdoxioRenewaltiedhousefederalinterest = (int?)from.TiedhouseFederalInterest;
            to.AdoxioDescription1 = from.Description1;

            //store opening
            to.AdoxioIsreadyworkers = from.IsReadyWorkers;
            to.AdoxioIsreadynamebranding = from.IsReadyNameBranding;
            to.AdoxioIsreadydisplays = from.IsReadyDisplays;
            to.AdoxioIsreadyintruderalarm = from.IsReadyIntruderAlarm;
            to.AdoxioIsreadyfirealarm = from.IsReadyFireAlarm;
            to.AdoxioIsreadylockedcases = from.IsReadyLockedCases;
            to.AdoxioIsreadylockedstorage = from.IsReadyLockedStorage;
            to.AdoxioIsreadyperimeter = from.IsReadyPerimeter;
            to.AdoxioIsreadyretailarea = from.IsReadyRetailArea;
            to.AdoxioIsreadystorage = from.IsReadyStorage;
            to.AdoxioIsreadyentranceexit = from.IsReadyExtranceExit;
            to.AdoxioIsreadysurveillancenotice = from.IsReadySurveillanceNotice;
            to.AdoxioIsreadyproductnotvisibleoutside = from.IsReadyProductNotVisibleOutside;
            to.AdoxioEstablishmentopeningdate = from.Establishmentopeningdate;
            to.AdoxioIsreadyvalidinterest = from.IsReadyValidInterest;

            to.AdoxioAuthorizedtosubmit = from.AuthorizedToSubmit;
            to.AdoxioSignatureagreement = from.SignatureAgreement;

            to.AdoxioApplicanttype = (int?)from.ApplicantType;

            // catering fields
            to.AdoxioPreviouslicenceapplication = from.PreviousApplication;
            to.AdoxioPreviouslicenceapplicationdetails = from.PreviousApplicationDetails;
            to.AdoxioRuralagencystoreappointment = from.RuralAgencyStoreAppointment;
            to.AdoxioLiquorindustryconnections = from.LiquorIndustryConnections;
            to.AdoxioLiquorindustryconnectionsdetails = from.LiquorIndustryConnectionsDetails;
            to.AdoxioOtherbusinessesatthesamelocation = from.OtherBusinesses;
            to.AdoxioOtherbusinesssamelocationdetails = from.OtherBusinessesDetails;
            to.AdoxioIsapplicationcomplete = (int?)from.IsApplicationComplete;

            to.AdoxioRenewaldui = (int?)from.RenewalDUI;
            to.AdoxioRenewalthirdparty = (int?)from.RenewalThirdParty;

            //lg approval fields
            to.AdoxioLgnameofofficial = from.LGNameOfOfficial;
            to.AdoxioLgtitleposition = from.LGTitlePosition;
            to.AdoxioLgcontactphone = from.LGContactPhone;
            to.AdoxioLgcontactemail = from.LGContactEmail;
            to.AdoxioLgdecisionsubmissiondate = from.LGDecisionSubmissionDate;
            to.AdoxioLgapprovaldecision = (int?)from.LGApprovalDecision;

            // comment out this next line as it is causing all application updates to fail (moved to controller)
            //to.AdoxioApplicanttype = (int)Enum.ToObject(typeof(Gov.Lclb.Cllb.Public.ViewModels.Adoxio_applicanttypecodes), from.applicantType);

            //if (from.adoxioInvoiceTrigger == GeneralYesNo.Yes)
            //{
            //	to.AdoxioInvoicetrigger = 1;
            //}

            //var adoxio_licencetype = dynamicsClient.GetAdoxioLicencetypeByName(from.licenseType).Result;
            //to.AdoxioLicenceType = adoxio_licencetype;
            //to._adoxioLicencetypeValue = adoxio_licencetype.AdoxioLicencetypeid;

            //if (!String.IsNullOrEmpty(from.applicationStatus))
            //{
            //    to.Statuscode = int.Parse(from.applicationStatus);
            //}
            //else
            //{
            //    to.Statecode = null;
            //}
        }


        public static void CopyValues(this MicrosoftDynamicsCRMadoxioApplication to, ViewModels.CovidApplication from)
        {
            to.AdoxioName = from.Name;
            //to.Adoxio_jobnumber = from.jobNumber;            
            to.AdoxioEstablishmentpropsedname = from.EstablishmentName;
            to.AdoxioEstablishmentaddressstreet = from.EstablishmentAddressStreet;
            to.AdoxioEstablishmentaddresscity = from.EstablishmentAddressCity;
            to.AdoxioEstablishmentaddresspostalcode = from.EstablishmentAddressPostalCode;
            // 12-10-2019 - Removed the update to AdoxioAddressCity as the Dynamics workflow handles that.

            to.AdoxioEstablishmentparcelid = from.EstablishmentParcelId;
            to.AdoxioEstablishmentphone = from.EstablishmentPhone;
            to.AdoxioEstablishmentemail = from.EstablishmentEmail;

            to.AdoxioContactpersonfirstname = from.ContactPersonFirstName;
            to.AdoxioContactpersonlastname = from.ContactPersonLastName;
            to.AdoxioRole = from.ContactPersonRole;
            to.AdoxioEmail = from.ContactPersonEmail;
            to.AdoxioContactpersonphone = from.ContactPersonPhone;
            to.AdoxioAuthorizedtosubmit = from.AuthorizedToSubmit;
            to.AdoxioAdditionalpropertyinformation = from.AdditionalPropertyInformation;

            to.AdoxioDescription1 = from.Description1;

            //store opening


            to.AdoxioAuthorizedtosubmit = from.AuthorizedToSubmit;

            to.AdoxioApplicanttype = (int?)from.ApplicantType;

            // catering fields
            to.AdoxioIsapplicationcomplete = (int?)from.IsApplicationComplete;
        }

        public static void CopyValuesForCovidApplication(this MicrosoftDynamicsCRMadoxioApplication to, ViewModels.CovidApplication from)
        {
            to.CopyValues(from);

            to.AdoxioNameofapplicant = from.NameOfApplicant;

            /* 2020/5/15 - Copy values has a comment that says to not copy this fields because of a dynamics workflow
            * Including this fields for the covid application as the workflow should not be relevant ?
            */
            to.AdoxioAddressstreet = from.AddressStreet;
            to.AdoxioAddresscity = from.AddressCity;
            to.AdoxioAddresspostalcode = from.AddressPostalCode;
        }
        public static void CopyValuesForChangeOfLocation(this MicrosoftDynamicsCRMadoxioApplication to, MicrosoftDynamicsCRMadoxioLicences from, bool copyAddress)
        {
            // copy establishment information
            if (copyAddress)
            {
                // 12-10-2019 - Removed set to AdoxioAddressCity as it is set by Dynamics Workflow, not the portal                
                to.AdoxioEstablishmentaddressstreet = from.AdoxioEstablishmentaddressstreet;
                to.AdoxioEstablishmentaddresscity = from.AdoxioEstablishmentaddresscity;
                to.AdoxioEstablishmentaddresspostalcode = from.AdoxioEstablishmentaddresspostalcode;
            }

            if (from.AdoxioEstablishment != null)
            {
                to.AdoxioEstablishmentpropsedname = from.AdoxioEstablishment.AdoxioName;
                to.AdoxioEstablishmentemail = from.AdoxioEstablishment.AdoxioEmail;
                to.AdoxioEstablishmentphone = from.AdoxioEstablishment.AdoxioPhone;
                to.AdoxioEstablishmentparcelid = from.AdoxioEstablishment.AdoxioParcelid;
                to.AdoxioIsoninland = from.AdoxioEstablishment.AdoxioIsoninland;
                to.AdoxioPoliceJurisdictionId = from.AdoxioEstablishment.AdoxioPDJurisdiction;
                to.AdoxioLocalgovindigenousnationid = from.AdoxioEstablishment.AdoxioLGIN;
            }

        }

        public static MicrosoftDynamicsCRMadoxioLicencetype GetCachedLicenceType(string id, IDynamicsClient dynamicsClient, IMemoryCache memoryCache)
        {
            string cacheKey = CacheKeys.LicenceTypePrefix + id;
            if (!memoryCache.TryGetValue(cacheKey, out MicrosoftDynamicsCRMadoxioLicencetype result))
            {
                // Key not in cache, so get data.
                result = dynamicsClient.GetAdoxioLicencetypeById(id);
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromDays(365));
                // Save data in cache.
                memoryCache.Set(cacheKey, result, cacheEntryOptions);
            }

            return result;
        }

        /// <summary>
        /// Get the licence type
        /// </summary>
        /// <param name="application"></param>
        /// <param name="dynamicsClient"></param>
        /// <param name="memoryCache"></param>
        public static void PopulateLicenceType(this MicrosoftDynamicsCRMadoxioApplication application, IDynamicsClient dynamicsClient, IMemoryCache memoryCache)
        {
            if (application._adoxioLicencetypeValue != null)
            {
                application.AdoxioLicenceType = GetCachedLicenceType(application._adoxioLicencetypeValue, dynamicsClient, memoryCache);
            }

            if (application.AdoxioAssignedLicence != null && application.AdoxioAssignedLicence._adoxioLicencetypeValue != null)
            {
                application.AdoxioAssignedLicence.AdoxioLicenceType = GetCachedLicenceType(application.AdoxioAssignedLicence._adoxioLicencetypeValue, dynamicsClient, memoryCache);
            }
        }

        public async static Task<ViewModels.Application> ToViewModel(this MicrosoftDynamicsCRMadoxioApplication dynamicsApplication, IDynamicsClient dynamicsClient, ILogger logger)
        {
            ViewModels.Application applicationVM = new ViewModels.Application()
            {
                Name = dynamicsApplication.AdoxioName,
                JobNumber = dynamicsApplication.AdoxioJobnumber,
                //get establishment name and address
                EstablishmentName = dynamicsApplication.AdoxioEstablishmentpropsedname,
                EstablishmentAddressStreet = dynamicsApplication.AdoxioEstablishmentaddressstreet,
                EstablishmentAddressCity = dynamicsApplication.AdoxioEstablishmentaddresscity,
                EstablishmentAddressPostalCode = dynamicsApplication.AdoxioEstablishmentaddresspostalcode,
                EstablishmentAddress = dynamicsApplication.AdoxioEstablishmentaddressstreet
                                                    + ", " + dynamicsApplication.AdoxioEstablishmentaddresscity
                                                    + " " + dynamicsApplication.AdoxioEstablishmentaddresspostalcode,
                EstablishmentPhone = dynamicsApplication.AdoxioEstablishmentphone,
                EstablishmentEmail = dynamicsApplication.AdoxioEstablishmentemail,
                FederalProducerNames = dynamicsApplication.AdoxioFederalproducernames,
                IsApplicationComplete = (GeneralYesNo?)dynamicsApplication.AdoxioIsapplicationcomplete,

                ServicehHoursStandardHours = dynamicsApplication.AdoxioServicehoursstandardhours,
                ServiceHoursSundayOpen = (ServiceHours?)dynamicsApplication.AdoxioServicehourssundayopen,
                ServiceHoursSundayClose = (ServiceHours?)dynamicsApplication.AdoxioServicehourssundayclose,
                ServiceHoursMondayOpen = (ServiceHours?)dynamicsApplication.AdoxioServicehoursmondayopen,
                ServiceHoursMondayClose = (ServiceHours?)dynamicsApplication.AdoxioServicehoursmondayclose,
                ServiceHoursTuesdayOpen = (ServiceHours?)dynamicsApplication.AdoxioServicehourstuesdayopen,
                ServiceHoursTuesdayClose = (ServiceHours?)dynamicsApplication.AdoxioServicehourstuesdayclose,
                ServiceHoursWednesdayOpen = (ServiceHours?)dynamicsApplication.AdoxioServicehourswednesdayopen,
                ServiceHoursWednesdayClose = (ServiceHours?)dynamicsApplication.AdoxioServicehourswednesdayclose,
                ServiceHoursThursdayOpen = (ServiceHours?)dynamicsApplication.AdoxioServicehoursthursdayopen,
                ServiceHoursThursdayClose = (ServiceHours?)dynamicsApplication.AdoxioServicehoursthursdayclose,
                ServiceHoursFridayOpen = (ServiceHours?)dynamicsApplication.AdoxioServicehoursfridayopen,
                ServiceHoursFridayClose = (ServiceHours?)dynamicsApplication.AdoxioServicehoursfridayclose,
                ServiceHoursSaturdayOpen = (ServiceHours?)dynamicsApplication.AdoxioServicehourssaturdayopen,
                ServiceHoursSaturdayClose = (ServiceHours?)dynamicsApplication.AdoxioServicehourssaturdayclose,

                RenewalCriminalOffenceCheck = (ValueNotChanged?)dynamicsApplication.AdoxioRenewalcriminaloffencecheck,
                RenewalUnreportedSaleOfBusiness = (ValueNotChanged?)dynamicsApplication.AdoxioRenewalunreportedsaleofbusiness,
                RenewalBusinessType = (ValueNotChanged?)dynamicsApplication.AdoxioRenewalbusinesstype,
                RenewalTiedhouse = (ValueNotChanged?)dynamicsApplication.AdoxioRenewaltiedhouse,
                RenewalOrgLeadership = (ValueNotChanged?)dynamicsApplication.AdoxioRenewalorgleadership,
                Renewalkeypersonnel = (ValueNotChanged?)dynamicsApplication.AdoxioRenewalkeypersonnel,
                RenewalShareholders = (ValueNotChanged?)dynamicsApplication.AdoxioRenewalshareholders,
                RenewalOutstandingFines = (ValueNotChanged?)dynamicsApplication.AdoxioRenewaloutstandingfines,
                RenewalBranding = (ValueNotChanged?)dynamicsApplication.AdoxioRenewalbranding,
                RenewalSignage = (ValueNotChanged?)dynamicsApplication.AdoxioRenewalsignage,
                RenewalEstablishmentAddress = (ValueNotChanged?)dynamicsApplication.AdoxioRenewalestablishmentaddress,
                RenewalValidInterest = (ValueNotChanged?)dynamicsApplication.AdoxioRenewalvalidinterest,
                RenewalZoning = (ValueNotChanged?)dynamicsApplication.AdoxioRenewalzoning,
                RenewalFloorPlan = (ValueNotChanged?)dynamicsApplication.AdoxioRenewalfloorplan,
                RenewalSiteMap = (ValueNotChanged?)dynamicsApplication.AdoxioRenewalsitemap,
                TiedhouseFederalInterest = (ValueNotChanged?)dynamicsApplication.AdoxioRenewaltiedhousefederalinterest,
                RenewalDUI = (ValueNotChanged?)dynamicsApplication.AdoxioRenewaldui,
                RenewalThirdParty = (ValueNotChanged?)dynamicsApplication.AdoxioRenewalthirdparty,

                AuthorizedToSubmit = dynamicsApplication.AdoxioAuthorizedtosubmit,
                SignatureAgreement = dynamicsApplication.AdoxioSignatureagreement,

                LicenceFeeInvoicePaid = (dynamicsApplication.AdoxioLicencefeeinvoicepaid != null && dynamicsApplication.AdoxioLicencefeeinvoicepaid == true),

                // set a couple of read-only flags to indicate status
                IsPaid = (dynamicsApplication.AdoxioPaymentrecieved != null && (bool)dynamicsApplication.AdoxioPaymentrecieved),

                IndigenousNationId = dynamicsApplication._adoxioLocalgovindigenousnationidValue,
                PoliceJurisdictionId = dynamicsApplication._adoxioPolicejurisdictionidValue,

                //get parcel id
                EstablishmentParcelId = dynamicsApplication.AdoxioEstablishmentparcelid,

                //get additional property info
                AdditionalPropertyInformation = dynamicsApplication.AdoxioAdditionalpropertyinformation,
                AdoxioInvoiceId = dynamicsApplication._adoxioInvoiceValue,

                PaymentReceivedDate = dynamicsApplication.AdoxioPaymentreceiveddate,
                Description1 = dynamicsApplication.AdoxioDescription1,

                //get contact details
                ContactPersonFirstName = dynamicsApplication.AdoxioContactpersonfirstname,
                ContactPersonLastName = dynamicsApplication.AdoxioContactpersonlastname,
                ContactPersonRole = dynamicsApplication.AdoxioRole,
                ContactPersonEmail = dynamicsApplication.AdoxioEmail,
                ContactPersonPhone = dynamicsApplication.AdoxioContactpersonphone,

                //get record audit info
                CreatedOn = dynamicsApplication.Createdon,
                ModifiedOn = dynamicsApplication.Modifiedon,

                //store opening 
                IsReadyWorkers = dynamicsApplication.AdoxioIsreadyworkers,
                IsReadyNameBranding = dynamicsApplication.AdoxioIsreadynamebranding,
                IsReadyDisplays = dynamicsApplication.AdoxioIsreadydisplays,
                IsReadyIntruderAlarm = dynamicsApplication.AdoxioIsreadyintruderalarm,
                IsReadyFireAlarm = dynamicsApplication.AdoxioIsreadyfirealarm,
                IsReadyLockedCases = dynamicsApplication.AdoxioIsreadylockedcases,
                IsReadyLockedStorage = dynamicsApplication.AdoxioIsreadylockedstorage,
                IsReadyPerimeter = dynamicsApplication.AdoxioIsreadyperimeter,
                IsReadyRetailArea = dynamicsApplication.AdoxioIsreadyretailarea,
                IsReadyStorage = dynamicsApplication.AdoxioIsreadystorage,
                IsReadyExtranceExit = dynamicsApplication.AdoxioIsreadyentranceexit,
                IsReadySurveillanceNotice = dynamicsApplication.AdoxioIsreadysurveillancenotice,
                IsReadyProductNotVisibleOutside = dynamicsApplication.AdoxioIsreadyproductnotvisibleoutside,
                Establishmentopeningdate = dynamicsApplication.AdoxioEstablishmentopeningdate,
                IsReadyValidInterest = dynamicsApplication.AdoxioIsreadyvalidinterest,

                // LgInName
                LGNameOfOfficial = dynamicsApplication.AdoxioLgnameofofficial,
                LGTitlePosition = dynamicsApplication.AdoxioLgtitleposition,
                LGContactPhone = dynamicsApplication.AdoxioLgcontactphone,
                LGContactEmail = dynamicsApplication.AdoxioLgcontactemail,
                LGDecisionSubmissionDate = dynamicsApplication.AdoxioLgdecisionsubmissiondate,
                LgInName = dynamicsApplication?.AdoxioLocalgovindigenousnationid?.AdoxioName,
                LGApprovalDecision = (LGDecision?)dynamicsApplication.AdoxioLgapprovaldecision,

                // Catering fields.

                PreviousApplicationDetails = dynamicsApplication.AdoxioPreviouslicenceapplicationdetails,

                LiquorIndustryConnectionsDetails = dynamicsApplication.AdoxioLiquorindustryconnectionsdetails,

                OtherBusinessesDetails = dynamicsApplication.AdoxioOtherbusinesssamelocationdetails

            };

            // Catering yes / no fields
            if (dynamicsApplication.AdoxioPreviouslicenceapplication != null)
            {
                applicationVM.PreviousApplication = dynamicsApplication.AdoxioPreviouslicenceapplication;
            }

            if (dynamicsApplication.AdoxioRuralagencystoreappointment != null)
            {
                applicationVM.RuralAgencyStoreAppointment = dynamicsApplication.AdoxioRuralagencystoreappointment;
            }

            if (dynamicsApplication.AdoxioLiquorindustryconnections != null)
            {
                applicationVM.LiquorIndustryConnections = dynamicsApplication.AdoxioLiquorindustryconnections;
            }

            if (dynamicsApplication.AdoxioOtherbusinessesatthesamelocation != null)
            {
                applicationVM.OtherBusinesses = dynamicsApplication.AdoxioOtherbusinessesatthesamelocation;
            }


            // id
            if (dynamicsApplication.AdoxioApplicationid != null)
            {
                applicationVM.Id = dynamicsApplication.AdoxioApplicationid.ToString();
            }

            if (dynamicsApplication.Statuscode != null)
            {
                applicationVM.ApplicationStatus = (AdoxioApplicationStatusCodes)dynamicsApplication.Statuscode;
            }

            if (dynamicsApplication.AdoxioApplicanttype != null)
            {
                applicationVM.ApplicantType = (AdoxioApplicantTypeCodes)dynamicsApplication.AdoxioApplicanttype;
            }

            //get applying person from Contact entity
            if (dynamicsApplication._adoxioApplyingpersonValue != null)
            {
                Guid applyingPersonId = Guid.Parse(dynamicsApplication._adoxioApplyingpersonValue);
                var contact = await dynamicsClient.GetContactById(applyingPersonId);
                applicationVM.ApplyingPerson = contact.Fullname;
            }

            if (dynamicsApplication._adoxioApplicantValue != null)
            {
                var applicant = await dynamicsClient.GetAccountByIdAsync(Guid.Parse(dynamicsApplication._adoxioApplicantValue));
                applicationVM.Applicant = applicant.ToViewModel();
            }

            //get license type from Adoxio_licencetype entity
            if (dynamicsApplication._adoxioLicencetypeValue != null)
            {
                Guid adoxio_licencetypeId = Guid.Parse(dynamicsApplication._adoxioLicencetypeValue);
                var adoxio_licencetype = dynamicsClient.GetAdoxioLicencetypeById(adoxio_licencetypeId);
                applicationVM.LicenseType = adoxio_licencetype.AdoxioName;
            }

            if (dynamicsApplication.AdoxioAppchecklistfinaldecision != null)
            {
                applicationVM.AppChecklistFinalDecision = (AdoxioFinalDecisionCodes)dynamicsApplication.AdoxioAppchecklistfinaldecision;
            }

            //get payment info
            if (dynamicsApplication.AdoxioInvoicetrigger != null && dynamicsApplication.AdoxioInvoicetrigger == 1)
            {
                applicationVM.InvoiceTrigger = GeneralYesNo.Yes;
                applicationVM.IsSubmitted = true;
            }
            else
            {
                applicationVM.InvoiceTrigger = GeneralYesNo.No;
                applicationVM.IsSubmitted = false;
            }

            if (dynamicsApplication.AdoxioLicenceFeeInvoice != null)
            {
                applicationVM.LicenceFeeInvoice = dynamicsApplication.AdoxioLicenceFeeInvoice.ToViewModel();
            }

            if (dynamicsApplication.AdoxioAssignedLicence != null)
            {
                applicationVM.AssignedLicence = dynamicsApplication.AdoxioAssignedLicence.ToViewModel(dynamicsClient);
            }

            if (dynamicsApplication.AdoxioApplicationTypeId != null)
            {
                applicationVM.ApplicationType = dynamicsApplication.AdoxioApplicationTypeId.ToViewModel();

                if (!string.IsNullOrEmpty(applicationVM.ApplicationType.FormReference))
                {
                    applicationVM.ApplicationType.DynamicsForm = dynamicsClient.GetSystemformViewModel(logger, applicationVM.ApplicationType.FormReference);
                }
            }
            if (dynamicsApplication.AdoxioApplicationAdoxioTiedhouseconnectionApplication != null)
            {
                var tiedHouse = dynamicsApplication.AdoxioApplicationAdoxioTiedhouseconnectionApplication.FirstOrDefault();
                if (tiedHouse != null)
                {
                    applicationVM.TiedHouse = tiedHouse.ToViewModel();
                }
            }

            if(dynamicsApplication.AdoxioPoliceJurisdictionId != null){
                applicationVM.PoliceJurisdiction = dynamicsApplication.AdoxioPoliceJurisdictionId.ToViewModel();
            }

            if(dynamicsApplication.AdoxioLocalgovindigenousnationid != null){
                applicationVM.IndigenousNation = dynamicsApplication.AdoxioLocalgovindigenousnationid.ToViewModel();
            }

            applicationVM.PrevPaymentFailed = (dynamicsApplication._adoxioInvoiceValue != null) && (!applicationVM.IsSubmitted);

            return applicationVM;
        }


        public async static Task<ViewModels.CovidApplication> ToCovidViewModel(this MicrosoftDynamicsCRMadoxioApplication dynamicsApplication, IDynamicsClient dynamicsClient, ILogger logger)
        {
            ViewModels.CovidApplication applicationVM = new ViewModels.CovidApplication()
            {
                Name = dynamicsApplication.AdoxioName,
                JobNumber = dynamicsApplication.AdoxioJobnumber,
                //get establishment name and address
                EstablishmentName = dynamicsApplication.AdoxioEstablishmentpropsedname,
                EstablishmentAddressStreet = dynamicsApplication.AdoxioEstablishmentaddressstreet,
                EstablishmentAddressCity = dynamicsApplication.AdoxioEstablishmentaddresscity,
                EstablishmentAddressPostalCode = dynamicsApplication.AdoxioEstablishmentaddresspostalcode,
                EstablishmentAddress = dynamicsApplication.AdoxioEstablishmentaddressstreet
                                                    + ", " + dynamicsApplication.AdoxioEstablishmentaddresscity
                                                    + " " + dynamicsApplication.AdoxioEstablishmentaddresspostalcode,
                EstablishmentPhone = dynamicsApplication.AdoxioEstablishmentphone,
                EstablishmentEmail = dynamicsApplication.AdoxioEstablishmentemail,
                IsApplicationComplete = (GeneralYesNo?)dynamicsApplication.AdoxioIsapplicationcomplete,

                AddressStreet = dynamicsApplication.AdoxioAddressstreet,
                AddressCity = dynamicsApplication.AdoxioAddresscity,
                AddressPostalCode = dynamicsApplication.AdoxioAddresspostalcode,

                NameOfApplicant = dynamicsApplication.AdoxioNameofapplicant,



                AuthorizedToSubmit = dynamicsApplication.AdoxioAuthorizedtosubmit,

                //get parcel id
                EstablishmentParcelId = dynamicsApplication.AdoxioEstablishmentparcelid,

                //get additional property info
                AdditionalPropertyInformation = dynamicsApplication.AdoxioAdditionalpropertyinformation,
                AdoxioInvoiceId = dynamicsApplication._adoxioInvoiceValue,

                Description1 = dynamicsApplication.AdoxioDescription1,

                //get contact details
                ContactPersonFirstName = dynamicsApplication.AdoxioContactpersonfirstname,
                ContactPersonLastName = dynamicsApplication.AdoxioContactpersonlastname,
                ContactPersonRole = dynamicsApplication.AdoxioRole,
                ContactPersonEmail = dynamicsApplication.AdoxioEmail,
                ContactPersonPhone = dynamicsApplication.AdoxioContactpersonphone,

                //get record audit info
                CreatedOn = dynamicsApplication.Createdon,
                ModifiedOn = dynamicsApplication.Modifiedon,

                //store opening 

                // Catering fields.

            };



            // id
            if (dynamicsApplication.AdoxioApplicationid != null)
            {
                applicationVM.Id = dynamicsApplication.AdoxioApplicationid.ToString();
            }


            if (dynamicsApplication.AdoxioApplicanttype != null)
            {
                applicationVM.ApplicantType = (AdoxioApplicantTypeCodes)dynamicsApplication.AdoxioApplicanttype;
            }

            //get applying person from Contact entity
            if (dynamicsApplication._adoxioApplyingpersonValue != null)
            {
                Guid applyingPersonId = Guid.Parse(dynamicsApplication._adoxioApplyingpersonValue);
                var contact = await dynamicsClient.GetContactById(applyingPersonId);
                applicationVM.ApplyingPerson = contact.Fullname;
            }


            //get license type from Adoxio_licencetype entity
            if (dynamicsApplication._adoxioLicencetypeValue != null)
            {
                Guid adoxio_licencetypeId = Guid.Parse(dynamicsApplication._adoxioLicencetypeValue);
                var adoxio_licencetype = dynamicsClient.GetAdoxioLicencetypeById(adoxio_licencetypeId);
                applicationVM.LicenceType = adoxio_licencetype.AdoxioName;
            }




            if (dynamicsApplication.AdoxioApplicationTypeId != null)
            {
                applicationVM.ApplicationType = dynamicsApplication.AdoxioApplicationTypeId.ToViewModel();

                if (!string.IsNullOrEmpty(applicationVM.ApplicationType.FormReference))
                {
                    applicationVM.ApplicationType.DynamicsForm = dynamicsClient.GetSystemformViewModel(logger, applicationVM.ApplicationType.FormReference);
                }
            }

            return applicationVM;
        }


        public static ApplicationSummary ToSummaryViewModel(this MicrosoftDynamicsCRMadoxioApplication dynamicsApplication)
        {
            ApplicationSummary applicationSummary = new ViewModels.ApplicationSummary()
            {
                Name = dynamicsApplication.AdoxioName,
                JobNumber = dynamicsApplication.AdoxioJobnumber,
                //get establishment name and address
                EstablishmentName = dynamicsApplication.AdoxioEstablishmentpropsedname,
                LicenceId = dynamicsApplication._adoxioAssignedlicenceValue,
                IsPaid = (dynamicsApplication.AdoxioPaymentrecieved == true),
            };

            // id
            if (dynamicsApplication.AdoxioApplicationid != null)
            {
                applicationSummary.Id = dynamicsApplication.AdoxioApplicationid.ToString();
            }

            if (dynamicsApplication.Statuscode != null)
            {
                applicationSummary.ApplicationStatus = StatusUtility.GetTranslatedApplicationStatus(dynamicsApplication);
            }

            if (dynamicsApplication.AdoxioApplicationTypeId != null)
            {
                applicationSummary.ApplicationTypeName = dynamicsApplication.AdoxioApplicationTypeId.AdoxioName;
                applicationSummary.Portallabel = dynamicsApplication.AdoxioApplicationTypeId.AdoxioPortallabel;
                applicationSummary.ApplicationTypeCategory = (ApplicationTypeCategory?)dynamicsApplication.AdoxioApplicationTypeId.AdoxioCategory;
            }

            applicationSummary.IsIndigenousNation = (dynamicsApplication.AdoxioApplicanttype == (int)AdoxioApplicantTypeCodes.IndigenousNation);

            return applicationSummary;
        }
    }
}
