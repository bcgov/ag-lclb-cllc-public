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
    /// Microsoft.Dynamics.CRM.adoxio_investigationreactivationhistory
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioInvestigationreactivationhistory
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioInvestigationreactivationhistory class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioInvestigationreactivationhistory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioInvestigationreactivationhistory class.
        /// </summary>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="adoxioName">The name of the custom entity.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="adoxioInvestigationreactivationhistoryid">Unique
        /// identifier for entity instances</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="statecode">Status of the Investigation Reactivation
        /// History</param>
        /// <param name="statuscode">Reason for the status of the Investigation
        /// Reactivation History</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="_owneridValue">Owner Id</param>
        /// <param name="versionnumber">Version Number</param>
        public MicrosoftDynamicsCRMadoxioInvestigationreactivationhistory(string adoxioReactivationnotes = default(string), string _modifiedonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), string _owningbusinessunitValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string adoxioName = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? adoxioReactivatedate = default(System.DateTimeOffset?), string adoxioInvestigationreactivationhistoryid = default(string), string _modifiedbyValue = default(string), string _adoxioReactivatedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owninguserValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? statecode = default(int?), int? statuscode = default(int?), string _adoxioInvestigationenforcementValue = default(string), string _createdbyValue = default(string), int? timezoneruleversionnumber = default(int?), int? importsequencenumber = default(int?), string _owningteamValue = default(string), string _owneridValue = default(string), string versionnumber = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioInvestigationreactivationhistorySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioInvestigationreactivationhistoryDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioInvestigationreactivationhistoryDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioInvestigationreactivationhistoryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioInvestigationreactivationhistoryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioComplianceinvestigation adoxioInvestigationEnforcement = default(MicrosoftDynamicsCRMadoxioComplianceinvestigation), MicrosoftDynamicsCRMsystemuser adoxioReactivatedBy = default(MicrosoftDynamicsCRMsystemuser))
        {
            AdoxioReactivationnotes = adoxioReactivationnotes;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Overriddencreatedon = overriddencreatedon;
            AdoxioName = adoxioName;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioReactivatedate = adoxioReactivatedate;
            AdoxioInvestigationreactivationhistoryid = adoxioInvestigationreactivationhistoryid;
            this._modifiedbyValue = _modifiedbyValue;
            this._adoxioReactivatedbyValue = _adoxioReactivatedbyValue;
            Modifiedon = modifiedon;
            this._owninguserValue = _owninguserValue;
            Createdon = createdon;
            Statecode = statecode;
            Statuscode = statuscode;
            this._adoxioInvestigationenforcementValue = _adoxioInvestigationenforcementValue;
            this._createdbyValue = _createdbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Importsequencenumber = importsequencenumber;
            this._owningteamValue = _owningteamValue;
            this._owneridValue = _owneridValue;
            Versionnumber = versionnumber;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioInvestigationreactivationhistorySyncErrors = adoxioInvestigationreactivationhistorySyncErrors;
            AdoxioInvestigationreactivationhistoryDuplicateMatchingRecord = adoxioInvestigationreactivationhistoryDuplicateMatchingRecord;
            AdoxioInvestigationreactivationhistoryDuplicateBaseRecord = adoxioInvestigationreactivationhistoryDuplicateBaseRecord;
            AdoxioInvestigationreactivationhistoryAsyncOperations = adoxioInvestigationreactivationhistoryAsyncOperations;
            AdoxioInvestigationreactivationhistoryBulkDeleteFailures = adoxioInvestigationreactivationhistoryBulkDeleteFailures;
            AdoxioInvestigationEnforcement = adoxioInvestigationEnforcement;
            AdoxioReactivatedBy = adoxioReactivatedBy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_reactivationnotes")]
        public string AdoxioReactivationnotes { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_reactivatedate")]
        public System.DateTimeOffset? AdoxioReactivatedate { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationreactivationhistoryid")]
        public string AdoxioInvestigationreactivationhistoryid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_reactivatedby_value")]
        public string _adoxioReactivatedbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets status of the Investigation Reactivation History
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Investigation
        /// Reactivation History
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_investigationenforcement_value")]
        public string _adoxioInvestigationenforcementValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets owner Id
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_investigationreactivationhistory_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioInvestigationreactivationhistorySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationreactivationhistory_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioInvestigationreactivationhistoryDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationreactivationhistory_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioInvestigationreactivationhistoryDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationreactivationhistory_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioInvestigationreactivationhistoryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationreactivationhistory_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioInvestigationreactivationhistoryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_InvestigationEnforcement")]
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation AdoxioInvestigationEnforcement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ReactivatedBy")]
        public MicrosoftDynamicsCRMsystemuser AdoxioReactivatedBy { get; set; }

    }
}
