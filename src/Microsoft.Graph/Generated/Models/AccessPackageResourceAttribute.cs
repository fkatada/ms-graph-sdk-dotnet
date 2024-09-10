// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class AccessPackageResourceAttribute : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Information about how to set the attribute, currently a accessPackageUserDirectoryAttributeStore type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessPackageResourceAttributeDestination? Destination
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageResourceAttributeDestination?>("destination"); }
            set { BackingStore?.Set("destination", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessPackageResourceAttributeDestination Destination
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageResourceAttributeDestination>("destination"); }
            set { BackingStore?.Set("destination", value); }
        }
#endif
        /// <summary>The isEditable property</summary>
        public bool? IsEditable
        {
            get { return BackingStore?.Get<bool?>("isEditable"); }
            set { BackingStore?.Set("isEditable", value); }
        }
        /// <summary>The isPersistedOnAssignmentRemoval property</summary>
        public bool? IsPersistedOnAssignmentRemoval
        {
            get { return BackingStore?.Get<bool?>("isPersistedOnAssignmentRemoval"); }
            set { BackingStore?.Set("isPersistedOnAssignmentRemoval", value); }
        }
        /// <summary>The name of the attribute in the end system. If the destination is accessPackageUserDirectoryAttributeStore, then a user property such as jobTitle or a directory schema extension for the user object type, such as extension2b676109c7c74ae2b41549205f1947edpersonalTitle.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Information about how to populate the attribute value when an accessPackageAssignmentRequest is being fulfilled, currently a accessPackageResourceAttributeQuestion type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessPackageResourceAttributeSource? Source
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageResourceAttributeSource?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessPackageResourceAttributeSource Source
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageResourceAttributeSource>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.AccessPackageResourceAttribute"/> and sets the default values.
        /// </summary>
        public AccessPackageResourceAttribute()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AccessPackageResourceAttribute"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.AccessPackageResourceAttribute CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AccessPackageResourceAttribute();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "destination", n => { Destination = n.GetObjectValue<global::Microsoft.Graph.Models.AccessPackageResourceAttributeDestination>(global::Microsoft.Graph.Models.AccessPackageResourceAttributeDestination.CreateFromDiscriminatorValue); } },
                { "isEditable", n => { IsEditable = n.GetBoolValue(); } },
                { "isPersistedOnAssignmentRemoval", n => { IsPersistedOnAssignmentRemoval = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "source", n => { Source = n.GetObjectValue<global::Microsoft.Graph.Models.AccessPackageResourceAttributeSource>(global::Microsoft.Graph.Models.AccessPackageResourceAttributeSource.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessPackageResourceAttributeDestination>("destination", Destination);
            writer.WriteBoolValue("isEditable", IsEditable);
            writer.WriteBoolValue("isPersistedOnAssignmentRemoval", IsPersistedOnAssignmentRemoval);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessPackageResourceAttributeSource>("source", Source);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
