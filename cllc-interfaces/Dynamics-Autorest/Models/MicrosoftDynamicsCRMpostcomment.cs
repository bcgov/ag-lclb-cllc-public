// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.postcomment
    /// </summary>
    public partial class MicrosoftDynamicsCRMpostcomment
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpostcomment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpostcomment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpostcomment
        /// class.
        /// </summary>
        /// <param name="postcommentid">Shows the ID of the post
        /// comment.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization associated with the solution.</param>
        /// <param name="text">Text of the comment.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="_postidValue">Unique identifier of the post with which
        /// the comment is associated.</param>
        public MicrosoftDynamicsCRMpostcomment(System.Guid? postcommentid = default(System.Guid?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.Guid? _createdbyValue = default(System.Guid?), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), System.Guid? _organizationidValue = default(System.Guid?), string text = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _postidValue = default(System.Guid?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMpost postid = default(MicrosoftDynamicsCRMpost))
        {
            Postcommentid = postcommentid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._organizationidValue = _organizationidValue;
            Text = text;
            Createdon = createdon;
            this._postidValue = _postidValue;
            Createdby = createdby;
            Organizationid = organizationid;
            Createdonbehalfby = createdonbehalfby;
            Postid = postid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets shows the ID of the post comment.
        /// </summary>
        [JsonProperty(PropertyName = "postcommentid")]
        public System.Guid? Postcommentid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization associated with
        /// the solution.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets text of the comment.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the post with which the comment
        /// is associated.
        /// </summary>
        [JsonProperty(PropertyName = "_postid_value")]
        public System.Guid? _postidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postid")]
        public MicrosoftDynamicsCRMpost Postid { get; set; }

    }
}
