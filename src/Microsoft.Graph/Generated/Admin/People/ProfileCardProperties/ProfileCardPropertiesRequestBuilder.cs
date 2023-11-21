// <auto-generated/>
using Microsoft.Graph.Admin.People.ProfileCardProperties.Count;
using Microsoft.Graph.Admin.People.ProfileCardProperties.Item;
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
namespace Microsoft.Graph.Admin.People.ProfileCardProperties {
    /// <summary>
    /// Provides operations to manage the profileCardProperties property of the microsoft.graph.peopleAdminSettings entity.
    /// </summary>
    public class ProfileCardPropertiesRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public CountRequestBuilder Count { get =>
            new CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the profileCardProperties property of the microsoft.graph.peopleAdminSettings entity.</summary>
        /// <param name="position">The unique identifier of profileCardProperty</param>
        public ProfileCardPropertyItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("profileCardProperty%2Did", position);
            return new ProfileCardPropertyItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ProfileCardPropertiesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProfileCardPropertiesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/people/profileCardProperties{?%24top,%24skip,%24search,%24filter,%24count,%24orderby,%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ProfileCardPropertiesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProfileCardPropertiesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/people/profileCardProperties{?%24top,%24skip,%24search,%24filter,%24count,%24orderby,%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Get a collection of profileCardProperty resources for an organization. Each resource is identified by its directoryPropertyName property.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/peopleadminsettings-list-profilecardproperties?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ProfileCardPropertyCollectionResponse?> GetAsync(Action<RequestConfiguration<ProfileCardPropertiesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ProfileCardPropertyCollectionResponse> GetAsync(Action<RequestConfiguration<ProfileCardPropertiesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ProfileCardPropertyCollectionResponse>(requestInfo, ProfileCardPropertyCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new profileCardProperty for an organization. The new property is identified by its directoryPropertyName property. For more information about how to add properties to the profile card for an organization, see Add or remove custom attributes on a profile card using the profile card API.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/peopleadminsettings-post-profilecardproperties?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ProfileCardProperty?> PostAsync(ProfileCardProperty body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ProfileCardProperty> PostAsync(ProfileCardProperty body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ProfileCardProperty>(requestInfo, ProfileCardProperty.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a collection of profileCardProperty resources for an organization. Each resource is identified by its directoryPropertyName property.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ProfileCardPropertiesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ProfileCardPropertiesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new profileCardProperty for an organization. The new property is identified by its directoryPropertyName property. For more information about how to add properties to the profile card for an organization, see Add or remove custom attributes on a profile card using the profile card API.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ProfileCardProperty body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ProfileCardProperty body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ProfileCardPropertiesRequestBuilder WithUrl(string rawUrl) {
            return new ProfileCardPropertiesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get a collection of profileCardProperty resources for an organization. Each resource is identified by its directoryPropertyName property.
        /// </summary>
        public class ProfileCardPropertiesRequestBuilderGetQueryParameters {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
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
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
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
        public class ProfileCardPropertiesRequestBuilderGetRequestConfiguration : RequestConfiguration<ProfileCardPropertiesRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ProfileCardPropertiesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
