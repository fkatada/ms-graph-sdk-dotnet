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
    public partial class ConditionalAccessRoot : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Read-only. Nullable. Returns a collection of the specified authentication context class references.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AuthenticationContextClassReference>? AuthenticationContextClassReferences
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AuthenticationContextClassReference>?>("authenticationContextClassReferences"); }
            set { BackingStore?.Set("authenticationContextClassReferences", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AuthenticationContextClassReference> AuthenticationContextClassReferences
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AuthenticationContextClassReference>>("authenticationContextClassReferences"); }
            set { BackingStore?.Set("authenticationContextClassReferences", value); }
        }
#endif
        /// <summary>The authenticationStrength property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AuthenticationStrengthRoot? AuthenticationStrength
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AuthenticationStrengthRoot?>("authenticationStrength"); }
            set { BackingStore?.Set("authenticationStrength", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AuthenticationStrengthRoot AuthenticationStrength
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AuthenticationStrengthRoot>("authenticationStrength"); }
            set { BackingStore?.Set("authenticationStrength", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Returns a collection of the specified named locations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.NamedLocation>? NamedLocations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.NamedLocation>?>("namedLocations"); }
            set { BackingStore?.Set("namedLocations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.NamedLocation> NamedLocations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.NamedLocation>>("namedLocations"); }
            set { BackingStore?.Set("namedLocations", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Returns a collection of the specified Conditional Access (CA) policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ConditionalAccessPolicy>? Policies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ConditionalAccessPolicy>?>("policies"); }
            set { BackingStore?.Set("policies", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ConditionalAccessPolicy> Policies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ConditionalAccessPolicy>>("policies"); }
            set { BackingStore?.Set("policies", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Returns a collection of the specified Conditional Access templates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ConditionalAccessTemplate>? Templates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ConditionalAccessTemplate>?>("templates"); }
            set { BackingStore?.Set("templates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ConditionalAccessTemplate> Templates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ConditionalAccessTemplate>>("templates"); }
            set { BackingStore?.Set("templates", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ConditionalAccessRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ConditionalAccessRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ConditionalAccessRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "authenticationContextClassReferences", n => { AuthenticationContextClassReferences = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AuthenticationContextClassReference>(global::Microsoft.Graph.Models.AuthenticationContextClassReference.CreateFromDiscriminatorValue)?.AsList(); } },
                { "authenticationStrength", n => { AuthenticationStrength = n.GetObjectValue<global::Microsoft.Graph.Models.AuthenticationStrengthRoot>(global::Microsoft.Graph.Models.AuthenticationStrengthRoot.CreateFromDiscriminatorValue); } },
                { "namedLocations", n => { NamedLocations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.NamedLocation>(global::Microsoft.Graph.Models.NamedLocation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "policies", n => { Policies = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ConditionalAccessPolicy>(global::Microsoft.Graph.Models.ConditionalAccessPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "templates", n => { Templates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ConditionalAccessTemplate>(global::Microsoft.Graph.Models.ConditionalAccessTemplate.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AuthenticationContextClassReference>("authenticationContextClassReferences", AuthenticationContextClassReferences);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AuthenticationStrengthRoot>("authenticationStrength", AuthenticationStrength);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.NamedLocation>("namedLocations", NamedLocations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ConditionalAccessPolicy>("policies", Policies);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ConditionalAccessTemplate>("templates", Templates);
        }
    }
}
#pragma warning restore CS0618
