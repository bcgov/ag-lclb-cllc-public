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
    /// adoxio_penaltytype
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioPenaltytype
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioPenaltytype class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioPenaltytype()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioPenaltytype class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioPenaltytype(int? statuscode = default(int?), string _createdonbehalfbyValue = default(string), string adoxioPenaltytypeid = default(string), string _createdbyValue = default(string), long? versionnumber = default(long?), string adoxioName = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _organizationidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statecode = default(int?), string _modifiedonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), int? importsequencenumber = default(int?), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> adoxioPenaltytypeSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioPenaltytypeDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioPenaltytypeDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioPenaltytypeAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioPenaltytypeBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMadoxioPenaltysubtype> adoxioAdoxioPenaltytypeAdoxioPenaltysubtypePenaltyType = default(IList<MicrosoftDynamicsCRMadoxioPenaltysubtype>), IList<MicrosoftDynamicsCRMadoxioViolationtype> adoxioAdoxioPenaltytypeAdoxioViolationtypePenaltyType = default(IList<MicrosoftDynamicsCRMadoxioViolationtype>))
        {
            Statuscode = statuscode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioPenaltytypeid = adoxioPenaltytypeid;
            this._createdbyValue = _createdbyValue;
            Versionnumber = versionnumber;
            AdoxioName = adoxioName;
            Createdon = createdon;
            this._modifiedbyValue = _modifiedbyValue;
            Overriddencreatedon = overriddencreatedon;
            this._organizationidValue = _organizationidValue;
            Modifiedon = modifiedon;
            Statecode = statecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Importsequencenumber = importsequencenumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Organizationid = organizationid;
            AdoxioPenaltytypeSyncErrors = adoxioPenaltytypeSyncErrors;
            AdoxioPenaltytypeDuplicateMatchingRecord = adoxioPenaltytypeDuplicateMatchingRecord;
            AdoxioPenaltytypeDuplicateBaseRecord = adoxioPenaltytypeDuplicateBaseRecord;
            AdoxioPenaltytypeAsyncOperations = adoxioPenaltytypeAsyncOperations;
            AdoxioPenaltytypeBulkDeleteFailures = adoxioPenaltytypeBulkDeleteFailures;
            AdoxioAdoxioPenaltytypeAdoxioPenaltysubtypePenaltyType = adoxioAdoxioPenaltytypeAdoxioPenaltysubtypePenaltyType;
            AdoxioAdoxioPenaltytypeAdoxioViolationtypePenaltyType = adoxioAdoxioPenaltytypeAdoxioViolationtypePenaltyType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_penaltytypeid")]
        public string AdoxioPenaltytypeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_penaltytype_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioPenaltytypeSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_penaltytype_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioPenaltytypeDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_penaltytype_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioPenaltytypeDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_penaltytype_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioPenaltytypeAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_penaltytype_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioPenaltytypeBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_penaltytype_adoxio_penaltysubtype_PenaltyType")]
        public IList<MicrosoftDynamicsCRMadoxioPenaltysubtype> AdoxioAdoxioPenaltytypeAdoxioPenaltysubtypePenaltyType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_penaltytype_adoxio_violationtype_PenaltyType")]
        public IList<MicrosoftDynamicsCRMadoxioViolationtype> AdoxioAdoxioPenaltytypeAdoxioViolationtypePenaltyType { get; set; }

    }
}
