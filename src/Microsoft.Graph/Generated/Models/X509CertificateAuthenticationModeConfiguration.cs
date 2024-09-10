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
    public partial class X509CertificateAuthenticationModeConfiguration : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Rules are configured in addition to the authentication mode to bind a specific x509CertificateRuleType to an x509CertificateAuthenticationMode. For example, bind the policyOID with identifier 1.32.132.343 to x509CertificateMultiFactor authentication mode.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.X509CertificateRule>? Rules
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.X509CertificateRule>?>("rules"); }
            set { BackingStore?.Set("rules", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.X509CertificateRule> Rules
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.X509CertificateRule>>("rules"); }
            set { BackingStore?.Set("rules", value); }
        }
#endif
        /// <summary>The type of strong authentication mode. The possible values are: x509CertificateSingleFactor, x509CertificateMultiFactor, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.X509CertificateAuthenticationMode? X509CertificateAuthenticationDefaultMode
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.X509CertificateAuthenticationMode?>("x509CertificateAuthenticationDefaultMode"); }
            set { BackingStore?.Set("x509CertificateAuthenticationDefaultMode", value); }
        }
        /// <summary>The x509CertificateDefaultRequiredAffinityLevel property</summary>
        public global::Microsoft.Graph.Models.X509CertificateAffinityLevel? X509CertificateDefaultRequiredAffinityLevel
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.X509CertificateAffinityLevel?>("x509CertificateDefaultRequiredAffinityLevel"); }
            set { BackingStore?.Set("x509CertificateDefaultRequiredAffinityLevel", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.X509CertificateAuthenticationModeConfiguration"/> and sets the default values.
        /// </summary>
        public X509CertificateAuthenticationModeConfiguration()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.X509CertificateAuthenticationModeConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.X509CertificateAuthenticationModeConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.X509CertificateAuthenticationModeConfiguration();
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
                { "rules", n => { Rules = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.X509CertificateRule>(global::Microsoft.Graph.Models.X509CertificateRule.CreateFromDiscriminatorValue)?.AsList(); } },
                { "x509CertificateAuthenticationDefaultMode", n => { X509CertificateAuthenticationDefaultMode = n.GetEnumValue<global::Microsoft.Graph.Models.X509CertificateAuthenticationMode>(); } },
                { "x509CertificateDefaultRequiredAffinityLevel", n => { X509CertificateDefaultRequiredAffinityLevel = n.GetEnumValue<global::Microsoft.Graph.Models.X509CertificateAffinityLevel>(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.X509CertificateRule>("rules", Rules);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.X509CertificateAuthenticationMode>("x509CertificateAuthenticationDefaultMode", X509CertificateAuthenticationDefaultMode);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.X509CertificateAffinityLevel>("x509CertificateDefaultRequiredAffinityLevel", X509CertificateDefaultRequiredAffinityLevel);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
