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
    public partial class OpenShift : global::Microsoft.Graph.Models.ChangeTrackedEntity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Draft changes in the openShift are only visible to managers until they&apos;re shared.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.OpenShiftItem? DraftOpenShift
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OpenShiftItem?>("draftOpenShift"); }
            set { BackingStore?.Set("draftOpenShift", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.OpenShiftItem DraftOpenShift
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OpenShiftItem>("draftOpenShift"); }
            set { BackingStore?.Set("draftOpenShift", value); }
        }
#endif
        /// <summary>The openShift is marked for deletion, a process that is finalized when the schedule is shared.</summary>
        public bool? IsStagedForDeletion
        {
            get { return BackingStore?.Get<bool?>("isStagedForDeletion"); }
            set { BackingStore?.Set("isStagedForDeletion", value); }
        }
        /// <summary>The ID of the schedulingGroup that contains the openShift.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SchedulingGroupId
        {
            get { return BackingStore?.Get<string?>("schedulingGroupId"); }
            set { BackingStore?.Set("schedulingGroupId", value); }
        }
#nullable restore
#else
        public string SchedulingGroupId
        {
            get { return BackingStore?.Get<string>("schedulingGroupId"); }
            set { BackingStore?.Set("schedulingGroupId", value); }
        }
#endif
        /// <summary>The shared version of this openShift that is viewable by both employees and managers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.OpenShiftItem? SharedOpenShift
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OpenShiftItem?>("sharedOpenShift"); }
            set { BackingStore?.Set("sharedOpenShift", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.OpenShiftItem SharedOpenShift
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OpenShiftItem>("sharedOpenShift"); }
            set { BackingStore?.Set("sharedOpenShift", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.OpenShift"/> and sets the default values.
        /// </summary>
        public OpenShift() : base()
        {
            OdataType = "#microsoft.graph.openShift";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.OpenShift"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.OpenShift CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.OpenShift();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "draftOpenShift", n => { DraftOpenShift = n.GetObjectValue<global::Microsoft.Graph.Models.OpenShiftItem>(global::Microsoft.Graph.Models.OpenShiftItem.CreateFromDiscriminatorValue); } },
                { "isStagedForDeletion", n => { IsStagedForDeletion = n.GetBoolValue(); } },
                { "schedulingGroupId", n => { SchedulingGroupId = n.GetStringValue(); } },
                { "sharedOpenShift", n => { SharedOpenShift = n.GetObjectValue<global::Microsoft.Graph.Models.OpenShiftItem>(global::Microsoft.Graph.Models.OpenShiftItem.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.OpenShiftItem>("draftOpenShift", DraftOpenShift);
            writer.WriteBoolValue("isStagedForDeletion", IsStagedForDeletion);
            writer.WriteStringValue("schedulingGroupId", SchedulingGroupId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.OpenShiftItem>("sharedOpenShift", SharedOpenShift);
        }
    }
}
#pragma warning restore CS0618
