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
    /// Collection of adoxio_establishmentincident
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_establishmentincidentCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioEstablishmentincidentCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioEstablishmentincidentCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioEstablishmentincidentCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioEstablishmentincidentCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioEstablishmentincidentCollection(IList<MicrosoftDynamicsCRMadoxioEstablishmentincident> value = default(IList<MicrosoftDynamicsCRMadoxioEstablishmentincident>))
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
        public IList<MicrosoftDynamicsCRMadoxioEstablishmentincident> Value { get; set; }

    }
}
