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

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="DataCenterResource" /> and their operations.
    /// Each <see cref="DataCenterResource" /> in the collection will belong to the same instance of <see cref="ClusterResource" />.
    /// To get a <see cref="DataCenterResourceCollection" /> instance call the GetDataCenterResources method from an instance of <see cref="ClusterResource" />.
    /// </summary>
    public partial class DataCenterResourceCollection : ArmCollection, IEnumerable<DataCenterResource>, IAsyncEnumerable<DataCenterResource>
    {
        private readonly ClientDiagnostics _dataCenterResourceCassandraDataCentersClientDiagnostics;
        private readonly CassandraDataCentersRestOperations _dataCenterResourceCassandraDataCentersRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataCenterResourceCollection"/> class for mocking. </summary>
        protected DataCenterResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataCenterResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataCenterResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataCenterResourceCassandraDataCentersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", DataCenterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataCenterResource.ResourceType, out string dataCenterResourceCassandraDataCentersApiVersion);
            _dataCenterResourceCassandraDataCentersRestClient = new CassandraDataCentersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataCenterResourceCassandraDataCentersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a managed Cassandra data center. When updating, overwrite all properties. To update only some properties, use PATCH.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters/{dataCenterName}
        /// Operation Id: CassandraDataCenters_CreateUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataCenterName"> Data center name in a managed Cassandra cluster. </param>
        /// <param name="data"> Parameters specifying the managed Cassandra data center. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCenterName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataCenterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dataCenterName, DataCenterResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCenterName, nameof(dataCenterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataCenterResourceCassandraDataCentersClientDiagnostics.CreateScope("DataCenterResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataCenterResourceCassandraDataCentersRestClient.CreateUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<DataCenterResource>(new DataCenterResourceOperationSource(Client), _dataCenterResourceCassandraDataCentersClientDiagnostics, Pipeline, _dataCenterResourceCassandraDataCentersRestClient.CreateCreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a managed Cassandra data center. When updating, overwrite all properties. To update only some properties, use PATCH.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters/{dataCenterName}
        /// Operation Id: CassandraDataCenters_CreateUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataCenterName"> Data center name in a managed Cassandra cluster. </param>
        /// <param name="data"> Parameters specifying the managed Cassandra data center. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCenterName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataCenterResource> CreateOrUpdate(WaitUntil waitUntil, string dataCenterName, DataCenterResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCenterName, nameof(dataCenterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataCenterResourceCassandraDataCentersClientDiagnostics.CreateScope("DataCenterResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataCenterResourceCassandraDataCentersRestClient.CreateUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, data, cancellationToken);
                var operation = new CosmosDBArmOperation<DataCenterResource>(new DataCenterResourceOperationSource(Client), _dataCenterResourceCassandraDataCentersClientDiagnostics, Pipeline, _dataCenterResourceCassandraDataCentersRestClient.CreateCreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get the properties of a managed Cassandra data center.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters/{dataCenterName}
        /// Operation Id: CassandraDataCenters_Get
        /// </summary>
        /// <param name="dataCenterName"> Data center name in a managed Cassandra cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCenterName"/> is null. </exception>
        public virtual async Task<Response<DataCenterResource>> GetAsync(string dataCenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCenterName, nameof(dataCenterName));

            using var scope = _dataCenterResourceCassandraDataCentersClientDiagnostics.CreateScope("DataCenterResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataCenterResourceCassandraDataCentersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataCenterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of a managed Cassandra data center.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters/{dataCenterName}
        /// Operation Id: CassandraDataCenters_Get
        /// </summary>
        /// <param name="dataCenterName"> Data center name in a managed Cassandra cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCenterName"/> is null. </exception>
        public virtual Response<DataCenterResource> Get(string dataCenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCenterName, nameof(dataCenterName));

            using var scope = _dataCenterResourceCassandraDataCentersClientDiagnostics.CreateScope("DataCenterResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _dataCenterResourceCassandraDataCentersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataCenterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all data centers in a particular managed Cassandra cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters
        /// Operation Id: CassandraDataCenters_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataCenterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataCenterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataCenterResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataCenterResourceCassandraDataCentersClientDiagnostics.CreateScope("DataCenterResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataCenterResourceCassandraDataCentersRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataCenterResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List all data centers in a particular managed Cassandra cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters
        /// Operation Id: CassandraDataCenters_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataCenterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataCenterResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DataCenterResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataCenterResourceCassandraDataCentersClientDiagnostics.CreateScope("DataCenterResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataCenterResourceCassandraDataCentersRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataCenterResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters/{dataCenterName}
        /// Operation Id: CassandraDataCenters_Get
        /// </summary>
        /// <param name="dataCenterName"> Data center name in a managed Cassandra cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCenterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataCenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCenterName, nameof(dataCenterName));

            using var scope = _dataCenterResourceCassandraDataCentersClientDiagnostics.CreateScope("DataCenterResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataCenterResourceCassandraDataCentersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters/{dataCenterName}
        /// Operation Id: CassandraDataCenters_Get
        /// </summary>
        /// <param name="dataCenterName"> Data center name in a managed Cassandra cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCenterName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataCenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCenterName, nameof(dataCenterName));

            using var scope = _dataCenterResourceCassandraDataCentersClientDiagnostics.CreateScope("DataCenterResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataCenterResourceCassandraDataCentersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataCenterResource> IEnumerable<DataCenterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataCenterResource> IAsyncEnumerable<DataCenterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
