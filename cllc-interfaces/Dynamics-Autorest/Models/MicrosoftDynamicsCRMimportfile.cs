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
    /// importfile
    /// </summary>
    public partial class MicrosoftDynamicsCRMimportfile
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMimportfile
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMimportfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMimportfile
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMimportfile(int? totalcount = default(int?), string targetentityname = default(string), string parsedtablename = default(string), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), string additionalheaderrow = default(string), bool? isfirstrowheader = default(bool?), string _modifiedbyValue = default(string), int? statuscode = default(int?), int? statecode = default(int?), string content = default(string), string source = default(string), int? fielddelimitercode = default(int?), string importfileid = default(string), string _modifiedonbehalfbyValue = default(string), int? partialfailurecount = default(int?), string _importmapidValue = default(string), string size = default(string), int? timezoneruleversionnumber = default(int?), string parsedtablecolumnprefix = default(string), string _createdbyValue = default(string), string _owningbusinessunitValue = default(string), bool? usesystemmap = default(bool?), string _owninguserValue = default(string), int? datadelimitercode = default(int?), string sourceentityname = default(string), string _importidValue = default(string), bool? enableduplicatedetection = default(bool?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? filetypecode = default(int?), int? failurecount = default(int?), string relatedentitycolumns = default(string), int? processingstatus = default(int?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string name = default(string), string _owneridValue = default(string), string headerrow = default(string), string _owningteamValue = default(string), int? processcode = default(int?), int? successcount = default(int?), int? parsedtablecolumnsnumber = default(int?), int? progresscounter = default(int?), string _recordsowneridValue = default(string), IList<MicrosoftDynamicsCRMasyncoperation> importFileAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> importFileBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMteam recordsowneridTeam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMimportdata> importFileImportData = default(IList<MicrosoftDynamicsCRMimportdata>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMimport importid = default(MicrosoftDynamicsCRMimport), MicrosoftDynamicsCRMsystemuser recordsowneridSystemuser = default(MicrosoftDynamicsCRMsystemuser), object ownerid = default(object), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMimportlog> importLogImportFile = default(IList<MicrosoftDynamicsCRMimportlog>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMimportmap importmapid = default(MicrosoftDynamicsCRMimportmap))
        {
            Totalcount = totalcount;
            Targetentityname = targetentityname;
            Parsedtablename = parsedtablename;
            Completedon = completedon;
            Additionalheaderrow = additionalheaderrow;
            Isfirstrowheader = isfirstrowheader;
            this._modifiedbyValue = _modifiedbyValue;
            Statuscode = statuscode;
            Statecode = statecode;
            Content = content;
            Source = source;
            Fielddelimitercode = fielddelimitercode;
            Importfileid = importfileid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Partialfailurecount = partialfailurecount;
            this._importmapidValue = _importmapidValue;
            Size = size;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Parsedtablecolumnprefix = parsedtablecolumnprefix;
            this._createdbyValue = _createdbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Usesystemmap = usesystemmap;
            this._owninguserValue = _owninguserValue;
            Datadelimitercode = datadelimitercode;
            Sourceentityname = sourceentityname;
            this._importidValue = _importidValue;
            Enableduplicatedetection = enableduplicatedetection;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdon = createdon;
            Filetypecode = filetypecode;
            Failurecount = failurecount;
            Relatedentitycolumns = relatedentitycolumns;
            Processingstatus = processingstatus;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Modifiedon = modifiedon;
            Name = name;
            this._owneridValue = _owneridValue;
            Headerrow = headerrow;
            this._owningteamValue = _owningteamValue;
            Processcode = processcode;
            Successcount = successcount;
            Parsedtablecolumnsnumber = parsedtablecolumnsnumber;
            Progresscounter = progresscounter;
            this._recordsowneridValue = _recordsowneridValue;
            ImportFileAsyncOperations = importFileAsyncOperations;
            ImportFileBulkDeleteFailures = importFileBulkDeleteFailures;
            RecordsowneridTeam = recordsowneridTeam;
            Owninguser = owninguser;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owningteam = owningteam;
            ImportFileImportData = importFileImportData;
            Createdonbehalfby = createdonbehalfby;
            Owningbusinessunit = owningbusinessunit;
            Importid = importid;
            RecordsowneridSystemuser = recordsowneridSystemuser;
            Ownerid = ownerid;
            Modifiedby = modifiedby;
            ImportLogImportFile = importLogImportFile;
            Createdby = createdby;
            Importmapid = importmapid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalcount")]
        public int? Totalcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetentityname")]
        public string Targetentityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parsedtablename")]
        public string Parsedtablename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additionalheaderrow")]
        public string Additionalheaderrow { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isfirstrowheader")]
        public bool? Isfirstrowheader { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

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
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fielddelimitercode")]
        public int? Fielddelimitercode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importfileid")]
        public string Importfileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partialfailurecount")]
        public int? Partialfailurecount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_importmapid_value")]
        public string _importmapidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parsedtablecolumnprefix")]
        public string Parsedtablecolumnprefix { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "usesystemmap")]
        public bool? Usesystemmap { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datadelimitercode")]
        public int? Datadelimitercode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceentityname")]
        public string Sourceentityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_importid_value")]
        public string _importidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enableduplicatedetection")]
        public bool? Enableduplicatedetection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filetypecode")]
        public int? Filetypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "failurecount")]
        public int? Failurecount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "relatedentitycolumns")]
        public string Relatedentitycolumns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processingstatus")]
        public int? Processingstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "headerrow")]
        public string Headerrow { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processcode")]
        public int? Processcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "successcount")]
        public int? Successcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parsedtablecolumnsnumber")]
        public int? Parsedtablecolumnsnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "progresscounter")]
        public int? Progresscounter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_recordsownerid_value")]
        public string _recordsowneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImportFile_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ImportFileAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImportFile_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ImportFileBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recordsownerid_team")]
        public MicrosoftDynamicsCRMteam RecordsowneridTeam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

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
        [JsonProperty(PropertyName = "ImportFile_ImportData")]
        public IList<MicrosoftDynamicsCRMimportdata> ImportFileImportData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importid")]
        public MicrosoftDynamicsCRMimport Importid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recordsownerid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser RecordsowneridSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public object Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImportLog_ImportFile")]
        public IList<MicrosoftDynamicsCRMimportlog> ImportLogImportFile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importmapid")]
        public MicrosoftDynamicsCRMimportmap Importmapid { get; set; }

    }
}
