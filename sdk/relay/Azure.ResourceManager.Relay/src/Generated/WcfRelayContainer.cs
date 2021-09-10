// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Relay.Models;

namespace Azure.ResourceManager.Relay
{
    /// <summary> A class representing collection of WcfRelay and their operations over a RelayNamespace. </summary>
    public partial class WcfRelayContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WCFRelaysRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="WcfRelayContainer"/> class for mocking. </summary>
        protected WcfRelayContainer()
        {
        }

        /// <summary> Initializes a new instance of WcfRelayContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal WcfRelayContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new WCFRelaysRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => RelayNamespace.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a WCF relay. This operation is idempotent. </summary>
        /// <param name="relayName"> The relay name. </param>
        /// <param name="parameters"> Parameters supplied to create a WCF relay. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relayName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual WCFRelayCreateOrUpdateOperation CreateOrUpdate(string relayName, WcfRelayData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (relayName == null)
            {
                throw new ArgumentNullException(nameof(relayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WcfRelayContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, relayName, parameters, cancellationToken);
                var operation = new WCFRelayCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a WCF relay. This operation is idempotent. </summary>
        /// <param name="relayName"> The relay name. </param>
        /// <param name="parameters"> Parameters supplied to create a WCF relay. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relayName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<WCFRelayCreateOrUpdateOperation> CreateOrUpdateAsync(string relayName, WcfRelayData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (relayName == null)
            {
                throw new ArgumentNullException(nameof(relayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WcfRelayContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, relayName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new WCFRelayCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="relayName"> The relay name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<WcfRelay> Get(string relayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WcfRelayContainer.Get");
            scope.Start();
            try
            {
                if (relayName == null)
                {
                    throw new ArgumentNullException(nameof(relayName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, relayName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WcfRelay(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="relayName"> The relay name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<WcfRelay>> GetAsync(string relayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WcfRelayContainer.Get");
            scope.Start();
            try
            {
                if (relayName == null)
                {
                    throw new ArgumentNullException(nameof(relayName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, relayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new WcfRelay(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="relayName"> The relay name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<WcfRelay> GetIfExists(string relayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WcfRelayContainer.GetIfExists");
            scope.Start();
            try
            {
                if (relayName == null)
                {
                    throw new ArgumentNullException(nameof(relayName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, relayName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<WcfRelay>(null, response.GetRawResponse())
                    : Response.FromValue(new WcfRelay(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="relayName"> The relay name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<WcfRelay>> GetIfExistsAsync(string relayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WcfRelayContainer.GetIfExists");
            scope.Start();
            try
            {
                if (relayName == null)
                {
                    throw new ArgumentNullException(nameof(relayName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, relayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<WcfRelay>(null, response.GetRawResponse())
                    : Response.FromValue(new WcfRelay(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="relayName"> The relay name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string relayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WcfRelayContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (relayName == null)
                {
                    throw new ArgumentNullException(nameof(relayName));
                }

                var response = GetIfExists(relayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="relayName"> The relay name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string relayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WcfRelayContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (relayName == null)
                {
                    throw new ArgumentNullException(nameof(relayName));
                }

                var response = await GetIfExistsAsync(relayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the WCF relays within the namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WcfRelay" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WcfRelay> GetAll(CancellationToken cancellationToken = default)
        {
            Page<WcfRelay> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WcfRelayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByNamespace(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WcfRelay(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<WcfRelay> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WcfRelayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByNamespaceNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WcfRelay(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the WCF relays within the namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WcfRelay" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WcfRelay> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<WcfRelay>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WcfRelayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByNamespaceAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WcfRelay(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<WcfRelay>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WcfRelayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByNamespaceNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WcfRelay(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, WcfRelay, WcfRelayData> Construct() { }
    }
}
