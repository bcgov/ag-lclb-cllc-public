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
    /// Microsoft.Dynamics.CRM.constraintbasedgroup
    /// </summary>
    public partial class MicrosoftDynamicsCRMconstraintbasedgroup
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMconstraintbasedgroup class.
        /// </summary>
        public MicrosoftDynamicsCRMconstraintbasedgroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMconstraintbasedgroup class.
        /// </summary>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the constraintbasedgroup.</param>
        /// <param name="modifiedon">Date and time when the resource group was
        /// last modified.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the constraintbasedgroup.</param>
        /// <param name="description">Type additional information to describe
        /// the resource group, such as the intended use or associated resource
        /// types.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the resource group.</param>
        /// <param name="grouptypecode">Shows whether the resource group is
        /// static, dynamic or hidden. Hidden groups are for system use only
        /// and are not viewable in Microsoft Dynamics 365.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization associated with the resource group.</param>
        /// <param name="name">Type a title or name that describes the resource
        /// group.</param>
        /// <param name="constraintbasedgroupid">Unique identifier of the
        /// resource group.</param>
        /// <param name="createdon">Date and time when the resource group was
        /// created.</param>
        /// <param name="_businessunitidValue">Shows the business unit that the
        /// record owner belongs to.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the resource group.</param>
        /// <param name="constraints">Shows the constraints defined for the
        /// users, equipment, teams, and other resource groups included as
        /// resources for the group, stored in XML format.</param>
        public MicrosoftDynamicsCRMconstraintbasedgroup(System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), string versionnumber = default(string), string description = default(string), System.Guid? _createdbyValue = default(System.Guid?), int? grouptypecode = default(int?), System.Guid? _organizationidValue = default(System.Guid?), string name = default(string), System.Guid? constraintbasedgroupid = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _businessunitidValue = default(System.Guid?), System.Guid? _modifiedbyValue = default(System.Guid?), string constraints = default(string), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMresourcespec> constraintBasedGroupResourceSpecs = default(IList<MicrosoftDynamicsCRMresourcespec>), MicrosoftDynamicsCRMsystemuser businessunitidSystemuser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMresourcegroup> constraintbasedgroupResourceGroups = default(IList<MicrosoftDynamicsCRMresourcegroup>), IList<MicrosoftDynamicsCRMconnection> constraintbasedgroupConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit businessunitidBusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMconnection> constraintbasedgroupConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMbulkdeletefailure> constraintBasedGroupBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMasyncoperation> constraintBasedGroupAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>))
        {
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Versionnumber = versionnumber;
            Description = description;
            this._createdbyValue = _createdbyValue;
            Grouptypecode = grouptypecode;
            this._organizationidValue = _organizationidValue;
            Name = name;
            Constraintbasedgroupid = constraintbasedgroupid;
            Createdon = createdon;
            this._businessunitidValue = _businessunitidValue;
            this._modifiedbyValue = _modifiedbyValue;
            Constraints = constraints;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdby = createdby;
            ConstraintBasedGroupResourceSpecs = constraintBasedGroupResourceSpecs;
            BusinessunitidSystemuser = businessunitidSystemuser;
            ConstraintbasedgroupResourceGroups = constraintbasedgroupResourceGroups;
            ConstraintbasedgroupConnections2 = constraintbasedgroupConnections2;
            Modifiedby = modifiedby;
            Createdonbehalfby = createdonbehalfby;
            BusinessunitidBusinessunit = businessunitidBusinessunit;
            ConstraintbasedgroupConnections1 = constraintbasedgroupConnections1;
            Organizationid = organizationid;
            ConstraintBasedGroupBulkDeleteFailures = constraintBasedGroupBulkDeleteFailures;
            ConstraintBasedGroupAsyncOperations = constraintBasedGroupAsyncOperations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// constraintbasedgroup.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the resource group was last
        /// modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the constraintbasedgroup.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets type additional information to describe the resource
        /// group, such as the intended use or associated resource types.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the resource
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows whether the resource group is static, dynamic or
        /// hidden. Hidden groups are for system use only and are not viewable
        /// in Microsoft Dynamics 365.
        /// </summary>
        [JsonProperty(PropertyName = "grouptypecode")]
        public int? Grouptypecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization associated with
        /// the resource group.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets type a title or name that describes the resource
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the resource group.
        /// </summary>
        [JsonProperty(PropertyName = "constraintbasedgroupid")]
        public System.Guid? Constraintbasedgroupid { get; set; }

        /// <summary>
        /// Gets or sets date and time when the resource group was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets shows the business unit that the record owner belongs
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public System.Guid? _businessunitidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// resource group.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the constraints defined for the users,
        /// equipment, teams, and other resource groups included as resources
        /// for the group, stored in XML format.
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public string Constraints { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraint_based_group_resource_specs")]
        public IList<MicrosoftDynamicsCRMresourcespec> ConstraintBasedGroupResourceSpecs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser BusinessunitidSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraintbasedgroup_resource_groups")]
        public IList<MicrosoftDynamicsCRMresourcegroup> ConstraintbasedgroupResourceGroups { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraintbasedgroup_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> ConstraintbasedgroupConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid_businessunit")]
        public MicrosoftDynamicsCRMbusinessunit BusinessunitidBusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraintbasedgroup_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> ConstraintbasedgroupConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ConstraintBasedGroup_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ConstraintBasedGroupBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ConstraintBasedGroup_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ConstraintBasedGroupAsyncOperations { get; set; }

    }
}
