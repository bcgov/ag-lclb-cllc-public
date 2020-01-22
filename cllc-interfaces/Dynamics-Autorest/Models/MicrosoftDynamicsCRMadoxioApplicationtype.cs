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
    /// Microsoft.Dynamics.CRM.adoxio_applicationtype
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioApplicationtype
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationtype class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationtype()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationtype class.
        /// </summary>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="versionnumber">Version Number</param>
        /// <param name="_owneridValue">Owner Id</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="adoxioPortallabel">The application name that is
        /// displayed to the applicant/licensee online.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="adoxioName">The name of the custom entity.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="statecode">Status of the Application Type</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="statuscode">Reason for the status of the Application
        /// Type</param>
        /// <param name="adoxioApplicationtypeid">Unique identifier for entity
        /// instances</param>
        public MicrosoftDynamicsCRMadoxioApplicationtype(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), bool? adoxioShowdescription3 = default(bool?), string _modifiedbyValue = default(string), int? adoxioFloorplan = default(int?), string adoxioCode = default(string), string adoxioDefaultbpmid = default(string), string adoxioDefaultqueuename = default(string), int? adoxioValidinterest = default(int?), int? importsequencenumber = default(int?), bool? adoxioIsshowpropertydetails = default(bool?), bool? adoxioIsshowcurrentproperty = default(bool?), bool? adoxioIslockestablishmentname = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), bool? adoxioIsshowdeclarations = default(bool?), bool? adoxioIsshowfinancialintegrityformupload = default(bool?), string versionnumber = default(string), string _owneridValue = default(string), bool? adoxioIsshowsupportingdocuments = default(bool?), string _owninguserValue = default(string), string _createdonbehalfbyValue = default(string), string adoxioActiontext = default(string), string adoxioPortallabel = default(string), string adoxioTitletext = default(string), bool? adoxioRequiressecurityscreening = default(bool?), int? adoxioSignage = default(int?), bool? adoxioIsshowassociatesformupload = default(bool?), string _owningbusinessunitValue = default(string), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), bool? adoxioIsdefault = default(bool?), int? adoxioCurrentestablishmentaddress = default(int?), int? adoxioStorecontactinfo = default(int?), bool? adoxioShowdescription1 = default(bool?), int? adoxioSiteplan = default(int?), string adoxioName = default(string), string _adoxioLicencetypeValue = default(string), string _adoxioApplicationfeeproductValue = default(string), string adoxioDefaultbpfid = default(string), bool? adoxioShowdescription2 = default(bool?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? adoxioCategory = default(int?), int? statecode = default(int?), string adoxioFormreference = default(string), bool? adoxioIsshowhoursofsale = default(bool?), string _modifiedonbehalfbyValue = default(string), int? adoxioEstablishmentname = default(int?), string _owningteamValue = default(string), int? statuscode = default(int?), int? adoxioNewestablishmentaddress = default(int?), string _adoxioRenewalapplicationtypeValue = default(string), string adoxioApplicationtypeid = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioApplicationtypeSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioApplicationtypeDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioApplicationtypeDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioApplicationtypeAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioApplicationtypeBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioApplicationtypeApplications = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMadoxioLicencetype> adoxioLicencetypesApplicationtypes = default(IList<MicrosoftDynamicsCRMadoxioLicencetype>), IList<MicrosoftDynamicsCRMadoxioApplicationtypecontent> adoxioApplicationtypeAdoxioApplicationtypecontentApplicationType = default(IList<MicrosoftDynamicsCRMadoxioApplicationtypecontent>), MicrosoftDynamicsCRMproduct adoxioApplicationFeeProduct = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMadoxioLicencetype adoxioLicenceType = default(MicrosoftDynamicsCRMadoxioLicencetype), IList<MicrosoftDynamicsCRMincident> adoxioApplicationtypeInspections = default(IList<MicrosoftDynamicsCRMincident>), MicrosoftDynamicsCRMadoxioApplicationtype adoxioRenewalApplicationType = default(MicrosoftDynamicsCRMadoxioApplicationtype), IList<MicrosoftDynamicsCRMadoxioApplicationtype> adoxioApplicationtypeRenewalType = default(IList<MicrosoftDynamicsCRMadoxioApplicationtype>), IList<MicrosoftDynamicsCRMadoxioLicenseechangelog> adoxioApplicationtypeAdoxioLicenseechangelogApplicationType = default(IList<MicrosoftDynamicsCRMadoxioLicenseechangelog>), IList<MicrosoftDynamicsCRMadoxioFormelementuploadfield> adoxioApplicationtypeFormelementuploadfields = default(IList<MicrosoftDynamicsCRMadoxioFormelementuploadfield>))
        {
            Overriddencreatedon = overriddencreatedon;
            this._createdbyValue = _createdbyValue;
            AdoxioShowdescription3 = adoxioShowdescription3;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioFloorplan = adoxioFloorplan;
            AdoxioCode = adoxioCode;
            AdoxioDefaultbpmid = adoxioDefaultbpmid;
            AdoxioDefaultqueuename = adoxioDefaultqueuename;
            AdoxioValidinterest = adoxioValidinterest;
            Importsequencenumber = importsequencenumber;
            AdoxioIsshowpropertydetails = adoxioIsshowpropertydetails;
            AdoxioIsshowcurrentproperty = adoxioIsshowcurrentproperty;
            AdoxioIslockestablishmentname = adoxioIslockestablishmentname;
            Modifiedon = modifiedon;
            AdoxioIsshowdeclarations = adoxioIsshowdeclarations;
            AdoxioIsshowfinancialintegrityformupload = adoxioIsshowfinancialintegrityformupload;
            Versionnumber = versionnumber;
            this._owneridValue = _owneridValue;
            AdoxioIsshowsupportingdocuments = adoxioIsshowsupportingdocuments;
            this._owninguserValue = _owninguserValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioActiontext = adoxioActiontext;
            AdoxioPortallabel = adoxioPortallabel;
            AdoxioTitletext = adoxioTitletext;
            AdoxioRequiressecurityscreening = adoxioRequiressecurityscreening;
            AdoxioSignage = adoxioSignage;
            AdoxioIsshowassociatesformupload = adoxioIsshowassociatesformupload;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioIsdefault = adoxioIsdefault;
            AdoxioCurrentestablishmentaddress = adoxioCurrentestablishmentaddress;
            AdoxioStorecontactinfo = adoxioStorecontactinfo;
            AdoxioShowdescription1 = adoxioShowdescription1;
            AdoxioSiteplan = adoxioSiteplan;
            AdoxioName = adoxioName;
            this._adoxioLicencetypeValue = _adoxioLicencetypeValue;
            this._adoxioApplicationfeeproductValue = _adoxioApplicationfeeproductValue;
            AdoxioDefaultbpfid = adoxioDefaultbpfid;
            AdoxioShowdescription2 = adoxioShowdescription2;
            Createdon = createdon;
            AdoxioCategory = adoxioCategory;
            Statecode = statecode;
            AdoxioFormreference = adoxioFormreference;
            AdoxioIsshowhoursofsale = adoxioIsshowhoursofsale;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioEstablishmentname = adoxioEstablishmentname;
            this._owningteamValue = _owningteamValue;
            Statuscode = statuscode;
            AdoxioNewestablishmentaddress = adoxioNewestablishmentaddress;
            this._adoxioRenewalapplicationtypeValue = _adoxioRenewalapplicationtypeValue;
            AdoxioApplicationtypeid = adoxioApplicationtypeid;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioApplicationtypeSyncErrors = adoxioApplicationtypeSyncErrors;
            AdoxioApplicationtypeDuplicateMatchingRecord = adoxioApplicationtypeDuplicateMatchingRecord;
            AdoxioApplicationtypeDuplicateBaseRecord = adoxioApplicationtypeDuplicateBaseRecord;
            AdoxioApplicationtypeAsyncOperations = adoxioApplicationtypeAsyncOperations;
            AdoxioApplicationtypeBulkDeleteFailures = adoxioApplicationtypeBulkDeleteFailures;
            AdoxioApplicationtypeApplications = adoxioApplicationtypeApplications;
            AdoxioLicencetypesApplicationtypes = adoxioLicencetypesApplicationtypes;
            AdoxioApplicationtypeAdoxioApplicationtypecontentApplicationType = adoxioApplicationtypeAdoxioApplicationtypecontentApplicationType;
            AdoxioApplicationFeeProduct = adoxioApplicationFeeProduct;
            AdoxioLicenceType = adoxioLicenceType;
            AdoxioApplicationtypeInspections = adoxioApplicationtypeInspections;
            AdoxioRenewalApplicationType = adoxioRenewalApplicationType;
            AdoxioApplicationtypeRenewalType = adoxioApplicationtypeRenewalType;
            AdoxioApplicationtypeAdoxioLicenseechangelogApplicationType = adoxioApplicationtypeAdoxioLicenseechangelogApplicationType;
            AdoxioApplicationtypeFormelementuploadfields = adoxioApplicationtypeFormelementuploadfields;
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
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_showdescription3")]
        public bool? AdoxioShowdescription3 { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_floorplan")]
        public int? AdoxioFloorplan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_code")]
        public string AdoxioCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_defaultbpmid")]
        public string AdoxioDefaultbpmid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_defaultqueuename")]
        public string AdoxioDefaultqueuename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_validinterest")]
        public int? AdoxioValidinterest { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowpropertydetails")]
        public bool? AdoxioIsshowpropertydetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowcurrentproperty")]
        public bool? AdoxioIsshowcurrentproperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_islockestablishmentname")]
        public bool? AdoxioIslockestablishmentname { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowdeclarations")]
        public bool? AdoxioIsshowdeclarations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowfinancialintegrityformupload")]
        public bool? AdoxioIsshowfinancialintegrityformupload { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets owner Id
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowsupportingdocuments")]
        public bool? AdoxioIsshowsupportingdocuments { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_actiontext")]
        public string AdoxioActiontext { get; set; }

        /// <summary>
        /// Gets or sets the application name that is displayed to the
        /// applicant/licensee online.
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_portallabel")]
        public string AdoxioPortallabel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_titletext")]
        public string AdoxioTitletext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_requiressecurityscreening")]
        public bool? AdoxioRequiressecurityscreening { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_signage")]
        public int? AdoxioSignage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowassociatesformupload")]
        public bool? AdoxioIsshowassociatesformupload { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

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
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isdefault")]
        public bool? AdoxioIsdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_currentestablishmentaddress")]
        public int? AdoxioCurrentestablishmentaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_storecontactinfo")]
        public int? AdoxioStorecontactinfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_showdescription1")]
        public bool? AdoxioShowdescription1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_siteplan")]
        public int? AdoxioSiteplan { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licencetype_value")]
        public string _adoxioLicencetypeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_applicationfeeproduct_value")]
        public string _adoxioApplicationfeeproductValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_defaultbpfid")]
        public string AdoxioDefaultbpfid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_showdescription2")]
        public bool? AdoxioShowdescription2 { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_category")]
        public int? AdoxioCategory { get; set; }

        /// <summary>
        /// Gets or sets status of the Application Type
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_formreference")]
        public string AdoxioFormreference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowhoursofsale")]
        public bool? AdoxioIsshowhoursofsale { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishmentname")]
        public int? AdoxioEstablishmentname { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Application Type
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_newestablishmentaddress")]
        public int? AdoxioNewestablishmentaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_renewalapplicationtype_value")]
        public string _adoxioRenewalapplicationtypeValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtypeid")]
        public string AdoxioApplicationtypeid { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_applicationtype_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioApplicationtypeSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioApplicationtypeDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioApplicationtypeDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioApplicationtypeAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioApplicationtypeBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_applications")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioApplicationtypeApplications { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypes_applicationtypes")]
        public IList<MicrosoftDynamicsCRMadoxioLicencetype> AdoxioLicencetypesApplicationtypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_adoxio_applicationtypecontent_ApplicationType")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtypecontent> AdoxioApplicationtypeAdoxioApplicationtypecontentApplicationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ApplicationFeeProduct")]
        public MicrosoftDynamicsCRMproduct AdoxioApplicationFeeProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceType")]
        public MicrosoftDynamicsCRMadoxioLicencetype AdoxioLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_inspections")]
        public IList<MicrosoftDynamicsCRMincident> AdoxioApplicationtypeInspections { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RenewalApplicationType")]
        public MicrosoftDynamicsCRMadoxioApplicationtype AdoxioRenewalApplicationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_RenewalType")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtype> AdoxioApplicationtypeRenewalType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_adoxio_licenseechangelog_ApplicationType")]
        public IList<MicrosoftDynamicsCRMadoxioLicenseechangelog> AdoxioApplicationtypeAdoxioLicenseechangelogApplicationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_formelementuploadfields")]
        public IList<MicrosoftDynamicsCRMadoxioFormelementuploadfield> AdoxioApplicationtypeFormelementuploadfields { get; set; }

    }
}
