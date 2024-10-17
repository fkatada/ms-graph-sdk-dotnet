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
    public partial class TeleconferenceDeviceVideoQuality : global::Microsoft.Graph.Models.TeleconferenceDeviceMediaQuality, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The average inbound stream video bit rate per second.</summary>
        public double? AverageInboundBitRate
        {
            get { return BackingStore?.Get<double?>("averageInboundBitRate"); }
            set { BackingStore?.Set("averageInboundBitRate", value); }
        }
        /// <summary>The average inbound stream video frame rate per second.</summary>
        public double? AverageInboundFrameRate
        {
            get { return BackingStore?.Get<double?>("averageInboundFrameRate"); }
            set { BackingStore?.Set("averageInboundFrameRate", value); }
        }
        /// <summary>The average outbound stream video bit rate per second.</summary>
        public double? AverageOutboundBitRate
        {
            get { return BackingStore?.Get<double?>("averageOutboundBitRate"); }
            set { BackingStore?.Set("averageOutboundBitRate", value); }
        }
        /// <summary>The average outbound stream video frame rate per second.</summary>
        public double? AverageOutboundFrameRate
        {
            get { return BackingStore?.Get<double?>("averageOutboundFrameRate"); }
            set { BackingStore?.Set("averageOutboundFrameRate", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.TeleconferenceDeviceVideoQuality"/> and sets the default values.
        /// </summary>
        public TeleconferenceDeviceVideoQuality() : base()
        {
            OdataType = "#microsoft.graph.teleconferenceDeviceVideoQuality";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TeleconferenceDeviceVideoQuality"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.TeleconferenceDeviceVideoQuality CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.teleconferenceDeviceScreenSharingQuality" => new global::Microsoft.Graph.Models.TeleconferenceDeviceScreenSharingQuality(),
                _ => new global::Microsoft.Graph.Models.TeleconferenceDeviceVideoQuality(),
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
                { "averageInboundBitRate", n => { AverageInboundBitRate = n.GetDoubleValue(); } },
                { "averageInboundFrameRate", n => { AverageInboundFrameRate = n.GetDoubleValue(); } },
                { "averageOutboundBitRate", n => { AverageOutboundBitRate = n.GetDoubleValue(); } },
                { "averageOutboundFrameRate", n => { AverageOutboundFrameRate = n.GetDoubleValue(); } },
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
            writer.WriteDoubleValue("averageInboundBitRate", AverageInboundBitRate);
            writer.WriteDoubleValue("averageInboundFrameRate", AverageInboundFrameRate);
            writer.WriteDoubleValue("averageOutboundBitRate", AverageOutboundBitRate);
            writer.WriteDoubleValue("averageOutboundFrameRate", AverageOutboundFrameRate);
        }
    }
}
#pragma warning restore CS0618
