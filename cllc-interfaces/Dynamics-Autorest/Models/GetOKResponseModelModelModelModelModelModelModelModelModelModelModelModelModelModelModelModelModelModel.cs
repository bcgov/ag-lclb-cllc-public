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
    /// Collection of sharepointdocumentlocations
    /// </summary>
    public partial class GetOKResponseModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetOKResponseModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModel
        /// class.
        /// </summary>
        public GetOKResponseModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GetOKResponseModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModel
        /// class.
        /// </summary>
        public GetOKResponseModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModelModel(IList<MicrosoftDynamicsCRMsharepointdocumentlocation> value = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>))
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
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> Value { get; set; }

    }
}
