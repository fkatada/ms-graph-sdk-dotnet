// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IAccessPackageAssignmentRequest.
    /// </summary>
    public partial interface IAccessPackageAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AccessPackageAssignment using POST.
        /// </summary>
        /// <param name="accessPackageAssignmentToCreate">The AccessPackageAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessPackageAssignment.</returns>
        System.Threading.Tasks.Task<AccessPackageAssignment> CreateAsync(AccessPackageAssignment accessPackageAssignmentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AccessPackageAssignment using POST and returns a <see cref="GraphResponse{AccessPackageAssignment}"/> object.
        /// </summary>
        /// <param name="accessPackageAssignmentToCreate">The AccessPackageAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageAssignment>> CreateResponseAsync(AccessPackageAssignment accessPackageAssignmentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AccessPackageAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AccessPackageAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AccessPackageAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessPackageAssignment.</returns>
        System.Threading.Tasks.Task<AccessPackageAssignment> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AccessPackageAssignment and returns a <see cref="GraphResponse{AccessPackageAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageAssignment>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessPackageAssignment using PATCH.
        /// </summary>
        /// <param name="accessPackageAssignmentToUpdate">The AccessPackageAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessPackageAssignment.</returns>
        System.Threading.Tasks.Task<AccessPackageAssignment> UpdateAsync(AccessPackageAssignment accessPackageAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessPackageAssignment using PATCH and returns a <see cref="GraphResponse{AccessPackageAssignment}"/> object.
        /// </summary>
        /// <param name="accessPackageAssignmentToUpdate">The AccessPackageAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessPackageAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageAssignment>> UpdateResponseAsync(AccessPackageAssignment accessPackageAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessPackageAssignment using PUT.
        /// </summary>
        /// <param name="accessPackageAssignmentToUpdate">The AccessPackageAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AccessPackageAssignment> PutAsync(AccessPackageAssignment accessPackageAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessPackageAssignment using PUT and returns a <see cref="GraphResponse{AccessPackageAssignment}"/> object.
        /// </summary>
        /// <param name="accessPackageAssignmentToUpdate">The AccessPackageAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AccessPackageAssignment}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageAssignment>> PutResponseAsync(AccessPackageAssignment accessPackageAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageAssignmentRequest Expand(Expression<Func<AccessPackageAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageAssignmentRequest Select(Expression<Func<AccessPackageAssignment, object>> selectExpression);

    }
}
