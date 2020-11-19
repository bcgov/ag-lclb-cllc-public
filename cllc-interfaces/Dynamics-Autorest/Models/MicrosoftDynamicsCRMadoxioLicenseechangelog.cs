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
    /// Microsoft.Dynamics.CRM.adoxio_licenseechangelog
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioLicenseechangelog
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLicenseechangelog class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLicenseechangelog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLicenseechangelog class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLicenseechangelog(int? adoxioNumberofmembersold = default(int?), System.DateTimeOffset? adoxioDateofbirthnew = default(System.DateTimeOffset?), string _transactioncurrencyidValue = default(string), int? adoxioNumberofnonvotingsharesnew = default(int?), string adoxioFirstnameold = default(string), string _createdonbehalfbyValue = default(string), decimal? adoxioAnnualmembershipfeenew = default(decimal?), int? adoxioNumberofmembers = default(int?), bool? adoxioIsmanagernew = default(bool?), string versionnumber = default(string), int? adoxioNumberofnonvotingsharesold = default(int?), decimal? adoxioAnnualmembershipfeeBase = default(decimal?), bool? adoxioIsownerold = default(bool?), int? utcconversiontimezonecode = default(int?), int? adoxioTotalsharesnew = default(int?), string _owningbusinessunitValue = default(string), int? statecode = default(int?), string adoxioEmailold = default(string), string _adoxioParentlegalentityidValue = default(string), decimal? adoxioInterestpercentageold = default(decimal?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _adoxioApplicationtypeValue = default(string), bool? adoxioIsmanagerold = default(bool?), int? adoxioBusinessaccounttype = default(int?), decimal? adoxioAnnualmembershipfeeold = default(decimal?), string adoxioTitlenew = default(string), decimal? adoxioAnnualmembershipfee = default(decimal?), int? adoxioNumberofmembersnew = default(int?), string adoxioName = default(string), bool? adoxioIsdirectorold = default(bool?), string _adoxioParentbusinessaccountValue = default(string), int? adoxioNumberofsharesnew = default(int?), string adoxioTitleold = default(string), string _adoxioApplicationValue = default(string), string _adoxioBusinessaccountValue = default(string), bool? adoxioIsownernew = default(bool?), bool? adoxioIskeypersonnelold = default(bool?), string _adoxioShareholderbusinessaccountValue = default(string), bool? adoxioIskeypersonnelnew = default(bool?), int? timezoneruleversionnumber = default(int?), string _modifiedonbehalfbyValue = default(string), string _adoxioContactValue = default(string), bool? adoxioIspartnerold = default(bool?), string _createdbyValue = default(string), int? adoxioNumberofsharesold = default(int?), bool? adoxioIsshareholdernew = default(bool?), decimal? exchangerate = default(decimal?), bool? adoxioIsshareholderold = default(bool?), decimal? adoxioInterestpercentagenew = default(decimal?), string adoxioBusinesnameold = default(string), string _owneridValue = default(string), string _owningteamValue = default(string), string adoxioLicenseechangelogid = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), bool? adoxioIstrusteenew = default(bool?), string _adoxioLegalentityidValue = default(string), bool? adoxioIspartnernew = default(bool?), bool? adoxioIsofficerold = default(bool?), int? adoxioTotalsharesold = default(int?), int? adoxioChangetype = default(int?), bool? adoxioIstrusteeold = default(bool?), string adoxioEmailnew = default(string), string adoxioBusinessnamenew = default(string), int? statuscode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? adoxioDateofbirthold = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string adoxioFirstnamenew = default(string), string adoxioLastnameold = default(string), string adoxioJobnumber = default(string), string _owninguserValue = default(string), bool? adoxioIsdirectornew = default(bool?), int? adoxioBusinesstype = default(int?), bool? adoxioIsofficernew = default(bool?), string _adoxioParentlinceseechangelogidValue = default(string), string adoxioLastnamenew = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioLicenseechangelogSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioLicenseechangelogAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioLicenseechangelogMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioLicenseechangelogProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioLicenseechangelogBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioLicenseechangelogPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMadoxioApplicationtype adoxioApplicationType = default(MicrosoftDynamicsCRMadoxioApplicationtype), MicrosoftDynamicsCRMaccount adoxioParentBusinessAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMaccount adoxioBusinessAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact adoxioContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMadoxioApplication adoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioLicenseechangelog adoxioParentLinceseeChangeLogId = default(MicrosoftDynamicsCRMadoxioLicenseechangelog), IList<MicrosoftDynamicsCRMadoxioLicenseechangelog> adoxioLicenseechangelogLicenseechangelogs = default(IList<MicrosoftDynamicsCRMadoxioLicenseechangelog>), MicrosoftDynamicsCRMaccount adoxioShareholderBusinessAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMadoxioLegalentity adoxioParentLegalEntityId = default(MicrosoftDynamicsCRMadoxioLegalentity), MicrosoftDynamicsCRMadoxioLegalentity adoxioLegalEntityId = default(MicrosoftDynamicsCRMadoxioLegalentity), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            AdoxioNumberofmembersold = adoxioNumberofmembersold;
            AdoxioDateofbirthnew = adoxioDateofbirthnew;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            AdoxioNumberofnonvotingsharesnew = adoxioNumberofnonvotingsharesnew;
            AdoxioFirstnameold = adoxioFirstnameold;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioAnnualmembershipfeenew = adoxioAnnualmembershipfeenew;
            AdoxioNumberofmembers = adoxioNumberofmembers;
            AdoxioIsmanagernew = adoxioIsmanagernew;
            Versionnumber = versionnumber;
            AdoxioNumberofnonvotingsharesold = adoxioNumberofnonvotingsharesold;
            AdoxioAnnualmembershipfeeBase = adoxioAnnualmembershipfeeBase;
            AdoxioIsownerold = adoxioIsownerold;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioTotalsharesnew = adoxioTotalsharesnew;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Statecode = statecode;
            AdoxioEmailold = adoxioEmailold;
            this._adoxioParentlegalentityidValue = _adoxioParentlegalentityidValue;
            AdoxioInterestpercentageold = adoxioInterestpercentageold;
            Createdon = createdon;
            this._adoxioApplicationtypeValue = _adoxioApplicationtypeValue;
            AdoxioIsmanagerold = adoxioIsmanagerold;
            AdoxioBusinessaccounttype = adoxioBusinessaccounttype;
            AdoxioAnnualmembershipfeeold = adoxioAnnualmembershipfeeold;
            AdoxioTitlenew = adoxioTitlenew;
            AdoxioAnnualmembershipfee = adoxioAnnualmembershipfee;
            AdoxioNumberofmembersnew = adoxioNumberofmembersnew;
            AdoxioName = adoxioName;
            AdoxioIsdirectorold = adoxioIsdirectorold;
            this._adoxioParentbusinessaccountValue = _adoxioParentbusinessaccountValue;
            AdoxioNumberofsharesnew = adoxioNumberofsharesnew;
            AdoxioTitleold = adoxioTitleold;
            this._adoxioApplicationValue = _adoxioApplicationValue;
            this._adoxioBusinessaccountValue = _adoxioBusinessaccountValue;
            AdoxioIsownernew = adoxioIsownernew;
            AdoxioIskeypersonnelold = adoxioIskeypersonnelold;
            this._adoxioShareholderbusinessaccountValue = _adoxioShareholderbusinessaccountValue;
            AdoxioIskeypersonnelnew = adoxioIskeypersonnelnew;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._adoxioContactValue = _adoxioContactValue;
            AdoxioIspartnerold = adoxioIspartnerold;
            this._createdbyValue = _createdbyValue;
            AdoxioNumberofsharesold = adoxioNumberofsharesold;
            AdoxioIsshareholdernew = adoxioIsshareholdernew;
            Exchangerate = exchangerate;
            AdoxioIsshareholderold = adoxioIsshareholderold;
            AdoxioInterestpercentagenew = adoxioInterestpercentagenew;
            AdoxioBusinesnameold = adoxioBusinesnameold;
            this._owneridValue = _owneridValue;
            this._owningteamValue = _owningteamValue;
            AdoxioLicenseechangelogid = adoxioLicenseechangelogid;
            Importsequencenumber = importsequencenumber;
            Modifiedon = modifiedon;
            AdoxioIstrusteenew = adoxioIstrusteenew;
            this._adoxioLegalentityidValue = _adoxioLegalentityidValue;
            AdoxioIspartnernew = adoxioIspartnernew;
            AdoxioIsofficerold = adoxioIsofficerold;
            AdoxioTotalsharesold = adoxioTotalsharesold;
            AdoxioChangetype = adoxioChangetype;
            AdoxioIstrusteeold = adoxioIstrusteeold;
            AdoxioEmailnew = adoxioEmailnew;
            AdoxioBusinessnamenew = adoxioBusinessnamenew;
            Statuscode = statuscode;
            Overriddencreatedon = overriddencreatedon;
            AdoxioDateofbirthold = adoxioDateofbirthold;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioFirstnamenew = adoxioFirstnamenew;
            AdoxioLastnameold = adoxioLastnameold;
            AdoxioJobnumber = adoxioJobnumber;
            this._owninguserValue = _owninguserValue;
            AdoxioIsdirectornew = adoxioIsdirectornew;
            AdoxioBusinesstype = adoxioBusinesstype;
            AdoxioIsofficernew = adoxioIsofficernew;
            this._adoxioParentlinceseechangelogidValue = _adoxioParentlinceseechangelogidValue;
            AdoxioLastnamenew = adoxioLastnamenew;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioLicenseechangelogSyncErrors = adoxioLicenseechangelogSyncErrors;
            AdoxioLicenseechangelogAsyncOperations = adoxioLicenseechangelogAsyncOperations;
            AdoxioLicenseechangelogMailboxTrackingFolders = adoxioLicenseechangelogMailboxTrackingFolders;
            AdoxioLicenseechangelogProcessSession = adoxioLicenseechangelogProcessSession;
            AdoxioLicenseechangelogBulkDeleteFailures = adoxioLicenseechangelogBulkDeleteFailures;
            AdoxioLicenseechangelogPrincipalObjectAttributeAccesses = adoxioLicenseechangelogPrincipalObjectAttributeAccesses;
            AdoxioApplicationType = adoxioApplicationType;
            AdoxioParentBusinessAccount = adoxioParentBusinessAccount;
            AdoxioBusinessAccount = adoxioBusinessAccount;
            AdoxioContact = adoxioContact;
            AdoxioApplication = adoxioApplication;
            AdoxioParentLinceseeChangeLogId = adoxioParentLinceseeChangeLogId;
            AdoxioLicenseechangelogLicenseechangelogs = adoxioLicenseechangelogLicenseechangelogs;
            AdoxioShareholderBusinessAccount = adoxioShareholderBusinessAccount;
            AdoxioParentLegalEntityId = adoxioParentLegalEntityId;
            AdoxioLegalEntityId = adoxioLegalEntityId;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_numberofmembersold")]
        public int? AdoxioNumberofmembersold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofbirthnew")]
        public System.DateTimeOffset? AdoxioDateofbirthnew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_numberofnonvotingsharesnew")]
        public int? AdoxioNumberofnonvotingsharesnew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_firstnameold")]
        public string AdoxioFirstnameold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_annualmembershipfeenew")]
        public decimal? AdoxioAnnualmembershipfeenew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_numberofmembers")]
        public int? AdoxioNumberofmembers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ismanagernew")]
        public bool? AdoxioIsmanagernew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_numberofnonvotingsharesold")]
        public int? AdoxioNumberofnonvotingsharesold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_annualmembershipfee_base")]
        public decimal? AdoxioAnnualmembershipfeeBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isownerold")]
        public bool? AdoxioIsownerold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_totalsharesnew")]
        public int? AdoxioTotalsharesnew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_emailold")]
        public string AdoxioEmailold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_parentlegalentityid_value")]
        public string _adoxioParentlegalentityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_interestpercentageold")]
        public decimal? AdoxioInterestpercentageold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_applicationtype_value")]
        public string _adoxioApplicationtypeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ismanagerold")]
        public bool? AdoxioIsmanagerold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_businessaccounttype")]
        public int? AdoxioBusinessaccounttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_annualmembershipfeeold")]
        public decimal? AdoxioAnnualmembershipfeeold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_titlenew")]
        public string AdoxioTitlenew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_annualmembershipfee")]
        public decimal? AdoxioAnnualmembershipfee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_numberofmembersnew")]
        public int? AdoxioNumberofmembersnew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isdirectorold")]
        public bool? AdoxioIsdirectorold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_parentbusinessaccount_value")]
        public string _adoxioParentbusinessaccountValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_numberofsharesnew")]
        public int? AdoxioNumberofsharesnew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_titleold")]
        public string AdoxioTitleold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_application_value")]
        public string _adoxioApplicationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_businessaccount_value")]
        public string _adoxioBusinessaccountValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isownernew")]
        public bool? AdoxioIsownernew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iskeypersonnelold")]
        public bool? AdoxioIskeypersonnelold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_shareholderbusinessaccount_value")]
        public string _adoxioShareholderbusinessaccountValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iskeypersonnelnew")]
        public bool? AdoxioIskeypersonnelnew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_contact_value")]
        public string _adoxioContactValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ispartnerold")]
        public bool? AdoxioIspartnerold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_numberofsharesold")]
        public int? AdoxioNumberofsharesold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshareholdernew")]
        public bool? AdoxioIsshareholdernew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshareholderold")]
        public bool? AdoxioIsshareholderold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_interestpercentagenew")]
        public decimal? AdoxioInterestpercentagenew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_businesnameold")]
        public string AdoxioBusinesnameold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licenseechangelogid")]
        public string AdoxioLicenseechangelogid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_istrusteenew")]
        public bool? AdoxioIstrusteenew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_legalentityid_value")]
        public string _adoxioLegalentityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ispartnernew")]
        public bool? AdoxioIspartnernew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isofficerold")]
        public bool? AdoxioIsofficerold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_totalsharesold")]
        public int? AdoxioTotalsharesold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_changetype")]
        public int? AdoxioChangetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_istrusteeold")]
        public bool? AdoxioIstrusteeold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_emailnew")]
        public string AdoxioEmailnew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_businessnamenew")]
        public string AdoxioBusinessnamenew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofbirthold")]
        public System.DateTimeOffset? AdoxioDateofbirthold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_firstnamenew")]
        public string AdoxioFirstnamenew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lastnameold")]
        public string AdoxioLastnameold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_jobnumber")]
        public string AdoxioJobnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isdirectornew")]
        public bool? AdoxioIsdirectornew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_businesstype")]
        public int? AdoxioBusinesstype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isofficernew")]
        public bool? AdoxioIsofficernew { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_parentlinceseechangelogid_value")]
        public string _adoxioParentlinceseechangelogidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lastnamenew")]
        public string AdoxioLastnamenew { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_licenseechangelog_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioLicenseechangelogSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licenseechangelog_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioLicenseechangelogAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licenseechangelog_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioLicenseechangelogMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licenseechangelog_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioLicenseechangelogProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licenseechangelog_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioLicenseechangelogBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licenseechangelog_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioLicenseechangelogPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ApplicationType")]
        public MicrosoftDynamicsCRMadoxioApplicationtype AdoxioApplicationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ParentBusinessAccount")]
        public MicrosoftDynamicsCRMaccount AdoxioParentBusinessAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_BusinessAccount")]
        public MicrosoftDynamicsCRMaccount AdoxioBusinessAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Contact")]
        public MicrosoftDynamicsCRMcontact AdoxioContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Application")]
        public MicrosoftDynamicsCRMadoxioApplication AdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ParentLinceseeChangeLogId")]
        public MicrosoftDynamicsCRMadoxioLicenseechangelog AdoxioParentLinceseeChangeLogId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licenseechangelog_licenseechangelogs")]
        public IList<MicrosoftDynamicsCRMadoxioLicenseechangelog> AdoxioLicenseechangelogLicenseechangelogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ShareholderBusinessAccount")]
        public MicrosoftDynamicsCRMaccount AdoxioShareholderBusinessAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ParentLegalEntityId")]
        public MicrosoftDynamicsCRMadoxioLegalentity AdoxioParentLegalEntityId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LegalEntityId")]
        public MicrosoftDynamicsCRMadoxioLegalentity AdoxioLegalEntityId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
