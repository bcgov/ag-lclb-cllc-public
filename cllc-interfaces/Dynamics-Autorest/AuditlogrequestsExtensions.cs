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
    /// Extension methods for Auditlogrequests.
    /// </summary>
    public static partial class AuditlogrequestsExtensions
    {
            /// <summary>
            /// Get entities from adoxio_auditlogrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
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
            public static MicrosoftDynamicsCRMadoxioAuditlogrequestCollection Get(this IAuditlogrequests operations, int? top = default(int?), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(top, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from adoxio_auditlogrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
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
            public static async Task<MicrosoftDynamicsCRMadoxioAuditlogrequestCollection> GetAsync(this IAuditlogrequests operations, int? top = default(int?), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(top, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entities from adoxio_auditlogrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioAuditlogrequestCollection> GetWithHttpMessages(this IAuditlogrequests operations, int? top = default(int?), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(top, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_auditlogrequests
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
            public static MicrosoftDynamicsCRMadoxioAuditlogrequest Create(this IAuditlogrequests operations, MicrosoftDynamicsCRMadoxioAuditlogrequest body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_auditlogrequests
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
            public static async Task<MicrosoftDynamicsCRMadoxioAuditlogrequest> CreateAsync(this IAuditlogrequests operations, MicrosoftDynamicsCRMadoxioAuditlogrequest body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to adoxio_auditlogrequests
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioAuditlogrequest> CreateWithHttpMessages(this IAuditlogrequests operations, MicrosoftDynamicsCRMadoxioAuditlogrequest body, string prefer = "return=representation", Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CreateWithHttpMessagesAsync(body, prefer, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_auditlogrequests by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAuditlogrequestid'>
            /// key: adoxio_auditlogrequestid of adoxio_auditlogrequest
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioAuditlogrequest GetByKey(this IAuditlogrequests operations, string adoxioAuditlogrequestid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetByKeyAsync(adoxioAuditlogrequestid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_auditlogrequests by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAuditlogrequestid'>
            /// key: adoxio_auditlogrequestid of adoxio_auditlogrequest
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
            public static async Task<MicrosoftDynamicsCRMadoxioAuditlogrequest> GetByKeyAsync(this IAuditlogrequests operations, string adoxioAuditlogrequestid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByKeyWithHttpMessagesAsync(adoxioAuditlogrequestid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from adoxio_auditlogrequests by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAuditlogrequestid'>
            /// key: adoxio_auditlogrequestid of adoxio_auditlogrequest
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioAuditlogrequest> GetByKeyWithHttpMessages(this IAuditlogrequests operations, string adoxioAuditlogrequestid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetByKeyWithHttpMessagesAsync(adoxioAuditlogrequestid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_auditlogrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAuditlogrequestid'>
            /// key: adoxio_auditlogrequestid of adoxio_auditlogrequest
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void Update(this IAuditlogrequests operations, string adoxioAuditlogrequestid, MicrosoftDynamicsCRMadoxioAuditlogrequest body)
            {
                operations.UpdateAsync(adoxioAuditlogrequestid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_auditlogrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAuditlogrequestid'>
            /// key: adoxio_auditlogrequestid of adoxio_auditlogrequest
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IAuditlogrequests operations, string adoxioAuditlogrequestid, MicrosoftDynamicsCRMadoxioAuditlogrequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(adoxioAuditlogrequestid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update entity in adoxio_auditlogrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAuditlogrequestid'>
            /// key: adoxio_auditlogrequestid of adoxio_auditlogrequest
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse UpdateWithHttpMessages(this IAuditlogrequests operations, string adoxioAuditlogrequestid, MicrosoftDynamicsCRMadoxioAuditlogrequest body, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.UpdateWithHttpMessagesAsync(adoxioAuditlogrequestid, body, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_auditlogrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAuditlogrequestid'>
            /// key: adoxio_auditlogrequestid of adoxio_auditlogrequest
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void Delete(this IAuditlogrequests operations, string adoxioAuditlogrequestid, string ifMatch = default(string))
            {
                operations.DeleteAsync(adoxioAuditlogrequestid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_auditlogrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAuditlogrequestid'>
            /// key: adoxio_auditlogrequestid of adoxio_auditlogrequest
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAuditlogrequests operations, string adoxioAuditlogrequestid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(adoxioAuditlogrequestid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete entity from adoxio_auditlogrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioAuditlogrequestid'>
            /// key: adoxio_auditlogrequestid of adoxio_auditlogrequest
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse DeleteWithHttpMessages(this IAuditlogrequests operations, string adoxioAuditlogrequestid, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.DeleteWithHttpMessagesAsync(adoxioAuditlogrequestid, ifMatch, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
