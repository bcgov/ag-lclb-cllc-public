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
    /// Microsoft.Dynamics.CRM.phonecall
    /// </summary>
    public partial class MicrosoftDynamicsCRMphonecall
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMphonecall
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMphonecall()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMphonecall
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMphonecall(string subcategory = default(string), bool? directioncode = default(bool?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string category = default(string), string subscriptionid = default(string), string phonenumber = default(string), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementPhonecall = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplatePhonecall = default(MicrosoftDynamicsCRMentitlementtemplate), IList<MicrosoftDynamicsCRMpostregarding> phonecallPostRegardings = default(IList<MicrosoftDynamicsCRMpostregarding>), IList<MicrosoftDynamicsCRMpostfollow> phonecallPostFollows = default(IList<MicrosoftDynamicsCRMpostfollow>), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingPhonecall = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderPhonecall = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordPhonecall = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMmsdynPostalbum regardingobjectidMsdynPostalbumPhonecall = default(MicrosoftDynamicsCRMmsdynPostalbum), MicrosoftDynamicsCRMabsScheduledprocess regardingobjectidAbsScheduledprocessPhonecall = default(MicrosoftDynamicsCRMabsScheduledprocess), MicrosoftDynamicsCRMadoxioApplication regardingobjectidAdoxioApplicationPhonecall = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioComplaint regardingobjectidAdoxioComplaintPhonecall = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioInvestigation regardingobjectidAdoxioInvestigationPhonecall = default(MicrosoftDynamicsCRMadoxioInvestigation), MicrosoftDynamicsCRMadoxioLicences regardingobjectidAdoxioLicencesPhonecall = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioWorker regardingobjectidAdoxioWorkerPhonecall = default(MicrosoftDynamicsCRMadoxioWorker), MicrosoftDynamicsCRMadoxioComplianceinvestigation regardingobjectidAdoxioComplianceinvestigationPhonecall = default(MicrosoftDynamicsCRMadoxioComplianceinvestigation), MicrosoftDynamicsCRMsite regardingobjectidSitePhonecall = default(MicrosoftDynamicsCRMsite), MicrosoftDynamicsCRMadoxioEvent regardingobjectidAdoxioEventPhonecall = default(MicrosoftDynamicsCRMadoxioEvent), MicrosoftDynamicsCRMadoxioEnforcementaction regardingobjectidAdoxioEnforcementactionPhonecall = default(MicrosoftDynamicsCRMadoxioEnforcementaction), MicrosoftDynamicsCRMadoxioSpecialevent regardingobjectidAdoxioSpecialeventPhonecall = default(MicrosoftDynamicsCRMadoxioSpecialevent), MicrosoftDynamicsCRMlead regardingobjectidLeadPhonecall = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityPhonecall = default(MicrosoftDynamicsCRMopportunity), IList<MicrosoftDynamicsCRMactioncard> phonecallActioncard = default(IList<MicrosoftDynamicsCRMactioncard>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidPhonecall = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMcontact regardingobjectidContactPhonecall = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMcampaignresponse> phonecallCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), MicrosoftDynamicsCRMservice serviceidPhonecall = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMsla slaPhonecallSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMbulkdeletefailure> phoneCallBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyPhonecall = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationPhonecall = default(MicrosoftDynamicsCRMbulkoperation), IList<MicrosoftDynamicsCRMasyncoperation> phoneCallAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMaccount regardingobjectidAccountPhonecall = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMinvoice regardingobjectidInvoicePhonecall = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMsystemuser createdbyPhonecall = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyPhonecall = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMactivityparty> phonecallActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMincident regardingobjectidIncidentPhonecall = default(MicrosoftDynamicsCRMincident), IList<MicrosoftDynamicsCRMprocesssession> phoneCallProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMbusinessunit owningbusinessunitPhonecall = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMduplicaterecord> phoneCallDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticlePhonecall = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), IList<MicrosoftDynamicsCRMduplicaterecord> phoneCallDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMconnection> phonecallConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMcontract regardingobjectidContractPhonecall = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorderPhonecall = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstancePhonecall = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMsla slainvokedidPhonecallSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMsyncerror> phoneCallSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser modifiedbyPhonecall = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteamPhonecall = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMqueueitem> phoneCallQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignPhonecall = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityPhonecall = default(MicrosoftDynamicsCRMcampaignactivity), IList<MicrosoftDynamicsCRMannotation> phoneCallAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMquote regardingobjectidQuotePhonecall = default(MicrosoftDynamicsCRMquote), IList<MicrosoftDynamicsCRMconnection> phonecallConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMsystemuser owninguserPhonecall = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> phonecallPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Subcategory = subcategory;
            Directioncode = directioncode;
            Overriddencreatedon = overriddencreatedon;
            Category = category;
            Subscriptionid = subscriptionid;
            Phonenumber = phonenumber;
            Importsequencenumber = importsequencenumber;
            RegardingobjectidEntitlementPhonecall = regardingobjectidEntitlementPhonecall;
            RegardingobjectidEntitlementtemplatePhonecall = regardingobjectidEntitlementtemplatePhonecall;
            PhonecallPostRegardings = phonecallPostRegardings;
            PhonecallPostFollows = phonecallPostFollows;
            RegardingobjectidBookableresourcebookingPhonecall = regardingobjectidBookableresourcebookingPhonecall;
            RegardingobjectidBookableresourcebookingheaderPhonecall = regardingobjectidBookableresourcebookingheaderPhonecall;
            RegardingobjectidKnowledgebaserecordPhonecall = regardingobjectidKnowledgebaserecordPhonecall;
            RegardingobjectidMsdynPostalbumPhonecall = regardingobjectidMsdynPostalbumPhonecall;
            RegardingobjectidAbsScheduledprocessPhonecall = regardingobjectidAbsScheduledprocessPhonecall;
            RegardingobjectidAdoxioApplicationPhonecall = regardingobjectidAdoxioApplicationPhonecall;
            RegardingobjectidAdoxioComplaintPhonecall = regardingobjectidAdoxioComplaintPhonecall;
            RegardingobjectidAdoxioInvestigationPhonecall = regardingobjectidAdoxioInvestigationPhonecall;
            RegardingobjectidAdoxioLicencesPhonecall = regardingobjectidAdoxioLicencesPhonecall;
            RegardingobjectidAdoxioWorkerPhonecall = regardingobjectidAdoxioWorkerPhonecall;
            RegardingobjectidAdoxioComplianceinvestigationPhonecall = regardingobjectidAdoxioComplianceinvestigationPhonecall;
            RegardingobjectidSitePhonecall = regardingobjectidSitePhonecall;
            RegardingobjectidAdoxioEventPhonecall = regardingobjectidAdoxioEventPhonecall;
            RegardingobjectidAdoxioEnforcementactionPhonecall = regardingobjectidAdoxioEnforcementactionPhonecall;
            RegardingobjectidAdoxioSpecialeventPhonecall = regardingobjectidAdoxioSpecialeventPhonecall;
            RegardingobjectidLeadPhonecall = regardingobjectidLeadPhonecall;
            RegardingobjectidOpportunityPhonecall = regardingobjectidOpportunityPhonecall;
            PhonecallActioncard = phonecallActioncard;
            TransactioncurrencyidPhonecall = transactioncurrencyidPhonecall;
            RegardingobjectidContactPhonecall = regardingobjectidContactPhonecall;
            PhonecallCampaignresponse = phonecallCampaignresponse;
            ServiceidPhonecall = serviceidPhonecall;
            SlaPhonecallSla = slaPhonecallSla;
            PhoneCallBulkDeleteFailures = phoneCallBulkDeleteFailures;
            ModifiedonbehalfbyPhonecall = modifiedonbehalfbyPhonecall;
            RegardingobjectidBulkoperationPhonecall = regardingobjectidBulkoperationPhonecall;
            PhoneCallAsyncOperations = phoneCallAsyncOperations;
            RegardingobjectidAccountPhonecall = regardingobjectidAccountPhonecall;
            RegardingobjectidInvoicePhonecall = regardingobjectidInvoicePhonecall;
            CreatedbyPhonecall = createdbyPhonecall;
            CreatedonbehalfbyPhonecall = createdonbehalfbyPhonecall;
            PhonecallActivityParties = phonecallActivityParties;
            RegardingobjectidIncidentPhonecall = regardingobjectidIncidentPhonecall;
            PhoneCallProcessSessions = phoneCallProcessSessions;
            OwningbusinessunitPhonecall = owningbusinessunitPhonecall;
            PhoneCallDuplicateMatchingRecord = phoneCallDuplicateMatchingRecord;
            RegardingobjectidKnowledgearticlePhonecall = regardingobjectidKnowledgearticlePhonecall;
            StageidProcessstage = stageidProcessstage;
            PhoneCallDuplicateBaseRecord = phoneCallDuplicateBaseRecord;
            PhonecallConnections1 = phonecallConnections1;
            RegardingobjectidContractPhonecall = regardingobjectidContractPhonecall;
            RegardingobjectidSalesorderPhonecall = regardingobjectidSalesorderPhonecall;
            ActivityidActivitypointer = activityidActivitypointer;
            SlakpiinstancePhonecall = slakpiinstancePhonecall;
            SlainvokedidPhonecallSla = slainvokedidPhonecallSla;
            PhoneCallSyncErrors = phoneCallSyncErrors;
            ModifiedbyPhonecall = modifiedbyPhonecall;
            OwningteamPhonecall = owningteamPhonecall;
            PhoneCallQueueItem = phoneCallQueueItem;
            RegardingobjectidCampaignPhonecall = regardingobjectidCampaignPhonecall;
            RegardingobjectidCampaignactivityPhonecall = regardingobjectidCampaignactivityPhonecall;
            PhoneCallAnnotation = phoneCallAnnotation;
            RegardingobjectidQuotePhonecall = regardingobjectidQuotePhonecall;
            PhonecallConnections2 = phonecallConnections2;
            OwninguserPhonecall = owninguserPhonecall;
            PhonecallPrincipalobjectattributeaccess = phonecallPrincipalobjectattributeaccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "directioncode")]
        public bool? Directioncode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionid")]
        public string Subscriptionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phonenumber")]
        public string Phonenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_phonecall")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_phonecall")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplatePhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phonecall_PostRegardings")]
        public IList<MicrosoftDynamicsCRMpostregarding> PhonecallPostRegardings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phonecall_PostFollows")]
        public IList<MicrosoftDynamicsCRMpostfollow> PhonecallPostFollows { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_phonecall")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_phonecall")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_phonecall")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_msdyn_postalbum_phonecall")]
        public MicrosoftDynamicsCRMmsdynPostalbum RegardingobjectidMsdynPostalbumPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_abs_scheduledprocess_phonecall")]
        public MicrosoftDynamicsCRMabsScheduledprocess RegardingobjectidAbsScheduledprocessPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_application_phonecall")]
        public MicrosoftDynamicsCRMadoxioApplication RegardingobjectidAdoxioApplicationPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complaint_phonecall")]
        public MicrosoftDynamicsCRMadoxioComplaint RegardingobjectidAdoxioComplaintPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_investigation_phonecall")]
        public MicrosoftDynamicsCRMadoxioInvestigation RegardingobjectidAdoxioInvestigationPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_licences_phonecall")]
        public MicrosoftDynamicsCRMadoxioLicences RegardingobjectidAdoxioLicencesPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_worker_phonecall")]
        public MicrosoftDynamicsCRMadoxioWorker RegardingobjectidAdoxioWorkerPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complianceinvestigation_phonecall")]
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation RegardingobjectidAdoxioComplianceinvestigationPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_site_phonecall")]
        public MicrosoftDynamicsCRMsite RegardingobjectidSitePhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_event_phonecall")]
        public MicrosoftDynamicsCRMadoxioEvent RegardingobjectidAdoxioEventPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_enforcementaction_phonecall")]
        public MicrosoftDynamicsCRMadoxioEnforcementaction RegardingobjectidAdoxioEnforcementactionPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_specialevent_phonecall")]
        public MicrosoftDynamicsCRMadoxioSpecialevent RegardingobjectidAdoxioSpecialeventPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_phonecall")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_phonecall")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phonecall_actioncard")]
        public IList<MicrosoftDynamicsCRMactioncard> PhonecallActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_phonecall")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_phonecall")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phonecall_campaignresponse")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> PhonecallCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_phonecall")]
        public MicrosoftDynamicsCRMservice ServiceidPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_phonecall_sla")]
        public MicrosoftDynamicsCRMsla SlaPhonecallSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhoneCall_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> PhoneCallBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_phonecall")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_phonecall")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhoneCall_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> PhoneCallAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_phonecall")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoice_phonecall")]
        public MicrosoftDynamicsCRMinvoice RegardingobjectidInvoicePhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_phonecall")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_phonecall")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phonecall_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> PhonecallActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_phonecall")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhoneCall_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> PhoneCallProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_phonecall")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhoneCall_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> PhoneCallDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_phonecall")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticlePhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhoneCall_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> PhoneCallDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phonecall_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> PhonecallConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contract_phonecall")]
        public MicrosoftDynamicsCRMcontract RegardingobjectidContractPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorder_phonecall")]
        public MicrosoftDynamicsCRMsalesorder RegardingobjectidSalesorderPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_phonecall")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstancePhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_phonecall_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidPhonecallSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhoneCall_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> PhoneCallSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_phonecall")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_phonecall")]
        public MicrosoftDynamicsCRMteam OwningteamPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhoneCall_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> PhoneCallQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_phonecall")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_phonecall")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhoneCall_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> PhoneCallAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_phonecall")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuotePhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phonecall_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> PhonecallConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_phonecall")]
        public MicrosoftDynamicsCRMsystemuser OwninguserPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phonecall_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> PhonecallPrincipalobjectattributeaccess { get; set; }

    }
}
