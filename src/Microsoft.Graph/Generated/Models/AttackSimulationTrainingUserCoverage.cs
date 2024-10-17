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
    public partial class AttackSimulationTrainingUserCoverage : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>User in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AttackSimulationUser? AttackSimulationUser
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AttackSimulationUser?>("attackSimulationUser"); }
            set { BackingStore?.Set("attackSimulationUser", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AttackSimulationUser AttackSimulationUser
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AttackSimulationUser>("attackSimulationUser"); }
            set { BackingStore?.Set("attackSimulationUser", value); }
        }
#endif
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
        /// <summary>List of assigned trainings and their statuses for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.UserTrainingStatusInfo>? UserTrainings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.UserTrainingStatusInfo>?>("userTrainings"); }
            set { BackingStore?.Set("userTrainings", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.UserTrainingStatusInfo> UserTrainings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.UserTrainingStatusInfo>>("userTrainings"); }
            set { BackingStore?.Set("userTrainings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.AttackSimulationTrainingUserCoverage"/> and sets the default values.
        /// </summary>
        public AttackSimulationTrainingUserCoverage()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AttackSimulationTrainingUserCoverage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.AttackSimulationTrainingUserCoverage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AttackSimulationTrainingUserCoverage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attackSimulationUser", n => { AttackSimulationUser = n.GetObjectValue<global::Microsoft.Graph.Models.AttackSimulationUser>(global::Microsoft.Graph.Models.AttackSimulationUser.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "userTrainings", n => { UserTrainings = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.UserTrainingStatusInfo>(global::Microsoft.Graph.Models.UserTrainingStatusInfo.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AttackSimulationUser>("attackSimulationUser", AttackSimulationUser);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.UserTrainingStatusInfo>("userTrainings", UserTrainings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
