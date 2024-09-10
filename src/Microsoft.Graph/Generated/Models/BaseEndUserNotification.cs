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
    public partial class BaseEndUserNotification : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The default language for the end user notification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultLanguage
        {
            get { return BackingStore?.Get<string?>("defaultLanguage"); }
            set { BackingStore?.Set("defaultLanguage", value); }
        }
#nullable restore
#else
        public string DefaultLanguage
        {
            get { return BackingStore?.Get<string>("defaultLanguage"); }
            set { BackingStore?.Set("defaultLanguage", value); }
        }
#endif
        /// <summary>The endUserNotification property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EndUserNotification? EndUserNotification
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EndUserNotification?>("endUserNotification"); }
            set { BackingStore?.Set("endUserNotification", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EndUserNotification EndUserNotification
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EndUserNotification>("endUserNotification"); }
            set { BackingStore?.Set("endUserNotification", value); }
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
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.BaseEndUserNotification"/> and sets the default values.
        /// </summary>
        public BaseEndUserNotification()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.BaseEndUserNotification"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.BaseEndUserNotification CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.positiveReinforcementNotification" => new global::Microsoft.Graph.Models.PositiveReinforcementNotification(),
                "#microsoft.graph.simulationNotification" => new global::Microsoft.Graph.Models.SimulationNotification(),
                "#microsoft.graph.trainingReminderNotification" => new global::Microsoft.Graph.Models.TrainingReminderNotification(),
                _ => new global::Microsoft.Graph.Models.BaseEndUserNotification(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "defaultLanguage", n => { DefaultLanguage = n.GetStringValue(); } },
                { "endUserNotification", n => { EndUserNotification = n.GetObjectValue<global::Microsoft.Graph.Models.EndUserNotification>(global::Microsoft.Graph.Models.EndUserNotification.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultLanguage", DefaultLanguage);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EndUserNotification>("endUserNotification", EndUserNotification);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
