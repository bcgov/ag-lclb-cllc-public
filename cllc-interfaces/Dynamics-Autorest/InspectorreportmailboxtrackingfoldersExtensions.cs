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
    /// Extension methods for Inspectorreportmailboxtrackingfolders.
    /// </summary>
    public static partial class InspectorreportmailboxtrackingfoldersExtensions
    {
            /// <summary>
            /// Get adoxio_inspectorreport_MailboxTrackingFolders from
            /// adoxio_inspectorreports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioInspectorreportid'>
            /// key: adoxio_inspectorreportid of adoxio_inspectorreport
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
            public static MicrosoftDynamicsCRMmailboxtrackingfolderCollection Get(this IInspectorreportmailboxtrackingfolders operations, string adoxioInspectorreportid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioInspectorreportid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_inspectorreport_MailboxTrackingFolders from
            /// adoxio_inspectorreports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioInspectorreportid'>
            /// key: adoxio_inspectorreportid of adoxio_inspectorreport
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
            public static async Task<MicrosoftDynamicsCRMmailboxtrackingfolderCollection> GetAsync(this IInspectorreportmailboxtrackingfolders operations, string adoxioInspectorreportid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioInspectorreportid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_inspectorreport_MailboxTrackingFolders from
            /// adoxio_inspectorreports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioInspectorreportid'>
            /// key: adoxio_inspectorreportid of adoxio_inspectorreport
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMmailboxtrackingfolderCollection> GetWithHttpMessages(this IInspectorreportmailboxtrackingfolders operations, string adoxioInspectorreportid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioInspectorreportid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_inspectorreport_MailboxTrackingFolders from
            /// adoxio_inspectorreports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioInspectorreportid'>
            /// key: adoxio_inspectorreportid of adoxio_inspectorreport
            /// </param>
            /// <param name='mailboxtrackingfolderid'>
            /// key: mailboxtrackingfolderid of mailboxtrackingfolder
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMmailboxtrackingfolder MailboxTrackingFoldersByKey(this IInspectorreportmailboxtrackingfolders operations, string adoxioInspectorreportid, string mailboxtrackingfolderid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.MailboxTrackingFoldersByKeyAsync(adoxioInspectorreportid, mailboxtrackingfolderid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_inspectorreport_MailboxTrackingFolders from
            /// adoxio_inspectorreports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioInspectorreportid'>
            /// key: adoxio_inspectorreportid of adoxio_inspectorreport
            /// </param>
            /// <param name='mailboxtrackingfolderid'>
            /// key: mailboxtrackingfolderid of mailboxtrackingfolder
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
            public static async Task<MicrosoftDynamicsCRMmailboxtrackingfolder> MailboxTrackingFoldersByKeyAsync(this IInspectorreportmailboxtrackingfolders operations, string adoxioInspectorreportid, string mailboxtrackingfolderid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.MailboxTrackingFoldersByKeyWithHttpMessagesAsync(adoxioInspectorreportid, mailboxtrackingfolderid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_inspectorreport_MailboxTrackingFolders from
            /// adoxio_inspectorreports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioInspectorreportid'>
            /// key: adoxio_inspectorreportid of adoxio_inspectorreport
            /// </param>
            /// <param name='mailboxtrackingfolderid'>
            /// key: mailboxtrackingfolderid of mailboxtrackingfolder
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMmailboxtrackingfolder> MailboxTrackingFoldersByKeyWithHttpMessages(this IInspectorreportmailboxtrackingfolders operations, string adoxioInspectorreportid, string mailboxtrackingfolderid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.MailboxTrackingFoldersByKeyWithHttpMessagesAsync(adoxioInspectorreportid, mailboxtrackingfolderid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
