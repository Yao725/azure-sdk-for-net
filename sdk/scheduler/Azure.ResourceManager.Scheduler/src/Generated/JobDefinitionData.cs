// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Scheduler.Models;

namespace Azure.ResourceManager.Scheduler
{
    /// <summary> A class representing the JobDefinition data model. </summary>
    public partial class JobDefinitionData : Resource
    {
        /// <summary> Initializes a new instance of JobDefinitionData. </summary>
        public JobDefinitionData()
        {
        }

        /// <summary> Initializes a new instance of JobDefinitionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="properties"> Gets or sets the job properties. </param>
        internal JobDefinitionData(ResourceIdentifier id, string name, ResourceType type, JobProperties properties) : base(id, name, type)
        {
            Properties = properties;
        }

        /// <summary> Gets or sets the job properties. </summary>
        public JobProperties Properties { get; set; }
    }
}
