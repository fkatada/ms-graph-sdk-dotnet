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
    /// Device protection status entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WindowsProtectionState : global::Microsoft.Graph.Models.Entity, IParsable
    {
        /// <summary>Current anti malware version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AntiMalwareVersion
        {
            get { return BackingStore?.Get<string?>("antiMalwareVersion"); }
            set { BackingStore?.Set("antiMalwareVersion", value); }
        }
#nullable restore
#else
        public string AntiMalwareVersion
        {
            get { return BackingStore?.Get<string>("antiMalwareVersion"); }
            set { BackingStore?.Set("antiMalwareVersion", value); }
        }
#endif
        /// <summary>Device malware list</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WindowsDeviceMalwareState>? DetectedMalwareState
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WindowsDeviceMalwareState>?>("detectedMalwareState"); }
            set { BackingStore?.Set("detectedMalwareState", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WindowsDeviceMalwareState> DetectedMalwareState
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WindowsDeviceMalwareState>>("detectedMalwareState"); }
            set { BackingStore?.Set("detectedMalwareState", value); }
        }
#endif
        /// <summary>Indicates device&apos;s health state. Possible values are: clean, fullScanPending, rebootPending, manualStepsPending, offlineScanPending, critical. Possible values are: clean, fullScanPending, rebootPending, manualStepsPending, offlineScanPending, critical.</summary>
        public global::Microsoft.Graph.Models.WindowsDeviceHealthState? DeviceState
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WindowsDeviceHealthState?>("deviceState"); }
            set { BackingStore?.Set("deviceState", value); }
        }
        /// <summary>Current endpoint protection engine&apos;s version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EngineVersion
        {
            get { return BackingStore?.Get<string?>("engineVersion"); }
            set { BackingStore?.Set("engineVersion", value); }
        }
#nullable restore
#else
        public string EngineVersion
        {
            get { return BackingStore?.Get<string>("engineVersion"); }
            set { BackingStore?.Set("engineVersion", value); }
        }
#endif
        /// <summary>When TRUE indicates full scan is overdue, when FALSE indicates full scan is not overdue. Defaults to setting on client device.</summary>
        public bool? FullScanOverdue
        {
            get { return BackingStore?.Get<bool?>("fullScanOverdue"); }
            set { BackingStore?.Set("fullScanOverdue", value); }
        }
        /// <summary>When TRUE indicates full scan is required, when FALSE indicates full scan is not required. Defaults to setting on client device.</summary>
        public bool? FullScanRequired
        {
            get { return BackingStore?.Get<bool?>("fullScanRequired"); }
            set { BackingStore?.Set("fullScanRequired", value); }
        }
        /// <summary>When TRUE indicates the device is a virtual machine, when FALSE indicates the device is not a virtual machine. Defaults to setting on client device.</summary>
        public bool? IsVirtualMachine
        {
            get { return BackingStore?.Get<bool?>("isVirtualMachine"); }
            set { BackingStore?.Set("isVirtualMachine", value); }
        }
        /// <summary>Last quick scan datetime</summary>
        public DateTimeOffset? LastFullScanDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastFullScanDateTime"); }
            set { BackingStore?.Set("lastFullScanDateTime", value); }
        }
        /// <summary>Last full scan signature version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastFullScanSignatureVersion
        {
            get { return BackingStore?.Get<string?>("lastFullScanSignatureVersion"); }
            set { BackingStore?.Set("lastFullScanSignatureVersion", value); }
        }
#nullable restore
#else
        public string LastFullScanSignatureVersion
        {
            get { return BackingStore?.Get<string>("lastFullScanSignatureVersion"); }
            set { BackingStore?.Set("lastFullScanSignatureVersion", value); }
        }
#endif
        /// <summary>Last quick scan datetime</summary>
        public DateTimeOffset? LastQuickScanDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastQuickScanDateTime"); }
            set { BackingStore?.Set("lastQuickScanDateTime", value); }
        }
        /// <summary>Last quick scan signature version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastQuickScanSignatureVersion
        {
            get { return BackingStore?.Get<string?>("lastQuickScanSignatureVersion"); }
            set { BackingStore?.Set("lastQuickScanSignatureVersion", value); }
        }
#nullable restore
#else
        public string LastQuickScanSignatureVersion
        {
            get { return BackingStore?.Get<string>("lastQuickScanSignatureVersion"); }
            set { BackingStore?.Set("lastQuickScanSignatureVersion", value); }
        }
