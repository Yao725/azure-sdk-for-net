// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace Azure.ResourceManager.Sqlvirtualmachine
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region AvailabilityGroupListener
        /// <summary> Gets an object representing a AvailabilityGroupListener along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvailabilityGroupListener" /> object. </returns>
        public static AvailabilityGroupListener GetAvailabilityGroupListener(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AvailabilityGroupListener(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SqlVirtualMachineGroup
        /// <summary> Gets an object representing a SqlVirtualMachineGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SqlVirtualMachineGroup" /> object. </returns>
        public static SqlVirtualMachineGroup GetSqlVirtualMachineGroup(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SqlVirtualMachineGroup(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SqlVirtualMachine
        /// <summary> Gets an object representing a SqlVirtualMachine along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SqlVirtualMachine" /> object. </returns>
        public static SqlVirtualMachine GetSqlVirtualMachine(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SqlVirtualMachine(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
