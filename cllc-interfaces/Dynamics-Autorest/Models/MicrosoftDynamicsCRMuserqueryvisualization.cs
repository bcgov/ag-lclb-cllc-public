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
    /// Microsoft.Dynamics.CRM.userqueryvisualization
    /// </summary>
    public partial class MicrosoftDynamicsCRMuserqueryvisualization
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMuserqueryvisualization class.
        /// </summary>
        public MicrosoftDynamicsCRMuserqueryvisualization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMuserqueryvisualization class.
        /// </summary>
        /// <param name="versionnumber">Version number of the user
        /// chart.</param>
        /// <param name="_webresourceidValue">Shows the web resource that will
        /// be displayed in the chart to the user.</param>
        /// <param name="createdon">Shows the date and time when the record was
        /// created. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.</param>
        /// <param name="_owningteamValue">Unique identifier of the team who
        /// owns the user chart.</param>
        /// <param name="primaryentitytypecode">Type of entity which the user
        /// chart is attached.</param>
        /// <param name="_modifiedbyValue">Shows who last updated the
        /// record.</param>
        /// <param name="datadescription">Shows the fields that are used to
        /// display data in a chart, stored in XML format.</param>
        /// <param name="isdefault">Select whether the chart is the default
        /// chart for the view that it is associated with.</param>
        /// <param name="userqueryvisualizationid">Unique identifier of the
        /// user chart.</param>
        /// <param name="_modifiedonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="_owneridValue">Enter the user or team who is assigned
        /// to manage the record. This field is updated every time the record
        /// is assigned to a different user.</param>
        /// <param name="name">Type a descriptive name for the chart.</param>
        /// <param name="presentationdescription">Contains the chart's
        /// formatting details and presentation properties, stored in XML
        /// format.</param>
        /// <param name="charttype">Indicates the library used to render the
        /// visualization.</param>
        /// <param name="_createdbyValue">Shows who created the record.</param>
        /// <param name="_owninguserValue">Unique identifier of the team who
        /// owns the user chart.</param>
        /// <param name="description">Type additional information to describe
        /// the chart, such as the filter criteria or intended
        /// audience.</param>
        /// <param name="_createdonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="modifiedon">Shows the date and time when the record
        /// was last updated. The date and time are displayed in the time zone
        /// selected in Microsoft Dynamics 365 options.</param>
        /// <param name="_owningbusinessunitValue">Shows the business unit that
        /// the record owner belongs to.</param>
        public MicrosoftDynamicsCRMuserqueryvisualization(string versionnumber = default(string), System.Guid? _webresourceidValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _owningteamValue = default(System.Guid?), string primaryentitytypecode = default(string), System.Guid? _modifiedbyValue = default(System.Guid?), string datadescription = default(string), bool? isdefault = default(bool?), System.Guid? userqueryvisualizationid = default(System.Guid?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.Guid? _owneridValue = default(System.Guid?), string name = default(string), string presentationdescription = default(string), int? charttype = default(int?), System.Guid? _createdbyValue = default(System.Guid?), System.Guid? _owninguserValue = default(System.Guid?), string description = default(string), System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.Guid? _owningbusinessunitValue = default(System.Guid?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> userQueryVisualizationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMwebresource webresourceid = default(MicrosoftDynamicsCRMwebresource), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Versionnumber = versionnumber;
            this._webresourceidValue = _webresourceidValue;
            Createdon = createdon;
            this._owningteamValue = _owningteamValue;
            Primaryentitytypecode = primaryentitytypecode;
            this._modifiedbyValue = _modifiedbyValue;
            Datadescription = datadescription;
            Isdefault = isdefault;
            Userqueryvisualizationid = userqueryvisualizationid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            Name = name;
            Presentationdescription = presentationdescription;
            Charttype = charttype;
            this._createdbyValue = _createdbyValue;
            this._owninguserValue = _owninguserValue;
            Description = description;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Modifiedonbehalfby = modifiedonbehalfby;
            UserQueryVisualizationSyncErrors = userQueryVisualizationSyncErrors;
            Createdonbehalfby = createdonbehalfby;
            Owningteam = owningteam;
            Modifiedby = modifiedby;
            Owningbusinessunit = owningbusinessunit;
            Ownerid = ownerid;
            Webresourceid = webresourceid;
            Owninguser = owninguser;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets version number of the user chart.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets shows the web resource that will be displayed in the
        /// chart to the user.
        /// </summary>
        [JsonProperty(PropertyName = "_webresourceid_value")]
        public System.Guid? _webresourceidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was created.
        /// The date and time are displayed in the time zone selected in
        /// Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the team who owns the user chart.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public System.Guid? _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets type of entity which the user chart is attached.
        /// </summary>
        [JsonProperty(PropertyName = "primaryentitytypecode")]
        public string Primaryentitytypecode { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the fields that are used to display data in a
        /// chart, stored in XML format.
        /// </summary>
        [JsonProperty(PropertyName = "datadescription")]
        public string Datadescription { get; set; }

        /// <summary>
        /// Gets or sets select whether the chart is the default chart for the
        /// view that it is associated with.
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user chart.
        /// </summary>
        [JsonProperty(PropertyName = "userqueryvisualizationid")]
        public System.Guid? Userqueryvisualizationid { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets enter the user or team who is assigned to manage the
        /// record. This field is updated every time the record is assigned to
        /// a different user.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public System.Guid? _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets type a descriptive name for the chart.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets contains the chart's formatting details and
        /// presentation properties, stored in XML format.
        /// </summary>
        [JsonProperty(PropertyName = "presentationdescription")]
        public string Presentationdescription { get; set; }

        /// <summary>
        /// Gets or sets indicates the library used to render the
        /// visualization.
        /// </summary>
        [JsonProperty(PropertyName = "charttype")]
        public int? Charttype { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the team who owns the user chart.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public System.Guid? _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets type additional information to describe the chart,
        /// such as the filter criteria or intended audience.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was last
        /// updated. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets shows the business unit that the record owner belongs
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public System.Guid? _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserQueryVisualization_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> UserQueryVisualizationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webresourceid")]
        public MicrosoftDynamicsCRMwebresource Webresourceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
