// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Powerbidedicated.Models
{
    /// <summary> Represents an instance of an PowerBI Dedicated resource. </summary>
    public partial class Resource : TrackedResource
    {
        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="location"> The location. </param>
        public Resource(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        internal Resource(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, SystemData systemData) : base(id, name, type, tags, location)
        {
            SystemData = systemData;
        }

        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; set; }
    }
}
