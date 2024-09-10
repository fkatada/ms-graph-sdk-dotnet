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
    public partial class Place : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The street address of the place.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.PhysicalAddress? Address
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PhysicalAddress?>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.PhysicalAddress Address
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PhysicalAddress>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#endif
        /// <summary>The name associated with the place.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Specifies the place location in latitude, longitude, and (optionally) altitude coordinates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.OutlookGeoCoordinates? GeoCoordinates
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OutlookGeoCoordinates?>("geoCoordinates"); }
            set { BackingStore?.Set("geoCoordinates", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.OutlookGeoCoordinates GeoCoordinates
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OutlookGeoCoordinates>("geoCoordinates"); }
            set { BackingStore?.Set("geoCoordinates", value); }
        }
#endif
        /// <summary>The phone number of the place.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone
        {
            get { return BackingStore?.Get<string?>("phone"); }
            set { BackingStore?.Set("phone", value); }
        }
#nullable restore
#else
        public string Phone
        {
            get { return BackingStore?.Get<string>("phone"); }
            set { BackingStore?.Set("phone", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Place"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Place CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.room" => new global::Microsoft.Graph.Models.Room(),
                "#microsoft.graph.roomList" => new global::Microsoft.Graph.Models.RoomList(),
                _ => new global::Microsoft.Graph.Models.Place(),
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
                { "address", n => { Address = n.GetObjectValue<global::Microsoft.Graph.Models.PhysicalAddress>(global::Microsoft.Graph.Models.PhysicalAddress.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "geoCoordinates", n => { GeoCoordinates = n.GetObjectValue<global::Microsoft.Graph.Models.OutlookGeoCoordinates>(global::Microsoft.Graph.Models.OutlookGeoCoordinates.CreateFromDiscriminatorValue); } },
                { "phone", n => { Phone = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.PhysicalAddress>("address", Address);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.OutlookGeoCoordinates>("geoCoordinates", GeoCoordinates);
            writer.WriteStringValue("phone", Phone);
        }
    }
}
#pragma warning restore CS0618
