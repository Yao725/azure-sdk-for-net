// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> A map of collections subscriptions details. </summary>
    public partial class CollectionsToSubscriptionsMappingResponse
    {
        /// <summary> Initializes a new instance of CollectionsToSubscriptionsMappingResponse. </summary>
        internal CollectionsToSubscriptionsMappingResponse()
        {
            Details = new ChangeTrackingDictionary<string, CollectionsSubscriptionsMappingDetails>();
        }

        /// <summary> Initializes a new instance of CollectionsToSubscriptionsMappingResponse. </summary>
        /// <param name="details"> The map of collections subscriptions. </param>
        internal CollectionsToSubscriptionsMappingResponse(IReadOnlyDictionary<string, CollectionsSubscriptionsMappingDetails> details)
        {
            Details = details;
        }

        /// <summary> The map of collections subscriptions. </summary>
        public IReadOnlyDictionary<string, CollectionsSubscriptionsMappingDetails> Details { get; }
    }
}
