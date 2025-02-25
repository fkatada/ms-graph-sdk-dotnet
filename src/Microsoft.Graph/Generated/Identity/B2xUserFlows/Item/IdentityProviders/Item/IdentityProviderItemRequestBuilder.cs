// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Identity.B2xUserFlows.Item.IdentityProviders.Item
{
    /// <summary>
    /// Provides operations to manage the identityProviders property of the microsoft.graph.b2xIdentityUserFlow entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IdentityProviderItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Identity.B2xUserFlows.Item.IdentityProviders.Item.IdentityProviderItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityProviderItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/b2xUserFlows/{b2xIdentityUserFlow%2Did}/identityProviders/{identityProvider%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Identity.B2xUserFlows.Item.IdentityProviders.Item.IdentityProviderItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityProviderItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/b2xUserFlows/{b2xIdentityUserFlow%2Did}/identityProviders/{identityProvider%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// The identity providers included in the user flow.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityProvider"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("The identityProvider API is deprecated and will stop returning data on March 2023. Please use the new identityProviderBase API. as of 2021-05/identityProvider on 2021-08-24 and will be removed 2023-03-15")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.IdentityProvider?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Identity.B2xUserFlows.Item.IdentityProviders.Item.IdentityProviderItemRequestBuilder.IdentityProviderItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.IdentityProvider> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Identity.B2xUserFlows.Item.IdentityProviders.Item.IdentityProviderItemRequestBuilder.IdentityProviderItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.IdentityProvider>(requestInfo, global::Microsoft.Graph.Models.IdentityProvider.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The identity providers included in the user flow.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The identityProvider API is deprecated and will stop returning data on March 2023. Please use the new identityProviderBase API. as of 2021-05/identityProvider on 2021-08-24 and will be removed 2023-03-15")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Identity.B2xUserFlows.Item.IdentityProviders.Item.IdentityProviderItemRequestBuilder.IdentityProviderItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Identity.B2xUserFlows.Item.IdentityProviders.Item.IdentityProviderItemRequestBuilder.IdentityProviderItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Identity.B2xUserFlows.Item.IdentityProviders.Item.IdentityProviderItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("The identityProvider API is deprecated and will stop returning data on March 2023. Please use the new identityProviderBase API. as of 2021-05/identityProvider on 2021-08-24 and will be removed 2023-03-15")]
        public global::Microsoft.Graph.Identity.B2xUserFlows.Item.IdentityProviders.Item.IdentityProviderItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Identity.B2xUserFlows.Item.IdentityProviders.Item.IdentityProviderItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// The identity providers included in the user flow.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class IdentityProviderItemRequestBuilderGetQueryParameters 
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
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class IdentityProviderItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Identity.B2xUserFlows.Item.IdentityProviders.Item.IdentityProviderItemRequestBuilder.IdentityProviderItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
