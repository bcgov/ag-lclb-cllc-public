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
    /// Extension methods for Asyncoperationidadoxiolqrlicencetransferbpf.
    /// </summary>
    public static partial class AsyncoperationidadoxiolqrlicencetransferbpfExtensions
    {
            /// <summary>
            /// Get asyncoperationid_adoxio_lqrlicencetransferbpf from workflowlogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workflowlogid'>
            /// key: workflowlogid of workflowlog
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioLqrlicencetransferbpf Get(this IAsyncoperationidadoxiolqrlicencetransferbpf operations, string workflowlogid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(workflowlogid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get asyncoperationid_adoxio_lqrlicencetransferbpf from workflowlogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workflowlogid'>
            /// key: workflowlogid of workflowlog
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
            public static async Task<MicrosoftDynamicsCRMadoxioLqrlicencetransferbpf> GetAsync(this IAsyncoperationidadoxiolqrlicencetransferbpf operations, string workflowlogid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(workflowlogid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get asyncoperationid_adoxio_lqrlicencetransferbpf from workflowlogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workflowlogid'>
            /// key: workflowlogid of workflowlog
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioLqrlicencetransferbpf> GetWithHttpMessages(this IAsyncoperationidadoxiolqrlicencetransferbpf operations, string workflowlogid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(workflowlogid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
