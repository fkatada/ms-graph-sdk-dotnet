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
    public partial class SynchronizationTaskExecution : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Identifier of the job run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityIdentifier
        {
            get { return BackingStore?.Get<string?>("activityIdentifier"); }
            set { BackingStore?.Set("activityIdentifier", value); }
        }
#nullable restore
#else
        public string ActivityIdentifier
        {
            get { return BackingStore?.Get<string>("activityIdentifier"); }
            set { BackingStore?.Set("activityIdentifier", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Count of processed entries that were assigned for this application.</summary>
        public long? CountEntitled
        {
            get { return BackingStore?.Get<long?>("countEntitled"); }
            set { BackingStore?.Set("countEntitled", value); }
        }
        /// <summary>Count of processed entries that were assigned for provisioning.</summary>
        public long? CountEntitledForProvisioning
        {
            get { return BackingStore?.Get<long?>("countEntitledForProvisioning"); }
            set { BackingStore?.Set("countEntitledForProvisioning", value); }
        }
        /// <summary>Count of entries that were escrowed (errors).</summary>
        public long? CountEscrowed
        {
            get { return BackingStore?.Get<long?>("countEscrowed"); }
            set { BackingStore?.Set("countEscrowed", value); }
        }
        /// <summary>Count of entries that were escrowed, including system-generated escrows.</summary>
        public long? CountEscrowedRaw
        {
            get { return BackingStore?.Get<long?>("countEscrowedRaw"); }
            set { BackingStore?.Set("countEscrowedRaw", value); }
        }
        /// <summary>Count of exported entries.</summary>
        public long? CountExported
        {
            get { return BackingStore?.Get<long?>("countExported"); }
            set { BackingStore?.Set("countExported", value); }
        }
        /// <summary>Count of entries that were expected to be exported.</summary>
        public long? CountExports
        {
            get { return BackingStore?.Get<long?>("countExports"); }
            set { BackingStore?.Set("countExports", value); }
        }
        /// <summary>Count of imported entries.</summary>
        public long? CountImported
        {
            get { return BackingStore?.Get<long?>("countImported"); }
            set { BackingStore?.Set("countImported", value); }
        }
        /// <summary>Count of imported delta-changes.</summary>
        public long? CountImportedDeltas
        {
            get { return BackingStore?.Get<long?>("countImportedDeltas"); }
            set { BackingStore?.Set("countImportedDeltas", value); }
        }
        /// <summary>Count of imported delta-changes pertaining to reference changes.</summary>
        public long? CountImportedReferenceDeltas
        {
            get { return BackingStore?.Get<long?>("countImportedReferenceDeltas"); }
            set { BackingStore?.Set("countImportedReferenceDeltas", value); }
        }
        /// <summary>If an error was encountered, contains a synchronizationError object with details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SynchronizationError? Error
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SynchronizationError?>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SynchronizationError Error
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SynchronizationError>("error"); }
            set { BackingStore?.Set("error", value); }
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
        /// <summary>The state property</summary>
        public global::Microsoft.Graph.Models.SynchronizationTaskExecutionResult? State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SynchronizationTaskExecutionResult?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>Time when this job run began. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? TimeBegan
        {
            get { return BackingStore?.Get<DateTimeOffset?>("timeBegan"); }
            set { BackingStore?.Set("timeBegan", value); }
        }
        /// <summary>Time when this job run ended. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? TimeEnded
        {
            get { return BackingStore?.Get<DateTimeOffset?>("timeEnded"); }
            set { BackingStore?.Set("timeEnded", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.SynchronizationTaskExecution"/> and sets the default values.
        /// </summary>
        public SynchronizationTaskExecution()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SynchronizationTaskExecution"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.SynchronizationTaskExecution CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.SynchronizationTaskExecution();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "activityIdentifier", n => { ActivityIdentifier = n.GetStringValue(); } },
                { "countEntitled", n => { CountEntitled = n.GetLongValue(); } },
                { "countEntitledForProvisioning", n => { CountEntitledForProvisioning = n.GetLongValue(); } },
                { "countEscrowed", n => { CountEscrowed = n.GetLongValue(); } },
                { "countEscrowedRaw", n => { CountEscrowedRaw = n.GetLongValue(); } },
                { "countExported", n => { CountExported = n.GetLongValue(); } },
                { "countExports", n => { CountExports = n.GetLongValue(); } },
                { "countImported", n => { CountImported = n.GetLongValue(); } },
                { "countImportedDeltas", n => { CountImportedDeltas = n.GetLongValue(); } },
                { "countImportedReferenceDeltas", n => { CountImportedReferenceDeltas = n.GetLongValue(); } },
                { "error", n => { Error = n.GetObjectValue<global::Microsoft.Graph.Models.SynchronizationError>(global::Microsoft.Graph.Models.SynchronizationError.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "state", n => { State = n.GetEnumValue<global::Microsoft.Graph.Models.SynchronizationTaskExecutionResult>(); } },
                { "timeBegan", n => { TimeBegan = n.GetDateTimeOffsetValue(); } },
                { "timeEnded", n => { TimeEnded = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activityIdentifier", ActivityIdentifier);
            writer.WriteLongValue("countEntitled", CountEntitled);
            writer.WriteLongValue("countEntitledForProvisioning", CountEntitledForProvisioning);
            writer.WriteLongValue("countEscrowed", CountEscrowed);
            writer.WriteLongValue("countEscrowedRaw", CountEscrowedRaw);
            writer.WriteLongValue("countExported", CountExported);
            writer.WriteLongValue("countExports", CountExports);
            writer.WriteLongValue("countImported", CountImported);
            writer.WriteLongValue("countImportedDeltas", CountImportedDeltas);
            writer.WriteLongValue("countImportedReferenceDeltas", CountImportedReferenceDeltas);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SynchronizationError>("error", Error);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.SynchronizationTaskExecutionResult>("state", State);
            writer.WriteDateTimeOffsetValue("timeBegan", TimeBegan);
            writer.WriteDateTimeOffsetValue("timeEnded", TimeEnded);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
