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
    public partial class AccessPackageQuestion : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies whether the requestor is allowed to edit answers to questions for an assignment by posting an update to accessPackageAssignmentRequest.</summary>
        public bool? IsAnswerEditable
        {
            get { return BackingStore?.Get<bool?>("isAnswerEditable"); }
            set { BackingStore?.Set("isAnswerEditable", value); }
        }
        /// <summary>Whether the requestor is required to supply an answer or not.</summary>
        public bool? IsRequired
        {
            get { return BackingStore?.Get<bool?>("isRequired"); }
            set { BackingStore?.Set("isRequired", value); }
        }
        /// <summary>The text of the question represented in a format for a specific locale.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AccessPackageLocalizedText>? Localizations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessPackageLocalizedText>?>("localizations"); }
            set { BackingStore?.Set("localizations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AccessPackageLocalizedText> Localizations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessPackageLocalizedText>>("localizations"); }
            set { BackingStore?.Set("localizations", value); }
        }
#endif
        /// <summary>Relative position of this question when displaying a list of questions to the requestor.</summary>
        public int? Sequence
        {
            get { return BackingStore?.Get<int?>("sequence"); }
            set { BackingStore?.Set("sequence", value); }
        }
        /// <summary>The text of the question to show to the requestor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text
        {
            get { return BackingStore?.Get<string?>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#nullable restore
#else
        public string Text
        {
            get { return BackingStore?.Get<string>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AccessPackageQuestion"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AccessPackageQuestion CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.accessPackageMultipleChoiceQuestion" => new global::Microsoft.Graph.Models.AccessPackageMultipleChoiceQuestion(),
                "#microsoft.graph.accessPackageTextInputQuestion" => new global::Microsoft.Graph.Models.AccessPackageTextInputQuestion(),
                _ => new global::Microsoft.Graph.Models.AccessPackageQuestion(),
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
                { "isAnswerEditable", n => { IsAnswerEditable = n.GetBoolValue(); } },
                { "isRequired", n => { IsRequired = n.GetBoolValue(); } },
                { "localizations", n => { Localizations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessPackageLocalizedText>(global::Microsoft.Graph.Models.AccessPackageLocalizedText.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sequence", n => { Sequence = n.GetIntValue(); } },
                { "text", n => { Text = n.GetStringValue(); } },
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
            writer.WriteBoolValue("isAnswerEditable", IsAnswerEditable);
            writer.WriteBoolValue("isRequired", IsRequired);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessPackageLocalizedText>("localizations", Localizations);
            writer.WriteIntValue("sequence", Sequence);
            writer.WriteStringValue("text", Text);
        }
    }
}
#pragma warning restore CS0618
