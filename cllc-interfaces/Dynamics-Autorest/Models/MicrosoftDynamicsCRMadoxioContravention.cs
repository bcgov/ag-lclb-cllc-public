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
    /// Microsoft.Dynamics.CRM.adoxio_contravention
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioContravention
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioContravention class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioContravention()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioContravention class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioContravention(decimal? exchangerate = default(decimal?), decimal? adoxioMaxpenalty = default(decimal?), string _owneridValue = default(string), int? adoxioNumberofoffence = default(int?), int? timezoneruleversionnumber = default(int?), bool? adoxioIstandc = default(bool?), string _owninguserValue = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _adoxioEstablishmentidValue = default(string), bool? adoxioIsact = default(bool?), int? adoxioRecommendedclosureperiod = default(int?), int? adoxioIswaivedbylicensee = default(int?), string _createdonbehalfbyValue = default(string), int? statuscode = default(int?), System.DateTimeOffset? adoxioCnissueddate = default(System.DateTimeOffset?), string _adoxioLicenceidValue = default(string), string _transactioncurrencyidValue = default(string), int? adoxioDelegategmdecision = default(int?), int? adoxioItemnumber = default(int?), int? utcconversiontimezonecode = default(int?), decimal? adoxioMinpenalty = default(decimal?), decimal? adoxioRecommendedmonetarypenaltyBase = default(decimal?), string adoxioBadgenumber = default(string), string _owningteamValue = default(string), int? statecode = default(int?), string adoxioLpcnumber = default(string), string adoxioIstandcwordtemplate = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), bool? adoxioIswqr = default(bool?), string _adoxioContraventiontitleidValue = default(string), System.DateTimeOffset? adoxioIncidentdatetime = default(System.DateTimeOffset?), string adoxioRmsummary = default(string), string _adoxioInvestigationidValue = default(string), string adoxioIsactwordtemplate = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? adoxioActiondate = default(System.DateTimeOffset?), int? adoxioType = default(int?), string _adoxioCompliantidValue = default(string), int? adoxioMaxperiod = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), decimal? adoxioRecommendedmonetarypenalty = default(decimal?), string adoxioIsregwordtemplate = default(string), string adoxioContraventionnumber = default(string), string _adoxioRegionalmanageridValue = default(string), string adoxioPolicynamereference = default(string), System.DateTimeOffset? adoxioDatetime = default(System.DateTimeOffset?), string _adoxioLicenseeidValue = default(string), int? adoxioIscontraventionconfirmed = default(int?), string _adoxioAreaidValue = default(string), bool? adoxioIsreg = default(bool?), string adoxioReference = default(string), int? adoxioMinperiod = default(int?), string adoxioContraventionevidencesummary = default(string), int? adoxioRmapprovaldecision = default(int?), string adoxioName = default(string), string adoxioInspectorsummary = default(string), string _adoxioInspectionidValue = default(string), string adoxioInterpretation = default(string), decimal? adoxioMaxpenaltyBase = default(decimal?), System.DateTimeOffset? adoxioRmapprovaldecisiondate = default(System.DateTimeOffset?), int? adoxioActiontaken = default(int?), string _createdbyValue = default(string), string versionnumber = default(string), string _modifiedonbehalfbyValue = default(string), string _adoxioRegionidValue = default(string), int? adoxioContraventionoutcome = default(int?), string _modifiedbyValue = default(string), string adoxioIswqrwordtemplate = default(string), string adoxioContraventionid = default(string), int? adoxioCategory = default(int?), decimal? adoxioMinpenaltyBase = default(decimal?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioContraventionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioContraventionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioContraventionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioContraventionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioContraventionMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioContraventionProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioContraventionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioContraventionPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMadoxioContraventionadmin adoxioContraventionTitleID = default(MicrosoftDynamicsCRMadoxioContraventionadmin), MicrosoftDynamicsCRMadoxioComplaint adoxioCompliantId = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMincident adoxioInspectionId = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMadoxioEstablishment adoxioEstablishmentId = default(MicrosoftDynamicsCRMadoxioEstablishment), MicrosoftDynamicsCRMadoxioArea adoxioAreaId = default(MicrosoftDynamicsCRMadoxioArea), MicrosoftDynamicsCRMadoxioLicences adoxioLicenceId = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMsystemuser adoxioRegionalManagerId = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMaccount adoxioLicenseeId = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMadoxioComplianceinvestigation adoxioInvestigationId = default(MicrosoftDynamicsCRMadoxioComplianceinvestigation), IList<MicrosoftDynamicsCRMadoxioInvestigationactivity> adoxioContraventionInvestigationactivities = default(IList<MicrosoftDynamicsCRMadoxioInvestigationactivity>), MicrosoftDynamicsCRMadoxioRegion adoxioRegionId = default(MicrosoftDynamicsCRMadoxioRegion), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> adoxioContraventionSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMadoxioCompliancemeeting> adoxioContraventionCompliancemeetings = default(IList<MicrosoftDynamicsCRMadoxioCompliancemeeting>), IList<MicrosoftDynamicsCRMannotation> adoxioContraventionAnnotations = default(IList<MicrosoftDynamicsCRMannotation>))
        {
            Exchangerate = exchangerate;
            AdoxioMaxpenalty = adoxioMaxpenalty;
            this._owneridValue = _owneridValue;
            AdoxioNumberofoffence = adoxioNumberofoffence;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioIstandc = adoxioIstandc;
            this._owninguserValue = _owninguserValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Overriddencreatedon = overriddencreatedon;
            this._adoxioEstablishmentidValue = _adoxioEstablishmentidValue;
            AdoxioIsact = adoxioIsact;
            AdoxioRecommendedclosureperiod = adoxioRecommendedclosureperiod;
            AdoxioIswaivedbylicensee = adoxioIswaivedbylicensee;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statuscode = statuscode;
            AdoxioCnissueddate = adoxioCnissueddate;
            this._adoxioLicenceidValue = _adoxioLicenceidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            AdoxioDelegategmdecision = adoxioDelegategmdecision;
            AdoxioItemnumber = adoxioItemnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioMinpenalty = adoxioMinpenalty;
            AdoxioRecommendedmonetarypenaltyBase = adoxioRecommendedmonetarypenaltyBase;
            AdoxioBadgenumber = adoxioBadgenumber;
            this._owningteamValue = _owningteamValue;
            Statecode = statecode;
            AdoxioLpcnumber = adoxioLpcnumber;
            AdoxioIstandcwordtemplate = adoxioIstandcwordtemplate;
            Createdon = createdon;
            AdoxioIswqr = adoxioIswqr;
            this._adoxioContraventiontitleidValue = _adoxioContraventiontitleidValue;
            AdoxioIncidentdatetime = adoxioIncidentdatetime;
            AdoxioRmsummary = adoxioRmsummary;
            this._adoxioInvestigationidValue = _adoxioInvestigationidValue;
            AdoxioIsactwordtemplate = adoxioIsactwordtemplate;
            Importsequencenumber = importsequencenumber;
            AdoxioActiondate = adoxioActiondate;
            AdoxioType = adoxioType;
            this._adoxioCompliantidValue = _adoxioCompliantidValue;
            AdoxioMaxperiod = adoxioMaxperiod;
            Modifiedon = modifiedon;
            AdoxioRecommendedmonetarypenalty = adoxioRecommendedmonetarypenalty;
            AdoxioIsregwordtemplate = adoxioIsregwordtemplate;
            AdoxioContraventionnumber = adoxioContraventionnumber;
            this._adoxioRegionalmanageridValue = _adoxioRegionalmanageridValue;
            AdoxioPolicynamereference = adoxioPolicynamereference;
            AdoxioDatetime = adoxioDatetime;
            this._adoxioLicenseeidValue = _adoxioLicenseeidValue;
            AdoxioIscontraventionconfirmed = adoxioIscontraventionconfirmed;
            this._adoxioAreaidValue = _adoxioAreaidValue;
            AdoxioIsreg = adoxioIsreg;
            AdoxioReference = adoxioReference;
            AdoxioMinperiod = adoxioMinperiod;
            AdoxioContraventionevidencesummary = adoxioContraventionevidencesummary;
            AdoxioRmapprovaldecision = adoxioRmapprovaldecision;
            AdoxioName = adoxioName;
            AdoxioInspectorsummary = adoxioInspectorsummary;
            this._adoxioInspectionidValue = _adoxioInspectionidValue;
            AdoxioInterpretation = adoxioInterpretation;
            AdoxioMaxpenaltyBase = adoxioMaxpenaltyBase;
            AdoxioRmapprovaldecisiondate = adoxioRmapprovaldecisiondate;
            AdoxioActiontaken = adoxioActiontaken;
            this._createdbyValue = _createdbyValue;
            Versionnumber = versionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._adoxioRegionidValue = _adoxioRegionidValue;
            AdoxioContraventionoutcome = adoxioContraventionoutcome;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioIswqrwordtemplate = adoxioIswqrwordtemplate;
            AdoxioContraventionid = adoxioContraventionid;
            AdoxioCategory = adoxioCategory;
            AdoxioMinpenaltyBase = adoxioMinpenaltyBase;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioContraventionSyncErrors = adoxioContraventionSyncErrors;
            AdoxioContraventionDuplicateMatchingRecord = adoxioContraventionDuplicateMatchingRecord;
            AdoxioContraventionDuplicateBaseRecord = adoxioContraventionDuplicateBaseRecord;
            AdoxioContraventionAsyncOperations = adoxioContraventionAsyncOperations;
            AdoxioContraventionMailboxTrackingFolders = adoxioContraventionMailboxTrackingFolders;
            AdoxioContraventionProcessSession = adoxioContraventionProcessSession;
            AdoxioContraventionBulkDeleteFailures = adoxioContraventionBulkDeleteFailures;
            AdoxioContraventionPrincipalObjectAttributeAccesses = adoxioContraventionPrincipalObjectAttributeAccesses;
            Transactioncurrencyid = transactioncurrencyid;
            AdoxioContraventionTitleID = adoxioContraventionTitleID;
            AdoxioCompliantId = adoxioCompliantId;
            AdoxioInspectionId = adoxioInspectionId;
            AdoxioEstablishmentId = adoxioEstablishmentId;
            AdoxioAreaId = adoxioAreaId;
            AdoxioLicenceId = adoxioLicenceId;
            AdoxioRegionalManagerId = adoxioRegionalManagerId;
            AdoxioLicenseeId = adoxioLicenseeId;
            AdoxioInvestigationId = adoxioInvestigationId;
            AdoxioContraventionInvestigationactivities = adoxioContraventionInvestigationactivities;
            AdoxioRegionId = adoxioRegionId;
            AdoxioContraventionSharePointDocumentLocations = adoxioContraventionSharePointDocumentLocations;
            AdoxioContraventionCompliancemeetings = adoxioContraventionCompliancemeetings;
            AdoxioContraventionAnnotations = adoxioContraventionAnnotations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_maxpenalty")]
        public decimal? AdoxioMaxpenalty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_numberofoffence")]
        public int? AdoxioNumberofoffence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_istandc")]
        public bool? AdoxioIstandc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_establishmentid_value")]
        public string _adoxioEstablishmentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isact")]
        public bool? AdoxioIsact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_recommendedclosureperiod")]
        public int? AdoxioRecommendedclosureperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iswaivedbylicensee")]
        public int? AdoxioIswaivedbylicensee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_cnissueddate")]
        public System.DateTimeOffset? AdoxioCnissueddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licenceid_value")]
        public string _adoxioLicenceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_delegategmdecision")]
        public int? AdoxioDelegategmdecision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_itemnumber")]
        public int? AdoxioItemnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_minpenalty")]
        public decimal? AdoxioMinpenalty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_recommendedmonetarypenalty_base")]
        public decimal? AdoxioRecommendedmonetarypenaltyBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_badgenumber")]
        public string AdoxioBadgenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lpcnumber")]
        public string AdoxioLpcnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_istandcwordtemplate")]
        public string AdoxioIstandcwordtemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iswqr")]
        public bool? AdoxioIswqr { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_contraventiontitleid_value")]
        public string _adoxioContraventiontitleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_incidentdatetime")]
        public System.DateTimeOffset? AdoxioIncidentdatetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_rmsummary")]
        public string AdoxioRmsummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_investigationid_value")]
        public string _adoxioInvestigationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isactwordtemplate")]
        public string AdoxioIsactwordtemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_actiondate")]
        public System.DateTimeOffset? AdoxioActiondate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_type")]
        public int? AdoxioType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_compliantid_value")]
        public string _adoxioCompliantidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_maxperiod")]
        public int? AdoxioMaxperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_recommendedmonetarypenalty")]
        public decimal? AdoxioRecommendedmonetarypenalty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isregwordtemplate")]
        public string AdoxioIsregwordtemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionnumber")]
        public string AdoxioContraventionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_regionalmanagerid_value")]
        public string _adoxioRegionalmanageridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_policynamereference")]
        public string AdoxioPolicynamereference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_datetime")]
        public System.DateTimeOffset? AdoxioDatetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licenseeid_value")]
        public string _adoxioLicenseeidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iscontraventionconfirmed")]
        public int? AdoxioIscontraventionconfirmed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_areaid_value")]
        public string _adoxioAreaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isreg")]
        public bool? AdoxioIsreg { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_reference")]
        public string AdoxioReference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_minperiod")]
        public int? AdoxioMinperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionevidencesummary")]
        public string AdoxioContraventionevidencesummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_rmapprovaldecision")]
        public int? AdoxioRmapprovaldecision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_inspectorsummary")]
        public string AdoxioInspectorsummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_inspectionid_value")]
        public string _adoxioInspectionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_interpretation")]
        public string AdoxioInterpretation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_maxpenalty_base")]
        public decimal? AdoxioMaxpenaltyBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_rmapprovaldecisiondate")]
        public System.DateTimeOffset? AdoxioRmapprovaldecisiondate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_actiontaken")]
        public int? AdoxioActiontaken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_regionid_value")]
        public string _adoxioRegionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionoutcome")]
        public int? AdoxioContraventionoutcome { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iswqrwordtemplate")]
        public string AdoxioIswqrwordtemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionid")]
        public string AdoxioContraventionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_category")]
        public int? AdoxioCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_minpenalty_base")]
        public decimal? AdoxioMinpenaltyBase { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_contravention_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioContraventionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioContraventionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioContraventionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioContraventionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioContraventionMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioContraventionProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioContraventionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioContraventionPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ContraventionTitleID")]
        public MicrosoftDynamicsCRMadoxioContraventionadmin AdoxioContraventionTitleID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_CompliantId")]
        public MicrosoftDynamicsCRMadoxioComplaint AdoxioCompliantId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_InspectionId")]
        public MicrosoftDynamicsCRMincident AdoxioInspectionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_EstablishmentId")]
        public MicrosoftDynamicsCRMadoxioEstablishment AdoxioEstablishmentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_AreaId")]
        public MicrosoftDynamicsCRMadoxioArea AdoxioAreaId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceId")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioLicenceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RegionalManagerId")]
        public MicrosoftDynamicsCRMsystemuser AdoxioRegionalManagerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenseeId")]
        public MicrosoftDynamicsCRMaccount AdoxioLicenseeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_InvestigationId")]
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation AdoxioInvestigationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_investigationactivities")]
        public IList<MicrosoftDynamicsCRMadoxioInvestigationactivity> AdoxioContraventionInvestigationactivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RegionId")]
        public MicrosoftDynamicsCRMadoxioRegion AdoxioRegionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> AdoxioContraventionSharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_compliancemeetings")]
        public IList<MicrosoftDynamicsCRMadoxioCompliancemeeting> AdoxioContraventionCompliancemeetings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> AdoxioContraventionAnnotations { get; set; }

    }
}
