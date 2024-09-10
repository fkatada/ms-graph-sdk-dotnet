// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.Subject;
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.TaskProcessingResults;
using Microsoft.Graph.Models.IdentityGovernance;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item
{
    /// <summary>
    /// Provides operations to manage the userProcessingResults property of the microsoft.graph.identityGovernance.workflow entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class UserProcessingResultItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the subject property of the microsoft.graph.identityGovernance.userProcessingResult entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.Subject.SubjectRequestBuilder Subject
        {
            get => new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.Subject.SubjectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the taskProcessingResults property of the microsoft.graph.identityGovernance.userProcessingResult entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.TaskProcessingResults.TaskProcessingResultsRequestBuilder TaskProcessingResults
        {
            get => new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.TaskProcessingResults.TaskProcessingResultsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.UserProcessingResultItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserProcessingResultItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/lifecycleWorkflows/workflows/{workflow%2Did}/userProcessingResults/{userProcessingResult%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.UserProcessingResultItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserProcessingResultItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/lifecycleWorkflows/workflows/{workflow%2Did}/userProcessingResults/{userProcessingResult%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Per-user workflow execution results.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResult"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResult?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.UserProcessingResultItemRequestBuilder.UserProcessingResultItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResult> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.UserProcessingResultItemRequestBuilder.UserProcessingResultItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResult>(requestInfo, global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResult.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Per-user workflow execution results.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.UserProcessingResultItemRequestBuilder.UserProcessingResultItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.UserProcessingResultItemRequestBuilder.UserProcessingResultItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.UserProcessingResultItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.UserProcessingResultItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.UserProcessingResultItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Per-user workflow execution results.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class UserProcessingResultItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class UserProcessingResultItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.Item.UserProcessingResultItemRequestBuilder.UserProcessingResultItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
