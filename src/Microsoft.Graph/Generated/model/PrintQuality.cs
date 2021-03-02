// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum PrintQuality.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum PrintQuality
    {
    
        /// <summary>
        /// Low
        /// </summary>
        Low = 0,
	
        /// <summary>
        /// Medium
        /// </summary>
        Medium = 1,
	
        /// <summary>
        /// High
        /// </summary>
        High = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 3,
	
    }
}
