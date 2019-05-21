// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Spice.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ApplicationScreeningRequest
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationScreeningRequest
        /// class.
        /// </summary>
        public ApplicationScreeningRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationScreeningRequest
        /// class.
        /// </summary>
        /// <param name="applicantType">Possible values include: 'ESS',
        /// 'Cannabis'</param>
        public ApplicationScreeningRequest(string applicantType = default(string), bool? urgentPriority = default(bool?), string name = default(string), string recordIdentifier = default(string), string applicantName = default(string), string bCeIDNumber = default(string), Account applicantAccount = default(Account), Address businessAddress = default(Address), Establishment establishment = default(Establishment), Contact contactPerson = default(Contact), Contact applyingPerson = default(Contact), System.DateTimeOffset? dateSent = default(System.DateTimeOffset?), IList<LegalEntity> associates = default(IList<LegalEntity>))
        {
            ApplicantType = applicantType;
            UrgentPriority = urgentPriority;
            Name = name;
            RecordIdentifier = recordIdentifier;
            ApplicantName = applicantName;
            BCeIDNumber = bCeIDNumber;
            ApplicantAccount = applicantAccount;
            BusinessAddress = businessAddress;
            Establishment = establishment;
            ContactPerson = contactPerson;
            ApplyingPerson = applyingPerson;
            DateSent = dateSent;
            Associates = associates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'ESS', 'Cannabis'
        /// </summary>
        [JsonProperty(PropertyName = "applicantType")]
        public string ApplicantType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "urgentPriority")]
        public bool? UrgentPriority { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recordIdentifier")]
        public string RecordIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "applicantName")]
        public string ApplicantName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bCeIDNumber")]
        public string BCeIDNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "applicantAccount")]
        public Account ApplicantAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessAddress")]
        public Address BusinessAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "establishment")]
        public Establishment Establishment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactPerson")]
        public Contact ContactPerson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "applyingPerson")]
        public Contact ApplyingPerson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateSent")]
        public System.DateTimeOffset? DateSent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "associates")]
        public IList<LegalEntity> Associates { get; set; }

    }
}
