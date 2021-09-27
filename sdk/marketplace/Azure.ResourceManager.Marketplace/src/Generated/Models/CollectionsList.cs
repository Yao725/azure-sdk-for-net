// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Marketplace;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> The CollectionsList. </summary>
    public partial class CollectionsList
    {
        /// <summary> Initializes a new instance of CollectionsList. </summary>
        internal CollectionsList()
        {
            Value = new ChangeTrackingList<CollectionData>();
        }

        /// <summary> Initializes a new instance of CollectionsList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> URL to get the next set of offer list results if there are any. </param>
        internal CollectionsList(IReadOnlyList<CollectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        public IReadOnlyList<CollectionData> Value { get; }
        /// <summary> URL to get the next set of offer list results if there are any. </summary>
        public string NextLink { get; }
    }
}
