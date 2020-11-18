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
    /// Microsoft.Dynamics.CRM.adoxio_territory
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioTerritory
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTerritory class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioTerritory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTerritory class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioTerritory(int? statuscode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string versionnumber = default(string), int? utcconversiontimezonecode = default(int?), string _adoxioPrimaryinspectorValue = default(string), string adoxioTerritoryid = default(string), string _owninguserValue = default(string), string _adoxioRegionValue = default(string), string _owningbusinessunitValue = default(string), string adoxioName = default(string), int? importsequencenumber = default(int?), string _owneridValue = default(string), int? statecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _owningteamValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioTerritorySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioTerritoryDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioTerritoryDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioTerritoryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioTerritoryMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioTerritoryProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioTerritoryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioTerritoryPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMadoxioRegion adoxioRegion = default(MicrosoftDynamicsCRMadoxioRegion), IList<MicrosoftDynamicsCRMadoxioEstablishment> adoxioAdoxioTerritoryAdoxioEstablishmentTerritory = default(IList<MicrosoftDynamicsCRMadoxioEstablishment>), IList<MicrosoftDynamicsCRMadoxioLicences> adoxioAdoxioTerritoryAdoxioLicencesTerritory = default(IList<MicrosoftDynamicsCRMadoxioLicences>), IList<MicrosoftDynamicsCRMadoxioPostalcode> adoxioAdoxioTerritoryAdoxioPostalcodeTerritory = default(IList<MicrosoftDynamicsCRMadoxioPostalcode>), MicrosoftDynamicsCRMsystemuser adoxioPrimaryInspector = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMadoxioCitydistrict> adoxioTerritoryAdoxioCitydistrictOfficeId = default(IList<MicrosoftDynamicsCRMadoxioCitydistrict>))
        {
            Statuscode = statuscode;
            Createdon = createdon;
            Versionnumber = versionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._adoxioPrimaryinspectorValue = _adoxioPrimaryinspectorValue;
            AdoxioTerritoryid = adoxioTerritoryid;
            this._owninguserValue = _owninguserValue;
            this._adoxioRegionValue = _adoxioRegionValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioName = adoxioName;
            Importsequencenumber = importsequencenumber;
            this._owneridValue = _owneridValue;
            Statecode = statecode;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owningteamValue = _owningteamValue;
            Modifiedon = modifiedon;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioTerritorySyncErrors = adoxioTerritorySyncErrors;
            AdoxioTerritoryDuplicateMatchingRecord = adoxioTerritoryDuplicateMatchingRecord;
            AdoxioTerritoryDuplicateBaseRecord = adoxioTerritoryDuplicateBaseRecord;
            AdoxioTerritoryAsyncOperations = adoxioTerritoryAsyncOperations;
            AdoxioTerritoryMailboxTrackingFolders = adoxioTerritoryMailboxTrackingFolders;
            AdoxioTerritoryProcessSession = adoxioTerritoryProcessSession;
            AdoxioTerritoryBulkDeleteFailures = adoxioTerritoryBulkDeleteFailures;
            AdoxioTerritoryPrincipalObjectAttributeAccesses = adoxioTerritoryPrincipalObjectAttributeAccesses;
            AdoxioRegion = adoxioRegion;
            AdoxioAdoxioTerritoryAdoxioEstablishmentTerritory = adoxioAdoxioTerritoryAdoxioEstablishmentTerritory;
            AdoxioAdoxioTerritoryAdoxioLicencesTerritory = adoxioAdoxioTerritoryAdoxioLicencesTerritory;
            AdoxioAdoxioTerritoryAdoxioPostalcodeTerritory = adoxioAdoxioTerritoryAdoxioPostalcodeTerritory;
            AdoxioPrimaryInspector = adoxioPrimaryInspector;
            AdoxioTerritoryAdoxioCitydistrictOfficeId = adoxioTerritoryAdoxioCitydistrictOfficeId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_primaryinspector_value")]
        public string _adoxioPrimaryinspectorValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_territoryid")]
        public string AdoxioTerritoryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_region_value")]
        public string _adoxioRegionValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_territory_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioTerritorySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_territory_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioTerritoryDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_territory_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioTerritoryDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_territory_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioTerritoryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_territory_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioTerritoryMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_territory_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioTerritoryProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_territory_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioTerritoryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_territory_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioTerritoryPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Region")]
        public MicrosoftDynamicsCRMadoxioRegion AdoxioRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_territory_adoxio_establishment_Territory")]
        public IList<MicrosoftDynamicsCRMadoxioEstablishment> AdoxioAdoxioTerritoryAdoxioEstablishmentTerritory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_territory_adoxio_licences_Territory")]
        public IList<MicrosoftDynamicsCRMadoxioLicences> AdoxioAdoxioTerritoryAdoxioLicencesTerritory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_territory_adoxio_postalcode_Territory")]
        public IList<MicrosoftDynamicsCRMadoxioPostalcode> AdoxioAdoxioTerritoryAdoxioPostalcodeTerritory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_PrimaryInspector")]
        public MicrosoftDynamicsCRMsystemuser AdoxioPrimaryInspector { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_territory_adoxio_citydistrict_OfficeId")]
        public IList<MicrosoftDynamicsCRMadoxioCitydistrict> AdoxioTerritoryAdoxioCitydistrictOfficeId { get; set; }

    }
}
