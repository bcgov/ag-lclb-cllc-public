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
    /// Microsoft.Dynamics.CRM.slaitem
    /// </summary>
    public partial class MicrosoftDynamicsCRMslaitem
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMslaitem
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMslaitem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMslaitem
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMslaitem(string _createdonbehalfbyValue = default(string), string slaitemidunique = default(string), string _modifiedonbehalfbyValue = default(string), string _slaidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _workflowidValue = default(string), string successconditionsxml = default(string), string description = default(string), decimal? exchangerate = default(decimal?), string applicablewhenxml = default(string), string _transactioncurrencyidValue = default(string), bool? ismanaged = default(bool?), string relatedfield = default(string), string _owningbusinessunitValue = default(string), string _owninguserValue = default(string), string solutionid = default(string), string name = default(string), int? warnafter = default(int?), string _createdbyValue = default(string), string versionnumber = default(string), int? failureafter = default(int?), string _modifiedbyValue = default(string), string _owneridValue = default(string), int? sequencenumber = default(int?), int? componentstate = default(int?), string slaitemid = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMworkflow workflowid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMsyncerror> sLAItemSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsla slaid = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Slaitemidunique = slaitemidunique;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._slaidValue = _slaidValue;
            Createdon = createdon;
            this._workflowidValue = _workflowidValue;
            Successconditionsxml = successconditionsxml;
            Description = description;
            Exchangerate = exchangerate;
            Applicablewhenxml = applicablewhenxml;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Ismanaged = ismanaged;
            Relatedfield = relatedfield;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owninguserValue = _owninguserValue;
            Solutionid = solutionid;
            Name = name;
            Warnafter = warnafter;
            this._createdbyValue = _createdbyValue;
            Versionnumber = versionnumber;
            Failureafter = failureafter;
            this._modifiedbyValue = _modifiedbyValue;
            this._owneridValue = _owneridValue;
            Sequencenumber = sequencenumber;
            Componentstate = componentstate;
            Slaitemid = slaitemid;
            Overwritetime = overwritetime;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdonbehalfby = createdonbehalfby;
            Workflowid = workflowid;
            SLAItemSyncErrors = sLAItemSyncErrors;
            Transactioncurrencyid = transactioncurrencyid;
            Modifiedby = modifiedby;
            Slaid = slaid;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slaitemidunique")]
        public string Slaitemidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slaid_value")]
        public string _slaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_workflowid_value")]
        public string _workflowidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "successconditionsxml")]
        public string Successconditionsxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "applicablewhenxml")]
        public string Applicablewhenxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "relatedfield")]
        public string Relatedfield { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "warnafter")]
        public int? Warnafter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "failureafter")]
        public int? Failureafter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sequencenumber")]
        public int? Sequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slaitemid")]
        public string Slaitemid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

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
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowid")]
        public MicrosoftDynamicsCRMworkflow Workflowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SLAItem_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SLAItemSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slaid")]
        public MicrosoftDynamicsCRMsla Slaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
