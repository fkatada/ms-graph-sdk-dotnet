// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class EdiscoveryExportOperation : global::Microsoft.Graph.Models.Security.CaseOperation, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The description provided for the export.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Contains the properties for an export file metadata, including downloadUrl, fileName, and size.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.ExportFileMetadata>? ExportFileMetadata
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.ExportFileMetadata>?>("exportFileMetadata"); }
            set { BackingStore?.Set("exportFileMetadata", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.ExportFileMetadata> ExportFileMetadata
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.ExportFileMetadata>>("exportFileMetadata"); }
            set { BackingStore?.Set("exportFileMetadata", value); }
        }
#endif
        /// <summary>The options provided for the export. For more information, see reviewSet: export. Possible values are: originalFiles, text, pdfReplacement,  tags.</summary>
        public global::Microsoft.Graph.Models.Security.ExportOptions? ExportOptions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.ExportOptions?>("exportOptions"); }
            set { BackingStore?.Set("exportOptions", value); }
        }
        /// <summary>The options that specify the structure of the export. For more information, see reviewSet: export. Possible values are: none, directory, pst.</summary>
        public global::Microsoft.Graph.Models.Security.ExportFileStructure? ExportStructure
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.ExportFileStructure?>("exportStructure"); }
            set { BackingStore?.Set("exportStructure", value); }
        }
        /// <summary>The name provided for the export.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputName
        {
            get { return BackingStore?.Get<string?>("outputName"); }
            set { BackingStore?.Set("outputName", value); }
        }
#nullable restore
#else
        public string OutputName
        {
            get { return BackingStore?.Get<string>("outputName"); }
            set { BackingStore?.Set("outputName", value); }
        }
#endif
        /// <summary>Review set from where documents are exported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.EdiscoveryReviewSet? ReviewSet
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.EdiscoveryReviewSet?>("reviewSet"); }
            set { BackingStore?.Set("reviewSet", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.EdiscoveryReviewSet ReviewSet
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.EdiscoveryReviewSet>("reviewSet"); }
            set { BackingStore?.Set("reviewSet", value); }
        }
#endif
        /// <summary>The review set query that is used to filter the documents for export.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.EdiscoveryReviewSetQuery? ReviewSetQuery
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.EdiscoveryReviewSetQuery?>("reviewSetQuery"); }
            set { BackingStore?.Set("reviewSetQuery", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.EdiscoveryReviewSetQuery ReviewSetQuery
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.EdiscoveryReviewSetQuery>("reviewSetQuery"); }
            set { BackingStore?.Set("reviewSetQuery", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.EdiscoveryExportOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.EdiscoveryExportOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.EdiscoveryExportOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "description", n => { Description = n.GetStringValue(); } },
                { "exportFileMetadata", n => { ExportFileMetadata = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.ExportFileMetadata>(global::Microsoft.Graph.Models.Security.ExportFileMetadata.CreateFromDiscriminatorValue)?.AsList(); } },
                { "exportOptions", n => { ExportOptions = n.GetEnumValue<global::Microsoft.Graph.Models.Security.ExportOptions>(); } },
                { "exportStructure", n => { ExportStructure = n.GetEnumValue<global::Microsoft.Graph.Models.Security.ExportFileStructure>(); } },
                { "outputName", n => { OutputName = n.GetStringValue(); } },
                { "reviewSet", n => { ReviewSet = n.GetObjectValue<global::Microsoft.Graph.Models.Security.EdiscoveryReviewSet>(global::Microsoft.Graph.Models.Security.EdiscoveryReviewSet.CreateFromDiscriminatorValue); } },
                { "reviewSetQuery", n => { ReviewSetQuery = n.GetObjectValue<global::Microsoft.Graph.Models.Security.EdiscoveryReviewSetQuery>(global::Microsoft.Graph.Models.Security.EdiscoveryReviewSetQuery.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.ExportFileMetadata>("exportFileMetadata", ExportFileMetadata);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.ExportOptions>("exportOptions", ExportOptions);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.ExportFileStructure>("exportStructure", ExportStructure);
            writer.WriteStringValue("outputName", OutputName);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.EdiscoveryReviewSet>("reviewSet", ReviewSet);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.EdiscoveryReviewSetQuery>("reviewSetQuery", ReviewSetQuery);
        }
    }
}
#pragma warning restore CS0618
