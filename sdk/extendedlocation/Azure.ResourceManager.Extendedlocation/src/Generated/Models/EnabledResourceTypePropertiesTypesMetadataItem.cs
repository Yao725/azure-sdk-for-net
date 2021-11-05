// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Extendedlocation.Models
{
    /// <summary> Metadata of the Resource Type. </summary>
    public partial class EnabledResourceTypePropertiesTypesMetadataItem
    {
        /// <summary> Initializes a new instance of EnabledResourceTypePropertiesTypesMetadataItem. </summary>
        public EnabledResourceTypePropertiesTypesMetadataItem()
        {
        }

        /// <summary> Initializes a new instance of EnabledResourceTypePropertiesTypesMetadataItem. </summary>
        /// <param name="apiVersion"> Api Version of Resource Type. </param>
        /// <param name="resourceProviderNamespace"> Resource Provider Namespace of Resource Type. </param>
        /// <param name="resourceType"> Resource Type. </param>
        internal EnabledResourceTypePropertiesTypesMetadataItem(string apiVersion, string resourceProviderNamespace, string resourceType)
        {
            ApiVersion = apiVersion;
            ResourceProviderNamespace = resourceProviderNamespace;
            ResourceType = resourceType;
        }

        /// <summary> Api Version of Resource Type. </summary>
        public string ApiVersion { get; set; }
        /// <summary> Resource Provider Namespace of Resource Type. </summary>
        public string ResourceProviderNamespace { get; set; }
        /// <summary> Resource Type. </summary>
        public string ResourceType { get; set; }
    }
}
