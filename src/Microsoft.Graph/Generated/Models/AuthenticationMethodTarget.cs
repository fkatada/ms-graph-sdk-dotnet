// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class AuthenticationMethodTarget : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Determines if the user is enforced to register the authentication method.</summary>
        public bool? IsRegistrationRequired
        {
            get { return BackingStore?.Get<bool?>("isRegistrationRequired"); }
            set { BackingStore?.Set("isRegistrationRequired", value); }
        }
        /// <summary>The targetType property</summary>
        public global::Microsoft.Graph.Models.AuthenticationMethodTargetType? TargetType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AuthenticationMethodTargetType?>("targetType"); }
            set { BackingStore?.Set("targetType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AuthenticationMethodTarget"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AuthenticationMethodTarget CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.microsoftAuthenticatorAuthenticationMethodTarget" => new global::Microsoft.Graph.Models.MicrosoftAuthenticatorAuthenticationMethodTarget(),
                "#microsoft.graph.smsAuthenticationMethodTarget" => new global::Microsoft.Graph.Models.SmsAuthenticationMethodTarget(),
                _ => new global::Microsoft.Graph.Models.AuthenticationMethodTarget(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "isRegistrationRequired", n => { IsRegistrationRequired = n.GetBoolValue(); } },
                { "targetType", n => { TargetType = n.GetEnumValue<global::Microsoft.Graph.Models.AuthenticationMethodTargetType>(); } },
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
            writer.WriteBoolValue("isRegistrationRequired", IsRegistrationRequired);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.AuthenticationMethodTargetType>("targetType", TargetType);
        }
    }
}
#pragma warning restore CS0618
