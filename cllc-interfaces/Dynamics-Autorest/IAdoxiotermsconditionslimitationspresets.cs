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
    /// Adoxiotermsconditionslimitationspresets operations.
    /// </summary>
    public partial interface IAdoxiotermsconditionslimitationspresets
    {
        /// <summary>
        /// Get entities from adoxio_termsconditionslimitationspresets
        /// </summary>
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
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="OdataerrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<MicrosoftDynamicsCRMadoxioTermsconditionslimitationspresetCollection>> GetWithHttpMessagesAsync(IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add new entity to adoxio_termsconditionslimitationspresets
        /// </summary>
        /// <param name='body'>
        /// New entity
        /// </param>
        /// <param name='prefer'>
        /// Required in order for the service to return a JSON representation
        /// of the object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="OdataerrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset>> CreateWithHttpMessagesAsync(MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset body, string prefer = "return=representation", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get entity from adoxio_termsconditionslimitationspresets by key
        /// </summary>
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
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="OdataerrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset>> TermsconditionslimitationspresetsByKeyWithHttpMessagesAsync(System.Guid adoxioTermsconditionslimitationspresetid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update entity in adoxio_termsconditionslimitationspresets
        /// </summary>
        /// <param name='adoxioTermsconditionslimitationspresetid'>
        /// key: adoxio_termsconditionslimitationspresetid of
        /// adoxio_termsconditionslimitationspreset
        /// </param>
        /// <param name='body'>
        /// New property values
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="OdataerrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> TermsconditionslimitationspresetsByKey1WithHttpMessagesAsync(System.Guid adoxioTermsconditionslimitationspresetid, MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete entity from adoxio_termsconditionslimitationspresets
        /// </summary>
        /// <param name='adoxioTermsconditionslimitationspresetid'>
        /// key: adoxio_termsconditionslimitationspresetid of
        /// adoxio_termsconditionslimitationspreset
        /// </param>
        /// <param name='ifMatch'>
        /// ETag
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="OdataerrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> TermsconditionslimitationspresetsByKey2WithHttpMessagesAsync(System.Guid adoxioTermsconditionslimitationspresetid, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
