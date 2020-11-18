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
    /// Microsoft.Dynamics.CRM.ratingmodel
    /// </summary>
    public partial class MicrosoftDynamicsCRMratingmodel
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMratingmodel
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMratingmodel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMratingmodel
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMratingmodel(string _owningbusinessunitValue = default(string), decimal? exchangerate = default(decimal?), string _transactioncurrencyidValue = default(string), string _createdonbehalfbyValue = default(string), string _owningteamValue = default(string), string _modifiedonbehalfbyValue = default(string), string _createdbyValue = default(string), string _owninguserValue = default(string), int? minratingvalue = default(int?), int? timezoneruleversionnumber = default(int?), string _owneridValue = default(string), string _modifiedbyValue = default(string), int? statecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string ratingmodelid = default(string), int? utcconversiontimezonecode = default(int?), string name = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string versionnumber = default(string), int? maxratingvalue = default(int?), int? statuscode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMduplicaterecord> ratingmodelDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ratingmodelDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ratingmodelAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMprocesssession> ratingmodelProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ratingmodelBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ratingmodelPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMratingvalue> ratingmodelRatingvalueRatingModel = default(IList<MicrosoftDynamicsCRMratingvalue>), IList<MicrosoftDynamicsCRMteam> ratingmodelTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ratingmodelMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMsyncerror> ratingModelSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Exchangerate = exchangerate;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owningteamValue = _owningteamValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            this._owninguserValue = _owninguserValue;
            Minratingvalue = minratingvalue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owneridValue = _owneridValue;
            this._modifiedbyValue = _modifiedbyValue;
            Statecode = statecode;
            Modifiedon = modifiedon;
            Ratingmodelid = ratingmodelid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Name = name;
            Importsequencenumber = importsequencenumber;
            Overriddencreatedon = overriddencreatedon;
            Versionnumber = versionnumber;
            Maxratingvalue = maxratingvalue;
            Statuscode = statuscode;
            Createdon = createdon;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            RatingmodelDuplicateMatchingRecord = ratingmodelDuplicateMatchingRecord;
            RatingmodelDuplicateBaseRecord = ratingmodelDuplicateBaseRecord;
            RatingmodelAsyncOperations = ratingmodelAsyncOperations;
            RatingmodelProcessSession = ratingmodelProcessSession;
            RatingmodelBulkDeleteFailures = ratingmodelBulkDeleteFailures;
            RatingmodelPrincipalObjectAttributeAccesses = ratingmodelPrincipalObjectAttributeAccesses;
            RatingmodelRatingvalueRatingModel = ratingmodelRatingvalueRatingModel;
            RatingmodelTeams = ratingmodelTeams;
            RatingmodelMailboxTrackingFolders = ratingmodelMailboxTrackingFolders;
            RatingModelSyncErrors = ratingModelSyncErrors;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minratingvalue")]
        public int? Minratingvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodelid")]
        public string Ratingmodelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxratingvalue")]
        public int? Maxratingvalue { get; set; }

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
        [JsonProperty(PropertyName = "ratingmodel_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> RatingmodelDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> RatingmodelDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> RatingmodelAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> RatingmodelProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> RatingmodelBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> RatingmodelPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_ratingvalue_RatingModel")]
        public IList<MicrosoftDynamicsCRMratingvalue> RatingmodelRatingvalueRatingModel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_Teams")]
        public IList<MicrosoftDynamicsCRMteam> RatingmodelTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> RatingmodelMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RatingModel_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> RatingModelSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
