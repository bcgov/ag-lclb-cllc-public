// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.webresource
    /// </summary>
    public partial class MicrosoftDynamicsCRMwebresource
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMwebresource
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMwebresource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMwebresource
        /// class.
        /// </summary>
        /// <param name="modifiedon">Date and time when the web resource was
        /// last modified.</param>
        /// <param name="webresourceid">Unique identifier of the web
        /// resource.</param>
        /// <param name="silverlightversion">Silverlight runtime version number
        /// required by a silverlight web resource.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the web resource.</param>
        /// <param name="webresourcetype">Drop-down list for selecting the type
        /// of the web resource.</param>
        /// <param name="canbedeleted">Information that specifies whether this
        /// component can be deleted.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the web resource.</param>
        /// <param name="dependencyxml">For internal use only.</param>
        /// <param name="overwritetime">For internal use only.</param>
        /// <param name="webresourceidunique">For internal use only.</param>
        /// <param name="isavailableformobileoffline">Information that
        /// specifies whether this web resource is available for mobile client
        /// in offline mode.</param>
        /// <param name="iscustomizable">Information that specifies whether
        /// this component can be customized.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the web resource.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the web resource.</param>
        /// <param name="isenabledformobileclient">Information that specifies
        /// whether this web resource is enabled for mobile client.</param>
        /// <param name="name">Name of the web resource.</param>
        /// <param name="description">Description of the web resource.</param>
        /// <param name="introducedversion">Version in which the form is
        /// introduced.</param>
        /// <param name="ishidden">Information that specifies whether this
        /// component should be hidden.</param>
        /// <param name="componentstate">For internal use only.</param>
        /// <param name="createdon">Date and time when the web resource was
        /// created.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization associated with the web resource.</param>
        /// <param name="solutionid">Unique identifier of the associated
        /// solution.</param>
        /// <param name="content">Bytes of the web resource, in Base64
        /// format.</param>
        /// <param name="contentBinary">Bytes of the web resource, in Base64
        /// format.</param>
        /// <param name="displayname">Display name of the web resource.</param>
        /// <param name="languagecode">Language of the web resource.</param>
        public MicrosoftDynamicsCRMwebresource(System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string webresourceid = default(string), string silverlightversion = default(string), string _modifiedbyValue = default(string), int? webresourcetype = default(int?), string canbedeleted = default(string), string _createdonbehalfbyValue = default(string), string dependencyxml = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string webresourceidunique = default(string), bool? isavailableformobileoffline = default(bool?), string iscustomizable = default(string), string _modifiedonbehalfbyValue = default(string), string _createdbyValue = default(string), bool? isenabledformobileclient = default(bool?), string name = default(string), string description = default(string), string introducedversion = default(string), string versionnumber = default(string), string ishidden = default(string), int? componentstate = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _organizationidValue = default(string), string solutionid = default(string), string content = default(string), byte[] contentBinary = default(byte[]), string displayname = default(string), int? languagecode = default(int?), bool? ismanaged = default(bool?), IList<MicrosoftDynamicsCRMsolution> solutionConfigurationWebresource = default(IList<MicrosoftDynamicsCRMsolution>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMuserqueryvisualization> webresourceUserqueryvisualizations = default(IList<MicrosoftDynamicsCRMuserqueryvisualization>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsavedqueryvisualization> webresourceSavedqueryvisualizations = default(IList<MicrosoftDynamicsCRMsavedqueryvisualization>), IList<MicrosoftDynamicsCRMtheme> lkThemeLogoid = default(IList<MicrosoftDynamicsCRMtheme>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Modifiedon = modifiedon;
            Webresourceid = webresourceid;
            Silverlightversion = silverlightversion;
            this._modifiedbyValue = _modifiedbyValue;
            Webresourcetype = webresourcetype;
            Canbedeleted = canbedeleted;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Dependencyxml = dependencyxml;
            Overwritetime = overwritetime;
            Webresourceidunique = webresourceidunique;
            Isavailableformobileoffline = isavailableformobileoffline;
            Iscustomizable = iscustomizable;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Isenabledformobileclient = isenabledformobileclient;
            Name = name;
            Description = description;
            Introducedversion = introducedversion;
            Versionnumber = versionnumber;
            Ishidden = ishidden;
            Componentstate = componentstate;
            Createdon = createdon;
            this._organizationidValue = _organizationidValue;
            Solutionid = solutionid;
            Content = content;
            ContentBinary = contentBinary;
            Displayname = displayname;
            Languagecode = languagecode;
            Ismanaged = ismanaged;
            SolutionConfigurationWebresource = solutionConfigurationWebresource;
            Organizationid = organizationid;
            Modifiedby = modifiedby;
            WebresourceUserqueryvisualizations = webresourceUserqueryvisualizations;
            Createdonbehalfby = createdonbehalfby;
            WebresourceSavedqueryvisualizations = webresourceSavedqueryvisualizations;
            LkThemeLogoid = lkThemeLogoid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date and time when the web resource was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the web resource.
        /// </summary>
        [JsonProperty(PropertyName = "webresourceid")]
        public string Webresourceid { get; set; }

        /// <summary>
        /// Gets or sets silverlight runtime version number required by a
        /// silverlight web resource.
        /// </summary>
        [JsonProperty(PropertyName = "silverlightversion")]
        public string Silverlightversion { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// web resource.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets drop-down list for selecting the type of the web
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "webresourcetype")]
        public int? Webresourcetype { get; set; }

        /// <summary>
        /// Gets or sets information that specifies whether this component can
        /// be deleted.
        /// </summary>
        [JsonProperty(PropertyName = "canbedeleted")]
        public string Canbedeleted { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// web resource.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "dependencyxml")]
        public string Dependencyxml { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "webresourceidunique")]
        public string Webresourceidunique { get; set; }

        /// <summary>
        /// Gets or sets information that specifies whether this web resource
        /// is available for mobile client in offline mode.
        /// </summary>
        [JsonProperty(PropertyName = "isavailableformobileoffline")]
        public bool? Isavailableformobileoffline { get; set; }

        /// <summary>
        /// Gets or sets information that specifies whether this component can
        /// be customized.
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the web resource.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the web
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets information that specifies whether this web resource
        /// is enabled for mobile client.
        /// </summary>
        [JsonProperty(PropertyName = "isenabledformobileclient")]
        public bool? Isenabledformobileclient { get; set; }

        /// <summary>
        /// Gets or sets name of the web resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description of the web resource.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets version in which the form is introduced.
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets information that specifies whether this component
        /// should be hidden.
        /// </summary>
        [JsonProperty(PropertyName = "ishidden")]
        public string Ishidden { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// Gets or sets date and time when the web resource was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization associated with
        /// the web resource.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the associated solution.
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// Gets or sets bytes of the web resource, in Base64 format.
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets bytes of the web resource, in Base64 format.
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "content_binary")]
        public byte[] ContentBinary { get; set; }

        /// <summary>
        /// Gets or sets display name of the web resource.
        /// </summary>
        [JsonProperty(PropertyName = "displayname")]
        public string Displayname { get; set; }

        /// <summary>
        /// Gets or sets language of the web resource.
        /// </summary>
        [JsonProperty(PropertyName = "languagecode")]
        public int? Languagecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solution_configuration_webresource")]
        public IList<MicrosoftDynamicsCRMsolution> SolutionConfigurationWebresource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webresource_userqueryvisualizations")]
        public IList<MicrosoftDynamicsCRMuserqueryvisualization> WebresourceUserqueryvisualizations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webresource_savedqueryvisualizations")]
        public IList<MicrosoftDynamicsCRMsavedqueryvisualization> WebresourceSavedqueryvisualizations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_theme_logoid")]
        public IList<MicrosoftDynamicsCRMtheme> LkThemeLogoid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
