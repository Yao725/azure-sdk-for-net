// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update Cosmos DB Gremlin graph. </summary>
    public partial class GremlinGraphCreateOrUpdateContent : TrackedResourceData
    {
        /// <summary> Initializes a new instance of GremlinGraphCreateOrUpdateContent. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> The standard JSON format of a Gremlin graph. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resource"/> is null. </exception>
        public GremlinGraphCreateOrUpdateContent(AzureLocation location, GremlinGraphResource resource) : base(location)
        {
            if (resource == null)
            {
                throw new ArgumentNullException(nameof(resource));
            }

            Resource = resource;
        }

        /// <summary> Initializes a new instance of GremlinGraphCreateOrUpdateContent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> The standard JSON format of a Gremlin graph. </param>
        /// <param name="options"> A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request. </param>
        internal GremlinGraphCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, GremlinGraphResource resource, CreateUpdateOptions options) : base(id, name, resourceType, systemData, tags, location)
        {
            Resource = resource;
            Options = options;
        }

        /// <summary> The standard JSON format of a Gremlin graph. </summary>
        public GremlinGraphResource Resource { get; set; }
        /// <summary> A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request. </summary>
        public CreateUpdateOptions Options { get; set; }
    }
}
