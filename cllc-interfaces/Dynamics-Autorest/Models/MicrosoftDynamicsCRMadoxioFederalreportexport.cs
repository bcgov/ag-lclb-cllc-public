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
    /// Microsoft.Dynamics.CRM.adoxio_federalreportexport
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioFederalreportexport
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioFederalreportexport class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioFederalreportexport()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioFederalreportexport class.
        /// </summary>
        /// <param name="statecode">Status of the Federal Report Export</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="versionnumber">Version Number</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="adoxioFederalreportexportid">Unique identifier for
        /// entity instances</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="adoxioName">The name of the custom entity.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="_owneridValue">Owner Id</param>
        /// <param name="statuscode">Reason for the status of the Federal
        /// Report Export</param>
        public MicrosoftDynamicsCRMadoxioFederalreportexport(int? statecode = default(int?), string adoxioDocumentlink = default(string), System.DateTimeOffset? adoxioExportcompleted = default(System.DateTimeOffset?), System.DateTimeOffset? adoxioExporttriggered = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string versionnumber = default(string), string _owningbusinessunitValue = default(string), string _createdonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), string adoxioFederalreportexportid = default(string), string _modifiedonbehalfbyValue = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string adoxioName = default(string), int? timezoneruleversionnumber = default(int?), string _modifiedbyValue = default(string), string _owninguserValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? adoxioExporttirggered = default(System.DateTimeOffset?), string _owningteamValue = default(string), int? adoxioExportnumber = default(int?), string _owneridValue = default(string), int? statuscode = default(int?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioFederalreportexportSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioFederalreportexportDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioFederalreportexportDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> adoxioFederalreportexportSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioFederalreportexportAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioFederalreportexportBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMadoxioCannabismonthlyreport> adoxioFederalreportexportAdoxioCannabismonthlyreportFederalReportExportId = default(IList<MicrosoftDynamicsCRMadoxioCannabismonthlyreport>))
        {
            Statecode = statecode;
            AdoxioDocumentlink = adoxioDocumentlink;
            AdoxioExportcompleted = adoxioExportcompleted;
            AdoxioExporttriggered = adoxioExporttriggered;
            Createdon = createdon;
            Versionnumber = versionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioFederalreportexportid = adoxioFederalreportexportid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Importsequencenumber = importsequencenumber;
            Modifiedon = modifiedon;
            this._createdbyValue = _createdbyValue;
            AdoxioName = adoxioName;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            this._owninguserValue = _owninguserValue;
            Overriddencreatedon = overriddencreatedon;
            AdoxioExporttirggered = adoxioExporttirggered;
            this._owningteamValue = _owningteamValue;
            AdoxioExportnumber = adoxioExportnumber;
            this._owneridValue = _owneridValue;
            Statuscode = statuscode;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioFederalreportexportSyncErrors = adoxioFederalreportexportSyncErrors;
            AdoxioFederalreportexportDuplicateMatchingRecord = adoxioFederalreportexportDuplicateMatchingRecord;
            AdoxioFederalreportexportDuplicateBaseRecord = adoxioFederalreportexportDuplicateBaseRecord;
            AdoxioFederalreportexportSharePointDocumentLocations = adoxioFederalreportexportSharePointDocumentLocations;
            AdoxioFederalreportexportAsyncOperations = adoxioFederalreportexportAsyncOperations;
            AdoxioFederalreportexportBulkDeleteFailures = adoxioFederalreportexportBulkDeleteFailures;
            AdoxioFederalreportexportAdoxioCannabismonthlyreportFederalReportExportId = adoxioFederalreportexportAdoxioCannabismonthlyreportFederalReportExportId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets status of the Federal Report Export
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_documentlink")]
        public string AdoxioDocumentlink { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_exportcompleted")]
        public System.DateTimeOffset? AdoxioExportcompleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_exporttriggered")]
        public System.DateTimeOffset? AdoxioExporttriggered { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_federalreportexportid")]
        public string AdoxioFederalreportexportid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

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
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_exporttirggered")]
        public System.DateTimeOffset? AdoxioExporttirggered { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_exportnumber")]
        public int? AdoxioExportnumber { get; set; }

        /// <summary>
        /// Gets or sets owner Id
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Federal Report Export
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_federalreportexport_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioFederalreportexportSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_federalreportexport_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioFederalreportexportDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_federalreportexport_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioFederalreportexportDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_federalreportexport_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> AdoxioFederalreportexportSharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_federalreportexport_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioFederalreportexportAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_federalreportexport_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioFederalreportexportBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_federalreportexport_adoxio_cannabismonthlyreport_FederalReportExportId")]
        public IList<MicrosoftDynamicsCRMadoxioCannabismonthlyreport> AdoxioFederalreportexportAdoxioCannabismonthlyreportFederalReportExportId { get; set; }

    }
}
