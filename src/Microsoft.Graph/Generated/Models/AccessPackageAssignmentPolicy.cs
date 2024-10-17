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
    public partial class AccessPackageAssignmentPolicy : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Access package containing this policy. Read-only.  Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessPackage? AccessPackage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackage?>("accessPackage"); }
            set { BackingStore?.Set("accessPackage", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessPackage AccessPackage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackage>("accessPackage"); }
            set { BackingStore?.Set("accessPackage", value); }
        }
#endif
        /// <summary>Principals that can be assigned the access package through this policy. The possible values are: notSpecified, specificDirectoryUsers, specificConnectedOrganizationUsers, specificDirectoryServicePrincipals, allMemberUsers, allDirectoryUsers, allDirectoryServicePrincipals, allConfiguredConnectedOrganizationUsers, allExternalUsers, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.AllowedTargetScope? AllowedTargetScope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AllowedTargetScope?>("allowedTargetScope"); }
            set { BackingStore?.Set("allowedTargetScope", value); }
        }
        /// <summary>This property is only present for an auto assignment policy; if absent, this is a request-based policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessPackageAutomaticRequestSettings? AutomaticRequestSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageAutomaticRequestSettings?>("automaticRequestSettings"); }
            set { BackingStore?.Set("automaticRequestSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessPackageAutomaticRequestSettings AutomaticRequestSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageAutomaticRequestSettings>("automaticRequestSettings"); }
            set { BackingStore?.Set("automaticRequestSettings", value); }
        }
#endif
        /// <summary>Catalog of the access package containing this policy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessPackageCatalog? Catalog
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageCatalog?>("catalog"); }
            set { BackingStore?.Set("catalog", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessPackageCatalog Catalog
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageCatalog>("catalog"); }
            set { BackingStore?.Set("catalog", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.CustomExtensionStageSetting>? CustomExtensionStageSettings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CustomExtensionStageSetting>?>("customExtensionStageSettings"); }
            set { BackingStore?.Set("customExtensionStageSettings", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.CustomExtensionStageSetting> CustomExtensionStageSettings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CustomExtensionStageSetting>>("customExtensionStageSettings"); }
            set { BackingStore?.Set("customExtensionStageSettings", value); }
        }
#endif
        /// <summary>The description of the policy.</summary>
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
        /// <summary>The display name of the policy.</summary>
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
        /// <summary>The expiration date for assignments created in this policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ExpirationPattern? Expiration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ExpirationPattern?>("expiration"); }
            set { BackingStore?.Set("expiration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ExpirationPattern Expiration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ExpirationPattern>("expiration"); }
            set { BackingStore?.Set("expiration", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("modifiedDateTime"); }
            set { BackingStore?.Set("modifiedDateTime", value); }
        }
        /// <summary>Questions that are posed to the  requestor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AccessPackageQuestion>? Questions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessPackageQuestion>?>("questions"); }
            set { BackingStore?.Set("questions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AccessPackageQuestion> Questions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessPackageQuestion>>("questions"); }
            set { BackingStore?.Set("questions", value); }
        }
#endif
        /// <summary>Specifies the settings for approval of requests for an access package assignment through this policy. For example, if approval is required for new requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessPackageAssignmentApprovalSettings? RequestApprovalSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageAssignmentApprovalSettings?>("requestApprovalSettings"); }
            set { BackingStore?.Set("requestApprovalSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessPackageAssignmentApprovalSettings RequestApprovalSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageAssignmentApprovalSettings>("requestApprovalSettings"); }
            set { BackingStore?.Set("requestApprovalSettings", value); }
        }
#endif
        /// <summary>Provides additional settings to select who can create a request for an access package assignment through this policy, and what they can include in their request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessPackageAssignmentRequestorSettings? RequestorSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageAssignmentRequestorSettings?>("requestorSettings"); }
            set { BackingStore?.Set("requestorSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessPackageAssignmentRequestorSettings RequestorSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageAssignmentRequestorSettings>("requestorSettings"); }
            set { BackingStore?.Set("requestorSettings", value); }
        }
#endif
        /// <summary>Settings for access reviews of assignments through this policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessPackageAssignmentReviewSettings? ReviewSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageAssignmentReviewSettings?>("reviewSettings"); }
            set { BackingStore?.Set("reviewSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessPackageAssignmentReviewSettings ReviewSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessPackageAssignmentReviewSettings>("reviewSettings"); }
            set { BackingStore?.Set("reviewSettings", value); }
        }
#endif
        /// <summary>The principals that can be assigned access from an access package through this policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SubjectSet>? SpecificAllowedTargets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SubjectSet>?>("specificAllowedTargets"); }
            set { BackingStore?.Set("specificAllowedTargets", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SubjectSet> SpecificAllowedTargets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SubjectSet>>("specificAllowedTargets"); }
            set { BackingStore?.Set("specificAllowedTargets", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AccessPackageAssignmentPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AccessPackageAssignmentPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AccessPackageAssignmentPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessPackage", n => { AccessPackage = n.GetObjectValue<global::Microsoft.Graph.Models.AccessPackage>(global::Microsoft.Graph.Models.AccessPackage.CreateFromDiscriminatorValue); } },
                { "allowedTargetScope", n => { AllowedTargetScope = n.GetEnumValue<global::Microsoft.Graph.Models.AllowedTargetScope>(); } },
                { "automaticRequestSettings", n => { AutomaticRequestSettings = n.GetObjectValue<global::Microsoft.Graph.Models.AccessPackageAutomaticRequestSettings>(global::Microsoft.Graph.Models.AccessPackageAutomaticRequestSettings.CreateFromDiscriminatorValue); } },
                { "catalog", n => { Catalog = n.GetObjectValue<global::Microsoft.Graph.Models.AccessPackageCatalog>(global::Microsoft.Graph.Models.AccessPackageCatalog.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "customExtensionStageSettings", n => { CustomExtensionStageSettings = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.CustomExtensionStageSetting>(global::Microsoft.Graph.Models.CustomExtensionStageSetting.CreateFromDiscriminatorValue)?.AsList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "expiration", n => { Expiration = n.GetObjectValue<global::Microsoft.Graph.Models.ExpirationPattern>(global::Microsoft.Graph.Models.ExpirationPattern.CreateFromDiscriminatorValue); } },
                { "modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "questions", n => { Questions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessPackageQuestion>(global::Microsoft.Graph.Models.AccessPackageQuestion.CreateFromDiscriminatorValue)?.AsList(); } },
                { "requestApprovalSettings", n => { RequestApprovalSettings = n.GetObjectValue<global::Microsoft.Graph.Models.AccessPackageAssignmentApprovalSettings>(global::Microsoft.Graph.Models.AccessPackageAssignmentApprovalSettings.CreateFromDiscriminatorValue); } },
                { "requestorSettings", n => { RequestorSettings = n.GetObjectValue<global::Microsoft.Graph.Models.AccessPackageAssignmentRequestorSettings>(global::Microsoft.Graph.Models.AccessPackageAssignmentRequestorSettings.CreateFromDiscriminatorValue); } },
                { "reviewSettings", n => { ReviewSettings = n.GetObjectValue<global::Microsoft.Graph.Models.AccessPackageAssignmentReviewSettings>(global::Microsoft.Graph.Models.AccessPackageAssignmentReviewSettings.CreateFromDiscriminatorValue); } },
                { "specificAllowedTargets", n => { SpecificAllowedTargets = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SubjectSet>(global::Microsoft.Graph.Models.SubjectSet.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.AllowedTargetScope>("allowedTargetScope", AllowedTargetScope);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessPackageAutomaticRequestSettings>("automaticRequestSettings", AutomaticRequestSettings);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessPackageCatalog>("catalog", Catalog);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.CustomExtensionStageSetting>("customExtensionStageSettings", CustomExtensionStageSettings);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ExpirationPattern>("expiration", Expiration);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessPackageQuestion>("questions", Questions);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessPackageAssignmentApprovalSettings>("requestApprovalSettings", RequestApprovalSettings);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessPackageAssignmentRequestorSettings>("requestorSettings", RequestorSettings);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessPackageAssignmentReviewSettings>("reviewSettings", ReviewSettings);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SubjectSet>("specificAllowedTargets", SpecificAllowedTargets);
        }
    }
}
#pragma warning restore CS0618
