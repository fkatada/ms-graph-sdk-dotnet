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
    public partial class Notebook : global::Microsoft.Graph.Models.OnenoteEntityHierarchyModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether this is the user&apos;s default notebook. Read-only.</summary>
        public bool? IsDefault
        {
            get { return BackingStore?.Get<bool?>("isDefault"); }
            set { BackingStore?.Set("isDefault", value); }
        }
        /// <summary>Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.</summary>
        public bool? IsShared
        {
            get { return BackingStore?.Get<bool?>("isShared"); }
            set { BackingStore?.Set("isShared", value); }
        }
        /// <summary>Links for opening the notebook. The oneNoteClientURL link opens the notebook in the OneNote native client if it&apos;s installed. The oneNoteWebURL link opens the notebook in OneNote on the web.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.NotebookLinks? Links
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.NotebookLinks?>("links"); }
            set { BackingStore?.Set("links", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.NotebookLinks Links
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.NotebookLinks>("links"); }
            set { BackingStore?.Set("links", value); }
        }
#endif
        /// <summary>The section groups in the notebook. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SectionGroup>? SectionGroups
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SectionGroup>?>("sectionGroups"); }
            set { BackingStore?.Set("sectionGroups", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SectionGroup> SectionGroups
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SectionGroup>>("sectionGroups"); }
            set { BackingStore?.Set("sectionGroups", value); }
        }
#endif
        /// <summary>The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SectionGroupsUrl
        {
            get { return BackingStore?.Get<string?>("sectionGroupsUrl"); }
            set { BackingStore?.Set("sectionGroupsUrl", value); }
        }
#nullable restore
#else
        public string SectionGroupsUrl
        {
            get { return BackingStore?.Get<string>("sectionGroupsUrl"); }
            set { BackingStore?.Set("sectionGroupsUrl", value); }
        }
#endif
        /// <summary>The sections in the notebook. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.OnenoteSection>? Sections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnenoteSection>?>("sections"); }
            set { BackingStore?.Set("sections", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.OnenoteSection> Sections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnenoteSection>>("sections"); }
            set { BackingStore?.Set("sections", value); }
        }
#endif
        /// <summary>The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SectionsUrl
        {
            get { return BackingStore?.Get<string?>("sectionsUrl"); }
            set { BackingStore?.Set("sectionsUrl", value); }
        }
#nullable restore
#else
        public string SectionsUrl
        {
            get { return BackingStore?.Get<string>("sectionsUrl"); }
            set { BackingStore?.Set("sectionsUrl", value); }
        }
#endif
        /// <summary>Possible values are: Owner, Contributor, Reader, None. Owner represents owner-level access to the notebook. Contributor represents read/write access to the notebook. Reader represents read-only access to the notebook. Read-only.</summary>
        public global::Microsoft.Graph.Models.OnenoteUserRole? UserRole
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OnenoteUserRole?>("userRole"); }
            set { BackingStore?.Set("userRole", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Notebook"/> and sets the default values.
        /// </summary>
        public Notebook() : base()
        {
            OdataType = "#microsoft.graph.notebook";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Notebook"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Notebook CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Notebook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "isDefault", n => { IsDefault = n.GetBoolValue(); } },
                { "isShared", n => { IsShared = n.GetBoolValue(); } },
                { "links", n => { Links = n.GetObjectValue<global::Microsoft.Graph.Models.NotebookLinks>(global::Microsoft.Graph.Models.NotebookLinks.CreateFromDiscriminatorValue); } },
                { "sectionGroups", n => { SectionGroups = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SectionGroup>(global::Microsoft.Graph.Models.SectionGroup.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sectionGroupsUrl", n => { SectionGroupsUrl = n.GetStringValue(); } },
                { "sections", n => { Sections = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.OnenoteSection>(global::Microsoft.Graph.Models.OnenoteSection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sectionsUrl", n => { SectionsUrl = n.GetStringValue(); } },
                { "userRole", n => { UserRole = n.GetEnumValue<global::Microsoft.Graph.Models.OnenoteUserRole>(); } },
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
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.NotebookLinks>("links", Links);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SectionGroup>("sectionGroups", SectionGroups);
            writer.WriteStringValue("sectionGroupsUrl", SectionGroupsUrl);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.OnenoteSection>("sections", Sections);
            writer.WriteStringValue("sectionsUrl", SectionsUrl);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.OnenoteUserRole>("userRole", UserRole);
        }
    }
}
#pragma warning restore CS0618
