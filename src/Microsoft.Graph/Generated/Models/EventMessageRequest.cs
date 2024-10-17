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
    public partial class EventMessageRequest : global::Microsoft.Graph.Models.EventMessage, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>True if the meeting organizer allows invitees to propose a new time when responding, false otherwise. Optional. Default is true.</summary>
        public bool? AllowNewTimeProposals
        {
            get { return BackingStore?.Get<bool?>("allowNewTimeProposals"); }
            set { BackingStore?.Set("allowNewTimeProposals", value); }
        }
        /// <summary>The meetingRequestType property</summary>
        public global::Microsoft.Graph.Models.MeetingRequestType? MeetingRequestType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.MeetingRequestType?>("meetingRequestType"); }
            set { BackingStore?.Set("meetingRequestType", value); }
        }
        /// <summary>If the meeting update changes the meeting end time, this property specifies the previous meeting end time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DateTimeTimeZone? PreviousEndDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone?>("previousEndDateTime"); }
            set { BackingStore?.Set("previousEndDateTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DateTimeTimeZone PreviousEndDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone>("previousEndDateTime"); }
            set { BackingStore?.Set("previousEndDateTime", value); }
        }
#endif
        /// <summary>If the meeting update changes the meeting location, this property specifies the previous meeting location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Location? PreviousLocation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Location?>("previousLocation"); }
            set { BackingStore?.Set("previousLocation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Location PreviousLocation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Location>("previousLocation"); }
            set { BackingStore?.Set("previousLocation", value); }
        }
#endif
        /// <summary>If the meeting update changes the meeting start time, this property specifies the previous meeting start time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DateTimeTimeZone? PreviousStartDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone?>("previousStartDateTime"); }
            set { BackingStore?.Set("previousStartDateTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DateTimeTimeZone PreviousStartDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone>("previousStartDateTime"); }
            set { BackingStore?.Set("previousStartDateTime", value); }
        }
#endif
        /// <summary>Set to true if the sender would like the invitee to send a response to the requested meeting.</summary>
        public bool? ResponseRequested
        {
            get { return BackingStore?.Get<bool?>("responseRequested"); }
            set { BackingStore?.Set("responseRequested", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.EventMessageRequest"/> and sets the default values.
        /// </summary>
        public EventMessageRequest() : base()
        {
            OdataType = "#microsoft.graph.eventMessageRequest";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.EventMessageRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.EventMessageRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.EventMessageRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowNewTimeProposals", n => { AllowNewTimeProposals = n.GetBoolValue(); } },
                { "meetingRequestType", n => { MeetingRequestType = n.GetEnumValue<global::Microsoft.Graph.Models.MeetingRequestType>(); } },
                { "previousEndDateTime", n => { PreviousEndDateTime = n.GetObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>(global::Microsoft.Graph.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "previousLocation", n => { PreviousLocation = n.GetObjectValue<global::Microsoft.Graph.Models.Location>(global::Microsoft.Graph.Models.Location.CreateFromDiscriminatorValue); } },
                { "previousStartDateTime", n => { PreviousStartDateTime = n.GetObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>(global::Microsoft.Graph.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "responseRequested", n => { ResponseRequested = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("allowNewTimeProposals", AllowNewTimeProposals);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.MeetingRequestType>("meetingRequestType", MeetingRequestType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>("previousEndDateTime", PreviousEndDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Location>("previousLocation", PreviousLocation);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>("previousStartDateTime", PreviousStartDateTime);
            writer.WriteBoolValue("responseRequested", ResponseRequested);
        }
    }
}
#pragma warning restore CS0618
