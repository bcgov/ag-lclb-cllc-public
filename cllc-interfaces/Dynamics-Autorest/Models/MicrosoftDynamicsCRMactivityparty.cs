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
    /// Microsoft.Dynamics.CRM.activityparty
    /// </summary>
    public partial class MicrosoftDynamicsCRMactivityparty
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMactivityparty
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMactivityparty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMactivityparty
        /// class.
        /// </summary>
        /// <param name="donotemail">Information about whether to allow sending
        /// email to the activity party.</param>
        /// <param name="scheduledend">Scheduled end time of the
        /// activity.</param>
        /// <param name="_partyidValue">Unique identifier of the party
        /// associated with the activity.</param>
        /// <param name="_activityidValue">Unique identifier of the activity
        /// associated with the activity party. (A "party" is any person who is
        /// associated with an activity.)</param>
        /// <param name="exchangeentryid">For internal use only.</param>
        /// <param name="activitypartyid">Unique identifier of the activity
        /// party.</param>
        /// <param name="donotpostalmail">Information about whether to allow
        /// sending postal mail to the lead.</param>
        /// <param name="participationtypemask">Role of the person in the
        /// activity, such as sender, to, cc, bcc, required, optional,
        /// organizer, regarding, or owner.</param>
        /// <param name="scheduledstart">Scheduled start time of the
        /// activity.</param>
        /// <param name="_owneridValue">Unique identifier of the user or team
        /// who owns the activity_party.</param>
        /// <param name="effort">Amount of effort used by the resource in a
        /// service appointment activity.</param>
        /// <param name="instancetypecode">Type of instance of a recurring
        /// series.</param>
        /// <param name="donotphone">Information about whether to allow phone
        /// calls to the lead.</param>
        /// <param name="ispartydeleted">Information about whether the
        /// underlying entity record is deleted.</param>
        /// <param name="addressusedemailcolumnnumber">Email address column
        /// number from associated party.</param>
        /// <param name="donotfax">Information about whether to allow sending
        /// faxes to the activity party.</param>
        /// <param name="addressused">Email address to which an email is
        /// delivered, and which is associated with the target entity.</param>
        /// <param name="_resourcespecidValue">Unique identifier of the
        /// resource specification for the activity party.</param>
        public MicrosoftDynamicsCRMactivityparty(bool? donotemail = default(bool?), System.DateTimeOffset? scheduledend = default(System.DateTimeOffset?), string _partyidValue = default(string), string _activityidValue = default(string), string exchangeentryid = default(string), string activitypartyid = default(string), bool? donotpostalmail = default(bool?), string versionnumber = default(string), int? participationtypemask = default(int?), System.DateTimeOffset? scheduledstart = default(System.DateTimeOffset?), string _owneridValue = default(string), decimal? effort = default(decimal?), int? instancetypecode = default(int?), bool? donotphone = default(bool?), bool? ispartydeleted = default(bool?), int? addressusedemailcolumnnumber = default(int?), bool? donotfax = default(bool?), string addressused = default(string), string _resourcespecidValue = default(string), MicrosoftDynamicsCRMcampaignactivity partyidCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMincident partyidIncident = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMserviceappointment activityidServiceappointment = default(MicrosoftDynamicsCRMserviceappointment), IList<MicrosoftDynamicsCRMsyncerror> activityPartySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMrecurringappointmentmaster activityidRecurringappointmentmaster = default(MicrosoftDynamicsCRMrecurringappointmentmaster), MicrosoftDynamicsCRMinvoice partyidInvoice = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMcontract partyidContract = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMcampaignactivity activityidCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMsocialactivity activityidSocialactivity = default(MicrosoftDynamicsCRMsocialactivity), MicrosoftDynamicsCRMappointment activityidAppointment = default(MicrosoftDynamicsCRMappointment), MicrosoftDynamicsCRMqueue partyidQueue = default(MicrosoftDynamicsCRMqueue), MicrosoftDynamicsCRMsystemuser partyidSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMfax activityidFax = default(MicrosoftDynamicsCRMfax), MicrosoftDynamicsCRMsalesorder partyidSalesorder = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMphonecall activityidPhonecall = default(MicrosoftDynamicsCRMphonecall), MicrosoftDynamicsCRMtask activityidTask = default(MicrosoftDynamicsCRMtask), MicrosoftDynamicsCRMcampaignresponse activityidCampaignresponse = default(MicrosoftDynamicsCRMcampaignresponse), MicrosoftDynamicsCRMquoteclose activityidQuoteclose = default(MicrosoftDynamicsCRMquoteclose), MicrosoftDynamicsCRMresourcespec resourcespecid = default(MicrosoftDynamicsCRMresourcespec), MicrosoftDynamicsCRMletter activityidLetter = default(MicrosoftDynamicsCRMletter), MicrosoftDynamicsCRMorderclose activityidOrderclose = default(MicrosoftDynamicsCRMorderclose), MicrosoftDynamicsCRMbulkoperation partyidBulkoperation = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMquote partyidQuote = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMemail activityidEmail = default(MicrosoftDynamicsCRMemail), MicrosoftDynamicsCRMknowledgearticle partyidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMlead partyidLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMopportunityclose activityidOpportunityclose = default(MicrosoftDynamicsCRMopportunityclose), MicrosoftDynamicsCRMequipment partyidEquipment = default(MicrosoftDynamicsCRMequipment), MicrosoftDynamicsCRMopportunity partyidOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMcampaign partyidCampaign = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMaccount partyidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMincidentresolution activityidIncidentresolution = default(MicrosoftDynamicsCRMincidentresolution), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMcontact partyidContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMadoxioApplication partyidAdoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMabsScheduledprocessexecution activityidAbsScheduledprocessexecutionActivityparty = default(MicrosoftDynamicsCRMabsScheduledprocessexecution), MicrosoftDynamicsCRMadoxioLicences partyidAdoxioLicences = default(MicrosoftDynamicsCRMadoxioLicences))
        {
            Donotemail = donotemail;
            Scheduledend = scheduledend;
            this._partyidValue = _partyidValue;
            this._activityidValue = _activityidValue;
            Exchangeentryid = exchangeentryid;
            Activitypartyid = activitypartyid;
            Donotpostalmail = donotpostalmail;
            Versionnumber = versionnumber;
            Participationtypemask = participationtypemask;
            Scheduledstart = scheduledstart;
            this._owneridValue = _owneridValue;
            Effort = effort;
            Instancetypecode = instancetypecode;
            Donotphone = donotphone;
            Ispartydeleted = ispartydeleted;
            Addressusedemailcolumnnumber = addressusedemailcolumnnumber;
            Donotfax = donotfax;
            Addressused = addressused;
            this._resourcespecidValue = _resourcespecidValue;
            PartyidCampaignactivity = partyidCampaignactivity;
            PartyidIncident = partyidIncident;
            ActivityidServiceappointment = activityidServiceappointment;
            ActivityPartySyncErrors = activityPartySyncErrors;
            ActivityidRecurringappointmentmaster = activityidRecurringappointmentmaster;
            PartyidInvoice = partyidInvoice;
            PartyidContract = partyidContract;
            ActivityidCampaignactivity = activityidCampaignactivity;
            ActivityidSocialactivity = activityidSocialactivity;
            ActivityidAppointment = activityidAppointment;
            PartyidQueue = partyidQueue;
            PartyidSystemuser = partyidSystemuser;
            ActivityidFax = activityidFax;
            PartyidSalesorder = partyidSalesorder;
            ActivityidPhonecall = activityidPhonecall;
            ActivityidTask = activityidTask;
            ActivityidCampaignresponse = activityidCampaignresponse;
            ActivityidQuoteclose = activityidQuoteclose;
            Resourcespecid = resourcespecid;
            ActivityidLetter = activityidLetter;
            ActivityidOrderclose = activityidOrderclose;
            PartyidBulkoperation = partyidBulkoperation;
            PartyidQuote = partyidQuote;
            ActivityidEmail = activityidEmail;
            PartyidKnowledgearticle = partyidKnowledgearticle;
            PartyidLead = partyidLead;
            ActivityidOpportunityclose = activityidOpportunityclose;
            PartyidEquipment = partyidEquipment;
            PartyidOpportunity = partyidOpportunity;
            PartyidCampaign = partyidCampaign;
            PartyidAccount = partyidAccount;
            ActivityidIncidentresolution = activityidIncidentresolution;
            ActivityidActivitypointer = activityidActivitypointer;
            PartyidContact = partyidContact;
            PartyidAdoxioApplication = partyidAdoxioApplication;
            ActivityidAbsScheduledprocessexecutionActivityparty = activityidAbsScheduledprocessexecutionActivityparty;
            PartyidAdoxioLicences = partyidAdoxioLicences;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets information about whether to allow sending email to
        /// the activity party.
        /// </summary>
        [JsonProperty(PropertyName = "donotemail")]
        public bool? Donotemail { get; set; }

        /// <summary>
        /// Gets or sets scheduled end time of the activity.
        /// </summary>
        [JsonProperty(PropertyName = "scheduledend")]
        public System.DateTimeOffset? Scheduledend { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the party associated with the
        /// activity.
        /// </summary>
        [JsonProperty(PropertyName = "_partyid_value")]
        public string _partyidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the activity associated with the
        /// activity party. (A "party" is any person who is associated with an
        /// activity.)
        /// </summary>
        [JsonProperty(PropertyName = "_activityid_value")]
        public string _activityidValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "exchangeentryid")]
        public string Exchangeentryid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the activity party.
        /// </summary>
        [JsonProperty(PropertyName = "activitypartyid")]
        public string Activitypartyid { get; set; }

        /// <summary>
        /// Gets or sets information about whether to allow sending postal mail
        /// to the lead.
        /// </summary>
        [JsonProperty(PropertyName = "donotpostalmail")]
        public bool? Donotpostalmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets role of the person in the activity, such as sender,
        /// to, cc, bcc, required, optional, organizer, regarding, or owner.
        /// </summary>
        [JsonProperty(PropertyName = "participationtypemask")]
        public int? Participationtypemask { get; set; }

        /// <summary>
        /// Gets or sets scheduled start time of the activity.
        /// </summary>
        [JsonProperty(PropertyName = "scheduledstart")]
        public System.DateTimeOffset? Scheduledstart { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user or team who owns the
        /// activity_party.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets amount of effort used by the resource in a service
        /// appointment activity.
        /// </summary>
        [JsonProperty(PropertyName = "effort")]
        public decimal? Effort { get; set; }

        /// <summary>
        /// Gets or sets type of instance of a recurring series.
        /// </summary>
        [JsonProperty(PropertyName = "instancetypecode")]
        public int? Instancetypecode { get; set; }

        /// <summary>
        /// Gets or sets information about whether to allow phone calls to the
        /// lead.
        /// </summary>
        [JsonProperty(PropertyName = "donotphone")]
        public bool? Donotphone { get; set; }

        /// <summary>
        /// Gets or sets information about whether the underlying entity record
        /// is deleted.
        /// </summary>
        [JsonProperty(PropertyName = "ispartydeleted")]
        public bool? Ispartydeleted { get; set; }

        /// <summary>
        /// Gets or sets email address column number from associated party.
        /// </summary>
        [JsonProperty(PropertyName = "addressusedemailcolumnnumber")]
        public int? Addressusedemailcolumnnumber { get; set; }

        /// <summary>
        /// Gets or sets information about whether to allow sending faxes to
        /// the activity party.
        /// </summary>
        [JsonProperty(PropertyName = "donotfax")]
        public bool? Donotfax { get; set; }

        /// <summary>
        /// Gets or sets email address to which an email is delivered, and
        /// which is associated with the target entity.
        /// </summary>
        [JsonProperty(PropertyName = "addressused")]
        public string Addressused { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the resource specification for
        /// the activity party.
        /// </summary>
        [JsonProperty(PropertyName = "_resourcespecid_value")]
        public string _resourcespecidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_campaignactivity")]
        public MicrosoftDynamicsCRMcampaignactivity PartyidCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_incident")]
        public MicrosoftDynamicsCRMincident PartyidIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_serviceappointment")]
        public MicrosoftDynamicsCRMserviceappointment ActivityidServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityParty_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ActivityPartySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMrecurringappointmentmaster ActivityidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_invoice")]
        public MicrosoftDynamicsCRMinvoice PartyidInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_contract")]
        public MicrosoftDynamicsCRMcontract PartyidContract { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_campaignactivity")]
        public MicrosoftDynamicsCRMcampaignactivity ActivityidCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_socialactivity")]
        public MicrosoftDynamicsCRMsocialactivity ActivityidSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_appointment")]
        public MicrosoftDynamicsCRMappointment ActivityidAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_queue")]
        public MicrosoftDynamicsCRMqueue PartyidQueue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser PartyidSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_fax")]
        public MicrosoftDynamicsCRMfax ActivityidFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_salesorder")]
        public MicrosoftDynamicsCRMsalesorder PartyidSalesorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_phonecall")]
        public MicrosoftDynamicsCRMphonecall ActivityidPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_task")]
        public MicrosoftDynamicsCRMtask ActivityidTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_campaignresponse")]
        public MicrosoftDynamicsCRMcampaignresponse ActivityidCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_quoteclose")]
        public MicrosoftDynamicsCRMquoteclose ActivityidQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcespecid")]
        public MicrosoftDynamicsCRMresourcespec Resourcespecid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_letter")]
        public MicrosoftDynamicsCRMletter ActivityidLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_orderclose")]
        public MicrosoftDynamicsCRMorderclose ActivityidOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_bulkoperation")]
        public MicrosoftDynamicsCRMbulkoperation PartyidBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_quote")]
        public MicrosoftDynamicsCRMquote PartyidQuote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_email")]
        public MicrosoftDynamicsCRMemail ActivityidEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_knowledgearticle")]
        public MicrosoftDynamicsCRMknowledgearticle PartyidKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_lead")]
        public MicrosoftDynamicsCRMlead PartyidLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_opportunityclose")]
        public MicrosoftDynamicsCRMopportunityclose ActivityidOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_equipment")]
        public MicrosoftDynamicsCRMequipment PartyidEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_opportunity")]
        public MicrosoftDynamicsCRMopportunity PartyidOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_campaign")]
        public MicrosoftDynamicsCRMcampaign PartyidCampaign { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_account")]
        public MicrosoftDynamicsCRMaccount PartyidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_incidentresolution")]
        public MicrosoftDynamicsCRMincidentresolution ActivityidIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_contact")]
        public MicrosoftDynamicsCRMcontact PartyidContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_adoxio_application")]
        public MicrosoftDynamicsCRMadoxioApplication PartyidAdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_abs_scheduledprocessexecution_activityparty")]
        public MicrosoftDynamicsCRMabsScheduledprocessexecution ActivityidAbsScheduledprocessexecutionActivityparty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyid_adoxio_licences")]
        public MicrosoftDynamicsCRMadoxioLicences PartyidAdoxioLicences { get; set; }

    }
}
