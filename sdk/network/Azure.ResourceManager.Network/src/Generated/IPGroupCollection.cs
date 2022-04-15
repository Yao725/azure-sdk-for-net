// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="IPGroupResource" /> and their operations.
    /// Each <see cref="IPGroupResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="IPGroupCollection" /> instance call the GetIPGroups method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class IPGroupCollection : ArmCollection, IEnumerable<IPGroupResource>, IAsyncEnumerable<IPGroupResource>
    {
        private readonly ClientDiagnostics _ipGroupIpGroupsClientDiagnostics;
        private readonly IpGroupsRestOperations _ipGroupIpGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="IPGroupCollection"/> class for mocking. </summary>
        protected IPGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IPGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IPGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _ipGroupIpGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", IPGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IPGroupResource.ResourceType, out string ipGroupIpGroupsApiVersion);
            _ipGroupIpGroupsRestClient = new IpGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, ipGroupIpGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an ipGroups in a specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}
        /// Operation Id: IpGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="data"> Parameters supplied to the create or update IpGroups operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IPGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ipGroupsName, IPGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ipGroupIpGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<IPGroupResource>(new IPGroupOperationSource(Client), _ipGroupIpGroupsClientDiagnostics, Pipeline, _ipGroupIpGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an ipGroups in a specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}
        /// Operation Id: IpGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="data"> Parameters supplied to the create or update IpGroups operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IPGroupResource> CreateOrUpdate(WaitUntil waitUntil, string ipGroupsName, IPGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ipGroupIpGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, data, cancellationToken);
                var operation = new NetworkArmOperation<IPGroupResource>(new IPGroupOperationSource(Client), _ipGroupIpGroupsClientDiagnostics, Pipeline, _ipGroupIpGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified ipGroups.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}
        /// Operation Id: IpGroups_Get
        /// </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public virtual async Task<Response<IPGroupResource>> GetAsync(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));

            using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _ipGroupIpGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IPGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified ipGroups.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}
        /// Operation Id: IpGroups_Get
        /// </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public virtual Response<IPGroupResource> Get(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));

            using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _ipGroupIpGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IPGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all IpGroups in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups
        /// Operation Id: IpGroups_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IPGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IPGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<IPGroupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _ipGroupIpGroupsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IPGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<IPGroupResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _ipGroupIpGroupsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IPGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all IpGroups in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups
        /// Operation Id: IpGroups_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IPGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IPGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<IPGroupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _ipGroupIpGroupsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IPGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<IPGroupResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _ipGroupIpGroupsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IPGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}
        /// Operation Id: IpGroups_Get
        /// </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));

            using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _ipGroupIpGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}
        /// Operation Id: IpGroups_Get
        /// </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public virtual Response<bool> Exists(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));

            using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _ipGroupIpGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IPGroupResource> IEnumerable<IPGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IPGroupResource> IAsyncEnumerable<IPGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
