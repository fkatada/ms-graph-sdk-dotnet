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
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class UpdateWindowsDeviceAccountActionParameter : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Not yet documented</summary>
        public bool? CalendarSyncEnabled
        {
            get { return BackingStore?.Get<bool?>("calendarSyncEnabled"); }
            set { BackingStore?.Set("calendarSyncEnabled", value); }
        }
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.WindowsDeviceAccount? DeviceAccount
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WindowsDeviceAccount?>("deviceAccount"); }
            set { BackingStore?.Set("deviceAccount", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.WindowsDeviceAccount DeviceAccount
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WindowsDeviceAccount>("deviceAccount"); }
            set { BackingStore?.Set("deviceAccount", value); }
        }
#endif
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceAccountEmail
        {
            get { return BackingStore?.Get<string?>("deviceAccountEmail"); }
            set { BackingStore?.Set("deviceAccountEmail", value); }
        }
#nullable restore
#else
        public string DeviceAccountEmail
        {
            get { return BackingStore?.Get<string>("deviceAccountEmail"); }
            set { BackingStore?.Set("deviceAccountEmail", value); }
        }
#endif
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExchangeServer
        {
            get { return BackingStore?.Get<string?>("exchangeServer"); }
            set { BackingStore?.Set("exchangeServer", value); }
        }
#nullable restore
#else
        public string ExchangeServer
        {
            get { return BackingStore?.Get<string>("exchangeServer"); }
            set { BackingStore?.Set("exchangeServer", value); }
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
        /// <summary>Not yet documented</summary>
        public bool? PasswordRotationEnabled
        {
            get { return BackingStore?.Get<bool?>("passwordRotationEnabled"); }
            set { BackingStore?.Set("passwordRotationEnabled", value); }
        }
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SessionInitiationProtocalAddress
        {
            get { return BackingStore?.Get<string?>("sessionInitiationProtocalAddress"); }
            set { BackingStore?.Set("sessionInitiationProtocalAddress", value); }
        }
#nullable restore
#else
        public string SessionInitiationProtocalAddress
        {
            get { return BackingStore?.Get<string>("sessionInitiationProtocalAddress"); }
            set { BackingStore?.Set("sessionInitiationProtocalAddress", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.UpdateWindowsDeviceAccountActionParameter"/> and sets the default values.
        /// </summary>
        public UpdateWindowsDeviceAccountActionParameter()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.UpdateWindowsDeviceAccountActionParameter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.UpdateWindowsDeviceAccountActionParameter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.UpdateWindowsDeviceAccountActionParameter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "calendarSyncEnabled", n => { CalendarSyncEnabled = n.GetBoolValue(); } },
                { "deviceAccount", n => { DeviceAccount = n.GetObjectValue<global::Microsoft.Graph.Models.WindowsDeviceAccount>(global::Microsoft.Graph.Models.WindowsDeviceAccount.CreateFromDiscriminatorValue); } },
                { "deviceAccountEmail", n => { DeviceAccountEmail = n.GetStringValue(); } },
                { "exchangeServer", n => { ExchangeServer = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "passwordRotationEnabled", n => { PasswordRotationEnabled = n.GetBoolValue(); } },
                { "sessionInitiationProtocalAddress", n => { SessionInitiationProtocalAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("calendarSyncEnabled", CalendarSyncEnabled);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.WindowsDeviceAccount>("deviceAccount", DeviceAccount);
            writer.WriteStringValue("deviceAccountEmail", DeviceAccountEmail);
            writer.WriteStringValue("exchangeServer", ExchangeServer);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("passwordRotationEnabled", PasswordRotationEnabled);
            writer.WriteStringValue("sessionInitiationProtocalAddress", SessionInitiationProtocalAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
