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
    /// Microsoft.Dynamics.CRM.plugintypestatistic
    /// </summary>
    public partial class MicrosoftDynamicsCRMplugintypestatistic
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMplugintypestatistic class.
        /// </summary>
        public MicrosoftDynamicsCRMplugintypestatistic()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMplugintypestatistic class.
        /// </summary>
        public MicrosoftDynamicsCRMplugintypestatistic(string _organizationidValue = default(string), string _createdbyValue = default(string), string _modifiedbyValue = default(string), int? crashcount = default(int?), int? executecount = default(int?), int? terminatememorycontributionpercent = default(int?), int? terminateothercontributionpercent = default(int?), string _modifiedonbehalfbyValue = default(string), int? terminatecpucontributionpercent = default(int?), int? failurepercent = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? averageexecutetimeinmilliseconds = default(int?), string _plugintypeidValue = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string plugintypestatisticid = default(string), int? terminatehandlescontributionpercent = default(int?), int? crashpercent = default(int?), int? failurecount = default(int?), int? crashcontributionpercent = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMplugintype plugintypeid = default(MicrosoftDynamicsCRMplugintype), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._organizationidValue = _organizationidValue;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Crashcount = crashcount;
            Executecount = executecount;
            Terminatememorycontributionpercent = terminatememorycontributionpercent;
            Terminateothercontributionpercent = terminateothercontributionpercent;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Terminatecpucontributionpercent = terminatecpucontributionpercent;
            Failurepercent = failurepercent;
            Createdon = createdon;
            Averageexecutetimeinmilliseconds = averageexecutetimeinmilliseconds;
            this._plugintypeidValue = _plugintypeidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            Plugintypestatisticid = plugintypestatisticid;
            Terminatehandlescontributionpercent = terminatehandlescontributionpercent;
            Crashpercent = crashpercent;
            Failurecount = failurecount;
            Crashcontributionpercent = crashcontributionpercent;
            Createdby = createdby;
            Organizationid = organizationid;
            Createdonbehalfby = createdonbehalfby;
            Plugintypeid = plugintypeid;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

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
        [JsonProperty(PropertyName = "crashcount")]
        public int? Crashcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "executecount")]
        public int? Executecount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "terminatememorycontributionpercent")]
        public int? Terminatememorycontributionpercent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "terminateothercontributionpercent")]
        public int? Terminateothercontributionpercent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "terminatecpucontributionpercent")]
        public int? Terminatecpucontributionpercent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "failurepercent")]
        public int? Failurepercent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "averageexecutetimeinmilliseconds")]
        public int? Averageexecutetimeinmilliseconds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_plugintypeid_value")]
        public string _plugintypeidValue { get; set; }

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
        [JsonProperty(PropertyName = "plugintypestatisticid")]
        public string Plugintypestatisticid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "terminatehandlescontributionpercent")]
        public int? Terminatehandlescontributionpercent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "crashpercent")]
        public int? Crashpercent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "failurecount")]
        public int? Failurecount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "crashcontributionpercent")]
        public int? Crashcontributionpercent { get; set; }

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
        [JsonProperty(PropertyName = "plugintypeid")]
        public MicrosoftDynamicsCRMplugintype Plugintypeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
