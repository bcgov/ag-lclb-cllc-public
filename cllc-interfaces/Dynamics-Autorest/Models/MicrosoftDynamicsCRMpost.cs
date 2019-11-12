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
    /// Microsoft.Dynamics.CRM.post
    /// </summary>
    public partial class MicrosoftDynamicsCRMpost
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpost class.
        /// </summary>
        public MicrosoftDynamicsCRMpost()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpost class.
        /// </summary>
        /// <param name="modifiedon">Shows the date and time when the record
        /// was last updated. The date and time are displayed in the time zone
        /// selected in Microsoft Dynamics 365 options.</param>
        /// <param name="createdon">Shows the date and time when the record was
        /// created. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.</param>
        /// <param name="_createdonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="_regardingobjectowningbusinessunitValue">Unique
        /// identifier of the business unit that owns the regarding
        /// object.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="text">Shows the text of a post. If this is a manual
        /// post, it appears in plain text. If this is an auto post, it appears
        /// in XML.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_regardingobjectidValue">Choose the parent record for
        /// the post to identify the customer, opportunity, case, or other
        /// record that the post most closely relates to.</param>
        /// <param name="_regardingobjectowneridValue">Unique identifier of the
        /// user or team who owns the regarding object.</param>
        /// <param name="_createdbyValue">Shows who created the record.</param>
        /// <param name="source">Select whether the post was created manually
        /// or automatically.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization associated with the solution.</param>
        /// <param name="postid">Unique identifier for entity instances</param>
        /// <param name="type">Select the post type.</param>
        public MicrosoftDynamicsCRMpost(System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.Guid? _regardingobjectowningbusinessunitValue = default(System.Guid?), System.Guid? _modifiedbyValue = default(System.Guid?), string text = default(string), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), System.Guid? _regardingobjectidValue = default(System.Guid?), System.Guid? _regardingobjectowneridValue = default(System.Guid?), System.Guid? _createdbyValue = default(System.Guid?), int? source = default(int?), System.Guid? _organizationidValue = default(System.Guid?), System.Guid? postid = default(System.Guid?), int? type = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> postAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> postBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMpostregarding postregardingid = default(MicrosoftDynamicsCRMpostregarding), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMpostcomment> postComments = default(IList<MicrosoftDynamicsCRMpostcomment>), IList<MicrosoftDynamicsCRMpostlike> postLikes = default(IList<MicrosoftDynamicsCRMpostlike>))
        {
            Modifiedon = modifiedon;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._regardingobjectowningbusinessunitValue = _regardingobjectowningbusinessunitValue;
            this._modifiedbyValue = _modifiedbyValue;
            Text = text;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._regardingobjectidValue = _regardingobjectidValue;
            this._regardingobjectowneridValue = _regardingobjectowneridValue;
            this._createdbyValue = _createdbyValue;
            Source = source;
            this._organizationidValue = _organizationidValue;
            Postid = postid;
            Type = type;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            PostAsyncOperations = postAsyncOperations;
            PostBulkDeleteFailures = postBulkDeleteFailures;
            Postregardingid = postregardingid;
            Organizationid = organizationid;
            PostComments = postComments;
            PostLikes = postLikes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets shows the date and time when the record was last
        /// updated. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was created.
        /// The date and time are displayed in the time zone selected in
        /// Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the business unit that owns the
        /// regarding object.
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectowningbusinessunit_value")]
        public System.Guid? _regardingobjectowningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the text of a post. If this is a manual post, it
        /// appears in plain text. If this is an auto post, it appears in XML.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets choose the parent record for the post to identify the
        /// customer, opportunity, case, or other record that the post most
        /// closely relates to.
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public System.Guid? _regardingobjectidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user or team who owns the
        /// regarding object.
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectownerid_value")]
        public System.Guid? _regardingobjectowneridValue { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets select whether the post was created manually or
        /// automatically.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public int? Source { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization associated with
        /// the solution.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "postid")]
        public System.Guid? Postid { get; set; }

        /// <summary>
        /// Gets or sets select the post type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

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
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "post_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> PostAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "post_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> PostBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postregardingid")]
        public MicrosoftDynamicsCRMpostregarding Postregardingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Post_Comments")]
        public IList<MicrosoftDynamicsCRMpostcomment> PostComments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Post_Likes")]
        public IList<MicrosoftDynamicsCRMpostlike> PostLikes { get; set; }

    }
}
