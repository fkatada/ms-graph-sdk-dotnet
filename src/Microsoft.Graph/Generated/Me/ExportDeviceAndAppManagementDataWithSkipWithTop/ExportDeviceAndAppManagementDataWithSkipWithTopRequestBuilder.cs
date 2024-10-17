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
namespace Microsoft.Graph.Me.ExportDeviceAndAppManagementDataWithSkipWithTop
{
    /// <summary>
    /// Provides operations to call the exportDeviceAndAppManagementData method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.ExportDeviceAndAppManagementDataWithSkipWithTop.ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="top">Usage: top={top}</param>
        public ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, int? skip = default, int? top = default) : base(requestAdapter, "{+baseurl}/me/exportDeviceAndAppManagementData(skip={skip},top={top})", pathParameters)
        {
            if (skip != null) PathParameters.Add("skip", skip);
            if (top != null) PathParameters.Add("top", top);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.ExportDeviceAndAppManagementDataWithSkipWithTop.ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/exportDeviceAndAppManagementData(skip={skip},top={top})", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function exportDeviceAndAppManagementData
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceAndAppManagementData"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.DeviceAndAppManagementData?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.DeviceAndAppManagementData> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.DeviceAndAppManagementData>(requestInfo, global::Microsoft.Graph.Models.DeviceAndAppManagementData.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function exportDeviceAndAppManagementData
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Me.ExportDeviceAndAppManagementDataWithSkipWithTop.ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Me.ExportDeviceAndAppManagementDataWithSkipWithTop.ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Me.ExportDeviceAndAppManagementDataWithSkipWithTop.ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
