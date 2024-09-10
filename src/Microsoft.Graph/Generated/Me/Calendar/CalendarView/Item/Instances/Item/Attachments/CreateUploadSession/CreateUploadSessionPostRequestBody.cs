// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Me.Calendar.CalendarView.Item.Instances.Item.Attachments.CreateUploadSession
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class CreateUploadSessionPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The AttachmentItem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AttachmentItem? AttachmentItem
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AttachmentItem?>("AttachmentItem"); }
            set { BackingStore?.Set("AttachmentItem", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AttachmentItem AttachmentItem
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AttachmentItem>("AttachmentItem"); }
            set { BackingStore?.Set("AttachmentItem", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.Calendar.CalendarView.Item.Instances.Item.Attachments.CreateUploadSession.CreateUploadSessionPostRequestBody"/> and sets the default values.
        /// </summary>
        public CreateUploadSessionPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Me.Calendar.CalendarView.Item.Instances.Item.Attachments.CreateUploadSession.CreateUploadSessionPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Me.Calendar.CalendarView.Item.Instances.Item.Attachments.CreateUploadSession.CreateUploadSessionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Me.Calendar.CalendarView.Item.Instances.Item.Attachments.CreateUploadSession.CreateUploadSessionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "AttachmentItem", n => { AttachmentItem = n.GetObjectValue<global::Microsoft.Graph.Models.AttachmentItem>(global::Microsoft.Graph.Models.AttachmentItem.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AttachmentItem>("AttachmentItem", AttachmentItem);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
