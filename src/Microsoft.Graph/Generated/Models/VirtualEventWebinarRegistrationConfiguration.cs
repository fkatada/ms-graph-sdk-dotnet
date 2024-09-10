// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class VirtualEventWebinarRegistrationConfiguration : global::Microsoft.Graph.Models.VirtualEventRegistrationConfiguration, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The isManualApprovalEnabled property</summary>
        public bool? IsManualApprovalEnabled
        {
            get { return BackingStore?.Get<bool?>("isManualApprovalEnabled"); }
            set { BackingStore?.Set("isManualApprovalEnabled", value); }
        }
        /// <summary>The isWaitlistEnabled property</summary>
        public bool? IsWaitlistEnabled
        {
            get { return BackingStore?.Get<bool?>("isWaitlistEnabled"); }
            set { BackingStore?.Set("isWaitlistEnabled", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.VirtualEventWebinarRegistrationConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.VirtualEventWebinarRegistrationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.VirtualEventWebinarRegistrationConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "isManualApprovalEnabled", n => { IsManualApprovalEnabled = n.GetBoolValue(); } },
                { "isWaitlistEnabled", n => { IsWaitlistEnabled = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("isManualApprovalEnabled", IsManualApprovalEnabled);
            writer.WriteBoolValue("isWaitlistEnabled", IsWaitlistEnabled);
        }
    }
}
#pragma warning restore CS0618
