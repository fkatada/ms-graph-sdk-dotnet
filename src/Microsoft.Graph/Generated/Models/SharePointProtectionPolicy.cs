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
    public partial class SharePointProtectionPolicy : global::Microsoft.Graph.Models.ProtectionPolicyBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The rules associated with the SharePoint Protection policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SiteProtectionRule>? SiteInclusionRules
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SiteProtectionRule>?>("siteInclusionRules"); }
            set { BackingStore?.Set("siteInclusionRules", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SiteProtectionRule> SiteInclusionRules
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SiteProtectionRule>>("siteInclusionRules"); }
            set { BackingStore?.Set("siteInclusionRules", value); }
        }
#endif
        /// <summary>The protection units (sites) that are protected under the site protection policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SiteProtectionUnit>? SiteProtectionUnits
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SiteProtectionUnit>?>("siteProtectionUnits"); }
            set { BackingStore?.Set("siteProtectionUnits", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SiteProtectionUnit> SiteProtectionUnits
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SiteProtectionUnit>>("siteProtectionUnits"); }
            set { BackingStore?.Set("siteProtectionUnits", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.SharePointProtectionPolicy"/> and sets the default values.
        /// </summary>
        public SharePointProtectionPolicy() : base()
        {
            OdataType = "#microsoft.graph.sharePointProtectionPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SharePointProtectionPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.SharePointProtectionPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.SharePointProtectionPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "siteInclusionRules", n => { SiteInclusionRules = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SiteProtectionRule>(global::Microsoft.Graph.Models.SiteProtectionRule.CreateFromDiscriminatorValue)?.AsList(); } },
                { "siteProtectionUnits", n => { SiteProtectionUnits = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SiteProtectionUnit>(global::Microsoft.Graph.Models.SiteProtectionUnit.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SiteProtectionRule>("siteInclusionRules", SiteInclusionRules);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SiteProtectionUnit>("siteProtectionUnits", SiteProtectionUnits);
        }
    }
}
#pragma warning restore CS0618
