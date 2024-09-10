// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Teamwork.SendActivityNotificationToRecipients
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class SendActivityNotificationToRecipientsPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The activityType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityType
        {
            get { return BackingStore?.Get<string?>("activityType"); }
            set { BackingStore?.Set("activityType", value); }
        }
#nullable restore
#else
        public string ActivityType
        {
            get { return BackingStore?.Get<string>("activityType"); }
            set { BackingStore?.Set("activityType", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The chainId property</summary>
        public long? ChainId
        {
            get { return BackingStore?.Get<long?>("chainId"); }
            set { BackingStore?.Set("chainId", value); }
        }
        /// <summary>The previewText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ItemBody? PreviewText
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ItemBody?>("previewText"); }
            set { BackingStore?.Set("previewText", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ItemBody PreviewText
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ItemBody>("previewText"); }
            set { BackingStore?.Set("previewText", value); }
        }
#endif
        /// <summary>The recipients property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TeamworkNotificationRecipient>? Recipients
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TeamworkNotificationRecipient>?>("recipients"); }
            set { BackingStore?.Set("recipients", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TeamworkNotificationRecipient> Recipients
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TeamworkNotificationRecipient>>("recipients"); }
            set { BackingStore?.Set("recipients", value); }
        }
#endif
        /// <summary>The teamsAppId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamsAppId
        {
            get { return BackingStore?.Get<string?>("teamsAppId"); }
            set { BackingStore?.Set("teamsAppId", value); }
        }
#nullable restore
#else
        public string TeamsAppId
        {
            get { return BackingStore?.Get<string>("teamsAppId"); }
            set { BackingStore?.Set("teamsAppId", value); }
        }
#endif
        /// <summary>The templateParameters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.KeyValuePair>? TemplateParameters
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.KeyValuePair>?>("templateParameters"); }
            set { BackingStore?.Set("templateParameters", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.KeyValuePair> TemplateParameters
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.KeyValuePair>>("templateParameters"); }
            set { BackingStore?.Set("templateParameters", value); }
        }
#endif
        /// <summary>The topic property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TeamworkActivityTopic? Topic
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamworkActivityTopic?>("topic"); }
            set { BackingStore?.Set("topic", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TeamworkActivityTopic Topic
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamworkActivityTopic>("topic"); }
            set { BackingStore?.Set("topic", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Teamwork.SendActivityNotificationToRecipients.SendActivityNotificationToRecipientsPostRequestBody"/> and sets the default values.
        /// </summary>
        public SendActivityNotificationToRecipientsPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Teamwork.SendActivityNotificationToRecipients.SendActivityNotificationToRecipientsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Teamwork.SendActivityNotificationToRecipients.SendActivityNotificationToRecipientsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Teamwork.SendActivityNotificationToRecipients.SendActivityNotificationToRecipientsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "activityType", n => { ActivityType = n.GetStringValue(); } },
                { "chainId", n => { ChainId = n.GetLongValue(); } },
                { "previewText", n => { PreviewText = n.GetObjectValue<global::Microsoft.Graph.Models.ItemBody>(global::Microsoft.Graph.Models.ItemBody.CreateFromDiscriminatorValue); } },
                { "recipients", n => { Recipients = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TeamworkNotificationRecipient>(global::Microsoft.Graph.Models.TeamworkNotificationRecipient.CreateFromDiscriminatorValue)?.AsList(); } },
                { "teamsAppId", n => { TeamsAppId = n.GetStringValue(); } },
                { "templateParameters", n => { TemplateParameters = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.KeyValuePair>(global::Microsoft.Graph.Models.KeyValuePair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "topic", n => { Topic = n.GetObjectValue<global::Microsoft.Graph.Models.TeamworkActivityTopic>(global::Microsoft.Graph.Models.TeamworkActivityTopic.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ItemBody>("previewText", PreviewText);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TeamworkNotificationRecipient>("recipients", Recipients);
            writer.WriteStringValue("teamsAppId", TeamsAppId);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.KeyValuePair>("templateParameters", TemplateParameters);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TeamworkActivityTopic>("topic", Topic);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
