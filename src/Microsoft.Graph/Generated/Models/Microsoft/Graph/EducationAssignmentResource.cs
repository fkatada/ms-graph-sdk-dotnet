using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class EducationAssignmentResource : Entity, IParsable {
        /// <summary>Indicates whether this resource should be copied to each student submission for modification and submission. Required</summary>
        public bool? DistributeForStudentWork { get; set; }
        /// <summary>Resource object that has been associated with this assignment.</summary>
        public EducationResource Resource { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationAssignmentResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationAssignmentResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"distributeForStudentWork", (o,n) => { (o as EducationAssignmentResource).DistributeForStudentWork = n.GetBoolValue(); } },
                {"resource", (o,n) => { (o as EducationAssignmentResource).Resource = n.GetObjectValue<EducationResource>(EducationResource.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("distributeForStudentWork", DistributeForStudentWork);
            writer.WriteObjectValue<EducationResource>("resource", Resource);
        }
    }
}
