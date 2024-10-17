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
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PrinterCapabilities : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>A list of supported bottom margins(in microns) for the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? BottomMargins
        {
            get { return BackingStore?.Get<List<int?>?>("bottomMargins"); }
            set { BackingStore?.Set("bottomMargins", value); }
        }
#nullable restore
#else
        public List<int?> BottomMargins
        {
            get { return BackingStore?.Get<List<int?>>("bottomMargins"); }
            set { BackingStore?.Set("bottomMargins", value); }
        }
#endif
        /// <summary>True if the printer supports collating when printing muliple copies of a multi-page document; false otherwise.</summary>
        public bool? Collation
        {
            get { return BackingStore?.Get<bool?>("collation"); }
            set { BackingStore?.Set("collation", value); }
        }
        /// <summary>The color modes supported by the printer. Valid values are described in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.PrintColorMode?>? ColorModes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintColorMode?>?>("colorModes"); }
            set { BackingStore?.Set("colorModes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.PrintColorMode?> ColorModes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintColorMode?>>("colorModes"); }
            set { BackingStore?.Set("colorModes", value); }
        }
#endif
        /// <summary>A list of supported content (MIME) types that the printer supports. It is not guaranteed that the Universal Print service supports printing all of these MIME types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ContentTypes
        {
            get { return BackingStore?.Get<List<string>?>("contentTypes"); }
            set { BackingStore?.Set("contentTypes", value); }
        }
#nullable restore
#else
        public List<string> ContentTypes
        {
            get { return BackingStore?.Get<List<string>>("contentTypes"); }
            set { BackingStore?.Set("contentTypes", value); }
        }
#endif
        /// <summary>The range of copies per job supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IntegerRange? CopiesPerJob
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IntegerRange?>("copiesPerJob"); }
            set { BackingStore?.Set("copiesPerJob", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IntegerRange CopiesPerJob
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IntegerRange>("copiesPerJob"); }
            set { BackingStore?.Set("copiesPerJob", value); }
        }
#endif
        /// <summary>The list of print resolutions in DPI that are supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? Dpis
        {
            get { return BackingStore?.Get<List<int?>?>("dpis"); }
            set { BackingStore?.Set("dpis", value); }
        }
#nullable restore
#else
        public List<int?> Dpis
        {
            get { return BackingStore?.Get<List<int?>>("dpis"); }
            set { BackingStore?.Set("dpis", value); }
        }
