// <auto-generated/>
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Users.Item.JoinedTeams.Item.SendActivityNotification {
    #pragma warning disable CS1591
    public class SendActivityNotificationPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The activityType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityType {
            get { return BackingStore?.Get<string?>("activityType"); }
            set { BackingStore?.Set("activityType", value); }
        }
#nullable restore
#else
        public string ActivityType {
            get { return BackingStore?.Get<string>("activityType"); }
            set { BackingStore?.Set("activityType", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? throw new InvalidOperationException("AdditionalData can not be null"); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The chainId property</summary>
        public long? ChainId {
            get { return BackingStore?.Get<long?>("chainId"); }
            set { BackingStore?.Set("chainId", value); }
        }
        /// <summary>The previewText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? PreviewText {
            get { return BackingStore?.Get<ItemBody?>("previewText"); }
            set { BackingStore?.Set("previewText", value); }
        }
#nullable restore
#else
        public ItemBody PreviewText {
            get { return BackingStore?.Get<ItemBody>("previewText"); }
            set { BackingStore?.Set("previewText", value); }
        }
#endif
        /// <summary>The recipient property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkNotificationRecipient? Recipient {
            get { return BackingStore?.Get<TeamworkNotificationRecipient?>("recipient"); }
            set { BackingStore?.Set("recipient", value); }
        }
#nullable restore
#else
        public TeamworkNotificationRecipient Recipient {
            get { return BackingStore?.Get<TeamworkNotificationRecipient>("recipient"); }
            set { BackingStore?.Set("recipient", value); }
        }
#endif
        /// <summary>The teamsAppId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamsAppId {
            get { return BackingStore?.Get<string?>("teamsAppId"); }
            set { BackingStore?.Set("teamsAppId", value); }
        }
#nullable restore
#else
        public string TeamsAppId {
            get { return BackingStore?.Get<string>("teamsAppId"); }
            set { BackingStore?.Set("teamsAppId", value); }
        }
#endif
        /// <summary>The templateParameters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.KeyValuePair>? TemplateParameters {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.KeyValuePair>?>("templateParameters"); }
            set { BackingStore?.Set("templateParameters", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.KeyValuePair> TemplateParameters {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.KeyValuePair>>("templateParameters"); }
            set { BackingStore?.Set("templateParameters", value); }
        }
#endif
        /// <summary>The topic property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkActivityTopic? Topic {
            get { return BackingStore?.Get<TeamworkActivityTopic?>("topic"); }
            set { BackingStore?.Set("topic", value); }
        }
#nullable restore
#else
        public TeamworkActivityTopic Topic {
            get { return BackingStore?.Get<TeamworkActivityTopic>("topic"); }
            set { BackingStore?.Set("topic", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SendActivityNotificationPostRequestBody"/> and sets the default values.
        /// </summary>
        public SendActivityNotificationPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SendActivityNotificationPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SendActivityNotificationPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SendActivityNotificationPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"activityType", n => { ActivityType = n.GetStringValue(); } },
                {"chainId", n => { ChainId = n.GetLongValue(); } },
                {"previewText", n => { PreviewText = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"recipient", n => { Recipient = n.GetObjectValue<TeamworkNotificationRecipient>(TeamworkNotificationRecipient.CreateFromDiscriminatorValue); } },
                {"teamsAppId", n => { TeamsAppId = n.GetStringValue(); } },
                {"templateParameters", n => { TemplateParameters = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.KeyValuePair>(Microsoft.Graph.Models.KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"topic", n => { Topic = n.GetObjectValue<TeamworkActivityTopic>(TeamworkActivityTopic.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activityType", ActivityType);
            writer.WriteLongValue("chainId", ChainId);
            writer.WriteObjectValue<ItemBody>("previewText", PreviewText);
            writer.WriteObjectValue<TeamworkNotificationRecipient>("recipient", Recipient);
            writer.WriteStringValue("teamsAppId", TeamsAppId);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.KeyValuePair>("templateParameters", TemplateParameters);
            writer.WriteObjectValue<TeamworkActivityTopic>("topic", Topic);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
