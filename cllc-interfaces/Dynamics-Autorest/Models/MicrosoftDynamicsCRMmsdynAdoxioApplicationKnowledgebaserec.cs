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
    /// msdyn_adoxio_application_knowledgebaserec
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgebaserec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgebaserec class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgebaserec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgebaserec class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgebaserec(long? versionnumber = default(long?), string knowledgebaserecordid = default(string), string adoxioApplicationid = default(string), string msdynAdoxioApplicationKnowledgebaserecid = default(string))
        {
            Versionnumber = versionnumber;
            Knowledgebaserecordid = knowledgebaserecordid;
            AdoxioApplicationid = adoxioApplicationid;
            MsdynAdoxioApplicationKnowledgebaserecid = msdynAdoxioApplicationKnowledgebaserecid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgebaserecordid")]
        public string Knowledgebaserecordid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationid")]
        public string AdoxioApplicationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_adoxio_application_knowledgebaserecid")]
        public string MsdynAdoxioApplicationKnowledgebaserecid { get; set; }

    }
}
