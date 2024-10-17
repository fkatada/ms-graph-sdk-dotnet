// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Windows Hello for Business settings lets users access their devices using a gesture, such as biometric authentication, or a PIN. Configure settings for enrolled Windows 10, Windows 10 Mobile and later.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceEnrollmentWindowsHelloForBusinessConfiguration : global::Microsoft.Graph.Models.DeviceEnrollmentConfiguration, IParsable
    {
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Models.Enablement? EnhancedBiometricsState
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Enablement?>("enhancedBiometricsState"); }
            set { BackingStore?.Set("enhancedBiometricsState", value); }
        }
        /// <summary>Controls the period of time (in days) that a PIN can be used before the system requires the user to change it. This must be set between 0 and 730, inclusive. If set to 0, the user&apos;s PIN will never expire</summary>
        public int? PinExpirationInDays
        {
            get { return BackingStore?.Get<int?>("pinExpirationInDays"); }
            set { BackingStore?.Set("pinExpirationInDays", value); }
        }
        /// <summary>Windows Hello for Business pin usage options</summary>
        public global::Microsoft.Graph.Models.WindowsHelloForBusinessPinUsage? PinLowercaseCharactersUsage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WindowsHelloForBusinessPinUsage?>("pinLowercaseCharactersUsage"); }
            set { BackingStore?.Set("pinLowercaseCharactersUsage", value); }
        }
        /// <summary>Controls the maximum number of characters allowed for the Windows Hello for Business PIN. This value must be between 4 and 127, inclusive. This value must be greater than or equal to the value set for the minimum PIN.</summary>
        public int? PinMaximumLength
        {
            get { return BackingStore?.Get<int?>("pinMaximumLength"); }
            set { BackingStore?.Set("pinMaximumLength", value); }
        }
        /// <summary>Controls the minimum number of characters required for the Windows Hello for Business PIN.  This value must be between 4 and 127, inclusive, and less than or equal to the value set for the maximum PIN.</summary>
        public int? PinMinimumLength
        {
            get { return BackingStore?.Get<int?>("pinMinimumLength"); }
            set { BackingStore?.Set("pinMinimumLength", value); }
        }
        /// <summary>Controls the ability to prevent users from using past PINs. This must be set between 0 and 50, inclusive, and the current PIN of the user is included in that count. If set to 0, previous PINs are not stored. PIN history is not preserved through a PIN reset.</summary>
        public int? PinPreviousBlockCount
        {
            get { return BackingStore?.Get<int?>("pinPreviousBlockCount"); }
            set { BackingStore?.Set("pinPreviousBlockCount", value); }
        }
        /// <summary>Windows Hello for Business pin usage options</summary>
        public global::Microsoft.Graph.Models.WindowsHelloForBusinessPinUsage? PinSpecialCharactersUsage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WindowsHelloForBusinessPinUsage?>("pinSpecialCharactersUsage"); }
            set { BackingStore?.Set("pinSpecialCharactersUsage", value); }
        }
        /// <summary>Windows Hello for Business pin usage options</summary>
        public global::Microsoft.Graph.Models.WindowsHelloForBusinessPinUsage? PinUppercaseCharactersUsage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WindowsHelloForBusinessPinUsage?>("pinUppercaseCharactersUsage"); }
            set { BackingStore?.Set("pinUppercaseCharactersUsage", value); }
        }
        /// <summary>Controls the use of Remote Windows Hello for Business. Remote Windows Hello for Business provides the ability for a portable, registered device to be usable as a companion for desktop authentication. The desktop must be Azure AD joined and the companion device must have a Windows Hello for Business PIN.</summary>
        public bool? RemotePassportEnabled
        {
            get { return BackingStore?.Get<bool?>("remotePassportEnabled"); }
            set { BackingStore?.Set("remotePassportEnabled", value); }
        }
        /// <summary>Controls whether to require a Trusted Platform Module (TPM) for provisioning Windows Hello for Business. A TPM provides an additional security benefit in that data stored on it cannot be used on other devices. If set to False, all devices can provision Windows Hello for Business even if there is not a usable TPM.</summary>
        public bool? SecurityDeviceRequired
        {
            get { return BackingStore?.Get<bool?>("securityDeviceRequired"); }
            set { BackingStore?.Set("securityDeviceRequired", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Models.Enablement? State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Enablement?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>Controls the use of biometric gestures, such as face and fingerprint, as an alternative to the Windows Hello for Business PIN.  If set to False, biometric gestures are not allowed. Users must still configure a PIN as a backup in case of failures.</summary>
        public bool? UnlockWithBiometricsEnabled
        {
            get { return BackingStore?.Get<bool?>("unlockWithBiometricsEnabled"); }
            set { BackingStore?.Set("unlockWithBiometricsEnabled", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.DeviceEnrollmentWindowsHelloForBusinessConfiguration"/> and sets the default values.
        /// </summary>
        public DeviceEnrollmentWindowsHelloForBusinessConfiguration() : base()
        {
            OdataType = "#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceEnrollmentWindowsHelloForBusinessConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.DeviceEnrollmentWindowsHelloForBusinessConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.DeviceEnrollmentWindowsHelloForBusinessConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "enhancedBiometricsState", n => { EnhancedBiometricsState = n.GetEnumValue<global::Microsoft.Graph.Models.Enablement>(); } },
                { "pinExpirationInDays", n => { PinExpirationInDays = n.GetIntValue(); } },
                { "pinLowercaseCharactersUsage", n => { PinLowercaseCharactersUsage = n.GetEnumValue<global::Microsoft.Graph.Models.WindowsHelloForBusinessPinUsage>(); } },
                { "pinMaximumLength", n => { PinMaximumLength = n.GetIntValue(); } },
                { "pinMinimumLength", n => { PinMinimumLength = n.GetIntValue(); } },
                { "pinPreviousBlockCount", n => { PinPreviousBlockCount = n.GetIntValue(); } },
                { "pinSpecialCharactersUsage", n => { PinSpecialCharactersUsage = n.GetEnumValue<global::Microsoft.Graph.Models.WindowsHelloForBusinessPinUsage>(); } },
                { "pinUppercaseCharactersUsage", n => { PinUppercaseCharactersUsage = n.GetEnumValue<global::Microsoft.Graph.Models.WindowsHelloForBusinessPinUsage>(); } },
                { "remotePassportEnabled", n => { RemotePassportEnabled = n.GetBoolValue(); } },
                { "securityDeviceRequired", n => { SecurityDeviceRequired = n.GetBoolValue(); } },
                { "state", n => { State = n.GetEnumValue<global::Microsoft.Graph.Models.Enablement>(); } },
                { "unlockWithBiometricsEnabled", n => { UnlockWithBiometricsEnabled = n.GetBoolValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Enablement>("enhancedBiometricsState", EnhancedBiometricsState);
            writer.WriteIntValue("pinExpirationInDays", PinExpirationInDays);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.WindowsHelloForBusinessPinUsage>("pinLowercaseCharactersUsage", PinLowercaseCharactersUsage);
            writer.WriteIntValue("pinMaximumLength", PinMaximumLength);
            writer.WriteIntValue("pinMinimumLength", PinMinimumLength);
            writer.WriteIntValue("pinPreviousBlockCount", PinPreviousBlockCount);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.WindowsHelloForBusinessPinUsage>("pinSpecialCharactersUsage", PinSpecialCharactersUsage);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.WindowsHelloForBusinessPinUsage>("pinUppercaseCharactersUsage", PinUppercaseCharactersUsage);
            writer.WriteBoolValue("remotePassportEnabled", RemotePassportEnabled);
            writer.WriteBoolValue("securityDeviceRequired", SecurityDeviceRequired);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Enablement>("state", State);
            writer.WriteBoolValue("unlockWithBiometricsEnabled", UnlockWithBiometricsEnabled);
        }
    }
}
#pragma warning restore CS0618
