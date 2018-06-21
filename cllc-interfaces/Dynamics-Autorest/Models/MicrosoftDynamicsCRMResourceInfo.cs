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
    /// ResourceInfo
    /// </summary>
    public partial class MicrosoftDynamicsCRMResourceInfo
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMResourceInfo
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMResourceInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMResourceInfo
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMResourceInfo(string displayName = default(string), string entityName = default(string), string id = default(string))
        {
            DisplayName = displayName;
            EntityName = entityName;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityName")]
        public string EntityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

    }
}
