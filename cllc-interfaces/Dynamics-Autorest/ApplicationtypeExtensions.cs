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
    /// Extension methods for Applicationtype.
    /// </summary>
    public static partial class ApplicationtypeExtensions
    {
            /// <summary>
            /// Get adoxio_ApplicationType from adoxio_proratedlicencefeeschedules
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioProratedlicencefeescheduleid'>
            /// key: adoxio_proratedlicencefeescheduleid of
            /// adoxio_proratedlicencefeeschedule
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioApplicationtype Get(this IApplicationtype operations, string adoxioProratedlicencefeescheduleid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioProratedlicencefeescheduleid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_ApplicationType from adoxio_proratedlicencefeeschedules
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioProratedlicencefeescheduleid'>
            /// key: adoxio_proratedlicencefeescheduleid of
            /// adoxio_proratedlicencefeeschedule
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
            public static async Task<MicrosoftDynamicsCRMadoxioApplicationtype> GetAsync(this IApplicationtype operations, string adoxioProratedlicencefeescheduleid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioProratedlicencefeescheduleid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_ApplicationType from adoxio_proratedlicencefeeschedules
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioProratedlicencefeescheduleid'>
            /// key: adoxio_proratedlicencefeescheduleid of
            /// adoxio_proratedlicencefeeschedule
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioApplicationtype> GetWithHttpMessages(this IApplicationtype operations, string adoxioProratedlicencefeescheduleid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioProratedlicencefeescheduleid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_ApplicationType from adoxio_termsconditionslimitationspresets
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTermsconditionslimitationspresetid'>
            /// key: adoxio_termsconditionslimitationspresetid of
            /// adoxio_termsconditionslimitationspreset
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioApplicationtype Get1(this IApplicationtype operations, string adoxioTermsconditionslimitationspresetid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.Get1Async(adoxioTermsconditionslimitationspresetid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_ApplicationType from adoxio_termsconditionslimitationspresets
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTermsconditionslimitationspresetid'>
            /// key: adoxio_termsconditionslimitationspresetid of
            /// adoxio_termsconditionslimitationspreset
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
            public static async Task<MicrosoftDynamicsCRMadoxioApplicationtype> Get1Async(this IApplicationtype operations, string adoxioTermsconditionslimitationspresetid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Get1WithHttpMessagesAsync(adoxioTermsconditionslimitationspresetid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_ApplicationType from adoxio_termsconditionslimitationspresets
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTermsconditionslimitationspresetid'>
            /// key: adoxio_termsconditionslimitationspresetid of
            /// adoxio_termsconditionslimitationspreset
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioApplicationtype> Get1WithHttpMessages(this IApplicationtype operations, string adoxioTermsconditionslimitationspresetid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.Get1WithHttpMessagesAsync(adoxioTermsconditionslimitationspresetid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
