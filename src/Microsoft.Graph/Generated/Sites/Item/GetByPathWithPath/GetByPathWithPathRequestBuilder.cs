// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.Analytics;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.Columns;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.ContentTypes;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.CreatedByUser;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.Drive;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.Drives;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.ExternalColumns;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.GetActivitiesByInterval;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.Items;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.LastModifiedByUser;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.Lists;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.Onenote;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.Operations;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.Pages;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.Permissions;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.Sites;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.TermStore;
using Microsoft.Graph.Sites.Item.GetByPathWithPath.TermStores;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Sites.Item.GetByPathWithPath
{
    /// <summary>
    /// Provides operations to call the getByPath method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class GetByPathWithPathRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the analytics property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Analytics.AnalyticsRequestBuilder Analytics
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Analytics.AnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columns property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Columns.ColumnsRequestBuilder Columns
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Columns.ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contentTypes property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.ContentTypes.ContentTypesRequestBuilder ContentTypes
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.ContentTypes.ContentTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the createdByUser property of the microsoft.graph.baseItem entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.CreatedByUser.CreatedByUserRequestBuilder CreatedByUser
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.CreatedByUser.CreatedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drive property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Drive.DriveRequestBuilder Drive
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Drive.DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drives property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Drives.DrivesRequestBuilder Drives
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Drives.DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the externalColumns property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.ExternalColumns.ExternalColumnsRequestBuilder ExternalColumns
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.ExternalColumns.ExternalColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getActivitiesByInterval method.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.GetActivitiesByInterval.GetActivitiesByIntervalRequestBuilder GetActivitiesByInterval
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.GetActivitiesByInterval.GetActivitiesByIntervalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the items property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Items.ItemsRequestBuilder Items
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Items.ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.LastModifiedByUser.LastModifiedByUserRequestBuilder LastModifiedByUser
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.LastModifiedByUser.LastModifiedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lists property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Lists.ListsRequestBuilder Lists
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Lists.ListsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onenote property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Onenote.OnenoteRequestBuilder Onenote
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Onenote.OnenoteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Operations.OperationsRequestBuilder Operations
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Operations.OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the pages property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Pages.PagesRequestBuilder Pages
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Pages.PagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the permissions property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Permissions.PermissionsRequestBuilder Permissions
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Permissions.PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sites property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Sites.SitesRequestBuilder Sites
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.Sites.SitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the termStore property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.TermStore.TermStoreRequestBuilder TermStore
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.TermStore.TermStoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the termStores property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.TermStores.TermStoresRequestBuilder TermStores
        {
            get => new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.TermStores.TermStoresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Sites.Item.GetByPathWithPath.GetByPathWithPathRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="path">Usage: path=&apos;{path}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetByPathWithPathRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string path = "") : base(requestAdapter, "{+baseurl}/sites/{site%2Did}/getByPath(path='{path}')", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(path)) PathParameters.Add("path", path);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Sites.Item.GetByPathWithPath.GetByPathWithPathRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetByPathWithPathRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sites/{site%2Did}/getByPath(path='{path}')", rawUrl)
        {
        }
        /// <summary>
        /// Provides operations to call the getActivitiesByInterval method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Sites.Item.GetByPathWithPath.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder"/></returns>
        /// <param name="endDateTime">Usage: endDateTime=&apos;{endDateTime}&apos;</param>
        /// <param name="interval">Usage: interval=&apos;{interval}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime=&apos;{startDateTime}&apos;</param>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval(string endDateTime, string interval, string startDateTime)
        {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(interval)) throw new ArgumentNullException(nameof(interval));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(PathParameters, RequestAdapter, endDateTime, interval, startDateTime);
        }
        /// <summary>
        /// Provides operations to call the getApplicableContentTypesForList method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder"/></returns>
        /// <param name="listId">Usage: listId=&apos;{listId}&apos;</param>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder GetApplicableContentTypesForListWithListId(string listId)
        {
            if(string.IsNullOrEmpty(listId)) throw new ArgumentNullException(nameof(listId));
            return new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder(PathParameters, RequestAdapter, listId);
        }
        /// <summary>
        /// Invoke function getByPath
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Site"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Site?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Site> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Site>(requestInfo, global::Microsoft.Graph.Models.Site.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function getByPath
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
        /// <returns>A <see cref="global::Microsoft.Graph.Sites.Item.GetByPathWithPath.GetByPathWithPathRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Sites.Item.GetByPathWithPath.GetByPathWithPathRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Sites.Item.GetByPathWithPath.GetByPathWithPathRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class GetByPathWithPathRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
