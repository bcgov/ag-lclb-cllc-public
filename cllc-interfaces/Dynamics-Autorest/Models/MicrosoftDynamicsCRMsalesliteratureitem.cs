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
    /// Microsoft.Dynamics.CRM.salesliteratureitem
    /// </summary>
    public partial class MicrosoftDynamicsCRMsalesliteratureitem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsalesliteratureitem class.
        /// </summary>
        public MicrosoftDynamicsCRMsalesliteratureitem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsalesliteratureitem class.
        /// </summary>
        public MicrosoftDynamicsCRMsalesliteratureitem(string filename = default(string), string organizationid = default(string), string _modifiedonbehalfbyValue = default(string), bool? iscustomerviewable = default(bool?), string attacheddocumenturl = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string versionnumber = default(string), string mimetype = default(string), string keywords = default(string), string abstractProperty = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string authorname = default(string), string mode = default(string), int? filesize = default(int?), string documentbody = default(string), byte[] documentbodyBinary = default(byte[]), int? filetypecode = default(int?), string salesliteratureitemid = default(string), int? importsequencenumber = default(int?), int? utcconversiontimezonecode = default(int?), string title = default(string), string _createdbyValue = default(string), string _modifiedbyValue = default(string), string _salesliteratureidValue = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), IList<MicrosoftDynamicsCRMsyncerror> salesliteratureitemSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMteam> salesliteratureitemTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> salesliteratureitemMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> salesliteratureitemPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsalesliterature salesliteratureid = default(MicrosoftDynamicsCRMsalesliterature), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMprocesssession> salesLiteratureItemProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> salesLiteratureItemBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> salesLiteratureItemAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>))
        {
            Filename = filename;
            Organizationid = organizationid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Iscustomerviewable = iscustomerviewable;
            Attacheddocumenturl = attacheddocumenturl;
            Overriddencreatedon = overriddencreatedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Versionnumber = versionnumber;
            Mimetype = mimetype;
            Keywords = keywords;
            AbstractProperty = abstractProperty;
            Createdon = createdon;
            Authorname = authorname;
            Mode = mode;
            Filesize = filesize;
            Documentbody = documentbody;
            DocumentbodyBinary = documentbodyBinary;
            Filetypecode = filetypecode;
            Salesliteratureitemid = salesliteratureitemid;
            Importsequencenumber = importsequencenumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Title = title;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._salesliteratureidValue = _salesliteratureidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            SalesliteratureitemSyncErrors = salesliteratureitemSyncErrors;
            SalesliteratureitemTeams = salesliteratureitemTeams;
            SalesliteratureitemMailboxTrackingFolders = salesliteratureitemMailboxTrackingFolders;
            SalesliteratureitemPrincipalObjectAttributeAccesses = salesliteratureitemPrincipalObjectAttributeAccesses;
            Createdby = createdby;
            Salesliteratureid = salesliteratureid;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            SalesLiteratureItemProcessSessions = salesLiteratureItemProcessSessions;
            SalesLiteratureItemBulkDeleteFailures = salesLiteratureItemBulkDeleteFailures;
            Modifiedby = modifiedby;
            SalesLiteratureItemAsyncOperations = salesLiteratureItemAsyncOperations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public string Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomerviewable")]
        public bool? Iscustomerviewable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attacheddocumenturl")]
        public string Attacheddocumenturl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abstract")]
        public string AbstractProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authorname")]
        public string Authorname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filesize")]
        public int? Filesize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentbody")]
        public string Documentbody { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "documentbody_binary")]
        public byte[] DocumentbodyBinary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filetypecode")]
        public int? Filetypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesliteratureitemid")]
        public string Salesliteratureitemid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesliteratureid_value")]
        public string _salesliteratureidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesliteratureitem_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SalesliteratureitemSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesliteratureitem_Teams")]
        public IList<MicrosoftDynamicsCRMteam> SalesliteratureitemTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesliteratureitem_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SalesliteratureitemMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesliteratureitem_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SalesliteratureitemPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesliteratureid")]
        public MicrosoftDynamicsCRMsalesliterature Salesliteratureid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesLiteratureItem_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> SalesLiteratureItemProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesLiteratureItem_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SalesLiteratureItemBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesLiteratureItem_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SalesLiteratureItemAsyncOperations { get; set; }

    }
}
