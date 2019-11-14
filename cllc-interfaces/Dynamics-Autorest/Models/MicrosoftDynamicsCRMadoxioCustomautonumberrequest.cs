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
    /// Microsoft.Dynamics.CRM.adoxio_customautonumberrequest
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioCustomautonumberrequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioCustomautonumberrequest class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioCustomautonumberrequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioCustomautonumberrequest class.
        /// </summary>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="statuscode">Reason for the status of the Custom Auto
        /// Number Request</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="_organizationidValue">Unique identifier for the
        /// organization</param>
        /// <param name="versionnumber">Version Number</param>
        /// <param name="statecode">Status of the Custom Auto Number
        /// Request</param>
        /// <param name="adoxioCustomautonumberrequestid">Unique identifier for
        /// entity instances</param>
        /// <param name="adoxioName">The name of the custom entity.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        public MicrosoftDynamicsCRMadoxioCustomautonumberrequest(string _createdbyValue = default(string), int? statuscode = default(int?), string adoxioFormattednumber = default(string), int? utcconversiontimezonecode = default(int?), string _organizationidValue = default(string), string versionnumber = default(string), int? statecode = default(int?), string adoxioCustomautonumberrequestid = default(string), string adoxioName = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string adoxioNumber = default(string), int? adoxioIntegernumber = default(int?), string _createdonbehalfbyValue = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), int? timezoneruleversionnumber = default(int?), string adoxioLockvalue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> adoxioCustomautonumberrequestSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioCustomautonumberrequestAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioCustomautonumberrequestBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>))
        {
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            AdoxioFormattednumber = adoxioFormattednumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._organizationidValue = _organizationidValue;
            Versionnumber = versionnumber;
            Statecode = statecode;
            AdoxioCustomautonumberrequestid = adoxioCustomautonumberrequestid;
            AdoxioName = adoxioName;
            Overriddencreatedon = overriddencreatedon;
            AdoxioNumber = adoxioNumber;
            AdoxioIntegernumber = adoxioIntegernumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            Importsequencenumber = importsequencenumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioLockvalue = adoxioLockvalue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Organizationid = organizationid;
            AdoxioCustomautonumberrequestSyncErrors = adoxioCustomautonumberrequestSyncErrors;
            AdoxioCustomautonumberrequestAsyncOperations = adoxioCustomautonumberrequestAsyncOperations;
            AdoxioCustomautonumberrequestBulkDeleteFailures = adoxioCustomautonumberrequestBulkDeleteFailures;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Custom Auto Number
        /// Request
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_formattednumber")]
        public string AdoxioFormattednumber { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the organization
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets status of the Custom Auto Number Request
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_customautonumberrequestid")]
        public string AdoxioCustomautonumberrequestid { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_number")]
        public string AdoxioNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_integernumber")]
        public int? AdoxioIntegernumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lockvalue")]
        public string AdoxioLockvalue { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_customautonumberrequest_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioCustomautonumberrequestSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_customautonumberrequest_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioCustomautonumberrequestAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_customautonumberrequest_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioCustomautonumberrequestBulkDeleteFailures { get; set; }

    }
}
