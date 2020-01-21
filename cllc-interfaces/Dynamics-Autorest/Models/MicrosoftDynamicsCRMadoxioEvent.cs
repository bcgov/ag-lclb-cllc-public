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
    /// Microsoft.Dynamics.CRM.adoxio_event
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioEvent
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMadoxioEvent
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioEvent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMadoxioEvent
        /// class.
        /// </summary>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="adoxioEventid">Unique identifier for entity
        /// instances</param>
        /// <param name="statecode">Status of the Event</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="_adoxioAccountValue">Licensee</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="statuscode">Reason for the status of the Event</param>
        /// <param name="_owneridValue">Owner Id</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="versionnumber">Version Number</param>
        /// <param name="adoxioName">The name of the custom entity.</param>
        public MicrosoftDynamicsCRMadoxioEvent(string _adoxioLicenceValue = default(string), string _adoxioInspectorValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owningteamValue = default(string), string adoxioVenuedescription = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? adoxioStartdate = default(System.DateTimeOffset?), string adoxioAdditionallocationinformation = default(string), string adoxioAddress = default(string), string adoxioFoodservicedescription = default(string), int? importsequencenumber = default(int?), bool? adoxioCommunityapproval = default(bool?), System.DateTimeOffset? adoxioEnddate = default(System.DateTimeOffset?), string adoxioEventid = default(string), string adoxioEntertainmentdescription = default(string), string adoxioContactphone = default(string), int? statecode = default(int?), string _createdbyValue = default(string), string adoxioExternalid = default(string), System.DateTimeOffset? adoxioDateoutcomed = default(System.DateTimeOffset?), string adoxioContactname = default(string), string adoxioContactemail = default(string), bool? adoxioNotifyeventinspector = default(bool?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _adoxioAccountValue = default(string), string adoxioOsSessionPk = default(string), string adoxioEventnumber = default(string), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), int? adoxioSpecificlocation = default(int?), string _owninguserValue = default(string), int? adoxioEventtype = default(int?), int? statuscode = default(int?), string _owneridValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? adoxioEntertainment = default(int?), string _createdonbehalfbyValue = default(string), int? adoxioClass = default(int?), string adoxioClienthostname = default(string), string versionnumber = default(string), string adoxioName = default(string), int? adoxioMaxattendance = default(int?), string adoxioEventtypedescription = default(string), int? adoxioFoodservice = default(int?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioEventSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioEventDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioEventDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioEventAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioEventBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioLicences adoxioLicence = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMsystemuser adoxioInspector = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMaccount adoxioAccount = default(MicrosoftDynamicsCRMaccount))
        {
            this._adoxioLicenceValue = _adoxioLicenceValue;
            this._adoxioInspectorValue = _adoxioInspectorValue;
            Modifiedon = modifiedon;
            this._owningteamValue = _owningteamValue;
            AdoxioVenuedescription = adoxioVenuedescription;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioStartdate = adoxioStartdate;
            AdoxioAdditionallocationinformation = adoxioAdditionallocationinformation;
            AdoxioAddress = adoxioAddress;
            AdoxioFoodservicedescription = adoxioFoodservicedescription;
            Importsequencenumber = importsequencenumber;
            AdoxioCommunityapproval = adoxioCommunityapproval;
            AdoxioEnddate = adoxioEnddate;
            AdoxioEventid = adoxioEventid;
            AdoxioEntertainmentdescription = adoxioEntertainmentdescription;
            AdoxioContactphone = adoxioContactphone;
            Statecode = statecode;
            this._createdbyValue = _createdbyValue;
            AdoxioExternalid = adoxioExternalid;
            AdoxioDateoutcomed = adoxioDateoutcomed;
            AdoxioContactname = adoxioContactname;
            AdoxioContactemail = adoxioContactemail;
            AdoxioNotifyeventinspector = adoxioNotifyeventinspector;
            Createdon = createdon;
            this._adoxioAccountValue = _adoxioAccountValue;
            AdoxioOsSessionPk = adoxioOsSessionPk;
            AdoxioEventnumber = adoxioEventnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioSpecificlocation = adoxioSpecificlocation;
            this._owninguserValue = _owninguserValue;
            AdoxioEventtype = adoxioEventtype;
            Statuscode = statuscode;
            this._owneridValue = _owneridValue;
            Overriddencreatedon = overriddencreatedon;
            AdoxioEntertainment = adoxioEntertainment;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioClass = adoxioClass;
            AdoxioClienthostname = adoxioClienthostname;
            Versionnumber = versionnumber;
            AdoxioName = adoxioName;
            AdoxioMaxattendance = adoxioMaxattendance;
            AdoxioEventtypedescription = adoxioEventtypedescription;
            AdoxioFoodservice = adoxioFoodservice;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioEventSyncErrors = adoxioEventSyncErrors;
            AdoxioEventDuplicateMatchingRecord = adoxioEventDuplicateMatchingRecord;
            AdoxioEventDuplicateBaseRecord = adoxioEventDuplicateBaseRecord;
            AdoxioEventAsyncOperations = adoxioEventAsyncOperations;
            AdoxioEventBulkDeleteFailures = adoxioEventBulkDeleteFailures;
            AdoxioLicence = adoxioLicence;
            AdoxioInspector = adoxioInspector;
            AdoxioAccount = adoxioAccount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licence_value")]
        public string _adoxioLicenceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_inspector_value")]
        public string _adoxioInspectorValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_venuedescription")]
        public string AdoxioVenuedescription { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_startdate")]
        public System.DateTimeOffset? AdoxioStartdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_additionallocationinformation")]
        public string AdoxioAdditionallocationinformation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_address")]
        public string AdoxioAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_foodservicedescription")]
        public string AdoxioFoodservicedescription { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_communityapproval")]
        public bool? AdoxioCommunityapproval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_enddate")]
        public System.DateTimeOffset? AdoxioEnddate { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_eventid")]
        public string AdoxioEventid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_entertainmentdescription")]
        public string AdoxioEntertainmentdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contactphone")]
        public string AdoxioContactphone { get; set; }

        /// <summary>
        /// Gets or sets status of the Event
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_externalid")]
        public string AdoxioExternalid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateoutcomed")]
        public System.DateTimeOffset? AdoxioDateoutcomed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contactname")]
        public string AdoxioContactname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contactemail")]
        public string AdoxioContactemail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_notifyeventinspector")]
        public bool? AdoxioNotifyeventinspector { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets licensee
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_account_value")]
        public string _adoxioAccountValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_os_session_pk")]
        public string AdoxioOsSessionPk { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_eventnumber")]
        public string AdoxioEventnumber { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_specificlocation")]
        public int? AdoxioSpecificlocation { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_eventtype")]
        public int? AdoxioEventtype { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Event
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets owner Id
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_entertainment")]
        public int? AdoxioEntertainment { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_class")]
        public int? AdoxioClass { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_clienthostname")]
        public string AdoxioClienthostname { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_maxattendance")]
        public int? AdoxioMaxattendance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_eventtypedescription")]
        public string AdoxioEventtypedescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_foodservice")]
        public int? AdoxioFoodservice { get; set; }

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
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_event_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioEventSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_event_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioEventDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_event_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioEventDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_event_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioEventAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_event_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioEventBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Licence")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioLicence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Inspector")]
        public MicrosoftDynamicsCRMsystemuser AdoxioInspector { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Account")]
        public MicrosoftDynamicsCRMaccount AdoxioAccount { get; set; }

    }
}
