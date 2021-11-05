// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> An Azure resource. </summary>
    public partial class Resource : ResourceManager.Models.Resource
    {
        /// <summary> Initializes a new instance of Resource. </summary>
        public Resource()
        {
        }

        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        internal Resource(ResourceIdentifier id, string name, ResourceType type, SystemData systemData) : base(id, name, type)
        {
            SystemData = systemData;
        }

        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; }
    }
}
