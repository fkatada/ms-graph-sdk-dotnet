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
    public partial class ServicePrincipalRiskDetection : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates the activity type the detected risk is linked to.  The possible values are: signin, servicePrincipal. Use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: servicePrincipal.</summary>
        public global::Microsoft.Graph.Models.ActivityType? Activity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ActivityType?>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
        /// <summary>Date and time when the risky activity occurred. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ActivityDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("activityDateTime"); }
            set { BackingStore?.Set("activityDateTime", value); }
        }
        /// <summary>Additional information associated with the risk detection. This string value is represented as a JSON object with the quotations escaped.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalInfo
        {
            get { return BackingStore?.Get<string?>("additionalInfo"); }
            set { BackingStore?.Set("additionalInfo", value); }
        }
#nullable restore
#else
        public string AdditionalInfo
        {
            get { return BackingStore?.Get<string>("additionalInfo"); }
            set { BackingStore?.Set("additionalInfo", value); }
        }
#endif
        /// <summary>The unique identifier for the associated application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId
        {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId
        {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>Correlation ID of the sign-in activity associated with the risk detection. This property is null if the risk detection is not associated with a sign-in activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId
        {
            get { return BackingStore?.Get<string?>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#nullable restore
#else
        public string CorrelationId
        {
            get { return BackingStore?.Get<string>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#endif
        /// <summary>Date and time when the risk was detected. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? DetectedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("detectedDateTime"); }
            set { BackingStore?.Set("detectedDateTime", value); }
        }
        /// <summary>Timing of the detected risk , whether real-time or offline. The possible values are: notDefined, realtime, nearRealtime, offline, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.RiskDetectionTimingType? DetectionTimingType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RiskDetectionTimingType?>("detectionTimingType"); }
            set { BackingStore?.Set("detectionTimingType", value); }
        }
        /// <summary>Provides the IP address of the client from where the risk occurred.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress
        {
            get { return BackingStore?.Get<string?>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#nullable restore
#else
        public string IpAddress
        {
            get { return BackingStore?.Get<string>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#endif
        /// <summary>The unique identifier for the key credential associated with the risk detection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? KeyIds
        {
            get { return BackingStore?.Get<List<string>?>("keyIds"); }
            set { BackingStore?.Set("keyIds", value); }
        }
#nullable restore
#else
        public List<string> KeyIds
        {
            get { return BackingStore?.Get<List<string>>("keyIds"); }
            set { BackingStore?.Set("keyIds", value); }
        }
#endif
        /// <summary>Date and time when the risk detection was last updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>Location from where the sign-in was initiated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SignInLocation? Location
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SignInLocation?>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SignInLocation Location
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SignInLocation>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#endif
        /// <summary>Request identifier of the sign-in activity associated with the risk detection. This property is null if the risk detection is not associated with a sign-in activity. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestId
        {
            get { return BackingStore?.Get<string?>("requestId"); }
            set { BackingStore?.Set("requestId", value); }
        }
#nullable restore
#else
        public string RequestId
        {
            get { return BackingStore?.Get<string>("requestId"); }
            set { BackingStore?.Set("requestId", value); }
        }
#endif
        /// <summary>Details of the detected risk. Note: Details for this property are only available for Workload Identities Premium customers. Events in tenants without this license will be returned hidden. The possible values are: none, hidden, adminConfirmedServicePrincipalCompromised, adminDismissedAllRiskForServicePrincipal. Use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: adminConfirmedServicePrincipalCompromised , adminDismissedAllRiskForServicePrincipal.</summary>
        public global::Microsoft.Graph.Models.RiskDetail? RiskDetail
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RiskDetail?>("riskDetail"); }
            set { BackingStore?.Set("riskDetail", value); }
        }
        /// <summary>The type of risk event detected. The possible values are: investigationsThreatIntelligence, generic, adminConfirmedServicePrincipalCompromised, suspiciousSignins, leakedCredentials, anomalousServicePrincipalActivity, maliciousApplication, suspiciousApplication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RiskEventType
        {
            get { return BackingStore?.Get<string?>("riskEventType"); }
            set { BackingStore?.Set("riskEventType", value); }
        }
#nullable restore
#else
        public string RiskEventType
        {
            get { return BackingStore?.Get<string>("riskEventType"); }
            set { BackingStore?.Set("riskEventType", value); }
        }
#endif
        /// <summary>Level of the detected risk. Note: Details for this property are only available for Workload Identities Premium customers. Events in tenants without this license will be returned hidden. The possible values are: low, medium, high, hidden, none.</summary>
        public global::Microsoft.Graph.Models.RiskLevel? RiskLevel
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RiskLevel?>("riskLevel"); }
            set { BackingStore?.Set("riskLevel", value); }
        }
        /// <summary>The state of a detected risky service principal or sign-in activity. The possible values are: none, dismissed, atRisk, confirmedCompromised.</summary>
        public global::Microsoft.Graph.Models.RiskState? RiskState
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RiskState?>("riskState"); }
            set { BackingStore?.Set("riskState", value); }
        }
        /// <summary>The display name for the service principal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePrincipalDisplayName
        {
            get { return BackingStore?.Get<string?>("servicePrincipalDisplayName"); }
            set { BackingStore?.Set("servicePrincipalDisplayName", value); }
        }
#nullable restore
#else
        public string ServicePrincipalDisplayName
        {
            get { return BackingStore?.Get<string>("servicePrincipalDisplayName"); }
            set { BackingStore?.Set("servicePrincipalDisplayName", value); }
        }
#endif
        /// <summary>The unique identifier for the service principal. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePrincipalId
        {
            get { return BackingStore?.Get<string?>("servicePrincipalId"); }
            set { BackingStore?.Set("servicePrincipalId", value); }
        }
#nullable restore
#else
        public string ServicePrincipalId
        {
            get { return BackingStore?.Get<string>("servicePrincipalId"); }
            set { BackingStore?.Set("servicePrincipalId", value); }
        }
#endif
        /// <summary>Source of the risk detection. For example, identityProtection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source
        {
            get { return BackingStore?.Get<string?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#nullable restore
#else
        public string Source
        {
            get { return BackingStore?.Get<string>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#endif
        /// <summary>Indicates the type of token issuer for the detected sign-in risk. The possible values are: AzureAD.</summary>
        public global::Microsoft.Graph.Models.TokenIssuerType? TokenIssuerType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TokenIssuerType?>("tokenIssuerType"); }
            set { BackingStore?.Set("tokenIssuerType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ServicePrincipalRiskDetection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ServicePrincipalRiskDetection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ServicePrincipalRiskDetection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activity", n => { Activity = n.GetEnumValue<global::Microsoft.Graph.Models.ActivityType>(); } },
                { "activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                { "additionalInfo", n => { AdditionalInfo = n.GetStringValue(); } },
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "correlationId", n => { CorrelationId = n.GetStringValue(); } },
                { "detectedDateTime", n => { DetectedDateTime = n.GetDateTimeOffsetValue(); } },
                { "detectionTimingType", n => { DetectionTimingType = n.GetEnumValue<global::Microsoft.Graph.Models.RiskDetectionTimingType>(); } },
                { "ipAddress", n => { IpAddress = n.GetStringValue(); } },
                { "keyIds", n => { KeyIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "location", n => { Location = n.GetObjectValue<global::Microsoft.Graph.Models.SignInLocation>(global::Microsoft.Graph.Models.SignInLocation.CreateFromDiscriminatorValue); } },
                { "requestId", n => { RequestId = n.GetStringValue(); } },
                { "riskDetail", n => { RiskDetail = n.GetEnumValue<global::Microsoft.Graph.Models.RiskDetail>(); } },
                { "riskEventType", n => { RiskEventType = n.GetStringValue(); } },
                { "riskLevel", n => { RiskLevel = n.GetEnumValue<global::Microsoft.Graph.Models.RiskLevel>(); } },
                { "riskState", n => { RiskState = n.GetEnumValue<global::Microsoft.Graph.Models.RiskState>(); } },
                { "servicePrincipalDisplayName", n => { ServicePrincipalDisplayName = n.GetStringValue(); } },
                { "servicePrincipalId", n => { ServicePrincipalId = n.GetStringValue(); } },
                { "source", n => { Source = n.GetStringValue(); } },
                { "tokenIssuerType", n => { TokenIssuerType = n.GetEnumValue<global::Microsoft.Graph.Models.TokenIssuerType>(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ActivityType>("activity", Activity);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("additionalInfo", AdditionalInfo);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteDateTimeOffsetValue("detectedDateTime", DetectedDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.RiskDetectionTimingType>("detectionTimingType", DetectionTimingType);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteCollectionOfPrimitiveValues<string>("keyIds", KeyIds);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SignInLocation>("location", Location);
            writer.WriteStringValue("requestId", RequestId);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.RiskDetail>("riskDetail", RiskDetail);
            writer.WriteStringValue("riskEventType", RiskEventType);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.RiskLevel>("riskLevel", RiskLevel);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.RiskState>("riskState", RiskState);
            writer.WriteStringValue("servicePrincipalDisplayName", ServicePrincipalDisplayName);
            writer.WriteStringValue("servicePrincipalId", ServicePrincipalId);
            writer.WriteStringValue("source", Source);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.TokenIssuerType>("tokenIssuerType", TokenIssuerType);
        }
    }
}
#pragma warning restore CS0618
