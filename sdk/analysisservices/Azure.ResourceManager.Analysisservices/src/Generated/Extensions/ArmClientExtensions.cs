// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace Azure.ResourceManager.Analysisservices
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region AnalysisServicesServer
        /// <summary> Gets an object representing a AnalysisServicesServer along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AnalysisServicesServer" /> object. </returns>
        public static AnalysisServicesServer GetAnalysisServicesServer(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AnalysisServicesServer(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
