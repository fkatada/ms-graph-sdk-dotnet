using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Charts.Item.SetData {
    public class SetDataRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string SeriesBy { get; set; }
        public Json SourceData { get; set; }
        /// <summary>
        /// Instantiates a new setDataRequestBody and sets the default values.
        /// </summary>
        public SetDataRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SetDataRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SetDataRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"seriesBy", (o,n) => { (o as SetDataRequestBody).SeriesBy = n.GetStringValue(); } },
                {"sourceData", (o,n) => { (o as SetDataRequestBody).SourceData = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("seriesBy", SeriesBy);
            writer.WriteObjectValue<Json>("sourceData", SourceData);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
