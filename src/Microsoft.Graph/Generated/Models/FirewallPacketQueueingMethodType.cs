// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>Possible values for firewallPacketQueueingMethod</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum FirewallPacketQueueingMethodType
    {
        /// <summary>No value configured by Intune, do not override the user-configured device default value</summary>
        [EnumMember(Value = "deviceDefault")]
        DeviceDefault,
        /// <summary>Disable packet queuing</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>Queue inbound encrypted packets</summary>
        [EnumMember(Value = "queueInbound")]
        QueueInbound,
        /// <summary>Queue decrypted outbound packets for forwarding</summary>
        [EnumMember(Value = "queueOutbound")]
        QueueOutbound,
        /// <summary>Queue both inbound and outbound packets</summary>
        [EnumMember(Value = "queueBoth")]
        QueueBoth,
    }
}
