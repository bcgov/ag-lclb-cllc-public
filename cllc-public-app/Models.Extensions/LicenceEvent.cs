using Gov.Lclb.Cllb.Interfaces.Models;
using Gov.Lclb.Cllb.Interfaces;
using Gov.Lclb.Cllb.Public.ViewModels;
using Gov.Lclb.Cllb.Public.Utils;
using System.Collections.Generic;

namespace Gov.Lclb.Cllb.Public.Models
{
    /// <summary>
    /// ViewModel transforms.
    /// </summary>
    public static class LicenceEventExtensions
    {
        public static EventClass DetermineEventClass(this LicenceEvent item, bool alwaysAuthorization)
        {
            bool isHighRisk = false;

            // Attendance > 500
            int maxAttendance = item.MaxAttendance != null ? (int)item.MaxAttendance : 0;
            int maxStaffAttendance = item.MaxStaffAttendance != null ? (int)item.MaxStaffAttendance : 0;
            if (maxAttendance + maxStaffAttendance >= 500) {
                isHighRisk = true;
            }

            // Location is outdoors
            // int? location = item.SpecificLocation;
            if (item.SpecificLocation == SpecificLocation.Outdoors || item.SpecificLocation == SpecificLocation.Both) {
                isHighRisk = true;
            }

            // liquor service > 2 hours (but not community event)
            if (item.EventType != EventType.Community) {
                item.Schedules?.ForEach((schedule) => {
                    System.TimeSpan? timeSpan = schedule.ServiceEndDateTime - schedule.ServiceStartDateTime;
                    if (timeSpan.HasValue && timeSpan.Value.Hours > 2)
                    {
                        isHighRisk = true;
                    }
                });
            }

            if (isHighRisk || alwaysAuthorization) {
                return EventClass.Authorization;
            }
            return EventClass.Notice;
        }

