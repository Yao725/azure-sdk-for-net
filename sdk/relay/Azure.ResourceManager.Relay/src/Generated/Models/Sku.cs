// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> SKU of the namespace. </summary>
    public partial class Sku
    {
        /// <summary> Initializes a new instance of Sku. </summary>
        public Sku()
        {
            Name = "Standard";
            Tier = "Standard";
        }

        /// <summary> Initializes a new instance of Sku. </summary>
        /// <param name="name"> Name of this SKU. </param>
        /// <param name="tier"> The tier of this SKU. </param>
        internal Sku(string name, string tier)
        {
            Name = name;
            Tier = tier;
        }

        /// <summary> Name of this SKU. </summary>
        public string Name { get; set; }
        /// <summary> The tier of this SKU. </summary>
        public string Tier { get; set; }
    }
}
