// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Adoxio.
    /// </summary>
    public static partial class AdoxioExtensions
    {
            /// <summary>
            /// Update entity in adoxio_legalentities
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLegalentityid'>
            /// key: adoxio_legalentityid
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void Legalentities(this IAdoxio operations, string adoxioLegalentityid, MicrosoftDynamicsCRMadoxioLegalentity body)
            {
                operations.LegalentitiesAsync(adoxioLegalentityid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_legalentities
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLegalentityid'>
            /// key: adoxio_legalentityid
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task LegalentitiesAsync(this IAdoxio operations, string adoxioLegalentityid, MicrosoftDynamicsCRMadoxioLegalentity body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.LegalentitiesWithHttpMessagesAsync(adoxioLegalentityid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
