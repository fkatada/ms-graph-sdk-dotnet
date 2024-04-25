// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    #pragma warning disable CS1591
    public class MailAssessmentRequest : ThreatAssessmentRequest, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The reason for mail routed to its destination. Possible values are: none, mailFlowRule, safeSender, blockedSender, advancedSpamFiltering, domainAllowList, domainBlockList, notInAddressBook, firstTimeSender, autoPurgeToInbox, autoPurgeToJunk, autoPurgeToDeleted, outbound, notJunk, junk.</summary>
        public MailDestinationRoutingReason? DestinationRoutingReason {
            get { return BackingStore?.Get<MailDestinationRoutingReason?>("destinationRoutingReason"); }
            set { BackingStore?.Set("destinationRoutingReason", value); }
        }
        /// <summary>The resource URI of the mail message for assessment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageUri {
            get { return BackingStore?.Get<string?>("messageUri"); }
            set { BackingStore?.Set("messageUri", value); }
        }
#nullable restore
#else
        public string MessageUri {
            get { return BackingStore?.Get<string>("messageUri"); }
            set { BackingStore?.Set("messageUri", value); }
        }
#endif
        /// <summary>The mail recipient whose policies are used to assess the mail.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecipientEmail {
            get { return BackingStore?.Get<string?>("recipientEmail"); }
            set { BackingStore?.Set("recipientEmail", value); }
        }
#nullable restore
#else
        public string RecipientEmail {
            get { return BackingStore?.Get<string>("recipientEmail"); }
            set { BackingStore?.Set("recipientEmail", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="MailAssessmentRequest"/> and sets the default values.
        /// </summary>
        public MailAssessmentRequest() : base()
        {
            OdataType = "#microsoft.graph.mailAssessmentRequest";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MailAssessmentRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MailAssessmentRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MailAssessmentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"destinationRoutingReason", n => { DestinationRoutingReason = n.GetEnumValue<MailDestinationRoutingReason>(); } },
                {"messageUri", n => { MessageUri = n.GetStringValue(); } },
                {"recipientEmail", n => { RecipientEmail = n.GetStringValue(); } },
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
            writer.WriteEnumValue<MailDestinationRoutingReason>("destinationRoutingReason", DestinationRoutingReason);
            writer.WriteStringValue("messageUri", MessageUri);
            writer.WriteStringValue("recipientEmail", RecipientEmail);
        }
    }
}
