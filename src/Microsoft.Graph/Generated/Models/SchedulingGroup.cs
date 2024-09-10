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
    public partial class SchedulingGroup : global::Microsoft.Graph.Models.ChangeTrackedEntity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The display name for the schedulingGroup. Required.</summary>
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
        /// <summary>Indicates whether the schedulingGroup can be used when creating new entities or updating existing ones. Required.</summary>
        public bool? IsActive
        {
            get { return BackingStore?.Get<bool?>("isActive"); }
            set { BackingStore?.Set("isActive", value); }
        }
        /// <summary>The list of user IDs that are a member of the schedulingGroup. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UserIds
        {
            get { return BackingStore?.Get<List<string>?>("userIds"); }
            set { BackingStore?.Set("userIds", value); }
        }
#nullable restore
#else
        public List<string> UserIds
        {
            get { return BackingStore?.Get<List<string>>("userIds"); }
            set { BackingStore?.Set("userIds", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.SchedulingGroup"/> and sets the default values.
        /// </summary>
        public SchedulingGroup() : base()
        {
            OdataType = "#microsoft.graph.schedulingGroup";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SchedulingGroup"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.SchedulingGroup CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.SchedulingGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "isActive", n => { IsActive = n.GetBoolValue(); } },
                { "userIds", n => { UserIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("userIds", UserIds);
        }
    }
}
#pragma warning restore CS0618