#endif
        /// <summary>The list of duplex modes that are supported by the printer. Valid values are described in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.PrintDuplexMode?>? DuplexModes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintDuplexMode?>?>("duplexModes"); }
            set { BackingStore?.Set("duplexModes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.PrintDuplexMode?> DuplexModes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintDuplexMode?>>("duplexModes"); }
            set { BackingStore?.Set("duplexModes", value); }
        }
#endif
        /// <summary>The list of feed orientations that are supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.PrinterFeedOrientation?>? FeedOrientations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrinterFeedOrientation?>?>("feedOrientations"); }
            set { BackingStore?.Set("feedOrientations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.PrinterFeedOrientation?> FeedOrientations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrinterFeedOrientation?>>("feedOrientations"); }
            set { BackingStore?.Set("feedOrientations", value); }
        }
#endif
        /// <summary>Finishing processes the printer supports for a printed document.</summary>
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
        /// <summary>Supported input bins for the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? InputBins
        {
            get { return BackingStore?.Get<List<string>?>("inputBins"); }
            set { BackingStore?.Set("inputBins", value); }
        }
#nullable restore
#else
        public List<string> InputBins
        {
            get { return BackingStore?.Get<List<string>>("inputBins"); }
            set { BackingStore?.Set("inputBins", value); }
        }
#endif
        /// <summary>True if color printing is supported by the printer; false otherwise. Read-only.</summary>
        public bool? IsColorPrintingSupported
        {
            get { return BackingStore?.Get<bool?>("isColorPrintingSupported"); }
            set { BackingStore?.Set("isColorPrintingSupported", value); }
        }
        /// <summary>True if the printer supports printing by page ranges; false otherwise.</summary>
        public bool? IsPageRangeSupported
        {
            get { return BackingStore?.Get<bool?>("isPageRangeSupported"); }
            set { BackingStore?.Set("isPageRangeSupported", value); }
        }
        /// <summary>A list of supported left margins(in microns) for the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? LeftMargins
        {
            get { return BackingStore?.Get<List<int?>?>("leftMargins"); }
            set { BackingStore?.Set("leftMargins", value); }
        }
#nullable restore
#else
        public List<int?> LeftMargins
        {
            get { return BackingStore?.Get<List<int?>>("leftMargins"); }
            set { BackingStore?.Set("leftMargins", value); }
        }
#endif
        /// <summary>The media (i.e., paper) colors supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MediaColors
        {
            get { return BackingStore?.Get<List<string>?>("mediaColors"); }
            set { BackingStore?.Set("mediaColors", value); }
        }
#nullable restore
#else
        public List<string> MediaColors
        {
            get { return BackingStore?.Get<List<string>>("mediaColors"); }
            set { BackingStore?.Set("mediaColors", value); }
        }
#endif
        /// <summary>The media sizes supported by the printer. Supports standard size names for ISO and ANSI media sizes. Valid values are in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MediaSizes
        {
            get { return BackingStore?.Get<List<string>?>("mediaSizes"); }
            set { BackingStore?.Set("mediaSizes", value); }
        }
#nullable restore
#else
        public List<string> MediaSizes
        {
            get { return BackingStore?.Get<List<string>>("mediaSizes"); }
            set { BackingStore?.Set("mediaSizes", value); }
        }
#endif
        /// <summary>The media types supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MediaTypes
        {
            get { return BackingStore?.Get<List<string>?>("mediaTypes"); }
            set { BackingStore?.Set("mediaTypes", value); }
        }
#nullable restore
#else
        public List<string> MediaTypes
        {
            get { return BackingStore?.Get<List<string>>("mediaTypes"); }
            set { BackingStore?.Set("mediaTypes", value); }
        }
#endif
        /// <summary>The presentation directions supported by the printer. Supported values are described in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.PrintMultipageLayout?>? MultipageLayouts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintMultipageLayout?>?>("multipageLayouts"); }
            set { BackingStore?.Set("multipageLayouts", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.PrintMultipageLayout?> MultipageLayouts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintMultipageLayout?>>("multipageLayouts"); }
            set { BackingStore?.Set("multipageLayouts", value); }
        }
#endif
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
        /// <summary>The print orientations supported by the printer. Valid values are described in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.PrintOrientation?>? Orientations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintOrientation?>?>("orientations"); }
            set { BackingStore?.Set("orientations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.PrintOrientation?> Orientations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintOrientation?>>("orientations"); }
            set { BackingStore?.Set("orientations", value); }
        }
#endif
        /// <summary>The printer&apos;s supported output bins (trays).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OutputBins
        {
            get { return BackingStore?.Get<List<string>?>("outputBins"); }
            set { BackingStore?.Set("outputBins", value); }
        }
#nullable restore
#else
        public List<string> OutputBins
        {
            get { return BackingStore?.Get<List<string>>("outputBins"); }
            set { BackingStore?.Set("outputBins", value); }
        }
#endif
        /// <summary>Supported number of Input Pages to impose upon a single Impression.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? PagesPerSheet
        {
            get { return BackingStore?.Get<List<int?>?>("pagesPerSheet"); }
            set { BackingStore?.Set("pagesPerSheet", value); }
        }
#nullable restore
#else
        public List<int?> PagesPerSheet
        {
            get { return BackingStore?.Get<List<int?>>("pagesPerSheet"); }
            set { BackingStore?.Set("pagesPerSheet", value); }
        }
#endif
        /// <summary>The print qualities supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.PrintQuality?>? Qualities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintQuality?>?>("qualities"); }
            set { BackingStore?.Set("qualities", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.PrintQuality?> Qualities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintQuality?>>("qualities"); }
            set { BackingStore?.Set("qualities", value); }
        }
#endif
        /// <summary>A list of supported right margins(in microns) for the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? RightMargins
        {
            get { return BackingStore?.Get<List<int?>?>("rightMargins"); }
            set { BackingStore?.Set("rightMargins", value); }
        }
#nullable restore
#else
        public List<int?> RightMargins
        {
            get { return BackingStore?.Get<List<int?>>("rightMargins"); }
            set { BackingStore?.Set("rightMargins", value); }
        }
#endif
        /// <summary>Supported print scalings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.PrintScaling?>? Scalings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintScaling?>?>("scalings"); }
            set { BackingStore?.Set("scalings", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.PrintScaling?> Scalings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintScaling?>>("scalings"); }
            set { BackingStore?.Set("scalings", value); }
        }
#endif
        /// <summary>True if the printer supports scaling PDF pages to match the print media size; false otherwise.</summary>
        public bool? SupportsFitPdfToPage
        {
            get { return BackingStore?.Get<bool?>("supportsFitPdfToPage"); }
            set { BackingStore?.Set("supportsFitPdfToPage", value); }
        }
        /// <summary>A list of supported top margins(in microns) for the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? TopMargins
        {
            get { return BackingStore?.Get<List<int?>?>("topMargins"); }
            set { BackingStore?.Set("topMargins", value); }
        }
#nullable restore
#else
        public List<int?> TopMargins
        {
            get { return BackingStore?.Get<List<int?>>("topMargins"); }
            set { BackingStore?.Set("topMargins", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.PrinterCapabilities"/> and sets the default values.
        /// </summary>
        public PrinterCapabilities()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.PrinterCapabilities"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.PrinterCapabilities CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.PrinterCapabilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bottomMargins", n => { BottomMargins = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "collation", n => { Collation = n.GetBoolValue(); } },
                { "colorModes", n => { ColorModes = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintColorMode>()?.AsList(); } },
                { "contentTypes", n => { ContentTypes = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "copiesPerJob", n => { CopiesPerJob = n.GetObjectValue<global::Microsoft.Graph.Models.IntegerRange>(global::Microsoft.Graph.Models.IntegerRange.CreateFromDiscriminatorValue); } },
                { "dpis", n => { Dpis = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "duplexModes", n => { DuplexModes = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintDuplexMode>()?.AsList(); } },
                { "feedOrientations", n => { FeedOrientations = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.PrinterFeedOrientation>()?.AsList(); } },
                { "finishings", n => { Finishings = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintFinishing>()?.AsList(); } },
                { "inputBins", n => { InputBins = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "isColorPrintingSupported", n => { IsColorPrintingSupported = n.GetBoolValue(); } },
                { "isPageRangeSupported", n => { IsPageRangeSupported = n.GetBoolValue(); } },
                { "leftMargins", n => { LeftMargins = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "mediaColors", n => { MediaColors = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "mediaSizes", n => { MediaSizes = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "mediaTypes", n => { MediaTypes = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "multipageLayouts", n => { MultipageLayouts = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintMultipageLayout>()?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "orientations", n => { Orientations = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintOrientation>()?.AsList(); } },
                { "outputBins", n => { OutputBins = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "pagesPerSheet", n => { PagesPerSheet = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "qualities", n => { Qualities = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintQuality>()?.AsList(); } },
                { "rightMargins", n => { RightMargins = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "scalings", n => { Scalings = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintScaling>()?.AsList(); } },
                { "supportsFitPdfToPage", n => { SupportsFitPdfToPage = n.GetBoolValue(); } },
                { "topMargins", n => { TopMargins = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<int?>("bottomMargins", BottomMargins);
            writer.WriteBoolValue("collation", Collation);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintColorMode>("colorModes", ColorModes);
            writer.WriteCollectionOfPrimitiveValues<string>("contentTypes", ContentTypes);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IntegerRange>("copiesPerJob", CopiesPerJob);
            writer.WriteCollectionOfPrimitiveValues<int?>("dpis", Dpis);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintDuplexMode>("duplexModes", DuplexModes);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.PrinterFeedOrientation>("feedOrientations", FeedOrientations);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintFinishing>("finishings", Finishings);
            writer.WriteCollectionOfPrimitiveValues<string>("inputBins", InputBins);
            writer.WriteBoolValue("isColorPrintingSupported", IsColorPrintingSupported);
            writer.WriteBoolValue("isPageRangeSupported", IsPageRangeSupported);
            writer.WriteCollectionOfPrimitiveValues<int?>("leftMargins", LeftMargins);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaColors", MediaColors);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaSizes", MediaSizes);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaTypes", MediaTypes);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintMultipageLayout>("multipageLayouts", MultipageLayouts);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintOrientation>("orientations", Orientations);
            writer.WriteCollectionOfPrimitiveValues<string>("outputBins", OutputBins);
            writer.WriteCollectionOfPrimitiveValues<int?>("pagesPerSheet", PagesPerSheet);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintQuality>("qualities", Qualities);
            writer.WriteCollectionOfPrimitiveValues<int?>("rightMargins", RightMargins);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.PrintScaling>("scalings", Scalings);
            writer.WriteBoolValue("supportsFitPdfToPage", SupportsFitPdfToPage);
            writer.WriteCollectionOfPrimitiveValues<int?>("topMargins", TopMargins);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
