// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.CreateSession
{
    /// <summary>
    /// Provides operations to call the createSession method.
    /// </summary>
    public class CreateSessionRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="CreateSessionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CreateSessionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/items/{driveItem%2Did}/workbook/createSession", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CreateSessionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CreateSessionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/items/{driveItem%2Did}/workbook/createSession", rawUrl)
        {
        }
        /// <summary>
        /// Create a new workbook session.  Excel APIs can be called in one of two modes:  To represent the session in the API, use the workbook-session-id: {session-id} header.  In some cases, creating a new session requires an indeterminate time to complete. Microsoft Graph also provides a long running operations pattern. This pattern provides a way to poll for creation status updates, without waiting for the creation to complete. The following are the steps:
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/workbook-createsession?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="WorkbookSessionInfo"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WorkbookSessionInfo?> PostAsync(CreateSessionPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<WorkbookSessionInfo> PostAsync(CreateSessionPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<WorkbookSessionInfo>(requestInfo, WorkbookSessionInfo.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new workbook session.  Excel APIs can be called in one of two modes:  To represent the session in the API, use the workbook-session-id: {session-id} header.  In some cases, creating a new session requires an indeterminate time to complete. Microsoft Graph also provides a long running operations pattern. This pattern provides a way to poll for creation status updates, without waiting for the creation to complete. The following are the steps:
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(CreateSessionPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(CreateSessionPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="CreateSessionRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CreateSessionRequestBuilder WithUrl(string rawUrl)
        {
            return new CreateSessionRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CreateSessionRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
