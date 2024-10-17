// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>Possible values for when accounts are deleted on a shared PC.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum SharedPCAccountDeletionPolicyType
    {
        /// <summary>Delete immediately.</summary>
        [EnumMember(Value = "immediate")]
        Immediate,
        /// <summary>Delete at disk space threshold.</summary>
        [EnumMember(Value = "diskSpaceThreshold")]
        DiskSpaceThreshold,
        /// <summary>Delete at disk space threshold or inactive threshold.</summary>
        [EnumMember(Value = "diskSpaceThresholdOrInactiveThreshold")]
        DiskSpaceThresholdOrInactiveThreshold,
    }
}
