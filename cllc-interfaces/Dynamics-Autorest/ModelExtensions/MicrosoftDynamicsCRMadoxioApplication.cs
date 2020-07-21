using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    class MicrosoftDynamicsCRMadoxioApplicationMetadata
    {
        //format date here
        [JsonProperty(PropertyName = "adoxio_establishmentopeningdate")]
        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-dd")]
        public System.DateTimeOffset? AdoxioEstablishmentopeningdate { get; set; }
    }

    [MetadataType(typeof(MicrosoftDynamicsCRMadoxioApplicationMetadata))]
    public partial class MicrosoftDynamicsCRMadoxioApplication
    {

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Applicant@odata.bind")]
        public string AdoxioApplicantODataBind { get; set; }

        [JsonProperty(PropertyName = "statuscode@odata.bind")]
        public string StatusCodeODataBind { get; set; }

        //adoxio_LicenceFeeInvoice
        [JsonProperty(PropertyName = "adoxio_LicenceType@odata.bind")]
        public string AdoxioLicenceTypeODataBind { get; set; }

        [JsonProperty(PropertyName = "adoxio_ApplicationTypeId@odata.bind")]
        public string AdoxioApplicationTypeIdODataBind { get; set; }

        [JsonProperty(PropertyName = "adoxio_LicenceFeeInvoice@odata.bind")]
        public string AdoxioLicenceFeeInvoiceODataBind { get; set; }

        [JsonProperty(PropertyName = "adoxio_Invoice@odata.bind")]
        public string AdoxioInvoiceODataBind { get; set; }

        [JsonProperty(PropertyName = "adoxio_AssignedLicence@odata.bind")]
        public string AdoxioAssignedLicenceODataBind { get; set; }

        [JsonProperty(PropertyName = "adoxio_application_SharePointDocumentLocations@odata.bind")]
        public string[] AdoxioApplicationSharePointDocumentLocationsODataBind { get; set; }

        [JsonProperty(PropertyName = "adoxio_localgovindigenousnationid@odata.bind")]
        public string AdoxioLocalgovindigenousnationidODataBind { get; set; }

        [JsonProperty(PropertyName = "adoxio_LicenceEstablishment@odata.bind")]
        public string AdoxioLicenceEstablishmentODataBind { get; set; }

        [JsonProperty(PropertyName = "adoxio_PoliceJurisdictionId@odata.bind")]
        public string AdoxioPoliceJurisdictionIdODataBind { get; set; }

        [JsonProperty(PropertyName = "adoxio_patiocompdescription")]
        public string AdoxioPatiocompdescription { get; set; }

        [JsonProperty(PropertyName = "adoxio_patiolocationdescription")]
        public string AdoxioPatiolocationdescription { get; set; }

        [JsonProperty(PropertyName = "adoxio_patioaccessdescription")]
        public string AdoxioPatioaccessdescription { get; set; }

        [JsonProperty(PropertyName = "adoxio_patioisliquorcarried")]
        public bool? AdoxioPatioisliquorcarried { get; set; }

        [JsonProperty(PropertyName = "adoxio_patioliquorcarrieddescription")]
        public string AdoxioPatioisliquorcarrieddescription { get; set; }

        [JsonProperty(PropertyName = "adoxio_patioaccesscontroldescription")]
        public string AdoxioPatioaccesscontroldescription { get; set; }

        [JsonProperty(PropertyName = "adoxio_locatedabovedescription")]
        public int? AdoxioLocatedabovedescription { get; set; }

        [JsonProperty(PropertyName = "adoxio_patioservicebar")]
        public int? AdoxioPatioservicebar { get; set; }



    }
}
