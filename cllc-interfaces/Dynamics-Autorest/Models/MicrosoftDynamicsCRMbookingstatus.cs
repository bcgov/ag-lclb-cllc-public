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
    /// Microsoft.Dynamics.CRM.bookingstatus
    /// </summary>
    public partial class MicrosoftDynamicsCRMbookingstatus
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMbookingstatus
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMbookingstatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMbookingstatus
        /// class.
        /// </summary>
        /// <param name="statuscode">Reason for the status of the Booking
        /// Status</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="description">Type a detailed description for the
        /// booking status.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="exchangerate">Exchange rate for the currency
        /// associated with the bookingstatus with respect to the base
        /// currency.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="bookingstatusid">Unique identifier of the booking
        /// status.</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="_owneridValue">Unique identifier of the user or team
        /// who owns the record.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="status">Select whether the booking status should be
        /// proposed, committed or canceled.</param>
        /// <param name="name">Type the name of the booking status.</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="statecode">Status of the Booking Status</param>
        /// <param name="_transactioncurrencyidValue">Exchange rate for the
        /// currency associated with the BookingStatus with respect to the base
        /// currency.</param>
        public MicrosoftDynamicsCRMbookingstatus(int? statuscode = default(int?), string _createdonbehalfbyValue = default(string), string description = default(string), string _createdbyValue = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string versionnumber = default(string), decimal? exchangerate = default(decimal?), int? importsequencenumber = default(int?), int? timezoneruleversionnumber = default(int?), string bookingstatusid = default(string), string _owninguserValue = default(string), string _owneridValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string _owningbusinessunitValue = default(string), int? status = default(int?), string name = default(string), string _owningteamValue = default(string), int? statecode = default(int?), string _transactioncurrencyidValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMduplicaterecord> bookingstatusDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bookingstatusDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> bookingstatusAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bookingstatusBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMbookableresourcebooking> bookingstatusBookableresourcebookingBookingStatus = default(IList<MicrosoftDynamicsCRMbookableresourcebooking>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsyncerror> bookingStatusSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>))
        {
            Statuscode = statuscode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Description = description;
            this._createdbyValue = _createdbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Overriddencreatedon = overriddencreatedon;
            Createdon = createdon;
            Versionnumber = versionnumber;
            Exchangerate = exchangerate;
            Importsequencenumber = importsequencenumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Bookingstatusid = bookingstatusid;
            this._owninguserValue = _owninguserValue;
            this._owneridValue = _owneridValue;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Status = status;
            Name = name;
            this._owningteamValue = _owningteamValue;
            Statecode = statecode;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BookingstatusDuplicateMatchingRecord = bookingstatusDuplicateMatchingRecord;
            BookingstatusDuplicateBaseRecord = bookingstatusDuplicateBaseRecord;
            BookingstatusAsyncOperations = bookingstatusAsyncOperations;
            BookingstatusBulkDeleteFailures = bookingstatusBulkDeleteFailures;
            BookingstatusBookableresourcebookingBookingStatus = bookingstatusBookableresourcebookingBookingStatus;
            Transactioncurrencyid = transactioncurrencyid;
            BookingStatusSyncErrors = bookingStatusSyncErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reason for the status of the Booking Status
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets type a detailed description for the booking status.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets exchange rate for the currency associated with the
        /// bookingstatus with respect to the base currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the booking status.
        /// </summary>
        [JsonProperty(PropertyName = "bookingstatusid")]
        public string Bookingstatusid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user or team who owns the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets select whether the booking status should be proposed,
        /// committed or canceled.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or sets type the name of the booking status.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets status of the Booking Status
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets exchange rate for the currency associated with the
        /// BookingStatus with respect to the base currency.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookingstatus_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BookingstatusDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookingstatus_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BookingstatusDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookingstatus_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BookingstatusAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookingstatus_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BookingstatusBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookingstatus_bookableresourcebooking_BookingStatus")]
        public IList<MicrosoftDynamicsCRMbookableresourcebooking> BookingstatusBookableresourcebookingBookingStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BookingStatus_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BookingStatusSyncErrors { get; set; }

    }
}
