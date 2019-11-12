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
    /// Microsoft.Dynamics.CRM.adoxio_previousaddress
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioPreviousaddress
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioPreviousaddress class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioPreviousaddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioPreviousaddress class.
        /// </summary>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="adoxioName">The name of the custom entity.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="statecode">Status of the Previous Address</param>
        /// <param name="_owneridValue">Owner Id</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="statuscode">Reason for the status of the Previous
        /// Address</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="versionnumber">Version Number</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="_adoxioWorkeridValue">Unique identifier for Worker
        /// Registration associated with Previous Address.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="adoxioPreviousaddressid">Unique identifier for entity
        /// instances</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        public MicrosoftDynamicsCRMadoxioPreviousaddress(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string adoxioProvstate = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string adoxioName = default(string), int? importsequencenumber = default(int?), int? statecode = default(int?), System.Guid? _owneridValue = default(System.Guid?), System.Guid? _adoxioContactidValue = default(System.Guid?), System.Guid? _owningteamValue = default(System.Guid?), int? statuscode = default(int?), System.Guid? _createdbyValue = default(System.Guid?), int? utcconversiontimezonecode = default(int?), System.Guid? _modifiedbyValue = default(System.Guid?), string adoxioPostalcode = default(string), System.Guid? _createdonbehalfbyValue = default(System.Guid?), string adoxioStreetaddress = default(string), System.DateTimeOffset? adoxioTodate = default(System.DateTimeOffset?), System.Guid? _adoxioLegalentityidValue = default(System.Guid?), string versionnumber = default(string), string adoxioCountry = default(string), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.Guid? _adoxioWorkeridValue = default(System.Guid?), string adoxioCity = default(string), System.Guid? _owningbusinessunitValue = default(System.Guid?), System.Guid? adoxioPreviousaddressid = default(System.Guid?), System.DateTimeOffset? adoxioFromdate = default(System.DateTimeOffset?), System.Guid? _owninguserValue = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioPreviousaddressSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioPreviousaddressAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioPreviousaddressBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMcontact adoxioContactId = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMadoxioLegalentity adoxioLegalEntityId = default(MicrosoftDynamicsCRMadoxioLegalentity), MicrosoftDynamicsCRMadoxioWorker adoxioWorkerId = default(MicrosoftDynamicsCRMadoxioWorker))
        {
            Overriddencreatedon = overriddencreatedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioProvstate = adoxioProvstate;
            Createdon = createdon;
            AdoxioName = adoxioName;
            Importsequencenumber = importsequencenumber;
            Statecode = statecode;
            this._owneridValue = _owneridValue;
            this._adoxioContactidValue = _adoxioContactidValue;
            this._owningteamValue = _owningteamValue;
            Statuscode = statuscode;
            this._createdbyValue = _createdbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioPostalcode = adoxioPostalcode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioStreetaddress = adoxioStreetaddress;
            AdoxioTodate = adoxioTodate;
            this._adoxioLegalentityidValue = _adoxioLegalentityidValue;
            Versionnumber = versionnumber;
            AdoxioCountry = adoxioCountry;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._adoxioWorkeridValue = _adoxioWorkeridValue;
            AdoxioCity = adoxioCity;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioPreviousaddressid = adoxioPreviousaddressid;
            AdoxioFromdate = adoxioFromdate;
            this._owninguserValue = _owninguserValue;
            Modifiedon = modifiedon;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioPreviousaddressSyncErrors = adoxioPreviousaddressSyncErrors;
            AdoxioPreviousaddressAsyncOperations = adoxioPreviousaddressAsyncOperations;
            AdoxioPreviousaddressBulkDeleteFailures = adoxioPreviousaddressBulkDeleteFailures;
            AdoxioContactId = adoxioContactId;
            AdoxioLegalEntityId = adoxioLegalEntityId;
            AdoxioWorkerId = adoxioWorkerId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_provstate")]
        public string AdoxioProvstate { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets status of the Previous Address
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets owner Id
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public System.Guid? _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_contactid_value")]
        public System.Guid? _adoxioContactidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public System.Guid? _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Previous Address
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

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
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_postalcode")]
        public string AdoxioPostalcode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_streetaddress")]
        public string AdoxioStreetaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_todate")]
        public System.DateTimeOffset? AdoxioTodate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_legalentityid_value")]
        public System.Guid? _adoxioLegalentityidValue { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_country")]
        public string AdoxioCountry { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Worker Registration associated
        /// with Previous Address.
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_workerid_value")]
        public System.Guid? _adoxioWorkeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_city")]
        public string AdoxioCity { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public System.Guid? _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousaddressid")]
        public System.Guid? AdoxioPreviousaddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fromdate")]
        public System.DateTimeOffset? AdoxioFromdate { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public System.Guid? _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_previousaddress_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioPreviousaddressSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousaddress_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioPreviousaddressAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousaddress_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioPreviousaddressBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ContactId")]
        public MicrosoftDynamicsCRMcontact AdoxioContactId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LegalEntityId")]
        public MicrosoftDynamicsCRMadoxioLegalentity AdoxioLegalEntityId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_WorkerId")]
        public MicrosoftDynamicsCRMadoxioWorker AdoxioWorkerId { get; set; }

    }
}
