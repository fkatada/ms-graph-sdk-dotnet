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
    public partial class Teamwork : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of deleted chats.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.DeletedChat>? DeletedChats
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DeletedChat>?>("deletedChats"); }
            set { BackingStore?.Set("deletedChats", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.DeletedChat> DeletedChats
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DeletedChat>>("deletedChats"); }
            set { BackingStore?.Set("deletedChats", value); }
        }
#endif
        /// <summary>The deleted team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.DeletedTeam>? DeletedTeams
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DeletedTeam>?>("deletedTeams"); }
            set { BackingStore?.Set("deletedTeams", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.DeletedTeam> DeletedTeams
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DeletedTeam>>("deletedTeams"); }
            set { BackingStore?.Set("deletedTeams", value); }
        }
#endif
        /// <summary>Indicates whether Microsoft Teams is enabled for the organization.</summary>
        public bool? IsTeamsEnabled
        {
            get { return BackingStore?.Get<bool?>("isTeamsEnabled"); }
            set { BackingStore?.Set("isTeamsEnabled", value); }
        }
        /// <summary>Represents the region of the organization or the tenant. The region value can be any region supported by the Teams payload. The possible values are: Americas, Europe and MiddleEast, Asia Pacific, UAE, Australia, Brazil, Canada, Switzerland, Germany, France, India, Japan, South Korea, Norway, Singapore, United Kingdom, South Africa, Sweden, Qatar, Poland, Italy, Israel, Spain, Mexico, USGov Community Cloud, USGov Community Cloud High, USGov Department of Defense, and China.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region
        {
            get { return BackingStore?.Get<string?>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#nullable restore
#else
        public string Region
        {
            get { return BackingStore?.Get<string>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#endif
        /// <summary>Represents tenant-wide settings for all Teams apps in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TeamsAppSettings? TeamsAppSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamsAppSettings?>("teamsAppSettings"); }
            set { BackingStore?.Set("teamsAppSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TeamsAppSettings TeamsAppSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamsAppSettings>("teamsAppSettings"); }
            set { BackingStore?.Set("teamsAppSettings", value); }
        }
#endif
        /// <summary>The workforceIntegrations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WorkforceIntegration>? WorkforceIntegrations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkforceIntegration>?>("workforceIntegrations"); }
            set { BackingStore?.Set("workforceIntegrations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WorkforceIntegration> WorkforceIntegrations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkforceIntegration>>("workforceIntegrations"); }
            set { BackingStore?.Set("workforceIntegrations", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Teamwork"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Teamwork CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Teamwork();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deletedChats", n => { DeletedChats = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.DeletedChat>(global::Microsoft.Graph.Models.DeletedChat.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deletedTeams", n => { DeletedTeams = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.DeletedTeam>(global::Microsoft.Graph.Models.DeletedTeam.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isTeamsEnabled", n => { IsTeamsEnabled = n.GetBoolValue(); } },
                { "region", n => { Region = n.GetStringValue(); } },
                { "teamsAppSettings", n => { TeamsAppSettings = n.GetObjectValue<global::Microsoft.Graph.Models.TeamsAppSettings>(global::Microsoft.Graph.Models.TeamsAppSettings.CreateFromDiscriminatorValue); } },
                { "workforceIntegrations", n => { WorkforceIntegrations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkforceIntegration>(global::Microsoft.Graph.Models.WorkforceIntegration.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.DeletedChat>("deletedChats", DeletedChats);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.DeletedTeam>("deletedTeams", DeletedTeams);
            writer.WriteBoolValue("isTeamsEnabled", IsTeamsEnabled);
            writer.WriteStringValue("region", Region);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TeamsAppSettings>("teamsAppSettings", TeamsAppSettings);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkforceIntegration>("workforceIntegrations", WorkforceIntegrations);
        }
    }
}
#pragma warning restore CS0618
