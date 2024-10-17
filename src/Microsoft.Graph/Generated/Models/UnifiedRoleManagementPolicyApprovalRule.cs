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
    public partial class UnifiedRoleManagementPolicyApprovalRule : global::Microsoft.Graph.Models.UnifiedRoleManagementPolicyRule, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The settings for approval of the role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ApprovalSettings? Setting
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ApprovalSettings?>("setting"); }
            set { BackingStore?.Set("setting", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ApprovalSettings Setting
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ApprovalSettings>("setting"); }
            set { BackingStore?.Set("setting", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.UnifiedRoleManagementPolicyApprovalRule"/> and sets the default values.
        /// </summary>
        public UnifiedRoleManagementPolicyApprovalRule() : base()
        {
            OdataType = "#microsoft.graph.unifiedRoleManagementPolicyApprovalRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.UnifiedRoleManagementPolicyApprovalRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.UnifiedRoleManagementPolicyApprovalRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.UnifiedRoleManagementPolicyApprovalRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "setting", n => { Setting = n.GetObjectValue<global::Microsoft.Graph.Models.ApprovalSettings>(global::Microsoft.Graph.Models.ApprovalSettings.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ApprovalSettings>("setting", Setting);
        }
    }
}
#pragma warning restore CS0618
