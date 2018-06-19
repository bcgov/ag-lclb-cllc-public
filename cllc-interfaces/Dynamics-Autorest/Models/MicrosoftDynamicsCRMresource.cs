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

    public partial class MicrosoftDynamicsCRMresource
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMresource
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMresource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMresource
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMresource(IList<MicrosoftDynamicsCRMasyncoperation> resourceAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> resourceBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMsyncerror> resourceSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string _businessunitidValue = default(string), string _organizationidValue = default(string), string _siteidValue = default(string), MicrosoftDynamicsCRMbusinessunit businessunitid = default(MicrosoftDynamicsCRMbusinessunit), string calendarid = default(string), bool? displayinserviceviews = default(bool?), string entityimage = default(string), object entityimageTimestamp = default(object), string entityimageUrl = default(string), string entityimageid = default(string), bool? isdisabled = default(bool?), string name = default(string), string objecttypecode = default(string), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), string resourceid = default(string), MicrosoftDynamicsCRMequipment resourceidEquipment = default(MicrosoftDynamicsCRMequipment), MicrosoftDynamicsCRMresourcespec resourceidResourcespec = default(MicrosoftDynamicsCRMresourcespec), MicrosoftDynamicsCRMsystemuser resourceidSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsite siteid = default(MicrosoftDynamicsCRMsite), object versionnumber = default(object))
        {
            ResourceAsyncOperations = resourceAsyncOperations;
            ResourceBulkDeleteFailures = resourceBulkDeleteFailures;
            ResourceSyncErrors = resourceSyncErrors;
            this._businessunitidValue = _businessunitidValue;
            this._organizationidValue = _organizationidValue;
            this._siteidValue = _siteidValue;
            Businessunitid = businessunitid;
            Calendarid = calendarid;
            Displayinserviceviews = displayinserviceviews;
            Entityimage = entityimage;
            EntityimageTimestamp = entityimageTimestamp;
            EntityimageUrl = entityimageUrl;
            Entityimageid = entityimageid;
            Isdisabled = isdisabled;
            Name = name;
            Objecttypecode = objecttypecode;
            Organizationid = organizationid;
            Resourceid = resourceid;
            ResourceidEquipment = resourceidEquipment;
            ResourceidResourcespec = resourceidResourcespec;
            ResourceidSystemuser = resourceidSystemuser;
            Siteid = siteid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Resource_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ResourceAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Resource_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ResourceBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Resource_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ResourceSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_siteid_value")]
        public string _siteidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid")]
        public MicrosoftDynamicsCRMbusinessunit Businessunitid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendarid")]
        public string Calendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayinserviceviews")]
        public bool? Displayinserviceviews { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage")]
        public string Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public object EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdisabled")]
        public bool? Isdisabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public string Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceid")]
        public string Resourceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceid_equipment")]
        public MicrosoftDynamicsCRMequipment ResourceidEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceid_resourcespec")]
        public MicrosoftDynamicsCRMresourcespec ResourceidResourcespec { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser ResourceidSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "siteid")]
        public MicrosoftDynamicsCRMsite Siteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
