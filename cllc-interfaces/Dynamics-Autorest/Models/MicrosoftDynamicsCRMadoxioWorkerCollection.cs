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
    /// Collection of adoxio_worker
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_workerCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioWorkerCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioWorkerCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioWorkerCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioWorkerCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioWorkerCollection(IList<MicrosoftDynamicsCRMadoxioWorker> value = default(IList<MicrosoftDynamicsCRMadoxioWorker>))
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
        public IList<MicrosoftDynamicsCRMadoxioWorker> Value { get; set; }

    }
}
