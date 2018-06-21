// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMdataperformance
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdataperformance class.
        /// </summary>
        public MicrosoftDynamicsCRMdataperformance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdataperformance class.
        /// </summary>
        public MicrosoftDynamicsCRMdataperformance(string _organizationidValue = default(string), bool? anyoptimizationapplied = default(bool?), bool? anyoptimizationavailable = default(bool?), string component = default(string), int? count = default(int?), string dataperformanceid = default(string), string entity = default(string), double? estimatedoptimizationimpact = default(double?), string executionperiod = default(string), string lastactionresult = default(string), System.DateTimeOffset? lastoptimizationdate = default(System.DateTimeOffset?), double? maxtime = default(double?), double? mediantime = default(double?), double? mintime = default(double?), string operation = default(string), string optimizationstatus = default(string), double? optimizationstorage = default(double?), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), string realizedoptimizationimpact = default(string), string solution = default(string), double? weight = default(double?))
        {
            this._organizationidValue = _organizationidValue;
            Anyoptimizationapplied = anyoptimizationapplied;
            Anyoptimizationavailable = anyoptimizationavailable;
            Component = component;
            Count = count;
            Dataperformanceid = dataperformanceid;
            Entity = entity;
            Estimatedoptimizationimpact = estimatedoptimizationimpact;
            Executionperiod = executionperiod;
            Lastactionresult = lastactionresult;
            Lastoptimizationdate = lastoptimizationdate;
            Maxtime = maxtime;
            Mediantime = mediantime;
            Mintime = mintime;
            Operation = operation;
            Optimizationstatus = optimizationstatus;
            Optimizationstorage = optimizationstorage;
            Organizationid = organizationid;
            Realizedoptimizationimpact = realizedoptimizationimpact;
            Solution = solution;
            Weight = weight;
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
        [JsonProperty(PropertyName = "anyoptimizationapplied")]
        public bool? Anyoptimizationapplied { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "anyoptimizationavailable")]
        public bool? Anyoptimizationavailable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "component")]
        public string Component { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataperformanceid")]
        public string Dataperformanceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entity")]
        public string Entity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "estimatedoptimizationimpact")]
        public double? Estimatedoptimizationimpact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "executionperiod")]
        public string Executionperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastactionresult")]
        public string Lastactionresult { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastoptimizationdate")]
        public System.DateTimeOffset? Lastoptimizationdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxtime")]
        public double? Maxtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mediantime")]
        public double? Mediantime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mintime")]
        public double? Mintime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "optimizationstatus")]
        public string Optimizationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "optimizationstorage")]
        public double? Optimizationstorage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "realizedoptimizationimpact")]
        public string Realizedoptimizationimpact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solution")]
        public string Solution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public double? Weight { get; set; }

    }
}
