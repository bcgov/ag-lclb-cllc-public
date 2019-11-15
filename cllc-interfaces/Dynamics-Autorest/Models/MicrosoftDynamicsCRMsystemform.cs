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
    /// Microsoft.Dynamics.CRM.systemform
    /// </summary>
    public partial class MicrosoftDynamicsCRMsystemform
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsystemform
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsystemform()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsystemform
        /// class.
        /// </summary>
        /// <param name="formid">Unique identifier of the record type
        /// form.</param>
        /// <param name="istabletenabled">Information that specifies whether
        /// the dashboard is enabled for tablet.</param>
        /// <param name="type">Type of the form, for example, Dashboard or
        /// Preview.</param>
        /// <param name="introducedversion">Version in which the form is
        /// introduced.</param>
        /// <param name="objecttypecode">Code that represents the record
        /// type.</param>
        /// <param name="versionnumber">Represents a version of customizations
        /// to be synchronized with the Microsoft Dynamics 365 client for
        /// Outlook.</param>
        /// <param name="description">Description of the form or
        /// dashboard.</param>
        /// <param name="formidunique">Unique identifier of the form used when
        /// synchronizing customizations for the Microsoft Dynamics 365 client
        /// for Outlook.</param>
        /// <param name="version">For internal use only.</param>
        /// <param name="_ancestorformidValue">Unique identifier of the parent
        /// form.</param>
        /// <param name="formxml">XML representation of the form
        /// layout.</param>
        /// <param name="solutionid">Unique identifier of the associated
        /// solution.</param>
        /// <param name="isdefault">Information that specifies whether the form
        /// or the dashboard is the system default.</param>
        /// <param name="isdesktopenabled">Information that specifies whether
        /// the dashboard is enabled for desktop.</param>
        /// <param name="canbedeleted">Information that specifies whether this
        /// component can be deleted.</param>
        /// <param name="isairmerged">Specifies whether this form is merged
        /// with the updated UI layout in Microsoft Dynamics CRM 2015 or
        /// Microsoft Dynamics CRM Online 2015 Update.</param>
        /// <param name="formactivationstate">Specifies the state of the
        /// form.</param>
        /// <param name="overwritetime">For internal use only.</param>
        /// <param name="componentstate">For internal use only.</param>
        /// <param name="iscustomizable">Information that specifies whether
        /// this component can be customized.</param>
        /// <param name="name">Name of the form.</param>
        /// <param name="uniquename">Unique Name</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization.</param>
        /// <param name="formpresentation">Specifies whether this form is in
        /// the updated UI layout in Microsoft Dynamics CRM 2015 or Microsoft
        /// Dynamics CRM Online 2015 Update.</param>
        public MicrosoftDynamicsCRMsystemform(string formid = default(string), bool? istabletenabled = default(bool?), int? type = default(int?), string introducedversion = default(string), string objecttypecode = default(string), string versionnumber = default(string), string description = default(string), string formidunique = default(string), int? version = default(int?), string _ancestorformidValue = default(string), string formxml = default(string), string solutionid = default(string), bool? isdefault = default(bool?), bool? isdesktopenabled = default(bool?), string canbedeleted = default(string), System.DateTimeOffset? publishedon = default(System.DateTimeOffset?), bool? isairmerged = default(bool?), int? formactivationstate = default(int?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), int? componentstate = default(int?), bool? ismanaged = default(bool?), string iscustomizable = default(string), string name = default(string), string uniquename = default(string), string _organizationidValue = default(string), int? formpresentation = default(int?), IList<MicrosoftDynamicsCRMasyncoperation> systemFormAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> systemFormBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemform ancestorformid = default(MicrosoftDynamicsCRMsystemform), IList<MicrosoftDynamicsCRMsystemform> formAncestorForm = default(IList<MicrosoftDynamicsCRMsystemform>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization))
        {
            Formid = formid;
            Istabletenabled = istabletenabled;
            Type = type;
            Introducedversion = introducedversion;
            Objecttypecode = objecttypecode;
            Versionnumber = versionnumber;
            Description = description;
            Formidunique = formidunique;
            Version = version;
            this._ancestorformidValue = _ancestorformidValue;
            Formxml = formxml;
            Solutionid = solutionid;
            Isdefault = isdefault;
            Isdesktopenabled = isdesktopenabled;
            Canbedeleted = canbedeleted;
            Publishedon = publishedon;
            Isairmerged = isairmerged;
            Formactivationstate = formactivationstate;
            Overwritetime = overwritetime;
            Componentstate = componentstate;
            Ismanaged = ismanaged;
            Iscustomizable = iscustomizable;
            Name = name;
            Uniquename = uniquename;
            this._organizationidValue = _organizationidValue;
            Formpresentation = formpresentation;
            SystemFormAsyncOperations = systemFormAsyncOperations;
            SystemFormBulkDeleteFailures = systemFormBulkDeleteFailures;
            Ancestorformid = ancestorformid;
            FormAncestorForm = formAncestorForm;
            Organizationid = organizationid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the record type form.
        /// </summary>
        [JsonProperty(PropertyName = "formid")]
        public string Formid { get; set; }

        /// <summary>
        /// Gets or sets information that specifies whether the dashboard is
        /// enabled for tablet.
        /// </summary>
        [JsonProperty(PropertyName = "istabletenabled")]
        public bool? Istabletenabled { get; set; }

        /// <summary>
        /// Gets or sets type of the form, for example, Dashboard or Preview.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// Gets or sets version in which the form is introduced.
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// Gets or sets code that represents the record type.
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public string Objecttypecode { get; set; }

        /// <summary>
        /// Gets or sets represents a version of customizations to be
        /// synchronized with the Microsoft Dynamics 365 client for Outlook.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets description of the form or dashboard.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the form used when synchronizing
        /// customizations for the Microsoft Dynamics 365 client for Outlook.
        /// </summary>
        [JsonProperty(PropertyName = "formidunique")]
        public string Formidunique { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public int? Version { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the parent form.
        /// </summary>
        [JsonProperty(PropertyName = "_ancestorformid_value")]
        public string _ancestorformidValue { get; set; }

        /// <summary>
        /// Gets or sets XML representation of the form layout.
        /// </summary>
        [JsonProperty(PropertyName = "formxml")]
        public string Formxml { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the associated solution.
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// Gets or sets information that specifies whether the form or the
        /// dashboard is the system default.
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// Gets or sets information that specifies whether the dashboard is
        /// enabled for desktop.
        /// </summary>
        [JsonProperty(PropertyName = "isdesktopenabled")]
        public bool? Isdesktopenabled { get; set; }

        /// <summary>
        /// Gets or sets information that specifies whether this component can
        /// be deleted.
        /// </summary>
        [JsonProperty(PropertyName = "canbedeleted")]
        public string Canbedeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publishedon")]
        public System.DateTimeOffset? Publishedon { get; set; }

        /// <summary>
        /// Gets or sets specifies whether this form is merged with the updated
        /// UI layout in Microsoft Dynamics CRM 2015 or Microsoft Dynamics CRM
        /// Online 2015 Update.
        /// </summary>
        [JsonProperty(PropertyName = "isairmerged")]
        public bool? Isairmerged { get; set; }

        /// <summary>
        /// Gets or sets specifies the state of the form.
        /// </summary>
        [JsonProperty(PropertyName = "formactivationstate")]
        public int? Formactivationstate { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// Gets or sets information that specifies whether this component can
        /// be customized.
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// Gets or sets name of the form.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets unique Name
        /// </summary>
        [JsonProperty(PropertyName = "uniquename")]
        public string Uniquename { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets specifies whether this form is in the updated UI
        /// layout in Microsoft Dynamics CRM 2015 or Microsoft Dynamics CRM
        /// Online 2015 Update.
        /// </summary>
        [JsonProperty(PropertyName = "formpresentation")]
        public int? Formpresentation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SystemForm_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SystemFormAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SystemForm_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SystemFormBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ancestorformid")]
        public MicrosoftDynamicsCRMsystemform Ancestorformid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "form_ancestor_form")]
        public IList<MicrosoftDynamicsCRMsystemform> FormAncestorForm { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

    }
}
