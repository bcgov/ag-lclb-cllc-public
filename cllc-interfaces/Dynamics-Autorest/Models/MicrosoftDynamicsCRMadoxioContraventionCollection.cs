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
    /// Collection of adoxio_contravention
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_contraventionCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioContraventionCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioContraventionCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioContraventionCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioContraventionCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioContraventionCollection(IList<MicrosoftDynamicsCRMadoxioContravention> value = default(IList<MicrosoftDynamicsCRMadoxioContravention>))
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
        public IList<MicrosoftDynamicsCRMadoxioContravention> Value { get; set; }

    }
}
