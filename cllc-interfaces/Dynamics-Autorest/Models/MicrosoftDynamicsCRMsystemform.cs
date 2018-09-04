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
    /// systemform
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
        public MicrosoftDynamicsCRMsystemform(string formid = default(string), bool? istabletenabled = default(bool?), int? type = default(int?), string introducedversion = default(string), string objecttypecode = default(string), long? versionnumber = default(long?), string description = default(string), string formidunique = default(string), int? version = default(int?), string _ancestorformidValue = default(string), string formxml = default(string), string solutionid = default(string), bool? isdefault = default(bool?), bool? isdesktopenabled = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty canbedeleted = default(MicrosoftDynamicsCRMBooleanManagedProperty), System.DateTimeOffset? publishedon = default(System.DateTimeOffset?), bool? isairmerged = default(bool?), int? formactivationstate = default(int?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), int? componentstate = default(int?), bool? ismanaged = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty iscustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), string name = default(string), string uniquename = default(string), string _organizationidValue = default(string), int? formpresentation = default(int?), IList<MicrosoftDynamicsCRMasyncoperation> systemFormAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> systemFormBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemform ancestorformid = default(MicrosoftDynamicsCRMsystemform), IList<MicrosoftDynamicsCRMsystemform> formAncestorForm = default(IList<MicrosoftDynamicsCRMsystemform>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization))
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
        /// </summary>
        [JsonProperty(PropertyName = "formid")]
        public string Formid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "istabletenabled")]
        public bool? Istabletenabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public string Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formidunique")]
        public string Formidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public int? Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ancestorformid_value")]
        public string _ancestorformidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formxml")]
        public string Formxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdesktopenabled")]
        public bool? Isdesktopenabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canbedeleted")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Canbedeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publishedon")]
        public System.DateTimeOffset? Publishedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isairmerged")]
        public bool? Isairmerged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formactivationstate")]
        public int? Formactivationstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uniquename")]
        public string Uniquename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
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
