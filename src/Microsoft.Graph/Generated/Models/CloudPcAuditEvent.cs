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
    public partial class CloudPcAuditEvent : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The friendly name of the audit activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Activity
        {
            get { return BackingStore?.Get<string?>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#nullable restore
#else
        public string Activity
        {
            get { return BackingStore?.Get<string>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#endif
        /// <summary>The date time in UTC when the activity was performed. Read-only.</summary>
        public DateTimeOffset? ActivityDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("activityDateTime"); }
            set { BackingStore?.Set("activityDateTime", value); }
        }
        /// <summary>The activityOperationType property</summary>
        public global::Microsoft.Graph.Models.CloudPcAuditActivityOperationType? ActivityOperationType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CloudPcAuditActivityOperationType?>("activityOperationType"); }
            set { BackingStore?.Set("activityOperationType", value); }
        }
        /// <summary>The activityResult property</summary>
        public global::Microsoft.Graph.Models.CloudPcAuditActivityResult? ActivityResult
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CloudPcAuditActivityResult?>("activityResult"); }
            set { BackingStore?.Set("activityResult", value); }
        }
        /// <summary>The type of activity that was performed. Read-only.</summary>
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
        /// <summary>The actor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.CloudPcAuditActor? Actor
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CloudPcAuditActor?>("actor"); }
            set { BackingStore?.Set("actor", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.CloudPcAuditActor Actor
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CloudPcAuditActor>("actor"); }
            set { BackingStore?.Set("actor", value); }
        }
#endif
        /// <summary>The category property</summary>
        public global::Microsoft.Graph.Models.CloudPcAuditCategory? Category
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CloudPcAuditCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>The component name for the audit event. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ComponentName
        {
            get { return BackingStore?.Get<string?>("componentName"); }
            set { BackingStore?.Set("componentName", value); }
        }
#nullable restore
#else
        public string ComponentName
        {
            get { return BackingStore?.Get<string>("componentName"); }
            set { BackingStore?.Set("componentName", value); }
        }
#endif
        /// <summary>The client request ID that is used to correlate activity within the system. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId
        {
            get { return BackingStore?.Get<string?>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#nullable restore
#else
        public string CorrelationId
        {
            get { return BackingStore?.Get<string>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#endif
        /// <summary>The display name for the audit event. Read-only.</summary>
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
        /// <summary>The list of cloudPcAuditResource objects. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.CloudPcAuditResource>? Resources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CloudPcAuditResource>?>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.CloudPcAuditResource> Resources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CloudPcAuditResource>>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.CloudPcAuditEvent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.CloudPcAuditEvent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.CloudPcAuditEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activity", n => { Activity = n.GetStringValue(); } },
                { "activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                { "activityOperationType", n => { ActivityOperationType = n.GetEnumValue<global::Microsoft.Graph.Models.CloudPcAuditActivityOperationType>(); } },
                { "activityResult", n => { ActivityResult = n.GetEnumValue<global::Microsoft.Graph.Models.CloudPcAuditActivityResult>(); } },
                { "activityType", n => { ActivityType = n.GetStringValue(); } },
                { "actor", n => { Actor = n.GetObjectValue<global::Microsoft.Graph.Models.CloudPcAuditActor>(global::Microsoft.Graph.Models.CloudPcAuditActor.CreateFromDiscriminatorValue); } },
                { "category", n => { Category = n.GetEnumValue<global::Microsoft.Graph.Models.CloudPcAuditCategory>(); } },
                { "componentName", n => { ComponentName = n.GetStringValue(); } },
                { "correlationId", n => { CorrelationId = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "resources", n => { Resources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.CloudPcAuditResource>(global::Microsoft.Graph.Models.CloudPcAuditResource.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteStringValue("activity", Activity);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.CloudPcAuditActivityOperationType>("activityOperationType", ActivityOperationType);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.CloudPcAuditActivityResult>("activityResult", ActivityResult);
            writer.WriteStringValue("activityType", ActivityType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.CloudPcAuditActor>("actor", Actor);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.CloudPcAuditCategory>("category", Category);
            writer.WriteStringValue("componentName", ComponentName);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.CloudPcAuditResource>("resources", Resources);
        }
    }
}
#pragma warning restore CS0618
