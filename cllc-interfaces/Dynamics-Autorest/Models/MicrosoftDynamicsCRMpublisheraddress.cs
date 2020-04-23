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
    /// Microsoft.Dynamics.CRM.publisheraddress
    /// </summary>
    public partial class MicrosoftDynamicsCRMpublisheraddress
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMpublisheraddress class.
        /// </summary>
        public MicrosoftDynamicsCRMpublisheraddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMpublisheraddress class.
        /// </summary>
        public MicrosoftDynamicsCRMpublisheraddress(string postofficebox = default(string), string line3 = default(string), string publisheraddressid = default(string), string telephone1 = default(string), int? importsequencenumber = default(int?), decimal? latitude = default(decimal?), string line1 = default(string), decimal? longitude = default(decimal?), string primarycontactname = default(string), string versionnumber = default(string), int? shippingmethodcode = default(int?), int? utcconversiontimezonecode = default(int?), string country = default(string), int? addresstypecode = default(int?), string _createdonbehalfbyValue = default(string), int? utcoffset = default(int?), string telephone3 = default(string), string name = default(string), string county = default(string), string line2 = default(string), string postalcode = default(string), string _parentidValue = default(string), string stateorprovince = default(string), string _modifiedonbehalfbyValue = default(string), int? freighttermscode = default(int?), int? timezoneruleversionnumber = default(int?), string fax = default(string), string _modifiedbyValue = default(string), string city = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string telephone2 = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string upszone = default(string), int? addressnumber = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMpublisher parentid = default(MicrosoftDynamicsCRMpublisher), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Postofficebox = postofficebox;
            Line3 = line3;
            Publisheraddressid = publisheraddressid;
            Telephone1 = telephone1;
            Importsequencenumber = importsequencenumber;
            Latitude = latitude;
            Line1 = line1;
            Longitude = longitude;
            Primarycontactname = primarycontactname;
            Versionnumber = versionnumber;
            Shippingmethodcode = shippingmethodcode;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Country = country;
            Addresstypecode = addresstypecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Utcoffset = utcoffset;
            Telephone3 = telephone3;
            Name = name;
            County = county;
            Line2 = line2;
            Postalcode = postalcode;
            this._parentidValue = _parentidValue;
            Stateorprovince = stateorprovince;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Freighttermscode = freighttermscode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Fax = fax;
            this._modifiedbyValue = _modifiedbyValue;
            City = city;
            Createdon = createdon;
            Telephone2 = telephone2;
            Modifiedon = modifiedon;
            this._createdbyValue = _createdbyValue;
            Upszone = upszone;
            Addressnumber = addressnumber;
            Createdby = createdby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Parentid = parentid;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postofficebox")]
        public string Postofficebox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "line3")]
        public string Line3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publisheraddressid")]
        public string Publisheraddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "telephone1")]
        public string Telephone1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primarycontactname")]
        public string Primarycontactname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippingmethodcode")]
        public int? Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addresstypecode")]
        public int? Addresstypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcoffset")]
        public int? Utcoffset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "telephone3")]
        public string Telephone3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "county")]
        public string County { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postalcode")]
        public string Postalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentid_value")]
        public string _parentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stateorprovince")]
        public string Stateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freighttermscode")]
        public int? Freighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax")]
        public string Fax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "telephone2")]
        public string Telephone2 { get; set; }

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
        [JsonProperty(PropertyName = "upszone")]
        public string Upszone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressnumber")]
        public int? Addressnumber { get; set; }

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
        [JsonProperty(PropertyName = "parentid")]
        public MicrosoftDynamicsCRMpublisher Parentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}
