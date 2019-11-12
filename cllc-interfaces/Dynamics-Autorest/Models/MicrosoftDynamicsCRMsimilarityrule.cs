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
    /// Microsoft.Dynamics.CRM.similarityrule
    /// </summary>
    public partial class MicrosoftDynamicsCRMsimilarityrule
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsimilarityrule class.
        /// </summary>
        public MicrosoftDynamicsCRMsimilarityrule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsimilarityrule class.
        /// </summary>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="_transactioncurrencyidValue">Exchange rate for the
        /// currency associated with the SimilarityRule with respect to the
        /// base currency.</param>
        /// <param name="solutionid">Unique identifier of the associated
        /// solution.</param>
        /// <param name="statuscode">Reason for the status of the Similarity
        /// Rule</param>
        /// <param name="createdon">Shows the date and time when the record was
        /// created. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.</param>
        /// <param name="_organizationidValue">Unique identifier for the
        /// organization</param>
        /// <param name="name">The name of the custom entity.</param>
        /// <param name="similarityruleid">Unique identifier for entity
        /// instances</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="matchingentityname">Record type of the records being
        /// evaluated as potential similarities.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="componentstate">For internal use only.</param>
        /// <param name="statecode">Status of the Similarity Rule</param>
        /// <param name="introducedversion">Version in which the similarity
        /// rule is introduced.</param>
        /// <param name="fetchxmllist">Fetch Xml</param>
        /// <param name="activerulefetchxml">Generated Fetch xml from Active
        /// rule and rule conditions.</param>
        /// <param name="maxkeywords">Enter the maximum number of keywords and
        /// key phrases to use with text analytics.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="baseentitytypecode">Record type of the record being
        /// evaluated for potential similarities.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="overwritetime">Date and time when the record was
        /// created.</param>
        /// <param name="similarityruleidunique">Unique identifier of the
        /// Similarity Rule used when synchronizing customizations for the
        /// Microsoft Dynamics 365 client for Outlook</param>
        /// <param name="exchangerate">Exchange rate for the currency
        /// associated with the SimilarityRule with respect to the base
        /// currency.</param>
        /// <param name="ngramsize">Enter the maximum number of words in a key
        /// phrase to use with text analytics.</param>
        /// <param name="description">Description of the similarity detection
        /// rule.</param>
        /// <param name="baseentityname">Record type of the record being
        /// evaluated for potential similarities.</param>
        /// <param name="modifiedon">Shows the date and time when the record
        /// was last updated. The date and time are displayed in the time zone
        /// selected in Microsoft Dynamics 365 options.</param>
        /// <param name="matchingentitytypecode">Record type of the records
        /// being evaluated as potential similarities.</param>
        /// <param name="excludeinactiverecords">Determines whether to flag
        /// inactive records as similarities</param>
        /// <param name="ruleconditionxml">ConditionXml for similarity rule
        /// conditions.</param>
        /// <param name="ismanaged">Is Managed</param>
        public MicrosoftDynamicsCRMsimilarityrule(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.Guid? _transactioncurrencyidValue = default(System.Guid?), System.Guid? solutionid = default(System.Guid?), int? statuscode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _organizationidValue = default(System.Guid?), string name = default(string), System.Guid? similarityruleid = default(System.Guid?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), string matchingentityname = default(string), int? timezoneruleversionnumber = default(int?), int? componentstate = default(int?), int? statecode = default(int?), string introducedversion = default(string), string fetchxmllist = default(string), string activerulefetchxml = default(string), int? maxkeywords = default(int?), int? utcconversiontimezonecode = default(int?), int? baseentitytypecode = default(int?), int? importsequencenumber = default(int?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), System.Guid? similarityruleidunique = default(System.Guid?), decimal? exchangerate = default(decimal?), int? ngramsize = default(int?), string description = default(string), string baseentityname = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string versionnumber = default(string), int? matchingentitytypecode = default(int?), bool? excludeinactiverecords = default(bool?), string ruleconditionxml = default(string), bool? ismanaged = default(bool?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> similarityruleAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            Overriddencreatedon = overriddencreatedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Solutionid = solutionid;
            Statuscode = statuscode;
            Createdon = createdon;
            this._organizationidValue = _organizationidValue;
            Name = name;
            Similarityruleid = similarityruleid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Matchingentityname = matchingentityname;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Componentstate = componentstate;
            Statecode = statecode;
            Introducedversion = introducedversion;
            Fetchxmllist = fetchxmllist;
            Activerulefetchxml = activerulefetchxml;
            Maxkeywords = maxkeywords;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Baseentitytypecode = baseentitytypecode;
            Importsequencenumber = importsequencenumber;
            Overwritetime = overwritetime;
            Similarityruleidunique = similarityruleidunique;
            Exchangerate = exchangerate;
            Ngramsize = ngramsize;
            Description = description;
            Baseentityname = baseentityname;
            Modifiedon = modifiedon;
            Versionnumber = versionnumber;
            Matchingentitytypecode = matchingentitytypecode;
            Excludeinactiverecords = excludeinactiverecords;
            Ruleconditionxml = ruleconditionxml;
            Ismanaged = ismanaged;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            SimilarityruleAsyncOperations = similarityruleAsyncOperations;
            Organizationid = organizationid;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets exchange rate for the currency associated with the
        /// SimilarityRule with respect to the base currency.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public System.Guid? _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the associated solution.
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public System.Guid? Solutionid { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Similarity Rule
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was created.
        /// The date and time are displayed in the time zone selected in
        /// Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the organization
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "similarityruleid")]
        public System.Guid? Similarityruleid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets record type of the records being evaluated as
        /// potential similarities.
        /// </summary>
        [JsonProperty(PropertyName = "matchingentityname")]
        public string Matchingentityname { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// Gets or sets status of the Similarity Rule
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets version in which the similarity rule is introduced.
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// Gets or sets fetch Xml
        /// </summary>
        [JsonProperty(PropertyName = "fetchxmllist")]
        public string Fetchxmllist { get; set; }

        /// <summary>
        /// Gets or sets generated Fetch xml from Active rule and rule
        /// conditions.
        /// </summary>
        [JsonProperty(PropertyName = "activerulefetchxml")]
        public string Activerulefetchxml { get; set; }

        /// <summary>
        /// Gets or sets enter the maximum number of keywords and key phrases
        /// to use with text analytics.
        /// </summary>
        [JsonProperty(PropertyName = "maxkeywords")]
        public int? Maxkeywords { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets record type of the record being evaluated for
        /// potential similarities.
        /// </summary>
        [JsonProperty(PropertyName = "baseentitytypecode")]
        public int? Baseentitytypecode { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the Similarity Rule used when
        /// synchronizing customizations for the Microsoft Dynamics 365 client
        /// for Outlook
        /// </summary>
        [JsonProperty(PropertyName = "similarityruleidunique")]
        public System.Guid? Similarityruleidunique { get; set; }

        /// <summary>
        /// Gets or sets exchange rate for the currency associated with the
        /// SimilarityRule with respect to the base currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets enter the maximum number of words in a key phrase to
        /// use with text analytics.
        /// </summary>
        [JsonProperty(PropertyName = "ngramsize")]
        public int? Ngramsize { get; set; }

        /// <summary>
        /// Gets or sets description of the similarity detection rule.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets record type of the record being evaluated for
        /// potential similarities.
        /// </summary>
        [JsonProperty(PropertyName = "baseentityname")]
        public string Baseentityname { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was last
        /// updated. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets record type of the records being evaluated as
        /// potential similarities.
        /// </summary>
        [JsonProperty(PropertyName = "matchingentitytypecode")]
        public int? Matchingentitytypecode { get; set; }

        /// <summary>
        /// Gets or sets determines whether to flag inactive records as
        /// similarities
        /// </summary>
        [JsonProperty(PropertyName = "excludeinactiverecords")]
        public bool? Excludeinactiverecords { get; set; }

        /// <summary>
        /// Gets or sets conditionXml for similarity rule conditions.
        /// </summary>
        [JsonProperty(PropertyName = "ruleconditionxml")]
        public string Ruleconditionxml { get; set; }

        /// <summary>
        /// Gets or sets is Managed
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "similarityrule_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SimilarityruleAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
