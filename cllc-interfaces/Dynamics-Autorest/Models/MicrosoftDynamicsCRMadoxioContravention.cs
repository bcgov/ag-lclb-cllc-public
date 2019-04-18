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
    /// adoxio_contravention
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
        public MicrosoftDynamicsCRMadoxioContravention(string adoxioContraventionid = default(string), string _adoxioEstablishmentidValue = default(string), int? adoxioRmapprovaldecision = default(int?), string _owningbusinessunitValue = default(string), System.DateTimeOffset? adoxioIncidentdatetime = default(System.DateTimeOffset?), int? adoxioNumberofoffence = default(int?), System.DateTimeOffset? adoxioRmapprovaldecisiondate = default(System.DateTimeOffset?), string _adoxioInvestigationidValue = default(string), string _adoxioRegionalmanageridValue = default(string), string _adoxioCompliantidValue = default(string), long? versionnumber = default(long?), int? adoxioMinperiod = default(int?), object adoxioMinpenaltyBase = default(object), System.DateTimeOffset? adoxioCnissueddate = default(System.DateTimeOffset?), string adoxioInspectorsummary = default(string), string _adoxioInspectionidValue = default(string), int? timezoneruleversionnumber = default(int?), int? statuscode = default(int?), string _adoxioLicenceidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioName = default(string), string _adoxioLicenseeidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? adoxioItemnumber = default(int?), int? adoxioDelegategmdecision = default(int?), string _transactioncurrencyidValue = default(string), string adoxioRmsummary = default(string), object adoxioMinpenalty = default(object), string _modifiedbyValue = default(string), int? utcconversiontimezonecode = default(int?), int? adoxioRecommendedclosureperiod = default(int?), int? adoxioCategory = default(int?), int? adoxioIscontraventionconfirmed = default(int?), int? statecode = default(int?), string adoxioReference = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? adoxioDatetime = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string _createdonbehalfbyValue = default(string), string adoxioContraventionnumber = default(string), object adoxioMaxpenaltyBase = default(object), string adoxioInterpretation = default(string), System.DateTimeOffset? adoxioActiondate = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), int? adoxioActiontaken = default(int?), string _owningteamValue = default(string), object adoxioRecommendedmonetarypenaltyBase = default(object), string _adoxioAreaidValue = default(string), string _adoxioContraventiontitleidValue = default(string), int? adoxioMaxperiod = default(int?), int? adoxioIswaivedbylicensee = default(int?), object adoxioMaxpenalty = default(object), string _owneridValue = default(string), string _createdbyValue = default(string), object exchangerate = default(object), object adoxioRecommendedmonetarypenalty = default(object), string _owninguserValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioContraventionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioContraventionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioContraventionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioContraventionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioContraventionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMadoxioArea adoxioAreaId = default(MicrosoftDynamicsCRMadoxioArea), MicrosoftDynamicsCRMadoxioComplaint adoxioCompliantId = default(MicrosoftDynamicsCRMadoxioComplaint), IList<MicrosoftDynamicsCRMadoxioInvestigationactivity> adoxioContraventionInvestigationactivities = default(IList<MicrosoftDynamicsCRMadoxioInvestigationactivity>), MicrosoftDynamicsCRMadoxioContraventionadmin adoxioContraventionTitleID = default(MicrosoftDynamicsCRMadoxioContraventionadmin), MicrosoftDynamicsCRMadoxioEstablishment adoxioEstablishmentId = default(MicrosoftDynamicsCRMadoxioEstablishment), MicrosoftDynamicsCRMincident adoxioInspectionId = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMadoxioComplianceinvestigation adoxioInvestigationId = default(MicrosoftDynamicsCRMadoxioComplianceinvestigation), MicrosoftDynamicsCRMadoxioLicences adoxioLicenceId = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMaccount adoxioLicenseeId = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMsystemuser adoxioRegionalManagerId = default(MicrosoftDynamicsCRMsystemuser))
        {
            AdoxioContraventionid = adoxioContraventionid;
            this._adoxioEstablishmentidValue = _adoxioEstablishmentidValue;
            AdoxioRmapprovaldecision = adoxioRmapprovaldecision;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioIncidentdatetime = adoxioIncidentdatetime;
            AdoxioNumberofoffence = adoxioNumberofoffence;
            AdoxioRmapprovaldecisiondate = adoxioRmapprovaldecisiondate;
            this._adoxioInvestigationidValue = _adoxioInvestigationidValue;
            this._adoxioRegionalmanageridValue = _adoxioRegionalmanageridValue;
            this._adoxioCompliantidValue = _adoxioCompliantidValue;
            Versionnumber = versionnumber;
            AdoxioMinperiod = adoxioMinperiod;
            AdoxioMinpenaltyBase = adoxioMinpenaltyBase;
            AdoxioCnissueddate = adoxioCnissueddate;
            AdoxioInspectorsummary = adoxioInspectorsummary;
            this._adoxioInspectionidValue = _adoxioInspectionidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statuscode = statuscode;
            this._adoxioLicenceidValue = _adoxioLicenceidValue;
            Modifiedon = modifiedon;
            AdoxioName = adoxioName;
            this._adoxioLicenseeidValue = _adoxioLicenseeidValue;
            Createdon = createdon;
            AdoxioItemnumber = adoxioItemnumber;
            AdoxioDelegategmdecision = adoxioDelegategmdecision;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            AdoxioRmsummary = adoxioRmsummary;
            AdoxioMinpenalty = adoxioMinpenalty;
            this._modifiedbyValue = _modifiedbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioRecommendedclosureperiod = adoxioRecommendedclosureperiod;
            AdoxioCategory = adoxioCategory;
            AdoxioIscontraventionconfirmed = adoxioIscontraventionconfirmed;
            Statecode = statecode;
            AdoxioReference = adoxioReference;
            Overriddencreatedon = overriddencreatedon;
            AdoxioDatetime = adoxioDatetime;
            Importsequencenumber = importsequencenumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioContraventionnumber = adoxioContraventionnumber;
            AdoxioMaxpenaltyBase = adoxioMaxpenaltyBase;
            AdoxioInterpretation = adoxioInterpretation;
            AdoxioActiondate = adoxioActiondate;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioActiontaken = adoxioActiontaken;
            this._owningteamValue = _owningteamValue;
            AdoxioRecommendedmonetarypenaltyBase = adoxioRecommendedmonetarypenaltyBase;
            this._adoxioAreaidValue = _adoxioAreaidValue;
            this._adoxioContraventiontitleidValue = _adoxioContraventiontitleidValue;
            AdoxioMaxperiod = adoxioMaxperiod;
            AdoxioIswaivedbylicensee = adoxioIswaivedbylicensee;
            AdoxioMaxpenalty = adoxioMaxpenalty;
            this._owneridValue = _owneridValue;
            this._createdbyValue = _createdbyValue;
            Exchangerate = exchangerate;
            AdoxioRecommendedmonetarypenalty = adoxioRecommendedmonetarypenalty;
            this._owninguserValue = _owninguserValue;
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
            AdoxioContraventionBulkDeleteFailures = adoxioContraventionBulkDeleteFailures;
            Transactioncurrencyid = transactioncurrencyid;
            AdoxioAreaId = adoxioAreaId;
            AdoxioCompliantId = adoxioCompliantId;
            AdoxioContraventionInvestigationactivities = adoxioContraventionInvestigationactivities;
            AdoxioContraventionTitleID = adoxioContraventionTitleID;
            AdoxioEstablishmentId = adoxioEstablishmentId;
            AdoxioInspectionId = adoxioInspectionId;
            AdoxioInvestigationId = adoxioInvestigationId;
            AdoxioLicenceId = adoxioLicenceId;
            AdoxioLicenseeId = adoxioLicenseeId;
            AdoxioRegionalManagerId = adoxioRegionalManagerId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionid")]
        public string AdoxioContraventionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_establishmentid_value")]
        public string _adoxioEstablishmentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_rmapprovaldecision")]
        public int? AdoxioRmapprovaldecision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_incidentdatetime")]
        public System.DateTimeOffset? AdoxioIncidentdatetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_numberofoffence")]
        public int? AdoxioNumberofoffence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_rmapprovaldecisiondate")]
        public System.DateTimeOffset? AdoxioRmapprovaldecisiondate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_investigationid_value")]
        public string _adoxioInvestigationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_regionalmanagerid_value")]
        public string _adoxioRegionalmanageridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_compliantid_value")]
        public string _adoxioCompliantidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_minperiod")]
        public int? AdoxioMinperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_minpenalty_base")]
        public object AdoxioMinpenaltyBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_cnissueddate")]
        public System.DateTimeOffset? AdoxioCnissueddate { get; set; }

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
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licenceid_value")]
        public string _adoxioLicenceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licenseeid_value")]
        public string _adoxioLicenseeidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_itemnumber")]
        public int? AdoxioItemnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_delegategmdecision")]
        public int? AdoxioDelegategmdecision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_rmsummary")]
        public string AdoxioRmsummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_minpenalty")]
        public object AdoxioMinpenalty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_recommendedclosureperiod")]
        public int? AdoxioRecommendedclosureperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_category")]
        public int? AdoxioCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iscontraventionconfirmed")]
        public int? AdoxioIscontraventionconfirmed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_reference")]
        public string AdoxioReference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_datetime")]
        public System.DateTimeOffset? AdoxioDatetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionnumber")]
        public string AdoxioContraventionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_maxpenalty_base")]
        public object AdoxioMaxpenaltyBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_interpretation")]
        public string AdoxioInterpretation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_actiondate")]
        public System.DateTimeOffset? AdoxioActiondate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_actiontaken")]
        public int? AdoxioActiontaken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_recommendedmonetarypenalty_base")]
        public object AdoxioRecommendedmonetarypenaltyBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_areaid_value")]
        public string _adoxioAreaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_contraventiontitleid_value")]
        public string _adoxioContraventiontitleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_maxperiod")]
        public int? AdoxioMaxperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iswaivedbylicensee")]
        public int? AdoxioIswaivedbylicensee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_maxpenalty")]
        public object AdoxioMaxpenalty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_recommendedmonetarypenalty")]
        public object AdoxioRecommendedmonetarypenalty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_contravention_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioContraventionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_AreaId")]
        public MicrosoftDynamicsCRMadoxioArea AdoxioAreaId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_CompliantId")]
        public MicrosoftDynamicsCRMadoxioComplaint AdoxioCompliantId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_investigationactivities")]
        public IList<MicrosoftDynamicsCRMadoxioInvestigationactivity> AdoxioContraventionInvestigationactivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ContraventionTitleID")]
        public MicrosoftDynamicsCRMadoxioContraventionadmin AdoxioContraventionTitleID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_EstablishmentId")]
        public MicrosoftDynamicsCRMadoxioEstablishment AdoxioEstablishmentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_InspectionId")]
        public MicrosoftDynamicsCRMincident AdoxioInspectionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_InvestigationId")]
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation AdoxioInvestigationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceId")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioLicenceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenseeId")]
        public MicrosoftDynamicsCRMaccount AdoxioLicenseeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RegionalManagerId")]
        public MicrosoftDynamicsCRMsystemuser AdoxioRegionalManagerId { get; set; }

    }
}
