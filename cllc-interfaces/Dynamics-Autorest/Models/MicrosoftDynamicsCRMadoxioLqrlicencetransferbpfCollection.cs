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
    /// Collection of adoxio_lqrlicencetransferbpf
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_lqrlicencetransferbpfCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioLqrlicencetransferbpfCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLqrlicencetransferbpfCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLqrlicencetransferbpfCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLqrlicencetransferbpfCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLqrlicencetransferbpfCollection(IList<MicrosoftDynamicsCRMadoxioLqrlicencetransferbpf> value = default(IList<MicrosoftDynamicsCRMadoxioLqrlicencetransferbpf>))
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
        public IList<MicrosoftDynamicsCRMadoxioLqrlicencetransferbpf> Value { get; set; }

    }
}
