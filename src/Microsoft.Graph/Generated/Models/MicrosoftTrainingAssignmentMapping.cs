// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    #pragma warning disable CS1591
    public class MicrosoftTrainingAssignmentMapping : TrainingSetting, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>A user collection that specifies to whom the training should be assigned. Possible values are: none, allUsers, clickedPayload, compromised, reportedPhish, readButNotClicked, didNothing, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TrainingAssignedTo?>? AssignedTo {
            get { return BackingStore?.Get<List<TrainingAssignedTo?>?>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
#nullable restore
#else
        public List<TrainingAssignedTo?> AssignedTo {
            get { return BackingStore?.Get<List<TrainingAssignedTo?>>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
#endif
        /// <summary>The training property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Training? Training {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Training?>("training"); }
            set { BackingStore?.Set("training", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Training Training {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Training>("training"); }
            set { BackingStore?.Set("training", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftTrainingAssignmentMapping"/> and sets the default values.
        /// </summary>
        public MicrosoftTrainingAssignmentMapping() : base()
        {
            OdataType = "#microsoft.graph.microsoftTrainingAssignmentMapping";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MicrosoftTrainingAssignmentMapping"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MicrosoftTrainingAssignmentMapping CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftTrainingAssignmentMapping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"assignedTo", n => { AssignedTo = n.GetCollectionOfEnumValues<TrainingAssignedTo>()?.ToList(); } },
                {"training", n => { Training = n.GetObjectValue<Microsoft.Graph.Models.Training>(Microsoft.Graph.Models.Training.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfEnumValues<TrainingAssignedTo>("assignedTo", AssignedTo);
            writer.WriteObjectValue<Microsoft.Graph.Models.Training>("training", Training);
        }
    }
}
