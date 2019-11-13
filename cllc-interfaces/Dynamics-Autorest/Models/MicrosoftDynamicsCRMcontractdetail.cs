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
    /// Microsoft.Dynamics.CRM.contractdetail
    /// </summary>
    public partial class MicrosoftDynamicsCRMcontractdetail
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcontractdetail class.
        /// </summary>
        public MicrosoftDynamicsCRMcontractdetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcontractdetail class.
        /// </summary>
        /// <param name="expireson">Enter the date when the contract line
        /// expires. The date is automatically filled with the contract date,
        /// but you can change it if required.</param>
        /// <param name="priceBase">Shows the Total Price field converted to
        /// the system's default base currency for reporting purposes. The
        /// calculation uses the exchange rate specified in the Currencies
        /// area.</param>
        /// <param name="rateBase">Shows the Rate field converted to the
        /// system's default base currency for reporting purposes. The
        /// calculation uses the exchange rate specified in the Currencies
        /// area.</param>
        /// <param name="netBase">Shows the Net field converted to the system's
        /// default base currency for reporting purposes. The calculation uses
        /// the exchange rate specified in the Currencies area.</param>
        /// <param name="allotmentsused">Shows the number of cases or minutes
        /// used in the resolved cases on the contract line.</param>
        /// <param name="statecode">Shows whether the contract line is
        /// existing, renewed, canceled, or expired. You can't edit a contract
        /// line after it is saved, regardless of the status.</param>
        /// <param name="owningbusinessunit">Unique identifier of the business
        /// unit that owns the contract line.</param>
        /// <param name="versionnumber">Version number of the contract
        /// template.</param>
        /// <param name="_customeridValue">Select the customer account or
        /// contact to provide a quick link to additional customer details,
        /// such as address, phone number, activities, and orders.</param>
        /// <param name="discountBase">Shows the Discount field converted to
        /// the system's default base currency. The calculation uses the
        /// exchange rate specified in the Currencies area.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_createdbyValue">Shows who created the record.</param>
        /// <param name="servicecontractunitscode">Select the unit type
        /// allotted in the contract line, such as cases or minutes, to
        /// determine the level of support.</param>
        /// <param name="_modifiedonbehalfbyValue">Shows who last updated the
        /// record on behalf of another user.</param>
        /// <param name="importsequencenumber">Unique identifier of the data
        /// import or data migration that created this record.</param>
        /// <param name="effectivitycalendar">Days of the week and times for
        /// which the contract line item is effective.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="_uomidValue">Choose the unit of measurement for the
        /// base unit quantity for this purchase, such as each or
        /// dozen.</param>
        /// <param name="owninguser">Unique identifier of the user who owns the
        /// contract line.</param>
        /// <param name="title">Type a title or name that describes the
        /// contract line.</param>
        /// <param name="_productidValue">Choose the product that is eligible
        /// for services on the contract line.</param>
        /// <param name="modifiedon">Shows the date and time when the record
        /// was last updated. The date and time are displayed in the time zone
        /// selected in Microsoft Dynamics 365 options.</param>
        /// <param name="_uomscheduleidValue">Unique identifier of the unit
        /// group associated with the contract line.</param>
        /// <param name="discountpercentage">Type the discount rate that should
        /// be applied to the Total Price, for use in calculating the net
        /// amount due for the contract line.</param>
        /// <param name="_serviceaddressValue">Choose the address for the
        /// customer account or contact where the services are
        /// provided.</param>
        /// <param name="contractstatecode">Status of the contract.</param>
        /// <param name="initialquantity">Type the number of units of the
        /// specified product or service that are eligible for support on the
        /// contract line.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="rate">Shows the cost per case or minute, calculated by
        /// dividing the Total Price value by the total number of cases or
        /// minutes allocated to the contract line.</param>
        /// <param name="net">Shows the total charge to the customer for the
        /// contract line, calculated as the Total Price minus any
        /// discounts.</param>
        /// <param name="_contractidValue">Unique identifier of the contract
        /// associated with the contract line.</param>
        /// <param name="allotmentsoverage">Shows the number of minutes over
        /// the Total Allotments field that have been spent on resolved cases
        /// related to the contract line.</param>
        /// <param name="contractdetailid">Unique identifier of the contract
        /// line.</param>
        /// <param name="createdon">Shows the date and time when the record was
        /// created. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.</param>
        /// <param name="_transactioncurrencyidValue">Choose the local currency
        /// for the record to make sure budgets are reported in the correct
        /// currency.</param>
        /// <param name="allotmentsremaining">Shows the number of cases or
        /// minutes remaining, based on the resolved cases logged to the
        /// contract line.</param>
        /// <param name="discount">Type the discount amount for the contract
        /// line to deduct any negotiated or other savings from the net amount
        /// due.</param>
        /// <param name="totalallotments">Type the total number of minutes or
        /// cases allowed for the contract line.</param>
        /// <param name="price">Type the total service charge for the contract
        /// line before any discounts are credited.</param>
        /// <param name="_contactidValue">Unique identifier for the contact
        /// associated with the contract line.</param>
        /// <param name="activeon">Enter the date when the contract line
        /// becomes active.</param>
        /// <param name="_accountidValue">Unique identifier of the account with
        /// which the contract is associated.</param>
        /// <param name="productserialnumber">Type the serial number for the
        /// product that is eligible for services on the contract line.</param>
        /// <param name="exchangerate">Shows the conversion rate of the
        /// record's currency. The exchange rate is used to convert all money
        /// fields in the record from the local currency to the system's
        /// default currency.</param>
        /// <param name="_owneridValue">Unique identifier of the user or team
        /// who owns the contract detail.</param>
        /// <param name="statuscode">Select the contract line's status.</param>
        /// <param name="lineitemorder">Type the line item number for the
        /// contract line to easily identify the contract line and make sure
        /// it's listed in the correct order in the parent contract.</param>
        /// <param name="_modifiedbyValue">Shows who last updated the
        /// record.</param>
        /// <param name="_createdonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        public MicrosoftDynamicsCRMcontractdetail(System.DateTimeOffset? expireson = default(System.DateTimeOffset?), decimal? priceBase = default(decimal?), decimal? rateBase = default(decimal?), decimal? netBase = default(decimal?), int? allotmentsused = default(int?), int? statecode = default(int?), string owningbusinessunit = default(string), string versionnumber = default(string), string _customeridValue = default(string), decimal? discountBase = default(decimal?), int? timezoneruleversionnumber = default(int?), string _createdbyValue = default(string), int? servicecontractunitscode = default(int?), string _modifiedonbehalfbyValue = default(string), int? importsequencenumber = default(int?), string effectivitycalendar = default(string), int? utcconversiontimezonecode = default(int?), string _uomidValue = default(string), string owninguser = default(string), string title = default(string), string _productidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _uomscheduleidValue = default(string), decimal? discountpercentage = default(decimal?), string _serviceaddressValue = default(string), int? contractstatecode = default(int?), int? initialquantity = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), decimal? rate = default(decimal?), decimal? net = default(decimal?), string _contractidValue = default(string), int? allotmentsoverage = default(int?), string contractdetailid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _transactioncurrencyidValue = default(string), int? allotmentsremaining = default(int?), decimal? discount = default(decimal?), int? totalallotments = default(int?), decimal? price = default(decimal?), string _contactidValue = default(string), System.DateTimeOffset? activeon = default(System.DateTimeOffset?), string _accountidValue = default(string), string productserialnumber = default(string), decimal? exchangerate = default(decimal?), string _owneridValue = default(string), int? statuscode = default(int?), int? lineitemorder = default(int?), string _modifiedbyValue = default(string), string _createdonbehalfbyValue = default(string), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> contractDetailBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMuomschedule uomscheduleid = default(MicrosoftDynamicsCRMuomschedule), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMincident> contractDetailCases = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMsyncerror> contractDetailSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcustomeraddress serviceaddress = default(MicrosoftDynamicsCRMcustomeraddress), MicrosoftDynamicsCRMcontract contractid = default(MicrosoftDynamicsCRMcontract), IList<MicrosoftDynamicsCRMannotation> contractDetailAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> contractDetailAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMuom uomid = default(MicrosoftDynamicsCRMuom), MicrosoftDynamicsCRMaccount customeridAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcontact customeridContact = default(MicrosoftDynamicsCRMcontact))
        {
            Expireson = expireson;
            PriceBase = priceBase;
            RateBase = rateBase;
            NetBase = netBase;
            Allotmentsused = allotmentsused;
            Statecode = statecode;
            Owningbusinessunit = owningbusinessunit;
            Versionnumber = versionnumber;
            this._customeridValue = _customeridValue;
            DiscountBase = discountBase;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdbyValue = _createdbyValue;
            Servicecontractunitscode = servicecontractunitscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Importsequencenumber = importsequencenumber;
            Effectivitycalendar = effectivitycalendar;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._uomidValue = _uomidValue;
            Owninguser = owninguser;
            Title = title;
            this._productidValue = _productidValue;
            Modifiedon = modifiedon;
            this._uomscheduleidValue = _uomscheduleidValue;
            Discountpercentage = discountpercentage;
            this._serviceaddressValue = _serviceaddressValue;
            Contractstatecode = contractstatecode;
            Initialquantity = initialquantity;
            Overriddencreatedon = overriddencreatedon;
            Rate = rate;
            Net = net;
            this._contractidValue = _contractidValue;
            Allotmentsoverage = allotmentsoverage;
            Contractdetailid = contractdetailid;
            Createdon = createdon;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Allotmentsremaining = allotmentsremaining;
            Discount = discount;
            Totalallotments = totalallotments;
            Price = price;
            this._contactidValue = _contactidValue;
            Activeon = activeon;
            this._accountidValue = _accountidValue;
            Productserialnumber = productserialnumber;
            Exchangerate = exchangerate;
            this._owneridValue = _owneridValue;
            Statuscode = statuscode;
            Lineitemorder = lineitemorder;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedonbehalfby = modifiedonbehalfby;
            ContractDetailBulkDeleteFailures = contractDetailBulkDeleteFailures;
            Uomscheduleid = uomscheduleid;
            Createdonbehalfby = createdonbehalfby;
            ContractDetailCases = contractDetailCases;
            ContractDetailSyncErrors = contractDetailSyncErrors;
            Transactioncurrencyid = transactioncurrencyid;
            Createdby = createdby;
            Serviceaddress = serviceaddress;
            Contractid = contractid;
            ContractDetailAnnotation = contractDetailAnnotation;
            ContractDetailAsyncOperations = contractDetailAsyncOperations;
            Uomid = uomid;
            CustomeridAccount = customeridAccount;
            Productid = productid;
            Modifiedby = modifiedby;
            CustomeridContact = customeridContact;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets enter the date when the contract line expires. The
        /// date is automatically filled with the contract date, but you can
        /// change it if required.
        /// </summary>
        [JsonProperty(PropertyName = "expireson")]
        public System.DateTimeOffset? Expireson { get; set; }

        /// <summary>
        /// Gets or sets shows the Total Price field converted to the system's
        /// default base currency for reporting purposes. The calculation uses
        /// the exchange rate specified in the Currencies area.
        /// </summary>
        [JsonProperty(PropertyName = "price_base")]
        public decimal? PriceBase { get; set; }

        /// <summary>
        /// Gets or sets shows the Rate field converted to the system's default
        /// base currency for reporting purposes. The calculation uses the
        /// exchange rate specified in the Currencies area.
        /// </summary>
        [JsonProperty(PropertyName = "rate_base")]
        public decimal? RateBase { get; set; }

        /// <summary>
        /// Gets or sets shows the Net field converted to the system's default
        /// base currency for reporting purposes. The calculation uses the
        /// exchange rate specified in the Currencies area.
        /// </summary>
        [JsonProperty(PropertyName = "net_base")]
        public decimal? NetBase { get; set; }

        /// <summary>
        /// Gets or sets shows the number of cases or minutes used in the
        /// resolved cases on the contract line.
        /// </summary>
        [JsonProperty(PropertyName = "allotmentsused")]
        public int? Allotmentsused { get; set; }

        /// <summary>
        /// Gets or sets shows whether the contract line is existing, renewed,
        /// canceled, or expired. You can't edit a contract line after it is
        /// saved, regardless of the status.
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the business unit that owns the
        /// contract line.
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public string Owningbusinessunit { get; set; }

        /// <summary>
        /// Gets or sets version number of the contract template.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets select the customer account or contact to provide a
        /// quick link to additional customer details, such as address, phone
        /// number, activities, and orders.
        /// </summary>
        [JsonProperty(PropertyName = "_customerid_value")]
        public string _customeridValue { get; set; }

        /// <summary>
        /// Gets or sets shows the Discount field converted to the system's
        /// default base currency. The calculation uses the exchange rate
        /// specified in the Currencies area.
        /// </summary>
        [JsonProperty(PropertyName = "discount_base")]
        public decimal? DiscountBase { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets select the unit type allotted in the contract line,
        /// such as cases or minutes, to determine the level of support.
        /// </summary>
        [JsonProperty(PropertyName = "servicecontractunitscode")]
        public int? Servicecontractunitscode { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the data import or data migration
        /// that created this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets days of the week and times for which the contract line
        /// item is effective.
        /// </summary>
        [JsonProperty(PropertyName = "effectivitycalendar")]
        public string Effectivitycalendar { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets choose the unit of measurement for the base unit
        /// quantity for this purchase, such as each or dozen.
        /// </summary>
        [JsonProperty(PropertyName = "_uomid_value")]
        public string _uomidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who owns the contract
        /// line.
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public string Owninguser { get; set; }

        /// <summary>
        /// Gets or sets type a title or name that describes the contract line.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets choose the product that is eligible for services on
        /// the contract line.
        /// </summary>
        [JsonProperty(PropertyName = "_productid_value")]
        public string _productidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was last
        /// updated. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the unit group associated with
        /// the contract line.
        /// </summary>
        [JsonProperty(PropertyName = "_uomscheduleid_value")]
        public string _uomscheduleidValue { get; set; }

        /// <summary>
        /// Gets or sets type the discount rate that should be applied to the
        /// Total Price, for use in calculating the net amount due for the
        /// contract line.
        /// </summary>
        [JsonProperty(PropertyName = "discountpercentage")]
        public decimal? Discountpercentage { get; set; }

        /// <summary>
        /// Gets or sets choose the address for the customer account or contact
        /// where the services are provided.
        /// </summary>
        [JsonProperty(PropertyName = "_serviceaddress_value")]
        public string _serviceaddressValue { get; set; }

        /// <summary>
        /// Gets or sets status of the contract.
        /// </summary>
        [JsonProperty(PropertyName = "contractstatecode")]
        public int? Contractstatecode { get; set; }

        /// <summary>
        /// Gets or sets type the number of units of the specified product or
        /// service that are eligible for support on the contract line.
        /// </summary>
        [JsonProperty(PropertyName = "initialquantity")]
        public int? Initialquantity { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets shows the cost per case or minute, calculated by
        /// dividing the Total Price value by the total number of cases or
        /// minutes allocated to the contract line.
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public decimal? Rate { get; set; }

        /// <summary>
        /// Gets or sets shows the total charge to the customer for the
        /// contract line, calculated as the Total Price minus any discounts.
        /// </summary>
        [JsonProperty(PropertyName = "net")]
        public decimal? Net { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the contract associated with the
        /// contract line.
        /// </summary>
        [JsonProperty(PropertyName = "_contractid_value")]
        public string _contractidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the number of minutes over the Total Allotments
        /// field that have been spent on resolved cases related to the
        /// contract line.
        /// </summary>
        [JsonProperty(PropertyName = "allotmentsoverage")]
        public int? Allotmentsoverage { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the contract line.
        /// </summary>
        [JsonProperty(PropertyName = "contractdetailid")]
        public string Contractdetailid { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was created.
        /// The date and time are displayed in the time zone selected in
        /// Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets choose the local currency for the record to make sure
        /// budgets are reported in the correct currency.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the number of cases or minutes remaining, based
        /// on the resolved cases logged to the contract line.
        /// </summary>
        [JsonProperty(PropertyName = "allotmentsremaining")]
        public int? Allotmentsremaining { get; set; }

        /// <summary>
        /// Gets or sets type the discount amount for the contract line to
        /// deduct any negotiated or other savings from the net amount due.
        /// </summary>
        [JsonProperty(PropertyName = "discount")]
        public decimal? Discount { get; set; }

        /// <summary>
        /// Gets or sets type the total number of minutes or cases allowed for
        /// the contract line.
        /// </summary>
        [JsonProperty(PropertyName = "totalallotments")]
        public int? Totalallotments { get; set; }

        /// <summary>
        /// Gets or sets type the total service charge for the contract line
        /// before any discounts are credited.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the contact associated with the
        /// contract line.
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public string _contactidValue { get; set; }

        /// <summary>
        /// Gets or sets enter the date when the contract line becomes active.
        /// </summary>
        [JsonProperty(PropertyName = "activeon")]
        public System.DateTimeOffset? Activeon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the account with which the
        /// contract is associated.
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public string _accountidValue { get; set; }

        /// <summary>
        /// Gets or sets type the serial number for the product that is
        /// eligible for services on the contract line.
        /// </summary>
        [JsonProperty(PropertyName = "productserialnumber")]
        public string Productserialnumber { get; set; }

        /// <summary>
        /// Gets or sets shows the conversion rate of the record's currency.
        /// The exchange rate is used to convert all money fields in the record
        /// from the local currency to the system's default currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user or team who owns the
        /// contract detail.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets select the contract line's status.
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets type the line item number for the contract line to
        /// easily identify the contract line and make sure it's listed in the
        /// correct order in the parent contract.
        /// </summary>
        [JsonProperty(PropertyName = "lineitemorder")]
        public int? Lineitemorder { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContractDetail_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ContractDetailBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomscheduleid")]
        public MicrosoftDynamicsCRMuomschedule Uomscheduleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_detail_cases")]
        public IList<MicrosoftDynamicsCRMincident> ContractDetailCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContractDetail_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ContractDetailSyncErrors { get; set; }

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
        [JsonProperty(PropertyName = "serviceaddress")]
        public MicrosoftDynamicsCRMcustomeraddress Serviceaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractid")]
        public MicrosoftDynamicsCRMcontract Contractid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContractDetail_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> ContractDetailAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContractDetail_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ContractDetailAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public MicrosoftDynamicsCRMuom Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_account")]
        public MicrosoftDynamicsCRMaccount CustomeridAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_contact")]
        public MicrosoftDynamicsCRMcontact CustomeridContact { get; set; }

    }
}
