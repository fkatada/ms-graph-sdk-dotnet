// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>Windows Hello for Business pin usage options</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum WindowsHelloForBusinessPinUsage
    {
        /// <summary>Allowed the usage of certain pin rule</summary>
        [EnumMember(Value = "allowed")]
        Allowed,
        /// <summary>Enforce the usage of certain pin rule</summary>
        [EnumMember(Value = "required")]
        Required,
        /// <summary>Forbit the usage of certain pin rule</summary>
        [EnumMember(Value = "disallowed")]
        Disallowed,
    }
}
