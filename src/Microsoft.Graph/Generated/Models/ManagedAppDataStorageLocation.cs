// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>Storage locations where managed apps can potentially store their data</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ManagedAppDataStorageLocation
    {
        /// <summary>OneDrive for business</summary>
        [EnumMember(Value = "oneDriveForBusiness")]
        OneDriveForBusiness,
        /// <summary>SharePoint</summary>
        [EnumMember(Value = "sharePoint")]
        SharePoint,
        /// <summary>Box</summary>
        [EnumMember(Value = "box")]
        Box,
        /// <summary>Local storage on the device</summary>
        [EnumMember(Value = "localStorage")]
        LocalStorage,
    }
}
