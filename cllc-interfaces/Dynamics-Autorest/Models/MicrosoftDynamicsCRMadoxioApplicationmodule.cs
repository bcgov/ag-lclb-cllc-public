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
    /// adoxio_applicationmodule
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioApplicationmodule
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationmodule class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationmodule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationmodule class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationmodule(string adoxioDisplayname = default(string), string adoxioFontawesomeicon = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), long? versionnumber = default(long?), string _owningteamValue = default(string), string _createdonbehalfbyValue = default(string), string _createdbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), bool? adoxioShowinreview = default(bool?), string _modifiedonbehalfbyValue = default(string), string adoxioApplicationmoduleid = default(string), string _owningbusinessunitValue = default(string), string _owneridValue = default(string), int? importsequencenumber = default(int?), string adoxioCopy = default(string), int? utcconversiontimezonecode = default(int?), int? statecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioInstructions = default(string), int? timezoneruleversionnumber = default(int?), string adoxioName = default(string), string _owninguserValue = default(string), int? statuscode = default(int?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioApplicationmoduleSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioApplicationmoduleDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioApplicationmoduleDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioApplicationmoduleAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioApplicationmoduleBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMadoxioLicencetypestep> adoxioApplicationmoduleAdoxioLicencetypestepModule = default(IList<MicrosoftDynamicsCRMadoxioLicencetypestep>))
        {
            AdoxioDisplayname = adoxioDisplayname;
            AdoxioFontawesomeicon = adoxioFontawesomeicon;
            this._modifiedbyValue = _modifiedbyValue;
            Overriddencreatedon = overriddencreatedon;
            Versionnumber = versionnumber;
            this._owningteamValue = _owningteamValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Createdon = createdon;
            AdoxioShowinreview = adoxioShowinreview;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioApplicationmoduleid = adoxioApplicationmoduleid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owneridValue = _owneridValue;
            Importsequencenumber = importsequencenumber;
            AdoxioCopy = adoxioCopy;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statecode = statecode;
            Modifiedon = modifiedon;
            AdoxioInstructions = adoxioInstructions;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioName = adoxioName;
            this._owninguserValue = _owninguserValue;
            Statuscode = statuscode;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioApplicationmoduleSyncErrors = adoxioApplicationmoduleSyncErrors;
            AdoxioApplicationmoduleDuplicateMatchingRecord = adoxioApplicationmoduleDuplicateMatchingRecord;
            AdoxioApplicationmoduleDuplicateBaseRecord = adoxioApplicationmoduleDuplicateBaseRecord;
            AdoxioApplicationmoduleAsyncOperations = adoxioApplicationmoduleAsyncOperations;
            AdoxioApplicationmoduleBulkDeleteFailures = adoxioApplicationmoduleBulkDeleteFailures;
            AdoxioApplicationmoduleAdoxioLicencetypestepModule = adoxioApplicationmoduleAdoxioLicencetypestepModule;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_displayname")]
        public string AdoxioDisplayname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fontawesomeicon")]
        public string AdoxioFontawesomeicon { get; set; }

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
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_showinreview")]
        public bool? AdoxioShowinreview { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationmoduleid")]
        public string AdoxioApplicationmoduleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_copy")]
        public string AdoxioCopy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_instructions")]
        public string AdoxioInstructions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
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
        [JsonProperty(PropertyName = "adoxio_applicationmodule_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioApplicationmoduleSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationmodule_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioApplicationmoduleDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationmodule_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioApplicationmoduleDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationmodule_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioApplicationmoduleAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationmodule_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioApplicationmoduleBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationmodule_adoxio_licencetypestep_Module")]
        public IList<MicrosoftDynamicsCRMadoxioLicencetypestep> AdoxioApplicationmoduleAdoxioLicencetypestepModule { get; set; }

    }
}
