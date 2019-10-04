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

    /// <summary>
    /// bookableresourcebookingheader
    /// </summary>
    public partial class MicrosoftDynamicsCRMbookableresourcebookingheader
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresourcebookingheader class.
        /// </summary>
        public MicrosoftDynamicsCRMbookableresourcebookingheader()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresourcebookingheader class.
        /// </summary>
        public MicrosoftDynamicsCRMbookableresourcebookingheader(string _owningbusinessunitValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), int? statuscode = default(int?), string processid = default(string), string traversedpath = default(string), int? utcconversiontimezonecode = default(int?), string _createdonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _transactioncurrencyidValue = default(string), object exchangerate = default(object), string bookableresourcebookingheaderid = default(string), long? versionnumber = default(long?), int? statecode = default(int?), int? importsequencenumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string name = default(string), string stageid = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), string _modifiedbyValue = default(string), string _owneridValue = default(string), System.DateTimeOffset? starttime = default(System.DateTimeOffset?), int? duration = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? endtime = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), object ownerid = default(object), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> bookableresourcebookingheaderActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> bookableresourcebookingheaderAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> bookableresourcebookingheaderEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> bookableresourcebookingheaderFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> bookableresourcebookingheaderLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> bookableresourcebookingheaderPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> bookableresourcebookingheaderServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> bookableresourcebookingheaderTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> bookableresourcebookingheaderRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> bookableresourcebookingheaderSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourcebookingheaderDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourcebookingheaderDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMannotation> bookableresourcebookingheaderAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> bookableresourcebookingheaderAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bookableresourcebookingheaderBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMbookableresourcebooking> bookableresourcebookingheaderBookableresourcebookingHeader = default(IList<MicrosoftDynamicsCRMbookableresourcebooking>), IList<MicrosoftDynamicsCRMsyncerror> bookableResourceBookingHeaderSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> bookableresourcebookingheaderAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>))
        {
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Modifiedon = modifiedon;
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            Processid = processid;
            Traversedpath = traversedpath;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Exchangerate = exchangerate;
            Bookableresourcebookingheaderid = bookableresourcebookingheaderid;
            Versionnumber = versionnumber;
            Statecode = statecode;
            Importsequencenumber = importsequencenumber;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Name = name;
            Stageid = stageid;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._owneridValue = _owneridValue;
            Starttime = starttime;
            Duration = duration;
            Createdon = createdon;
            Endtime = endtime;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BookableresourcebookingheaderActivityPointers = bookableresourcebookingheaderActivityPointers;
            BookableresourcebookingheaderAppointments = bookableresourcebookingheaderAppointments;
            BookableresourcebookingheaderEmails = bookableresourcebookingheaderEmails;
            BookableresourcebookingheaderFaxes = bookableresourcebookingheaderFaxes;
            BookableresourcebookingheaderLetters = bookableresourcebookingheaderLetters;
            BookableresourcebookingheaderPhoneCalls = bookableresourcebookingheaderPhoneCalls;
            BookableresourcebookingheaderServiceAppointments = bookableresourcebookingheaderServiceAppointments;
            BookableresourcebookingheaderTasks = bookableresourcebookingheaderTasks;
            BookableresourcebookingheaderRecurringAppointmentMasters = bookableresourcebookingheaderRecurringAppointmentMasters;
            BookableresourcebookingheaderSocialActivities = bookableresourcebookingheaderSocialActivities;
            BookableresourcebookingheaderDuplicateMatchingRecord = bookableresourcebookingheaderDuplicateMatchingRecord;
            BookableresourcebookingheaderDuplicateBaseRecord = bookableresourcebookingheaderDuplicateBaseRecord;
            BookableresourcebookingheaderAnnotations = bookableresourcebookingheaderAnnotations;
            BookableresourcebookingheaderAsyncOperations = bookableresourcebookingheaderAsyncOperations;
            BookableresourcebookingheaderBulkDeleteFailures = bookableresourcebookingheaderBulkDeleteFailures;
            BookableresourcebookingheaderBookableresourcebookingHeader = bookableresourcebookingheaderBookableresourcebookingHeader;
            BookableResourceBookingHeaderSyncErrors = bookableResourceBookingHeaderSyncErrors;
            Transactioncurrencyid = transactioncurrencyid;
            BookableresourcebookingheaderAbsScheduledprocessexecutions = bookableresourcebookingheaderAbsScheduledprocessexecutions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheaderid")]
        public string Bookableresourcebookingheaderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "starttime")]
        public System.DateTimeOffset? Starttime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endtime")]
        public System.DateTimeOffset? Endtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public object Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> BookableresourcebookingheaderActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> BookableresourcebookingheaderAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_Emails")]
        public IList<MicrosoftDynamicsCRMemail> BookableresourcebookingheaderEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> BookableresourcebookingheaderFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_Letters")]
        public IList<MicrosoftDynamicsCRMletter> BookableresourcebookingheaderLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> BookableresourcebookingheaderPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> BookableresourcebookingheaderServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> BookableresourcebookingheaderTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> BookableresourcebookingheaderRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> BookableresourcebookingheaderSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourcebookingheaderDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourcebookingheaderDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> BookableresourcebookingheaderAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BookableresourcebookingheaderAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BookableresourcebookingheaderBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_bookableresourcebooking_Header")]
        public IList<MicrosoftDynamicsCRMbookableresourcebooking> BookableresourcebookingheaderBookableresourcebookingHeader { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BookableResourceBookingHeader_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BookableResourceBookingHeaderSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> BookableresourcebookingheaderAbsScheduledprocessexecutions { get; set; }

    }
}
