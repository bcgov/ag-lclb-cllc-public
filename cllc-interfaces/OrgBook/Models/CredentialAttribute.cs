// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CredentialAttribute
    {
        /// <summary>
        /// Initializes a new instance of the CredentialAttribute class.
        /// </summary>
        public CredentialAttribute()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CredentialAttribute class.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="type">Type</param>
        /// <param name="format">Format</param>
        /// <param name="value">Value</param>
        /// <param name="credentialId">Credential id</param>
        public CredentialAttribute(int? id = default(int?), string type = default(string), string format = default(string), string value = default(string), string credentialId = default(string))
        {
            Id = id;
            Type = type;
            Format = format;
            Value = value;
            CredentialId = credentialId;
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
        /// Gets or sets type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets format
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets credential id
        /// </summary>
        [JsonProperty(PropertyName = "credential_id")]
        public string CredentialId { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type != null)
            {
                if (Type.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Type", 1);
                }
            }
            if (Format != null)
            {
                if (Format.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Format", 1);
                }
            }
            if (Value != null)
            {
                if (Value.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Value", 1);
                }
            }
        }
    }
}
