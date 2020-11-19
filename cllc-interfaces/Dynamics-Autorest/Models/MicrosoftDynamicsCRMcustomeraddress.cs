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
    /// Microsoft.Dynamics.CRM.customeraddress
    /// </summary>
    public partial class MicrosoftDynamicsCRMcustomeraddress
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcustomeraddress class.
        /// </summary>
        public MicrosoftDynamicsCRMcustomeraddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcustomeraddress class.
        /// </summary>
        public MicrosoftDynamicsCRMcustomeraddress(string _modifiedbyValue = default(string), int? addresstypecode = default(int?), string _owneridValue = default(string), string customeraddressid = default(string), string _createdonbehalfbyValue = default(string), string line2 = default(string), int? utcconversiontimezonecode = default(int?), int? addressnumber = default(int?), string postofficebox = default(string), string telephone1 = default(string), int? utcoffset = default(int?), string line3 = default(string), string _owninguserValue = default(string), int? importsequencenumber = default(int?), string line1 = default(string), string versionnumber = default(string), string _parentidValue = default(string), string postalcode = default(string), int? freighttermscode = default(int?), decimal? exchangerate = default(decimal?), string country = default(string), string county = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), string stateorprovince = default(string), string _createdbyValue = default(string), string _transactioncurrencyidValue = default(string), int? shippingmethodcode = default(int?), string primarycontactname = default(string), string city = default(string), string fax = default(string), string _modifiedonbehalfbyValue = default(string), string objecttypecode = default(string), string telephone2 = default(string), string upszone = default(string), string composite = default(string), decimal? longitude = default(decimal?), int? timezoneruleversionnumber = default(int?), string telephone3 = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), decimal? latitude = default(decimal?), string name = default(string), IList<MicrosoftDynamicsCRMbulkdeletefailure> customerAddressBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMcontract> customerAddressContractsAsServiceAddress = default(IList<MicrosoftDynamicsCRMcontract>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMprocesssession> customerAddressProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMaccount parentidAccount = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMcontractdetail> customerAddressContractLineItems = default(IList<MicrosoftDynamicsCRMcontractdetail>), MicrosoftDynamicsCRMcontact parentidContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> customerAddressSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMcontract> customerAddressContractsAsBillingAddress = default(IList<MicrosoftDynamicsCRMcontract>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> customeraddressPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMasyncoperation> customerAddressAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>))
        {
            this._modifiedbyValue = _modifiedbyValue;
            Addresstypecode = addresstypecode;
            this._owneridValue = _owneridValue;
            Customeraddressid = customeraddressid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Line2 = line2;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Addressnumber = addressnumber;
            Postofficebox = postofficebox;
            Telephone1 = telephone1;
            Utcoffset = utcoffset;
            Line3 = line3;
            this._owninguserValue = _owninguserValue;
            Importsequencenumber = importsequencenumber;
            Line1 = line1;
            Versionnumber = versionnumber;
            this._parentidValue = _parentidValue;
            Postalcode = postalcode;
            Freighttermscode = freighttermscode;
            Exchangerate = exchangerate;
            Country = country;
            County = county;
            Createdon = createdon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Stateorprovince = stateorprovince;
            this._createdbyValue = _createdbyValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Shippingmethodcode = shippingmethodcode;
            Primarycontactname = primarycontactname;
            City = city;
            Fax = fax;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Objecttypecode = objecttypecode;
            Telephone2 = telephone2;
            Upszone = upszone;
            Composite = composite;
            Longitude = longitude;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Telephone3 = telephone3;
            Modifiedon = modifiedon;
            Overriddencreatedon = overriddencreatedon;
            Latitude = latitude;
            Name = name;
            CustomerAddressBulkDeleteFailures = customerAddressBulkDeleteFailures;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomerAddressContractsAsServiceAddress = customerAddressContractsAsServiceAddress;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Transactioncurrencyid = transactioncurrencyid;
            CustomerAddressProcessSessions = customerAddressProcessSessions;
            ParentidAccount = parentidAccount;
            CustomerAddressContractLineItems = customerAddressContractLineItems;
            ParentidContact = parentidContact;
            Modifiedby = modifiedby;
            CustomerAddressSyncErrors = customerAddressSyncErrors;
            CustomerAddressContractsAsBillingAddress = customerAddressContractsAsBillingAddress;
            CustomeraddressPrincipalobjectattributeaccess = customeraddressPrincipalobjectattributeaccess;
            CustomerAddressAsyncOperations = customerAddressAsyncOperations;
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
        [JsonProperty(PropertyName = "addresstypecode")]
        public int? Addresstypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customeraddressid")]
        public string Customeraddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressnumber")]
        public int? Addressnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postofficebox")]
        public string Postofficebox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "telephone1")]
        public string Telephone1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcoffset")]
        public int? Utcoffset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "line3")]
        public string Line3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentid_value")]
        public string _parentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postalcode")]
        public string Postalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freighttermscode")]
        public int? Freighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "county")]
        public string County { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stateorprovince")]
        public string Stateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippingmethodcode")]
        public int? Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primarycontactname")]
        public string Primarycontactname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fax")]
        public string Fax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public string Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "telephone2")]
        public string Telephone2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "upszone")]
        public string Upszone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "composite")]
        public string Composite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "telephone3")]
        public string Telephone3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomerAddress_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CustomerAddressBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customer_address_contracts_as_service_address")]
        public IList<MicrosoftDynamicsCRMcontract> CustomerAddressContractsAsServiceAddress { get; set; }

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
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomerAddress_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> CustomerAddressProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentid_account")]
        public MicrosoftDynamicsCRMaccount ParentidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customer_address_contract_line_items")]
        public IList<MicrosoftDynamicsCRMcontractdetail> CustomerAddressContractLineItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentid_contact")]
        public MicrosoftDynamicsCRMcontact ParentidContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomerAddress_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CustomerAddressSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customer_address_contracts_as_billing_address")]
        public IList<MicrosoftDynamicsCRMcontract> CustomerAddressContractsAsBillingAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customeraddress_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CustomeraddressPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomerAddress_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CustomerAddressAsyncOperations { get; set; }

    }
}
