// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class PrintJobConfiguration : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Whether the printer should collate pages wehen printing multiple copies of a multi-page document.</summary>
        public bool? Collate
        {
            get { return BackingStore?.Get<bool?>("collate"); }
            set { BackingStore?.Set("collate", value); }
        }
        /// <summary>The color mode the printer should use to print the job. Valid values are described in the table below. Read-only.</summary>
        public global::Microsoft.Graph.Models.PrintColorMode? ColorMode
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrintColorMode?>("colorMode"); }
            set { BackingStore?.Set("colorMode", value); }
        }
        /// <summary>The number of copies that should be printed. Read-only.</summary>
        public int? Copies
        {
            get { return BackingStore?.Get<int?>("copies"); }
            set { BackingStore?.Set("copies", value); }
        }
        /// <summary>The resolution to use when printing the job, expressed in dots per inch (DPI). Read-only.</summary>
        public int? Dpi
        {
            get { return BackingStore?.Get<int?>("dpi"); }
            set { BackingStore?.Set("dpi", value); }
        }
        /// <summary>The duplex mode the printer should use when printing the job. Valid values are described in the table below. Read-only.</summary>
        public global::Microsoft.Graph.Models.PrintDuplexMode? DuplexMode
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrintDuplexMode?>("duplexMode"); }
            set { BackingStore?.Set("duplexMode", value); }
        }
        /// <summary>The orientation to use when feeding media into the printer. Valid values are described in the following table. Read-only.</summary>
        public global::Microsoft.Graph.Models.PrinterFeedOrientation? FeedOrientation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrinterFeedOrientation?>("feedOrientation"); }
            set { BackingStore?.Set("feedOrientation", value); }
        }
        /// <summary>Finishing processes to use when printing.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.PrintFinishing?>? Finishings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintFinishing?>?>("finishings"); }
            set { BackingStore?.Set("finishings", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.PrintFinishing?> Finishings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintFinishing?>>("finishings"); }
            set { BackingStore?.Set("finishings", value); }
        }
#endif
        /// <summary>True to fit each page of a PDF document to a physical sheet of media; false to let the printer decide how to lay out impressions.</summary>
        public bool? FitPdfToPage
        {
            get { return BackingStore?.Get<bool?>("fitPdfToPage"); }
            set { BackingStore?.Set("fitPdfToPage", value); }
        }
        /// <summary>The input bin (tray) to use when printing. See the printer&apos;s capabilities for a list of supported input bins.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InputBin
        {
            get { return BackingStore?.Get<string?>("inputBin"); }
            set { BackingStore?.Set("inputBin", value); }
        }
#nullable restore
#else
        public string InputBin
        {
            get { return BackingStore?.Get<string>("inputBin"); }
            set { BackingStore?.Set("inputBin", value); }
        }
#endif
        /// <summary>The margin settings to use when printing.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.PrintMargin? Margin
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrintMargin?>("margin"); }
            set { BackingStore?.Set("margin", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.PrintMargin Margin
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrintMargin>("margin"); }
            set { BackingStore?.Set("margin", value); }
        }
#endif
        /// <summary>The media size to use when printing. Supports standard size names for ISO and ANSI media sizes. Valid values listed in the printerCapabilities topic.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaSize
        {
            get { return BackingStore?.Get<string?>("mediaSize"); }
            set { BackingStore?.Set("mediaSize", value); }
        }
#nullable restore
#else
        public string MediaSize
        {
            get { return BackingStore?.Get<string>("mediaSize"); }
            set { BackingStore?.Set("mediaSize", value); }
        }
#endif
        /// <summary>The default media (such as paper) type to print the document on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaType
        {
            get { return BackingStore?.Get<string?>("mediaType"); }
            set { BackingStore?.Set("mediaType", value); }
        }
#nullable restore
#else
        public string MediaType
        {
            get { return BackingStore?.Get<string>("mediaType"); }
            set { BackingStore?.Set("mediaType", value); }
        }
#endif
        /// <summary>The direction to lay out pages when multiple pages are being printed per sheet. Valid values are described in the following table.</summary>
        public global::Microsoft.Graph.Models.PrintMultipageLayout? MultipageLayout
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrintMultipageLayout?>("multipageLayout"); }
            set { BackingStore?.Set("multipageLayout", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The orientation setting the printer should use when printing the job. Valid values are described in the following table.</summary>
        public global::Microsoft.Graph.Models.PrintOrientation? Orientation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrintOrientation?>("orientation"); }
            set { BackingStore?.Set("orientation", value); }
        }
        /// <summary>The output bin to place completed prints into. See the printer&apos;s capabilities for a list of supported output bins.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputBin
        {
            get { return BackingStore?.Get<string?>("outputBin"); }
            set { BackingStore?.Set("outputBin", value); }
        }
