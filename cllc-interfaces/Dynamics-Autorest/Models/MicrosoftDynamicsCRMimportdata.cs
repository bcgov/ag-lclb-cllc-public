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

    public partial class MicrosoftDynamicsCRMimportdata
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMimportdata
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMimportdata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMimportdata
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMimportdata(string _owningteamValue = default(string), object modifiedon = default(object), bool? haserror = default(bool?), int? errortype = default(int?), string _importfileidValue = default(string), int? linenumber = default(int?), int? statuscode = default(int?), int? statecode = default(int?), string _owneridValue = default(string), string importdataid = default(string), object createdon = default(object), string data = default(string), string _owninguserValue = default(string), string recordid = default(string), string _createdonbehalfbyValue = default(string), string _owningbusinessunitValue = default(string), string _modifiedonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _createdbyValue = default(string), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> importDataAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMimportfile importfileid = default(MicrosoftDynamicsCRMimportfile), IList<MicrosoftDynamicsCRMimportlog> importLogImportData = default(IList<MicrosoftDynamicsCRMimportlog>), IList<MicrosoftDynamicsCRMbulkdeletefailure> importDataBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._owningteamValue = _owningteamValue;
            Modifiedon = modifiedon;
            Haserror = haserror;
            Errortype = errortype;
            this._importfileidValue = _importfileidValue;
            Linenumber = linenumber;
            Statuscode = statuscode;
            Statecode = statecode;
            this._owneridValue = _owneridValue;
            Importdataid = importdataid;
            Createdon = createdon;
            Data = data;
            this._owninguserValue = _owninguserValue;
            Recordid = recordid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdbyValue = _createdbyValue;
            Owninguser = owninguser;
            Modifiedby = modifiedby;
            ImportDataAsyncOperations = importDataAsyncOperations;
            Createdonbehalfby = createdonbehalfby;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owningteam = owningteam;
            Importfileid = importfileid;
            ImportLogImportData = importLogImportData;
            ImportDataBulkDeleteFailures = importDataBulkDeleteFailures;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public object Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "haserror")]
        public bool? Haserror { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errortype")]
        public int? Errortype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_importfileid_value")]
        public string _importfileidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "linenumber")]
        public int? Linenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importdataid")]
        public string Importdataid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public object Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recordid")]
        public string Recordid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImportData_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ImportDataAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

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
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importfileid")]
        public MicrosoftDynamicsCRMimportfile Importfileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImportLog_ImportData")]
        public IList<MicrosoftDynamicsCRMimportlog> ImportLogImportData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImportData_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ImportDataBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
