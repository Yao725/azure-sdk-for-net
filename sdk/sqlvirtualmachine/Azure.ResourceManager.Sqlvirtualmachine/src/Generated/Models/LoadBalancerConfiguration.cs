// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sqlvirtualmachine.Models
{
    /// <summary> A load balancer configuration for an availability group listener. </summary>
    public partial class LoadBalancerConfiguration
    {
        /// <summary> Initializes a new instance of LoadBalancerConfiguration. </summary>
        public LoadBalancerConfiguration()
        {
            SqlVirtualMachineInstances = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of LoadBalancerConfiguration. </summary>
        /// <param name="privateIpAddress"> Private IP address. </param>
        /// <param name="publicIpAddressResourceId"> Resource id of the public IP. </param>
        /// <param name="loadBalancerResourceId"> Resource id of the load balancer. </param>
        /// <param name="probePort"> Probe port. </param>
        /// <param name="sqlVirtualMachineInstances"> List of the SQL virtual machine instance resource id&apos;s that are enrolled into the availability group listener. </param>
        internal LoadBalancerConfiguration(PrivateIPAddress privateIpAddress, string publicIpAddressResourceId, string loadBalancerResourceId, int? probePort, IList<string> sqlVirtualMachineInstances)
        {
            PrivateIpAddress = privateIpAddress;
            PublicIpAddressResourceId = publicIpAddressResourceId;
            LoadBalancerResourceId = loadBalancerResourceId;
            ProbePort = probePort;
            SqlVirtualMachineInstances = sqlVirtualMachineInstances;
        }

        /// <summary> Private IP address. </summary>
        public PrivateIPAddress PrivateIpAddress { get; set; }
        /// <summary> Resource id of the public IP. </summary>
        public string PublicIpAddressResourceId { get; set; }
        /// <summary> Resource id of the load balancer. </summary>
        public string LoadBalancerResourceId { get; set; }
        /// <summary> Probe port. </summary>
        public int? ProbePort { get; set; }
        /// <summary> List of the SQL virtual machine instance resource id&apos;s that are enrolled into the availability group listener. </summary>
        public IList<string> SqlVirtualMachineInstances { get; }
    }
}