#endif
        /// <summary>Last device health status reported time</summary>
        public DateTimeOffset? LastReportedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastReportedDateTime"); }
            set { BackingStore?.Set("lastReportedDateTime", value); }
        }
        /// <summary>When TRUE indicates anti malware is enabled when FALSE indicates anti malware is not enabled.</summary>
        public bool? MalwareProtectionEnabled
        {
            get { return BackingStore?.Get<bool?>("malwareProtectionEnabled"); }
            set { BackingStore?.Set("malwareProtectionEnabled", value); }
        }
        /// <summary>When TRUE indicates network inspection system enabled, when FALSE indicates network inspection system is not enabled. Defaults to setting on client device.</summary>
        public bool? NetworkInspectionSystemEnabled
        {
            get { return BackingStore?.Get<bool?>("networkInspectionSystemEnabled"); }
            set { BackingStore?.Set("networkInspectionSystemEnabled", value); }
        }
        /// <summary>Product Status of Windows Defender Antivirus. Possible values are: noStatus, serviceNotRunning, serviceStartedWithoutMalwareProtection, pendingFullScanDueToThreatAction, pendingRebootDueToThreatAction, pendingManualStepsDueToThreatAction, avSignaturesOutOfDate, asSignaturesOutOfDate, noQuickScanHappenedForSpecifiedPeriod, noFullScanHappenedForSpecifiedPeriod, systemInitiatedScanInProgress, systemInitiatedCleanInProgress, samplesPendingSubmission, productRunningInEvaluationMode, productRunningInNonGenuineMode, productExpired, offlineScanRequired, serviceShutdownAsPartOfSystemShutdown, threatRemediationFailedCritically, threatRemediationFailedNonCritically, noStatusFlagsSet, platformOutOfDate, platformUpdateInProgress, platformAboutToBeOutdated, signatureOrPlatformEndOfLifeIsPastOrIsImpending, windowsSModeSignaturesInUseOnNonWin10SInstall. Possible values are: noStatus, serviceNotRunning, serviceStartedWithoutMalwareProtection, pendingFullScanDueToThreatAction, pendingRebootDueToThreatAction, pendingManualStepsDueToThreatAction, avSignaturesOutOfDate, asSignaturesOutOfDate, noQuickScanHappenedForSpecifiedPeriod, noFullScanHappenedForSpecifiedPeriod, systemInitiatedScanInProgress, systemInitiatedCleanInProgress, samplesPendingSubmission, productRunningInEvaluationMode, productRunningInNonGenuineMode, productExpired, offlineScanRequired, serviceShutdownAsPartOfSystemShutdown, threatRemediationFailedCritically, threatRemediationFailedNonCritically, noStatusFlagsSet, platformOutOfDate, platformUpdateInProgress, platformAboutToBeOutdated, signatureOrPlatformEndOfLifeIsPastOrIsImpending, windowsSModeSignaturesInUseOnNonWin10SInstall.</summary>
        public global::Microsoft.Graph.Models.WindowsDefenderProductStatus? ProductStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WindowsDefenderProductStatus?>("productStatus"); }
            set { BackingStore?.Set("productStatus", value); }
        }
        /// <summary>When TRUE indicates quick scan is overdue, when FALSE indicates quick scan is not overdue. Defaults to setting on client device.</summary>
        public bool? QuickScanOverdue
        {
            get { return BackingStore?.Get<bool?>("quickScanOverdue"); }
            set { BackingStore?.Set("quickScanOverdue", value); }
        }
        /// <summary>When TRUE indicates real time protection is enabled, when FALSE indicates real time protection is not enabled. Defaults to setting on client device.</summary>
        public bool? RealTimeProtectionEnabled
        {
            get { return BackingStore?.Get<bool?>("realTimeProtectionEnabled"); }
            set { BackingStore?.Set("realTimeProtectionEnabled", value); }
        }
        /// <summary>When TRUE indicates reboot is required, when FALSE indicates when TRUE indicates reboot is not required. Defaults to setting on client device.</summary>
        public bool? RebootRequired
        {
            get { return BackingStore?.Get<bool?>("rebootRequired"); }
            set { BackingStore?.Set("rebootRequired", value); }
        }
        /// <summary>When TRUE indicates signature is out of date, when FALSE indicates signature is not out of date. Defaults to setting on client device.</summary>
        public bool? SignatureUpdateOverdue
        {
            get { return BackingStore?.Get<bool?>("signatureUpdateOverdue"); }
            set { BackingStore?.Set("signatureUpdateOverdue", value); }
        }
        /// <summary>Current malware definitions version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignatureVersion
        {
            get { return BackingStore?.Get<string?>("signatureVersion"); }
            set { BackingStore?.Set("signatureVersion", value); }
        }
