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
    /// adoxio_incident_adoxio_licencetype
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioIncidentAdoxioLicencetype
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioIncidentAdoxioLicencetype class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioIncidentAdoxioLicencetype()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioIncidentAdoxioLicencetype class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioIncidentAdoxioLicencetype(string adoxioIncidentAdoxioLicencetypeid = default(string), string adoxioLicencetypeid = default(string), string incidentid = default(string), long? versionnumber = default(long?))
        {
            AdoxioIncidentAdoxioLicencetypeid = adoxioIncidentAdoxioLicencetypeid;
            AdoxioLicencetypeid = adoxioLicencetypeid;
            Incidentid = incidentid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_incident_adoxio_licencetypeid")]
        public string AdoxioIncidentAdoxioLicencetypeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypeid")]
        public string AdoxioLicencetypeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentid")]
        public string Incidentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

    }
}
