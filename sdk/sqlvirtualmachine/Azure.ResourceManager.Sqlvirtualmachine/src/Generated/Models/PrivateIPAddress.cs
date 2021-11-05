// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sqlvirtualmachine.Models
{
    /// <summary> A private IP address bound to the availability group listener. </summary>
    public partial class PrivateIPAddress
    {
        /// <summary> Initializes a new instance of PrivateIPAddress. </summary>
        public PrivateIPAddress()
        {
        }

        /// <summary> Initializes a new instance of PrivateIPAddress. </summary>
        /// <param name="ipAddress"> Private IP address bound to the availability group listener. </param>
        /// <param name="subnetResourceId"> Subnet used to include private IP. </param>
        internal PrivateIPAddress(string ipAddress, string subnetResourceId)
        {
            IpAddress = ipAddress;
            SubnetResourceId = subnetResourceId;
        }

        /// <summary> Private IP address bound to the availability group listener. </summary>
        public string IpAddress { get; set; }
        /// <summary> Subnet used to include private IP. </summary>
        public string SubnetResourceId { get; set; }
    }
}
