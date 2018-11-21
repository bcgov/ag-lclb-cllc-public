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
    /// mailbox
    /// </summary>
    public partial class MicrosoftDynamicsCRMmailbox
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMmailbox
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMmailbox()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMmailbox
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMmailbox(int? testemailconfigurationretrycount = default(int?), bool? isactsyncorgflagset = default(bool?), System.DateTimeOffset? lastmailboxforcedunlockoccurredon = default(System.DateTimeOffset?), bool? isforwardmailbox = default(bool?), string _emailserverprofileValue = default(string), bool? isemailaddressapprovedbyo365admin = default(bool?), bool? orgmarkedasprimaryforexchangesync = default(bool?), int? actdeliverymethod = default(int?), int? mailboxprocessingcontext = default(int?), int? outgoingemaildeliverymethod = default(int?), string entityimageid = default(string), int? incomingemaildeliverymethod = default(int?), string lastsyncerror = default(string), int? noactcount = default(int?), string mailboxid = default(string), int? timezoneruleversionnumber = default(int?), int? forcedunlockcount = default(int?), System.DateTimeOffset? lastsuccessfulsynccompletedon = default(System.DateTimeOffset?), System.DateTimeOffset? lastautodiscoveredon = default(System.DateTimeOffset?), string _owninguserValue = default(string), bool? enabledforoutgoingemail = default(bool?), string _modifiedbyValue = default(string), object entityimage = default(object), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), long? versionnumber = default(long?), string _organizationidValue = default(string), int? lastduration = default(int?), bool? testemailconfigurationscheduled = default(bool?), int? itemsfailedforlastsync = default(int?), string officeappsdeploymenterror = default(string), bool? enabledforact = default(bool?), int? outgoingemailstatus = default(int?), int? lastsyncerrorcount = default(int?), string emailaddress = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? lastsyncerroroccurredon = default(System.DateTimeOffset?), bool? processanddeleteemails = default(bool?), int? itemsprocessedforlastsync = default(int?), long? entityimageTimestamp = default(long?), string folderhierarchy = default(string), System.DateTimeOffset? officeappsdeploymentcompleteon = default(System.DateTimeOffset?), System.DateTimeOffset? processinglastattemptedon = default(System.DateTimeOffset?), string username = default(string), bool? officeappsdeploymentscheduled = default(bool?), string _modifiedonbehalfbyValue = default(string), int? officeappsdeploymentstatus = default(int?), System.DateTimeOffset? postponesendinguntil = default(System.DateTimeOffset?), System.DateTimeOffset? postponetestemailconfigurationuntil = default(System.DateTimeOffset?), int? actstatus = default(int?), int? statuscode = default(int?), System.DateTimeOffset? lastsyncstartedon = default(System.DateTimeOffset?), int? processedtimes = default(int?), int? lastsyncerrorcode = default(int?), bool? ispasswordset = default(bool?), string _createdbyValue = default(string), string _owningteamValue = default(string), string _owneridValue = default(string), string lastsyncerrormachinename = default(string), string ewsurl = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? postponeofficeappsdeploymentuntil = default(System.DateTimeOffset?), System.DateTimeOffset? postponemailboxprocessinguntil = default(System.DateTimeOffset?), System.DateTimeOffset? processemailreceivedafter = default(System.DateTimeOffset?), System.DateTimeOffset? receivingpostponeduntil = default(System.DateTimeOffset?), int? emailrouteraccessapproval = default(int?), int? mailboxstatus = default(int?), int? noemailcount = default(int?), int? incomingemailstatus = default(int?), int? processingstatecode = default(int?), string password = default(string), bool? enabledforincomingemail = default(bool?), string name = default(string), string _owningbusinessunitValue = default(string), bool? isserviceaccount = default(bool?), int? statecode = default(int?), System.DateTimeOffset? testmailboxaccesscompletedon = default(System.DateTimeOffset?), string exchangesyncstatexml = default(string), string entityimageUrl = default(string), string _regardingobjectidValue = default(string), string undeliverablefolder = default(string), bool? allowemailconnectortousecredentials = default(bool?), int? averagetotalduration = default(int?), int? verboseloggingenabled = default(int?), System.DateTimeOffset? receivingpostponeduntilforact = default(System.DateTimeOffset?), string hostid = default(string), int? transientfailurecount = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser regardingobjectid = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMemailserverprofile emailserverprofile = default(MicrosoftDynamicsCRMemailserverprofile), IList<MicrosoftDynamicsCRMsystemuser> systemuserDefaultmailboxMailbox = default(IList<MicrosoftDynamicsCRMsystemuser>), IList<MicrosoftDynamicsCRMqueue> queueDefaultmailboxMailbox = default(IList<MicrosoftDynamicsCRMqueue>), IList<MicrosoftDynamicsCRMtracelog> tracelogMailbox = default(IList<MicrosoftDynamicsCRMtracelog>), IList<MicrosoftDynamicsCRMactivitypointer> activitypointerSendermailboxidMailbox = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMasyncoperation> mailboxAsyncoperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMqueue regardingobjectidQueue = default(MicrosoftDynamicsCRMqueue), IList<MicrosoftDynamicsCRMemail> emailSendermailboxidMailbox = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMsyncerror> mailboxSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMannotation> mailboxAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> absScheduledprocessexecutionMailboxSendermailboxid = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>))
        {
            Testemailconfigurationretrycount = testemailconfigurationretrycount;
            Isactsyncorgflagset = isactsyncorgflagset;
            Lastmailboxforcedunlockoccurredon = lastmailboxforcedunlockoccurredon;
            Isforwardmailbox = isforwardmailbox;
            this._emailserverprofileValue = _emailserverprofileValue;
            Isemailaddressapprovedbyo365admin = isemailaddressapprovedbyo365admin;
            Orgmarkedasprimaryforexchangesync = orgmarkedasprimaryforexchangesync;
            Actdeliverymethod = actdeliverymethod;
            Mailboxprocessingcontext = mailboxprocessingcontext;
            Outgoingemaildeliverymethod = outgoingemaildeliverymethod;
            Entityimageid = entityimageid;
            Incomingemaildeliverymethod = incomingemaildeliverymethod;
            Lastsyncerror = lastsyncerror;
            Noactcount = noactcount;
            Mailboxid = mailboxid;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Forcedunlockcount = forcedunlockcount;
            Lastsuccessfulsynccompletedon = lastsuccessfulsynccompletedon;
            Lastautodiscoveredon = lastautodiscoveredon;
            this._owninguserValue = _owninguserValue;
            Enabledforoutgoingemail = enabledforoutgoingemail;
            this._modifiedbyValue = _modifiedbyValue;
            Entityimage = entityimage;
            Createdon = createdon;
            Versionnumber = versionnumber;
            this._organizationidValue = _organizationidValue;
            Lastduration = lastduration;
            Testemailconfigurationscheduled = testemailconfigurationscheduled;
            Itemsfailedforlastsync = itemsfailedforlastsync;
            Officeappsdeploymenterror = officeappsdeploymenterror;
            Enabledforact = enabledforact;
            Outgoingemailstatus = outgoingemailstatus;
            Lastsyncerrorcount = lastsyncerrorcount;
            Emailaddress = emailaddress;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Lastsyncerroroccurredon = lastsyncerroroccurredon;
            Processanddeleteemails = processanddeleteemails;
            Itemsprocessedforlastsync = itemsprocessedforlastsync;
            EntityimageTimestamp = entityimageTimestamp;
            Folderhierarchy = folderhierarchy;
            Officeappsdeploymentcompleteon = officeappsdeploymentcompleteon;
            Processinglastattemptedon = processinglastattemptedon;
            Username = username;
            Officeappsdeploymentscheduled = officeappsdeploymentscheduled;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Officeappsdeploymentstatus = officeappsdeploymentstatus;
            Postponesendinguntil = postponesendinguntil;
            Postponetestemailconfigurationuntil = postponetestemailconfigurationuntil;
            Actstatus = actstatus;
            Statuscode = statuscode;
            Lastsyncstartedon = lastsyncstartedon;
            Processedtimes = processedtimes;
            Lastsyncerrorcode = lastsyncerrorcode;
            Ispasswordset = ispasswordset;
            this._createdbyValue = _createdbyValue;
            this._owningteamValue = _owningteamValue;
            this._owneridValue = _owneridValue;
            Lastsyncerrormachinename = lastsyncerrormachinename;
            Ewsurl = ewsurl;
            Modifiedon = modifiedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Postponeofficeappsdeploymentuntil = postponeofficeappsdeploymentuntil;
            Postponemailboxprocessinguntil = postponemailboxprocessinguntil;
            Processemailreceivedafter = processemailreceivedafter;
            Receivingpostponeduntil = receivingpostponeduntil;
            Emailrouteraccessapproval = emailrouteraccessapproval;
            Mailboxstatus = mailboxstatus;
            Noemailcount = noemailcount;
            Incomingemailstatus = incomingemailstatus;
            Processingstatecode = processingstatecode;
            Password = password;
            Enabledforincomingemail = enabledforincomingemail;
            Name = name;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Isserviceaccount = isserviceaccount;
            Statecode = statecode;
            Testmailboxaccesscompletedon = testmailboxaccesscompletedon;
            Exchangesyncstatexml = exchangesyncstatexml;
            EntityimageUrl = entityimageUrl;
            this._regardingobjectidValue = _regardingobjectidValue;
            Undeliverablefolder = undeliverablefolder;
            Allowemailconnectortousecredentials = allowemailconnectortousecredentials;
            Averagetotalduration = averagetotalduration;
            Verboseloggingenabled = verboseloggingenabled;
            Receivingpostponeduntilforact = receivingpostponeduntilforact;
            Hostid = hostid;
            Transientfailurecount = transientfailurecount;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Regardingobjectid = regardingobjectid;
            Emailserverprofile = emailserverprofile;
            SystemuserDefaultmailboxMailbox = systemuserDefaultmailboxMailbox;
            QueueDefaultmailboxMailbox = queueDefaultmailboxMailbox;
            TracelogMailbox = tracelogMailbox;
            ActivitypointerSendermailboxidMailbox = activitypointerSendermailboxidMailbox;
            MailboxAsyncoperations = mailboxAsyncoperations;
            RegardingobjectidQueue = regardingobjectidQueue;
            EmailSendermailboxidMailbox = emailSendermailboxidMailbox;
            MailboxSyncErrors = mailboxSyncErrors;
            MailboxAnnotation = mailboxAnnotation;
            Organizationid = organizationid;
            AbsScheduledprocessexecutionMailboxSendermailboxid = absScheduledprocessexecutionMailboxSendermailboxid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "testemailconfigurationretrycount")]
        public int? Testemailconfigurationretrycount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isactsyncorgflagset")]
        public bool? Isactsyncorgflagset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastmailboxforcedunlockoccurredon")]
        public System.DateTimeOffset? Lastmailboxforcedunlockoccurredon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isforwardmailbox")]
        public bool? Isforwardmailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_emailserverprofile_value")]
        public string _emailserverprofileValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isemailaddressapprovedbyo365admin")]
        public bool? Isemailaddressapprovedbyo365admin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orgmarkedasprimaryforexchangesync")]
        public bool? Orgmarkedasprimaryforexchangesync { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actdeliverymethod")]
        public int? Actdeliverymethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailboxprocessingcontext")]
        public int? Mailboxprocessingcontext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outgoingemaildeliverymethod")]
        public int? Outgoingemaildeliverymethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incomingemaildeliverymethod")]
        public int? Incomingemaildeliverymethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerror")]
        public string Lastsyncerror { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "noactcount")]
        public int? Noactcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailboxid")]
        public string Mailboxid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "forcedunlockcount")]
        public int? Forcedunlockcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsuccessfulsynccompletedon")]
        public System.DateTimeOffset? Lastsuccessfulsynccompletedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastautodiscoveredon")]
        public System.DateTimeOffset? Lastautodiscoveredon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabledforoutgoingemail")]
        public bool? Enabledforoutgoingemail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage")]
        public object Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastduration")]
        public int? Lastduration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "testemailconfigurationscheduled")]
        public bool? Testemailconfigurationscheduled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemsfailedforlastsync")]
        public int? Itemsfailedforlastsync { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "officeappsdeploymenterror")]
        public string Officeappsdeploymenterror { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabledforact")]
        public bool? Enabledforact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outgoingemailstatus")]
        public int? Outgoingemailstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerrorcount")]
        public int? Lastsyncerrorcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerroroccurredon")]
        public System.DateTimeOffset? Lastsyncerroroccurredon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processanddeleteemails")]
        public bool? Processanddeleteemails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemsprocessedforlastsync")]
        public int? Itemsprocessedforlastsync { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "folderhierarchy")]
        public string Folderhierarchy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "officeappsdeploymentcompleteon")]
        public System.DateTimeOffset? Officeappsdeploymentcompleteon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processinglastattemptedon")]
        public System.DateTimeOffset? Processinglastattemptedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "officeappsdeploymentscheduled")]
        public bool? Officeappsdeploymentscheduled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "officeappsdeploymentstatus")]
        public int? Officeappsdeploymentstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postponesendinguntil")]
        public System.DateTimeOffset? Postponesendinguntil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postponetestemailconfigurationuntil")]
        public System.DateTimeOffset? Postponetestemailconfigurationuntil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actstatus")]
        public int? Actstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncstartedon")]
        public System.DateTimeOffset? Lastsyncstartedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processedtimes")]
        public int? Processedtimes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerrorcode")]
        public int? Lastsyncerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispasswordset")]
        public bool? Ispasswordset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerrormachinename")]
        public string Lastsyncerrormachinename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ewsurl")]
        public string Ewsurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postponeofficeappsdeploymentuntil")]
        public System.DateTimeOffset? Postponeofficeappsdeploymentuntil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postponemailboxprocessinguntil")]
        public System.DateTimeOffset? Postponemailboxprocessinguntil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processemailreceivedafter")]
        public System.DateTimeOffset? Processemailreceivedafter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "receivingpostponeduntil")]
        public System.DateTimeOffset? Receivingpostponeduntil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailrouteraccessapproval")]
        public int? Emailrouteraccessapproval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailboxstatus")]
        public int? Mailboxstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "noemailcount")]
        public int? Noemailcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incomingemailstatus")]
        public int? Incomingemailstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processingstatecode")]
        public int? Processingstatecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabledforincomingemail")]
        public bool? Enabledforincomingemail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isserviceaccount")]
        public bool? Isserviceaccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "testmailboxaccesscompletedon")]
        public System.DateTimeOffset? Testmailboxaccesscompletedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangesyncstatexml")]
        public string Exchangesyncstatexml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "undeliverablefolder")]
        public string Undeliverablefolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowemailconnectortousecredentials")]
        public bool? Allowemailconnectortousecredentials { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "averagetotalduration")]
        public int? Averagetotalduration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "verboseloggingenabled")]
        public int? Verboseloggingenabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "receivingpostponeduntilforact")]
        public System.DateTimeOffset? Receivingpostponeduntilforact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostid")]
        public string Hostid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transientfailurecount")]
        public int? Transientfailurecount { get; set; }

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
        [JsonProperty(PropertyName = "regardingobjectid")]
        public MicrosoftDynamicsCRMsystemuser Regardingobjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailserverprofile")]
        public MicrosoftDynamicsCRMemailserverprofile Emailserverprofile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemuser_defaultmailbox_mailbox")]
        public IList<MicrosoftDynamicsCRMsystemuser> SystemuserDefaultmailboxMailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queue_defaultmailbox_mailbox")]
        public IList<MicrosoftDynamicsCRMqueue> QueueDefaultmailboxMailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tracelog_Mailbox")]
        public IList<MicrosoftDynamicsCRMtracelog> TracelogMailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activitypointer_sendermailboxid_mailbox")]
        public IList<MicrosoftDynamicsCRMactivitypointer> ActivitypointerSendermailboxidMailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailbox_asyncoperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MailboxAsyncoperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_queue")]
        public MicrosoftDynamicsCRMqueue RegardingobjectidQueue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email_sendermailboxid_mailbox")]
        public IList<MicrosoftDynamicsCRMemail> EmailSendermailboxidMailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Mailbox_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MailboxSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Mailbox_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> MailboxAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessexecution_mailbox_sendermailboxid")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> AbsScheduledprocessexecutionMailboxSendermailboxid { get; set; }

    }
}
