// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>The type of Exchange Connector sync requested.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DeviceManagementExchangeConnectorSyncType
    {
        /// <summary>Discover all the device in Exchange.</summary>
        [EnumMember(Value = "fullSync")]
        FullSync,
        /// <summary>Discover only the device in Exchange which have updated during the delta sync window.</summary>
        [EnumMember(Value = "deltaSync")]
        DeltaSync,
    }
}
