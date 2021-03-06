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
    /// Extension methods for Complaintinvestigationrequests.
    /// </summary>
    public static partial class ComplaintinvestigationrequestsExtensions
    {
            /// <summary>
            /// Get adoxio_complaint_investigationrequests from adoxio_complaints
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioComplaintid'>
            /// key: adoxio_complaintid of adoxio_complaint
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
            public static MicrosoftDynamicsCRMadoxioInvestigationrequestCollection Get(this IComplaintinvestigationrequests operations, string adoxioComplaintid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioComplaintid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_complaint_investigationrequests from adoxio_complaints
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioComplaintid'>
            /// key: adoxio_complaintid of adoxio_complaint
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
            public static async Task<MicrosoftDynamicsCRMadoxioInvestigationrequestCollection> GetAsync(this IComplaintinvestigationrequests operations, string adoxioComplaintid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioComplaintid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_complaint_investigationrequests from adoxio_complaints
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioComplaintid'>
            /// key: adoxio_complaintid of adoxio_complaint
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioInvestigationrequestCollection> GetWithHttpMessages(this IComplaintinvestigationrequests operations, string adoxioComplaintid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioComplaintid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_complaint_investigationrequests from adoxio_complaints
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioComplaintid'>
            /// key: adoxio_complaintid of adoxio_complaint
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
            public static MicrosoftDynamicsCRMadoxioInvestigationrequest InvestigationrequestsByKey(this IComplaintinvestigationrequests operations, string adoxioComplaintid, string adoxioInvestigationrequestid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.InvestigationrequestsByKeyAsync(adoxioComplaintid, adoxioInvestigationrequestid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_complaint_investigationrequests from adoxio_complaints
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioComplaintid'>
            /// key: adoxio_complaintid of adoxio_complaint
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
            public static async Task<MicrosoftDynamicsCRMadoxioInvestigationrequest> InvestigationrequestsByKeyAsync(this IComplaintinvestigationrequests operations, string adoxioComplaintid, string adoxioInvestigationrequestid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.InvestigationrequestsByKeyWithHttpMessagesAsync(adoxioComplaintid, adoxioInvestigationrequestid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_complaint_investigationrequests from adoxio_complaints
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioComplaintid'>
            /// key: adoxio_complaintid of adoxio_complaint
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioInvestigationrequest> InvestigationrequestsByKeyWithHttpMessages(this IComplaintinvestigationrequests operations, string adoxioComplaintid, string adoxioInvestigationrequestid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.InvestigationrequestsByKeyWithHttpMessagesAsync(adoxioComplaintid, adoxioInvestigationrequestid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
