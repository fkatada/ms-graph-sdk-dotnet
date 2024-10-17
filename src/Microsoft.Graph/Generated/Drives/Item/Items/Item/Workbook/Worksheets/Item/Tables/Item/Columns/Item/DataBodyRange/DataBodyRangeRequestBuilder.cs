// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.BoundingRectWithAnotherRange;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.CellWithRowWithColumn;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Clear;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnWithColumn;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnsAfter;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnsAfterWithCount;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnsBefore;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnsBeforeWithCount;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Delete;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.EntireColumn;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.EntireRow;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Format;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Insert;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.IntersectionWithAnotherRange;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.LastCell;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.LastColumn;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.LastRow;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Merge;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.OffsetRangeWithRowOffsetWithColumnOffset;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ResizedRangeWithDeltaRowsWithDeltaColumns;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowWithRow;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowsAbove;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowsAboveWithCount;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowsBelow;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowsBelowWithCount;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Sort;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Unmerge;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.UsedRange;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.UsedRangeWithValuesOnly;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.VisibleView;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Worksheet;
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
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange
{
    /// <summary>
    /// Provides operations to call the dataBodyRange method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DataBodyRangeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the clear method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Clear.ClearRequestBuilder Clear
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Clear.ClearRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the columnsAfter method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnsAfter.ColumnsAfterRequestBuilder ColumnsAfter
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnsAfter.ColumnsAfterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the columnsBefore method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnsBefore.ColumnsBeforeRequestBuilder ColumnsBefore
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnsBefore.ColumnsBeforeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the delete method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Delete.DeleteRequestBuilder DeletePath
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Delete.DeleteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the entireColumn method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.EntireColumn.EntireColumnRequestBuilder EntireColumn
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.EntireColumn.EntireColumnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the entireRow method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.EntireRow.EntireRowRequestBuilder EntireRow
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.EntireRow.EntireRowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the format property of the microsoft.graph.workbookRange entity.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Format.FormatRequestBuilder Format
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Format.FormatRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the insert method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Insert.InsertRequestBuilder Insert
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Insert.InsertRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lastCell method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.LastCell.LastCellRequestBuilder LastCell
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.LastCell.LastCellRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lastColumn method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.LastColumn.LastColumnRequestBuilder LastColumn
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.LastColumn.LastColumnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the lastRow method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.LastRow.LastRowRequestBuilder LastRow
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.LastRow.LastRowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the merge method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Merge.MergeRequestBuilder Merge
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Merge.MergeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rowsAbove method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowsAbove.RowsAboveRequestBuilder RowsAbove
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowsAbove.RowsAboveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rowsBelow method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowsBelow.RowsBelowRequestBuilder RowsBelow
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowsBelow.RowsBelowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sort property of the microsoft.graph.workbookRange entity.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Sort.SortRequestBuilder Sort
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Sort.SortRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unmerge method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Unmerge.UnmergeRequestBuilder Unmerge
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Unmerge.UnmergeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the usedRange method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.UsedRange.UsedRangeRequestBuilder UsedRange
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.UsedRange.UsedRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the visibleView method.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.VisibleView.VisibleViewRequestBuilder VisibleView
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.VisibleView.VisibleViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the worksheet property of the microsoft.graph.workbookRange entity.</summary>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Worksheet.WorksheetRequestBuilder Worksheet
        {
            get => new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.Worksheet.WorksheetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the boundingRect method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder"/></returns>
        /// <param name="anotherRange">Usage: anotherRange=&apos;{anotherRange}&apos;</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder BoundingRectWithAnotherRange(string anotherRange)
        {
            if(string.IsNullOrEmpty(anotherRange)) throw new ArgumentNullException(nameof(anotherRange));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.BoundingRectWithAnotherRange.BoundingRectWithAnotherRangeRequestBuilder(PathParameters, RequestAdapter, anotherRange);
        }
        /// <summary>
        /// Provides operations to call the cell method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder"/></returns>
        /// <param name="column">Usage: column={column}</param>
        /// <param name="row">Usage: row={row}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder CellWithRowWithColumn(int? column, int? row)
        {
            _ = column ?? throw new ArgumentNullException(nameof(column));
            _ = row ?? throw new ArgumentNullException(nameof(row));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.CellWithRowWithColumn.CellWithRowWithColumnRequestBuilder(PathParameters, RequestAdapter, column, row);
        }
        /// <summary>
        /// Provides operations to call the columnsAfter method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder ColumnsAfterWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnsAfterWithCount.ColumnsAfterWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the columnsBefore method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder ColumnsBeforeWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnsBeforeWithCount.ColumnsBeforeWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the column method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnWithColumn.ColumnWithColumnRequestBuilder"/></returns>
        /// <param name="column">Usage: column={column}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnWithColumn.ColumnWithColumnRequestBuilder ColumnWithColumn(int? column)
        {
            _ = column ?? throw new ArgumentNullException(nameof(column));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ColumnWithColumn.ColumnWithColumnRequestBuilder(PathParameters, RequestAdapter, column);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.DataBodyRangeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DataBodyRangeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/tables/{workbookTable%2Did}/columns/{workbookTableColumn%2Did}/dataBodyRange()", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.DataBodyRangeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DataBodyRangeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/tables/{workbookTable%2Did}/columns/{workbookTableColumn%2Did}/dataBodyRange()", rawUrl)
        {
        }
        /// <summary>
        /// Gets the range object associated with the data body of the column.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/tablecolumn-databodyrange?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.WorkbookRange"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.WorkbookRange?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.WorkbookRange> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.WorkbookRange>(requestInfo, global::Microsoft.Graph.Models.WorkbookRange.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the intersection method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder"/></returns>
        /// <param name="anotherRange">Usage: anotherRange=&apos;{anotherRange}&apos;</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder IntersectionWithAnotherRange(string anotherRange)
        {
            if(string.IsNullOrEmpty(anotherRange)) throw new ArgumentNullException(nameof(anotherRange));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.IntersectionWithAnotherRange.IntersectionWithAnotherRangeRequestBuilder(PathParameters, RequestAdapter, anotherRange);
        }
        /// <summary>
        /// Provides operations to call the offsetRange method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder"/></returns>
        /// <param name="columnOffset">Usage: columnOffset={columnOffset}</param>
        /// <param name="rowOffset">Usage: rowOffset={rowOffset}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder OffsetRangeWithRowOffsetWithColumnOffset(int? columnOffset, int? rowOffset)
        {
            _ = columnOffset ?? throw new ArgumentNullException(nameof(columnOffset));
            _ = rowOffset ?? throw new ArgumentNullException(nameof(rowOffset));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.OffsetRangeWithRowOffsetWithColumnOffset.OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder(PathParameters, RequestAdapter, columnOffset, rowOffset);
        }
        /// <summary>
        /// Provides operations to call the resizedRange method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder"/></returns>
        /// <param name="deltaColumns">Usage: deltaColumns={deltaColumns}</param>
        /// <param name="deltaRows">Usage: deltaRows={deltaRows}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder ResizedRangeWithDeltaRowsWithDeltaColumns(int? deltaColumns, int? deltaRows)
        {
            _ = deltaColumns ?? throw new ArgumentNullException(nameof(deltaColumns));
            _ = deltaRows ?? throw new ArgumentNullException(nameof(deltaRows));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.ResizedRangeWithDeltaRowsWithDeltaColumns.ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder(PathParameters, RequestAdapter, deltaColumns, deltaRows);
        }
        /// <summary>
        /// Provides operations to call the rowsAbove method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowsAboveWithCount.RowsAboveWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowsAboveWithCount.RowsAboveWithCountRequestBuilder RowsAboveWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowsAboveWithCount.RowsAboveWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the rowsBelow method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowsBelowWithCount.RowsBelowWithCountRequestBuilder"/></returns>
        /// <param name="count">Usage: count={count}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowsBelowWithCount.RowsBelowWithCountRequestBuilder RowsBelowWithCount(int? count)
        {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowsBelowWithCount.RowsBelowWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Provides operations to call the row method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowWithRow.RowWithRowRequestBuilder"/></returns>
        /// <param name="row">Usage: row={row}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowWithRow.RowWithRowRequestBuilder RowWithRow(int? row)
        {
            _ = row ?? throw new ArgumentNullException(nameof(row));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.RowWithRow.RowWithRowRequestBuilder(PathParameters, RequestAdapter, row);
        }
        /// <summary>
        /// Gets the range object associated with the data body of the column.
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
        /// Provides operations to call the usedRange method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder"/></returns>
        /// <param name="valuesOnly">Usage: valuesOnly={valuesOnly}</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder UsedRangeWithValuesOnly(bool? valuesOnly)
        {
            _ = valuesOnly ?? throw new ArgumentNullException(nameof(valuesOnly));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.UsedRangeWithValuesOnly.UsedRangeWithValuesOnlyRequestBuilder(PathParameters, RequestAdapter, valuesOnly);
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.DataBodyRangeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.DataBodyRangeRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.DataBodyRange.DataBodyRangeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DataBodyRangeRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
