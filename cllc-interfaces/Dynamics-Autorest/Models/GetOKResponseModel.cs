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
    /// Collection of accounts
    /// </summary>
    public partial class GetOKResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the GetOKResponseModel class.
        /// </summary>
        public GetOKResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetOKResponseModel class.
        /// </summary>
        public GetOKResponseModel(IList<MicrosoftDynamicsCRMaccount> value = default(IList<MicrosoftDynamicsCRMaccount>))
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
        public IList<MicrosoftDynamicsCRMaccount> Value { get; set; }

    }
}
