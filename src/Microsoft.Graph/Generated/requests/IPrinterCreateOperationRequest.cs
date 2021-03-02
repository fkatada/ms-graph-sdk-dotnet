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
    /// The interface IPrinterCreateOperationRequest.
    /// </summary>
    public partial interface IPrinterCreateOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PrinterCreateOperation using POST.
        /// </summary>
        /// <param name="printerCreateOperationToCreate">The PrinterCreateOperation to create.</param>
        /// <returns>The created PrinterCreateOperation.</returns>
        System.Threading.Tasks.Task<PrinterCreateOperation> CreateAsync(PrinterCreateOperation printerCreateOperationToCreate);        /// <summary>
        /// Creates the specified PrinterCreateOperation using POST.
        /// </summary>
        /// <param name="printerCreateOperationToCreate">The PrinterCreateOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrinterCreateOperation.</returns>
        System.Threading.Tasks.Task<PrinterCreateOperation> CreateAsync(PrinterCreateOperation printerCreateOperationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PrinterCreateOperation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PrinterCreateOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PrinterCreateOperation.
        /// </summary>
        /// <returns>The PrinterCreateOperation.</returns>
        System.Threading.Tasks.Task<PrinterCreateOperation> GetAsync();

        /// <summary>
        /// Gets the specified PrinterCreateOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrinterCreateOperation.</returns>
        System.Threading.Tasks.Task<PrinterCreateOperation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PrinterCreateOperation using PATCH.
        /// </summary>
        /// <param name="printerCreateOperationToUpdate">The PrinterCreateOperation to update.</param>
        /// <returns>The updated PrinterCreateOperation.</returns>
        System.Threading.Tasks.Task<PrinterCreateOperation> UpdateAsync(PrinterCreateOperation printerCreateOperationToUpdate);

        /// <summary>
        /// Updates the specified PrinterCreateOperation using PATCH.
        /// </summary>
        /// <param name="printerCreateOperationToUpdate">The PrinterCreateOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrinterCreateOperation.</returns>
        System.Threading.Tasks.Task<PrinterCreateOperation> UpdateAsync(PrinterCreateOperation printerCreateOperationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrinterCreateOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrinterCreateOperationRequest Expand(Expression<Func<PrinterCreateOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrinterCreateOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrinterCreateOperationRequest Select(Expression<Func<PrinterCreateOperation, object>> selectExpression);

    }
}
