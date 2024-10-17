// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ListItemVersion : global::Microsoft.Graph.Models.BaseItemVersion, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of the fields and values for this version of the list item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.FieldValueSet? Fields
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.FieldValueSet?>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.FieldValueSet Fields
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.FieldValueSet>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.ListItemVersion"/> and sets the default values.
        /// </summary>
        public ListItemVersion() : base()
        {
            OdataType = "#microsoft.graph.listItemVersion";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ListItemVersion"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ListItemVersion CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.documentSetVersion" => new global::Microsoft.Graph.Models.DocumentSetVersion(),
                _ => new global::Microsoft.Graph.Models.ListItemVersion(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "fields", n => { Fields = n.GetObjectValue<global::Microsoft.Graph.Models.FieldValueSet>(global::Microsoft.Graph.Models.FieldValueSet.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.FieldValueSet>("fields", Fields);
        }
    }
}
#pragma warning restore CS0618
