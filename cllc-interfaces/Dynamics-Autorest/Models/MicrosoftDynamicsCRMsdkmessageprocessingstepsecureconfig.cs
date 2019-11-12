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
    /// Microsoft.Dynamics.CRM.sdkmessageprocessingstepsecureconfig
    /// </summary>
    public partial class MicrosoftDynamicsCRMsdkmessageprocessingstepsecureconfig
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsdkmessageprocessingstepsecureconfig class.
        /// </summary>
        public MicrosoftDynamicsCRMsdkmessageprocessingstepsecureconfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsdkmessageprocessingstepsecureconfig class.
        /// </summary>
        /// <param name="customizationlevel">Customization level of the SDK
        /// message processing step secure configuration.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the
        /// sdkmessageprocessingstepsecureconfig.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the
        /// sdkmessageprocessingstepsecureconfig.</param>
        /// <param name="sdkmessageprocessingstepsecureconfigidunique">Unique
        /// identifier of the SDK message processing step.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the SDK message processing step.</param>
        /// <param name="secureconfig">Secure step-specific configuration for
        /// the plug-in type that is passed to the plug-in's constructor at run
        /// time.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization with which the SDK message processing step is
        /// associated.</param>
        /// <param name="sdkmessageprocessingstepsecureconfigid">Unique
        /// identifier of the SDK message processing step secure
        /// configuration.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the SDK message processing step.</param>
        /// <param name="modifiedon">Date and time when the SDK message
        /// processing step was last modified.</param>
        /// <param name="createdon">Date and time when the SDK message
        /// processing step was created.</param>
        public MicrosoftDynamicsCRMsdkmessageprocessingstepsecureconfig(int? customizationlevel = default(int?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.Guid? sdkmessageprocessingstepsecureconfigidunique = default(System.Guid?), System.Guid? _modifiedbyValue = default(System.Guid?), string secureconfig = default(string), System.Guid? _organizationidValue = default(System.Guid?), System.Guid? sdkmessageprocessingstepsecureconfigid = default(System.Guid?), System.Guid? _createdbyValue = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> sdkmessageprocessingstepsecureconfigidSdkmessageprocessingstep = default(IList<MicrosoftDynamicsCRMsdkmessageprocessingstep>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Customizationlevel = customizationlevel;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Sdkmessageprocessingstepsecureconfigidunique = sdkmessageprocessingstepsecureconfigidunique;
            this._modifiedbyValue = _modifiedbyValue;
            Secureconfig = secureconfig;
            this._organizationidValue = _organizationidValue;
            Sdkmessageprocessingstepsecureconfigid = sdkmessageprocessingstepsecureconfigid;
            this._createdbyValue = _createdbyValue;
            Modifiedon = modifiedon;
            Createdon = createdon;
            SdkmessageprocessingstepsecureconfigidSdkmessageprocessingstep = sdkmessageprocessingstepsecureconfigidSdkmessageprocessingstep;
            Organizationid = organizationid;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdonbehalfby = createdonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets customization level of the SDK message processing step
        /// secure configuration.
        /// </summary>
        [JsonProperty(PropertyName = "customizationlevel")]
        public int? Customizationlevel { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// sdkmessageprocessingstepsecureconfig.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the sdkmessageprocessingstepsecureconfig.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the SDK message processing step.
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepsecureconfigidunique")]
        public System.Guid? Sdkmessageprocessingstepsecureconfigidunique { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// SDK message processing step.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets secure step-specific configuration for the plug-in
        /// type that is passed to the plug-in's constructor at run time.
        /// </summary>
        [JsonProperty(PropertyName = "secureconfig")]
        public string Secureconfig { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization with which the
        /// SDK message processing step is associated.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the SDK message processing step
        /// secure configuration.
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepsecureconfigid")]
        public System.Guid? Sdkmessageprocessingstepsecureconfigid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the SDK
        /// message processing step.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the SDK message processing step was
        /// last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets date and time when the SDK message processing step was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
        public IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> SdkmessageprocessingstepsecureconfigidSdkmessageprocessingstep { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

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
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

    }
}
