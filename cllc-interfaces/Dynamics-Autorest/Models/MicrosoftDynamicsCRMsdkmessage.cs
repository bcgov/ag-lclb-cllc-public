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
    /// Microsoft.Dynamics.CRM.sdkmessage
    /// </summary>
    public partial class MicrosoftDynamicsCRMsdkmessage
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsdkmessage
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsdkmessage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsdkmessage
        /// class.
        /// </summary>
        /// <param name="autotransact">Information about whether the SDK
        /// message is automatically transacted.</param>
        /// <param name="workflowsdkstepenabled">Whether or not the SDK message
        /// can be called from a workflow.</param>
        /// <param name="versionnumber">Number that identifies a specific
        /// revision of the SDK message. </param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization with which the SDK message is associated.</param>
        /// <param name="isreadonly">Identifies whether an SDK message will be
        /// ReadOnly or Read Write. false - ReadWrite, true - ReadOnly
        /// .</param>
        /// <param name="customizationlevel">Customization level of the SDK
        /// message.</param>
        /// <param name="availability">Identifies where a method will be
        /// exposed. 0 - Server, 1 - Client, 2 - both.</param>
        /// <param name="createdon">Date and time when the SDK message was
        /// created.</param>
        /// <param name="categoryname">If this is a categorized method, this is
        /// the name, otherwise None.</param>
        /// <param name="isactive">Information about whether the SDK message is
        /// active.</param>
        /// <param name="modifiedon">Date and time when the SDK message was
        /// last modified.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the SDK message.</param>
        /// <param name="sdkmessageid">Unique identifier of the SDK message
        /// entity.</param>
        /// <param name="name">Name of the SDK message.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the sdkmessage.</param>
        /// <param name="isprivate">Indicates whether the SDK message is
        /// private.</param>
        /// <param name="isvalidforexecuteasync">For internal use only.</param>
        /// <param name="sdkmessageidunique">Unique identifier of the SDK
        /// message.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the sdkmessage.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the SDK message.</param>
        /// <param name="template">Indicates whether the SDK message is a
        /// template.</param>
        /// <param name="throttlesettings">For internal use only.</param>
        /// <param name="expand">Indicates whether the SDK message should have
        /// its requests expanded per primary entity defined in its
        /// filters.</param>
        public MicrosoftDynamicsCRMsdkmessage(bool? autotransact = default(bool?), bool? workflowsdkstepenabled = default(bool?), string versionnumber = default(string), string _organizationidValue = default(string), bool? isreadonly = default(bool?), int? customizationlevel = default(int?), int? availability = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string categoryname = default(string), bool? isactive = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string sdkmessageid = default(string), string name = default(string), string _modifiedonbehalfbyValue = default(string), bool? isprivate = default(bool?), bool? isvalidforexecuteasync = default(bool?), string sdkmessageidunique = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), bool? template = default(bool?), string throttlesettings = default(string), bool? expand = default(bool?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> sdkmessageidSdkmessageprocessingstep = default(IList<MicrosoftDynamicsCRMsdkmessageprocessingstep>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsdkmessagefilter> sdkmessageidSdkmessagefilter = default(IList<MicrosoftDynamicsCRMsdkmessagefilter>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Autotransact = autotransact;
            Workflowsdkstepenabled = workflowsdkstepenabled;
            Versionnumber = versionnumber;
            this._organizationidValue = _organizationidValue;
            Isreadonly = isreadonly;
            Customizationlevel = customizationlevel;
            Availability = availability;
            Createdon = createdon;
            Categoryname = categoryname;
            Isactive = isactive;
            Modifiedon = modifiedon;
            this._createdbyValue = _createdbyValue;
            Sdkmessageid = sdkmessageid;
            Name = name;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Isprivate = isprivate;
            Isvalidforexecuteasync = isvalidforexecuteasync;
            Sdkmessageidunique = sdkmessageidunique;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Template = template;
            Throttlesettings = throttlesettings;
            Expand = expand;
            Createdby = createdby;
            SdkmessageidSdkmessageprocessingstep = sdkmessageidSdkmessageprocessingstep;
            Createdonbehalfby = createdonbehalfby;
            Organizationid = organizationid;
            SdkmessageidSdkmessagefilter = sdkmessageidSdkmessagefilter;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets information about whether the SDK message is
        /// automatically transacted.
        /// </summary>
        [JsonProperty(PropertyName = "autotransact")]
        public bool? Autotransact { get; set; }

        /// <summary>
        /// Gets or sets whether or not the SDK message can be called from a
        /// workflow.
        /// </summary>
        [JsonProperty(PropertyName = "workflowsdkstepenabled")]
        public bool? Workflowsdkstepenabled { get; set; }

        /// <summary>
        /// Gets or sets number that identifies a specific revision of the SDK
        /// message.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization with which the
        /// SDK message is associated.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets identifies whether an SDK message will be ReadOnly or
        /// Read Write. false - ReadWrite, true - ReadOnly .
        /// </summary>
        [JsonProperty(PropertyName = "isreadonly")]
        public bool? Isreadonly { get; set; }

        /// <summary>
        /// Gets or sets customization level of the SDK message.
        /// </summary>
        [JsonProperty(PropertyName = "customizationlevel")]
        public int? Customizationlevel { get; set; }

        /// <summary>
        /// Gets or sets identifies where a method will be exposed. 0 - Server,
        /// 1 - Client, 2 - both.
        /// </summary>
        [JsonProperty(PropertyName = "availability")]
        public int? Availability { get; set; }

        /// <summary>
        /// Gets or sets date and time when the SDK message was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets if this is a categorized method, this is the name,
        /// otherwise None.
        /// </summary>
        [JsonProperty(PropertyName = "categoryname")]
        public string Categoryname { get; set; }

        /// <summary>
        /// Gets or sets information about whether the SDK message is active.
        /// </summary>
        [JsonProperty(PropertyName = "isactive")]
        public bool? Isactive { get; set; }

        /// <summary>
        /// Gets or sets date and time when the SDK message was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the SDK
        /// message.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the SDK message entity.
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageid")]
        public string Sdkmessageid { get; set; }

        /// <summary>
        /// Gets or sets name of the SDK message.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the sdkmessage.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the SDK message is private.
        /// </summary>
        [JsonProperty(PropertyName = "isprivate")]
        public bool? Isprivate { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "isvalidforexecuteasync")]
        public bool? Isvalidforexecuteasync { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the SDK message.
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageidunique")]
        public string Sdkmessageidunique { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// sdkmessage.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// SDK message.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the SDK message is a template.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public bool? Template { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "throttlesettings")]
        public string Throttlesettings { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the SDK message should have its
        /// requests expanded per primary entity defined in its filters.
        /// </summary>
        [JsonProperty(PropertyName = "expand")]
        public bool? Expand { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageid_sdkmessageprocessingstep")]
        public IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> SdkmessageidSdkmessageprocessingstep { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageid_sdkmessagefilter")]
        public IList<MicrosoftDynamicsCRMsdkmessagefilter> SdkmessageidSdkmessagefilter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
