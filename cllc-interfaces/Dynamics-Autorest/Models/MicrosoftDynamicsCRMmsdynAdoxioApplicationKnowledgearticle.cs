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
    /// msdyn_adoxio_application_knowledgearticle
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle(string msdynAdoxioApplicationKnowledgearticleid = default(string), string adoxioApplicationid = default(string), string knowledgearticleid = default(string), long? versionnumber = default(long?))
        {
            MsdynAdoxioApplicationKnowledgearticleid = msdynAdoxioApplicationKnowledgearticleid;
            AdoxioApplicationid = adoxioApplicationid;
            Knowledgearticleid = knowledgearticleid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_adoxio_application_knowledgearticleid")]
        public string MsdynAdoxioApplicationKnowledgearticleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationid")]
        public string AdoxioApplicationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleid")]
        public string Knowledgearticleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

    }
}
