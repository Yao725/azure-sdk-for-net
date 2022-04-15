// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The MongoDBCollectionPropertiesResource. </summary>
    public partial class MongoDBCollectionPropertiesResource : MongoDBCollectionResource
    {
        /// <summary> Initializes a new instance of MongoDBCollectionPropertiesResource. </summary>
        /// <param name="id"> Name of the Cosmos DB MongoDB collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public MongoDBCollectionPropertiesResource(string id) : base(id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
        }

        /// <summary> Initializes a new instance of MongoDBCollectionPropertiesResource. </summary>
        /// <param name="id"> Name of the Cosmos DB MongoDB collection. </param>
        /// <param name="shardKey"> A key-value pair of shard keys to be applied for the request. </param>
        /// <param name="indexes"> List of index keys. </param>
        /// <param name="analyticalStorageTtl"> Analytical TTL. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="ts"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        internal MongoDBCollectionPropertiesResource(string id, IDictionary<string, string> shardKey, IList<MongoIndex> indexes, int? analyticalStorageTtl, string rid, float? ts, string etag) : base(id, shardKey, indexes, analyticalStorageTtl)
        {
            Rid = rid;
            Ts = ts;
            Etag = etag;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Ts { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public string Etag { get; }
    }
}
