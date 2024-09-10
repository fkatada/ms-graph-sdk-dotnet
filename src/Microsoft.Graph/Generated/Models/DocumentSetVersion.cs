// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class DocumentSetVersion : global::Microsoft.Graph.Models.ListItemVersion, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Comment about the captured version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment
        {
            get { return BackingStore?.Get<string?>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#nullable restore
#else
        public string Comment
        {
            get { return BackingStore?.Get<string>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#endif
        /// <summary>User who captured the version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentitySet? CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentitySet CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Date and time when this version was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Items within the document set that are captured as part of this version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.DocumentSetVersionItem>? Items
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DocumentSetVersionItem>?>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.DocumentSetVersionItem> Items
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DocumentSetVersionItem>>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#endif
        /// <summary>If true, minor versions of items are also captured; otherwise, only major versions are captured. The default value is false.</summary>
        public bool? ShouldCaptureMinorVersion
        {
            get { return BackingStore?.Get<bool?>("shouldCaptureMinorVersion"); }
            set { BackingStore?.Set("shouldCaptureMinorVersion", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.DocumentSetVersion"/> and sets the default values.
        /// </summary>
        public DocumentSetVersion() : base()
        {
            OdataType = "#microsoft.graph.documentSetVersion";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DocumentSetVersion"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.DocumentSetVersion CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.DocumentSetVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "comment", n => { Comment = n.GetStringValue(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::Microsoft.Graph.Models.IdentitySet>(global::Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "items", n => { Items = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.DocumentSetVersionItem>(global::Microsoft.Graph.Models.DocumentSetVersionItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "shouldCaptureMinorVersion", n => { ShouldCaptureMinorVersion = n.GetBoolValue(); } },
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
            writer.WriteStringValue("comment", Comment);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.DocumentSetVersionItem>("items", Items);
            writer.WriteBoolValue("shouldCaptureMinorVersion", ShouldCaptureMinorVersion);
        }
    }
}
#pragma warning restore CS0618
