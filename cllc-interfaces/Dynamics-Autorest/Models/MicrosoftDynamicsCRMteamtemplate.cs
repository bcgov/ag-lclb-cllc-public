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
    /// teamtemplate
    /// </summary>
    public partial class MicrosoftDynamicsCRMteamtemplate
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMteamtemplate
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMteamtemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMteamtemplate
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMteamtemplate(string description = default(string), int? objecttypecode = default(int?), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string teamtemplatename = default(string), string teamtemplateid = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedonbehalfbyValue = default(string), int? defaultaccessrightsmask = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), bool? issystem = default(bool?), IList<MicrosoftDynamicsCRMteam> teamtemplateTeams = default(IList<MicrosoftDynamicsCRMteam>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> teamTemplateSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>))
        {
            Description = description;
            Objecttypecode = objecttypecode;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            Teamtemplatename = teamtemplatename;
            Teamtemplateid = teamtemplateid;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Defaultaccessrightsmask = defaultaccessrightsmask;
            Createdon = createdon;
            Issystem = issystem;
            TeamtemplateTeams = teamtemplateTeams;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            TeamTemplateSyncErrors = teamTemplateSyncErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public int? Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teamtemplatename")]
        public string Teamtemplatename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teamtemplateid")]
        public string Teamtemplateid { get; set; }

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
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultaccessrightsmask")]
        public int? Defaultaccessrightsmask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issystem")]
        public bool? Issystem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teamtemplate_Teams")]
        public IList<MicrosoftDynamicsCRMteam> TeamtemplateTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TeamTemplate_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> TeamTemplateSyncErrors { get; set; }

    }
}
