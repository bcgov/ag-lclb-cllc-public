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
    /// RetrieveAllEntitiesResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveAllEntitiesResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveAllEntitiesResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveAllEntitiesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveAllEntitiesResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveAllEntitiesResponse(IList<MicrosoftDynamicsCRMComplexEntityMetadata> entityMetadata = default(IList<MicrosoftDynamicsCRMComplexEntityMetadata>), string timestamp = default(string))
        {
            EntityMetadata = entityMetadata;
            Timestamp = timestamp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityMetadata")]
        public IList<MicrosoftDynamicsCRMComplexEntityMetadata> EntityMetadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Timestamp")]
        public string Timestamp { get; set; }

    }
}
