// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Privatedns.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Privatedns
{
    /// <summary> A class representing the PrivateZone data model. </summary>
    public partial class PrivateZoneData : TrackedResource
    {
        /// <summary> Initializes a new instance of PrivateZoneData. </summary>
        /// <param name="location"> The location. </param>
        public PrivateZoneData(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of PrivateZoneData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> The ETag of the zone. </param>
        /// <param name="maxNumberOfRecordSets"> The maximum number of record sets that can be created in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="numberOfRecordSets"> The current number of record sets in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="maxNumberOfVirtualNetworkLinks"> The maximum number of virtual networks that can be linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="numberOfVirtualNetworkLinks"> The current number of virtual networks that are linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="maxNumberOfVirtualNetworkLinksWithRegistration"> The maximum number of virtual networks that can be linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="numberOfVirtualNetworkLinksWithRegistration"> The current number of virtual networks that are linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="internalId"> Private zone internal Id. </param>
        internal PrivateZoneData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, string etag, long? maxNumberOfRecordSets, long? numberOfRecordSets, long? maxNumberOfVirtualNetworkLinks, long? numberOfVirtualNetworkLinks, long? maxNumberOfVirtualNetworkLinksWithRegistration, long? numberOfVirtualNetworkLinksWithRegistration, ProvisioningState? provisioningState, string internalId) : base(id, name, type, tags, location)
        {
            Etag = etag;
            MaxNumberOfRecordSets = maxNumberOfRecordSets;
            NumberOfRecordSets = numberOfRecordSets;
            MaxNumberOfVirtualNetworkLinks = maxNumberOfVirtualNetworkLinks;
            NumberOfVirtualNetworkLinks = numberOfVirtualNetworkLinks;
            MaxNumberOfVirtualNetworkLinksWithRegistration = maxNumberOfVirtualNetworkLinksWithRegistration;
            NumberOfVirtualNetworkLinksWithRegistration = numberOfVirtualNetworkLinksWithRegistration;
            ProvisioningState = provisioningState;
            InternalId = internalId;
        }

        /// <summary> The ETag of the zone. </summary>
        public string Etag { get; set; }
        /// <summary> The maximum number of record sets that can be created in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? MaxNumberOfRecordSets { get; }
        /// <summary> The current number of record sets in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? NumberOfRecordSets { get; }
        /// <summary> The maximum number of virtual networks that can be linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? MaxNumberOfVirtualNetworkLinks { get; }
        /// <summary> The current number of virtual networks that are linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? NumberOfVirtualNetworkLinks { get; }
        /// <summary> The maximum number of virtual networks that can be linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? MaxNumberOfVirtualNetworkLinksWithRegistration { get; }
        /// <summary> The current number of virtual networks that are linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? NumberOfVirtualNetworkLinksWithRegistration { get; }
        /// <summary> The provisioning state of the resource. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Private zone internal Id. </summary>
        public string InternalId { get; }
    }
}
