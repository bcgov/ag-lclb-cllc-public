// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.officegraphdocument
    /// </summary>
    public partial class MicrosoftDynamicsCRMofficegraphdocument
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMofficegraphdocument class.
        /// </summary>
        public MicrosoftDynamicsCRMofficegraphdocument()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMofficegraphdocument class.
        /// </summary>
        public MicrosoftDynamicsCRMofficegraphdocument(string _modifiedonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), string modifiedby = default(string), string fileextension = default(string), string createdby = default(string), string readurl = default(string), int? viewcount = default(int?), string sitetitle = default(string), string documentid = default(string), string authornames = default(string), string _transactioncurrencyidValue = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? createdtime = default(System.DateTimeOffset?), string documentpreviewmetadata = default(string), System.DateTimeOffset? documentlastmodifiedon = default(System.DateTimeOffset?), string previewimageurl = default(string), int? rank = default(int?), string title = default(string), System.DateTimeOffset? modifiedtime = default(System.DateTimeOffset?), string versionnumber = default(string), string _organizationidValue = default(string), string secondaryfileextension = default(string), int? querytype = default(int?), string weblocationurl = default(string), string filetype = default(string), int? timezoneruleversionnumber = default(int?), string siteurl = default(string), string officegraphdocumentid = default(string), decimal? exchangerate = default(decimal?), string documentlastmodifiedby = default(string), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Modifiedby = modifiedby;
            Fileextension = fileextension;
            Createdby = createdby;
            Readurl = readurl;
            Viewcount = viewcount;
            Sitetitle = sitetitle;
            Documentid = documentid;
            Authornames = authornames;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdtime = createdtime;
            Documentpreviewmetadata = documentpreviewmetadata;
            Documentlastmodifiedon = documentlastmodifiedon;
            Previewimageurl = previewimageurl;
            Rank = rank;
            Title = title;
            Modifiedtime = modifiedtime;
            Versionnumber = versionnumber;
            this._organizationidValue = _organizationidValue;
            Secondaryfileextension = secondaryfileextension;
            Querytype = querytype;
            Weblocationurl = weblocationurl;
            Filetype = filetype;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Siteurl = siteurl;
            Officegraphdocumentid = officegraphdocumentid;
            Exchangerate = exchangerate;
            Documentlastmodifiedby = documentlastmodifiedby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public string Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fileextension")]
        public string Fileextension { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public string Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "readurl")]
        public string Readurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "viewcount")]
        public int? Viewcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sitetitle")]
        public string Sitetitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentid")]
        public string Documentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authornames")]
        public string Authornames { get; set; }

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
        [JsonProperty(PropertyName = "createdtime")]
        public System.DateTimeOffset? Createdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentpreviewmetadata")]
        public string Documentpreviewmetadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentlastmodifiedon")]
        public System.DateTimeOffset? Documentlastmodifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "previewimageurl")]
        public string Previewimageurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedtime")]
        public System.DateTimeOffset? Modifiedtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "secondaryfileextension")]
        public string Secondaryfileextension { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "querytype")]
        public int? Querytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "weblocationurl")]
        public string Weblocationurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filetype")]
        public string Filetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "siteurl")]
        public string Siteurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "officegraphdocumentid")]
        public string Officegraphdocumentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentlastmodifiedby")]
        public string Documentlastmodifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
