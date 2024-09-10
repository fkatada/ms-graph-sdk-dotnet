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
namespace Microsoft.Graph.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances.Item.RoleDefinition
{
    /// <summary>
    /// Provides operations to manage the roleDefinition property of the microsoft.graph.unifiedRoleScheduleInstanceBase entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class RoleDefinitionRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances.Item.RoleDefinition.RoleDefinitionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RoleDefinitionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/roleManagement/entitlementManagement/roleEligibilityScheduleInstances/{unifiedRoleEligibilityScheduleInstance%2Did}/roleDefinition{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances.Item.RoleDefinition.RoleDefinitionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RoleDefinitionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/roleManagement/entitlementManagement/roleEligibilityScheduleInstances/{unifiedRoleEligibilityScheduleInstance%2Did}/roleDefinition{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.UnifiedRoleDefinition"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.UnifiedRoleDefinition?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances.Item.RoleDefinition.RoleDefinitionRequestBuilder.RoleDefinitionRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.UnifiedRoleDefinition> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances.Item.RoleDefinition.RoleDefinitionRequestBuilder.RoleDefinitionRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.UnifiedRoleDefinition>(requestInfo, global::Microsoft.Graph.Models.UnifiedRoleDefinition.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances.Item.RoleDefinition.RoleDefinitionRequestBuilder.RoleDefinitionRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances.Item.RoleDefinition.RoleDefinitionRequestBuilder.RoleDefinitionRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances.Item.RoleDefinition.RoleDefinitionRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances.Item.RoleDefinition.RoleDefinitionRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances.Item.RoleDefinition.RoleDefinitionRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class RoleDefinitionRequestBuilderGetQueryParameters 
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
        public partial class RoleDefinitionRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances.Item.RoleDefinition.RoleDefinitionRequestBuilder.RoleDefinitionRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
