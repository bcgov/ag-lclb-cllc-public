using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    public partial class MicrosoftDynamicsCRMadoxioEvent
    {
        [JsonProperty(PropertyName = "adoxio_Licence@odata.bind")]
        public string LicenceODataBind { get; set; }

        [JsonProperty(PropertyName = "adoxio_Account@odata.bind")]
        public string AccountODataBind { get; set; }
    }
}
