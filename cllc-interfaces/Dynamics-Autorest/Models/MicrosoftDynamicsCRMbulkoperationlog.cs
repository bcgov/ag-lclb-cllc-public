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
    /// Microsoft.Dynamics.CRM.bulkoperationlog
    /// </summary>
    public partial class MicrosoftDynamicsCRMbulkoperationlog
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbulkoperationlog class.
        /// </summary>
        public MicrosoftDynamicsCRMbulkoperationlog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbulkoperationlog class.
        /// </summary>
        /// <param name="additionalinfo">Shows the data value at which an error
        /// occurred during the quick campaign.</param>
        /// <param name="owningbusinessunit">Unique identifier of the business
        /// unit that owns the bulk operation log.</param>
        /// <param name="owninguser">Unique identifier of the user who owns the
        /// bulk operation log.</param>
        /// <param name="errornumber">Shows the error code that is used to
        /// troubleshoot issues in the bulk operation.</param>
        /// <param name="bulkoperationlogid">Unique identifier of the bulk
        /// operation log.</param>
        /// <param name="_bulkoperationidValue">Shows the quick campaign record
        /// that the log applies to. This information is used to relate log
        /// data to the parent quick campaign.</param>
        /// <param name="_regardingobjectidValue">Choose the account, contact,
        /// lead, or list that the bulk operation log item applies to.</param>
        /// <param name="_createdobjectidValue">Choose the activity or other
        /// item created by the bulk operation.</param>
        /// <param name="_owneridValue">Unique identifier of the user or team
        /// who owns the bulk operation log.</param>
        public MicrosoftDynamicsCRMbulkoperationlog(string additionalinfo = default(string), string owningbusinessunit = default(string), string owninguser = default(string), int? errornumber = default(int?), string bulkoperationlogid = default(string), string _bulkoperationidValue = default(string), string _regardingobjectidValue = default(string), string _createdobjectidValue = default(string), string _owneridValue = default(string), MicrosoftDynamicsCRMactivitypointer createdobjectidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMcontact createdobjectidContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMbulkdeletefailure> bulkOperationLogBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMbulkoperation bulkoperationid = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMaccount createdobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMaccount regardingobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMactivitypointer bulkoperationidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMlead createdobjectidLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMopportunity createdobjectidOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMcontact regardingobjectidContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMasyncoperation> bulkOperationLogAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMlead regardingobjectidLead = default(MicrosoftDynamicsCRMlead))
        {
            Additionalinfo = additionalinfo;
            Owningbusinessunit = owningbusinessunit;
            Owninguser = owninguser;
            Errornumber = errornumber;
            Bulkoperationlogid = bulkoperationlogid;
            this._bulkoperationidValue = _bulkoperationidValue;
            this._regardingobjectidValue = _regardingobjectidValue;
            this._createdobjectidValue = _createdobjectidValue;
            this._owneridValue = _owneridValue;
            CreatedobjectidActivitypointer = createdobjectidActivitypointer;
            CreatedobjectidContact = createdobjectidContact;
            BulkOperationLogBulkDeleteFailures = bulkOperationLogBulkDeleteFailures;
            Bulkoperationid = bulkoperationid;
            CreatedobjectidAccount = createdobjectidAccount;
            RegardingobjectidAccount = regardingobjectidAccount;
            BulkoperationidActivitypointer = bulkoperationidActivitypointer;
            CreatedobjectidLead = createdobjectidLead;
            CreatedobjectidOpportunity = createdobjectidOpportunity;
            RegardingobjectidContact = regardingobjectidContact;
            BulkOperationLogAsyncOperations = bulkOperationLogAsyncOperations;
            RegardingobjectidLead = regardingobjectidLead;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets shows the data value at which an error occurred during
        /// the quick campaign.
        /// </summary>
        [JsonProperty(PropertyName = "additionalinfo")]
        public string Additionalinfo { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the business unit that owns the
        /// bulk operation log.
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public string Owningbusinessunit { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who owns the bulk
        /// operation log.
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public string Owninguser { get; set; }

        /// <summary>
        /// Gets or sets shows the error code that is used to troubleshoot
        /// issues in the bulk operation.
        /// </summary>
        [JsonProperty(PropertyName = "errornumber")]
        public int? Errornumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the bulk operation log.
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperationlogid")]
        public string Bulkoperationlogid { get; set; }

        /// <summary>
        /// Gets or sets shows the quick campaign record that the log applies
        /// to. This information is used to relate log data to the parent quick
        /// campaign.
        /// </summary>
        [JsonProperty(PropertyName = "_bulkoperationid_value")]
        public string _bulkoperationidValue { get; set; }

        /// <summary>
        /// Gets or sets choose the account, contact, lead, or list that the
        /// bulk operation log item applies to.
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// Gets or sets choose the activity or other item created by the bulk
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "_createdobjectid_value")]
        public string _createdobjectidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user or team who owns the
        /// bulk operation log.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdobjectid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer CreatedobjectidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdobjectid_contact")]
        public MicrosoftDynamicsCRMcontact CreatedobjectidContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperationLog_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BulkOperationLogBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperationid")]
        public MicrosoftDynamicsCRMbulkoperation Bulkoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdobjectid_account")]
        public MicrosoftDynamicsCRMaccount CreatedobjectidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperationid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer BulkoperationidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdobjectid_lead")]
        public MicrosoftDynamicsCRMlead CreatedobjectidLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdobjectid_opportunity")]
        public MicrosoftDynamicsCRMopportunity CreatedobjectidOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperationLog_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BulkOperationLogAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLead { get; set; }

    }
}
