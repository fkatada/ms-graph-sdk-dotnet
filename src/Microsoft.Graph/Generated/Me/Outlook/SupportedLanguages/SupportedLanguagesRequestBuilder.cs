// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Me.Outlook.SupportedLanguages {
    /// <summary>
    /// Provides operations to call the supportedLanguages method.
    /// </summary>
    public class SupportedLanguagesRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new SupportedLanguagesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SupportedLanguagesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/outlook/supportedLanguages(){?%24top,%24skip,%24search,%24filter,%24count}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SupportedLanguagesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SupportedLanguagesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/outlook/supportedLanguages(){?%24top,%24skip,%24search,%24filter,%24count}", rawUrl) {
        }
        /// <summary>
        /// Get the list of locales and languages that are supported for the user, as configured on the user&apos;s mailbox server. When setting up an Outlook client, the user selects the preferred language from this supported list. You can subsequently get the preferred language bygetting the user&apos;s mailbox settings. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/outlookuser-supportedlanguages?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SupportedLanguagesGetResponse?> GetAsSupportedLanguagesGetResponseAsync(Action<RequestConfiguration<SupportedLanguagesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<SupportedLanguagesGetResponse> GetAsSupportedLanguagesGetResponseAsync(Action<RequestConfiguration<SupportedLanguagesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<SupportedLanguagesGetResponse>(requestInfo, SupportedLanguagesGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the list of locales and languages that are supported for the user, as configured on the user&apos;s mailbox server. When setting up an Outlook client, the user selects the preferred language from this supported list. You can subsequently get the preferred language bygetting the user&apos;s mailbox settings. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/outlookuser-supportedlanguages?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsSupportedLanguagesGetResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SupportedLanguagesResponse?> GetAsync(Action<RequestConfiguration<SupportedLanguagesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<SupportedLanguagesResponse> GetAsync(Action<RequestConfiguration<SupportedLanguagesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<SupportedLanguagesResponse>(requestInfo, SupportedLanguagesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the list of locales and languages that are supported for the user, as configured on the user&apos;s mailbox server. When setting up an Outlook client, the user selects the preferred language from this supported list. You can subsequently get the preferred language bygetting the user&apos;s mailbox settings. This API is available in the following national cloud deployments.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SupportedLanguagesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SupportedLanguagesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SupportedLanguagesRequestBuilder WithUrl(string rawUrl) {
            return new SupportedLanguagesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the list of locales and languages that are supported for the user, as configured on the user&apos;s mailbox server. When setting up an Outlook client, the user selects the preferred language from this supported list. You can subsequently get the preferred language bygetting the user&apos;s mailbox settings. This API is available in the following national cloud deployments.
        /// </summary>
        public class SupportedLanguagesRequestBuilderGetQueryParameters {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class SupportedLanguagesRequestBuilderGetRequestConfiguration : RequestConfiguration<SupportedLanguagesRequestBuilderGetQueryParameters> {
        }
    }
}
