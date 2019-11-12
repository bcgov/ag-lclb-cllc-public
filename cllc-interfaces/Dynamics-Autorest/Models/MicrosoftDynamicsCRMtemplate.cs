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
    /// Microsoft.Dynamics.CRM.template
    /// </summary>
    public partial class MicrosoftDynamicsCRMtemplate
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtemplate
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMtemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtemplate
        /// class.
        /// </summary>
        /// <param name="presentationxml">XML data for the body of the email
        /// template.</param>
        /// <param name="_owningteamValue">Unique identifier of the team who
        /// owns the template.</param>
        /// <param name="subjectpresentationxml">XML data for the subject of
        /// the email template.</param>
        /// <param name="generationtypecode">For internal use only.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the email template.</param>
        /// <param name="mimetype">MIME type of the email template.</param>
        /// <param name="modifiedon">Date and time when the email template was
        /// last modified.</param>
        /// <param name="_owninguserValue">Unique identifier of the user who
        /// owns the template.</param>
        /// <param name="_owneridValue">Unique identifier of the user or team
        /// who owns the template for the email activity.</param>
        /// <param name="importsequencenumber">Unique identifier of the data
        /// import or data migration that created this record.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier of the
        /// business unit that owns the template.</param>
        /// <param name="description">Description of the email
        /// template.</param>
        /// <param name="templateidunique">For internal use only.</param>
        /// <param name="body">Body text of the email template.</param>
        /// <param name="solutionid">Unique identifier of the associated
        /// solution.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the template.</param>
        /// <param name="templatetypecode">Type of email template.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the template.</param>
        /// <param name="iscustomizable">Information that specifies whether
        /// this component can be customized.</param>
        /// <param name="ispersonal">Information about whether the template is
        /// personal or is available to all users.</param>
        /// <param name="opencount">For internal use only. Shows the number of
        /// times emails that use this template have been opened.</param>
        /// <param name="componentstate">For internal use only.</param>
        /// <param name="templateid">Unique identifier of the template.</param>
        /// <param name="ismanaged">Indicates whether the solution component is
        /// part of a managed solution.</param>
        /// <param name="openrate">Shows the open rate of this template. This
        /// is based on number of opens on followed emails that use this
        /// template.</param>
        /// <param name="title">Title of the template.</param>
        /// <param name="replyrate">Shows the reply rate for this template.
        /// This is based on number of replies received on followed emails that
        /// use this template.</param>
        /// <param name="createdon">Date and time when the email template was
        /// created.</param>
        /// <param name="overwritetime">For internal use only.</param>
        /// <param name="subject">Subject associated with the email
        /// template.</param>
        /// <param name="isrecommended">Indicates if a template is recommended
        /// by Dynamics 365.</param>
        /// <param name="introducedversion">Version in which the form is
        /// introduced.</param>
        /// <param name="replycount">For internal use only. Shows the number of
        /// times emails that use this template have received replies.</param>
        /// <param name="usedcount">Shows the number of sent emails that use
        /// this template.</param>
        /// <param name="languagecode">Language of the email template.</param>
        /// <param name="versionnumber">Version number of the template.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the template.</param>
        public MicrosoftDynamicsCRMtemplate(string presentationxml = default(string), System.Guid? _owningteamValue = default(System.Guid?), string subjectpresentationxml = default(string), int? generationtypecode = default(int?), System.Guid? _createdbyValue = default(System.Guid?), string mimetype = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.Guid? _owninguserValue = default(System.Guid?), System.Guid? _owneridValue = default(System.Guid?), int? importsequencenumber = default(int?), System.Guid? _owningbusinessunitValue = default(System.Guid?), string description = default(string), System.Guid? templateidunique = default(System.Guid?), string body = default(string), System.Guid? solutionid = default(System.Guid?), System.Guid? _modifiedbyValue = default(System.Guid?), string templatetypecode = default(string), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), string iscustomizable = default(string), bool? ispersonal = default(bool?), int? opencount = default(int?), int? componentstate = default(int?), System.Guid? templateid = default(System.Guid?), bool? ismanaged = default(bool?), int? openrate = default(int?), string title = default(string), int? replyrate = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string subject = default(string), bool? isrecommended = default(bool?), string introducedversion = default(string), int? replycount = default(int?), int? usedcount = default(int?), int? languagecode = default(int?), string versionnumber = default(string), System.Guid? _createdonbehalfbyValue = default(System.Guid?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> templateAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> templateBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMactivitymimeattachment> templateActivityMimeAttachments = default(IList<MicrosoftDynamicsCRMactivitymimeattachment>), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), IList<MicrosoftDynamicsCRMsyncerror> templateSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMorganization> templateOrganization = default(IList<MicrosoftDynamicsCRMorganization>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMemail> emailEmailTemplate = default(IList<MicrosoftDynamicsCRMemail>))
        {
            Presentationxml = presentationxml;
            this._owningteamValue = _owningteamValue;
            Subjectpresentationxml = subjectpresentationxml;
            Generationtypecode = generationtypecode;
            this._createdbyValue = _createdbyValue;
            Mimetype = mimetype;
            Modifiedon = modifiedon;
            this._owninguserValue = _owninguserValue;
            this._owneridValue = _owneridValue;
            Importsequencenumber = importsequencenumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Description = description;
            Templateidunique = templateidunique;
            Body = body;
            Solutionid = solutionid;
            this._modifiedbyValue = _modifiedbyValue;
            Templatetypecode = templatetypecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Iscustomizable = iscustomizable;
            Ispersonal = ispersonal;
            Opencount = opencount;
            Componentstate = componentstate;
            Templateid = templateid;
            Ismanaged = ismanaged;
            Openrate = openrate;
            Title = title;
            Replyrate = replyrate;
            Createdon = createdon;
            Overwritetime = overwritetime;
            Subject = subject;
            Isrecommended = isrecommended;
            Introducedversion = introducedversion;
            Replycount = replycount;
            Usedcount = usedcount;
            Languagecode = languagecode;
            Versionnumber = versionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdby = createdby;
            Owningbusinessunit = owningbusinessunit;
            Modifiedby = modifiedby;
            TemplateAsyncOperations = templateAsyncOperations;
            TemplateBulkDeleteFailures = templateBulkDeleteFailures;
            Createdonbehalfby = createdonbehalfby;
            Owningteam = owningteam;
            TemplateActivityMimeAttachments = templateActivityMimeAttachments;
            Ownerid = ownerid;
            TemplateSyncErrors = templateSyncErrors;
            Owninguser = owninguser;
            TemplateOrganization = templateOrganization;
            Modifiedonbehalfby = modifiedonbehalfby;
            EmailEmailTemplate = emailEmailTemplate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets XML data for the body of the email template.
        /// </summary>
        [JsonProperty(PropertyName = "presentationxml")]
        public string Presentationxml { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the team who owns the template.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public System.Guid? _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets XML data for the subject of the email template.
        /// </summary>
        [JsonProperty(PropertyName = "subjectpresentationxml")]
        public string Subjectpresentationxml { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "generationtypecode")]
        public int? Generationtypecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the email
        /// template.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets MIME type of the email template.
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// Gets or sets date and time when the email template was last
        /// modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who owns the template.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public System.Guid? _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user or team who owns the
        /// template for the email activity.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public System.Guid? _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the data import or data migration
        /// that created this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the business unit that owns the
        /// template.
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public System.Guid? _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets description of the email template.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "templateidunique")]
        public System.Guid? Templateidunique { get; set; }

        /// <summary>
        /// Gets or sets body text of the email template.
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the associated solution.
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public System.Guid? Solutionid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// template.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets type of email template.
        /// </summary>
        [JsonProperty(PropertyName = "templatetypecode")]
        public string Templatetypecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the template.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets information that specifies whether this component can
        /// be customized.
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// Gets or sets information about whether the template is personal or
        /// is available to all users.
        /// </summary>
        [JsonProperty(PropertyName = "ispersonal")]
        public bool? Ispersonal { get; set; }

        /// <summary>
        /// Gets or sets for internal use only. Shows the number of times
        /// emails that use this template have been opened.
        /// </summary>
        [JsonProperty(PropertyName = "opencount")]
        public int? Opencount { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the template.
        /// </summary>
        [JsonProperty(PropertyName = "templateid")]
        public System.Guid? Templateid { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the solution component is part of a
        /// managed solution.
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// Gets or sets shows the open rate of this template. This is based on
        /// number of opens on followed emails that use this template.
        /// </summary>
        [JsonProperty(PropertyName = "openrate")]
        public int? Openrate { get; set; }

        /// <summary>
        /// Gets or sets title of the template.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets shows the reply rate for this template. This is based
        /// on number of replies received on followed emails that use this
        /// template.
        /// </summary>
        [JsonProperty(PropertyName = "replyrate")]
        public int? Replyrate { get; set; }

        /// <summary>
        /// Gets or sets date and time when the email template was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// Gets or sets subject associated with the email template.
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets indicates if a template is recommended by Dynamics
        /// 365.
        /// </summary>
        [JsonProperty(PropertyName = "isrecommended")]
        public bool? Isrecommended { get; set; }

        /// <summary>
        /// Gets or sets version in which the form is introduced.
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// Gets or sets for internal use only. Shows the number of times
        /// emails that use this template have received replies.
        /// </summary>
        [JsonProperty(PropertyName = "replycount")]
        public int? Replycount { get; set; }

        /// <summary>
        /// Gets or sets shows the number of sent emails that use this
        /// template.
        /// </summary>
        [JsonProperty(PropertyName = "usedcount")]
        public int? Usedcount { get; set; }

        /// <summary>
        /// Gets or sets language of the email template.
        /// </summary>
        [JsonProperty(PropertyName = "languagecode")]
        public int? Languagecode { get; set; }

        /// <summary>
        /// Gets or sets version number of the template.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// template.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Template_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> TemplateAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Template_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> TemplateBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "template_activity_mime_attachments")]
        public IList<MicrosoftDynamicsCRMactivitymimeattachment> TemplateActivityMimeAttachments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Template_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> TemplateSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Template_Organization")]
        public IList<MicrosoftDynamicsCRMorganization> TemplateOrganization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email_EmailTemplate")]
        public IList<MicrosoftDynamicsCRMemail> EmailEmailTemplate { get; set; }

    }
}
