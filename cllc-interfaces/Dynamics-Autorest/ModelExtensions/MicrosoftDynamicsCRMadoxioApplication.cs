namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMadoxioApplication
    {

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Applicant@odata.bind")]
        public string AdoxioApplicantODataBind { get; set; }

        [JsonProperty(PropertyName = "adoxio_LicenceType@odata.bind")]
        public string AdoxioLicenceTypeODataBind { get; set; }

    }
}
