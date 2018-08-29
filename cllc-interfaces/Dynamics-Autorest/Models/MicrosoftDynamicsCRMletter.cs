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

    public partial class MicrosoftDynamicsCRMletter : MicrosoftDynamicsCRMactivitypointer
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMletter class.
        /// </summary>
        public MicrosoftDynamicsCRMletter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMletter class.
        /// </summary>
        public MicrosoftDynamicsCRMletter(string _owneridValue = default(string), string activityadditionalparams = default(string), object createdon = default(object), int? statuscode = default(int?), object modifiedon = default(object), string _regardingobjectidValue = default(string), object scheduledstart = default(object), object lastonholdtime = default(object), bool? isbilled = default(bool?), string _transactioncurrencyidValue = default(string), int? prioritycode = default(int?), string _sendermailboxidValue = default(string), int? scheduleddurationminutes = default(int?), string _owninguserValue = default(string), string exchangeweblink = default(string), string versionnumber = default(string), string _owningbusinessunitValue = default(string), string _modifiedonbehalfbyValue = default(string), object scheduledend = default(object), string _slainvokedidValue = default(string), object postponeactivityprocessinguntil = default(object), string _createdbyValue = default(string), int? deliveryprioritycode = default(int?), string _owningteamValue = default(string), bool? ismapiprivate = default(bool?), string traversedpath = default(string), object actualend = default(object), int? actualdurationminutes = default(int?), string _serviceidValue = default(string), int? instancetypecode = default(int?), string _createdonbehalfbyValue = default(string), string seriesid = default(string), string activityid = default(string), string description = default(string), bool? leftvoicemail = default(bool?), bool? isworkflowcreated = default(bool?), object senton = default(object), string processid = default(string), int? community = default(int?), string _modifiedbyValue = default(string), string exchangeitemid = default(string), int? statecode = default(int?), string activitytypecode = default(string), int? utcconversiontimezonecode = default(int?), object actualstart = default(object), string subject = default(string), object deliverylastattemptedon = default(object), int? timezoneruleversionnumber = default(int?), string stageid = default(string), int? onholdtime = default(int?), object sortdate = default(object), bool? isregularactivity = default(bool?), object exchangerate = default(object), string _slaidValue = default(string), MicrosoftDynamicsCRMinteractionforemail regardingobjectidNewInteractionforemail = default(MicrosoftDynamicsCRMinteractionforemail), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlement = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplate = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebooking = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheader = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecord = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMaccount regardingobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontract regardingobjectidContract = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcontact regardingobjectidContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMbulkoperationlog> createdActivityBulkOperationLogs = default(IList<MicrosoftDynamicsCRMbulkoperationlog>), IList<MicrosoftDynamicsCRMsocialactivity> activityPointerSocialactivity = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> activityPointerRecurringappointmentmaster = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMemail> activityPointerEmail = default(IList<MicrosoftDynamicsCRMemail>), MicrosoftDynamicsCRMmailbox sendermailboxid = default(MicrosoftDynamicsCRMmailbox), IList<MicrosoftDynamicsCRMquoteclose> activityPointerQuoteClose = default(IList<MicrosoftDynamicsCRMquoteclose>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMqueueitem> activityPointerQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorder = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkoperation> activityPointerBulkOperation = default(IList<MicrosoftDynamicsCRMbulkoperation>), IList<MicrosoftDynamicsCRMcampaignactivityitem> activityPointerCampaignActivityItems = default(IList<MicrosoftDynamicsCRMcampaignactivityitem>), MicrosoftDynamicsCRMsla slaActivitypointerSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMinvoice regardingobjectidInvoice = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMquote regardingobjectidQuote = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMlead regardingobjectidLead = default(MicrosoftDynamicsCRMlead), IList<MicrosoftDynamicsCRMcampaignresponse> activityPointerCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMserviceappointment> activityPointerServiceAppointment = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMactivitymimeattachment> activityPointerActivityMimeAttachment = default(IList<MicrosoftDynamicsCRMactivitymimeattachment>), IList<MicrosoftDynamicsCRMfax> activityPointerFax = default(IList<MicrosoftDynamicsCRMfax>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkoperationlog> activityPointerBulkOperationLogs = default(IList<MicrosoftDynamicsCRMbulkoperationlog>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperation = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMservice serviceid = default(MicrosoftDynamicsCRMservice), IList<MicrosoftDynamicsCRMtask> activityPointerTask = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMopportunityclose> activityPointerOpportunityClose = default(IList<MicrosoftDynamicsCRMopportunityclose>), MicrosoftDynamicsCRMincident regardingobjectidIncident = default(MicrosoftDynamicsCRMincident), IList<MicrosoftDynamicsCRMcampaignresponse> activityCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMcampaignactivity> activityPointerCampaignactivity = default(IList<MicrosoftDynamicsCRMcampaignactivity>), IList<MicrosoftDynamicsCRMphonecall> activityPointerPhonecall = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMappointment> activityPointerAppointment = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMorderclose> activityPointerOrderClose = default(IList<MicrosoftDynamicsCRMorderclose>), MicrosoftDynamicsCRMcampaign regardingobjectidCampaign = default(MicrosoftDynamicsCRMcampaign), IList<MicrosoftDynamicsCRMincidentresolution> activityPointerIncidentResolution = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMletter> activityPointerLetter = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMconnection> activitypointerConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceActivitypointer = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), IList<MicrosoftDynamicsCRMbulkdeletefailure> activityPointerBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsla slainvokedidActivitypointerSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMconnection> activitypointerConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMasyncoperation> activityPointerAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMactivityparty> activitypointerActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMadoxioAgencycommunication regardingobjectidAdoxioAgencycommunication = default(MicrosoftDynamicsCRMadoxioAgencycommunication), MicrosoftDynamicsCRMadoxioApplication regardingobjectidAdoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioInvestigationstakeholder regardingobjectidAdoxioInvestigationstakeholder = default(MicrosoftDynamicsCRMadoxioInvestigationstakeholder), MicrosoftDynamicsCRMadoxioLicences regardingobjectidAdoxioLicences = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioComplaint regardingobjectidAdoxioComplaint = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioInvestigation regardingobjectidAdoxioInvestigation = default(MicrosoftDynamicsCRMadoxioInvestigation), string category = default(string), object overriddencreatedon = default(object), string address = default(string), bool? directioncode = default(bool?), int? importsequencenumber = default(int?), string subcategory = default(string), string subscriptionid = default(string), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementLetter = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateLetter = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingLetter = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderLetter = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordLetter = default(MicrosoftDynamicsCRMknowledgebaserecord), IList<MicrosoftDynamicsCRMactioncard> letterActioncard = default(IList<MicrosoftDynamicsCRMactioncard>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceLetter = default(IList<MicrosoftDynamicsCRMslakpiinstance>), IList<MicrosoftDynamicsCRMcampaignresponse> letterCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignLetter = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyLetter = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyLetter = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMconnection> letterConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMbulkdeletefailure> letterBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMquote regardingobjectidQuoteLetter = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleLetter = default(MicrosoftDynamicsCRMknowledgearticle), IList<MicrosoftDynamicsCRMsyncerror> letterSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMbusinessunit owningbusinessunitLetter = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMannotation> letterAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMinvoice regardingobjectidInvoiceLetter = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMsla slainvokedidLetterSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorderLetter = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMteam owningteamLetter = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityLetter = default(MicrosoftDynamicsCRMcampaignactivity), IList<MicrosoftDynamicsCRMactivityparty> letterActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMservice serviceidLetter = default(MicrosoftDynamicsCRMservice), IList<MicrosoftDynamicsCRMasyncoperation> letterAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMcontract regardingobjectidContractLetter = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidLetter = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationLetter = default(MicrosoftDynamicsCRMbulkoperation), IList<MicrosoftDynamicsCRMconnection> letterConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMsystemuser owninguserLetter = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> letterDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityLetter = default(MicrosoftDynamicsCRMopportunity), IList<MicrosoftDynamicsCRMqueueitem> letterQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMincident regardingobjectidIncidentLetter = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMsystemuser modifiedbyLetter = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMlead regardingobjectidLeadLetter = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMsla slaLetterSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsystemuser createdbyLetter = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> letterDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMaccount regardingobjectidAccountLetter = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact regardingobjectidContactLetter = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMadoxioAgencycommunication regardingobjectidAdoxioAgencycommunicationLetter = default(MicrosoftDynamicsCRMadoxioAgencycommunication), MicrosoftDynamicsCRMadoxioApplication regardingobjectidAdoxioApplicationLetter = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioInvestigationstakeholder regardingobjectidAdoxioInvestigationstakeholderLetter = default(MicrosoftDynamicsCRMadoxioInvestigationstakeholder), MicrosoftDynamicsCRMadoxioLicences regardingobjectidAdoxioLicencesLetter = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioComplaint regardingobjectidAdoxioComplaintLetter = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioInvestigation regardingobjectidAdoxioInvestigationLetter = default(MicrosoftDynamicsCRMadoxioInvestigation))
            : base(_owneridValue, activityadditionalparams, createdon, statuscode, modifiedon, _regardingobjectidValue, scheduledstart, lastonholdtime, isbilled, _transactioncurrencyidValue, prioritycode, _sendermailboxidValue, scheduleddurationminutes, _owninguserValue, exchangeweblink, versionnumber, _owningbusinessunitValue, _modifiedonbehalfbyValue, scheduledend, _slainvokedidValue, postponeactivityprocessinguntil, _createdbyValue, deliveryprioritycode, _owningteamValue, ismapiprivate, traversedpath, actualend, actualdurationminutes, _serviceidValue, instancetypecode, _createdonbehalfbyValue, seriesid, activityid, description, leftvoicemail, isworkflowcreated, senton, processid, community, _modifiedbyValue, exchangeitemid, statecode, activitytypecode, utcconversiontimezonecode, actualstart, subject, deliverylastattemptedon, timezoneruleversionnumber, stageid, onholdtime, sortdate, isregularactivity, exchangerate, _slaidValue, regardingobjectidNewInteractionforemail, regardingobjectidEntitlement, regardingobjectidEntitlementtemplate, regardingobjectidBookableresourcebooking, regardingobjectidBookableresourcebookingheader, regardingobjectidKnowledgebaserecord, regardingobjectidAccount, regardingobjectidContract, createdby, regardingobjectidContact, createdActivityBulkOperationLogs, activityPointerSocialactivity, activityPointerRecurringappointmentmaster, activityPointerEmail, sendermailboxid, activityPointerQuoteClose, transactioncurrencyid, activityPointerQueueItem, regardingobjectidSalesorder, ownerid, regardingobjectidOpportunity, owninguser, activityPointerBulkOperation, activityPointerCampaignActivityItems, slaActivitypointerSla, regardingobjectidInvoice, owningbusinessunit, regardingobjectidKnowledgearticle, regardingobjectidQuote, regardingobjectidLead, activityPointerCampaignresponse, modifiedonbehalfby, activityPointerServiceAppointment, activityPointerActivityMimeAttachment, activityPointerFax, createdonbehalfby, activityPointerBulkOperationLogs, modifiedby, regardingobjectidBulkoperation, serviceid, activityPointerTask, activityPointerOpportunityClose, regardingobjectidIncident, activityCampaignresponse, activityPointerCampaignactivity, activityPointerPhonecall, activityPointerAppointment, activityPointerOrderClose, regardingobjectidCampaign, activityPointerIncidentResolution, activityPointerLetter, activitypointerConnections2, slakpiinstanceActivitypointer, owningteam, regardingobjectidCampaignactivity, activityPointerBulkDeleteFailures, slainvokedidActivitypointerSla, activitypointerConnections1, activityPointerAsyncOperations, activitypointerActivityParties, regardingobjectidAdoxioAgencycommunication, regardingobjectidAdoxioApplication, regardingobjectidAdoxioInvestigationstakeholder, regardingobjectidAdoxioLicences, regardingobjectidAdoxioComplaint, regardingobjectidAdoxioInvestigation)
        {
            Category = category;
            Overriddencreatedon = overriddencreatedon;
            Address = address;
            Directioncode = directioncode;
            Importsequencenumber = importsequencenumber;
            Subcategory = subcategory;
            Subscriptionid = subscriptionid;
            RegardingobjectidEntitlementLetter = regardingobjectidEntitlementLetter;
            RegardingobjectidEntitlementtemplateLetter = regardingobjectidEntitlementtemplateLetter;
            RegardingobjectidBookableresourcebookingLetter = regardingobjectidBookableresourcebookingLetter;
            RegardingobjectidBookableresourcebookingheaderLetter = regardingobjectidBookableresourcebookingheaderLetter;
            RegardingobjectidKnowledgebaserecordLetter = regardingobjectidKnowledgebaserecordLetter;
            LetterActioncard = letterActioncard;
            SlakpiinstanceLetter = slakpiinstanceLetter;
            LetterCampaignresponse = letterCampaignresponse;
            RegardingobjectidCampaignLetter = regardingobjectidCampaignLetter;
            StageidProcessstage = stageidProcessstage;
            ModifiedonbehalfbyLetter = modifiedonbehalfbyLetter;
            CreatedonbehalfbyLetter = createdonbehalfbyLetter;
            LetterConnections2 = letterConnections2;
            LetterBulkDeleteFailures = letterBulkDeleteFailures;
            RegardingobjectidQuoteLetter = regardingobjectidQuoteLetter;
            RegardingobjectidKnowledgearticleLetter = regardingobjectidKnowledgearticleLetter;
            LetterSyncErrors = letterSyncErrors;
            OwningbusinessunitLetter = owningbusinessunitLetter;
            LetterAnnotation = letterAnnotation;
            RegardingobjectidInvoiceLetter = regardingobjectidInvoiceLetter;
            SlainvokedidLetterSla = slainvokedidLetterSla;
            RegardingobjectidSalesorderLetter = regardingobjectidSalesorderLetter;
            OwningteamLetter = owningteamLetter;
            RegardingobjectidCampaignactivityLetter = regardingobjectidCampaignactivityLetter;
            LetterActivityParties = letterActivityParties;
            ServiceidLetter = serviceidLetter;
            LetterAsyncOperations = letterAsyncOperations;
            RegardingobjectidContractLetter = regardingobjectidContractLetter;
            TransactioncurrencyidLetter = transactioncurrencyidLetter;
            RegardingobjectidBulkoperationLetter = regardingobjectidBulkoperationLetter;
            LetterConnections1 = letterConnections1;
            OwninguserLetter = owninguserLetter;
            LetterDuplicateBaseRecord = letterDuplicateBaseRecord;
            RegardingobjectidOpportunityLetter = regardingobjectidOpportunityLetter;
            LetterQueueItem = letterQueueItem;
            ActivityidActivitypointer = activityidActivitypointer;
            RegardingobjectidIncidentLetter = regardingobjectidIncidentLetter;
            ModifiedbyLetter = modifiedbyLetter;
            RegardingobjectidLeadLetter = regardingobjectidLeadLetter;
            SlaLetterSla = slaLetterSla;
            CreatedbyLetter = createdbyLetter;
            LetterDuplicateMatchingRecord = letterDuplicateMatchingRecord;
            RegardingobjectidAccountLetter = regardingobjectidAccountLetter;
            RegardingobjectidContactLetter = regardingobjectidContactLetter;
            RegardingobjectidAdoxioAgencycommunicationLetter = regardingobjectidAdoxioAgencycommunicationLetter;
            RegardingobjectidAdoxioApplicationLetter = regardingobjectidAdoxioApplicationLetter;
            RegardingobjectidAdoxioInvestigationstakeholderLetter = regardingobjectidAdoxioInvestigationstakeholderLetter;
            RegardingobjectidAdoxioLicencesLetter = regardingobjectidAdoxioLicencesLetter;
            RegardingobjectidAdoxioComplaintLetter = regardingobjectidAdoxioComplaintLetter;
            RegardingobjectidAdoxioInvestigationLetter = regardingobjectidAdoxioInvestigationLetter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public object Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "directioncode")]
        public bool? Directioncode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionid")]
        public string Subscriptionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_letter")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_letter")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_letter")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_letter")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_letter")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "letter_actioncard")]
        public IList<MicrosoftDynamicsCRMactioncard> LetterActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_letter")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "letter_campaignresponse")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> LetterCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_letter")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_letter")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_letter")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "letter_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> LetterConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> LetterBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_letter")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuoteLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_letter")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> LetterSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_letter")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> LetterAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoice_letter")]
        public MicrosoftDynamicsCRMinvoice RegardingobjectidInvoiceLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_letter_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidLetterSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorder_letter")]
        public MicrosoftDynamicsCRMsalesorder RegardingobjectidSalesorderLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_letter")]
        public MicrosoftDynamicsCRMteam OwningteamLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_letter")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "letter_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> LetterActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_letter")]
        public MicrosoftDynamicsCRMservice ServiceidLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> LetterAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contract_letter")]
        public MicrosoftDynamicsCRMcontract RegardingobjectidContractLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_letter")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_letter")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "letter_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> LetterConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_letter")]
        public MicrosoftDynamicsCRMsystemuser OwninguserLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> LetterDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_letter")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> LetterQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_letter")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_letter")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_letter")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_letter_sla")]
        public MicrosoftDynamicsCRMsla SlaLetterSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_letter")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Letter_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> LetterDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_letter")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_letter")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_agencycommunication_letter")]
        public MicrosoftDynamicsCRMadoxioAgencycommunication RegardingobjectidAdoxioAgencycommunicationLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_application_letter")]
        public MicrosoftDynamicsCRMadoxioApplication RegardingobjectidAdoxioApplicationLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_investigationstakeholder_letter")]
        public MicrosoftDynamicsCRMadoxioInvestigationstakeholder RegardingobjectidAdoxioInvestigationstakeholderLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_licences_letter")]
        public MicrosoftDynamicsCRMadoxioLicences RegardingobjectidAdoxioLicencesLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complaint_letter")]
        public MicrosoftDynamicsCRMadoxioComplaint RegardingobjectidAdoxioComplaintLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_investigation_letter")]
        public MicrosoftDynamicsCRMadoxioInvestigation RegardingobjectidAdoxioInvestigationLetter { get; set; }

    }
}
