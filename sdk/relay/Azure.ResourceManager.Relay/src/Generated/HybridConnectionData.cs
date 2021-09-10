// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Relay
{
    /// <summary> A class representing the HybridConnection data model. </summary>
    public partial class HybridConnectionData : Resource
    {
        /// <summary> Initializes a new instance of HybridConnectionData. </summary>
        public HybridConnectionData()
        {
        }

        /// <summary> Initializes a new instance of HybridConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="createdAt"> The time the hybrid connection was created. </param>
        /// <param name="updatedAt"> The time the namespace was updated. </param>
        /// <param name="listenerCount"> The number of listeners for this hybrid connection. Note that min : 1 and max:25 are supported. </param>
        /// <param name="requiresClientAuthorization"> Returns true if client authorization is needed for this hybrid connection; otherwise, false. </param>
        /// <param name="userMetadata"> The usermetadata is a placeholder to store user-defined string data for the hybrid connection endpoint. For example, it can be used to store descriptive data, such as a list of teams and their contact information. Also, user-defined configuration settings can be stored. </param>
        internal HybridConnectionData(ResourceIdentifier id, string name, ResourceType type, DateTimeOffset? createdAt, DateTimeOffset? updatedAt, int? listenerCount, bool? requiresClientAuthorization, string userMetadata) : base(id, name, type)
        {
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ListenerCount = listenerCount;
            RequiresClientAuthorization = requiresClientAuthorization;
            UserMetadata = userMetadata;
        }

        /// <summary> The time the hybrid connection was created. </summary>
        public DateTimeOffset? CreatedAt { get; }
        /// <summary> The time the namespace was updated. </summary>
        public DateTimeOffset? UpdatedAt { get; }
        /// <summary> The number of listeners for this hybrid connection. Note that min : 1 and max:25 are supported. </summary>
        public int? ListenerCount { get; }
        /// <summary> Returns true if client authorization is needed for this hybrid connection; otherwise, false. </summary>
        public bool? RequiresClientAuthorization { get; set; }
        /// <summary> The usermetadata is a placeholder to store user-defined string data for the hybrid connection endpoint. For example, it can be used to store descriptive data, such as a list of teams and their contact information. Also, user-defined configuration settings can be stored. </summary>
        public string UserMetadata { get; set; }
    }
}
