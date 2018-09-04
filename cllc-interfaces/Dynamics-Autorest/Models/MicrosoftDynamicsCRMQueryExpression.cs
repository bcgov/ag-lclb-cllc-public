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
    /// QueryExpression
    /// </summary>
    public partial class MicrosoftDynamicsCRMQueryExpression
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMQueryExpression class.
        /// </summary>
        public MicrosoftDynamicsCRMQueryExpression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMQueryExpression class.
        /// </summary>
        public MicrosoftDynamicsCRMQueryExpression(bool? distinct = default(bool?), bool? noLock = default(bool?), MicrosoftDynamicsCRMPagingInfo pageInfo = default(MicrosoftDynamicsCRMPagingInfo), IList<MicrosoftDynamicsCRMLinkEntity> linkEntities = default(IList<MicrosoftDynamicsCRMLinkEntity>), MicrosoftDynamicsCRMFilterExpression criteria = default(MicrosoftDynamicsCRMFilterExpression), IList<MicrosoftDynamicsCRMOrderExpression> orders = default(IList<MicrosoftDynamicsCRMOrderExpression>), string entityName = default(string), MicrosoftDynamicsCRMColumnSet columnSet = default(MicrosoftDynamicsCRMColumnSet), int? topCount = default(int?))
        {
            Distinct = distinct;
            NoLock = noLock;
            PageInfo = pageInfo;
            LinkEntities = linkEntities;
            Criteria = criteria;
            Orders = orders;
            EntityName = entityName;
            ColumnSet = columnSet;
            TopCount = topCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Distinct")]
        public bool? Distinct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NoLock")]
        public bool? NoLock { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PageInfo")]
        public MicrosoftDynamicsCRMPagingInfo PageInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LinkEntities")]
        public IList<MicrosoftDynamicsCRMLinkEntity> LinkEntities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Criteria")]
        public MicrosoftDynamicsCRMFilterExpression Criteria { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Orders")]
        public IList<MicrosoftDynamicsCRMOrderExpression> Orders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityName")]
        public string EntityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ColumnSet")]
        public MicrosoftDynamicsCRMColumnSet ColumnSet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TopCount")]
        public int? TopCount { get; set; }

    }
}