        // Converts a dynamics entity into a view model
        public static ViewModels.LicenceEvent ToViewModel(this MicrosoftDynamicsCRMadoxioEvent item, IDynamicsClient dynamicsClient)
        {
            ViewModels.LicenceEvent result = null;
            if (item != null)
            {
                result = new ViewModels.LicenceEvent();
                if (item.AdoxioEventid != null)
                {
                    result.Id = item.AdoxioEventid;
                }
                result.Status = (LicenceEventStatus?)item.Statuscode;
                result.Name = item.AdoxioName;
                result.StartDate = item.AdoxioStartdate;
                result.EndDate = item.AdoxioEnddate;
                result.VenueDescription = item.AdoxioVenuenamedescription;
                result.AdditionalLocationInformation = item.AdoxioAdditionallocationinfo;
                result.FoodService = (FoodService?)item.AdoxioFoodservice;
                result.FoodServiceDescription = item.AdoxioFoodservicedescription;
                result.Entertainment = (Entertainment?)item.AdoxioEntertainment;
                result.EntertainmentDescription = item.AdoxioEntertainmentdescription;
                result.ContactPhone = item.AdoxioContactphonenumber;
                result.ExternalId = item.AdoxioExternalid;
                result.ContactName = item.AdoxioContactname;
                result.ContactEmail = item.AdoxioContactemail;
                result.EventNumber = item.AdoxioEventnumber;
                result.ClientHostname = item.AdoxioClienthostname;
                result.EventType = (EventType?)item.AdoxioEventtype;
                result.EventTypeDescription = item.AdoxioEventdescription;
                result.ImportSequenceNumber = item.Importsequencenumber;
                result.SpecificLocation = (SpecificLocation?)item.AdoxioSpecificlocation;
                result.EventClass = (EventClass?)item.AdoxioClass;
                result.MaxAttendance = item.AdoxioMaxattendance;
                result.MaxStaffAttendance = item.AdoxioMaxstaffattendance;
                result.MinorsAttending = item.AdoxioAttendanceminors;
                result.CommunityApproval = item.AdoxioCommunityapproval;
                result.NotifyEventInspector = item.AdoxioNotifyeventinspector;
                result.LicenceId = item._adoxioLicenceValue;
                result.AccountId = item._adoxioAccountValue;
                result.Street1 = item.AdoxioStreet1;
                result.Street2 = item.AdoxioStreet2;
                result.City = item.AdoxioCity;
                result.Province = item.AdoxioProvince;
                result.PostalCode = item.AdoxioPostalcode;
                result.ModifiedOn = item.Modifiedon;
                result.Schedules = new List<LicenceEventSchedule>();
                // Security Plan
                result.SecurityPlanRequested = item.AdoxioRequestsafetysecurityplan;
                result.EventLiquorLayout = item.AdoxioEventliquorlayout;
                result.DailyEventAttendees = item.AdoxioNumberdailyeventattendees;
                result.DailyMinorAttendees = item.AdoxioNumberdailyminorattendees;
                result.OccupantLoad = item.AdoxioEventoccupantload;
                result.OccupantLoadAvailable = item.AdoxioIseventloadavailable;
                result.OccupantLoadServiceArea = item.AdoxioEventoccupantloadservicesarea;
                result.OccupantLoadServiceAreaAvailable = item.AdoxioIsservicearealoadavailable;
                result.ServiceAreaControlledDetails = item.AdoxioEventliquorcontainment;
                result.StaffingManagers = item.AdoxioEventstaffingmanagers;
                result.StaffingBartenders = item.AdoxioEventstaffingbartenders;
                result.StaffingServers = item.AdoxioEventstaffingservers;
                result.SecurityPersonnel = item.AdoxioSecuritycompanysummary;
                result.SecurityPersonnelThroughCompany = item.AdoxioSecuritypersonnelnumberhired;
                result.SecurityCompanyName = item.AdoxioSecuritycompanyname;
                result.SecurityCompanyAddress = item.AdoxioSecuritycompanystreet;
                result.SecurityCompanyCity = item.AdoxioSecuritycompanycity;
                result.SecurityCompanyPostalCode = item.AdoxioSecuritycompanypostal;
                result.SecurityCompanyContactPerson = item.AdoxioSecuritycompanycontactname;
                result.SecurityCompanyPhoneNumber = item.AdoxioSecuritycompanycontactphone;
                result.SecurityCompanyEmail = item.AdoxioSecuritycompanycontactemail;
                result.SecurityPoliceOfficerSummary = item.AdoxioPoliceofficersummary;
                result.SafeAndResponsibleMinorsNotAttending = item.AdoxioIsminorsattending;
                result.SafeAndResponsibleLiquorAreaControlled = item.AdoxioIsliquorareacontrolled;
                result.SafeAndResponsibleLiquorAreaControlledDescription = item.AdoxioLiquorareacontrolleddetails;
                result.SafeAndResponsibleMandatoryID = item.AdoxioIstwopiecesidrequired;
                result.SafeAndResponsibleSignsAdvisingMinors = item.AdoxioIssignsadvisingminors;
                result.SafeAndResponsibleMinorsOther = item.AdoxioIsotherminorssafety;
                result.SafeAndResponsibleMinorsOtherDescription = item.AdoxioIsotherminorssafetydetails;
                result.SafeAndResponsibleSignsAdvisingRemoval = item.AdoxioIssignsintoxicatedpersons;
                result.SafeAndResponsibleSignsAdvisingTwoDrink = item.AdoxioIssignstwodrinkmax;
                result.SafeAndResponsibleOverConsumptionOther = item.AdoxioIsotherconsumptionsafety;
                result.SafeAndResponsibleOverConsumptionOtherDescription = item.AdoxioIsotherconsumptionsafetydetails;
                result.SafeAndResponsibleReadAppendix2 = item.AdoxioIsdisturbanceappendix2;
                result.SafeAndResponsibleDisturbancesOther = item.AdoxioIsotherdisturbance;
                result.SafeAndResponsibleDisturbancesOtherDescription = item.AdoxioIsotherdisturbancedetails;
                result.SafeAndResponsibleAdditionalSafetyMeasures = item.AdoxioAdditionalsafetydetails;
                result.SafeAndResponsibleServiceAreaSupervision = item.AdoxioServiceareaentrancesupervisiondetails;
                result.DeclarationIsAccurate = item.AdoxioIsdeclarationaccurate;
                result.SecurityPlanSubmitted = item.AdoxioSafetysecurityplanchangessubmitted;
                
            }

            MicrosoftDynamicsCRMadoxioEventscheduleCollection eventSchedules = dynamicsClient.GetEventSchedulesByEventId(result.Id);
            foreach (var schedule in eventSchedules.Value)
            {
                result.Schedules.Add(schedule.ToViewModel());
            }

            return result;
        }