#nullable restore
#else
        public string SignatureVersion
        {
            get { return BackingStore?.Get<string>("signatureVersion"); }
            set { BackingStore?.Set("signatureVersion", value); }
        }
#endif
        /// <summary>When TRUE indicates the Windows Defender tamper protection feature is enabled, when FALSE indicates the Windows Defender tamper protection feature is not enabled. Defaults to setting on client device.</summary>
        public bool? TamperProtectionEnabled
        {
            get { return BackingStore?.Get<bool?>("tamperProtectionEnabled"); }
            set { BackingStore?.Set("tamperProtectionEnabled", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.WindowsProtectionState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.WindowsProtectionState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.WindowsProtectionState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "antiMalwareVersion", n => { AntiMalwareVersion = n.GetStringValue(); } },
                { "detectedMalwareState", n => { DetectedMalwareState = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WindowsDeviceMalwareState>(global::Microsoft.Graph.Models.WindowsDeviceMalwareState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deviceState", n => { DeviceState = n.GetEnumValue<global::Microsoft.Graph.Models.WindowsDeviceHealthState>(); } },
                { "engineVersion", n => { EngineVersion = n.GetStringValue(); } },
                { "fullScanOverdue", n => { FullScanOverdue = n.GetBoolValue(); } },
                { "fullScanRequired", n => { FullScanRequired = n.GetBoolValue(); } },
                { "isVirtualMachine", n => { IsVirtualMachine = n.GetBoolValue(); } },
                { "lastFullScanDateTime", n => { LastFullScanDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastFullScanSignatureVersion", n => { LastFullScanSignatureVersion = n.GetStringValue(); } },
                { "lastQuickScanDateTime", n => { LastQuickScanDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastQuickScanSignatureVersion", n => { LastQuickScanSignatureVersion = n.GetStringValue(); } },
                { "lastReportedDateTime", n => { LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                { "malwareProtectionEnabled", n => { MalwareProtectionEnabled = n.GetBoolValue(); } },
                { "networkInspectionSystemEnabled", n => { NetworkInspectionSystemEnabled = n.GetBoolValue(); } },
                { "productStatus", n => { ProductStatus = n.GetEnumValue<global::Microsoft.Graph.Models.WindowsDefenderProductStatus>(); } },
                { "quickScanOverdue", n => { QuickScanOverdue = n.GetBoolValue(); } },
                { "realTimeProtectionEnabled", n => { RealTimeProtectionEnabled = n.GetBoolValue(); } },
                { "rebootRequired", n => { RebootRequired = n.GetBoolValue(); } },
                { "signatureUpdateOverdue", n => { SignatureUpdateOverdue = n.GetBoolValue(); } },
                { "signatureVersion", n => { SignatureVersion = n.GetStringValue(); } },
                { "tamperProtectionEnabled", n => { TamperProtectionEnabled = n.GetBoolValue(); } },
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
            writer.WriteStringValue("antiMalwareVersion", AntiMalwareVersion);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WindowsDeviceMalwareState>("detectedMalwareState", DetectedMalwareState);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.WindowsDeviceHealthState>("deviceState", DeviceState);
            writer.WriteStringValue("engineVersion", EngineVersion);
            writer.WriteBoolValue("fullScanOverdue", FullScanOverdue);
            writer.WriteBoolValue("fullScanRequired", FullScanRequired);
            writer.WriteBoolValue("isVirtualMachine", IsVirtualMachine);
            writer.WriteDateTimeOffsetValue("lastFullScanDateTime", LastFullScanDateTime);
            writer.WriteStringValue("lastFullScanSignatureVersion", LastFullScanSignatureVersion);
            writer.WriteDateTimeOffsetValue("lastQuickScanDateTime", LastQuickScanDateTime);
            writer.WriteStringValue("lastQuickScanSignatureVersion", LastQuickScanSignatureVersion);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteBoolValue("malwareProtectionEnabled", MalwareProtectionEnabled);
            writer.WriteBoolValue("networkInspectionSystemEnabled", NetworkInspectionSystemEnabled);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.WindowsDefenderProductStatus>("productStatus", ProductStatus);
            writer.WriteBoolValue("quickScanOverdue", QuickScanOverdue);
            writer.WriteBoolValue("realTimeProtectionEnabled", RealTimeProtectionEnabled);
            writer.WriteBoolValue("rebootRequired", RebootRequired);
            writer.WriteBoolValue("signatureUpdateOverdue", SignatureUpdateOverdue);
            writer.WriteStringValue("signatureVersion", SignatureVersion);
            writer.WriteBoolValue("tamperProtectionEnabled", TamperProtectionEnabled);
        }
    }
}
#pragma warning restore CS0618
