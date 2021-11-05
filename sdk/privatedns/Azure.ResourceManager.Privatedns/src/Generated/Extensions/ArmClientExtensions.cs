// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace Azure.ResourceManager.Privatedns
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region PrivateZone
        /// <summary> Gets an object representing a PrivateZone along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateZone" /> object. </returns>
        public static PrivateZone GetPrivateZone(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateZone(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualNetworkLink
        /// <summary> Gets an object representing a VirtualNetworkLink along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualNetworkLink" /> object. </returns>
        public static VirtualNetworkLink GetVirtualNetworkLink(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualNetworkLink(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region RecordSet
        /// <summary> Gets an object representing a RecordSet along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RecordSet" /> object. </returns>
        public static RecordSet GetRecordSet(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new RecordSet(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
