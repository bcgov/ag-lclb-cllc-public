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

    public partial class Contact
    {
        /// <summary>
        /// Initializes a new instance of the Contact class.
        /// </summary>
        public Contact()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Contact class.
        /// </summary>
        /// <param name="selfDisclosure">Possible values include: 'Yes',
        /// 'No'</param>
        /// <param name="gender">Possible values include: 'Male', 'Female',
        /// 'Other'</param>
        public Contact(string spdJobId = default(string), string contactId = default(string), string firstName = default(string), string lastName = default(string), string middleName = default(string), string companyName = default(string), string phoneNumber = default(string), string email = default(string), string driversLicenceNumber = default(string), string bcIdCardNumber = default(string), System.DateTimeOffset? birthDate = default(System.DateTimeOffset?), string birthplace = default(string), string selfDisclosure = default(string), string gender = default(string), Address address = default(Address), IList<Alias> aliases = default(IList<Alias>), IList<Address> previousAddresses = default(IList<Address>))
        {
            SpdJobId = spdJobId;
            ContactId = contactId;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            CompanyName = companyName;
            PhoneNumber = phoneNumber;
            Email = email;
            DriversLicenceNumber = driversLicenceNumber;
            BcIdCardNumber = bcIdCardNumber;
            BirthDate = birthDate;
            Birthplace = birthplace;
            SelfDisclosure = selfDisclosure;
            Gender = gender;
            Address = address;
            Aliases = aliases;
            PreviousAddresses = previousAddresses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spdJobId")]
        public string SpdJobId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactId")]
        public string ContactId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "driversLicenceNumber")]
        public string DriversLicenceNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcIdCardNumber")]
        public string BcIdCardNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "birthDate")]
        public System.DateTimeOffset? BirthDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "birthplace")]
        public string Birthplace { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Yes', 'No'
        /// </summary>
        [JsonProperty(PropertyName = "selfDisclosure")]
        public string SelfDisclosure { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Male', 'Female', 'Other'
        /// </summary>
        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public Address Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "aliases")]
        public IList<Alias> Aliases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "previousAddresses")]
        public IList<Address> PreviousAddresses { get; set; }

    }
}
