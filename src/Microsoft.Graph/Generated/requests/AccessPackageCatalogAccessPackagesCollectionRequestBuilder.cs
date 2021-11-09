// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type AccessPackageCatalogAccessPackagesCollectionRequestBuilder.
    /// </summary>
    public partial class AccessPackageCatalogAccessPackagesCollectionRequestBuilder : BaseRequestBuilder, IAccessPackageCatalogAccessPackagesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AccessPackageCatalogAccessPackagesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AccessPackageCatalogAccessPackagesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAccessPackageCatalogAccessPackagesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAccessPackageCatalogAccessPackagesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AccessPackageCatalogAccessPackagesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAccessPackageRequestBuilder"/> for the specified AccessPackageCatalogAccessPackage.
        /// </summary>
        /// <param name="id">The ID for the AccessPackageCatalogAccessPackage.</param>
        /// <returns>The <see cref="IAccessPackageRequestBuilder"/>.</returns>
        public IAccessPackageRequestBuilder this[string id]
        {
            get
            {
                return new AccessPackageRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageFilterByCurrentUser.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageFilterByCurrentUserRequestBuilder"/>.</returns>
        public IAccessPackageFilterByCurrentUserRequestBuilder FilterByCurrentUser(
            AccessPackageFilterByCurrentUserOptions on)
        {
            return new AccessPackageFilterByCurrentUserRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.filterByCurrentUser"),
                this.Client,
                on);
        }
    }
}
