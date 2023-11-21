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
namespace Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackages.Item.GetApplicablePolicyRequirements {
    /// <summary>
    /// Provides operations to call the getApplicablePolicyRequirements method.
    /// </summary>
    public class GetApplicablePolicyRequirementsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new GetApplicablePolicyRequirementsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetApplicablePolicyRequirementsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/accessPackages/{accessPackage%2Did}/getApplicablePolicyRequirements", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new GetApplicablePolicyRequirementsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetApplicablePolicyRequirementsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/accessPackages/{accessPackage%2Did}/getApplicablePolicyRequirements", rawUrl) {
        }
        /// <summary>
        /// In Microsoft Entra entitlement management, this action retrieves a list of accessPackageAssignmentRequestRequirements objects that the currently signed-in user can use to create an accessPackageAssignmentRequest.  Each requirement object corresponds to an access package assignment policy that the currently signed-in user is allowed to request an assignment for. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accesspackage-getapplicablepolicyrequirements?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GetApplicablePolicyRequirementsPostResponse?> PostAsGetApplicablePolicyRequirementsPostResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<GetApplicablePolicyRequirementsPostResponse> PostAsGetApplicablePolicyRequirementsPostResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<GetApplicablePolicyRequirementsPostResponse>(requestInfo, GetApplicablePolicyRequirementsPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// In Microsoft Entra entitlement management, this action retrieves a list of accessPackageAssignmentRequestRequirements objects that the currently signed-in user can use to create an accessPackageAssignmentRequest.  Each requirement object corresponds to an access package assignment policy that the currently signed-in user is allowed to request an assignment for. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accesspackage-getapplicablepolicyrequirements?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use PostAsGetApplicablePolicyRequirementsPostResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GetApplicablePolicyRequirementsResponse?> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<GetApplicablePolicyRequirementsResponse> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<GetApplicablePolicyRequirementsResponse>(requestInfo, GetApplicablePolicyRequirementsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// In Microsoft Entra entitlement management, this action retrieves a list of accessPackageAssignmentRequestRequirements objects that the currently signed-in user can use to create an accessPackageAssignmentRequest.  Each requirement object corresponds to an access package assignment policy that the currently signed-in user is allowed to request an assignment for. This API is available in the following national cloud deployments.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GetApplicablePolicyRequirementsRequestBuilder WithUrl(string rawUrl) {
            return new GetApplicablePolicyRequirementsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class GetApplicablePolicyRequirementsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
