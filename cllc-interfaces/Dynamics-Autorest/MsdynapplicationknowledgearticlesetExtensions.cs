// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Msdynapplicationknowledgearticleset.
    /// </summary>
    public static partial class MsdynapplicationknowledgearticlesetExtensions
    {
            /// <summary>
            /// Get entities from msdyn_adoxio_application_knowledgearticleset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MsdynapplicationknowledgearticlesetGetResponseModel Get(this IMsdynapplicationknowledgearticleset operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from msdyn_adoxio_application_knowledgearticleset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MsdynapplicationknowledgearticlesetGetResponseModel> GetAsync(this IMsdynapplicationknowledgearticleset operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entities from msdyn_adoxio_application_knowledgearticleset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MsdynapplicationknowledgearticlesetGetResponseModel> GetWithHttpMessages(this IMsdynapplicationknowledgearticleset operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to msdyn_adoxio_application_knowledgearticleset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            public static MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle Create(this IMsdynapplicationknowledgearticleset operations, MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to msdyn_adoxio_application_knowledgearticleset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle> CreateAsync(this IMsdynapplicationknowledgearticleset operations, MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to msdyn_adoxio_application_knowledgearticleset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle> CreateWithHttpMessages(this IMsdynapplicationknowledgearticleset operations, MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle body, string prefer = "return=representation", Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CreateWithHttpMessagesAsync(body, prefer, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from msdyn_adoxio_application_knowledgearticleset by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='msdynAdoxioApplicationKnowledgearticleid'>
            /// key: msdyn_adoxio_application_knowledgearticleid
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle GetByKey(this IMsdynapplicationknowledgearticleset operations, string msdynAdoxioApplicationKnowledgearticleid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetByKeyAsync(msdynAdoxioApplicationKnowledgearticleid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from msdyn_adoxio_application_knowledgearticleset by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='msdynAdoxioApplicationKnowledgearticleid'>
            /// key: msdyn_adoxio_application_knowledgearticleid
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle> GetByKeyAsync(this IMsdynapplicationknowledgearticleset operations, string msdynAdoxioApplicationKnowledgearticleid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByKeyWithHttpMessagesAsync(msdynAdoxioApplicationKnowledgearticleid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from msdyn_adoxio_application_knowledgearticleset by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='msdynAdoxioApplicationKnowledgearticleid'>
            /// key: msdyn_adoxio_application_knowledgearticleid
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle> GetByKeyWithHttpMessages(this IMsdynapplicationknowledgearticleset operations, string msdynAdoxioApplicationKnowledgearticleid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetByKeyWithHttpMessagesAsync(msdynAdoxioApplicationKnowledgearticleid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from msdyn_adoxio_application_knowledgearticleset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='msdynAdoxioApplicationKnowledgearticleid'>
            /// key: msdyn_adoxio_application_knowledgearticleid
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void Delete(this IMsdynapplicationknowledgearticleset operations, string msdynAdoxioApplicationKnowledgearticleid, string ifMatch = default(string))
            {
                operations.DeleteAsync(msdynAdoxioApplicationKnowledgearticleid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from msdyn_adoxio_application_knowledgearticleset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='msdynAdoxioApplicationKnowledgearticleid'>
            /// key: msdyn_adoxio_application_knowledgearticleid
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IMsdynapplicationknowledgearticleset operations, string msdynAdoxioApplicationKnowledgearticleid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(msdynAdoxioApplicationKnowledgearticleid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete entity from msdyn_adoxio_application_knowledgearticleset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='msdynAdoxioApplicationKnowledgearticleid'>
            /// key: msdyn_adoxio_application_knowledgearticleid
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse DeleteWithHttpMessages(this IMsdynapplicationknowledgearticleset operations, string msdynAdoxioApplicationKnowledgearticleid, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.DeleteWithHttpMessagesAsync(msdynAdoxioApplicationKnowledgearticleid, ifMatch, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in msdyn_adoxio_application_knowledgearticleset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='msdynAdoxioApplicationKnowledgearticleid'>
            /// key: msdyn_adoxio_application_knowledgearticleid
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void Update(this IMsdynapplicationknowledgearticleset operations, string msdynAdoxioApplicationKnowledgearticleid, MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle body)
            {
                operations.UpdateAsync(msdynAdoxioApplicationKnowledgearticleid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in msdyn_adoxio_application_knowledgearticleset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='msdynAdoxioApplicationKnowledgearticleid'>
            /// key: msdyn_adoxio_application_knowledgearticleid
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IMsdynapplicationknowledgearticleset operations, string msdynAdoxioApplicationKnowledgearticleid, MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(msdynAdoxioApplicationKnowledgearticleid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update entity in msdyn_adoxio_application_knowledgearticleset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='msdynAdoxioApplicationKnowledgearticleid'>
            /// key: msdyn_adoxio_application_knowledgearticleid
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse UpdateWithHttpMessages(this IMsdynapplicationknowledgearticleset operations, string msdynAdoxioApplicationKnowledgearticleid, MicrosoftDynamicsCRMmsdynAdoxioApplicationKnowledgearticle body, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.UpdateWithHttpMessagesAsync(msdynAdoxioApplicationKnowledgearticleid, body, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
