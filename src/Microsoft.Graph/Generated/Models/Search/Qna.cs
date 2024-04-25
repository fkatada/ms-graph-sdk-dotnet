// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Search {
    #pragma warning disable CS1591
    public class Qna : SearchAnswer, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Date and time when the QnA stops appearing as a search result. Set as null for always available. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? AvailabilityEndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("availabilityEndDateTime"); }
            set { BackingStore?.Set("availabilityEndDateTime", value); }
        }
        /// <summary>Date and time when the QnA starts to appear as a search result. Set as null for always available. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? AvailabilityStartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("availabilityStartDateTime"); }
            set { BackingStore?.Set("availabilityStartDateTime", value); }
        }
        /// <summary>The list of security groups that are able to view this QnA.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GroupIds {
            get { return BackingStore?.Get<List<string>?>("groupIds"); }
            set { BackingStore?.Set("groupIds", value); }
        }
#nullable restore
#else
        public List<string> GroupIds {
            get { return BackingStore?.Get<List<string>>("groupIds"); }
            set { BackingStore?.Set("groupIds", value); }
        }
#endif
        /// <summary>True if a user or Microsoft suggested this QnA to the admin. Read-only.</summary>
        public bool? IsSuggested {
            get { return BackingStore?.Get<bool?>("isSuggested"); }
            set { BackingStore?.Set("isSuggested", value); }
        }
        /// <summary>Keywords that trigger this QnA to appear in search results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AnswerKeyword? Keywords {
            get { return BackingStore?.Get<AnswerKeyword?>("keywords"); }
            set { BackingStore?.Set("keywords", value); }
        }
#nullable restore
#else
        public AnswerKeyword Keywords {
            get { return BackingStore?.Get<AnswerKeyword>("keywords"); }
            set { BackingStore?.Set("keywords", value); }
        }
#endif
        /// <summary>A list of geographically specific language names in which this QnA can be viewed. Each language tag value follows the pattern {language}-{region}. For example, en-us is English as used in the United States. For the list of possible values, see Supported language tags.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? LanguageTags {
            get { return BackingStore?.Get<List<string>?>("languageTags"); }
            set { BackingStore?.Set("languageTags", value); }
        }
#nullable restore
#else
        public List<string> LanguageTags {
            get { return BackingStore?.Get<List<string>>("languageTags"); }
            set { BackingStore?.Set("languageTags", value); }
        }
#endif
        /// <summary>List of devices and operating systems that are able to view this QnA. Possible values are: android, androidForWork, ios, macOS, windowsPhone81, windowsPhone81AndLater, windows10AndLater, androidWorkProfile, unknown, androidASOP, androidMobileApplicationManagement, iOSMobileApplicationManagement, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DevicePlatformType?>? Platforms {
            get { return BackingStore?.Get<List<DevicePlatformType?>?>("platforms"); }
            set { BackingStore?.Set("platforms", value); }
        }
#nullable restore
#else
        public List<DevicePlatformType?> Platforms {
            get { return BackingStore?.Get<List<DevicePlatformType?>>("platforms"); }
            set { BackingStore?.Set("platforms", value); }
        }
#endif
        /// <summary>The state property</summary>
        public AnswerState? State {
            get { return BackingStore?.Get<AnswerState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>Variations of a QnA for different countries or devices. Use when you need to show different content to users based on their device, country/region, or both. The date and group settings apply to all variations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AnswerVariant>? TargetedVariations {
            get { return BackingStore?.Get<List<AnswerVariant>?>("targetedVariations"); }
            set { BackingStore?.Set("targetedVariations", value); }
        }
#nullable restore
#else
        public List<AnswerVariant> TargetedVariations {
            get { return BackingStore?.Get<List<AnswerVariant>>("targetedVariations"); }
            set { BackingStore?.Set("targetedVariations", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Qna"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Qna CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Qna();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"availabilityEndDateTime", n => { AvailabilityEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"availabilityStartDateTime", n => { AvailabilityStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"groupIds", n => { GroupIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"isSuggested", n => { IsSuggested = n.GetBoolValue(); } },
                {"keywords", n => { Keywords = n.GetObjectValue<AnswerKeyword>(AnswerKeyword.CreateFromDiscriminatorValue); } },
                {"languageTags", n => { LanguageTags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"platforms", n => { Platforms = n.GetCollectionOfEnumValues<DevicePlatformType>()?.ToList(); } },
                {"state", n => { State = n.GetEnumValue<AnswerState>(); } },
                {"targetedVariations", n => { TargetedVariations = n.GetCollectionOfObjectValues<AnswerVariant>(AnswerVariant.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteDateTimeOffsetValue("availabilityEndDateTime", AvailabilityEndDateTime);
            writer.WriteDateTimeOffsetValue("availabilityStartDateTime", AvailabilityStartDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("groupIds", GroupIds);
            writer.WriteBoolValue("isSuggested", IsSuggested);
            writer.WriteObjectValue<AnswerKeyword>("keywords", Keywords);
            writer.WriteCollectionOfPrimitiveValues<string>("languageTags", LanguageTags);
            writer.WriteCollectionOfEnumValues<DevicePlatformType>("platforms", Platforms);
            writer.WriteEnumValue<AnswerState>("state", State);
            writer.WriteCollectionOfObjectValues<AnswerVariant>("targetedVariations", TargetedVariations);
        }
    }
}
