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

    public partial class MicrosoftDynamicsCRMfieldpermission
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMfieldpermission class.
        /// </summary>
        public MicrosoftDynamicsCRMfieldpermission()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMfieldpermission class.
        /// </summary>
        public MicrosoftDynamicsCRMfieldpermission(IList<MicrosoftDynamicsCRMsyncerror> fieldPermissionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string _fieldsecurityprofileidValue = default(string), string _organizationidValue = default(string), string attributelogicalname = default(string), int? cancreate = default(int?), int? canread = default(int?), int? canupdate = default(int?), int? componentstate = default(int?), string entityname = default(string), string fieldpermissionid = default(string), string fieldpermissionidunique = default(string), MicrosoftDynamicsCRMfieldsecurityprofile fieldsecurityprofileid = default(MicrosoftDynamicsCRMfieldsecurityprofile), bool? ismanaged = default(bool?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string solutionid = default(string), object versionnumber = default(object))
        {
            FieldPermissionSyncErrors = fieldPermissionSyncErrors;
            this._fieldsecurityprofileidValue = _fieldsecurityprofileidValue;
            this._organizationidValue = _organizationidValue;
            Attributelogicalname = attributelogicalname;
            Cancreate = cancreate;
            Canread = canread;
            Canupdate = canupdate;
            Componentstate = componentstate;
            Entityname = entityname;
            Fieldpermissionid = fieldpermissionid;
            Fieldpermissionidunique = fieldpermissionidunique;
            Fieldsecurityprofileid = fieldsecurityprofileid;
            Ismanaged = ismanaged;
            Overwritetime = overwritetime;
            Solutionid = solutionid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FieldPermission_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> FieldPermissionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_fieldsecurityprofileid_value")]
        public string _fieldsecurityprofileidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attributelogicalname")]
        public string Attributelogicalname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cancreate")]
        public int? Cancreate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canread")]
        public int? Canread { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canupdate")]
        public int? Canupdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityname")]
        public string Entityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fieldpermissionid")]
        public string Fieldpermissionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fieldpermissionidunique")]
        public string Fieldpermissionidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fieldsecurityprofileid")]
        public MicrosoftDynamicsCRMfieldsecurityprofile Fieldsecurityprofileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
