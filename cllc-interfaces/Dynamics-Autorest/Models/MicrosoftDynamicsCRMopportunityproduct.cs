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

    public partial class MicrosoftDynamicsCRMopportunityproduct
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunityproduct class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunityproduct()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunityproduct class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunityproduct(string _modifiedbyValue = default(string), bool? isproductoverridden = default(bool?), object priceperunit = default(object), string _createdonbehalfbyValue = default(string), object taxBase = default(object), object quantity = default(object), string productdescription = default(string), bool? ispriceoverridden = default(bool?), string description = default(string), string _transactioncurrencyidValue = default(string), object baseamountBase = default(object), int? lineitemnumber = default(int?), object manualdiscountamount = default(object), object extendedamount = default(object), object priceperunitBase = default(object), int? producttypecode = default(int?), int? opportunitystatecode = default(int?), object createdon = default(object), string parentbundleid = default(string), int? pricingerrorcode = default(int?), object volumediscountamount = default(object), object baseamount = default(object), object overriddencreatedon = default(object), string opportunityproductid = default(string), string _uomidValue = default(string), string entityimageUrl = default(string), object entityimage = default(object), string owninguser = default(string), string _opportunityidValue = default(string), object manualdiscountamountBase = default(object), object modifiedon = default(object), string versionnumber = default(string), string entityimageid = default(string), string _productidValue = default(string), int? timezoneruleversionnumber = default(int?), int? importsequencenumber = default(int?), string productassociationid = default(string), string owningbusinessunit = default(string), string entityimageTimestamp = default(string), string _modifiedonbehalfbyValue = default(string), int? propertyconfigurationstatus = default(int?), object tax = default(object), object volumediscountamountBase = default(object), object extendedamountBase = default(object), object exchangerate = default(object), int? utcconversiontimezonecode = default(int?), string _owneridValue = default(string), int? sequencenumber = default(int?), string _createdbyValue = default(string), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMopportunity opportunityid = default(MicrosoftDynamicsCRMopportunity), IList<MicrosoftDynamicsCRMasyncoperation> opportunityProductAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMdynamicpropertyinstance> opportunityProductDynamicpropertyinstance = default(IList<MicrosoftDynamicsCRMdynamicpropertyinstance>), IList<MicrosoftDynamicsCRMsyncerror> opportunityProductSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMproductassociation productassociationidProductassociation = default(MicrosoftDynamicsCRMproductassociation), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMuom uomid = default(MicrosoftDynamicsCRMuom), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> opportunityProductBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMopportunityproduct parentbundleidOpportunityproduct = default(MicrosoftDynamicsCRMopportunityproduct), IList<MicrosoftDynamicsCRMopportunityproduct> opportunityproductParentOpportunityproduct = default(IList<MicrosoftDynamicsCRMopportunityproduct>))
        {
            this._modifiedbyValue = _modifiedbyValue;
            Isproductoverridden = isproductoverridden;
            Priceperunit = priceperunit;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            TaxBase = taxBase;
            Quantity = quantity;
            Productdescription = productdescription;
            Ispriceoverridden = ispriceoverridden;
            Description = description;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            BaseamountBase = baseamountBase;
            Lineitemnumber = lineitemnumber;
            Manualdiscountamount = manualdiscountamount;
            Extendedamount = extendedamount;
            PriceperunitBase = priceperunitBase;
            Producttypecode = producttypecode;
            Opportunitystatecode = opportunitystatecode;
            Createdon = createdon;
            Parentbundleid = parentbundleid;
            Pricingerrorcode = pricingerrorcode;
            Volumediscountamount = volumediscountamount;
            Baseamount = baseamount;
            Overriddencreatedon = overriddencreatedon;
            Opportunityproductid = opportunityproductid;
            this._uomidValue = _uomidValue;
            EntityimageUrl = entityimageUrl;
            Entityimage = entityimage;
            Owninguser = owninguser;
            this._opportunityidValue = _opportunityidValue;
            ManualdiscountamountBase = manualdiscountamountBase;
            Modifiedon = modifiedon;
            Versionnumber = versionnumber;
            Entityimageid = entityimageid;
            this._productidValue = _productidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Importsequencenumber = importsequencenumber;
            Productassociationid = productassociationid;
            Owningbusinessunit = owningbusinessunit;
            EntityimageTimestamp = entityimageTimestamp;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Propertyconfigurationstatus = propertyconfigurationstatus;
            Tax = tax;
            VolumediscountamountBase = volumediscountamountBase;
            ExtendedamountBase = extendedamountBase;
            Exchangerate = exchangerate;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._owneridValue = _owneridValue;
            Sequencenumber = sequencenumber;
            this._createdbyValue = _createdbyValue;
            Productid = productid;
            Transactioncurrencyid = transactioncurrencyid;
            Createdby = createdby;
            Opportunityid = opportunityid;
            OpportunityProductAsyncOperations = opportunityProductAsyncOperations;
            Modifiedby = modifiedby;
            OpportunityProductDynamicpropertyinstance = opportunityProductDynamicpropertyinstance;
            OpportunityProductSyncErrors = opportunityProductSyncErrors;
            ProductassociationidProductassociation = productassociationidProductassociation;
            Modifiedonbehalfby = modifiedonbehalfby;
            Uomid = uomid;
            Createdonbehalfby = createdonbehalfby;
            OpportunityProductBulkDeleteFailures = opportunityProductBulkDeleteFailures;
            ParentbundleidOpportunityproduct = parentbundleidOpportunityproduct;
            OpportunityproductParentOpportunityproduct = opportunityproductParentOpportunityproduct;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isproductoverridden")]
        public bool? Isproductoverridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priceperunit")]
        public object Priceperunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax_base")]
        public object TaxBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public object Quantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productdescription")]
        public string Productdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispriceoverridden")]
        public bool? Ispriceoverridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseamount_base")]
        public object BaseamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lineitemnumber")]
        public int? Lineitemnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualdiscountamount")]
        public object Manualdiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedamount")]
        public object Extendedamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priceperunit_base")]
        public object PriceperunitBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "producttypecode")]
        public int? Producttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitystatecode")]
        public int? Opportunitystatecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public object Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleid")]
        public string Parentbundleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricingerrorcode")]
        public int? Pricingerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "volumediscountamount")]
        public object Volumediscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseamount")]
        public object Baseamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public object Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityproductid")]
        public string Opportunityproductid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomid_value")]
        public string _uomidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage")]
        public object Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public string Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_opportunityid_value")]
        public string _opportunityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualdiscountamount_base")]
        public object ManualdiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public object Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_productid_value")]
        public string _productidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid")]
        public string Productassociationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public string Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public string EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "propertyconfigurationstatus")]
        public int? Propertyconfigurationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tax")]
        public object Tax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "volumediscountamount_base")]
        public object VolumediscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedamount_base")]
        public object ExtendedamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sequencenumber")]
        public int? Sequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityid")]
        public MicrosoftDynamicsCRMopportunity Opportunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityProduct_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> OpportunityProductAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityProduct_Dynamicpropertyinstance")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyinstance> OpportunityProductDynamicpropertyinstance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityProduct_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> OpportunityProductSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid_productassociation")]
        public MicrosoftDynamicsCRMproductassociation ProductassociationidProductassociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public MicrosoftDynamicsCRMuom Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityProduct_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> OpportunityProductBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentbundleid_opportunityproduct")]
        public MicrosoftDynamicsCRMopportunityproduct ParentbundleidOpportunityproduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityproduct_parent_opportunityproduct")]
        public IList<MicrosoftDynamicsCRMopportunityproduct> OpportunityproductParentOpportunityproduct { get; set; }

    }
}
