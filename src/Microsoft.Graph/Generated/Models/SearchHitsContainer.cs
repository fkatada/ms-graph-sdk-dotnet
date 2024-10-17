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
    public partial class SearchHitsContainer : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The aggregations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SearchAggregation>? Aggregations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SearchAggregation>?>("aggregations"); }
            set { BackingStore?.Set("aggregations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SearchAggregation> Aggregations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SearchAggregation>>("aggregations"); }
            set { BackingStore?.Set("aggregations", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A collection of the search results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SearchHit>? Hits
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SearchHit>?>("hits"); }
            set { BackingStore?.Set("hits", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SearchHit> Hits
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SearchHit>>("hits"); }
            set { BackingStore?.Set("hits", value); }
        }
#endif
        /// <summary>Provides information if more results are available. Based on this information, you can adjust the from and size properties of the searchRequest accordingly.</summary>
        public bool? MoreResultsAvailable
        {
            get { return BackingStore?.Get<bool?>("moreResultsAvailable"); }
            set { BackingStore?.Set("moreResultsAvailable", value); }
        }
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
        /// <summary>The total number of results. Note this isn&apos;t the number of results on the page, but the total number of results satisfying the query.</summary>
        public int? Total
        {
            get { return BackingStore?.Get<int?>("total"); }
            set { BackingStore?.Set("total", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.SearchHitsContainer"/> and sets the default values.
        /// </summary>
        public SearchHitsContainer()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SearchHitsContainer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.SearchHitsContainer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.SearchHitsContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "aggregations", n => { Aggregations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SearchAggregation>(global::Microsoft.Graph.Models.SearchAggregation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hits", n => { Hits = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SearchHit>(global::Microsoft.Graph.Models.SearchHit.CreateFromDiscriminatorValue)?.AsList(); } },
                { "moreResultsAvailable", n => { MoreResultsAvailable = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "total", n => { Total = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SearchAggregation>("aggregations", Aggregations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SearchHit>("hits", Hits);
            writer.WriteBoolValue("moreResultsAvailable", MoreResultsAvailable);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("total", Total);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
