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
    /// Microsoft.Dynamics.CRM.feedback
    /// </summary>
    public partial class MicrosoftDynamicsCRMfeedback
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMfeedback
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMfeedback()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMfeedback
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMfeedback(string versionnumber = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statuscode = default(int?), string _modifiedbyValue = default(string), System.DateTimeOffset? closedon = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? statecode = default(int?), string _regardingobjectidValue = default(string), string title = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? rating = default(int?), string _createdbycontactValue = default(string), string comments = default(string), string feedbackid = default(string), int? maxrating = default(int?), string _closedbyValue = default(string), string _createdbyValue = default(string), int? importsequencenumber = default(int?), int? source = default(int?), string _owningbusinessunitValue = default(string), string _createdonbehalfbycontactValue = default(string), decimal? exchangerate = default(decimal?), string _owningteamValue = default(string), string _owninguserValue = default(string), string _modifiedonbehalfbyValue = default(string), string _transactioncurrencyidValue = default(string), decimal? normalizedrating = default(decimal?), int? minrating = default(int?), string _owneridValue = default(string), MicrosoftDynamicsCRMabsScheduledprocessexecution regardingobjectidAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMabsScheduledprocessexecution), MicrosoftDynamicsCRMcontact contactId = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMcontact createdOnBehalfByContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> feedbackPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser modifiedOnBehalfBy = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser closedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcontact createdByContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMfeedback feedbackId = default(MicrosoftDynamicsCRMfeedback), IList<MicrosoftDynamicsCRMfeedback> feedbackFeedback = default(IList<MicrosoftDynamicsCRMfeedback>), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> feedbackSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMknowledgearticle knowledgeArticleId = default(MicrosoftDynamicsCRMknowledgearticle))
        {
            Versionnumber = versionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            Statuscode = statuscode;
            this._modifiedbyValue = _modifiedbyValue;
            Closedon = closedon;
            Overriddencreatedon = overriddencreatedon;
            Statecode = statecode;
            this._regardingobjectidValue = _regardingobjectidValue;
            Title = title;
            Createdon = createdon;
            Rating = rating;
            this._createdbycontactValue = _createdbycontactValue;
            Comments = comments;
            Feedbackid = feedbackid;
            Maxrating = maxrating;
            this._closedbyValue = _closedbyValue;
            this._createdbyValue = _createdbyValue;
            Importsequencenumber = importsequencenumber;
            Source = source;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._createdonbehalfbycontactValue = _createdonbehalfbycontactValue;
            Exchangerate = exchangerate;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Normalizedrating = normalizedrating;
            Minrating = minrating;
            this._owneridValue = _owneridValue;
            RegardingobjectidAbsScheduledprocessexecution = regardingobjectidAbsScheduledprocessexecution;
            ContactId = contactId;
            CreatedOnBehalfByContact = createdOnBehalfByContact;
            FeedbackPrincipalobjectattributeaccess = feedbackPrincipalobjectattributeaccess;
            Modifiedby = modifiedby;
            Ownerid = ownerid;
            Transactioncurrencyid = transactioncurrencyid;
            ModifiedOnBehalfBy = modifiedOnBehalfBy;
            Closedby = closedby;
            Createdonbehalfby = createdonbehalfby;
            CreatedByContact = createdByContact;
            Createdby = createdby;
            FeedbackId = feedbackId;
            FeedbackFeedback = feedbackFeedback;
            Owningbusinessunit = owningbusinessunit;
            FeedbackSyncErrors = feedbackSyncErrors;
            KnowledgeArticleId = knowledgeArticleId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "closedon")]
        public System.DateTimeOffset? Closedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rating")]
        public int? Rating { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdbycontact_value")]
        public string _createdbycontactValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "feedbackid")]
        public string Feedbackid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxrating")]
        public int? Maxrating { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_closedby_value")]
        public string _closedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public int? Source { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfbycontact_value")]
        public string _createdonbehalfbycontactValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "normalizedrating")]
        public decimal? Normalizedrating { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minrating")]
        public int? Minrating { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMabsScheduledprocessexecution RegardingobjectidAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContactId")]
        public MicrosoftDynamicsCRMcontact ContactId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedOnBehalfByContact")]
        public MicrosoftDynamicsCRMcontact CreatedOnBehalfByContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "feedback_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> FeedbackPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ModifiedOnBehalfBy")]
        public MicrosoftDynamicsCRMsystemuser ModifiedOnBehalfBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "closedby")]
        public MicrosoftDynamicsCRMsystemuser Closedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedByContact")]
        public MicrosoftDynamicsCRMcontact CreatedByContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FeedbackId")]
        public MicrosoftDynamicsCRMfeedback FeedbackId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "feedback_feedback")]
        public IList<MicrosoftDynamicsCRMfeedback> FeedbackFeedback { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Feedback_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> FeedbackSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeArticleId")]
        public MicrosoftDynamicsCRMknowledgearticle KnowledgeArticleId { get; set; }

    }
}
