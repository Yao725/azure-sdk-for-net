// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Marketplace.Models;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary> A class representing collection of Collection and their operations over a PrivateStore. </summary>
    public partial class CollectionContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PrivateStoreCollectionRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="CollectionContainer"/> class for mocking. </summary>
        protected CollectionContainer()
        {
        }

        /// <summary> Initializes a new instance of CollectionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CollectionContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new PrivateStoreCollectionRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => PrivateStore.ResourceType;

        // Container level operations.

        /// <summary> Create or update private store collection. </summary>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="payload"> The Collection to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collectionId"/> is null. </exception>
        public virtual PrivateStoreCollectionCreateOrUpdateOperation CreateOrUpdate(string collectionId, CollectionData payload = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (collectionId == null)
            {
                throw new ArgumentNullException(nameof(collectionId));
            }

            using var scope = _clientDiagnostics.CreateScope("CollectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.Name, collectionId, payload, cancellationToken);
                var operation = new PrivateStoreCollectionCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Create or update private store collection. </summary>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="payload"> The Collection to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collectionId"/> is null. </exception>
        public async virtual Task<PrivateStoreCollectionCreateOrUpdateOperation> CreateOrUpdateAsync(string collectionId, CollectionData payload = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (collectionId == null)
            {
                throw new ArgumentNullException(nameof(collectionId));
            }

            using var scope = _clientDiagnostics.CreateScope("CollectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.Name, collectionId, payload, cancellationToken).ConfigureAwait(false);
                var operation = new PrivateStoreCollectionCreateOrUpdateOperation(Parent, response);
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
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<Collection> Get(string collectionId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CollectionContainer.Get");
            scope.Start();
            try
            {
                if (collectionId == null)
                {
                    throw new ArgumentNullException(nameof(collectionId));
                }

                var response = _restClient.Get(Id.Name, collectionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Collection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<Collection>> GetAsync(string collectionId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CollectionContainer.Get");
            scope.Start();
            try
            {
                if (collectionId == null)
                {
                    throw new ArgumentNullException(nameof(collectionId));
                }

                var response = await _restClient.GetAsync(Id.Name, collectionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Collection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<Collection> GetIfExists(string collectionId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CollectionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (collectionId == null)
                {
                    throw new ArgumentNullException(nameof(collectionId));
                }

                var response = _restClient.Get(Id.Name, collectionId, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Collection>(null, response.GetRawResponse())
                    : Response.FromValue(new Collection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<Collection>> GetIfExistsAsync(string collectionId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CollectionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (collectionId == null)
                {
                    throw new ArgumentNullException(nameof(collectionId));
                }

                var response = await _restClient.GetAsync(Id.Name, collectionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Collection>(null, response.GetRawResponse())
                    : Response.FromValue(new Collection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string collectionId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CollectionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (collectionId == null)
                {
                    throw new ArgumentNullException(nameof(collectionId));
                }

                var response = GetIfExists(collectionId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string collectionId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CollectionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (collectionId == null)
                {
                    throw new ArgumentNullException(nameof(collectionId));
                }

                var response = await GetIfExistsAsync(collectionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets private store collections list. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<Collection>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CollectionContainer.GetAll");
            scope.Start();
            try
            {
                var response = await _restClient.GetAllAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(data => new Collection(Parent, data)).ToArray() as IReadOnlyList<Collection>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets private store collections list. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<Collection>> GetAll(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CollectionContainer.GetAll");
            scope.Start();
            try
            {
                var response = _restClient.GetAll(Id.Name, cancellationToken);
                return Response.FromValue(response.Value.Value.Select(data => new Collection(Parent, data)).ToArray() as IReadOnlyList<Collection>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, Collection, CollectionData> Construct() { }
    }
}