        // Converts a view model into a dynamics entity
        public static void CopyValues(this MicrosoftDynamicsCRMadoxioEvent to, ViewModels.LicenceEvent from)
        {
            to.AdoxioEventid = from.Id;
            to.AdoxioName = from.Name;
            to.Statuscode = (int?)from.Status;
            to.AdoxioStartdate = from.StartDate;
            to.AdoxioEnddate = from.EndDate;
            to.AdoxioVenuenamedescription = from.VenueDescription;
            to.AdoxioAdditionallocationinfo = from.AdditionalLocationInformation;
            to.AdoxioFoodservice = (int?)from.FoodService;
            to.AdoxioFoodservicedescription = from.FoodServiceDescription;
            to.AdoxioEntertainment = (int?)from.Entertainment;
            to.AdoxioEntertainmentdescription = from.EntertainmentDescription;
            to.AdoxioContactphonenumber = from.ContactPhone;
            to.AdoxioContactname = from.ContactName;
            to.AdoxioExternalid = from.ExternalId;
            to.AdoxioContactemail = from.ContactEmail;
            to.AdoxioEventnumber = from.EventNumber;
            to.AdoxioClienthostname = from.ClientHostname;
            to.AdoxioEventtype = (int?)from.EventType;
            to.AdoxioEventdescription = from.EventTypeDescription;
            to.Importsequencenumber = from.ImportSequenceNumber;
            to.AdoxioSpecificlocation = (int?)from.SpecificLocation;
            to.AdoxioClass = (int?)from.EventClass;
            to.AdoxioMaxattendance = from.MaxAttendance;
            to.AdoxioMaxstaffattendance = from.MaxStaffAttendance;
            to.AdoxioAttendanceminors = from.MinorsAttending;
            to.AdoxioCommunityapproval = from.CommunityApproval;
            to.AdoxioNotifyeventinspector = from.NotifyEventInspector;
            to.AdoxioStreet1 = from.Street1;
            to.AdoxioStreet2 = from.Street2;
            to.AdoxioCity = from.City;
            to.AdoxioProvince = from.Province;
            to.AdoxioPostalcode = from.PostalCode;
            
            // Security Plan
            to.AdoxioRequestsafetysecurityplan = from.SecurityPlanRequested;
            to.AdoxioEventliquorlayout = from.EventLiquorLayout;
            to.AdoxioNumberdailyeventattendees = from.DailyEventAttendees;
            to.AdoxioNumberdailyminorattendees = from.DailyMinorAttendees;
            to.AdoxioEventoccupantload = from.OccupantLoad;
            to.AdoxioIseventloadavailable = from.OccupantLoadAvailable;
            to.AdoxioEventoccupantloadservicesarea = from.OccupantLoadServiceArea;
            to.AdoxioIsservicearealoadavailable = from.OccupantLoadServiceAreaAvailable;
            to.AdoxioEventliquorcontainment = from.ServiceAreaControlledDetails;
            to.AdoxioEventstaffingmanagers = from.StaffingManagers;
            to.AdoxioEventstaffingbartenders = from.StaffingBartenders;
            to.AdoxioEventstaffingservers = from.StaffingServers;
            to.AdoxioSecuritycompanysummary = from.SecurityPersonnel;
            to.AdoxioSecuritypersonnelnumberhired = from.SecurityPersonnelThroughCompany;
            to.AdoxioSecuritycompanyname = from.SecurityCompanyName;
            to.AdoxioSecuritycompanystreet = from.SecurityCompanyAddress;
            to.AdoxioSecuritycompanycity = from.SecurityCompanyCity;
            to.AdoxioSecuritycompanypostal = from.SecurityCompanyPostalCode;
            to.AdoxioSecuritycompanycontactname = from.SecurityCompanyContactPerson;
            to.AdoxioSecuritycompanycontactphone = from.SecurityCompanyPhoneNumber;
            to.AdoxioSecuritycompanycontactemail = from.SecurityCompanyEmail;
            to.AdoxioPoliceofficersummary = from.SecurityPoliceOfficerSummary;
            to.AdoxioIsminorsattending  = from.SafeAndResponsibleMinorsNotAttending;
            to.AdoxioIsliquorareacontrolled = from.SafeAndResponsibleLiquorAreaControlled;
            to.AdoxioLiquorareacontrolleddetails = from.SafeAndResponsibleLiquorAreaControlledDescription;
            to.AdoxioIstwopiecesidrequired = from.SafeAndResponsibleMandatoryID;
            to.AdoxioIssignsadvisingminors = from.SafeAndResponsibleSignsAdvisingMinors;
            to.AdoxioIsotherminorssafety = from.SafeAndResponsibleMinorsOther;
            to.AdoxioIsotherminorssafetydetails = from.SafeAndResponsibleMinorsOtherDescription;
            to.AdoxioIssignsintoxicatedpersons = from.SafeAndResponsibleSignsAdvisingRemoval;
            to.AdoxioIssignstwodrinkmax = from.SafeAndResponsibleSignsAdvisingTwoDrink;
            to.AdoxioIsotherconsumptionsafety = from.SafeAndResponsibleOverConsumptionOther;
            to.AdoxioIsotherconsumptionsafetydetails = from.SafeAndResponsibleOverConsumptionOtherDescription;
            to.AdoxioIsdisturbanceappendix2 = from.SafeAndResponsibleReadAppendix2;
            to.AdoxioIsotherdisturbance = from.SafeAndResponsibleDisturbancesOther;
            to.AdoxioIsotherdisturbancedetails = from.SafeAndResponsibleDisturbancesOtherDescription;
            to.AdoxioAdditionalsafetydetails = from.SafeAndResponsibleAdditionalSafetyMeasures;
            to.AdoxioServiceareaentrancesupervisiondetails = from.SafeAndResponsibleServiceAreaSupervision;
            to.AdoxioIsdeclarationaccurate = from.DeclarationIsAccurate;

            to.AdoxioSafetysecurityplanchangessubmitted = from.SecurityPlanSubmitted;
        }
    }
}
