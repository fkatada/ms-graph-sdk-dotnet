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
namespace Microsoft.Graph.Me.EmployeeExperience.LearningCourseActivities.Item
{
    /// <summary>
    /// Provides operations to manage the learningCourseActivities property of the microsoft.graph.employeeExperienceUser entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class LearningCourseActivityItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.EmployeeExperience.LearningCourseActivities.Item.LearningCourseActivityItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LearningCourseActivityItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/employeeExperience/learningCourseActivities/{learningCourseActivity%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.EmployeeExperience.LearningCourseActivities.Item.LearningCourseActivityItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LearningCourseActivityItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/employeeExperience/learningCourseActivities/{learningCourseActivity%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get learningCourseActivities from me
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.LearningCourseActivity"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.LearningCourseActivity?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.EmployeeExperience.LearningCourseActivities.Item.LearningCourseActivityItemRequestBuilder.LearningCourseActivityItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.LearningCourseActivity> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.EmployeeExperience.LearningCourseActivities.Item.LearningCourseActivityItemRequestBuilder.LearningCourseActivityItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.LearningCourseActivity>(requestInfo, global::Microsoft.Graph.Models.LearningCourseActivity.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get learningCourseActivities from me
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.EmployeeExperience.LearningCourseActivities.Item.LearningCourseActivityItemRequestBuilder.LearningCourseActivityItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.EmployeeExperience.LearningCourseActivities.Item.LearningCourseActivityItemRequestBuilder.LearningCourseActivityItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Me.EmployeeExperience.LearningCourseActivities.Item.LearningCourseActivityItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Me.EmployeeExperience.LearningCourseActivities.Item.LearningCourseActivityItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Me.EmployeeExperience.LearningCourseActivities.Item.LearningCourseActivityItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get learningCourseActivities from me
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class LearningCourseActivityItemRequestBuilderGetQueryParameters 
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
        public partial class LearningCourseActivityItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Me.EmployeeExperience.LearningCourseActivities.Item.LearningCourseActivityItemRequestBuilder.LearningCourseActivityItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
