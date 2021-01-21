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
    /// Extension methods for Contraventioninvestigationrequests.
    /// </summary>
    public static partial class ContraventioninvestigationrequestsExtensions
    {
            /// <summary>
            /// Get adoxio_contravention_investigationrequests from
            /// adoxio_contraventionadmins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioContraventionadminid'>
            /// key: adoxio_contraventionadminid of adoxio_contraventionadmin
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
            public static MicrosoftDynamicsCRMadoxioInvestigationrequestCollection Get(this IContraventioninvestigationrequests operations, string adoxioContraventionadminid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioContraventionadminid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_contravention_investigationrequests from
            /// adoxio_contraventionadmins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioContraventionadminid'>
            /// key: adoxio_contraventionadminid of adoxio_contraventionadmin
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
            public static async Task<MicrosoftDynamicsCRMadoxioInvestigationrequestCollection> GetAsync(this IContraventioninvestigationrequests operations, string adoxioContraventionadminid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioContraventionadminid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_contravention_investigationrequests from
            /// adoxio_contraventionadmins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioContraventionadminid'>
            /// key: adoxio_contraventionadminid of adoxio_contraventionadmin
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioInvestigationrequestCollection> GetWithHttpMessages(this IContraventioninvestigationrequests operations, string adoxioContraventionadminid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioContraventionadminid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_contravention_investigationrequests from
            /// adoxio_contraventionadmins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioContraventionadminid'>
            /// key: adoxio_contraventionadminid of adoxio_contraventionadmin
            /// </param>
            /// <param name='adoxioInvestigationrequestid'>
            /// key: adoxio_investigationrequestid of adoxio_investigationrequest
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioInvestigationrequest InvestigationrequestsByKey(this IContraventioninvestigationrequests operations, string adoxioContraventionadminid, string adoxioInvestigationrequestid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.InvestigationrequestsByKeyAsync(adoxioContraventionadminid, adoxioInvestigationrequestid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_contravention_investigationrequests from
            /// adoxio_contraventionadmins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioContraventionadminid'>
            /// key: adoxio_contraventionadminid of adoxio_contraventionadmin
            /// </param>
            /// <param name='adoxioInvestigationrequestid'>
            /// key: adoxio_investigationrequestid of adoxio_investigationrequest
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
            public static async Task<MicrosoftDynamicsCRMadoxioInvestigationrequest> InvestigationrequestsByKeyAsync(this IContraventioninvestigationrequests operations, string adoxioContraventionadminid, string adoxioInvestigationrequestid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.InvestigationrequestsByKeyWithHttpMessagesAsync(adoxioContraventionadminid, adoxioInvestigationrequestid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_contravention_investigationrequests from
            /// adoxio_contraventionadmins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioContraventionadminid'>
            /// key: adoxio_contraventionadminid of adoxio_contraventionadmin
            /// </param>
            /// <param name='adoxioInvestigationrequestid'>
            /// key: adoxio_investigationrequestid of adoxio_investigationrequest
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioInvestigationrequest> InvestigationrequestsByKeyWithHttpMessages(this IContraventioninvestigationrequests operations, string adoxioContraventionadminid, string adoxioInvestigationrequestid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.InvestigationrequestsByKeyWithHttpMessagesAsync(adoxioContraventionadminid, adoxioInvestigationrequestid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
