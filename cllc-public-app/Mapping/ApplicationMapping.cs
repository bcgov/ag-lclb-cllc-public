﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gov.Lclb.Cllb.Public.Mapping
{
    public class ApplicationMapping : FieldMap
    {
        
        public ApplicationMapping()
        {
            fieldMap = new Dictionary<string, string>
            {
                // catering fields
                { "adoxio_previouslicenceapplication","previousApplication" },
                { "adoxio_previouslicenceapplicationdetails","previousApplicationDetails" },
                { "adoxio_ruralagencystoreappointment","ruralAgencyStoreAppointment" },
                { "adoxio_liquorindustryconnections","liquorIndustryConnections" },
                { "adoxio_liquorindustryconnectionsdetails","liquorIndustryConnectionsDetails" },                
                { "adoxio_otherbusinessesatthesamelocation","otherBusinesses"},
                { "adoxio_otherbusinesssamelocationdetails", "otherBusinessesDetails" },


                {"adoxio_name","name" },
                {"adoxio_establishmentpropsedname","establishmentName" },
                {"adoxio_establishmentaddressstreet", "establishmentAddressStreet" },
                {"adoxio_establishmentaddresscity","establishmentAddressCity" },
                {"adoxio_establishmentaddresspostalcode","establishmentAddressPostalCode" },
                {"adoxio_establishmentparcelid","establishmentParcelId" },
                {"adoxio_establishmentphone","establishmentPhone" },
                {"adoxio_establishmentemail","establishmentEmail" },
                {"adoxio_contactpersonfirstname","contactPersonFirstName"},
                {"adoxio_contactpersonlastname","contactPersonLastName" },
                {"adoxio_role","contactPersonRole"},
                {"adoxio_email", "contactPersonEmail"},
                {"adoxio_contactpersonphone", "contactPersonPhone"},
                {"adoxio_authorizedtosubmit", "authorizedToSubmit"},
                {"adoxio_signatureagreement", "signatureAgreement"},
                {"adoxio_additionalpropertyinformation", "additionalPropertyInformation"},
                {"adoxio_federalproducernames", "federalProducerNames"},
                {"adoxio_renewalcriminaloffencecheck", "renewalCriminalOffenceCheck"},
                {"adoxio_renewalunreportedsaleofbusiness", "renewalUnreportedSaleOfBusiness"},
                {"adoxio_renewalbusinesstype", "renewalBusinessType"},
                {"adoxio_renewaltiedhouse", "renewalTiedhouse"},
                {"adoxio_renewalorgleadership", "renewalOrgLeadership"},
                {"adoxio_renewalkeypersonnel", "renewalkeypersonnel"},
                {"adoxio_renewalshareholders", "renewalShareholders"},
                {"adoxio_renewaloutstandingfines", "renewalOutstandingFines"},
                {"adoxio_renewalbranding", "renewalBranding"},
                {"adoxio_renewalsignage", "renewalSignage"},
                {"adoxio_renewalestablishmentaddress", "renewalEstablishmentAddress"},
                {"adoxio_renewalvalidinterest", "renewalValidInterest"},
                {"adoxio_renewalzoning", "renewalZoning"},
                {"adoxio_renewalfloorplan", "renewalFloorPlan"},
                {"adoxio_renewalsitemap", "renewalSiteMap"},
                {"adoxio_renewaltiedhousefederalinterest", "tiedhouseFederalInterest"},
                {"adoxio_description1", "description1"},

                //store opening
                {"adoxio_isreadyworkers", "isReadyWorkers"},
                {"adoxio_isreadynamebranding", "isReadyNameBranding"},
                {"adoxio_isreadydisplays", "isReadyDisplays"},
                {"adoxio_isreadyintruderalarm", "isReadyIntruderAlarm"},
                {"adoxio_isreadyfirealarm", "isReadyFireAlarm"},
                {"adoxio_isreadylockedcases", "isReadyLockedCases"},
                {"adoxio_isreadylockedstorage", "isReadyLockedStorage"},
                {"adoxio_isreadyperimeter", "isReadyPerimeter"},
                {"adoxio_Isreadyretailarea", "isReadyRetailArea"},
                {"adoxio_isreadystorage", "isReadyStorage"},
                {"adoxio_isreadyentranceexit", "isReadyExtranceExit"},
                {"adoxio_isreadysurveillancenotice", "isReadySurveillanceNotice"},
                {"adoxio_isreadyproductnotvisibleoutside", "isReadyProductNotVisibleOutside"},
                {"adoxio_establishmentopeningdate", "establishmentopeningdate"},
                {"adoxio_isreadyvalidinterest", "isReadyValidInterest"},

                {"adoxio_applicanttype", "applicantType"},

                // manufacturer fields.

                { "adoxio_ispackaging", "isPackaging" },
                { "adoxio_mfgpipedinproduct", "mfgPipedInProduct" },
                { "adoxio_mfgbrewpubonsite", "mfgBrewPubOnSite"},

                // manufacturer structural change fields

                { "adoxio_patiocompdescription", "patioCompDescription" },
                { "adoxio_patiolocationdescription", "patioLocationDescription" },
                { "adoxio_patioaccessdescription", "patioAccessDescription" },
                { "adoxio_patioisliquorcarried", "patioIsLiquorCarried" },
                { "adoxio_patioliquorcarrieddescription", "patioLiquorCarriedDescription" },
                { "adoxio_patioaccesscontroldescription", "patioAccessControlDescription" },
                { "adoxio_locatedabovedescription", "locatedAboveDescription" },
                { "adoxio_patioservicebar", "patioServiceBar" }

        };
        }
    }
}
