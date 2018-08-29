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

    public partial class MicrosoftDynamicsCRMuserquery
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMuserquery
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMuserquery()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMuserquery
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMuserquery(object modifiedon = default(object), int? statecode = default(int?), string fetchxml = default(string), string _modifiedbyValue = default(string), string advancedgroupby = default(string), string columnsetxml = default(string), string _owningteamValue = default(string), string layoutxml = default(string), string _createdonbehalfbyValue = default(string), string conditionalformatting = default(string), string userqueryid = default(string), int? querytype = default(int?), string returnedtypecode = default(string), object createdon = default(object), string _owningbusinessunitValue = default(string), string _modifiedonbehalfbyValue = default(string), string description = default(string), string versionnumber = default(string), string _owninguserValue = default(string), string _parentqueryidValue = default(string), string name = default(string), string _createdbyValue = default(string), int? statuscode = default(int?), string _owneridValue = default(string), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> userQuerySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMbulkdeletefailure> userQueryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMasyncoperation> userQueryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser))
        {
            Modifiedon = modifiedon;
            Statecode = statecode;
            Fetchxml = fetchxml;
            this._modifiedbyValue = _modifiedbyValue;
            Advancedgroupby = advancedgroupby;
            Columnsetxml = columnsetxml;
            this._owningteamValue = _owningteamValue;
            Layoutxml = layoutxml;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Conditionalformatting = conditionalformatting;
            Userqueryid = userqueryid;
            Querytype = querytype;
            Returnedtypecode = returnedtypecode;
            Createdon = createdon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Description = description;
            Versionnumber = versionnumber;
            this._owninguserValue = _owninguserValue;
            this._parentqueryidValue = _parentqueryidValue;
            Name = name;
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            this._owneridValue = _owneridValue;
            Ownerid = ownerid;
            Modifiedby = modifiedby;
            Owningteam = owningteam;
            Createdonbehalfby = createdonbehalfby;
            UserQuerySyncErrors = userQuerySyncErrors;
            UserQueryBulkDeleteFailures = userQueryBulkDeleteFailures;
            UserQueryAsyncOperations = userQueryAsyncOperations;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdby = createdby;
            Owningbusinessunit = owningbusinessunit;
            Owninguser = owninguser;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public object Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fetchxml")]
        public string Fetchxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "advancedgroupby")]
        public string Advancedgroupby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columnsetxml")]
        public string Columnsetxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "layoutxml")]
        public string Layoutxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "conditionalformatting")]
        public string Conditionalformatting { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userqueryid")]
        public string Userqueryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "querytype")]
        public int? Querytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "returnedtypecode")]
        public string Returnedtypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public object Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentqueryid_value")]
        public string _parentqueryidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserQuery_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> UserQuerySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserQuery_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> UserQueryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserQuery_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> UserQueryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

    }
}
