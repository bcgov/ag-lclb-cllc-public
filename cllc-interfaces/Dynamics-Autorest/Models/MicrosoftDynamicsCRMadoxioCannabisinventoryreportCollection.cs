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
    /// Collection of adoxio_cannabisinventoryreport
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_cannabisinventoryreportCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioCannabisinventoryreportCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioCannabisinventoryreportCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioCannabisinventoryreportCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioCannabisinventoryreportCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioCannabisinventoryreportCollection(IList<MicrosoftDynamicsCRMadoxioCannabisinventoryreport> value = default(IList<MicrosoftDynamicsCRMadoxioCannabisinventoryreport>))
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
        public IList<MicrosoftDynamicsCRMadoxioCannabisinventoryreport> Value { get; set; }

    }
}
