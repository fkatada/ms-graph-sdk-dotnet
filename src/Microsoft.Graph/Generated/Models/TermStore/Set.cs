// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.TermStore
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class Set : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Children terms of set in term [store].</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TermStore.Term>? Children
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TermStore.Term>?>("children"); }
            set { BackingStore?.Set("children", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TermStore.Term> Children
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TermStore.Term>>("children"); }
            set { BackingStore?.Set("children", value); }
        }
#endif
        /// <summary>Date and time of set creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description that gives details on the term usage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Name of the set for each languageTag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TermStore.LocalizedName>? LocalizedNames
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TermStore.LocalizedName>?>("localizedNames"); }
            set { BackingStore?.Set("localizedNames", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TermStore.LocalizedName> LocalizedNames
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TermStore.LocalizedName>>("localizedNames"); }
            set { BackingStore?.Set("localizedNames", value); }
        }
#endif
        /// <summary>The parentGroup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TermStore.Group? ParentGroup
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TermStore.Group?>("parentGroup"); }
            set { BackingStore?.Set("parentGroup", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TermStore.Group ParentGroup
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TermStore.Group>("parentGroup"); }
            set { BackingStore?.Set("parentGroup", value); }
        }
#endif
        /// <summary>Custom properties for the set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.KeyValue>? Properties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.KeyValue>?>("properties"); }
            set { BackingStore?.Set("properties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.KeyValue> Properties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.KeyValue>>("properties"); }
            set { BackingStore?.Set("properties", value); }
        }
#endif
        /// <summary>Indicates which terms have been pinned or reused directly under the set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TermStore.Relation>? Relations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TermStore.Relation>?>("relations"); }
            set { BackingStore?.Set("relations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TermStore.Relation> Relations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TermStore.Relation>>("relations"); }
            set { BackingStore?.Set("relations", value); }
        }
#endif
        /// <summary>All the terms under the set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TermStore.Term>? Terms
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TermStore.Term>?>("terms"); }
            set { BackingStore?.Set("terms", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TermStore.Term> Terms
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TermStore.Term>>("terms"); }
            set { BackingStore?.Set("terms", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TermStore.Set"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.TermStore.Set CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.TermStore.Set();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "children", n => { Children = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TermStore.Term>(global::Microsoft.Graph.Models.TermStore.Term.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "localizedNames", n => { LocalizedNames = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TermStore.LocalizedName>(global::Microsoft.Graph.Models.TermStore.LocalizedName.CreateFromDiscriminatorValue)?.AsList(); } },
                { "parentGroup", n => { ParentGroup = n.GetObjectValue<global::Microsoft.Graph.Models.TermStore.Group>(global::Microsoft.Graph.Models.TermStore.Group.CreateFromDiscriminatorValue); } },
                { "properties", n => { Properties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.KeyValue>(global::Microsoft.Graph.Models.KeyValue.CreateFromDiscriminatorValue)?.AsList(); } },
                { "relations", n => { Relations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TermStore.Relation>(global::Microsoft.Graph.Models.TermStore.Relation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "terms", n => { Terms = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TermStore.Term>(global::Microsoft.Graph.Models.TermStore.Term.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TermStore.Term>("children", Children);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TermStore.LocalizedName>("localizedNames", LocalizedNames);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TermStore.Group>("parentGroup", ParentGroup);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.KeyValue>("properties", Properties);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TermStore.Relation>("relations", Relations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TermStore.Term>("terms", Terms);
        }
    }
}
#pragma warning restore CS0618
