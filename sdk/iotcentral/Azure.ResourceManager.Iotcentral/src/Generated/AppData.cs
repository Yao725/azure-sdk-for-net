// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Iotcentral.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Iotcentral
{
    /// <summary> A class representing the App data model. </summary>
    public partial class AppData : TrackedResource
    {
        /// <summary> Initializes a new instance of AppData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> A valid instance SKU. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public AppData(Location location, AppSkuInfo sku) : base(location)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            Sku = sku;
        }

        /// <summary> Initializes a new instance of AppData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> A valid instance SKU. </param>
        /// <param name="identity"> The managed identities for the IoT Central application. </param>
        /// <param name="applicationId"> The ID of the application. </param>
        /// <param name="displayName"> The display name of the application. </param>
        /// <param name="subdomain"> The subdomain of the application. </param>
        /// <param name="template"> The ID of the application template, which is a blueprint that defines the characteristics and behaviors of an application. Optional; if not specified, defaults to a blank blueprint and allows the application to be defined from scratch. </param>
        /// <param name="state"> The current state of the application. </param>
        internal AppData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, AppSkuInfo sku, SystemAssignedServiceIdentity identity, string applicationId, string displayName, string subdomain, string template, AppState? state) : base(id, name, type, tags, location)
        {
            Sku = sku;
            Identity = identity;
            ApplicationId = applicationId;
            DisplayName = displayName;
            Subdomain = subdomain;
            Template = template;
            State = state;
        }

        /// <summary> A valid instance SKU. </summary>
        public AppSkuInfo Sku { get; set; }
        /// <summary> The managed identities for the IoT Central application. </summary>
        public SystemAssignedServiceIdentity Identity { get; set; }
        /// <summary> The ID of the application. </summary>
        public string ApplicationId { get; }
        /// <summary> The display name of the application. </summary>
        public string DisplayName { get; set; }
        /// <summary> The subdomain of the application. </summary>
        public string Subdomain { get; set; }
        /// <summary> The ID of the application template, which is a blueprint that defines the characteristics and behaviors of an application. Optional; if not specified, defaults to a blank blueprint and allows the application to be defined from scratch. </summary>
        public string Template { get; set; }
        /// <summary> The current state of the application. </summary>
        public AppState? State { get; }
    }
}
