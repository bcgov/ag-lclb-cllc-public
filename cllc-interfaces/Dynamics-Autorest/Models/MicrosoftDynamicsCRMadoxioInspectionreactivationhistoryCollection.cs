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
    /// Collection of adoxio_inspectionreactivationhistory
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_inspectionreactivationhistoryCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioInspectionreactivationhistoryCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioInspectionreactivationhistoryCollection
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioInspectionreactivationhistoryCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioInspectionreactivationhistoryCollection
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioInspectionreactivationhistoryCollection(IList<MicrosoftDynamicsCRMadoxioInspectionreactivationhistory> value = default(IList<MicrosoftDynamicsCRMadoxioInspectionreactivationhistory>))
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
        public IList<MicrosoftDynamicsCRMadoxioInspectionreactivationhistory> Value { get; set; }

    }
}
