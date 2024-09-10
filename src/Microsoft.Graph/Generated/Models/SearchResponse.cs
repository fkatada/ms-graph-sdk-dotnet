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
    public partial class SearchResponse : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>A collection of search results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SearchHitsContainer>? HitsContainers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SearchHitsContainer>?>("hitsContainers"); }
            set { BackingStore?.Set("hitsContainers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SearchHitsContainer> HitsContainers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SearchHitsContainer>>("hitsContainers"); }
            set { BackingStore?.Set("hitsContainers", value); }
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
        /// <summary>Provides information related to spelling corrections in the alteration response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AlterationResponse? QueryAlterationResponse
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AlterationResponse?>("queryAlterationResponse"); }
            set { BackingStore?.Set("queryAlterationResponse", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AlterationResponse QueryAlterationResponse
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AlterationResponse>("queryAlterationResponse"); }
            set { BackingStore?.Set("queryAlterationResponse", value); }
        }
#endif
        /// <summary>A dictionary of resultTemplateIds and associated values, which include the name and JSON schema of the result templates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ResultTemplateDictionary? ResultTemplates
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ResultTemplateDictionary?>("resultTemplates"); }
            set { BackingStore?.Set("resultTemplates", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ResultTemplateDictionary ResultTemplates
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ResultTemplateDictionary>("resultTemplates"); }
            set { BackingStore?.Set("resultTemplates", value); }
        }
#endif
        /// <summary>Contains the search terms sent in the initial search query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SearchTerms
        {
            get { return BackingStore?.Get<List<string>?>("searchTerms"); }
            set { BackingStore?.Set("searchTerms", value); }
        }
#nullable restore
#else
        public List<string> SearchTerms
        {
            get { return BackingStore?.Get<List<string>>("searchTerms"); }
            set { BackingStore?.Set("searchTerms", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.SearchResponse"/> and sets the default values.
        /// </summary>
        public SearchResponse()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SearchResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.SearchResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.SearchResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "hitsContainers", n => { HitsContainers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SearchHitsContainer>(global::Microsoft.Graph.Models.SearchHitsContainer.CreateFromDiscriminatorValue)?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "queryAlterationResponse", n => { QueryAlterationResponse = n.GetObjectValue<global::Microsoft.Graph.Models.AlterationResponse>(global::Microsoft.Graph.Models.AlterationResponse.CreateFromDiscriminatorValue); } },
                { "resultTemplates", n => { ResultTemplates = n.GetObjectValue<global::Microsoft.Graph.Models.ResultTemplateDictionary>(global::Microsoft.Graph.Models.ResultTemplateDictionary.CreateFromDiscriminatorValue); } },
                { "searchTerms", n => { SearchTerms = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SearchHitsContainer>("hitsContainers", HitsContainers);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AlterationResponse>("queryAlterationResponse", QueryAlterationResponse);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ResultTemplateDictionary>("resultTemplates", ResultTemplates);
            writer.WriteCollectionOfPrimitiveValues<string>("searchTerms", SearchTerms);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
