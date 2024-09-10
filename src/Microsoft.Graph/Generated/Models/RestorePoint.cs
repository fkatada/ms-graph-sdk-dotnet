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
    public partial class RestorePoint : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Expiration date time of the restore point.</summary>
        public DateTimeOffset? ExpirationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>Date time when the restore point was created.</summary>
        public DateTimeOffset? ProtectionDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("protectionDateTime"); }
            set { BackingStore?.Set("protectionDateTime", value); }
        }
        /// <summary>The site, drive, or mailbox units that are protected under a protection policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ProtectionUnitBase? ProtectionUnit
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ProtectionUnitBase?>("protectionUnit"); }
            set { BackingStore?.Set("protectionUnit", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ProtectionUnitBase ProtectionUnit
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ProtectionUnitBase>("protectionUnit"); }
            set { BackingStore?.Set("protectionUnit", value); }
        }
#endif
        /// <summary>The type of the restore point. The possible values are: none, fastRestore, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.RestorePointTags? Tags
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RestorePointTags?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.RestorePoint"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.RestorePoint CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.RestorePoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "protectionDateTime", n => { ProtectionDateTime = n.GetDateTimeOffsetValue(); } },
                { "protectionUnit", n => { ProtectionUnit = n.GetObjectValue<global::Microsoft.Graph.Models.ProtectionUnitBase>(global::Microsoft.Graph.Models.ProtectionUnitBase.CreateFromDiscriminatorValue); } },
                { "tags", n => { Tags = n.GetEnumValue<global::Microsoft.Graph.Models.RestorePointTags>(); } },
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
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("protectionDateTime", ProtectionDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ProtectionUnitBase>("protectionUnit", ProtectionUnit);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.RestorePointTags>("tags", Tags);
        }
    }
}
#pragma warning restore CS0618
