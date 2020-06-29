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
    /// Extension methods for Licencetypeid.
    /// </summary>
    public static partial class LicencetypeidExtensions
    {
            /// <summary>
            /// Get adoxio_LicenceTypeId from adoxio_contraventionadmins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioContraventionadminid'>
            /// key: adoxio_contraventionadminid of adoxio_contraventionadmin
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioLicencetype Get(this ILicencetypeid operations, string adoxioContraventionadminid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioContraventionadminid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_LicenceTypeId from adoxio_contraventionadmins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioContraventionadminid'>
            /// key: adoxio_contraventionadminid of adoxio_contraventionadmin
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
            public static async Task<MicrosoftDynamicsCRMadoxioLicencetype> GetAsync(this ILicencetypeid operations, string adoxioContraventionadminid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioContraventionadminid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_LicenceTypeId from adoxio_contraventionadmins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioContraventionadminid'>
            /// key: adoxio_contraventionadminid of adoxio_contraventionadmin
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioLicencetype> GetWithHttpMessages(this ILicencetypeid operations, string adoxioContraventionadminid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioContraventionadminid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_LicenceTypeId from adoxio_enforcementactions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEnforcementactionid'>
            /// key: adoxio_enforcementactionid of adoxio_enforcementaction
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioLicencetype Get1(this ILicencetypeid operations, string adoxioEnforcementactionid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.Get1Async(adoxioEnforcementactionid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_LicenceTypeId from adoxio_enforcementactions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEnforcementactionid'>
            /// key: adoxio_enforcementactionid of adoxio_enforcementaction
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
            public static async Task<MicrosoftDynamicsCRMadoxioLicencetype> Get1Async(this ILicencetypeid operations, string adoxioEnforcementactionid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Get1WithHttpMessagesAsync(adoxioEnforcementactionid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_LicenceTypeId from adoxio_enforcementactions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEnforcementactionid'>
            /// key: adoxio_enforcementactionid of adoxio_enforcementaction
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioLicencetype> Get1WithHttpMessages(this ILicencetypeid operations, string adoxioEnforcementactionid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.Get1WithHttpMessagesAsync(adoxioEnforcementactionid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