#nullable restore
#else
        public string OutputBin
        {
            get { return BackingStore?.Get<string>("outputBin"); }
            set { BackingStore?.Set("outputBin", value); }
        }
#endif
        /// <summary>The page ranges to print. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.IntegerRange>? PageRanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.IntegerRange>?>("pageRanges"); }
            set { BackingStore?.Set("pageRanges", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.IntegerRange> PageRanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.IntegerRange>>("pageRanges"); }
            set { BackingStore?.Set("pageRanges", value); }
        }
#endif
        /// <summary>The number of document pages to print on each sheet.</summary>
        public int? PagesPerSheet
        {
            get { return BackingStore?.Get<int?>("pagesPerSheet"); }
            set { BackingStore?.Set("pagesPerSheet", value); }
        }
        /// <summary>The print quality to use when printing the job. Valid values are described in the table below. Read-only.</summary>
        public global::Microsoft.Graph.Models.PrintQuality? Quality
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrintQuality?>("quality"); }
            set { BackingStore?.Set("quality", value); }
        }
        /// <summary>Specifies how the printer should scale the document data to fit the requested media. Valid values are described in the following table.</summary>
        public global::Microsoft.Graph.Models.PrintScaling? Scaling
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrintScaling?>("scaling"); }
            set { BackingStore?.Set("scaling", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.PrintJobConfiguration"/> and sets the default values.
        /// </summary>
        public PrintJobConfiguration()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.PrintJobConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.PrintJobConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.PrintJobConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "collate", n => { Collate = n.GetBoolValue(); } },
                { "colorMode", n => { ColorMode = n.GetEnumValue<global::Microsoft.Graph.Models.PrintColorMode>(); } },
                { "copies", n => { Copies = n.GetIntValue(); } },
                { "dpi", n => { Dpi = n.GetIntValue(); } },
                { "duplexMode", n => { DuplexMode = n.GetEnumValue<global::Microsoft.Graph.Models.PrintDuplexMode>(); } },
                { "feedOrientation", n => { FeedOrientation = n.GetEnumValue<global::Microsoft.Graph.Models.PrinterFeedOrientation>(); } },
                { "finishings", n => { Finishings = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintFinishing>()?.AsList(); } },
                { "fitPdfToPage", n => { FitPdfToPage = n.GetBoolValue(); } },
                { "inputBin", n => { InputBin = n.GetStringValue(); } },
                { "margin", n => { Margin = n.GetObjectValue<global::Microsoft.Graph.Models.PrintMargin>(global::Microsoft.Graph.Models.PrintMargin.CreateFromDiscriminatorValue); } },
                { "mediaSize", n => { MediaSize = n.GetStringValue(); } },
                { "mediaType", n => { MediaType = n.GetStringValue(); } },
                { "multipageLayout", n => { MultipageLayout = n.GetEnumValue<global::Microsoft.Graph.Models.PrintMultipageLayout>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "orientation", n => { Orientation = n.GetEnumValue<global::Microsoft.Graph.Models.PrintOrientation>(); } },
                { "outputBin", n => { OutputBin = n.GetStringValue(); } },
                { "pageRanges", n => { PageRanges = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.IntegerRange>(global::Microsoft.Graph.Models.IntegerRange.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pagesPerSheet", n => { PagesPerSheet = n.GetIntValue(); } },
                { "quality", n => { Quality = n.GetEnumValue<global::Microsoft.Graph.Models.PrintQuality>(); } },
                { "scaling", n => { Scaling = n.GetEnumValue<global::Microsoft.Graph.Models.PrintScaling>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("collate", Collate);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.PrintColorMode>("colorMode", ColorMode);
            writer.WriteIntValue("copies", Copies);
            writer.WriteIntValue("dpi", Dpi);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.PrintDuplexMode>("duplexMode", DuplexMode);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.PrinterFeedOrientation>("feedOrientation", FeedOrientation);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintFinishing>("finishings", Finishings);
            writer.WriteBoolValue("fitPdfToPage", FitPdfToPage);
            writer.WriteStringValue("inputBin", InputBin);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.PrintMargin>("margin", Margin);
            writer.WriteStringValue("mediaSize", MediaSize);
            writer.WriteStringValue("mediaType", MediaType);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.PrintMultipageLayout>("multipageLayout", MultipageLayout);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.PrintOrientation>("orientation", Orientation);
            writer.WriteStringValue("outputBin", OutputBin);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.IntegerRange>("pageRanges", PageRanges);
            writer.WriteIntValue("pagesPerSheet", PagesPerSheet);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.PrintQuality>("quality", Quality);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.PrintScaling>("scaling", Scaling);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
