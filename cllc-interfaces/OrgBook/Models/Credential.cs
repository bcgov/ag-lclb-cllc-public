// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Credential
    {
        /// <summary>
        /// Initializes a new instance of the Credential class.
        /// </summary>
        public Credential()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Credential class.
        /// </summary>
        /// <param name="walletId">Wallet id</param>
        /// <param name="topic">Topic</param>
        /// <param name="credentialType">Credential type</param>
        /// <param name="id">ID</param>
        /// <param name="createTimestamp">Create timestamp</param>
        /// <param name="updateTimestamp">Update timestamp</param>
        /// <param name="credentialDefId">Credential def id</param>
        /// <param name="cardinalityHash">Cardinality hash</param>
        /// <param name="effectiveDate">Effective date</param>
        /// <param name="inactive">Inactive</param>
        /// <param name="latest">Latest</param>
        /// <param name="revoked">Revoked</param>
        /// <param name="revokedDate">Revoked date</param>
        /// <param name="credentialSet">Credential set</param>
        /// <param name="revokedBy">Revoked by</param>
        public Credential(string walletId, int topic, int credentialType, int? id = default(int?), System.DateTimeOffset? createTimestamp = default(System.DateTimeOffset?), System.DateTimeOffset? updateTimestamp = default(System.DateTimeOffset?), string credentialDefId = default(string), string cardinalityHash = default(string), System.DateTimeOffset? effectiveDate = default(System.DateTimeOffset?), bool? inactive = default(bool?), bool? latest = default(bool?), bool? revoked = default(bool?), System.DateTimeOffset? revokedDate = default(System.DateTimeOffset?), int? credentialSet = default(int?), int? revokedBy = default(int?), IList<int?> relatedTopics = default(IList<int?>))
        {
            Id = id;
            CreateTimestamp = createTimestamp;
            UpdateTimestamp = updateTimestamp;
            WalletId = walletId;
            CredentialDefId = credentialDefId;
            CardinalityHash = cardinalityHash;
            EffectiveDate = effectiveDate;
            Inactive = inactive;
            Latest = latest;
            Revoked = revoked;
            RevokedDate = revokedDate;
            Topic = topic;
            CredentialSet = credentialSet;
            CredentialType = credentialType;
            RevokedBy = revokedBy;
            RelatedTopics = relatedTopics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets create timestamp
        /// </summary>
        [JsonProperty(PropertyName = "create_timestamp")]
        public System.DateTimeOffset? CreateTimestamp { get; private set; }

        /// <summary>
        /// Gets update timestamp
        /// </summary>
        [JsonProperty(PropertyName = "update_timestamp")]
        public System.DateTimeOffset? UpdateTimestamp { get; private set; }

        /// <summary>
        /// Gets or sets wallet id
        /// </summary>
        [JsonProperty(PropertyName = "wallet_id")]
        public string WalletId { get; set; }

        /// <summary>
        /// Gets or sets credential def id
        /// </summary>
        [JsonProperty(PropertyName = "credential_def_id")]
        public string CredentialDefId { get; set; }

        /// <summary>
        /// Gets or sets cardinality hash
        /// </summary>
        [JsonProperty(PropertyName = "cardinality_hash")]
        public string CardinalityHash { get; set; }

        /// <summary>
        /// Gets or sets effective date
        /// </summary>
        [JsonProperty(PropertyName = "effective_date")]
        public System.DateTimeOffset? EffectiveDate { get; set; }

        /// <summary>
        /// Gets or sets inactive
        /// </summary>
        [JsonProperty(PropertyName = "inactive")]
        public bool? Inactive { get; set; }

        /// <summary>
        /// Gets or sets latest
        /// </summary>
        [JsonProperty(PropertyName = "latest")]
        public bool? Latest { get; set; }

        /// <summary>
        /// Gets or sets revoked
        /// </summary>
        [JsonProperty(PropertyName = "revoked")]
        public bool? Revoked { get; set; }

        /// <summary>
        /// Gets or sets revoked date
        /// </summary>
        [JsonProperty(PropertyName = "revoked_date")]
        public System.DateTimeOffset? RevokedDate { get; set; }

        /// <summary>
        /// Gets or sets topic
        /// </summary>
        [JsonProperty(PropertyName = "topic")]
        public int Topic { get; set; }

        /// <summary>
        /// Gets or sets credential set
        /// </summary>
        [JsonProperty(PropertyName = "credential_set")]
        public int? CredentialSet { get; set; }

        /// <summary>
        /// Gets or sets credential type
        /// </summary>
        [JsonProperty(PropertyName = "credential_type")]
        public int CredentialType { get; set; }

        /// <summary>
        /// Gets or sets revoked by
        /// </summary>
        [JsonProperty(PropertyName = "revoked_by")]
        public int? RevokedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "related_topics")]
        public IList<int?> RelatedTopics { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (WalletId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WalletId");
            }
            if (WalletId != null)
            {
                if (WalletId.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "WalletId", 1);
                }
            }
            if (CredentialDefId != null)
            {
                if (CredentialDefId.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "CredentialDefId", 1);
                }
            }
            if (CardinalityHash != null)
            {
                if (CardinalityHash.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "CardinalityHash", 1);
                }
            }
            if (RelatedTopics != null)
            {
                if (RelatedTopics.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(RelatedTopics)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "RelatedTopics");
                }
            }
        }
    }
}
