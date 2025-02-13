// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Support for this Entity is being deprecated starting May 2026 &amp; will no longer be supported.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceConfigurationState : global::Microsoft.Graph.Models.Entity, IParsable
    {
        /// <summary>The name of the policy for this policyBase</summary>
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
        /// <summary>Supported platform types for policies.</summary>
        public global::Microsoft.Graph.Models.PolicyPlatformType? PlatformType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PolicyPlatformType?>("platformType"); }
            set { BackingStore?.Set("platformType", value); }
        }
        /// <summary>Count of how many setting a policy holds</summary>
        public int? SettingCount
        {
            get { return BackingStore?.Get<int?>("settingCount"); }
            set { BackingStore?.Set("settingCount", value); }
        }
        /// <summary>The settingStates property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.DeviceConfigurationSettingState>? SettingStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DeviceConfigurationSettingState>?>("settingStates"); }
            set { BackingStore?.Set("settingStates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.DeviceConfigurationSettingState> SettingStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DeviceConfigurationSettingState>>("settingStates"); }
            set { BackingStore?.Set("settingStates", value); }
        }
#endif
        /// <summary>The state property</summary>
        public global::Microsoft.Graph.Models.ComplianceStatus? State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ComplianceStatus?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>The version of the policy</summary>
        public int? Version
        {
            get { return BackingStore?.Get<int?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceConfigurationState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.DeviceConfigurationState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.DeviceConfigurationState();
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
                { "platformType", n => { PlatformType = n.GetEnumValue<global::Microsoft.Graph.Models.PolicyPlatformType>(); } },
                { "settingCount", n => { SettingCount = n.GetIntValue(); } },
                { "settingStates", n => { SettingStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.DeviceConfigurationSettingState>(global::Microsoft.Graph.Models.DeviceConfigurationSettingState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "state", n => { State = n.GetEnumValue<global::Microsoft.Graph.Models.ComplianceStatus>(); } },
                { "version", n => { Version = n.GetIntValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.PolicyPlatformType>("platformType", PlatformType);
            writer.WriteIntValue("settingCount", SettingCount);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.DeviceConfigurationSettingState>("settingStates", SettingStates);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ComplianceStatus>("state", State);
            writer.WriteIntValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
