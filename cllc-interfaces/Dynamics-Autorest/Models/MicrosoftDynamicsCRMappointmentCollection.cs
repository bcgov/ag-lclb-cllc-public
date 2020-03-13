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
    /// Collection of appointment
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.appointmentCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMappointmentCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMappointmentCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMappointmentCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMappointmentCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMappointmentCollection(IList<MicrosoftDynamicsCRMappointment> value = default(IList<MicrosoftDynamicsCRMappointment>))
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
        public IList<MicrosoftDynamicsCRMappointment> Value { get; set; }

    }
}
