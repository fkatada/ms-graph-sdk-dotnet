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
    public partial class Simulation : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The social engineering technique used in the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, credentialHarvesting, attachmentMalware, driveByUrl, linkInAttachment, linkToMalwareFile, unknownFutureValue, oAuthConsentGrant. Use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: oAuthConsentGrant. For more information on the types of social engineering attack techniques, see simulations.</summary>
        public global::Microsoft.Graph.Models.SimulationAttackTechnique? AttackTechnique
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SimulationAttackTechnique?>("attackTechnique"); }
            set { BackingStore?.Set("attackTechnique", value); }
        }
        /// <summary>Attack type of the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, social, cloud, endpoint, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.SimulationAttackType? AttackType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SimulationAttackType?>("attackType"); }
            set { BackingStore?.Set("attackType", value); }
        }
        /// <summary>Unique identifier for the attack simulation automation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AutomationId
        {
            get { return BackingStore?.Get<string?>("automationId"); }
            set { BackingStore?.Set("automationId", value); }
        }
#nullable restore
#else
        public string AutomationId
        {
            get { return BackingStore?.Get<string>("automationId"); }
            set { BackingStore?.Set("automationId", value); }
        }
#endif
        /// <summary>Date and time of completion of the attack simulation and training campaign. Supports $filter and $orderby.</summary>
        public DateTimeOffset? CompletionDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("completionDateTime"); }
            set { BackingStore?.Set("completionDateTime", value); }
        }
        /// <summary>Identity of the user who created the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EmailIdentity? CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EmailIdentity?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EmailIdentity CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EmailIdentity>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Date and time of creation of the attack simulation and training campaign.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description of the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Display name of the attack simulation and training campaign. Supports $filter and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Simulation duration in days.</summary>
        public int? DurationInDays
        {
            get { return BackingStore?.Get<int?>("durationInDays"); }
            set { BackingStore?.Set("durationInDays", value); }
        }
        /// <summary>Details about the end user notification setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EndUserNotificationSetting? EndUserNotificationSetting
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EndUserNotificationSetting?>("endUserNotificationSetting"); }
            set { BackingStore?.Set("endUserNotificationSetting", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EndUserNotificationSetting EndUserNotificationSetting
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EndUserNotificationSetting>("endUserNotificationSetting"); }
            set { BackingStore?.Set("endUserNotificationSetting", value); }
        }
#endif
        /// <summary>Users excluded from the simulation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccountTargetContent? ExcludedAccountTarget
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccountTargetContent?>("excludedAccountTarget"); }
            set { BackingStore?.Set("excludedAccountTarget", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccountTargetContent ExcludedAccountTarget
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccountTargetContent>("excludedAccountTarget"); }
            set { BackingStore?.Set("excludedAccountTarget", value); }
        }
#endif
        /// <summary>Users targeted in the simulation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccountTargetContent? IncludedAccountTarget
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccountTargetContent?>("includedAccountTarget"); }
            set { BackingStore?.Set("includedAccountTarget", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccountTargetContent IncludedAccountTarget
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccountTargetContent>("includedAccountTarget"); }
            set { BackingStore?.Set("includedAccountTarget", value); }
        }
#endif
        /// <summary>Flag that represents if the attack simulation and training campaign was created from a simulation automation flow. Supports $filter and $orderby.</summary>
        public bool? IsAutomated
        {
            get { return BackingStore?.Get<bool?>("isAutomated"); }
            set { BackingStore?.Set("isAutomated", value); }
        }
        /// <summary>The landing page associated with a simulation during its creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.LandingPage? LandingPage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.LandingPage?>("landingPage"); }
            set { BackingStore?.Set("landingPage", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.LandingPage LandingPage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.LandingPage>("landingPage"); }
            set { BackingStore?.Set("landingPage", value); }
        }
#endif
        /// <summary>Identity of the user who most recently modified the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EmailIdentity? LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EmailIdentity?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EmailIdentity LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EmailIdentity>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>Date and time of the most recent modification of the attack simulation and training campaign.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Date and time of the launch/start of the attack simulation and training campaign. Supports $filter and $orderby.</summary>
        public DateTimeOffset? LaunchDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("launchDateTime"); }
            set { BackingStore?.Set("launchDateTime", value); }
        }
        /// <summary>The login page associated with a simulation during its creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.LoginPage? LoginPage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.LoginPage?>("loginPage"); }
            set { BackingStore?.Set("loginPage", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.LoginPage LoginPage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.LoginPage>("loginPage"); }
            set { BackingStore?.Set("loginPage", value); }
        }
#endif
        /// <summary>OAuth app details for the OAuth technique.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.OAuthConsentAppDetail? OAuthConsentAppDetail
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OAuthConsentAppDetail?>("oAuthConsentAppDetail"); }
            set { BackingStore?.Set("oAuthConsentAppDetail", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.OAuthConsentAppDetail OAuthConsentAppDetail
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OAuthConsentAppDetail>("oAuthConsentAppDetail"); }
            set { BackingStore?.Set("oAuthConsentAppDetail", value); }
        }
#endif
        /// <summary>The payload associated with a simulation during its creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Payload? Payload
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Payload?>("payload"); }
            set { BackingStore?.Set("payload", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Payload Payload
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Payload>("payload"); }
            set { BackingStore?.Set("payload", value); }
        }
