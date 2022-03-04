using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImDiv {
    public class ImDivRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Inumber1 { get; set; }
        public Json Inumber2 { get; set; }
        /// <summary>
        /// Instantiates a new imDivRequestBody and sets the default values.
        /// </summary>
        public ImDivRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ImDivRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImDivRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"inumber1", (o,n) => { (o as ImDivRequestBody).Inumber1 = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"inumber2", (o,n) => { (o as ImDivRequestBody).Inumber2 = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("inumber1", Inumber1);
            writer.WriteObjectValue<Json>("inumber2", Inumber2);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
