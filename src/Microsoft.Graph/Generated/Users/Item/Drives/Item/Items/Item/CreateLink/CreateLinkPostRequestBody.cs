using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Users.Item.Drives.Item.Items.Item.CreateLink {
    public class CreateLinkPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The expirationDateTime property</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message {
            get { return BackingStore?.Get<string?>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#nullable restore
#else
        public string Message {
            get { return BackingStore?.Get<string>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#endif
        /// <summary>The password property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Password {
            get { return BackingStore?.Get<string?>("password"); }
            set { BackingStore?.Set("password", value); }
        }
#nullable restore
#else
        public string Password {
            get { return BackingStore?.Get<string>("password"); }
            set { BackingStore?.Set("password", value); }
        }
#endif
        /// <summary>The retainInheritedPermissions property</summary>
        public bool? RetainInheritedPermissions {
            get { return BackingStore?.Get<bool?>("retainInheritedPermissions"); }
            set { BackingStore?.Set("retainInheritedPermissions", value); }
        }
        /// <summary>The scope property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Scope {
            get { return BackingStore?.Get<string?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#nullable restore
#else
        public string Scope {
            get { return BackingStore?.Get<string>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public string Type {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new createLinkPostRequestBody and sets the default values.
        /// </summary>
        public CreateLinkPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateLinkPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateLinkPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"message", n => { Message = n.GetStringValue(); } },
                {"password", n => { Password = n.GetStringValue(); } },
                {"retainInheritedPermissions", n => { RetainInheritedPermissions = n.GetBoolValue(); } },
                {"scope", n => { Scope = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("password", Password);
            writer.WriteBoolValue("retainInheritedPermissions", RetainInheritedPermissions);
            writer.WriteStringValue("scope", Scope);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
