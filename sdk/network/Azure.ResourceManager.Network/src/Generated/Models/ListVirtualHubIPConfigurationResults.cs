// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VirtualHubIpConfigurations list. </summary>
    internal partial class ListVirtualHubIPConfigurationResults
    {
        /// <summary> Initializes a new instance of ListVirtualHubIPConfigurationResults. </summary>
        internal ListVirtualHubIPConfigurationResults()
        {
            Value = new ChangeTrackingList<HubIPConfigurationData>();
        }

        /// <summary> Initializes a new instance of ListVirtualHubIPConfigurationResults. </summary>
        /// <param name="value"> The list of VirtualHubIpConfigurations. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        internal ListVirtualHubIPConfigurationResults(IReadOnlyList<HubIPConfigurationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of VirtualHubIpConfigurations. </summary>
        public IReadOnlyList<HubIPConfigurationData> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
