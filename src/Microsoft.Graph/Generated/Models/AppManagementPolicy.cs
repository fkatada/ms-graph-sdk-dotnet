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
    public partial class AppManagementPolicy : global::Microsoft.Graph.Models.PolicyBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Collection of applications and service principals to which the policy is applied.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.DirectoryObject>? AppliesTo
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DirectoryObject>?>("appliesTo"); }
            set { BackingStore?.Set("appliesTo", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.DirectoryObject> AppliesTo
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DirectoryObject>>("appliesTo"); }
            set { BackingStore?.Set("appliesTo", value); }
        }
#endif
        /// <summary>Denotes whether the policy is enabled.</summary>
        public bool? IsEnabled
        {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>Restrictions that apply to an application or service principal object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.CustomAppManagementConfiguration? Restrictions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CustomAppManagementConfiguration?>("restrictions"); }
            set { BackingStore?.Set("restrictions", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.CustomAppManagementConfiguration Restrictions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CustomAppManagementConfiguration>("restrictions"); }
            set { BackingStore?.Set("restrictions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.AppManagementPolicy"/> and sets the default values.
        /// </summary>
        public AppManagementPolicy() : base()
        {
            OdataType = "#microsoft.graph.appManagementPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AppManagementPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AppManagementPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AppManagementPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appliesTo", n => { AppliesTo = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.DirectoryObject>(global::Microsoft.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                { "restrictions", n => { Restrictions = n.GetObjectValue<global::Microsoft.Graph.Models.CustomAppManagementConfiguration>(global::Microsoft.Graph.Models.CustomAppManagementConfiguration.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.DirectoryObject>("appliesTo", AppliesTo);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.CustomAppManagementConfiguration>("restrictions", Restrictions);
        }
    }
}
#pragma warning restore CS0618
