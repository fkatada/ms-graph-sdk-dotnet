// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>Work From Anywhere windows device upgrade eligibility status.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum OperatingSystemUpgradeEligibility
    {
        /// <summary>The device is upgraded to latest version of windows.</summary>
        [EnumMember(Value = "upgraded")]
        Upgraded,
        /// <summary>Not enough data available to compute the eligibility of device for windows upgrade.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>The device is not capable for windows upgrade.</summary>
        [EnumMember(Value = "notCapable")]
        NotCapable,
        /// <summary>The device is capable for windows upgrade.</summary>
        [EnumMember(Value = "capable")]
        Capable,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
