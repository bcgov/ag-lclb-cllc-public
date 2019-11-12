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
    /// Microsoft.Dynamics.CRM.serviceendpoint
    /// </summary>
    public partial class MicrosoftDynamicsCRMserviceendpoint
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMserviceendpoint class.
        /// </summary>
        public MicrosoftDynamicsCRMserviceendpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMserviceendpoint class.
        /// </summary>
        /// <param name="connectionmode">Connection mode to contact the service
        /// endpoint.</param>
        /// <param name="ismanaged">Information that specifies whether this
        /// component is managed.</param>
        /// <param name="solutionid">Unique identifier of the associated
        /// solution.</param>
        /// <param name="messageformat">Content type of the message</param>
        /// <param name="introducedversion">Version in which the form is
        /// introduced.</param>
        /// <param name="iscustomizable">Information that specifies whether
        /// this component can be customized.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the service endpoint.</param>
        /// <param name="modifiedon">Date and time when the service endpoint
        /// was last modified.</param>
        /// <param name="sastoken">Shared Access Token</param>
        /// <param name="serviceendpointidunique">Unique identifier of the
        /// service endpoint.</param>
        /// <param name="componentstate">For internal use only.</param>
        /// <param name="path">Path to the service endpoint.</param>
        /// <param name="description">Description of the service
        /// endpoint.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the service endpoint.</param>
        /// <param name="namespaceformat">Format of Service Bus
        /// Namespace</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization with which the service endpoint is associated.</param>
        /// <param name="contract">Type of the endpoint contract.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the service endpoint.</param>
        /// <param name="serviceendpointid">Unique identifier of the service
        /// endpoint.</param>
        /// <param name="authtype">Specifies mode of authentication with
        /// SB</param>
        /// <param name="solutionnamespace">Namespace of the App Fabric
        /// solution.</param>
        /// <param name="overwritetime">For internal use only.</param>
        /// <param name="namespaceaddress">Full service endpoint
        /// address.</param>
        /// <param name="userclaim">Additional user claim value type.</param>
        /// <param name="createdon">Date and time when the service endpoint was
        /// created.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the service endpoint.</param>
        /// <param name="saskeyname">Shared Access Key Name</param>
        /// <param name="name">Name of Service end point.</param>
        /// <param name="saskey">Shared Access Key</param>
        public MicrosoftDynamicsCRMserviceendpoint(int? connectionmode = default(int?), bool? ismanaged = default(bool?), System.Guid? solutionid = default(System.Guid?), int? messageformat = default(int?), string introducedversion = default(string), string iscustomizable = default(string), bool? issastokenset = default(bool?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), bool? issaskeyset = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string sastoken = default(string), System.Guid? serviceendpointidunique = default(System.Guid?), int? componentstate = default(int?), string path = default(string), string description = default(string), System.Guid? _modifiedbyValue = default(System.Guid?), int? namespaceformat = default(int?), System.Guid? _organizationidValue = default(System.Guid?), int? contract = default(int?), System.Guid? _createdbyValue = default(System.Guid?), System.Guid? serviceendpointid = default(System.Guid?), int? authtype = default(int?), string solutionnamespace = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string namespaceaddress = default(string), int? userclaim = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), string saskeyname = default(string), string name = default(string), string saskey = default(string), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> serviceendpointSdkmessageprocessingstep = default(IList<MicrosoftDynamicsCRMsdkmessageprocessingstep>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Connectionmode = connectionmode;
            Ismanaged = ismanaged;
            Solutionid = solutionid;
            Messageformat = messageformat;
            Introducedversion = introducedversion;
            Iscustomizable = iscustomizable;
            Issastokenset = issastokenset;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Issaskeyset = issaskeyset;
            Modifiedon = modifiedon;
            Sastoken = sastoken;
            Serviceendpointidunique = serviceendpointidunique;
            Componentstate = componentstate;
            Path = path;
            Description = description;
            this._modifiedbyValue = _modifiedbyValue;
            Namespaceformat = namespaceformat;
            this._organizationidValue = _organizationidValue;
            Contract = contract;
            this._createdbyValue = _createdbyValue;
            Serviceendpointid = serviceendpointid;
            Authtype = authtype;
            Solutionnamespace = solutionnamespace;
            Overwritetime = overwritetime;
            Namespaceaddress = namespaceaddress;
            Userclaim = userclaim;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Saskeyname = saskeyname;
            Name = name;
            Saskey = saskey;
            Createdonbehalfby = createdonbehalfby;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Organizationid = organizationid;
            ServiceendpointSdkmessageprocessingstep = serviceendpointSdkmessageprocessingstep;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets connection mode to contact the service endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "connectionmode")]
        public int? Connectionmode { get; set; }

        /// <summary>
        /// Gets or sets information that specifies whether this component is
        /// managed.
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the associated solution.
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public System.Guid? Solutionid { get; set; }

        /// <summary>
        /// Gets or sets content type of the message
        /// </summary>
        [JsonProperty(PropertyName = "messageformat")]
        public int? Messageformat { get; set; }

        /// <summary>
        /// Gets or sets version in which the form is introduced.
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// Gets or sets information that specifies whether this component can
        /// be customized.
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issastokenset")]
        public bool? Issastokenset { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the service endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issaskeyset")]
        public bool? Issaskeyset { get; set; }

        /// <summary>
        /// Gets or sets date and time when the service endpoint was last
        /// modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets shared Access Token
        /// </summary>
        [JsonProperty(PropertyName = "sastoken")]
        public string Sastoken { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the service endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "serviceendpointidunique")]
        public System.Guid? Serviceendpointidunique { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// Gets or sets path to the service endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets description of the service endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// service endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets format of Service Bus Namespace
        /// </summary>
        [JsonProperty(PropertyName = "namespaceformat")]
        public int? Namespaceformat { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization with which the
        /// service endpoint is associated.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets type of the endpoint contract.
        /// </summary>
        [JsonProperty(PropertyName = "contract")]
        public int? Contract { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the service
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the service endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "serviceendpointid")]
        public System.Guid? Serviceendpointid { get; set; }

        /// <summary>
        /// Gets or sets specifies mode of authentication with SB
        /// </summary>
        [JsonProperty(PropertyName = "authtype")]
        public int? Authtype { get; set; }

        /// <summary>
        /// Gets or sets namespace of the App Fabric solution.
        /// </summary>
        [JsonProperty(PropertyName = "solutionnamespace")]
        public string Solutionnamespace { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// Gets or sets full service endpoint address.
        /// </summary>
        [JsonProperty(PropertyName = "namespaceaddress")]
        public string Namespaceaddress { get; set; }

        /// <summary>
        /// Gets or sets additional user claim value type.
        /// </summary>
        [JsonProperty(PropertyName = "userclaim")]
        public int? Userclaim { get; set; }

        /// <summary>
        /// Gets or sets date and time when the service endpoint was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// service endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets shared Access Key Name
        /// </summary>
        [JsonProperty(PropertyName = "saskeyname")]
        public string Saskeyname { get; set; }

        /// <summary>
        /// Gets or sets name of Service end point.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets shared Access Key
        /// </summary>
        [JsonProperty(PropertyName = "saskey")]
        public string Saskey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceendpoint_sdkmessageprocessingstep")]
        public IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> ServiceendpointSdkmessageprocessingstep { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
