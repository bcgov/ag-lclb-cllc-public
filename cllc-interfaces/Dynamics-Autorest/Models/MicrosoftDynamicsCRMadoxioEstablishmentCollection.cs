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
    /// Collection of adoxio_establishment
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_establishmentCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioEstablishmentCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioEstablishmentCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioEstablishmentCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioEstablishmentCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioEstablishmentCollection(IList<MicrosoftDynamicsCRMadoxioEstablishment> value = default(IList<MicrosoftDynamicsCRMadoxioEstablishment>))
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
        public IList<MicrosoftDynamicsCRMadoxioEstablishment> Value { get; set; }

    }
}
