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
    /// Collection of adoxio_licencesubcategory
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_licencesubcategoryCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioLicencesubcategoryCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLicencesubcategoryCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLicencesubcategoryCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLicencesubcategoryCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLicencesubcategoryCollection(IList<MicrosoftDynamicsCRMadoxioLicencesubcategory> value = default(IList<MicrosoftDynamicsCRMadoxioLicencesubcategory>))
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
        public IList<MicrosoftDynamicsCRMadoxioLicencesubcategory> Value { get; set; }

    }
}
