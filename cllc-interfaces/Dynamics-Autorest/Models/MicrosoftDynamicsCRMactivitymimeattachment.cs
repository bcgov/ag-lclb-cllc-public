// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.activitymimeattachment
    /// </summary>
    public partial class MicrosoftDynamicsCRMactivitymimeattachment
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMactivitymimeattachment class.
        /// </summary>
        public MicrosoftDynamicsCRMactivitymimeattachment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMactivitymimeattachment class.
        /// </summary>
        public MicrosoftDynamicsCRMactivitymimeattachment(int? componentstate = default(int?), string versionnumber = default(string), string _owneridValue = default(string), string subject = default(string), int? filesize = default(int?), bool? isfollowed = default(bool?), bool? ismanaged = default(bool?), string activitymimeattachmentid = default(string), string _owninguserValue = default(string), string attachmentcontentid = default(string), string _attachmentidValue = default(string), string objecttypecode = default(string), string _owningbusinessunitValue = default(string), string _objectidValue = default(string), string activitymimeattachmentidunique = default(string), string mimetype = default(string), string activitysubject = default(string), string solutionid = default(string), int? attachmentnumber = default(int?), string anonymouslink = default(string), string filename = default(string), string body = default(string), byte[] bodyBinary = default(byte[]), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), IList<MicrosoftDynamicsCRMsyncerror> activityMimeAttachmentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMemail objectidEmail = default(MicrosoftDynamicsCRMemail), MicrosoftDynamicsCRMactivitypointer objectidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMtemplate objectidTemplate = default(MicrosoftDynamicsCRMtemplate), MicrosoftDynamicsCRMattachment attachmentid = default(MicrosoftDynamicsCRMattachment), MicrosoftDynamicsCRMappointment objectidAppointment = default(MicrosoftDynamicsCRMappointment), IList<MicrosoftDynamicsCRMasyncoperation> activityMimeAttachmentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> activityMimeAttachmentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>))
        {
            Componentstate = componentstate;
            Versionnumber = versionnumber;
            this._owneridValue = _owneridValue;
            Subject = subject;
            Filesize = filesize;
            Isfollowed = isfollowed;
            Ismanaged = ismanaged;
            Activitymimeattachmentid = activitymimeattachmentid;
            this._owninguserValue = _owninguserValue;
            Attachmentcontentid = attachmentcontentid;
            this._attachmentidValue = _attachmentidValue;
            Objecttypecode = objecttypecode;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._objectidValue = _objectidValue;
            Activitymimeattachmentidunique = activitymimeattachmentidunique;
            Mimetype = mimetype;
            Activitysubject = activitysubject;
            Solutionid = solutionid;
            Attachmentnumber = attachmentnumber;
            Anonymouslink = anonymouslink;
            Filename = filename;
            Body = body;
            BodyBinary = bodyBinary;
            Overwritetime = overwritetime;
            ActivityMimeAttachmentSyncErrors = activityMimeAttachmentSyncErrors;
            ObjectidEmail = objectidEmail;
            ObjectidActivitypointer = objectidActivitypointer;
            ObjectidTemplate = objectidTemplate;
            Attachmentid = attachmentid;
            ObjectidAppointment = objectidAppointment;
            ActivityMimeAttachmentAsyncOperations = activityMimeAttachmentAsyncOperations;
            ActivityMimeAttachmentBulkDeleteFailures = activityMimeAttachmentBulkDeleteFailures;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filesize")]
        public int? Filesize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isfollowed")]
        public bool? Isfollowed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activitymimeattachmentid")]
        public string Activitymimeattachmentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachmentcontentid")]
        public string Attachmentcontentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_attachmentid_value")]
        public string _attachmentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public string Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_objectid_value")]
        public string _objectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activitymimeattachmentidunique")]
        public string Activitymimeattachmentidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activitysubject")]
        public string Activitysubject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachmentnumber")]
        public int? Attachmentnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "anonymouslink")]
        public string Anonymouslink { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "body_binary")]
        public byte[] BodyBinary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityMimeAttachment_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ActivityMimeAttachmentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_email")]
        public MicrosoftDynamicsCRMemail ObjectidEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ObjectidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_template")]
        public MicrosoftDynamicsCRMtemplate ObjectidTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachmentid")]
        public MicrosoftDynamicsCRMattachment Attachmentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_appointment")]
        public MicrosoftDynamicsCRMappointment ObjectidAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityMimeAttachment_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ActivityMimeAttachmentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityMimeAttachment_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ActivityMimeAttachmentBulkDeleteFailures { get; set; }

    }
}
