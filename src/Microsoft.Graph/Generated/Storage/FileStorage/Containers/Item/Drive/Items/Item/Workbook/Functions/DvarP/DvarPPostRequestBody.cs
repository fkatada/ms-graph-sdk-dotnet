// <auto-generated/>
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.DvarP
{
    #pragma warning disable CS1591
    public class DvarPPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The criteria property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Criteria
        {
            get { return BackingStore?.Get<Json?>("criteria"); }
            set { BackingStore?.Set("criteria", value); }
        }
#nullable restore
#else
        public Json Criteria
        {
            get { return BackingStore?.Get<Json>("criteria"); }
            set { BackingStore?.Set("criteria", value); }
        }
#endif
        /// <summary>The database property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Database
        {
            get { return BackingStore?.Get<Json?>("database"); }
            set { BackingStore?.Set("database", value); }
        }
#nullable restore
#else
        public Json Database
        {
            get { return BackingStore?.Get<Json>("database"); }
            set { BackingStore?.Set("database", value); }
        }
#endif
        /// <summary>The field property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Field
        {
            get { return BackingStore?.Get<Json?>("field"); }
            set { BackingStore?.Set("field", value); }
        }
#nullable restore
#else
        public Json Field
        {
            get { return BackingStore?.Get<Json>("field"); }
            set { BackingStore?.Set("field", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DvarPPostRequestBody"/> and sets the default values.
        /// </summary>
        public DvarPPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DvarPPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DvarPPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DvarPPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "criteria", n => { Criteria = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "database", n => { Database = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "field", n => { Field = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("criteria", Criteria);
            writer.WriteObjectValue<Json>("database", Database);
            writer.WriteObjectValue<Json>("field", Field);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
