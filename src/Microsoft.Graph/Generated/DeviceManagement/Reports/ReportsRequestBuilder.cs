// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.DeviceManagement.Reports.ExportJobs;
using Microsoft.Graph.DeviceManagement.Reports.GetCachedReport;
using Microsoft.Graph.DeviceManagement.Reports.GetCompliancePolicyNonComplianceReport;
using Microsoft.Graph.DeviceManagement.Reports.GetCompliancePolicyNonComplianceSummaryReport;
using Microsoft.Graph.DeviceManagement.Reports.GetComplianceSettingNonComplianceReport;
using Microsoft.Graph.DeviceManagement.Reports.GetConfigurationPolicyNonComplianceReport;
using Microsoft.Graph.DeviceManagement.Reports.GetConfigurationPolicyNonComplianceSummaryReport;
using Microsoft.Graph.DeviceManagement.Reports.GetConfigurationSettingNonComplianceReport;
using Microsoft.Graph.DeviceManagement.Reports.GetDeviceManagementIntentPerSettingContributingProfiles;
using Microsoft.Graph.DeviceManagement.Reports.GetDeviceManagementIntentSettingsReport;
using Microsoft.Graph.DeviceManagement.Reports.GetDeviceNonComplianceReport;
using Microsoft.Graph.DeviceManagement.Reports.GetDevicesWithoutCompliancePolicyReport;
using Microsoft.Graph.DeviceManagement.Reports.GetHistoricalReport;
using Microsoft.Graph.DeviceManagement.Reports.GetNoncompliantDevicesAndSettingsReport;
using Microsoft.Graph.DeviceManagement.Reports.GetPolicyNonComplianceMetadata;
using Microsoft.Graph.DeviceManagement.Reports.GetPolicyNonComplianceReport;
using Microsoft.Graph.DeviceManagement.Reports.GetPolicyNonComplianceSummaryReport;
using Microsoft.Graph.DeviceManagement.Reports.GetReportFilters;
using Microsoft.Graph.DeviceManagement.Reports.GetSettingNonComplianceReport;
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
namespace Microsoft.Graph.DeviceManagement.Reports
{
    /// <summary>
    /// Provides operations to manage the reports property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class ReportsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the exportJobs property of the microsoft.graph.deviceManagementReports entity.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.ExportJobs.ExportJobsRequestBuilder ExportJobs
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.ExportJobs.ExportJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCachedReport method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetCachedReport.GetCachedReportRequestBuilder GetCachedReport
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetCachedReport.GetCachedReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCompliancePolicyNonComplianceReport method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetCompliancePolicyNonComplianceReport.GetCompliancePolicyNonComplianceReportRequestBuilder GetCompliancePolicyNonComplianceReport
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetCompliancePolicyNonComplianceReport.GetCompliancePolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCompliancePolicyNonComplianceSummaryReport method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetCompliancePolicyNonComplianceSummaryReport.GetCompliancePolicyNonComplianceSummaryReportRequestBuilder GetCompliancePolicyNonComplianceSummaryReport
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetCompliancePolicyNonComplianceSummaryReport.GetCompliancePolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getComplianceSettingNonComplianceReport method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetComplianceSettingNonComplianceReport.GetComplianceSettingNonComplianceReportRequestBuilder GetComplianceSettingNonComplianceReport
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetComplianceSettingNonComplianceReport.GetComplianceSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationPolicyNonComplianceReport method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetConfigurationPolicyNonComplianceReport.GetConfigurationPolicyNonComplianceReportRequestBuilder GetConfigurationPolicyNonComplianceReport
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetConfigurationPolicyNonComplianceReport.GetConfigurationPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationPolicyNonComplianceSummaryReport method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetConfigurationPolicyNonComplianceSummaryReport.GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder GetConfigurationPolicyNonComplianceSummaryReport
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetConfigurationPolicyNonComplianceSummaryReport.GetConfigurationPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConfigurationSettingNonComplianceReport method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetConfigurationSettingNonComplianceReport.GetConfigurationSettingNonComplianceReportRequestBuilder GetConfigurationSettingNonComplianceReport
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetConfigurationSettingNonComplianceReport.GetConfigurationSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDeviceManagementIntentPerSettingContributingProfiles method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetDeviceManagementIntentPerSettingContributingProfiles.GetDeviceManagementIntentPerSettingContributingProfilesRequestBuilder GetDeviceManagementIntentPerSettingContributingProfiles
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetDeviceManagementIntentPerSettingContributingProfiles.GetDeviceManagementIntentPerSettingContributingProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDeviceManagementIntentSettingsReport method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetDeviceManagementIntentSettingsReport.GetDeviceManagementIntentSettingsReportRequestBuilder GetDeviceManagementIntentSettingsReport
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetDeviceManagementIntentSettingsReport.GetDeviceManagementIntentSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDeviceNonComplianceReport method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetDeviceNonComplianceReport.GetDeviceNonComplianceReportRequestBuilder GetDeviceNonComplianceReport
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetDeviceNonComplianceReport.GetDeviceNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDevicesWithoutCompliancePolicyReport method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetDevicesWithoutCompliancePolicyReport.GetDevicesWithoutCompliancePolicyReportRequestBuilder GetDevicesWithoutCompliancePolicyReport
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetDevicesWithoutCompliancePolicyReport.GetDevicesWithoutCompliancePolicyReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getHistoricalReport method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetHistoricalReport.GetHistoricalReportRequestBuilder GetHistoricalReport
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetHistoricalReport.GetHistoricalReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getNoncompliantDevicesAndSettingsReport method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetNoncompliantDevicesAndSettingsReport.GetNoncompliantDevicesAndSettingsReportRequestBuilder GetNoncompliantDevicesAndSettingsReport
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetNoncompliantDevicesAndSettingsReport.GetNoncompliantDevicesAndSettingsReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getPolicyNonComplianceMetadata method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetPolicyNonComplianceMetadata.GetPolicyNonComplianceMetadataRequestBuilder GetPolicyNonComplianceMetadata
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetPolicyNonComplianceMetadata.GetPolicyNonComplianceMetadataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getPolicyNonComplianceReport method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetPolicyNonComplianceReport.GetPolicyNonComplianceReportRequestBuilder GetPolicyNonComplianceReport
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetPolicyNonComplianceReport.GetPolicyNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getPolicyNonComplianceSummaryReport method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetPolicyNonComplianceSummaryReport.GetPolicyNonComplianceSummaryReportRequestBuilder GetPolicyNonComplianceSummaryReport
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetPolicyNonComplianceSummaryReport.GetPolicyNonComplianceSummaryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getReportFilters method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetReportFilters.GetReportFiltersRequestBuilder GetReportFilters
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetReportFilters.GetReportFiltersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getSettingNonComplianceReport method.</summary>
        public global::Microsoft.Graph.DeviceManagement.Reports.GetSettingNonComplianceReport.GetSettingNonComplianceReportRequestBuilder GetSettingNonComplianceReport
        {
            get => new global::Microsoft.Graph.DeviceManagement.Reports.GetSettingNonComplianceReport.GetSettingNonComplianceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.DeviceManagement.Reports.ReportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/reports{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.DeviceManagement.Reports.ReportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/reports{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property reports for deviceManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Read properties and relationships of the deviceManagementReports object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-reporting-devicemanagementreports-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceManagementReports"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.DeviceManagementReports?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.DeviceManagement.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.DeviceManagementReports> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.DeviceManagement.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.DeviceManagementReports>(requestInfo, global::Microsoft.Graph.Models.DeviceManagementReports.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the properties of a deviceManagementReports object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-reporting-devicemanagementreports-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceManagementReports"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.DeviceManagementReports?> PatchAsync(global::Microsoft.Graph.Models.DeviceManagementReports body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.DeviceManagementReports> PatchAsync(global::Microsoft.Graph.Models.DeviceManagementReports body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.DeviceManagementReports>(requestInfo, global::Microsoft.Graph.Models.DeviceManagementReports.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property reports for deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read properties and relationships of the deviceManagementReports object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.DeviceManagement.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.DeviceManagement.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a deviceManagementReports object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.DeviceManagementReports body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.DeviceManagementReports body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.DeviceManagement.Reports.ReportsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.DeviceManagement.Reports.ReportsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.DeviceManagement.Reports.ReportsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class ReportsRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Read properties and relationships of the deviceManagementReports object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class ReportsRequestBuilderGetQueryParameters 
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
        public partial class ReportsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.DeviceManagement.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class ReportsRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
