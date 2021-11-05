// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Azurestackhci;

namespace Azure.ResourceManager.Azurestackhci.Models
{
    /// <summary> List of clusters. </summary>
    internal partial class ClusterList
    {
        /// <summary> Initializes a new instance of ClusterList. </summary>
        internal ClusterList()
        {
            Value = new ChangeTrackingList<ClusterData>();
        }

        /// <summary> Initializes a new instance of ClusterList. </summary>
        /// <param name="value"> List of clusters. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal ClusterList(IReadOnlyList<ClusterData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of clusters. </summary>
        public IReadOnlyList<ClusterData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
