// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Extendedlocation.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Extendedlocation
{
    /// <summary> A class representing the CustomLocation data model. </summary>
    public partial class CustomLocationData : TrackedResource
    {
        /// <summary> Initializes a new instance of CustomLocationData. </summary>
        /// <param name="location"> The location. </param>
        public CustomLocationData(Location location) : base(location)
        {
            ClusterExtensionIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CustomLocationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="authentication"> This is optional input that contains the authentication that should be used to generate the namespace. </param>
        /// <param name="clusterExtensionIds"> Contains the reference to the add-on that contains charts to deploy CRDs and operators. </param>
        /// <param name="displayName"> Display name for the Custom Locations location. </param>
        /// <param name="hostResourceId"> Connected Cluster or AKS Cluster. The Custom Locations RP will perform a checkAccess API for listAdminCredentials permissions. </param>
        /// <param name="hostType"> Type of host the Custom Locations is referencing (Kubernetes, etc...). </param>
        /// <param name="namespace"> Kubernetes namespace that will be created on the specified cluster. </param>
        /// <param name="provisioningState"> Provisioning State for the Custom Location. </param>
        internal CustomLocationData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, SystemData systemData, CustomLocationPropertiesAuthentication authentication, IList<string> clusterExtensionIds, string displayName, string hostResourceId, HostType? hostType, string @namespace, string provisioningState) : base(id, name, type, tags, location)
        {
            SystemData = systemData;
            Authentication = authentication;
            ClusterExtensionIds = clusterExtensionIds;
            DisplayName = displayName;
            HostResourceId = hostResourceId;
            HostType = hostType;
            Namespace = @namespace;
            ProvisioningState = provisioningState;
        }

        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; }
        /// <summary> This is optional input that contains the authentication that should be used to generate the namespace. </summary>
        public CustomLocationPropertiesAuthentication Authentication { get; set; }
        /// <summary> Contains the reference to the add-on that contains charts to deploy CRDs and operators. </summary>
        public IList<string> ClusterExtensionIds { get; }
        /// <summary> Display name for the Custom Locations location. </summary>
        public string DisplayName { get; set; }
        /// <summary> Connected Cluster or AKS Cluster. The Custom Locations RP will perform a checkAccess API for listAdminCredentials permissions. </summary>
        public string HostResourceId { get; set; }
        /// <summary> Type of host the Custom Locations is referencing (Kubernetes, etc...). </summary>
        public HostType? HostType { get; set; }
        /// <summary> Kubernetes namespace that will be created on the specified cluster. </summary>
        public string Namespace { get; set; }
        /// <summary> Provisioning State for the Custom Location. </summary>
        public string ProvisioningState { get; set; }
    }
}
