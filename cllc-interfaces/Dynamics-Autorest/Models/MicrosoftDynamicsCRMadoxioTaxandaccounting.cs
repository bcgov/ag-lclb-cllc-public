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
    /// Microsoft.Dynamics.CRM.adoxio_taxandaccounting
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioTaxandaccounting
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTaxandaccounting class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioTaxandaccounting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTaxandaccounting class.
        /// </summary>
        /// <param name="statecode">Status of the Tax and Accounting</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="adoxioName">The name of the custom entity.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="versionnumber">Version Number</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="_owneridValue">Owner Id</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="statuscode">Reason for the status of the Tax and
        /// Accounting</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="adoxioTaxandaccountingid">Unique identifier for entity
        /// instances</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="_adoxioAccountidValue">Unique identifier for Account
        /// associated with Tax and Accounting.</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        public MicrosoftDynamicsCRMadoxioTaxandaccounting(int? adoxioTaxfilingtype = default(int?), int? statecode = default(int?), bool? adoxioIsaccountant = default(bool?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string adoxioName = default(string), int? timezoneruleversionnumber = default(int?), System.Guid? _owningbusinessunitValue = default(System.Guid?), string versionnumber = default(string), int? importsequencenumber = default(int?), System.Guid? _owneridValue = default(System.Guid?), string adoxioPhonenumber = default(string), bool? adoxioIsbookkeeper = default(bool?), System.Guid? _owningteamValue = default(System.Guid?), int? statuscode = default(int?), string adoxioEmail = default(string), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.Guid? adoxioTaxandaccountingid = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), System.Guid? _modifiedbyValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), int? adoxioRecordtype = default(int?), System.Guid? _adoxioAccountidValue = default(System.Guid?), System.Guid? _owninguserValue = default(System.Guid?), System.Guid? _createdbyValue = default(System.Guid?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioTaxandaccountingSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioTaxandaccountingDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioTaxandaccountingDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioTaxandaccountingAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioTaxandaccountingBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMaccount adoxioAccountId = default(MicrosoftDynamicsCRMaccount))
        {
            AdoxioTaxfilingtype = adoxioTaxfilingtype;
            Statecode = statecode;
            AdoxioIsaccountant = adoxioIsaccountant;
            Overriddencreatedon = overriddencreatedon;
            AdoxioName = adoxioName;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Versionnumber = versionnumber;
            Importsequencenumber = importsequencenumber;
            this._owneridValue = _owneridValue;
            AdoxioPhonenumber = adoxioPhonenumber;
            AdoxioIsbookkeeper = adoxioIsbookkeeper;
            this._owningteamValue = _owningteamValue;
            Statuscode = statuscode;
            AdoxioEmail = adoxioEmail;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioTaxandaccountingid = adoxioTaxandaccountingid;
            Modifiedon = modifiedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioRecordtype = adoxioRecordtype;
            this._adoxioAccountidValue = _adoxioAccountidValue;
            this._owninguserValue = _owninguserValue;
            this._createdbyValue = _createdbyValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioTaxandaccountingSyncErrors = adoxioTaxandaccountingSyncErrors;
            AdoxioTaxandaccountingDuplicateMatchingRecord = adoxioTaxandaccountingDuplicateMatchingRecord;
            AdoxioTaxandaccountingDuplicateBaseRecord = adoxioTaxandaccountingDuplicateBaseRecord;
            AdoxioTaxandaccountingAsyncOperations = adoxioTaxandaccountingAsyncOperations;
            AdoxioTaxandaccountingBulkDeleteFailures = adoxioTaxandaccountingBulkDeleteFailures;
            AdoxioAccountId = adoxioAccountId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_taxfilingtype")]
        public int? AdoxioTaxfilingtype { get; set; }

        /// <summary>
        /// Gets or sets status of the Tax and Accounting
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isaccountant")]
        public bool? AdoxioIsaccountant { get; set; }

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
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public System.Guid? _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets owner Id
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public System.Guid? _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_phonenumber")]
        public string AdoxioPhonenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isbookkeeper")]
        public bool? AdoxioIsbookkeeper { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public System.Guid? _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Tax and Accounting
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_email")]
        public string AdoxioEmail { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_taxandaccountingid")]
        public System.Guid? AdoxioTaxandaccountingid { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_recordtype")]
        public int? AdoxioRecordtype { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Account associated with Tax and
        /// Accounting.
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_accountid_value")]
        public System.Guid? _adoxioAccountidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public System.Guid? _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_taxandaccounting_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioTaxandaccountingSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_taxandaccounting_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioTaxandaccountingDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_taxandaccounting_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioTaxandaccountingDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_taxandaccounting_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioTaxandaccountingAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_taxandaccounting_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioTaxandaccountingBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_AccountId")]
        public MicrosoftDynamicsCRMaccount AdoxioAccountId { get; set; }

    }
}
