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
    /// Microsoft.Dynamics.CRM.leadtoopportunitysalesprocess
    /// </summary>
    public partial class MicrosoftDynamicsCRMleadtoopportunitysalesprocess
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMleadtoopportunitysalesprocess class.
        /// </summary>
        public MicrosoftDynamicsCRMleadtoopportunitysalesprocess()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMleadtoopportunitysalesprocess class.
        /// </summary>
        /// <param name="importsequencenumber">Unique identifier of the data
        /// import or data migration that created this record.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization with which the SDK message request is
        /// associated.</param>
        /// <param name="_modifiedonbehalfbyValue">Shows who last updated the
        /// record on behalf of another user.</param>
        /// <param name="_createdbyValue">Shows who created the record.</param>
        /// <param name="_processidValue">Unique identifier of the
        /// LeadToOpportunitySalesProcess associated to the Business Process
        /// Flow instance.</param>
        /// <param name="_modifiedbyValue">Shows who last updated the
        /// record.</param>
        /// <param name="activestagestartedon">Date and time when current
        /// active stage is started.</param>
        /// <param name="versionnumber">Version number of the business process
        /// instance.</param>
        /// <param name="exchangerate">Shows the conversion rate of the
        /// record's currency. The exchange rate is used to convert all money
        /// fields in the record from the local currency to the system's
        /// default currency.</param>
        /// <param name="_opportunityidValue">Unique identifier of the workflow
        /// associated to the Business Process Flow instance.</param>
        /// <param name="duration">Duration between completed on and started
        /// on, used by business process flow.</param>
        /// <param name="completedon">Date and time when Business Process Flow
        /// instance is completed</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="businessprocessflowinstanceid">Unique identifier for
        /// Lead To Opportunity Sales Process bpf entity instances</param>
        /// <param name="createdon">Shows the date and time when the record was
        /// created. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics CRM options.</param>
        /// <param name="_createdonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="modifiedon">Shows the date and time when the record
        /// was last updated. The date and time are displayed in the time zone
        /// selected in Microsoft Dynamics CRM options.</param>
        /// <param name="_transactioncurrencyidValue">Choose the local currency
        /// for the record to make sure budgets are reported in the correct
        /// currency.</param>
        /// <param name="_leadidValue">Unique identifier of the workflow
        /// associated to the Business Process Flow instance.</param>
        /// <param name="_activestageidValue">Unique identifier of the active
        /// stage for the Business Process Flow instance.</param>
        /// <param name="statuscode">Select the delve action record
        /// status.</param>
        /// <param name="traversedpath">Traversed Path</param>
        /// <param name="name">Process Name.</param>
        /// <param name="statecode">Shows whether the Delve action record is
        /// pending, completed, or tracking.</param>
        public MicrosoftDynamicsCRMleadtoopportunitysalesprocess(int? importsequencenumber = default(int?), System.Guid? _organizationidValue = default(System.Guid?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.Guid? _createdbyValue = default(System.Guid?), System.Guid? _processidValue = default(System.Guid?), System.Guid? _modifiedbyValue = default(System.Guid?), System.DateTimeOffset? activestagestartedon = default(System.DateTimeOffset?), string versionnumber = default(string), decimal? exchangerate = default(decimal?), System.Guid? _opportunityidValue = default(System.Guid?), int? duration = default(int?), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.Guid? businessprocessflowinstanceid = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.Guid? _transactioncurrencyidValue = default(System.Guid?), System.Guid? _leadidValue = default(System.Guid?), System.Guid? _activestageidValue = default(System.Guid?), int? statuscode = default(int?), string traversedpath = default(string), string name = default(string), int? statecode = default(int?), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMlead leadId = default(MicrosoftDynamicsCRMlead), IList<MicrosoftDynamicsCRMworkflowlog> workflowlogsLeadtoopportunitysalesprocess = default(IList<MicrosoftDynamicsCRMworkflowlog>), MicrosoftDynamicsCRMworkflow processid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMsyncerror> leadToOpportunitySalesProcessSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMprocessstage activestageid = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMopportunity opportunityId = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser))
        {
            Importsequencenumber = importsequencenumber;
            this._organizationidValue = _organizationidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            this._processidValue = _processidValue;
            this._modifiedbyValue = _modifiedbyValue;
            Activestagestartedon = activestagestartedon;
            Versionnumber = versionnumber;
            Exchangerate = exchangerate;
            this._opportunityidValue = _opportunityidValue;
            Duration = duration;
            Completedon = completedon;
            Overriddencreatedon = overriddencreatedon;
            Businessprocessflowinstanceid = businessprocessflowinstanceid;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._leadidValue = _leadidValue;
            this._activestageidValue = _activestageidValue;
            Statuscode = statuscode;
            Traversedpath = traversedpath;
            Name = name;
            Statecode = statecode;
            Transactioncurrencyid = transactioncurrencyid;
            LeadId = leadId;
            WorkflowlogsLeadtoopportunitysalesprocess = workflowlogsLeadtoopportunitysalesprocess;
            Processid = processid;
            LeadToOpportunitySalesProcessSyncErrors = leadToOpportunitySalesProcessSyncErrors;
            Createdonbehalfbyname = createdonbehalfbyname;
            Organizationid = organizationid;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Activestageid = activestageid;
            OpportunityId = opportunityId;
            Createdbyname = createdbyname;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the data import or data migration
        /// that created this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization with which the
        /// SDK message request is associated.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the LeadToOpportunitySalesProcess
        /// associated to the Business Process Flow instance.
        /// </summary>
        [JsonProperty(PropertyName = "_processid_value")]
        public System.Guid? _processidValue { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when current active stage is started.
        /// </summary>
        [JsonProperty(PropertyName = "activestagestartedon")]
        public System.DateTimeOffset? Activestagestartedon { get; set; }

        /// <summary>
        /// Gets or sets version number of the business process instance.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets shows the conversion rate of the record's currency.
        /// The exchange rate is used to convert all money fields in the record
        /// from the local currency to the system's default currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the workflow associated to the
        /// Business Process Flow instance.
        /// </summary>
        [JsonProperty(PropertyName = "_opportunityid_value")]
        public System.Guid? _opportunityidValue { get; set; }

        /// <summary>
        /// Gets or sets duration between completed on and started on, used by
        /// business process flow.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Gets or sets date and time when Business Process Flow instance is
        /// completed
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Lead To Opportunity Sales
        /// Process bpf entity instances
        /// </summary>
        [JsonProperty(PropertyName = "businessprocessflowinstanceid")]
        public System.Guid? Businessprocessflowinstanceid { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was created.
        /// The date and time are displayed in the time zone selected in
        /// Microsoft Dynamics CRM options.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was last
        /// updated. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics CRM options.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets choose the local currency for the record to make sure
        /// budgets are reported in the correct currency.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public System.Guid? _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the workflow associated to the
        /// Business Process Flow instance.
        /// </summary>
        [JsonProperty(PropertyName = "_leadid_value")]
        public System.Guid? _leadidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the active stage for the Business
        /// Process Flow instance.
        /// </summary>
        [JsonProperty(PropertyName = "_activestageid_value")]
        public System.Guid? _activestageidValue { get; set; }

        /// <summary>
        /// Gets or sets select the delve action record status.
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets traversed Path
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// Gets or sets process Name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets shows whether the Delve action record is pending,
        /// completed, or tracking.
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadId")]
        public MicrosoftDynamicsCRMlead LeadId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowlogs_leadtoopportunitysalesprocess")]
        public IList<MicrosoftDynamicsCRMworkflowlog> WorkflowlogsLeadtoopportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public MicrosoftDynamicsCRMworkflow Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LeadToOpportunitySalesProcess_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> LeadToOpportunitySalesProcessSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestageid")]
        public MicrosoftDynamicsCRMprocessstage Activestageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityId")]
        public MicrosoftDynamicsCRMopportunity OpportunityId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

    }
}
