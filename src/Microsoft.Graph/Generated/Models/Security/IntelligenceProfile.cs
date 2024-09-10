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
    public partial class IntelligenceProfile : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A list of commonly-known aliases for the threat intelligence included in the intelligenceProfile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Aliases
        {
            get { return BackingStore?.Get<List<string>?>("aliases"); }
            set { BackingStore?.Set("aliases", value); }
        }
#nullable restore
#else
        public List<string> Aliases
        {
            get { return BackingStore?.Get<List<string>>("aliases"); }
            set { BackingStore?.Set("aliases", value); }
        }
#endif
        /// <summary>The country/region of origin for the given actor or threat associated with this intelligenceProfile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.IntelligenceProfileCountryOrRegionOfOrigin>? CountriesOrRegionsOfOrigin
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.IntelligenceProfileCountryOrRegionOfOrigin>?>("countriesOrRegionsOfOrigin"); }
            set { BackingStore?.Set("countriesOrRegionsOfOrigin", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.IntelligenceProfileCountryOrRegionOfOrigin> CountriesOrRegionsOfOrigin
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.IntelligenceProfileCountryOrRegionOfOrigin>>("countriesOrRegionsOfOrigin"); }
            set { BackingStore?.Set("countriesOrRegionsOfOrigin", value); }
        }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.FormattedContent? Description
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.FormattedContent?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.FormattedContent Description
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.FormattedContent>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The date and time when this intelligenceProfile was first active. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstActiveDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("firstActiveDateTime"); }
            set { BackingStore?.Set("firstActiveDateTime", value); }
        }
        /// <summary>Includes an assemblage of high-fidelity network indicators of compromise.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.IntelligenceProfileIndicator>? Indicators
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.IntelligenceProfileIndicator>?>("indicators"); }
            set { BackingStore?.Set("indicators", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.IntelligenceProfileIndicator> Indicators
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.IntelligenceProfileIndicator>>("indicators"); }
            set { BackingStore?.Set("indicators", value); }
        }
#endif
        /// <summary>The kind property</summary>
        public global::Microsoft.Graph.Models.Security.IntelligenceProfileKind? Kind
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.IntelligenceProfileKind?>("kind"); }
            set { BackingStore?.Set("kind", value); }
        }
        /// <summary>The summary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.FormattedContent? Summary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.FormattedContent?>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.FormattedContent Summary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.FormattedContent>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#endif
        /// <summary>Known targets related to this intelligenceProfile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Targets
        {
            get { return BackingStore?.Get<List<string>?>("targets"); }
            set { BackingStore?.Set("targets", value); }
        }
#nullable restore
#else
        public List<string> Targets
        {
            get { return BackingStore?.Get<List<string>>("targets"); }
            set { BackingStore?.Set("targets", value); }
        }
#endif
        /// <summary>The title of this intelligenceProfile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title
        {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title
        {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>Formatted information featuring a description of the distinctive tactics, techniques, and procedures (TTP) of the group, followed by a list of all known custom, commodity, and publicly available implants used by the group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.FormattedContent? Tradecraft
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.FormattedContent?>("tradecraft"); }
            set { BackingStore?.Set("tradecraft", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.FormattedContent Tradecraft
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.FormattedContent>("tradecraft"); }
            set { BackingStore?.Set("tradecraft", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.IntelligenceProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.IntelligenceProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.IntelligenceProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "aliases", n => { Aliases = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "countriesOrRegionsOfOrigin", n => { CountriesOrRegionsOfOrigin = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.IntelligenceProfileCountryOrRegionOfOrigin>(global::Microsoft.Graph.Models.Security.IntelligenceProfileCountryOrRegionOfOrigin.CreateFromDiscriminatorValue)?.AsList(); } },
                { "description", n => { Description = n.GetObjectValue<global::Microsoft.Graph.Models.Security.FormattedContent>(global::Microsoft.Graph.Models.Security.FormattedContent.CreateFromDiscriminatorValue); } },
                { "firstActiveDateTime", n => { FirstActiveDateTime = n.GetDateTimeOffsetValue(); } },
                { "indicators", n => { Indicators = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.IntelligenceProfileIndicator>(global::Microsoft.Graph.Models.Security.IntelligenceProfileIndicator.CreateFromDiscriminatorValue)?.AsList(); } },
                { "kind", n => { Kind = n.GetEnumValue<global::Microsoft.Graph.Models.Security.IntelligenceProfileKind>(); } },
                { "summary", n => { Summary = n.GetObjectValue<global::Microsoft.Graph.Models.Security.FormattedContent>(global::Microsoft.Graph.Models.Security.FormattedContent.CreateFromDiscriminatorValue); } },
                { "targets", n => { Targets = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "tradecraft", n => { Tradecraft = n.GetObjectValue<global::Microsoft.Graph.Models.Security.FormattedContent>(global::Microsoft.Graph.Models.Security.FormattedContent.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("aliases", Aliases);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.IntelligenceProfileCountryOrRegionOfOrigin>("countriesOrRegionsOfOrigin", CountriesOrRegionsOfOrigin);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.FormattedContent>("description", Description);
            writer.WriteDateTimeOffsetValue("firstActiveDateTime", FirstActiveDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.IntelligenceProfileIndicator>("indicators", Indicators);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.IntelligenceProfileKind>("kind", Kind);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.FormattedContent>("summary", Summary);
            writer.WriteCollectionOfPrimitiveValues<string>("targets", Targets);
            writer.WriteStringValue("title", Title);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.FormattedContent>("tradecraft", Tradecraft);
        }
    }
}
#pragma warning restore CS0618
