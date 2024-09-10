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
    public partial class EducationRoot : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The classes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.EducationClass>? Classes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.EducationClass>?>("classes"); }
            set { BackingStore?.Set("classes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.EducationClass> Classes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.EducationClass>>("classes"); }
            set { BackingStore?.Set("classes", value); }
        }
#endif
        /// <summary>The me property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EducationUser? Me
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationUser?>("me"); }
            set { BackingStore?.Set("me", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EducationUser Me
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationUser>("me"); }
            set { BackingStore?.Set("me", value); }
        }
#endif
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
        /// <summary>The schools property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.EducationSchool>? Schools
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.EducationSchool>?>("schools"); }
            set { BackingStore?.Set("schools", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.EducationSchool> Schools
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.EducationSchool>>("schools"); }
            set { BackingStore?.Set("schools", value); }
        }
#endif
        /// <summary>The users property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.EducationUser>? Users
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.EducationUser>?>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.EducationUser> Users
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.EducationUser>>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.EducationRoot"/> and sets the default values.
        /// </summary>
        public EducationRoot()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.EducationRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.EducationRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.EducationRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "classes", n => { Classes = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.EducationClass>(global::Microsoft.Graph.Models.EducationClass.CreateFromDiscriminatorValue)?.AsList(); } },
                { "me", n => { Me = n.GetObjectValue<global::Microsoft.Graph.Models.EducationUser>(global::Microsoft.Graph.Models.EducationUser.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "schools", n => { Schools = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.EducationSchool>(global::Microsoft.Graph.Models.EducationSchool.CreateFromDiscriminatorValue)?.AsList(); } },
                { "users", n => { Users = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.EducationUser>(global::Microsoft.Graph.Models.EducationUser.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.EducationClass>("classes", Classes);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EducationUser>("me", Me);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.EducationSchool>("schools", Schools);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.EducationUser>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
