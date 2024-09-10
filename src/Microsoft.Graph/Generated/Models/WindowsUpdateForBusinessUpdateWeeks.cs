// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>Scheduled the update installation on the weeks of the month</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    [Flags]
    public enum WindowsUpdateForBusinessUpdateWeeks
    {
        /// <summary>Allow the user to set.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined = 1,
        /// <summary>Scheduled the update installation on the first week of the month</summary>
        [EnumMember(Value = "firstWeek")]
        FirstWeek = 2,
        /// <summary>Scheduled the update installation on the second week of the month</summary>
        [EnumMember(Value = "secondWeek")]
        SecondWeek = 4,
        /// <summary>Scheduled the update installation on the third week of the month</summary>
        [EnumMember(Value = "thirdWeek")]
        ThirdWeek = 8,
        /// <summary>Scheduled the update installation on the fourth week of the month</summary>
        [EnumMember(Value = "fourthWeek")]
        FourthWeek = 16,
        /// <summary>Scheduled the update installation on every week of the month</summary>
        [EnumMember(Value = "everyWeek")]
        EveryWeek = 32,
        /// <summary>Evolvable enum member</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 64,
    }
}
