// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class NumberColumn : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>How many decimal places to display. See below for information about the possible values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DecimalPlaces {
            get { return BackingStore?.Get<string?>("decimalPlaces"); }
            set { BackingStore?.Set("decimalPlaces", value); }
        }
#nullable restore
#else
        public string DecimalPlaces {
            get { return BackingStore?.Get<string>("decimalPlaces"); }
            set { BackingStore?.Set("decimalPlaces", value); }
        }
#endif
        /// <summary>How the value should be presented in the UX. Must be one of number or percentage. If unspecified, treated as number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayAs {
            get { return BackingStore?.Get<string?>("displayAs"); }
            set { BackingStore?.Set("displayAs", value); }
        }
#nullable restore
#else
        public string DisplayAs {
            get { return BackingStore?.Get<string>("displayAs"); }
            set { BackingStore?.Set("displayAs", value); }
        }
#endif
        /// <summary>The maximum permitted value.</summary>
        public double? Maximum {
            get { return BackingStore?.Get<double?>("maximum"); }
            set { BackingStore?.Set("maximum", value); }
        }
        /// <summary>The minimum permitted value.</summary>
        public double? Minimum {
            get { return BackingStore?.Get<double?>("minimum"); }
            set { BackingStore?.Set("minimum", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="NumberColumn"/> and sets the default values.
        /// </summary>
        public NumberColumn() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="NumberColumn"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static NumberColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NumberColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"decimalPlaces", n => { DecimalPlaces = n.GetStringValue(); } },
                {"displayAs", n => { DisplayAs = n.GetStringValue(); } },
                {"maximum", n => { Maximum = n.GetDoubleValue(); } },
                {"minimum", n => { Minimum = n.GetDoubleValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("decimalPlaces", DecimalPlaces);
            writer.WriteStringValue("displayAs", DisplayAs);
            writer.WriteDoubleValue("maximum", Maximum);
            writer.WriteDoubleValue("minimum", Minimum);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
