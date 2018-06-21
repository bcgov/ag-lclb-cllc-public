// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMcalendar
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcalendar
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcalendar()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcalendar
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcalendar(IList<MicrosoftDynamicsCRMbusinessunit> businessUnitCalendar = default(IList<MicrosoftDynamicsCRMbusinessunit>), IList<MicrosoftDynamicsCRMannotation> calendarAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> calendarAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> calendarBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), string _businessunitidValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _holidayschedulecalendaridValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _organizationidValue = default(string), MicrosoftDynamicsCRMbusinessunit businessunitid = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMbookableresource> calendarBookableresources = default(IList<MicrosoftDynamicsCRMbookableresource>), IList<MicrosoftDynamicsCRMcalendarrule> calendarCalendarRules = default(IList<MicrosoftDynamicsCRMcalendarrule>), IList<MicrosoftDynamicsCRMcalendar> calendarCustomercalendarHolidaycalendar = default(IList<MicrosoftDynamicsCRMcalendar>), IList<MicrosoftDynamicsCRMequipment> calendarEquipment = default(IList<MicrosoftDynamicsCRMequipment>), IList<MicrosoftDynamicsCRMorganization> calendarOrganization = default(IList<MicrosoftDynamicsCRMorganization>), IList<MicrosoftDynamicsCRMservice> calendarServices = default(IList<MicrosoftDynamicsCRMservice>), IList<MicrosoftDynamicsCRMsystemuser> calendarSystemUsers = default(IList<MicrosoftDynamicsCRMsystemuser>), string calendarid = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string description = default(string), MicrosoftDynamicsCRMcalendar holidayschedulecalendarid = default(MicrosoftDynamicsCRMcalendar), IList<MicrosoftDynamicsCRMcalendarrule> innerCalendarCalendarRules = default(IList<MicrosoftDynamicsCRMcalendarrule>), bool? isshared = default(bool?), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string name = default(string), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), string primaryuserid = default(string), IList<MicrosoftDynamicsCRMsla> slabaseBusinesshoursid = default(IList<MicrosoftDynamicsCRMsla>), int? type = default(int?), object versionnumber = default(object))
        {
            BusinessUnitCalendar = businessUnitCalendar;
            CalendarAnnotation = calendarAnnotation;
            CalendarAsyncOperations = calendarAsyncOperations;
            CalendarBulkDeleteFailures = calendarBulkDeleteFailures;
            this._businessunitidValue = _businessunitidValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._holidayschedulecalendaridValue = _holidayschedulecalendaridValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._organizationidValue = _organizationidValue;
            Businessunitid = businessunitid;
            CalendarBookableresources = calendarBookableresources;
            CalendarCalendarRules = calendarCalendarRules;
            CalendarCustomercalendarHolidaycalendar = calendarCustomercalendarHolidaycalendar;
            CalendarEquipment = calendarEquipment;
            CalendarOrganization = calendarOrganization;
            CalendarServices = calendarServices;
            CalendarSystemUsers = calendarSystemUsers;
            Calendarid = calendarid;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Description = description;
            Holidayschedulecalendarid = holidayschedulecalendarid;
            InnerCalendarCalendarRules = innerCalendarCalendarRules;
            Isshared = isshared;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Name = name;
            Organizationid = organizationid;
            Primaryuserid = primaryuserid;
            SlabaseBusinesshoursid = slabaseBusinesshoursid;
            Type = type;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BusinessUnit_Calendar")]
        public IList<MicrosoftDynamicsCRMbusinessunit> BusinessUnitCalendar { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Calendar_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> CalendarAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Calendar_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CalendarAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Calendar_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CalendarBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_holidayschedulecalendarid_value")]
        public string _holidayschedulecalendaridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid")]
        public MicrosoftDynamicsCRMbusinessunit Businessunitid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendar_bookableresources")]
        public IList<MicrosoftDynamicsCRMbookableresource> CalendarBookableresources { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendar_calendar_rules")]
        public IList<MicrosoftDynamicsCRMcalendarrule> CalendarCalendarRules { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendar_customercalendar_holidaycalendar")]
        public IList<MicrosoftDynamicsCRMcalendar> CalendarCustomercalendarHolidaycalendar { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendar_equipment")]
        public IList<MicrosoftDynamicsCRMequipment> CalendarEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendar_organization")]
        public IList<MicrosoftDynamicsCRMorganization> CalendarOrganization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendar_services")]
        public IList<MicrosoftDynamicsCRMservice> CalendarServices { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendar_system_users")]
        public IList<MicrosoftDynamicsCRMsystemuser> CalendarSystemUsers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendarid")]
        public string Calendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "holidayschedulecalendarid")]
        public MicrosoftDynamicsCRMcalendar Holidayschedulecalendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inner_calendar_calendar_rules")]
        public IList<MicrosoftDynamicsCRMcalendarrule> InnerCalendarCalendarRules { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isshared")]
        public bool? Isshared { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryuserid")]
        public string Primaryuserid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slabase_businesshoursid")]
        public IList<MicrosoftDynamicsCRMsla> SlabaseBusinesshoursid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
