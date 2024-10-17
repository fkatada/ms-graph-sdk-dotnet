// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class OnPremisesDirectorySynchronization : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Consists of configurations that can be fine-tuned and impact the on-premises directory synchronization process for a tenant. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.OnPremisesDirectorySynchronizationConfiguration? Configuration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OnPremisesDirectorySynchronizationConfiguration?>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.OnPremisesDirectorySynchronizationConfiguration Configuration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OnPremisesDirectorySynchronizationConfiguration>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
#endif
        /// <summary>The features property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.OnPremisesDirectorySynchronizationFeature? Features
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OnPremisesDirectorySynchronizationFeature?>("features"); }
            set { BackingStore?.Set("features", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.OnPremisesDirectorySynchronizationFeature Features
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OnPremisesDirectorySynchronizationFeature>("features"); }
            set { BackingStore?.Set("features", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.OnPremisesDirectorySynchronization"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.OnPremisesDirectorySynchronization CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.OnPremisesDirectorySynchronization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "configuration", n => { Configuration = n.GetObjectValue<global::Microsoft.Graph.Models.OnPremisesDirectorySynchronizationConfiguration>(global::Microsoft.Graph.Models.OnPremisesDirectorySynchronizationConfiguration.CreateFromDiscriminatorValue); } },
                { "features", n => { Features = n.GetObjectValue<global::Microsoft.Graph.Models.OnPremisesDirectorySynchronizationFeature>(global::Microsoft.Graph.Models.OnPremisesDirectorySynchronizationFeature.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.OnPremisesDirectorySynchronizationConfiguration>("configuration", Configuration);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.OnPremisesDirectorySynchronizationFeature>("features", Features);
        }
    }
}
#pragma warning restore CS0618
