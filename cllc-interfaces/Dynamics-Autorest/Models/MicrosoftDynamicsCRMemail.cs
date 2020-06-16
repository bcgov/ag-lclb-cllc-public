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
    /// Microsoft.Dynamics.CRM.email
    /// </summary>
    public partial class MicrosoftDynamicsCRMemail
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMemail class.
        /// </summary>
        public MicrosoftDynamicsCRMemail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMemail class.
        /// </summary>
        public MicrosoftDynamicsCRMemail(string reminderactioncardid = default(string), string trackingtoken = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), bool? readreceiptrequested = default(bool?), bool? compressed = default(bool?), string emailremindertext = default(string), string emailtrackingid = default(string), System.DateTimeOffset? emailreminderexpirytime = default(System.DateTimeOffset?), int? isunsafe = default(int?), string subcategory = default(string), string _parentactivityidValue = default(string), System.DateTimeOffset? postponeemailprocessinguntil = default(System.DateTimeOffset?), string category = default(string), int? replycount = default(int?), bool? directioncode = default(bool?), int? correlationmethod = default(int?), string _sendersaccountValue = default(string), int? emailreminderstatus = default(int?), int? linksclickedcount = default(int?), string submittedby = default(string), string _emailsenderValue = default(string), bool? deliveryreceiptrequested = default(bool?), int? notifications = default(int?), string conversationtrackingid = default(string), int? deliveryattempts = default(int?), int? opencount = default(int?), string torecipients = default(string), System.DateTimeOffset? delayedemailsendtime = default(System.DateTimeOffset?), string mimetype = default(string), bool? followemailuserpreference = default(bool?), string _templateidValue = default(string), string inreplyto = default(string), string messageid = default(string), int? attachmentcount = default(int?), System.DateTimeOffset? lastopenedtime = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), bool? isemailreminderset = default(bool?), bool? isemailfollowed = default(bool?), string conversationindex = default(string), int? emailremindertype = default(int?), int? baseconversationindexhash = default(int?), string sender = default(string), int? attachmentopencount = default(int?), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementEmail = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateEmail = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingEmail = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderEmail = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordEmail = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMmsdynPostalbum regardingobjectidMsdynPostalbumEmail = default(MicrosoftDynamicsCRMmsdynPostalbum), MicrosoftDynamicsCRMabsScheduledprocess regardingobjectidAbsScheduledprocessEmail = default(MicrosoftDynamicsCRMabsScheduledprocess), MicrosoftDynamicsCRMadoxioApplication regardingobjectidAdoxioApplicationEmail = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioComplaint regardingobjectidAdoxioComplaintEmail = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioInvestigation regardingobjectidAdoxioInvestigationEmail = default(MicrosoftDynamicsCRMadoxioInvestigation), MicrosoftDynamicsCRMadoxioLicences regardingobjectidAdoxioLicencesEmail = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioWorker regardingobjectidAdoxioWorkerEmail = default(MicrosoftDynamicsCRMadoxioWorker), MicrosoftDynamicsCRMadoxioComplianceinvestigation regardingobjectidAdoxioComplianceinvestigationEmail = default(MicrosoftDynamicsCRMadoxioComplianceinvestigation), MicrosoftDynamicsCRMsite regardingobjectidSiteEmail = default(MicrosoftDynamicsCRMsite), MicrosoftDynamicsCRMadoxioEvent regardingobjectidAdoxioEventEmail = default(MicrosoftDynamicsCRMadoxioEvent), MicrosoftDynamicsCRMadoxioEnforcementaction regardingobjectidAdoxioEnforcementactionEmail = default(MicrosoftDynamicsCRMadoxioEnforcementaction), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationEmail = default(MicrosoftDynamicsCRMbulkoperation), IList<MicrosoftDynamicsCRMsyncerror> emailSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidEmail = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMasyncoperation regardingobjectidAsyncoperation = default(MicrosoftDynamicsCRMasyncoperation), MicrosoftDynamicsCRMaccount sendersaccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMaccount emailsenderAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMlead regardingobjectidLeadEmail = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMsla slaEmailSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorderEmail = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMlead emailsenderLead = default(MicrosoftDynamicsCRMlead), IList<MicrosoftDynamicsCRMasyncoperation> emailAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityEmail = default(MicrosoftDynamicsCRMopportunity), IList<MicrosoftDynamicsCRMduplicaterecord> emailDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMconnection> emailConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMmailbox sendermailboxidEmail = default(MicrosoftDynamicsCRMmailbox), IList<MicrosoftDynamicsCRMactivitymimeattachment> emailActivityMimeAttachment = default(IList<MicrosoftDynamicsCRMactivitymimeattachment>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceEmail = default(IList<MicrosoftDynamicsCRMslakpiinstance>), IList<MicrosoftDynamicsCRMconnection> emailConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMinvoice regardingobjectidInvoiceEmail = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMbusinessunit owningbusinessunitEmail = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMcontact emailsenderContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMsystemuser owninguserEmail = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyEmail = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMincident regardingobjectidIncidentEmail = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMteam owningteamEmail = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignEmail = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMqueue emailsenderQueue = default(MicrosoftDynamicsCRMqueue), MicrosoftDynamicsCRMsla slainvokedidEmailSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMannotation> emailAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> emailBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprocesssession> emailProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMsystemuser createdonbehalfbyEmail = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMactivityparty> emailActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleEmail = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMequipment emailsenderEquipment = default(MicrosoftDynamicsCRMequipment), IList<MicrosoftDynamicsCRMactioncard> emailActioncard = default(IList<MicrosoftDynamicsCRMactioncard>), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityEmail = default(MicrosoftDynamicsCRMcampaignactivity), IList<MicrosoftDynamicsCRMduplicaterecord> emailDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMservice serviceidEmail = default(MicrosoftDynamicsCRMservice), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> emailPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyEmail = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMcampaignresponse> emailCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), MicrosoftDynamicsCRMaccount regardingobjectidAccountEmail = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMsystemuser createdbyEmail = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser emailsenderSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcontract regardingobjectidContractEmail = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMtemplate templateid = default(MicrosoftDynamicsCRMtemplate), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMcontact regardingobjectidContactEmail = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMqueueitem> emailQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), MicrosoftDynamicsCRMemail parentactivityid = default(MicrosoftDynamicsCRMemail), IList<MicrosoftDynamicsCRMemail> emailEmailParentactivityid = default(IList<MicrosoftDynamicsCRMemail>), MicrosoftDynamicsCRMquote regardingobjectidQuoteEmail = default(MicrosoftDynamicsCRMquote))
        {
            Reminderactioncardid = reminderactioncardid;
            Trackingtoken = trackingtoken;
            Overriddencreatedon = overriddencreatedon;
            Readreceiptrequested = readreceiptrequested;
            Compressed = compressed;
            Emailremindertext = emailremindertext;
            Emailtrackingid = emailtrackingid;
            Emailreminderexpirytime = emailreminderexpirytime;
            Isunsafe = isunsafe;
            Subcategory = subcategory;
            this._parentactivityidValue = _parentactivityidValue;
            Postponeemailprocessinguntil = postponeemailprocessinguntil;
            Category = category;
            Replycount = replycount;
            Directioncode = directioncode;
            Correlationmethod = correlationmethod;
            this._sendersaccountValue = _sendersaccountValue;
            Emailreminderstatus = emailreminderstatus;
            Linksclickedcount = linksclickedcount;
            Submittedby = submittedby;
            this._emailsenderValue = _emailsenderValue;
            Deliveryreceiptrequested = deliveryreceiptrequested;
            Notifications = notifications;
            Conversationtrackingid = conversationtrackingid;
            Deliveryattempts = deliveryattempts;
            Opencount = opencount;
            Torecipients = torecipients;
            Delayedemailsendtime = delayedemailsendtime;
            Mimetype = mimetype;
            Followemailuserpreference = followemailuserpreference;
            this._templateidValue = _templateidValue;
            Inreplyto = inreplyto;
            Messageid = messageid;
            Attachmentcount = attachmentcount;
            Lastopenedtime = lastopenedtime;
            Importsequencenumber = importsequencenumber;
            Isemailreminderset = isemailreminderset;
            Isemailfollowed = isemailfollowed;
            Conversationindex = conversationindex;
            Emailremindertype = emailremindertype;
            Baseconversationindexhash = baseconversationindexhash;
            Sender = sender;
            Attachmentopencount = attachmentopencount;
            RegardingobjectidEntitlementEmail = regardingobjectidEntitlementEmail;
            RegardingobjectidEntitlementtemplateEmail = regardingobjectidEntitlementtemplateEmail;
            RegardingobjectidBookableresourcebookingEmail = regardingobjectidBookableresourcebookingEmail;
            RegardingobjectidBookableresourcebookingheaderEmail = regardingobjectidBookableresourcebookingheaderEmail;
            RegardingobjectidKnowledgebaserecordEmail = regardingobjectidKnowledgebaserecordEmail;
            RegardingobjectidMsdynPostalbumEmail = regardingobjectidMsdynPostalbumEmail;
            RegardingobjectidAbsScheduledprocessEmail = regardingobjectidAbsScheduledprocessEmail;
            RegardingobjectidAdoxioApplicationEmail = regardingobjectidAdoxioApplicationEmail;
            RegardingobjectidAdoxioComplaintEmail = regardingobjectidAdoxioComplaintEmail;
            RegardingobjectidAdoxioInvestigationEmail = regardingobjectidAdoxioInvestigationEmail;
            RegardingobjectidAdoxioLicencesEmail = regardingobjectidAdoxioLicencesEmail;
            RegardingobjectidAdoxioWorkerEmail = regardingobjectidAdoxioWorkerEmail;
            RegardingobjectidAdoxioComplianceinvestigationEmail = regardingobjectidAdoxioComplianceinvestigationEmail;
            RegardingobjectidSiteEmail = regardingobjectidSiteEmail;
            RegardingobjectidAdoxioEventEmail = regardingobjectidAdoxioEventEmail;
            RegardingobjectidAdoxioEnforcementactionEmail = regardingobjectidAdoxioEnforcementactionEmail;
            RegardingobjectidBulkoperationEmail = regardingobjectidBulkoperationEmail;
            EmailSyncErrors = emailSyncErrors;
            TransactioncurrencyidEmail = transactioncurrencyidEmail;
            RegardingobjectidAsyncoperation = regardingobjectidAsyncoperation;
            Sendersaccount = sendersaccount;
            EmailsenderAccount = emailsenderAccount;
            RegardingobjectidLeadEmail = regardingobjectidLeadEmail;
            ActivityidActivitypointer = activityidActivitypointer;
            SlaEmailSla = slaEmailSla;
            RegardingobjectidSalesorderEmail = regardingobjectidSalesorderEmail;
            EmailsenderLead = emailsenderLead;
            EmailAsyncOperations = emailAsyncOperations;
            RegardingobjectidOpportunityEmail = regardingobjectidOpportunityEmail;
            EmailDuplicateBaseRecord = emailDuplicateBaseRecord;
            EmailConnections1 = emailConnections1;
            SendermailboxidEmail = sendermailboxidEmail;
            EmailActivityMimeAttachment = emailActivityMimeAttachment;
            SlakpiinstanceEmail = slakpiinstanceEmail;
            EmailConnections2 = emailConnections2;
            RegardingobjectidInvoiceEmail = regardingobjectidInvoiceEmail;
            OwningbusinessunitEmail = owningbusinessunitEmail;
            EmailsenderContact = emailsenderContact;
            OwninguserEmail = owninguserEmail;
            ModifiedbyEmail = modifiedbyEmail;
            RegardingobjectidIncidentEmail = regardingobjectidIncidentEmail;
            OwningteamEmail = owningteamEmail;
            RegardingobjectidCampaignEmail = regardingobjectidCampaignEmail;
            EmailsenderQueue = emailsenderQueue;
            SlainvokedidEmailSla = slainvokedidEmailSla;
            EmailAnnotation = emailAnnotation;
            EmailBulkDeleteFailures = emailBulkDeleteFailures;
            EmailProcessSessions = emailProcessSessions;
            CreatedonbehalfbyEmail = createdonbehalfbyEmail;
            EmailActivityParties = emailActivityParties;
            RegardingobjectidKnowledgearticleEmail = regardingobjectidKnowledgearticleEmail;
            EmailsenderEquipment = emailsenderEquipment;
            EmailActioncard = emailActioncard;
            RegardingobjectidCampaignactivityEmail = regardingobjectidCampaignactivityEmail;
            EmailDuplicateMatchingRecord = emailDuplicateMatchingRecord;
            ServiceidEmail = serviceidEmail;
            EmailPrincipalobjectattributeaccess = emailPrincipalobjectattributeaccess;
            ModifiedonbehalfbyEmail = modifiedonbehalfbyEmail;
            EmailCampaignresponse = emailCampaignresponse;
            RegardingobjectidAccountEmail = regardingobjectidAccountEmail;
            CreatedbyEmail = createdbyEmail;
            EmailsenderSystemuser = emailsenderSystemuser;
            RegardingobjectidContractEmail = regardingobjectidContractEmail;
            Templateid = templateid;
            StageidProcessstage = stageidProcessstage;
            RegardingobjectidContactEmail = regardingobjectidContactEmail;
            EmailQueueItem = emailQueueItem;
            Parentactivityid = parentactivityid;
            EmailEmailParentactivityid = emailEmailParentactivityid;
            RegardingobjectidQuoteEmail = regardingobjectidQuoteEmail;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reminderactioncardid")]
        public string Reminderactioncardid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "trackingtoken")]
        public string Trackingtoken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "readreceiptrequested")]
        public bool? Readreceiptrequested { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "compressed")]
        public bool? Compressed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailremindertext")]
        public string Emailremindertext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailtrackingid")]
        public string Emailtrackingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailreminderexpirytime")]
        public System.DateTimeOffset? Emailreminderexpirytime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isunsafe")]
        public int? Isunsafe { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentactivityid_value")]
        public string _parentactivityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postponeemailprocessinguntil")]
        public System.DateTimeOffset? Postponeemailprocessinguntil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replycount")]
        public int? Replycount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "directioncode")]
        public bool? Directioncode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "correlationmethod")]
        public int? Correlationmethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_sendersaccount_value")]
        public string _sendersaccountValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailreminderstatus")]
        public int? Emailreminderstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "linksclickedcount")]
        public int? Linksclickedcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "submittedby")]
        public string Submittedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_emailsender_value")]
        public string _emailsenderValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deliveryreceiptrequested")]
        public bool? Deliveryreceiptrequested { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications")]
        public int? Notifications { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "conversationtrackingid")]
        public string Conversationtrackingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deliveryattempts")]
        public int? Deliveryattempts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opencount")]
        public int? Opencount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "torecipients")]
        public string Torecipients { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "delayedemailsendtime")]
        public System.DateTimeOffset? Delayedemailsendtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "followemailuserpreference")]
        public bool? Followemailuserpreference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_templateid_value")]
        public string _templateidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inreplyto")]
        public string Inreplyto { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messageid")]
        public string Messageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachmentcount")]
        public int? Attachmentcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastopenedtime")]
        public System.DateTimeOffset? Lastopenedtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isemailreminderset")]
        public bool? Isemailreminderset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isemailfollowed")]
        public bool? Isemailfollowed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "conversationindex")]
        public string Conversationindex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailremindertype")]
        public int? Emailremindertype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseconversationindexhash")]
        public int? Baseconversationindexhash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sender")]
        public string Sender { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachmentopencount")]
        public int? Attachmentopencount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_email")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_email")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_email")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_email")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_email")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_msdyn_postalbum_email")]
        public MicrosoftDynamicsCRMmsdynPostalbum RegardingobjectidMsdynPostalbumEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_abs_scheduledprocess_email")]
        public MicrosoftDynamicsCRMabsScheduledprocess RegardingobjectidAbsScheduledprocessEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_application_email")]
        public MicrosoftDynamicsCRMadoxioApplication RegardingobjectidAdoxioApplicationEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complaint_email")]
        public MicrosoftDynamicsCRMadoxioComplaint RegardingobjectidAdoxioComplaintEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_investigation_email")]
        public MicrosoftDynamicsCRMadoxioInvestigation RegardingobjectidAdoxioInvestigationEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_licences_email")]
        public MicrosoftDynamicsCRMadoxioLicences RegardingobjectidAdoxioLicencesEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_worker_email")]
        public MicrosoftDynamicsCRMadoxioWorker RegardingobjectidAdoxioWorkerEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complianceinvestigation_email")]
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation RegardingobjectidAdoxioComplianceinvestigationEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_site_email")]
        public MicrosoftDynamicsCRMsite RegardingobjectidSiteEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_event_email")]
        public MicrosoftDynamicsCRMadoxioEvent RegardingobjectidAdoxioEventEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_enforcementaction_email")]
        public MicrosoftDynamicsCRMadoxioEnforcementaction RegardingobjectidAdoxioEnforcementactionEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_email")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> EmailSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_email")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_asyncoperation")]
        public MicrosoftDynamicsCRMasyncoperation RegardingobjectidAsyncoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sendersaccount")]
        public MicrosoftDynamicsCRMaccount Sendersaccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailsender_account")]
        public MicrosoftDynamicsCRMaccount EmailsenderAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_email")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_email_sla")]
        public MicrosoftDynamicsCRMsla SlaEmailSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorder_email")]
        public MicrosoftDynamicsCRMsalesorder RegardingobjectidSalesorderEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailsender_lead")]
        public MicrosoftDynamicsCRMlead EmailsenderLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> EmailAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_email")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EmailDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> EmailConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sendermailboxid_email")]
        public MicrosoftDynamicsCRMmailbox SendermailboxidEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email_activity_mime_attachment")]
        public IList<MicrosoftDynamicsCRMactivitymimeattachment> EmailActivityMimeAttachment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_email")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> EmailConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoice_email")]
        public MicrosoftDynamicsCRMinvoice RegardingobjectidInvoiceEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_email")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailsender_contact")]
        public MicrosoftDynamicsCRMcontact EmailsenderContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_email")]
        public MicrosoftDynamicsCRMsystemuser OwninguserEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_email")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_email")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_email")]
        public MicrosoftDynamicsCRMteam OwningteamEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_email")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailsender_queue")]
        public MicrosoftDynamicsCRMqueue EmailsenderQueue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_email_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidEmailSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> EmailAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> EmailBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> EmailProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_email")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> EmailActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_email")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailsender_equipment")]
        public MicrosoftDynamicsCRMequipment EmailsenderEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email_actioncard")]
        public IList<MicrosoftDynamicsCRMactioncard> EmailActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_email")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EmailDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_email")]
        public MicrosoftDynamicsCRMservice ServiceidEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> EmailPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_email")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email_campaignresponse")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> EmailCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_email")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_email")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailsender_systemuser")]
        public MicrosoftDynamicsCRMsystemuser EmailsenderSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contract_email")]
        public MicrosoftDynamicsCRMcontract RegardingobjectidContractEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "templateid")]
        public MicrosoftDynamicsCRMtemplate Templateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_email")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> EmailQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentactivityid")]
        public MicrosoftDynamicsCRMemail Parentactivityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email_email_parentactivityid")]
        public IList<MicrosoftDynamicsCRMemail> EmailEmailParentactivityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_email")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuoteEmail { get; set; }

    }
}
