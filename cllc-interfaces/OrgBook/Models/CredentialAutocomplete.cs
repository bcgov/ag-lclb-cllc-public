// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CredentialAutocomplete
    {
        /// <summary>
        /// Initializes a new instance of the CredentialAutocomplete class.
        /// </summary>
        public CredentialAutocomplete()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CredentialAutocomplete class.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="inactive">Inactive</param>
        public CredentialAutocomplete(IList<CredentialName> names, int? id = default(int?), bool? inactive = default(bool?))
        {
            Id = id;
            Names = names;
            Inactive = inactive;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<CredentialName> Names { get; set; }

        /// <summary>
        /// Gets or sets inactive
        /// </summary>
        [JsonProperty(PropertyName = "inactive")]
        public bool? Inactive { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Names == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Names");
            }
            if (Names != null)
            {
                foreach (var element in Names)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
