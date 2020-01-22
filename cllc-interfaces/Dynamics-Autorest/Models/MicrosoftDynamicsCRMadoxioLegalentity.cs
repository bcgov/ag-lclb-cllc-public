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
    /// Microsoft.Dynamics.CRM.adoxio_legalentity
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioLegalentity
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLegalentity class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLegalentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLegalentity class.
        /// </summary>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="versionnumber">Version Number</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="adoxioLegalentityid">Unique identifier for entity
        /// instances</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="_owneridValue">Owner Id</param>
        /// <param name="adoxioTotalshares">sum of no. of voting shares and no.
        /// of non-voting shares</param>
        /// <param name="_adoxioShareholderaccountidValue">Unique identifier
        /// for Account associated with Legal Entity.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="adoxioInterestpercentage">Must fill if interest is
        /// more than 10%</param>
        /// <param name="adoxioName">The name of the custom entity.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="statecode">Status of the Legal Entity</param>
        /// <param name="statuscode">Reason for the status of the Legal
        /// Entity</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        public MicrosoftDynamicsCRMadoxioLegalentity(string _modifiedbyValue = default(string), string adoxioLastname = default(string), string adoxioFirstname = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioBirthplace = default(string), string adoxioSharepointanchor = default(string), System.DateTimeOffset? adoxioDateofbirth = default(System.DateTimeOffset?), bool? adoxioIswithdrawn = default(bool?), bool? adoxioIsapplicant = default(bool?), string adoxioInstructionsoninsertform = default(string), int? adoxioGendercode = default(int?), int? adoxioCommonnonvotingshares = default(int?), System.DateTimeOffset? adoxioDateemailsent = default(System.DateTimeOffset?), bool? adoxioIsofficer = default(bool?), int? adoxioSameasapplyingperson = default(int?), string adoxioBcidcardnumber = default(string), int? adoxioSelfdeclaredlicencecap = default(int?), int? adoxioSelfdisclosure = default(int?), bool? adoxioIspartner = default(bool?), string versionnumber = default(string), System.DateTimeOffset? adoxioDateofsharesissued = default(System.DateTimeOffset?), bool? adoxioIstrustee = default(bool?), string _owninguserValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? adoxioIncorporationdate = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), string _modifiedonbehalfbyValue = default(string), string _createdbyValue = default(string), string adoxioLegalentityid = default(string), string _adoxioCorrespondingpersonalhistorysummaryValue = default(string), bool? adoxioIskeypersonnel = default(bool?), int? adoxioTotalcompanyshares = default(int?), int? adoxioPreferredvotingshares = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? adoxioCommonvotingshares = default(int?), bool? adoxioIsdonotsendtospd = default(bool?), System.DateTimeOffset? adoxioSelfdeclaredlicencecapdate = default(System.DateTimeOffset?), string _adoxioRelatedlicenceValue = default(string), string _adoxioProfilenameValue = default(string), bool? adoxioIsseniormanagement = default(bool?), int? adoxioIsindividual = default(int?), int? adoxioPosition = default(int?), string adoxioEmail = default(string), string _owneridValue = default(string), int? adoxioTotalshares = default(int?), string _adoxioShareholderaccountidValue = default(string), string _adoxioRelatedapplicationValue = default(string), string adoxioOtherlegalentitytype = default(string), int? adoxioLegalentitytype = default(int?), string _adoxioContactValue = default(string), int? importsequencenumber = default(int?), string adoxioPhonenumber = default(string), bool? adoxioIsdeemedassociate = default(bool?), string _adoxioLegalentityownedValue = default(string), bool? adoxioIsowner = default(bool?), decimal? adoxioInterestpercentage = default(decimal?), string adoxioName = default(string), int? adoxioSelfdeclaredtiedhouse = default(int?), string _owningbusinessunitValue = default(string), int? statecode = default(int?), System.DateTimeOffset? adoxioDateofappointment = default(System.DateTimeOffset?), int? adoxioPreferrednonvotingshares = default(int?), int? statuscode = default(int?), string adoxioJobtitle = default(string), int? adoxioPartnertype = default(int?), string _adoxioAccountValue = default(string), bool? adoxioIsdirector = default(bool?), string adoxioMiddlename = default(string), bool? adoxioIsshareholder = default(bool?), string _owningteamValue = default(string), System.DateTimeOffset? adoxioSelfdeclaredtiedhousedate = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), bool? adoxioSameastheapplyingperson = default(bool?), int? adoxioAssociatedecisionby = default(int?), string adoxioDriverslicencenumber = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioLegalentitySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLegalentityDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLegalentityDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> adoxioLegalentitySharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioLegalentityAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioLegalentityBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMaccount adoxioAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMadoxioApplication adoxioRelatedApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioLegalentity adoxioLegalEntityOwned = default(MicrosoftDynamicsCRMadoxioLegalentity), IList<MicrosoftDynamicsCRMadoxioLegalentity> adoxioAdoxioLegalentityAdoxioLegalentityLegalEntityOwned = default(IList<MicrosoftDynamicsCRMadoxioLegalentity>), MicrosoftDynamicsCRMadoxioLicences adoxioRelatedLicence = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioPersonalhistorysummary adoxioCorrespondingPersonalHistorySummary = default(MicrosoftDynamicsCRMadoxioPersonalhistorysummary), MicrosoftDynamicsCRMcontact adoxioContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMaccount adoxioShareholderAccountID = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMaccount adoxioProfileNameAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact adoxioProfileNameContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMadoxioPreviousaddress> adoxioLegalentityAdoxioPreviousaddressLegalEntityId = default(IList<MicrosoftDynamicsCRMadoxioPreviousaddress>), IList<MicrosoftDynamicsCRMadoxioAlias> adoxioLegalentityAliases = default(IList<MicrosoftDynamicsCRMadoxioAlias>), IList<MicrosoftDynamicsCRMadoxioPersonalhistorysummary> adoxioLegalentityPersonalhistorysummaries = default(IList<MicrosoftDynamicsCRMadoxioPersonalhistorysummary>), IList<MicrosoftDynamicsCRMadoxioLicenseechangelog> adoxioLegalentityChangelogs = default(IList<MicrosoftDynamicsCRMadoxioLicenseechangelog>), IList<MicrosoftDynamicsCRMadoxioLicenseechangelog> adoxioParentlegalentityChangelogs = default(IList<MicrosoftDynamicsCRMadoxioLicenseechangelog>), IList<MicrosoftDynamicsCRMtask> adoxioLegalentityTaskLegalEntity = default(IList<MicrosoftDynamicsCRMtask>))
        {
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioLastname = adoxioLastname;
            AdoxioFirstname = adoxioFirstname;
            Modifiedon = modifiedon;
            AdoxioBirthplace = adoxioBirthplace;
            AdoxioSharepointanchor = adoxioSharepointanchor;
            AdoxioDateofbirth = adoxioDateofbirth;
            AdoxioIswithdrawn = adoxioIswithdrawn;
            AdoxioIsapplicant = adoxioIsapplicant;
            AdoxioInstructionsoninsertform = adoxioInstructionsoninsertform;
            AdoxioGendercode = adoxioGendercode;
            AdoxioCommonnonvotingshares = adoxioCommonnonvotingshares;
            AdoxioDateemailsent = adoxioDateemailsent;
            AdoxioIsofficer = adoxioIsofficer;
            AdoxioSameasapplyingperson = adoxioSameasapplyingperson;
            AdoxioBcidcardnumber = adoxioBcidcardnumber;
            AdoxioSelfdeclaredlicencecap = adoxioSelfdeclaredlicencecap;
            AdoxioSelfdisclosure = adoxioSelfdisclosure;
            AdoxioIspartner = adoxioIspartner;
            Versionnumber = versionnumber;
            AdoxioDateofsharesissued = adoxioDateofsharesissued;
            AdoxioIstrustee = adoxioIstrustee;
            this._owninguserValue = _owninguserValue;
            Createdon = createdon;
            AdoxioIncorporationdate = adoxioIncorporationdate;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            AdoxioLegalentityid = adoxioLegalentityid;
            this._adoxioCorrespondingpersonalhistorysummaryValue = _adoxioCorrespondingpersonalhistorysummaryValue;
            AdoxioIskeypersonnel = adoxioIskeypersonnel;
            AdoxioTotalcompanyshares = adoxioTotalcompanyshares;
            AdoxioPreferredvotingshares = adoxioPreferredvotingshares;
            Overriddencreatedon = overriddencreatedon;
            AdoxioCommonvotingshares = adoxioCommonvotingshares;
            AdoxioIsdonotsendtospd = adoxioIsdonotsendtospd;
            AdoxioSelfdeclaredlicencecapdate = adoxioSelfdeclaredlicencecapdate;
            this._adoxioRelatedlicenceValue = _adoxioRelatedlicenceValue;
            this._adoxioProfilenameValue = _adoxioProfilenameValue;
            AdoxioIsseniormanagement = adoxioIsseniormanagement;
            AdoxioIsindividual = adoxioIsindividual;
            AdoxioPosition = adoxioPosition;
            AdoxioEmail = adoxioEmail;
            this._owneridValue = _owneridValue;
            AdoxioTotalshares = adoxioTotalshares;
            this._adoxioShareholderaccountidValue = _adoxioShareholderaccountidValue;
            this._adoxioRelatedapplicationValue = _adoxioRelatedapplicationValue;
            AdoxioOtherlegalentitytype = adoxioOtherlegalentitytype;
            AdoxioLegalentitytype = adoxioLegalentitytype;
            this._adoxioContactValue = _adoxioContactValue;
            Importsequencenumber = importsequencenumber;
            AdoxioPhonenumber = adoxioPhonenumber;
            AdoxioIsdeemedassociate = adoxioIsdeemedassociate;
            this._adoxioLegalentityownedValue = _adoxioLegalentityownedValue;
            AdoxioIsowner = adoxioIsowner;
            AdoxioInterestpercentage = adoxioInterestpercentage;
            AdoxioName = adoxioName;
            AdoxioSelfdeclaredtiedhouse = adoxioSelfdeclaredtiedhouse;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Statecode = statecode;
            AdoxioDateofappointment = adoxioDateofappointment;
            AdoxioPreferrednonvotingshares = adoxioPreferrednonvotingshares;
            Statuscode = statuscode;
            AdoxioJobtitle = adoxioJobtitle;
            AdoxioPartnertype = adoxioPartnertype;
            this._adoxioAccountValue = _adoxioAccountValue;
            AdoxioIsdirector = adoxioIsdirector;
            AdoxioMiddlename = adoxioMiddlename;
            AdoxioIsshareholder = adoxioIsshareholder;
            this._owningteamValue = _owningteamValue;
            AdoxioSelfdeclaredtiedhousedate = adoxioSelfdeclaredtiedhousedate;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioSameastheapplyingperson = adoxioSameastheapplyingperson;
            AdoxioAssociatedecisionby = adoxioAssociatedecisionby;
            AdoxioDriverslicencenumber = adoxioDriverslicencenumber;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioLegalentitySyncErrors = adoxioLegalentitySyncErrors;
            AdoxioLegalentityDuplicateMatchingRecord = adoxioLegalentityDuplicateMatchingRecord;
            AdoxioLegalentityDuplicateBaseRecord = adoxioLegalentityDuplicateBaseRecord;
            AdoxioLegalentitySharePointDocumentLocations = adoxioLegalentitySharePointDocumentLocations;
            AdoxioLegalentityAsyncOperations = adoxioLegalentityAsyncOperations;
            AdoxioLegalentityBulkDeleteFailures = adoxioLegalentityBulkDeleteFailures;
            AdoxioAccount = adoxioAccount;
            AdoxioRelatedApplication = adoxioRelatedApplication;
            AdoxioLegalEntityOwned = adoxioLegalEntityOwned;
            AdoxioAdoxioLegalentityAdoxioLegalentityLegalEntityOwned = adoxioAdoxioLegalentityAdoxioLegalentityLegalEntityOwned;
            AdoxioRelatedLicence = adoxioRelatedLicence;
            AdoxioCorrespondingPersonalHistorySummary = adoxioCorrespondingPersonalHistorySummary;
            AdoxioContact = adoxioContact;
            AdoxioShareholderAccountID = adoxioShareholderAccountID;
            AdoxioProfileNameAccount = adoxioProfileNameAccount;
            AdoxioProfileNameContact = adoxioProfileNameContact;
            AdoxioLegalentityAdoxioPreviousaddressLegalEntityId = adoxioLegalentityAdoxioPreviousaddressLegalEntityId;
            AdoxioLegalentityAliases = adoxioLegalentityAliases;
            AdoxioLegalentityPersonalhistorysummaries = adoxioLegalentityPersonalhistorysummaries;
            AdoxioLegalentityChangelogs = adoxioLegalentityChangelogs;
            AdoxioParentlegalentityChangelogs = adoxioParentlegalentityChangelogs;
            AdoxioLegalentityTaskLegalEntity = adoxioLegalentityTaskLegalEntity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lastname")]
        public string AdoxioLastname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_firstname")]
        public string AdoxioFirstname { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_birthplace")]
        public string AdoxioBirthplace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sharepointanchor")]
        public string AdoxioSharepointanchor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofbirth")]
        public System.DateTimeOffset? AdoxioDateofbirth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iswithdrawn")]
        public bool? AdoxioIswithdrawn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isapplicant")]
        public bool? AdoxioIsapplicant { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_instructionsoninsertform")]
        public string AdoxioInstructionsoninsertform { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_gendercode")]
        public int? AdoxioGendercode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_commonnonvotingshares")]
        public int? AdoxioCommonnonvotingshares { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateemailsent")]
        public System.DateTimeOffset? AdoxioDateemailsent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isofficer")]
        public bool? AdoxioIsofficer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sameasapplyingperson")]
        public int? AdoxioSameasapplyingperson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_bcidcardnumber")]
        public string AdoxioBcidcardnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_selfdeclaredlicencecap")]
        public int? AdoxioSelfdeclaredlicencecap { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_selfdisclosure")]
        public int? AdoxioSelfdisclosure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ispartner")]
        public bool? AdoxioIspartner { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofsharesissued")]
        public System.DateTimeOffset? AdoxioDateofsharesissued { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_istrustee")]
        public bool? AdoxioIstrustee { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_incorporationdate")]
        public System.DateTimeOffset? AdoxioIncorporationdate { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentityid")]
        public string AdoxioLegalentityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_correspondingpersonalhistorysummary_value")]
        public string _adoxioCorrespondingpersonalhistorysummaryValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iskeypersonnel")]
        public bool? AdoxioIskeypersonnel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_totalcompanyshares")]
        public int? AdoxioTotalcompanyshares { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_preferredvotingshares")]
        public int? AdoxioPreferredvotingshares { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_commonvotingshares")]
        public int? AdoxioCommonvotingshares { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isdonotsendtospd")]
        public bool? AdoxioIsdonotsendtospd { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_selfdeclaredlicencecapdate")]
        public System.DateTimeOffset? AdoxioSelfdeclaredlicencecapdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_relatedlicence_value")]
        public string _adoxioRelatedlicenceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_profilename_value")]
        public string _adoxioProfilenameValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isseniormanagement")]
        public bool? AdoxioIsseniormanagement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isindividual")]
        public int? AdoxioIsindividual { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_position")]
        public int? AdoxioPosition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_email")]
        public string AdoxioEmail { get; set; }

        /// <summary>
        /// Gets or sets owner Id
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets sum of no. of voting shares and no. of non-voting
        /// shares
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_totalshares")]
        public int? AdoxioTotalshares { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Account associated with Legal
        /// Entity.
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_shareholderaccountid_value")]
        public string _adoxioShareholderaccountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_relatedapplication_value")]
        public string _adoxioRelatedapplicationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_otherlegalentitytype")]
        public string AdoxioOtherlegalentitytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentitytype")]
        public int? AdoxioLegalentitytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_contact_value")]
        public string _adoxioContactValue { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_phonenumber")]
        public string AdoxioPhonenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isdeemedassociate")]
        public bool? AdoxioIsdeemedassociate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_legalentityowned_value")]
        public string _adoxioLegalentityownedValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isowner")]
        public bool? AdoxioIsowner { get; set; }

        /// <summary>
        /// Gets or sets must fill if interest is more than 10%
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_interestpercentage")]
        public decimal? AdoxioInterestpercentage { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_selfdeclaredtiedhouse")]
        public int? AdoxioSelfdeclaredtiedhouse { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets status of the Legal Entity
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofappointment")]
        public System.DateTimeOffset? AdoxioDateofappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_preferrednonvotingshares")]
        public int? AdoxioPreferrednonvotingshares { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Legal Entity
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_jobtitle")]
        public string AdoxioJobtitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_partnertype")]
        public int? AdoxioPartnertype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_account_value")]
        public string _adoxioAccountValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isdirector")]
        public bool? AdoxioIsdirector { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_middlename")]
        public string AdoxioMiddlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshareholder")]
        public bool? AdoxioIsshareholder { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_selfdeclaredtiedhousedate")]
        public System.DateTimeOffset? AdoxioSelfdeclaredtiedhousedate { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sameastheapplyingperson")]
        public bool? AdoxioSameastheapplyingperson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_associatedecisionby")]
        public int? AdoxioAssociatedecisionby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_driverslicencenumber")]
        public string AdoxioDriverslicencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_legalentity_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioLegalentitySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLegalentityDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLegalentityDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> AdoxioLegalentitySharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioLegalentityAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioLegalentityBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Account")]
        public MicrosoftDynamicsCRMaccount AdoxioAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RelatedApplication")]
        public MicrosoftDynamicsCRMadoxioApplication AdoxioRelatedApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LegalEntityOwned")]
        public MicrosoftDynamicsCRMadoxioLegalentity AdoxioLegalEntityOwned { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_legalentity_adoxio_legalentity_LegalEntityOwned")]
        public IList<MicrosoftDynamicsCRMadoxioLegalentity> AdoxioAdoxioLegalentityAdoxioLegalentityLegalEntityOwned { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RelatedLicence")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioRelatedLicence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_CorrespondingPersonalHistorySummary")]
        public MicrosoftDynamicsCRMadoxioPersonalhistorysummary AdoxioCorrespondingPersonalHistorySummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Contact")]
        public MicrosoftDynamicsCRMcontact AdoxioContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ShareholderAccountID")]
        public MicrosoftDynamicsCRMaccount AdoxioShareholderAccountID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ProfileName_account")]
        public MicrosoftDynamicsCRMaccount AdoxioProfileNameAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ProfileName_contact")]
        public MicrosoftDynamicsCRMcontact AdoxioProfileNameContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_adoxio_previousaddress_LegalEntityId")]
        public IList<MicrosoftDynamicsCRMadoxioPreviousaddress> AdoxioLegalentityAdoxioPreviousaddressLegalEntityId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_aliases")]
        public IList<MicrosoftDynamicsCRMadoxioAlias> AdoxioLegalentityAliases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_personalhistorysummaries")]
        public IList<MicrosoftDynamicsCRMadoxioPersonalhistorysummary> AdoxioLegalentityPersonalhistorysummaries { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_changelogs")]
        public IList<MicrosoftDynamicsCRMadoxioLicenseechangelog> AdoxioLegalentityChangelogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_parentlegalentity_changelogs")]
        public IList<MicrosoftDynamicsCRMadoxioLicenseechangelog> AdoxioParentlegalentityChangelogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentity_task_LegalEntity")]
        public IList<MicrosoftDynamicsCRMtask> AdoxioLegalentityTaskLegalEntity { get; set; }

    }
}
