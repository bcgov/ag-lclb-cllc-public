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
    /// Collection of adoxio_applicationtermsconditionslimitation
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_applicationtermsconditionslimitationCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitationCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitationCollection
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitationCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitationCollection
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitationCollection(IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> value = default(IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation>))
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
        public IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> Value { get; set; }

    }
}
