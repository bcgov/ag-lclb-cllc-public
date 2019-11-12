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
    /// Microsoft.Dynamics.CRM.knowledgebaserecord
    /// </summary>
    public partial class MicrosoftDynamicsCRMknowledgebaserecord
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMknowledgebaserecord class.
        /// </summary>
        public MicrosoftDynamicsCRMknowledgebaserecord()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMknowledgebaserecord class.
        /// </summary>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="title">Shows the title of the knowledge base (KB)
        /// Record.</param>
        /// <param name="exchangerate">Exchange rate for the currency
        /// associated with the knowledge base record with respect to the base
        /// currency.</param>
        /// <param name="publicurl">Shows the public Parature portal URL of the
        /// knowledge base records.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="_organizationidValue">Unique identifier for the
        /// organization</param>
        /// <param name="privateurl">Shows the internal Parature service desk
        /// URL of the knowledge base records.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="knowledgebaserecordid">This field will be used to
        /// store the Unique ID of the associated Knowledge Base
        /// records</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="uniqueid">Shows the unique ID of the linked knowledge
        /// base (KB) article.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_transactioncurrencyidValue">Exchange rate for the
        /// currency associated with the Knowledge Base Record with respect to
        /// the base currency.</param>
        public MicrosoftDynamicsCRMknowledgebaserecord(System.Guid? _createdbyValue = default(System.Guid?), string title = default(string), decimal? exchangerate = default(decimal?), string publicurl = default(string), System.Guid? _modifiedbyValue = default(System.Guid?), System.Guid? _organizationidValue = default(System.Guid?), string privateurl = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.Guid? knowledgebaserecordid = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), string versionnumber = default(string), string uniqueid = default(string), int? timezoneruleversionnumber = default(int?), System.Guid? _transactioncurrencyidValue = default(System.Guid?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMactivitypointer> knowledgeBaseRecordActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> knowledgeBaseRecordAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> knowledgeBaseRecordEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> knowledgeBaseRecordFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> knowledgeBaseRecordLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> knowledgeBaseRecordPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> knowledgeBaseRecordServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> knowledgeBaseRecordTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> knowledgeBaseRecordRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> knowledgeBaseRecordSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMconnection> knowledgeBaseRecordConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> knowledgeBaseRecordConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMduplicaterecord> knowledgeBaseRecordDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> knowledgeBaseRecordDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMannotation> knowledgeBaseRecordAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> knowledgeBaseRecordAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> knowledgeBaseRecordBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMsyncerror> knowledgeBaseRecordSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMincident> knowledgeBaseRecordIncident = default(IList<MicrosoftDynamicsCRMincident>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> knowledgebaserecordAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioApplicationKnowledgebaserecord = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMadoxioLicencetype> adoxioLicencetypeKnowledgebaserecord = default(IList<MicrosoftDynamicsCRMadoxioLicencetype>))
        {
            this._createdbyValue = _createdbyValue;
            Title = title;
            Exchangerate = exchangerate;
            Publicurl = publicurl;
            this._modifiedbyValue = _modifiedbyValue;
            this._organizationidValue = _organizationidValue;
            Privateurl = privateurl;
            Modifiedon = modifiedon;
            Knowledgebaserecordid = knowledgebaserecordid;
            Createdon = createdon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Versionnumber = versionnumber;
            Uniqueid = uniqueid;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            KnowledgeBaseRecordActivityPointers = knowledgeBaseRecordActivityPointers;
            KnowledgeBaseRecordAppointments = knowledgeBaseRecordAppointments;
            KnowledgeBaseRecordEmails = knowledgeBaseRecordEmails;
            KnowledgeBaseRecordFaxes = knowledgeBaseRecordFaxes;
            KnowledgeBaseRecordLetters = knowledgeBaseRecordLetters;
            KnowledgeBaseRecordPhoneCalls = knowledgeBaseRecordPhoneCalls;
            KnowledgeBaseRecordServiceAppointments = knowledgeBaseRecordServiceAppointments;
            KnowledgeBaseRecordTasks = knowledgeBaseRecordTasks;
            KnowledgeBaseRecordRecurringAppointmentMasters = knowledgeBaseRecordRecurringAppointmentMasters;
            KnowledgeBaseRecordSocialActivities = knowledgeBaseRecordSocialActivities;
            KnowledgeBaseRecordConnections1 = knowledgeBaseRecordConnections1;
            KnowledgeBaseRecordConnections2 = knowledgeBaseRecordConnections2;
            KnowledgeBaseRecordDuplicateMatchingRecord = knowledgeBaseRecordDuplicateMatchingRecord;
            KnowledgeBaseRecordDuplicateBaseRecord = knowledgeBaseRecordDuplicateBaseRecord;
            KnowledgeBaseRecordAnnotations = knowledgeBaseRecordAnnotations;
            KnowledgeBaseRecordAsyncOperations = knowledgeBaseRecordAsyncOperations;
            KnowledgeBaseRecordBulkDeleteFailures = knowledgeBaseRecordBulkDeleteFailures;
            KnowledgeBaseRecordSyncErrors = knowledgeBaseRecordSyncErrors;
            KnowledgeBaseRecordIncident = knowledgeBaseRecordIncident;
            Transactioncurrencyid = transactioncurrencyid;
            KnowledgebaserecordAbsScheduledprocessexecutions = knowledgebaserecordAbsScheduledprocessexecutions;
            AdoxioApplicationKnowledgebaserecord = adoxioApplicationKnowledgebaserecord;
            AdoxioLicencetypeKnowledgebaserecord = adoxioLicencetypeKnowledgebaserecord;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the title of the knowledge base (KB) Record.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets exchange rate for the currency associated with the
        /// knowledge base record with respect to the base currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets shows the public Parature portal URL of the knowledge
        /// base records.
        /// </summary>
        [JsonProperty(PropertyName = "publicurl")]
        public string Publicurl { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the organization
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the internal Parature service desk URL of the
        /// knowledge base records.
        /// </summary>
        [JsonProperty(PropertyName = "privateurl")]
        public string Privateurl { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets this field will be used to store the Unique ID of the
        /// associated Knowledge Base records
        /// </summary>
        [JsonProperty(PropertyName = "knowledgebaserecordid")]
        public System.Guid? Knowledgebaserecordid { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets shows the unique ID of the linked knowledge base (KB)
        /// article.
        /// </summary>
        [JsonProperty(PropertyName = "uniqueid")]
        public string Uniqueid { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets exchange rate for the currency associated with the
        /// Knowledge Base Record with respect to the base currency.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public System.Guid? _transactioncurrencyidValue { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> KnowledgeBaseRecordActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> KnowledgeBaseRecordAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_Emails")]
        public IList<MicrosoftDynamicsCRMemail> KnowledgeBaseRecordEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> KnowledgeBaseRecordFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_Letters")]
        public IList<MicrosoftDynamicsCRMletter> KnowledgeBaseRecordLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> KnowledgeBaseRecordPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> KnowledgeBaseRecordServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> KnowledgeBaseRecordTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> KnowledgeBaseRecordRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> KnowledgeBaseRecordSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> KnowledgeBaseRecordConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> KnowledgeBaseRecordConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> KnowledgeBaseRecordDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> KnowledgeBaseRecordDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> KnowledgeBaseRecordAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> KnowledgeBaseRecordAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> KnowledgeBaseRecordBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> KnowledgeBaseRecordSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeBaseRecord_Incident")]
        public IList<MicrosoftDynamicsCRMincident> KnowledgeBaseRecordIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgebaserecord_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> KnowledgebaserecordAbsScheduledprocessexecutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_application_knowledgebaserecord")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioApplicationKnowledgebaserecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_knowledgebaserecord")]
        public IList<MicrosoftDynamicsCRMadoxioLicencetype> AdoxioLicencetypeKnowledgebaserecord { get; set; }

    }
}
