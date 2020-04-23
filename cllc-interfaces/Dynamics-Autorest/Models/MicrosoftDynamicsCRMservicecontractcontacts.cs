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
    /// Microsoft.Dynamics.CRM.servicecontractcontacts
    /// </summary>
    public partial class MicrosoftDynamicsCRMservicecontractcontacts
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMservicecontractcontacts class.
        /// </summary>
        public MicrosoftDynamicsCRMservicecontractcontacts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMservicecontractcontacts class.
        /// </summary>
        public MicrosoftDynamicsCRMservicecontractcontacts(int? importsequencenumber = default(int?), int? timezoneruleversionnumber = default(int?), string versionnumber = default(string), int? utcconversiontimezonecode = default(int?), string name = default(string), string contactid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string contractid = default(string), int? servicelevel = default(int?), string servicecontractcontactid = default(string), IList<MicrosoftDynamicsCRMteam> servicecontractcontactsTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMasyncoperation> servicecontractcontactsAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> servicecontractcontactsMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> servicecontractcontactsBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> servicecontractcontactsPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Importsequencenumber = importsequencenumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Versionnumber = versionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Name = name;
            Contactid = contactid;
            Overriddencreatedon = overriddencreatedon;
            Contractid = contractid;
            Servicelevel = servicelevel;
            Servicecontractcontactid = servicecontractcontactid;
            ServicecontractcontactsTeams = servicecontractcontactsTeams;
            ServicecontractcontactsAsyncOperations = servicecontractcontactsAsyncOperations;
            ServicecontractcontactsMailboxTrackingFolders = servicecontractcontactsMailboxTrackingFolders;
            ServicecontractcontactsBulkDeleteFailures = servicecontractcontactsBulkDeleteFailures;
            ServicecontractcontactsPrincipalObjectAttributeAccesses = servicecontractcontactsPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactid")]
        public string Contactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractid")]
        public string Contractid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicelevel")]
        public int? Servicelevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicecontractcontactid")]
        public string Servicecontractcontactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicecontractcontacts_Teams")]
        public IList<MicrosoftDynamicsCRMteam> ServicecontractcontactsTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicecontractcontacts_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ServicecontractcontactsAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicecontractcontacts_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ServicecontractcontactsMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicecontractcontacts_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ServicecontractcontactsBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicecontractcontacts_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ServicecontractcontactsPrincipalObjectAttributeAccesses { get; set; }

    }
}
