// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Contains properties for a single installer file that is associated with a given mobileAppContent version.
    /// </summary>
    public class MobileAppContentFile : Entity, IParsable 
    {
        /// <summary>The Azure Storage URI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureStorageUri {
            get { return BackingStore?.Get<string?>("azureStorageUri"); }
            set { BackingStore?.Set("azureStorageUri", value); }
        }
#nullable restore
#else
        public string AzureStorageUri {
            get { return BackingStore?.Get<string>("azureStorageUri"); }
            set { BackingStore?.Set("azureStorageUri", value); }
        }
#endif
        /// <summary>The time the Azure storage Uri expires.</summary>
        public DateTimeOffset? AzureStorageUriExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("azureStorageUriExpirationDateTime"); }
            set { BackingStore?.Set("azureStorageUriExpirationDateTime", value); }
        }
        /// <summary>The time the file was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>A value indicating whether the file is committed.</summary>
        public bool? IsCommitted {
            get { return BackingStore?.Get<bool?>("isCommitted"); }
            set { BackingStore?.Set("isCommitted", value); }
        }
        /// <summary>Indicates whether this content file is a dependency for the main content file. TRUE means that the content file is a dependency, FALSE means that the content file is not a dependency and is the main content file. Defaults to FALSE.</summary>
        public bool? IsDependency {
            get { return BackingStore?.Get<bool?>("isDependency"); }
            set { BackingStore?.Set("isDependency", value); }
        }
        /// <summary>The manifest information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Manifest {
            get { return BackingStore?.Get<byte[]?>("manifest"); }
            set { BackingStore?.Set("manifest", value); }
        }
#nullable restore
#else
        public byte[] Manifest {
            get { return BackingStore?.Get<byte[]>("manifest"); }
            set { BackingStore?.Set("manifest", value); }
        }
#endif
        /// <summary>the file name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The size of the file prior to encryption.</summary>
        public long? Size {
            get { return BackingStore?.Get<long?>("size"); }
            set { BackingStore?.Set("size", value); }
        }
        /// <summary>The size of the file after encryption.</summary>
        public long? SizeEncrypted {
            get { return BackingStore?.Get<long?>("sizeEncrypted"); }
            set { BackingStore?.Set("sizeEncrypted", value); }
        }
        /// <summary>Contains properties for upload request states.</summary>
        public MobileAppContentFileUploadState? UploadState {
            get { return BackingStore?.Get<MobileAppContentFileUploadState?>("uploadState"); }
            set { BackingStore?.Set("uploadState", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MobileAppContentFile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MobileAppContentFile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppContentFile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"azureStorageUri", n => { AzureStorageUri = n.GetStringValue(); } },
                {"azureStorageUriExpirationDateTime", n => { AzureStorageUriExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"isCommitted", n => { IsCommitted = n.GetBoolValue(); } },
                {"isDependency", n => { IsDependency = n.GetBoolValue(); } },
                {"manifest", n => { Manifest = n.GetByteArrayValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"size", n => { Size = n.GetLongValue(); } },
                {"sizeEncrypted", n => { SizeEncrypted = n.GetLongValue(); } },
                {"uploadState", n => { UploadState = n.GetEnumValue<MobileAppContentFileUploadState>(); } },
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
            writer.WriteBoolValue("isDependency", IsDependency);
            writer.WriteByteArrayValue("manifest", Manifest);
            writer.WriteStringValue("name", Name);
            writer.WriteLongValue("size", Size);
            writer.WriteLongValue("sizeEncrypted", SizeEncrypted);
            writer.WriteEnumValue<MobileAppContentFileUploadState>("uploadState", UploadState);
        }
    }
}
