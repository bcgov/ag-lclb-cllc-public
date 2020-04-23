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
    /// Microsoft.Dynamics.CRM.solutioncomponent
    /// </summary>
    public partial class MicrosoftDynamicsCRMsolutioncomponent
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsolutioncomponent class.
        /// </summary>
        public MicrosoftDynamicsCRMsolutioncomponent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsolutioncomponent class.
        /// </summary>
        public MicrosoftDynamicsCRMsolutioncomponent(System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? componenttype = default(int?), int? rootcomponentbehavior = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string versionnumber = default(string), string _modifiedonbehalfbyValue = default(string), bool? ismetadata = default(bool?), string rootsolutioncomponentid = default(string), string _createdonbehalfbyValue = default(string), string _createdbyValue = default(string), string _solutionidValue = default(string), string _modifiedbyValue = default(string), string solutioncomponentid = default(string), string objectid = default(string), MicrosoftDynamicsCRMsolution solutionid = default(MicrosoftDynamicsCRMsolution), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsolutioncomponent rootsolutioncomponentidSolutioncomponent = default(MicrosoftDynamicsCRMsolutioncomponent), IList<MicrosoftDynamicsCRMsolutioncomponent> solutioncomponentParentSolutioncomponent = default(IList<MicrosoftDynamicsCRMsolutioncomponent>))
        {
            Createdon = createdon;
            Componenttype = componenttype;
            Rootcomponentbehavior = rootcomponentbehavior;
            Modifiedon = modifiedon;
            Versionnumber = versionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Ismetadata = ismetadata;
            Rootsolutioncomponentid = rootsolutioncomponentid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            this._solutionidValue = _solutionidValue;
            this._modifiedbyValue = _modifiedbyValue;
            Solutioncomponentid = solutioncomponentid;
            Objectid = objectid;
            Solutionid = solutionid;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            RootsolutioncomponentidSolutioncomponent = rootsolutioncomponentidSolutioncomponent;
            SolutioncomponentParentSolutioncomponent = solutioncomponentParentSolutioncomponent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componenttype")]
        public int? Componenttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rootcomponentbehavior")]
        public int? Rootcomponentbehavior { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismetadata")]
        public bool? Ismetadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rootsolutioncomponentid")]
        public string Rootsolutioncomponentid { get; set; }

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
        [JsonProperty(PropertyName = "_solutionid_value")]
        public string _solutionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutioncomponentid")]
        public string Solutioncomponentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid")]
        public string Objectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public MicrosoftDynamicsCRMsolution Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rootsolutioncomponentid_solutioncomponent")]
        public MicrosoftDynamicsCRMsolutioncomponent RootsolutioncomponentidSolutioncomponent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutioncomponent_parent_solutioncomponent")]
        public IList<MicrosoftDynamicsCRMsolutioncomponent> SolutioncomponentParentSolutioncomponent { get; set; }

    }
}
