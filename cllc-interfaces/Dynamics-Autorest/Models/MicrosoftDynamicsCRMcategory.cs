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
    /// Microsoft.Dynamics.CRM.category
    /// </summary>
    public partial class MicrosoftDynamicsCRMcategory
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcategory
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcategory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcategory
        /// class.
        /// </summary>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="exchangerate">Shows the conversion rate of the
        /// record's currency. The exchange rate is used to convert all money
        /// fields in the record from the local currency to the system's
        /// default currency.</param>
        /// <param name="_owninguserValue">Unique identifier of the user who
        /// owns this category.</param>
        /// <param name="_owningteamValue">Unique identifier of the team who
        /// owns the category.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="categoryid">Shows the category.</param>
        /// <param name="importsequencenumber">Unique identifier of the data
        /// import or data migration that created this record.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="categorynumber">Shows the category number for customer
        /// reference.</param>
        /// <param name="_owneridValue">Enter the user or team who is assigned
        /// to manage the record. This field is updated every time the record
        /// is assigned to a different user.</param>
        /// <param name="_transactioncurrencyidValue">Choose the local currency
        /// for the record to make sure budgets are reported in the correct
        /// currency.</param>
        /// <param name="description">Type a detailed description of the
        /// category</param>
        /// <param name="_parentcategoryidValue">Select an existing category
        /// article for the category.</param>
        /// <param name="sequencenumber">Enter a number to define the display
        /// position of the category in the hierarchy.</param>
        /// <param name="_owningbusinessunitValue">Shows the business unit that
        /// the record owner belongs to.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="title">Type a title for the Category.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        public MicrosoftDynamicsCRMcategory(string versionnumber = default(string), System.Guid? _createdonbehalfbyValue = default(System.Guid?), decimal? exchangerate = default(decimal?), System.Guid? _owninguserValue = default(System.Guid?), System.Guid? _owningteamValue = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.Guid? categoryid = default(System.Guid?), int? importsequencenumber = default(int?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.Guid? _createdbyValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string categorynumber = default(string), System.Guid? _owneridValue = default(System.Guid?), System.Guid? _transactioncurrencyidValue = default(System.Guid?), string description = default(string), System.Guid? _parentcategoryidValue = default(System.Guid?), int? sequencenumber = default(int?), System.Guid? _owningbusinessunitValue = default(System.Guid?), System.Guid? _modifiedbyValue = default(System.Guid?), string title = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMcategory parentcategoryid = default(MicrosoftDynamicsCRMcategory), IList<MicrosoftDynamicsCRMcategory> categoryParentCategory = default(IList<MicrosoftDynamicsCRMcategory>), IList<MicrosoftDynamicsCRMsyncerror> categorySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser lkCategoryModifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser lkCategoryCreatedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser lkCategoryModifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMknowledgearticle> knowledgearticleCategory = default(IList<MicrosoftDynamicsCRMknowledgearticle>), MicrosoftDynamicsCRMsystemuser lkCategoryCreatedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit))
        {
            Versionnumber = versionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Exchangerate = exchangerate;
            this._owninguserValue = _owninguserValue;
            this._owningteamValue = _owningteamValue;
            Modifiedon = modifiedon;
            Categoryid = categoryid;
            Importsequencenumber = importsequencenumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Createdon = createdon;
            Categorynumber = categorynumber;
            this._owneridValue = _owneridValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Description = description;
            this._parentcategoryidValue = _parentcategoryidValue;
            Sequencenumber = sequencenumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedbyValue = _modifiedbyValue;
            Title = title;
            Overriddencreatedon = overriddencreatedon;
            Parentcategoryid = parentcategoryid;
            CategoryParentCategory = categoryParentCategory;
            CategorySyncErrors = categorySyncErrors;
            LkCategoryModifiedonbehalfby = lkCategoryModifiedonbehalfby;
            Ownerid = ownerid;
            LkCategoryCreatedonbehalfby = lkCategoryCreatedonbehalfby;
            Transactioncurrencyid = transactioncurrencyid;
            LkCategoryModifiedby = lkCategoryModifiedby;
            KnowledgearticleCategory = knowledgearticleCategory;
            LkCategoryCreatedby = lkCategoryCreatedby;
            Owningbusinessunit = owningbusinessunit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the conversion rate of the record's currency.
        /// The exchange rate is used to convert all money fields in the record
        /// from the local currency to the system's default currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who owns this category.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public System.Guid? _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the team who owns the category.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public System.Guid? _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets shows the category.
        /// </summary>
        [JsonProperty(PropertyName = "categoryid")]
        public System.Guid? Categoryid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the data import or data migration
        /// that created this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets shows the category number for customer reference.
        /// </summary>
        [JsonProperty(PropertyName = "categorynumber")]
        public string Categorynumber { get; set; }

        /// <summary>
        /// Gets or sets enter the user or team who is assigned to manage the
        /// record. This field is updated every time the record is assigned to
        /// a different user.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public System.Guid? _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets choose the local currency for the record to make sure
        /// budgets are reported in the correct currency.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public System.Guid? _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets type a detailed description of the category
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets select an existing category article for the category.
        /// </summary>
        [JsonProperty(PropertyName = "_parentcategoryid_value")]
        public System.Guid? _parentcategoryidValue { get; set; }

        /// <summary>
        /// Gets or sets enter a number to define the display position of the
        /// category in the hierarchy.
        /// </summary>
        [JsonProperty(PropertyName = "sequencenumber")]
        public int? Sequencenumber { get; set; }

        /// <summary>
        /// Gets or sets shows the business unit that the record owner belongs
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public System.Guid? _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets type a title for the Category.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentcategoryid")]
        public MicrosoftDynamicsCRMcategory Parentcategoryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category_parent_category")]
        public IList<MicrosoftDynamicsCRMcategory> CategoryParentCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Category_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CategorySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_category_modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser LkCategoryModifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_category_createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser LkCategoryCreatedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_category_modifiedby")]
        public MicrosoftDynamicsCRMsystemuser LkCategoryModifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_category")]
        public IList<MicrosoftDynamicsCRMknowledgearticle> KnowledgearticleCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_category_createdby")]
        public MicrosoftDynamicsCRMsystemuser LkCategoryCreatedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

    }
}
