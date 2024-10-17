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
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class SharingDetail : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The user who shared the document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.InsightIdentity? SharedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.InsightIdentity?>("sharedBy"); }
            set { BackingStore?.Set("sharedBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.InsightIdentity SharedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.InsightIdentity>("sharedBy"); }
            set { BackingStore?.Set("sharedBy", value); }
        }
#endif
        /// <summary>The date and time the file was last shared. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? SharedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("sharedDateTime"); }
            set { BackingStore?.Set("sharedDateTime", value); }
        }
        /// <summary>Reference properties of the document, such as the URL and type of the document. Read-only</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ResourceReference? SharingReference
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ResourceReference?>("sharingReference"); }
            set { BackingStore?.Set("sharingReference", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ResourceReference SharingReference
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ResourceReference>("sharingReference"); }
            set { BackingStore?.Set("sharingReference", value); }
        }
#endif
        /// <summary>The subject with which the document was shared.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SharingSubject
        {
            get { return BackingStore?.Get<string?>("sharingSubject"); }
            set { BackingStore?.Set("sharingSubject", value); }
        }
#nullable restore
#else
        public string SharingSubject
        {
            get { return BackingStore?.Get<string>("sharingSubject"); }
            set { BackingStore?.Set("sharingSubject", value); }
        }
#endif
        /// <summary>Determines the way the document was shared. Can be by a 1Link1, 1Attachment1, 1Group1, 1Site1.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SharingType
        {
            get { return BackingStore?.Get<string?>("sharingType"); }
            set { BackingStore?.Set("sharingType", value); }
        }
#nullable restore
#else
        public string SharingType
        {
            get { return BackingStore?.Get<string>("sharingType"); }
            set { BackingStore?.Set("sharingType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.SharingDetail"/> and sets the default values.
        /// </summary>
        public SharingDetail()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SharingDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.SharingDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.SharingDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "sharedBy", n => { SharedBy = n.GetObjectValue<global::Microsoft.Graph.Models.InsightIdentity>(global::Microsoft.Graph.Models.InsightIdentity.CreateFromDiscriminatorValue); } },
                { "sharedDateTime", n => { SharedDateTime = n.GetDateTimeOffsetValue(); } },
                { "sharingReference", n => { SharingReference = n.GetObjectValue<global::Microsoft.Graph.Models.ResourceReference>(global::Microsoft.Graph.Models.ResourceReference.CreateFromDiscriminatorValue); } },
                { "sharingSubject", n => { SharingSubject = n.GetStringValue(); } },
                { "sharingType", n => { SharingType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.InsightIdentity>("sharedBy", SharedBy);
            writer.WriteDateTimeOffsetValue("sharedDateTime", SharedDateTime);
            writer.WriteStringValue("sharingSubject", SharingSubject);
            writer.WriteStringValue("sharingType", SharingType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