#endif
        /// <summary>Method of delivery of the phishing payload used in the attack simulation and training campaign. Possible values are: unknown, sms, email, teams, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.PayloadDeliveryPlatform? PayloadDeliveryPlatform
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PayloadDeliveryPlatform?>("payloadDeliveryPlatform"); }
            set { BackingStore?.Set("payloadDeliveryPlatform", value); }
        }
        /// <summary>Report of the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SimulationReport? Report
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SimulationReport?>("report"); }
            set { BackingStore?.Set("report", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SimulationReport Report
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SimulationReport>("report"); }
            set { BackingStore?.Set("report", value); }
        }
#endif
        /// <summary>Status of the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, draft, running, scheduled, succeeded, failed, cancelled, excluded, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.SimulationStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SimulationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>Details about the training settings for a simulation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TrainingSetting? TrainingSetting
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TrainingSetting?>("trainingSetting"); }
            set { BackingStore?.Set("trainingSetting", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TrainingSetting TrainingSetting
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TrainingSetting>("trainingSetting"); }
            set { BackingStore?.Set("trainingSetting", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Simulation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Simulation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Simulation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "attackTechnique", n => { AttackTechnique = n.GetEnumValue<global::Microsoft.Graph.Models.SimulationAttackTechnique>(); } },
                { "attackType", n => { AttackType = n.GetEnumValue<global::Microsoft.Graph.Models.SimulationAttackType>(); } },
                { "automationId", n => { AutomationId = n.GetStringValue(); } },
                { "completionDateTime", n => { CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::Microsoft.Graph.Models.EmailIdentity>(global::Microsoft.Graph.Models.EmailIdentity.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "durationInDays", n => { DurationInDays = n.GetIntValue(); } },
                { "endUserNotificationSetting", n => { EndUserNotificationSetting = n.GetObjectValue<global::Microsoft.Graph.Models.EndUserNotificationSetting>(global::Microsoft.Graph.Models.EndUserNotificationSetting.CreateFromDiscriminatorValue); } },
                { "excludedAccountTarget", n => { ExcludedAccountTarget = n.GetObjectValue<global::Microsoft.Graph.Models.AccountTargetContent>(global::Microsoft.Graph.Models.AccountTargetContent.CreateFromDiscriminatorValue); } },
                { "includedAccountTarget", n => { IncludedAccountTarget = n.GetObjectValue<global::Microsoft.Graph.Models.AccountTargetContent>(global::Microsoft.Graph.Models.AccountTargetContent.CreateFromDiscriminatorValue); } },
                { "isAutomated", n => { IsAutomated = n.GetBoolValue(); } },
                { "landingPage", n => { LandingPage = n.GetObjectValue<global::Microsoft.Graph.Models.LandingPage>(global::Microsoft.Graph.Models.LandingPage.CreateFromDiscriminatorValue); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::Microsoft.Graph.Models.EmailIdentity>(global::Microsoft.Graph.Models.EmailIdentity.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "launchDateTime", n => { LaunchDateTime = n.GetDateTimeOffsetValue(); } },
                { "loginPage", n => { LoginPage = n.GetObjectValue<global::Microsoft.Graph.Models.LoginPage>(global::Microsoft.Graph.Models.LoginPage.CreateFromDiscriminatorValue); } },
                { "oAuthConsentAppDetail", n => { OAuthConsentAppDetail = n.GetObjectValue<global::Microsoft.Graph.Models.OAuthConsentAppDetail>(global::Microsoft.Graph.Models.OAuthConsentAppDetail.CreateFromDiscriminatorValue); } },
                { "payload", n => { Payload = n.GetObjectValue<global::Microsoft.Graph.Models.Payload>(global::Microsoft.Graph.Models.Payload.CreateFromDiscriminatorValue); } },
                { "payloadDeliveryPlatform", n => { PayloadDeliveryPlatform = n.GetEnumValue<global::Microsoft.Graph.Models.PayloadDeliveryPlatform>(); } },
                { "report", n => { Report = n.GetObjectValue<global::Microsoft.Graph.Models.SimulationReport>(global::Microsoft.Graph.Models.SimulationReport.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Models.SimulationStatus>(); } },
                { "trainingSetting", n => { TrainingSetting = n.GetObjectValue<global::Microsoft.Graph.Models.TrainingSetting>(global::Microsoft.Graph.Models.TrainingSetting.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.SimulationAttackTechnique>("attackTechnique", AttackTechnique);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.SimulationAttackType>("attackType", AttackType);
            writer.WriteStringValue("automationId", AutomationId);
            writer.WriteDateTimeOffsetValue("completionDateTime", CompletionDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EmailIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("durationInDays", DurationInDays);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EndUserNotificationSetting>("endUserNotificationSetting", EndUserNotificationSetting);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccountTargetContent>("excludedAccountTarget", ExcludedAccountTarget);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccountTargetContent>("includedAccountTarget", IncludedAccountTarget);
            writer.WriteBoolValue("isAutomated", IsAutomated);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.LandingPage>("landingPage", LandingPage);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EmailIdentity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("launchDateTime", LaunchDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.LoginPage>("loginPage", LoginPage);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.OAuthConsentAppDetail>("oAuthConsentAppDetail", OAuthConsentAppDetail);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Payload>("payload", Payload);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.PayloadDeliveryPlatform>("payloadDeliveryPlatform", PayloadDeliveryPlatform);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SimulationReport>("report", Report);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.SimulationStatus>("status", Status);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TrainingSetting>("trainingSetting", TrainingSetting);
        }
    }
}
#pragma warning restore CS0618
