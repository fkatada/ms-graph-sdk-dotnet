// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class OauthApplicationEvidence : global::Microsoft.Graph.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Unique identifier of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId
        {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId
        {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>Name of the application.</summary>
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
        /// <summary>The unique identifier of the application object in Azure AD.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectId
        {
            get { return BackingStore?.Get<string?>("objectId"); }
            set { BackingStore?.Set("objectId", value); }
        }
#nullable restore
#else
        public string ObjectId
        {
            get { return BackingStore?.Get<string>("objectId"); }
            set { BackingStore?.Set("objectId", value); }
        }
#endif
        /// <summary>The name of the application publisher.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher
        {
            get { return BackingStore?.Get<string?>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#nullable restore
#else
        public string Publisher
        {
            get { return BackingStore?.Get<string>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Security.OauthApplicationEvidence"/> and sets the default values.
        /// </summary>
        public OauthApplicationEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.oauthApplicationEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.OauthApplicationEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.OauthApplicationEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.OauthApplicationEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "objectId", n => { ObjectId = n.GetStringValue(); } },
                { "publisher", n => { Publisher = n.GetStringValue(); } },
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
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteStringValue("publisher", Publisher);
        }
    }
}
#pragma warning restore CS0618
