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

    public partial class MicrosoftDynamicsCRMfixedmonthlyfiscalcalendar
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMfixedmonthlyfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMfixedmonthlyfiscalcalendar()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMfixedmonthlyfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMfixedmonthlyfiscalcalendar(IList<MicrosoftDynamicsCRMasyncoperation> fixedMonthlyFiscalCalendarAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> fixedMonthlyFiscalCalendarBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), string _businessunitidValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _salespersonidValue = default(string), string _transactioncurrencyidValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? effectiveon = default(System.DateTimeOffset?), double? exchangerate = default(double?), int? fiscalperiodtype = default(int?), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), double? period1 = default(double?), double? period10 = default(double?), double? period10Base = default(double?), double? period11 = default(double?), double? period11Base = default(double?), double? period12 = default(double?), double? period12Base = default(double?), double? period13 = default(double?), double? period13Base = default(double?), double? period1Base = default(double?), double? period2 = default(double?), double? period2Base = default(double?), double? period3 = default(double?), double? period3Base = default(double?), double? period4 = default(double?), double? period4Base = default(double?), double? period5 = default(double?), double? period5Base = default(double?), double? period6 = default(double?), double? period6Base = default(double?), double? period7 = default(double?), double? period7Base = default(double?), double? period8 = default(double?), double? period8Base = default(double?), double? period9 = default(double?), double? period9Base = default(double?), MicrosoftDynamicsCRMsystemuser salespersonid = default(MicrosoftDynamicsCRMsystemuser), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), string userfiscalcalendarid = default(string), int? utcconversiontimezonecode = default(int?))
        {
            FixedMonthlyFiscalCalendarAsyncOperations = fixedMonthlyFiscalCalendarAsyncOperations;
            FixedMonthlyFiscalCalendarBulkDeleteFailures = fixedMonthlyFiscalCalendarBulkDeleteFailures;
            this._businessunitidValue = _businessunitidValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._salespersonidValue = _salespersonidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Effectiveon = effectiveon;
            Exchangerate = exchangerate;
            Fiscalperiodtype = fiscalperiodtype;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Period1 = period1;
            Period10 = period10;
            Period10Base = period10Base;
            Period11 = period11;
            Period11Base = period11Base;
            Period12 = period12;
            Period12Base = period12Base;
            Period13 = period13;
            Period13Base = period13Base;
            Period1Base = period1Base;
            Period2 = period2;
            Period2Base = period2Base;
            Period3 = period3;
            Period3Base = period3Base;
            Period4 = period4;
            Period4Base = period4Base;
            Period5 = period5;
            Period5Base = period5Base;
            Period6 = period6;
            Period6Base = period6Base;
            Period7 = period7;
            Period7Base = period7Base;
            Period8 = period8;
            Period8Base = period8Base;
            Period9 = period9;
            Period9Base = period9Base;
            Salespersonid = salespersonid;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Transactioncurrencyid = transactioncurrencyid;
            Userfiscalcalendarid = userfiscalcalendarid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FixedMonthlyFiscalCalendar_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> FixedMonthlyFiscalCalendarAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FixedMonthlyFiscalCalendar_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> FixedMonthlyFiscalCalendarBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salespersonid_value")]
        public string _salespersonidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveon")]
        public System.DateTimeOffset? Effectiveon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public double? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fiscalperiodtype")]
        public int? Fiscalperiodtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period1")]
        public double? Period1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period10")]
        public double? Period10 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period10_base")]
        public double? Period10Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period11")]
        public double? Period11 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period11_base")]
        public double? Period11Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period12")]
        public double? Period12 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period12_base")]
        public double? Period12Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period13")]
        public double? Period13 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period13_base")]
        public double? Period13Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period1_base")]
        public double? Period1Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period2")]
        public double? Period2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period2_base")]
        public double? Period2Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period3")]
        public double? Period3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period3_base")]
        public double? Period3Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period4")]
        public double? Period4 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period4_base")]
        public double? Period4Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period5")]
        public double? Period5 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period5_base")]
        public double? Period5Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period6")]
        public double? Period6 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period6_base")]
        public double? Period6Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period7")]
        public double? Period7 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period7_base")]
        public double? Period7Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period8")]
        public double? Period8 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period8_base")]
        public double? Period8Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period9")]
        public double? Period9 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period9_base")]
        public double? Period9Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salespersonid")]
        public MicrosoftDynamicsCRMsystemuser Salespersonid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userfiscalcalendarid")]
        public string Userfiscalcalendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

    }
}
