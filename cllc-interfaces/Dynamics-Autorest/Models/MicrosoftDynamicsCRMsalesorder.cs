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
    /// salesorder
    /// </summary>
    public partial class MicrosoftDynamicsCRMsalesorder
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsalesorder
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsalesorder()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsalesorder
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsalesorder(int? importsequencenumber = default(int?), System.DateTimeOffset? lastbackofficesubmit = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), object exchangerate = default(object), object discountpercentage = default(object), object totalamountlessfreightBase = default(object), int? statecode = default(int?), string billtoCountry = default(string), string entityimageid = default(string), string billtoFax = default(string), string shiptoLine3 = default(string), object discountamount = default(object), bool? willcall = default(bool?), int? pricingerrorcode = default(int?), string shiptoTelephone = default(string), string _slainvokedidValue = default(string), object totallineitemdiscountamountBase = default(object), int? utcconversiontimezonecode = default(int?), string billtoLine1 = default(string), string _pricelevelidValue = default(string), string billtoTelephone = default(string), string billtoComposite = default(string), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? lastonholdtime = default(System.DateTimeOffset?), object totaltaxBase = default(object), int? shiptoFreighttermscode = default(int?), object freightamountBase = default(object), long? versionnumber = default(long?), object totaldiscountamount = default(object), string name = default(string), int? statuscode = default(int?), string _campaignidValue = default(string), string _accountidValue = default(string), string billtoLine3 = default(string), object totalamountBase = default(object), string billtoLine2 = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string stageid = default(string), string shiptoCountry = default(string), object discountamountBase = default(object), string shiptoComposite = default(string), string shiptoPostalcode = default(string), string billtoPostalcode = default(string), System.DateTimeOffset? submitdate = default(System.DateTimeOffset?), object totaltax = default(object), string _opportunityidValue = default(string), string _quoteidValue = default(string), string entityimageUrl = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string billtoCity = default(string), string traversedpath = default(string), object entityimage = default(object), string _createdbyValue = default(string), object totallineitemamountBase = default(object), object totallineitemamount = default(object), long? entityimageTimestamp = default(long?), int? prioritycode = default(int?), string _createdonbehalfbyValue = default(string), object totallineitemdiscountamount = default(object), string ordernumber = default(string), object totalamount = default(object), System.DateTimeOffset? datefulfilled = default(System.DateTimeOffset?), string _slaidValue = default(string), System.DateTimeOffset? requestdeliveryby = default(System.DateTimeOffset?), string processid = default(string), string billtoName = default(string), int? paymenttermscode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string salesorderid = default(string), int? timezoneruleversionnumber = default(int?), string shiptoName = default(string), string shiptoLine2 = default(string), string _owninguserValue = default(string), int? onholdtime = default(int?), string shiptoStateorprovince = default(string), string _owningbusinessunitValue = default(string), object totaldiscountamountBase = default(object), int? shippingmethodcode = default(int?), string shiptoContactname = default(string), string _owneridValue = default(string), string submitstatusdescription = default(string), string shiptoCity = default(string), string billtoStateorprovince = default(string), string _owningteamValue = default(string), string shiptoLine1 = default(string), object totalamountlessfreight = default(object), object freightamount = default(object), string description = default(string), int? submitstatus = default(int?), string _customeridValue = default(string), string shiptoAddressid = default(string), string billtoContactname = default(string), string _contactidValue = default(string), string billtoAddressid = default(string), bool? ispricelocked = default(bool?), string shiptoFax = default(string), int? freighttermscode = default(int?), IList<MicrosoftDynamicsCRMcontact> contactordersAssociation = default(IList<MicrosoftDynamicsCRMcontact>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), IList<MicrosoftDynamicsCRMopportunitysalesprocess> salesorderOpportunitysalesprocess = default(IList<MicrosoftDynamicsCRMopportunitysalesprocess>), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), IList<MicrosoftDynamicsCRMemail> salesOrderEmails = default(IList<MicrosoftDynamicsCRMemail>), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> salesOrderBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsla slaSalesorderSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMactivitypointer> salesOrderActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), MicrosoftDynamicsCRMcampaign campaignid = default(MicrosoftDynamicsCRMcampaign), IList<MicrosoftDynamicsCRMsocialactivity> salesOrderSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMasyncoperation> salesOrderAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMserviceappointment> salesOrderServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), MicrosoftDynamicsCRMquote quoteid = default(MicrosoftDynamicsCRMquote), IList<MicrosoftDynamicsCRMconnection> salesorderConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceSalesorder = default(IList<MicrosoftDynamicsCRMslakpiinstance>), IList<MicrosoftDynamicsCRMactivityparty> salesorderActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMannotation> salesOrderAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMsalesorderdetail> orderDetails = default(IList<MicrosoftDynamicsCRMsalesorderdetail>), IList<MicrosoftDynamicsCRMletter> salesOrderLetters = default(IList<MicrosoftDynamicsCRMletter>), MicrosoftDynamicsCRMpricelevel pricelevelid = default(MicrosoftDynamicsCRMpricelevel), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcontact customeridContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMphonecall> salesOrderPhonecalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMsyncerror> salesOrderSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMorderclose> salesOrderOrderClose = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> salesOrderRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMtask> salesOrderTasks = default(IList<MicrosoftDynamicsCRMtask>), MicrosoftDynamicsCRMopportunity opportunityid = default(MicrosoftDynamicsCRMopportunity), IList<MicrosoftDynamicsCRMappointment> salesOrderAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMfax> salesOrderFaxes = default(IList<MicrosoftDynamicsCRMfax>), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMconnection> salesorderConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMaccount customeridAccount = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMinvoice> orderInvoices = default(IList<MicrosoftDynamicsCRMinvoice>), MicrosoftDynamicsCRMsla slainvokedidSalesorderSla = default(MicrosoftDynamicsCRMsla))
        {
            Importsequencenumber = importsequencenumber;
            Lastbackofficesubmit = lastbackofficesubmit;
            this._modifiedbyValue = _modifiedbyValue;
            Exchangerate = exchangerate;
            Discountpercentage = discountpercentage;
            TotalamountlessfreightBase = totalamountlessfreightBase;
            Statecode = statecode;
            BilltoCountry = billtoCountry;
            Entityimageid = entityimageid;
            BilltoFax = billtoFax;
            ShiptoLine3 = shiptoLine3;
            Discountamount = discountamount;
            Willcall = willcall;
            Pricingerrorcode = pricingerrorcode;
            ShiptoTelephone = shiptoTelephone;
            this._slainvokedidValue = _slainvokedidValue;
            TotallineitemdiscountamountBase = totallineitemdiscountamountBase;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            BilltoLine1 = billtoLine1;
            this._pricelevelidValue = _pricelevelidValue;
            BilltoTelephone = billtoTelephone;
            BilltoComposite = billtoComposite;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Lastonholdtime = lastonholdtime;
            TotaltaxBase = totaltaxBase;
            ShiptoFreighttermscode = shiptoFreighttermscode;
            FreightamountBase = freightamountBase;
            Versionnumber = versionnumber;
            Totaldiscountamount = totaldiscountamount;
            Name = name;
            Statuscode = statuscode;
            this._campaignidValue = _campaignidValue;
            this._accountidValue = _accountidValue;
            BilltoLine3 = billtoLine3;
            TotalamountBase = totalamountBase;
            BilltoLine2 = billtoLine2;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Modifiedon = modifiedon;
            Stageid = stageid;
            ShiptoCountry = shiptoCountry;
            DiscountamountBase = discountamountBase;
            ShiptoComposite = shiptoComposite;
            ShiptoPostalcode = shiptoPostalcode;
            BilltoPostalcode = billtoPostalcode;
            Submitdate = submitdate;
            Totaltax = totaltax;
            this._opportunityidValue = _opportunityidValue;
            this._quoteidValue = _quoteidValue;
            EntityimageUrl = entityimageUrl;
            Overriddencreatedon = overriddencreatedon;
            BilltoCity = billtoCity;
            Traversedpath = traversedpath;
            Entityimage = entityimage;
            this._createdbyValue = _createdbyValue;
            TotallineitemamountBase = totallineitemamountBase;
            Totallineitemamount = totallineitemamount;
            EntityimageTimestamp = entityimageTimestamp;
            Prioritycode = prioritycode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Totallineitemdiscountamount = totallineitemdiscountamount;
            Ordernumber = ordernumber;
            Totalamount = totalamount;
            Datefulfilled = datefulfilled;
            this._slaidValue = _slaidValue;
            Requestdeliveryby = requestdeliveryby;
            Processid = processid;
            BilltoName = billtoName;
            Paymenttermscode = paymenttermscode;
            Createdon = createdon;
            Salesorderid = salesorderid;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            ShiptoName = shiptoName;
            ShiptoLine2 = shiptoLine2;
            this._owninguserValue = _owninguserValue;
            Onholdtime = onholdtime;
            ShiptoStateorprovince = shiptoStateorprovince;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            TotaldiscountamountBase = totaldiscountamountBase;
            Shippingmethodcode = shippingmethodcode;
            ShiptoContactname = shiptoContactname;
            this._owneridValue = _owneridValue;
            Submitstatusdescription = submitstatusdescription;
            ShiptoCity = shiptoCity;
            BilltoStateorprovince = billtoStateorprovince;
            this._owningteamValue = _owningteamValue;
            ShiptoLine1 = shiptoLine1;
            Totalamountlessfreight = totalamountlessfreight;
            Freightamount = freightamount;
            Description = description;
            Submitstatus = submitstatus;
            this._customeridValue = _customeridValue;
            ShiptoAddressid = shiptoAddressid;
            BilltoContactname = billtoContactname;
            this._contactidValue = _contactidValue;
            BilltoAddressid = billtoAddressid;
            Ispricelocked = ispricelocked;
            ShiptoFax = shiptoFax;
            Freighttermscode = freighttermscode;
            ContactordersAssociation = contactordersAssociation;
            Modifiedby = modifiedby;
            StageidProcessstage = stageidProcessstage;
            SalesorderOpportunitysalesprocess = salesorderOpportunitysalesprocess;
            Ownerid = ownerid;
            SalesOrderEmails = salesOrderEmails;
            Owninguser = owninguser;
            SalesOrderBulkDeleteFailures = salesOrderBulkDeleteFailures;
            Transactioncurrencyid = transactioncurrencyid;
            SlaSalesorderSla = slaSalesorderSla;
            SalesOrderActivityPointers = salesOrderActivityPointers;
            Campaignid = campaignid;
            SalesOrderSocialActivities = salesOrderSocialActivities;
            Owningbusinessunit = owningbusinessunit;
            SalesOrderAsyncOperations = salesOrderAsyncOperations;
            Modifiedonbehalfby = modifiedonbehalfby;
            SalesOrderServiceAppointments = salesOrderServiceAppointments;
            Quoteid = quoteid;
            SalesorderConnections2 = salesorderConnections2;
            SlakpiinstanceSalesorder = slakpiinstanceSalesorder;
            SalesorderActivityParties = salesorderActivityParties;
            SalesOrderAnnotation = salesOrderAnnotation;
            OrderDetails = orderDetails;
            SalesOrderLetters = salesOrderLetters;
            Pricelevelid = pricelevelid;
            Createdonbehalfby = createdonbehalfby;
            CustomeridContact = customeridContact;
            SalesOrderPhonecalls = salesOrderPhonecalls;
            SalesOrderSyncErrors = salesOrderSyncErrors;
            SalesOrderOrderClose = salesOrderOrderClose;
            SalesOrderRecurringAppointmentMasters = salesOrderRecurringAppointmentMasters;
            SalesOrderTasks = salesOrderTasks;
            Opportunityid = opportunityid;
            SalesOrderAppointments = salesOrderAppointments;
            SalesOrderFaxes = salesOrderFaxes;
            Owningteam = owningteam;
            Createdby = createdby;
            SalesorderConnections1 = salesorderConnections1;
            CustomeridAccount = customeridAccount;
            OrderInvoices = orderInvoices;
            SlainvokedidSalesorderSla = slainvokedidSalesorderSla;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastbackofficesubmit")]
        public System.DateTimeOffset? Lastbackofficesubmit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountpercentage")]
        public object Discountpercentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamountlessfreight_base")]
        public object TotalamountlessfreightBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_country")]
        public string BilltoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_fax")]
        public string BilltoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line3")]
        public string ShiptoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountamount")]
        public object Discountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "willcall")]
        public bool? Willcall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricingerrorcode")]
        public int? Pricingerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_telephone")]
        public string ShiptoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slainvokedid_value")]
        public string _slainvokedidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemdiscountamount_base")]
        public object TotallineitemdiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line1")]
        public string BilltoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_pricelevelid_value")]
        public string _pricelevelidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_telephone")]
        public string BilltoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_composite")]
        public string BilltoComposite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastonholdtime")]
        public System.DateTimeOffset? Lastonholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaltax_base")]
        public object TotaltaxBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_freighttermscode")]
        public int? ShiptoFreighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freightamount_base")]
        public object FreightamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscountamount")]
        public object Totaldiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_campaignid_value")]
        public string _campaignidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public string _accountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line3")]
        public string BilltoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamount_base")]
        public object TotalamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line2")]
        public string BilltoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_country")]
        public string ShiptoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountamount_base")]
        public object DiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_composite")]
        public string ShiptoComposite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_postalcode")]
        public string ShiptoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_postalcode")]
        public string BilltoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "submitdate")]
        public System.DateTimeOffset? Submitdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaltax")]
        public object Totaltax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_opportunityid_value")]
        public string _opportunityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_quoteid_value")]
        public string _quoteidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_city")]
        public string BilltoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage")]
        public object Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemamount_base")]
        public object TotallineitemamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemamount")]
        public object Totallineitemamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "prioritycode")]
        public int? Prioritycode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemdiscountamount")]
        public object Totallineitemdiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ordernumber")]
        public string Ordernumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamount")]
        public object Totalamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datefulfilled")]
        public System.DateTimeOffset? Datefulfilled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slaid_value")]
        public string _slaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestdeliveryby")]
        public System.DateTimeOffset? Requestdeliveryby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_name")]
        public string BilltoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paymenttermscode")]
        public int? Paymenttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderid")]
        public string Salesorderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_name")]
        public string ShiptoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line2")]
        public string ShiptoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "onholdtime")]
        public int? Onholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_stateorprovince")]
        public string ShiptoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscountamount_base")]
        public object TotaldiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippingmethodcode")]
        public int? Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_contactname")]
        public string ShiptoContactname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "submitstatusdescription")]
        public string Submitstatusdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_city")]
        public string ShiptoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_stateorprovince")]
        public string BilltoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line1")]
        public string ShiptoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamountlessfreight")]
        public object Totalamountlessfreight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freightamount")]
        public object Freightamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "submitstatus")]
        public int? Submitstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_customerid_value")]
        public string _customeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_addressid")]
        public string ShiptoAddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_contactname")]
        public string BilltoContactname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public string _contactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_addressid")]
        public string BilltoAddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispricelocked")]
        public bool? Ispricelocked { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_fax")]
        public string ShiptoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freighttermscode")]
        public int? Freighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactorders_association")]
        public IList<MicrosoftDynamicsCRMcontact> ContactordersAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorder_opportunitysalesprocess")]
        public IList<MicrosoftDynamicsCRMopportunitysalesprocess> SalesorderOpportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_Emails")]
        public IList<MicrosoftDynamicsCRMemail> SalesOrderEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SalesOrderBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_salesorder_sla")]
        public MicrosoftDynamicsCRMsla SlaSalesorderSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> SalesOrderActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignid")]
        public MicrosoftDynamicsCRMcampaign Campaignid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> SalesOrderSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SalesOrderAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> SalesOrderServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteid")]
        public MicrosoftDynamicsCRMquote Quoteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorder_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> SalesorderConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_salesorder")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceSalesorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorder_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> SalesorderActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> SalesOrderAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "order_details")]
        public IList<MicrosoftDynamicsCRMsalesorderdetail> OrderDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_Letters")]
        public IList<MicrosoftDynamicsCRMletter> SalesOrderLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevelid")]
        public MicrosoftDynamicsCRMpricelevel Pricelevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_contact")]
        public MicrosoftDynamicsCRMcontact CustomeridContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_Phonecalls")]
        public IList<MicrosoftDynamicsCRMphonecall> SalesOrderPhonecalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SalesOrderSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_OrderClose")]
        public IList<MicrosoftDynamicsCRMorderclose> SalesOrderOrderClose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> SalesOrderRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> SalesOrderTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityid")]
        public MicrosoftDynamicsCRMopportunity Opportunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> SalesOrderAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> SalesOrderFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorder_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> SalesorderConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_account")]
        public MicrosoftDynamicsCRMaccount CustomeridAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "order_invoices")]
        public IList<MicrosoftDynamicsCRMinvoice> OrderInvoices { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_salesorder_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidSalesorderSla { get; set; }

    }
}
