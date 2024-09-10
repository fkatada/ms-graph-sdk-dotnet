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
    public partial class ItemActivityStat : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Statistics about the access actions in this interval. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ItemActionStat? Access
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ItemActionStat?>("access"); }
            set { BackingStore?.Set("access", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ItemActionStat Access
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ItemActionStat>("access"); }
            set { BackingStore?.Set("access", value); }
        }
#endif
        /// <summary>Exposes the itemActivities represented in this itemActivityStat resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ItemActivity>? Activities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ItemActivity>?>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ItemActivity> Activities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ItemActivity>>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#endif
        /// <summary>Statistics about the create actions in this interval. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ItemActionStat? Create
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ItemActionStat?>("create"); }
            set { BackingStore?.Set("create", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ItemActionStat Create
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ItemActionStat>("create"); }
            set { BackingStore?.Set("create", value); }
        }
#endif
        /// <summary>Statistics about the delete actions in this interval. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ItemActionStat? Delete
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ItemActionStat?>("delete"); }
            set { BackingStore?.Set("delete", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ItemActionStat Delete
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ItemActionStat>("delete"); }
            set { BackingStore?.Set("delete", value); }
        }
#endif
        /// <summary>Statistics about the edit actions in this interval. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ItemActionStat? Edit
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ItemActionStat?>("edit"); }
            set { BackingStore?.Set("edit", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ItemActionStat Edit
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ItemActionStat>("edit"); }
            set { BackingStore?.Set("edit", value); }
        }
#endif
        /// <summary>When the interval ends. Read-only.</summary>
        public DateTimeOffset? EndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>Indicates that the statistics in this interval are based on incomplete data. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IncompleteData? IncompleteData
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IncompleteData?>("incompleteData"); }
            set { BackingStore?.Set("incompleteData", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IncompleteData IncompleteData
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IncompleteData>("incompleteData"); }
            set { BackingStore?.Set("incompleteData", value); }
        }
#endif
        /// <summary>Indicates whether the item is &apos;trending.&apos; Read-only.</summary>
        public bool? IsTrending
        {
            get { return BackingStore?.Get<bool?>("isTrending"); }
            set { BackingStore?.Set("isTrending", value); }
        }
        /// <summary>Statistics about the move actions in this interval. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ItemActionStat? Move
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ItemActionStat?>("move"); }
            set { BackingStore?.Set("move", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ItemActionStat Move
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ItemActionStat>("move"); }
            set { BackingStore?.Set("move", value); }
        }
#endif
        /// <summary>When the interval starts. Read-only.</summary>
        public DateTimeOffset? StartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ItemActivityStat"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ItemActivityStat CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ItemActivityStat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "access", n => { Access = n.GetObjectValue<global::Microsoft.Graph.Models.ItemActionStat>(global::Microsoft.Graph.Models.ItemActionStat.CreateFromDiscriminatorValue); } },
                { "activities", n => { Activities = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ItemActivity>(global::Microsoft.Graph.Models.ItemActivity.CreateFromDiscriminatorValue)?.AsList(); } },
                { "create", n => { Create = n.GetObjectValue<global::Microsoft.Graph.Models.ItemActionStat>(global::Microsoft.Graph.Models.ItemActionStat.CreateFromDiscriminatorValue); } },
                { "delete", n => { Delete = n.GetObjectValue<global::Microsoft.Graph.Models.ItemActionStat>(global::Microsoft.Graph.Models.ItemActionStat.CreateFromDiscriminatorValue); } },
                { "edit", n => { Edit = n.GetObjectValue<global::Microsoft.Graph.Models.ItemActionStat>(global::Microsoft.Graph.Models.ItemActionStat.CreateFromDiscriminatorValue); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "incompleteData", n => { IncompleteData = n.GetObjectValue<global::Microsoft.Graph.Models.IncompleteData>(global::Microsoft.Graph.Models.IncompleteData.CreateFromDiscriminatorValue); } },
                { "isTrending", n => { IsTrending = n.GetBoolValue(); } },
                { "move", n => { Move = n.GetObjectValue<global::Microsoft.Graph.Models.ItemActionStat>(global::Microsoft.Graph.Models.ItemActionStat.CreateFromDiscriminatorValue); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ItemActionStat>("access", Access);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ItemActivity>("activities", Activities);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ItemActionStat>("create", Create);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ItemActionStat>("delete", Delete);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ItemActionStat>("edit", Edit);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IncompleteData>("incompleteData", IncompleteData);
            writer.WriteBoolValue("isTrending", IsTrending);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ItemActionStat>("move", Move);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}
#pragma warning restore CS0618
