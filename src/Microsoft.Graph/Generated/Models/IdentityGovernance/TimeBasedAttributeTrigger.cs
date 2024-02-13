// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.IdentityGovernance {
    public class TimeBasedAttributeTrigger : WorkflowExecutionTrigger, IParsable {
        /// <summary>How many days before or after the time-based attribute specified the workflow should trigger. For example, if the attribute is employeeHireDate and offsetInDays is -1, then the workflow should trigger one day before the employee hire date. The value can range between -180 and 180 days.</summary>
        public int? OffsetInDays {
            get { return BackingStore?.Get<int?>("offsetInDays"); }
            set { BackingStore?.Set("offsetInDays", value); }
        }
        /// <summary>The timeBasedAttribute property</summary>
        public WorkflowTriggerTimeBasedAttribute? TimeBasedAttribute {
            get { return BackingStore?.Get<WorkflowTriggerTimeBasedAttribute?>("timeBasedAttribute"); }
            set { BackingStore?.Set("timeBasedAttribute", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="TimeBasedAttributeTrigger"/> and sets the default values.
        /// </summary>
        public TimeBasedAttributeTrigger() : base() {
            OdataType = "#microsoft.graph.identityGovernance.timeBasedAttributeTrigger";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TimeBasedAttributeTrigger"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TimeBasedAttributeTrigger CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeBasedAttributeTrigger();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"offsetInDays", n => { OffsetInDays = n.GetIntValue(); } },
                {"timeBasedAttribute", n => { TimeBasedAttribute = n.GetEnumValue<WorkflowTriggerTimeBasedAttribute>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("offsetInDays", OffsetInDays);
            writer.WriteEnumValue<WorkflowTriggerTimeBasedAttribute>("timeBasedAttribute", TimeBasedAttribute);
        }
    }
}
