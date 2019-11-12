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
    /// Extension methods for Adoxiocannabisinventoryreports.
    /// </summary>
    public static partial class AdoxiocannabisinventoryreportsExtensions
    {
            /// <summary>
            /// Get entities from adoxio_cannabisinventoryreports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
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
            public static MicrosoftDynamicsCRMadoxioCannabisinventoryreportCollection Get(this IAdoxiocannabisinventoryreports operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from adoxio_cannabisinventoryreports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
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
            public static async Task<MicrosoftDynamicsCRMadoxioCannabisinventoryreportCollection> GetAsync(this IAdoxiocannabisinventoryreports operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entities from adoxio_cannabisinventoryreports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioCannabisinventoryreportCollection> GetWithHttpMessages(this IAdoxiocannabisinventoryreports operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_cannabisinventoryreports
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
            public static MicrosoftDynamicsCRMadoxioCannabisinventoryreport Create(this IAdoxiocannabisinventoryreports operations, MicrosoftDynamicsCRMadoxioCannabisinventoryreport body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_cannabisinventoryreports
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
            public static async Task<MicrosoftDynamicsCRMadoxioCannabisinventoryreport> CreateAsync(this IAdoxiocannabisinventoryreports operations, MicrosoftDynamicsCRMadoxioCannabisinventoryreport body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to adoxio_cannabisinventoryreports
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioCannabisinventoryreport> CreateWithHttpMessages(this IAdoxiocannabisinventoryreports operations, MicrosoftDynamicsCRMadoxioCannabisinventoryreport body, string prefer = "return=representation", Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CreateWithHttpMessagesAsync(body, prefer, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_cannabisinventoryreports by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCannabisinventoryreportid'>
            /// key: adoxio_cannabisinventoryreportid of adoxio_cannabisinventoryreport
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioCannabisinventoryreport CannabisinventoryreportsByKey(this IAdoxiocannabisinventoryreports operations, System.Guid adoxioCannabisinventoryreportid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.CannabisinventoryreportsByKeyAsync(adoxioCannabisinventoryreportid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_cannabisinventoryreports by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCannabisinventoryreportid'>
            /// key: adoxio_cannabisinventoryreportid of adoxio_cannabisinventoryreport
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
            public static async Task<MicrosoftDynamicsCRMadoxioCannabisinventoryreport> CannabisinventoryreportsByKeyAsync(this IAdoxiocannabisinventoryreports operations, System.Guid adoxioCannabisinventoryreportid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CannabisinventoryreportsByKeyWithHttpMessagesAsync(adoxioCannabisinventoryreportid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from adoxio_cannabisinventoryreports by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCannabisinventoryreportid'>
            /// key: adoxio_cannabisinventoryreportid of adoxio_cannabisinventoryreport
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioCannabisinventoryreport> CannabisinventoryreportsByKeyWithHttpMessages(this IAdoxiocannabisinventoryreports operations, System.Guid adoxioCannabisinventoryreportid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CannabisinventoryreportsByKeyWithHttpMessagesAsync(adoxioCannabisinventoryreportid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_cannabisinventoryreports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCannabisinventoryreportid'>
            /// key: adoxio_cannabisinventoryreportid of adoxio_cannabisinventoryreport
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void CannabisinventoryreportsByKey1(this IAdoxiocannabisinventoryreports operations, System.Guid adoxioCannabisinventoryreportid, MicrosoftDynamicsCRMadoxioCannabisinventoryreport body)
            {
                operations.CannabisinventoryreportsByKey1Async(adoxioCannabisinventoryreportid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_cannabisinventoryreports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCannabisinventoryreportid'>
            /// key: adoxio_cannabisinventoryreportid of adoxio_cannabisinventoryreport
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CannabisinventoryreportsByKey1Async(this IAdoxiocannabisinventoryreports operations, System.Guid adoxioCannabisinventoryreportid, MicrosoftDynamicsCRMadoxioCannabisinventoryreport body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CannabisinventoryreportsByKey1WithHttpMessagesAsync(adoxioCannabisinventoryreportid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update entity in adoxio_cannabisinventoryreports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCannabisinventoryreportid'>
            /// key: adoxio_cannabisinventoryreportid of adoxio_cannabisinventoryreport
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse CannabisinventoryreportsByKey1WithHttpMessages(this IAdoxiocannabisinventoryreports operations, System.Guid adoxioCannabisinventoryreportid, MicrosoftDynamicsCRMadoxioCannabisinventoryreport body, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CannabisinventoryreportsByKey1WithHttpMessagesAsync(adoxioCannabisinventoryreportid, body, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_cannabisinventoryreports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCannabisinventoryreportid'>
            /// key: adoxio_cannabisinventoryreportid of adoxio_cannabisinventoryreport
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void CannabisinventoryreportsByKey2(this IAdoxiocannabisinventoryreports operations, System.Guid adoxioCannabisinventoryreportid, string ifMatch = default(string))
            {
                operations.CannabisinventoryreportsByKey2Async(adoxioCannabisinventoryreportid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_cannabisinventoryreports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCannabisinventoryreportid'>
            /// key: adoxio_cannabisinventoryreportid of adoxio_cannabisinventoryreport
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CannabisinventoryreportsByKey2Async(this IAdoxiocannabisinventoryreports operations, System.Guid adoxioCannabisinventoryreportid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CannabisinventoryreportsByKey2WithHttpMessagesAsync(adoxioCannabisinventoryreportid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete entity from adoxio_cannabisinventoryreports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCannabisinventoryreportid'>
            /// key: adoxio_cannabisinventoryreportid of adoxio_cannabisinventoryreport
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse CannabisinventoryreportsByKey2WithHttpMessages(this IAdoxiocannabisinventoryreports operations, System.Guid adoxioCannabisinventoryreportid, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CannabisinventoryreportsByKey2WithHttpMessagesAsync(adoxioCannabisinventoryreportid, ifMatch, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
