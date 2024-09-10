// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser
{
    /// <summary>
    /// Provides operations to call the allowedCalendarSharingRoles method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class AllowedCalendarSharingRolesWithUserRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="user">Usage: User=&apos;{User}&apos;</param>
        public AllowedCalendarSharingRolesWithUserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string user = "") : base(requestAdapter, "{+baseurl}/me/calendar/allowedCalendarSharingRoles(User='{User}'){?%24count,%24filter,%24search,%24skip,%24top}", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(user)) PathParameters.Add("User", user);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AllowedCalendarSharingRolesWithUserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/calendar/allowedCalendarSharingRoles(User='{User}'){?%24count,%24filter,%24search,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function allowedCalendarSharingRoles
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserGetResponse?> GetAsAllowedCalendarSharingRolesWithUserGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserRequestBuilder.AllowedCalendarSharingRolesWithUserRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserGetResponse> GetAsAllowedCalendarSharingRolesWithUserGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserRequestBuilder.AllowedCalendarSharingRolesWithUserRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserGetResponse>(requestInfo, global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function allowedCalendarSharingRoles
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsAllowedCalendarSharingRolesWithUserGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserRequestBuilder.AllowedCalendarSharingRolesWithUserRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserRequestBuilder.AllowedCalendarSharingRolesWithUserRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserResponse>(requestInfo, global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function allowedCalendarSharingRoles
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserRequestBuilder.AllowedCalendarSharingRolesWithUserRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserRequestBuilder.AllowedCalendarSharingRolesWithUserRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Invoke function allowedCalendarSharingRoles
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class AllowedCalendarSharingRolesWithUserRequestBuilderGetQueryParameters 
        {
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
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class AllowedCalendarSharingRolesWithUserRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Me.Calendar.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserRequestBuilder.AllowedCalendarSharingRolesWithUserRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
