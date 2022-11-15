using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ChatMembersNotificationRecipient : TeamworkNotificationRecipient, IParsable {
        /// <summary>The unique identifier for the chat whose members should receive the notifications.</summary>
        public string ChatId {
            get { return BackingStore?.Get<string>("chatId"); }
            set { BackingStore?.Set("chatId", value); }
        }
        /// <summary>
        /// Instantiates a new ChatMembersNotificationRecipient and sets the default values.
        /// </summary>
        public ChatMembersNotificationRecipient() : base() {
            OdataType = "#microsoft.graph.chatMembersNotificationRecipient";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ChatMembersNotificationRecipient CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChatMembersNotificationRecipient();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"chatId", n => { ChatId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("chatId", ChatId);
        }
    }
}
