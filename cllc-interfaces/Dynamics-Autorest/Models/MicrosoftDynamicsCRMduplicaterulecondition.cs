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

    public partial class MicrosoftDynamicsCRMduplicaterulecondition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMduplicaterulecondition class.
        /// </summary>
        public MicrosoftDynamicsCRMduplicaterulecondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMduplicaterulecondition class.
        /// </summary>
        public MicrosoftDynamicsCRMduplicaterulecondition(IList<MicrosoftDynamicsCRMsyncerror> duplicateRuleConditionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), string _regardingobjectidValue = default(string), string baseattributename = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string duplicateruleconditionid = default(string), bool? ignoreblankvalues = default(bool?), string matchingattributename = default(string), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), int? operatorcode = default(int?), int? operatorparam = default(int?), string owningbusinessunit = default(string), string owninguser = default(string), MicrosoftDynamicsCRMduplicaterule regardingobjectid = default(MicrosoftDynamicsCRMduplicaterule))
        {
            DuplicateRuleConditionSyncErrors = duplicateRuleConditionSyncErrors;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            this._regardingobjectidValue = _regardingobjectidValue;
            Baseattributename = baseattributename;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Duplicateruleconditionid = duplicateruleconditionid;
            Ignoreblankvalues = ignoreblankvalues;
            Matchingattributename = matchingattributename;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Operatorcode = operatorcode;
            Operatorparam = operatorparam;
            Owningbusinessunit = owningbusinessunit;
            Owninguser = owninguser;
            Regardingobjectid = regardingobjectid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DuplicateRuleCondition_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> DuplicateRuleConditionSyncErrors { get; set; }

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
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseattributename")]
        public string Baseattributename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duplicateruleconditionid")]
        public string Duplicateruleconditionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ignoreblankvalues")]
        public bool? Ignoreblankvalues { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "matchingattributename")]
        public string Matchingattributename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operatorcode")]
        public int? Operatorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operatorparam")]
        public int? Operatorparam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public string Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public string Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid")]
        public MicrosoftDynamicsCRMduplicaterule Regardingobjectid { get; set; }

    }
}
