using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class KubernetesServiceEvidence : AlertEvidence, IParsable {
        /// <summary>The clusterIP property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IpEvidence? ClusterIP {
            get { return BackingStore?.Get<IpEvidence?>("clusterIP"); }
            set { BackingStore?.Set("clusterIP", value); }
        }
#nullable restore
#else
        public IpEvidence ClusterIP {
            get { return BackingStore?.Get<IpEvidence>("clusterIP"); }
            set { BackingStore?.Set("clusterIP", value); }
        }
#endif
        /// <summary>The externalIPs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IpEvidence>? ExternalIPs {
            get { return BackingStore?.Get<List<IpEvidence>?>("externalIPs"); }
            set { BackingStore?.Set("externalIPs", value); }
        }
#nullable restore
#else
        public List<IpEvidence> ExternalIPs {
            get { return BackingStore?.Get<List<IpEvidence>>("externalIPs"); }
            set { BackingStore?.Set("externalIPs", value); }
        }
#endif
        /// <summary>The labels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Dictionary? Labels {
            get { return BackingStore?.Get<Dictionary?>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#nullable restore
#else
        public Dictionary Labels {
            get { return BackingStore?.Get<Dictionary>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The namespace property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KubernetesNamespaceEvidence? Namespace {
            get { return BackingStore?.Get<KubernetesNamespaceEvidence?>("namespace"); }
            set { BackingStore?.Set("namespace", value); }
        }
#nullable restore
#else
        public KubernetesNamespaceEvidence Namespace {
            get { return BackingStore?.Get<KubernetesNamespaceEvidence>("namespace"); }
            set { BackingStore?.Set("namespace", value); }
        }
#endif
        /// <summary>The selector property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Dictionary? Selector {
            get { return BackingStore?.Get<Dictionary?>("selector"); }
            set { BackingStore?.Set("selector", value); }
        }
#nullable restore
#else
        public Dictionary Selector {
            get { return BackingStore?.Get<Dictionary>("selector"); }
            set { BackingStore?.Set("selector", value); }
        }
#endif
        /// <summary>The servicePorts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KubernetesServicePort>? ServicePorts {
            get { return BackingStore?.Get<List<KubernetesServicePort>?>("servicePorts"); }
            set { BackingStore?.Set("servicePorts", value); }
        }
#nullable restore
#else
        public List<KubernetesServicePort> ServicePorts {
            get { return BackingStore?.Get<List<KubernetesServicePort>>("servicePorts"); }
            set { BackingStore?.Set("servicePorts", value); }
        }
#endif
        /// <summary>The serviceType property</summary>
        public KubernetesServiceType? ServiceType {
            get { return BackingStore?.Get<KubernetesServiceType?>("serviceType"); }
            set { BackingStore?.Set("serviceType", value); }
        }
        /// <summary>
        /// Instantiates a new kubernetesServiceEvidence and sets the default values.
        /// </summary>
        public KubernetesServiceEvidence() : base() {
            OdataType = "#microsoft.graph.security.kubernetesServiceEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KubernetesServiceEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KubernetesServiceEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"clusterIP", n => { ClusterIP = n.GetObjectValue<IpEvidence>(IpEvidence.CreateFromDiscriminatorValue); } },
                {"externalIPs", n => { ExternalIPs = n.GetCollectionOfObjectValues<IpEvidence>(IpEvidence.CreateFromDiscriminatorValue)?.ToList(); } },
                {"labels", n => { Labels = n.GetObjectValue<Dictionary>(Dictionary.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"namespace", n => { Namespace = n.GetObjectValue<KubernetesNamespaceEvidence>(KubernetesNamespaceEvidence.CreateFromDiscriminatorValue); } },
                {"selector", n => { Selector = n.GetObjectValue<Dictionary>(Dictionary.CreateFromDiscriminatorValue); } },
                {"servicePorts", n => { ServicePorts = n.GetCollectionOfObjectValues<KubernetesServicePort>(KubernetesServicePort.CreateFromDiscriminatorValue)?.ToList(); } },
                {"serviceType", n => { ServiceType = n.GetEnumValue<KubernetesServiceType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IpEvidence>("clusterIP", ClusterIP);
            writer.WriteCollectionOfObjectValues<IpEvidence>("externalIPs", ExternalIPs);
            writer.WriteObjectValue<Dictionary>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<KubernetesNamespaceEvidence>("namespace", Namespace);
            writer.WriteObjectValue<Dictionary>("selector", Selector);
            writer.WriteCollectionOfObjectValues<KubernetesServicePort>("servicePorts", ServicePorts);
            writer.WriteEnumValue<KubernetesServiceType>("serviceType", ServiceType);
        }
    }
}
