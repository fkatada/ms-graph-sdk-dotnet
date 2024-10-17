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
    public partial class SimulationReportOverview : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>List of recommended actions for a tenant to improve its security posture based on the attack simulation and training campaign attack type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.RecommendedAction>? RecommendedActions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RecommendedAction>?>("recommendedActions"); }
            set { BackingStore?.Set("recommendedActions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.RecommendedAction> RecommendedActions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RecommendedAction>>("recommendedActions"); }
            set { BackingStore?.Set("recommendedActions", value); }
        }
#endif
        /// <summary>Number of valid users in the attack simulation and training campaign.</summary>
        public int? ResolvedTargetsCount
        {
            get { return BackingStore?.Get<int?>("resolvedTargetsCount"); }
            set { BackingStore?.Set("resolvedTargetsCount", value); }
        }
        /// <summary>Summary of simulation events in the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SimulationEventsContent? SimulationEventsContent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SimulationEventsContent?>("simulationEventsContent"); }
            set { BackingStore?.Set("simulationEventsContent", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SimulationEventsContent SimulationEventsContent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SimulationEventsContent>("simulationEventsContent"); }
            set { BackingStore?.Set("simulationEventsContent", value); }
        }
#endif
        /// <summary>Summary of assigned trainings in the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TrainingEventsContent? TrainingEventsContent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TrainingEventsContent?>("trainingEventsContent"); }
            set { BackingStore?.Set("trainingEventsContent", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TrainingEventsContent TrainingEventsContent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TrainingEventsContent>("trainingEventsContent"); }
            set { BackingStore?.Set("trainingEventsContent", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.SimulationReportOverview"/> and sets the default values.
        /// </summary>
        public SimulationReportOverview()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SimulationReportOverview"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.SimulationReportOverview CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.SimulationReportOverview();
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
                { "recommendedActions", n => { RecommendedActions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.RecommendedAction>(global::Microsoft.Graph.Models.RecommendedAction.CreateFromDiscriminatorValue)?.AsList(); } },
                { "resolvedTargetsCount", n => { ResolvedTargetsCount = n.GetIntValue(); } },
                { "simulationEventsContent", n => { SimulationEventsContent = n.GetObjectValue<global::Microsoft.Graph.Models.SimulationEventsContent>(global::Microsoft.Graph.Models.SimulationEventsContent.CreateFromDiscriminatorValue); } },
                { "trainingEventsContent", n => { TrainingEventsContent = n.GetObjectValue<global::Microsoft.Graph.Models.TrainingEventsContent>(global::Microsoft.Graph.Models.TrainingEventsContent.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.RecommendedAction>("recommendedActions", RecommendedActions);
            writer.WriteIntValue("resolvedTargetsCount", ResolvedTargetsCount);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SimulationEventsContent>("simulationEventsContent", SimulationEventsContent);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TrainingEventsContent>("trainingEventsContent", TrainingEventsContent);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
