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
    /// AuditPartitionDetail
    /// </summary>
    public partial class MicrosoftDynamicsCRMAuditPartitionDetail
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAuditPartitionDetail class.
        /// </summary>
        public MicrosoftDynamicsCRMAuditPartitionDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAuditPartitionDetail class.
        /// </summary>
        public MicrosoftDynamicsCRMAuditPartitionDetail(int? partitionNumber = default(int?), System.DateTimeOffset? startDate = default(System.DateTimeOffset?), System.DateTimeOffset? endDate = default(System.DateTimeOffset?), long? size = default(long?))
        {
            PartitionNumber = partitionNumber;
            StartDate = startDate;
            EndDate = endDate;
            Size = size;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PartitionNumber")]
        public int? PartitionNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StartDate")]
        public System.DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EndDate")]
        public System.DateTimeOffset? EndDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Size")]
        public long? Size { get; set; }

    }
}
