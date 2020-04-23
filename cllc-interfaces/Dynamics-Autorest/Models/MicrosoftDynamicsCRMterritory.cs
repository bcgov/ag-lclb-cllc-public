// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.territory
    /// </summary>
    public partial class MicrosoftDynamicsCRMterritory
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMterritory
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMterritory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMterritory
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMterritory(System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string entityimageUrl = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _createdbyValue = default(string), string _manageridValue = default(string), int? importsequencenumber = default(int?), decimal? exchangerate = default(decimal?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string description = default(string), string entityimageid = default(string), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), string _transactioncurrencyidValue = default(string), string _organizationidValue = default(string), string _modifiedbyValue = default(string), byte[] entityimage = default(byte[]), long? entityimageTimestamp = default(long?), string versionnumber = default(string), string territoryid = default(string), string name = default(string), IList<MicrosoftDynamicsCRMteam> territoryTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> territoryMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMconnection> territoryConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> territoryConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMsystemuser managerid = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> territoryDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMbulkdeletefailure> territoryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprocesssession> territoryProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMduplicaterecord> territoryDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsyncerror> territorySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMaccount> territoryAccounts = default(IList<MicrosoftDynamicsCRMaccount>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMasyncoperation> territoryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsystemuser> territorySystemUsers = default(IList<MicrosoftDynamicsCRMsystemuser>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> territoryPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Createdon = createdon;
            EntityimageUrl = entityimageUrl;
            Modifiedon = modifiedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            this._manageridValue = _manageridValue;
            Importsequencenumber = importsequencenumber;
            Exchangerate = exchangerate;
            Overriddencreatedon = overriddencreatedon;
            Description = description;
            Entityimageid = entityimageid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._organizationidValue = _organizationidValue;
            this._modifiedbyValue = _modifiedbyValue;
            Entityimage = entityimage;
            EntityimageTimestamp = entityimageTimestamp;
            Versionnumber = versionnumber;
            Territoryid = territoryid;
            Name = name;
            TerritoryTeams = territoryTeams;
            TerritoryMailboxTrackingFolders = territoryMailboxTrackingFolders;
            Createdonbehalfby = createdonbehalfby;
            TerritoryConnections1 = territoryConnections1;
            TerritoryConnections2 = territoryConnections2;
            Managerid = managerid;
            Createdby = createdby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Modifiedby = modifiedby;
            TerritoryDuplicateMatchingRecord = territoryDuplicateMatchingRecord;
            TerritoryBulkDeleteFailures = territoryBulkDeleteFailures;
            TerritoryProcessSessions = territoryProcessSessions;
            TerritoryDuplicateBaseRecord = territoryDuplicateBaseRecord;
            TerritorySyncErrors = territorySyncErrors;
            TerritoryAccounts = territoryAccounts;
            Organizationid = organizationid;
            TerritoryAsyncOperations = territoryAsyncOperations;
            Transactioncurrencyid = transactioncurrencyid;
            TerritorySystemUsers = territorySystemUsers;
            TerritoryPrincipalobjectattributeaccess = territoryPrincipalobjectattributeaccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "_managerid_value")]
        public string _manageridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "entityimage")]
        public byte[] Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territoryid")]
        public string Territoryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territory_Teams")]
        public IList<MicrosoftDynamicsCRMteam> TerritoryTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territory_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> TerritoryMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territory_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> TerritoryConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territory_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> TerritoryConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "managerid")]
        public MicrosoftDynamicsCRMsystemuser Managerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Territory_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> TerritoryDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Territory_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> TerritoryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Territory_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> TerritoryProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Territory_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> TerritoryDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Territory_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> TerritorySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territory_accounts")]
        public IList<MicrosoftDynamicsCRMaccount> TerritoryAccounts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Territory_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> TerritoryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territory_system_users")]
        public IList<MicrosoftDynamicsCRMsystemuser> TerritorySystemUsers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territory_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> TerritoryPrincipalobjectattributeaccess { get; set; }

    }
}
