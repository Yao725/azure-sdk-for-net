// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Powerbidedicated.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Powerbidedicated
{
    /// <summary> A class representing the DedicatedCapacity data model. </summary>
    public partial class DedicatedCapacityData : Resource
    {
        /// <summary> Initializes a new instance of DedicatedCapacityData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU of the PowerBI Dedicated capacity resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public DedicatedCapacityData(Location location, CapacitySku sku) : base(location)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            Sku = sku;
        }

        /// <summary> Initializes a new instance of DedicatedCapacityData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="sku"> The SKU of the PowerBI Dedicated capacity resource. </param>
        /// <param name="administration"> A collection of Dedicated capacity administrators. </param>
        /// <param name="mode"> Specifies the generation of the Power BI Embedded capacity. If no value is specified, the default value &apos;Gen2&apos; is used. [Learn More](https://docs.microsoft.com/power-bi/developer/embedded/power-bi-embedded-generation-2). </param>
        /// <param name="state"> The current state of PowerBI Dedicated resource. The state is to indicate more states outside of resource provisioning. </param>
        /// <param name="provisioningState"> The current deployment state of PowerBI Dedicated resource. The provisioningState is to indicate states for resource provisioning. </param>
        internal DedicatedCapacityData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, SystemData systemData, CapacitySku sku, DedicatedCapacityAdministrators administration, Mode? mode, State? state, CapacityProvisioningState? provisioningState) : base(id, name, type, tags, location, systemData)
        {
            Sku = sku;
            Administration = administration;
            Mode = mode;
            State = state;
            ProvisioningState = provisioningState;
        }

        /// <summary> The SKU of the PowerBI Dedicated capacity resource. </summary>
        public CapacitySku Sku { get; set; }
        /// <summary> A collection of Dedicated capacity administrators. </summary>
        public DedicatedCapacityAdministrators Administration { get; set; }
        /// <summary> Specifies the generation of the Power BI Embedded capacity. If no value is specified, the default value &apos;Gen2&apos; is used. [Learn More](https://docs.microsoft.com/power-bi/developer/embedded/power-bi-embedded-generation-2). </summary>
        public Mode? Mode { get; set; }
        /// <summary> The current state of PowerBI Dedicated resource. The state is to indicate more states outside of resource provisioning. </summary>
        public State? State { get; }
        /// <summary> The current deployment state of PowerBI Dedicated resource. The provisioningState is to indicate states for resource provisioning. </summary>
        public CapacityProvisioningState? ProvisioningState { get; }
    }
}
