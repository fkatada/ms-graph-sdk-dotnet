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
    public partial class PrinterBase : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The capabilities of the printer/printerShare.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.PrinterCapabilities? Capabilities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrinterCapabilities?>("capabilities"); }
            set { BackingStore?.Set("capabilities", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.PrinterCapabilities Capabilities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrinterCapabilities>("capabilities"); }
            set { BackingStore?.Set("capabilities", value); }
        }
#endif
        /// <summary>The default print settings of printer/printerShare.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.PrinterDefaults? Defaults
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrinterDefaults?>("defaults"); }
            set { BackingStore?.Set("defaults", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.PrinterDefaults Defaults
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrinterDefaults>("defaults"); }
            set { BackingStore?.Set("defaults", value); }
        }
#endif
        /// <summary>The name of the printer/printerShare.</summary>
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
        /// <summary>Specifies whether the printer/printerShare is currently accepting new print jobs.</summary>
        public bool? IsAcceptingJobs
        {
            get { return BackingStore?.Get<bool?>("isAcceptingJobs"); }
            set { BackingStore?.Set("isAcceptingJobs", value); }
        }
        /// <summary>The list of jobs that are queued for printing by the printer/printerShare.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.PrintJob>? Jobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintJob>?>("jobs"); }
            set { BackingStore?.Set("jobs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.PrintJob> Jobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PrintJob>>("jobs"); }
            set { BackingStore?.Set("jobs", value); }
        }
#endif
        /// <summary>The physical and/or organizational location of the printer/printerShare.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.PrinterLocation? Location
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrinterLocation?>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.PrinterLocation Location
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrinterLocation>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#endif
        /// <summary>The manufacturer of the printer/printerShare.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer
        {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer
        {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>The model name of the printer/printerShare.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model
        {
            get { return BackingStore?.Get<string?>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#nullable restore
#else
        public string Model
        {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.PrinterStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrinterStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.PrinterStatus Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PrinterStatus>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.PrinterBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.PrinterBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.printer" => new global::Microsoft.Graph.Models.Printer(),
                "#microsoft.graph.printerShare" => new global::Microsoft.Graph.Models.PrinterShare(),
                _ => new global::Microsoft.Graph.Models.PrinterBase(),
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
                { "capabilities", n => { Capabilities = n.GetObjectValue<global::Microsoft.Graph.Models.PrinterCapabilities>(global::Microsoft.Graph.Models.PrinterCapabilities.CreateFromDiscriminatorValue); } },
                { "defaults", n => { Defaults = n.GetObjectValue<global::Microsoft.Graph.Models.PrinterDefaults>(global::Microsoft.Graph.Models.PrinterDefaults.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "isAcceptingJobs", n => { IsAcceptingJobs = n.GetBoolValue(); } },
                { "jobs", n => { Jobs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.PrintJob>(global::Microsoft.Graph.Models.PrintJob.CreateFromDiscriminatorValue)?.AsList(); } },
                { "location", n => { Location = n.GetObjectValue<global::Microsoft.Graph.Models.PrinterLocation>(global::Microsoft.Graph.Models.PrinterLocation.CreateFromDiscriminatorValue); } },
                { "manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                { "model", n => { Model = n.GetStringValue(); } },
                { "status", n => { Status = n.GetObjectValue<global::Microsoft.Graph.Models.PrinterStatus>(global::Microsoft.Graph.Models.PrinterStatus.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.PrinterCapabilities>("capabilities", Capabilities);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.PrinterDefaults>("defaults", Defaults);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isAcceptingJobs", IsAcceptingJobs);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.PrintJob>("jobs", Jobs);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.PrinterLocation>("location", Location);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.PrinterStatus>("status", Status);
        }
    }
}
#pragma warning restore CS0618
