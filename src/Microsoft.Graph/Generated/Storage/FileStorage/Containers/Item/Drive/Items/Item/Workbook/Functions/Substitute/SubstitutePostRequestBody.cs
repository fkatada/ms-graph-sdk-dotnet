// <auto-generated/>
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.Substitute
{
    #pragma warning disable CS1591
    public class SubstitutePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The instanceNum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? InstanceNum
        {
            get { return BackingStore?.Get<Json?>("instanceNum"); }
            set { BackingStore?.Set("instanceNum", value); }
        }
#nullable restore
#else
        public Json InstanceNum
        {
            get { return BackingStore?.Get<Json>("instanceNum"); }
            set { BackingStore?.Set("instanceNum", value); }
        }
#endif
        /// <summary>The newText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? NewText
        {
            get { return BackingStore?.Get<Json?>("newText"); }
            set { BackingStore?.Set("newText", value); }
        }
#nullable restore
#else
        public Json NewText
        {
            get { return BackingStore?.Get<Json>("newText"); }
            set { BackingStore?.Set("newText", value); }
        }
#endif
        /// <summary>The oldText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? OldText
        {
            get { return BackingStore?.Get<Json?>("oldText"); }
            set { BackingStore?.Set("oldText", value); }
        }
#nullable restore
#else
        public Json OldText
        {
            get { return BackingStore?.Get<Json>("oldText"); }
            set { BackingStore?.Set("oldText", value); }
        }
#endif
        /// <summary>The text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Text
        {
            get { return BackingStore?.Get<Json?>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#nullable restore
#else
        public Json Text
        {
            get { return BackingStore?.Get<Json>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SubstitutePostRequestBody"/> and sets the default values.
        /// </summary>
        public SubstitutePostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SubstitutePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SubstitutePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubstitutePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "instanceNum", n => { InstanceNum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "newText", n => { NewText = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "oldText", n => { OldText = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "text", n => { Text = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("instanceNum", InstanceNum);
            writer.WriteObjectValue<Json>("newText", NewText);
            writer.WriteObjectValue<Json>("oldText", OldText);
            writer.WriteObjectValue<Json>("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
