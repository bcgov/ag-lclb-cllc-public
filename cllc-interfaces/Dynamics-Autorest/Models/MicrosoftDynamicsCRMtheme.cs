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
    /// Microsoft.Dynamics.CRM.theme
    /// </summary>
    public partial class MicrosoftDynamicsCRMtheme
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtheme class.
        /// </summary>
        public MicrosoftDynamicsCRMtheme()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtheme class.
        /// </summary>
        public MicrosoftDynamicsCRMtheme(string headercolor = default(string), string name = default(string), string controlborder = default(string), string globallinkcolor = default(string), string navbarbackgroundcolor = default(string), string _modifiedbyValue = default(string), string backgroundcolor = default(string), string _logoidValue = default(string), string _organizationidValue = default(string), bool? isdefaulttheme = default(bool?), decimal? exchangerate = default(decimal?), int? importsequencenumber = default(int?), string pageheaderbackgroundcolor = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string processcontrolcolor = default(string), string panelheaderbackgroundcolor = default(string), string _transactioncurrencyidValue = default(string), int? statuscode = default(int?), bool? type = default(bool?), string hoverlinkeffect = default(string), int? utcconversiontimezonecode = default(int?), string accentcolor = default(string), string logotooltip = default(string), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), string themeid = default(string), string defaultcustomentitycolor = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string defaultentitycolor = default(string), string selectedlinkeffect = default(string), string navbarshelfcolor = default(string), int? statecode = default(int?), string maincolor = default(string), string versionnumber = default(string), string _createdbyValue = default(string), string controlshade = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMasyncoperation> themeAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMprocesssession> themeProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> themeBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMwebresource logoimage = default(MicrosoftDynamicsCRMwebresource))
        {
            Headercolor = headercolor;
            Name = name;
            Controlborder = controlborder;
            Globallinkcolor = globallinkcolor;
            Navbarbackgroundcolor = navbarbackgroundcolor;
            this._modifiedbyValue = _modifiedbyValue;
            Backgroundcolor = backgroundcolor;
            this._logoidValue = _logoidValue;
            this._organizationidValue = _organizationidValue;
            Isdefaulttheme = isdefaulttheme;
            Exchangerate = exchangerate;
            Importsequencenumber = importsequencenumber;
            Pageheaderbackgroundcolor = pageheaderbackgroundcolor;
            Overriddencreatedon = overriddencreatedon;
            Processcontrolcolor = processcontrolcolor;
            Panelheaderbackgroundcolor = panelheaderbackgroundcolor;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Statuscode = statuscode;
            Type = type;
            Hoverlinkeffect = hoverlinkeffect;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Accentcolor = accentcolor;
            Logotooltip = logotooltip;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Themeid = themeid;
            Defaultcustomentitycolor = defaultcustomentitycolor;
            Createdon = createdon;
            Defaultentitycolor = defaultentitycolor;
            Selectedlinkeffect = selectedlinkeffect;
            Navbarshelfcolor = navbarshelfcolor;
            Statecode = statecode;
            Maincolor = maincolor;
            Versionnumber = versionnumber;
            this._createdbyValue = _createdbyValue;
            Controlshade = controlshade;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Modifiedon = modifiedon;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            ThemeAsyncOperations = themeAsyncOperations;
            ThemeProcessSession = themeProcessSession;
            ThemeBulkDeleteFailures = themeBulkDeleteFailures;
            Transactioncurrencyid = transactioncurrencyid;
            Logoimage = logoimage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "headercolor")]
        public string Headercolor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "controlborder")]
        public string Controlborder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "globallinkcolor")]
        public string Globallinkcolor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "navbarbackgroundcolor")]
        public string Navbarbackgroundcolor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "backgroundcolor")]
        public string Backgroundcolor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_logoid_value")]
        public string _logoidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdefaulttheme")]
        public bool? Isdefaulttheme { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pageheaderbackgroundcolor")]
        public string Pageheaderbackgroundcolor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processcontrolcolor")]
        public string Processcontrolcolor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "panelheaderbackgroundcolor")]
        public string Panelheaderbackgroundcolor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public bool? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hoverlinkeffect")]
        public string Hoverlinkeffect { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accentcolor")]
        public string Accentcolor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logotooltip")]
        public string Logotooltip { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "themeid")]
        public string Themeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultcustomentitycolor")]
        public string Defaultcustomentitycolor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultentitycolor")]
        public string Defaultentitycolor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "selectedlinkeffect")]
        public string Selectedlinkeffect { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "navbarshelfcolor")]
        public string Navbarshelfcolor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maincolor")]
        public string Maincolor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "controlshade")]
        public string Controlshade { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "theme_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ThemeAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "theme_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> ThemeProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "theme_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ThemeBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logoimage")]
        public MicrosoftDynamicsCRMwebresource Logoimage { get; set; }

    }
}
