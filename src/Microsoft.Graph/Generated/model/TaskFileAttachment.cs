// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Task File Attachment.
    /// </summary>
    public partial class TaskFileAttachment : AttachmentBase
    {
    
        ///<summary>
        /// The TaskFileAttachment constructor
        ///</summary>
        public TaskFileAttachment()
        {
            this.ODataType = "microsoft.graph.taskFileAttachment";
        }

        /// <summary>
        /// Gets or sets content bytes.
        /// The base64-encoded contents of the file.
        /// </summary>
        [JsonPropertyName("contentBytes")]
        public byte[] ContentBytes { get; set; }
    
    }
}

