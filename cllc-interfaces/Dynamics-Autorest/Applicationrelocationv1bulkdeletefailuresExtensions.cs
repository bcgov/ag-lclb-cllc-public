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
    /// Extension methods for Applicationrelocationv1bulkdeletefailures.
    /// </summary>
    public static partial class Applicationrelocationv1bulkdeletefailuresExtensions
    {
            /// <summary>
            /// Get adoxio_applicationrelocationv1_BulkDeleteFailures from
            /// adoxio_applicationrelocationv1s
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='businessprocessflowinstanceid'>
            /// key: businessprocessflowinstanceid of adoxio_applicationrelocationv1
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
            public static MicrosoftDynamicsCRMbulkdeletefailureCollection Get(this IApplicationrelocationv1bulkdeletefailures operations, string businessprocessflowinstanceid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(businessprocessflowinstanceid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_applicationrelocationv1_BulkDeleteFailures from
            /// adoxio_applicationrelocationv1s
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='businessprocessflowinstanceid'>
            /// key: businessprocessflowinstanceid of adoxio_applicationrelocationv1
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
            public static async Task<MicrosoftDynamicsCRMbulkdeletefailureCollection> GetAsync(this IApplicationrelocationv1bulkdeletefailures operations, string businessprocessflowinstanceid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(businessprocessflowinstanceid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_applicationrelocationv1_BulkDeleteFailures from
            /// adoxio_applicationrelocationv1s
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='businessprocessflowinstanceid'>
            /// key: businessprocessflowinstanceid of adoxio_applicationrelocationv1
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMbulkdeletefailureCollection> GetWithHttpMessages(this IApplicationrelocationv1bulkdeletefailures operations, string businessprocessflowinstanceid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(businessprocessflowinstanceid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_applicationrelocationv1_BulkDeleteFailures from
            /// adoxio_applicationrelocationv1s
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='businessprocessflowinstanceid'>
            /// key: businessprocessflowinstanceid of adoxio_applicationrelocationv1
            /// </param>
            /// <param name='bulkdeletefailureid'>
            /// key: bulkdeletefailureid of bulkdeletefailure
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMbulkdeletefailure BulkDeleteFailuresByKey(this IApplicationrelocationv1bulkdeletefailures operations, string businessprocessflowinstanceid, string bulkdeletefailureid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.BulkDeleteFailuresByKeyAsync(businessprocessflowinstanceid, bulkdeletefailureid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_applicationrelocationv1_BulkDeleteFailures from
            /// adoxio_applicationrelocationv1s
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='businessprocessflowinstanceid'>
            /// key: businessprocessflowinstanceid of adoxio_applicationrelocationv1
            /// </param>
            /// <param name='bulkdeletefailureid'>
            /// key: bulkdeletefailureid of bulkdeletefailure
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
            public static async Task<MicrosoftDynamicsCRMbulkdeletefailure> BulkDeleteFailuresByKeyAsync(this IApplicationrelocationv1bulkdeletefailures operations, string businessprocessflowinstanceid, string bulkdeletefailureid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BulkDeleteFailuresByKeyWithHttpMessagesAsync(businessprocessflowinstanceid, bulkdeletefailureid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_applicationrelocationv1_BulkDeleteFailures from
            /// adoxio_applicationrelocationv1s
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='businessprocessflowinstanceid'>
            /// key: businessprocessflowinstanceid of adoxio_applicationrelocationv1
            /// </param>
            /// <param name='bulkdeletefailureid'>
            /// key: bulkdeletefailureid of bulkdeletefailure
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMbulkdeletefailure> BulkDeleteFailuresByKeyWithHttpMessages(this IApplicationrelocationv1bulkdeletefailures operations, string businessprocessflowinstanceid, string bulkdeletefailureid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.BulkDeleteFailuresByKeyWithHttpMessagesAsync(businessprocessflowinstanceid, bulkdeletefailureid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
