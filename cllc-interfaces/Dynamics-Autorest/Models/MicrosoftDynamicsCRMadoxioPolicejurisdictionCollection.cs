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
    /// Collection of adoxio_policejurisdiction
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_policejurisdictionCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioPolicejurisdictionCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioPolicejurisdictionCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioPolicejurisdictionCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioPolicejurisdictionCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioPolicejurisdictionCollection(IList<MicrosoftDynamicsCRMadoxioPolicejurisdiction> value = default(IList<MicrosoftDynamicsCRMadoxioPolicejurisdiction>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMadoxioPolicejurisdiction> Value { get; set; }

    }
}
