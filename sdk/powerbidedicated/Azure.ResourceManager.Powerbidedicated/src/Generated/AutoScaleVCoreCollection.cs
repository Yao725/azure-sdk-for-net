// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Powerbidedicated.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Powerbidedicated
{
    /// <summary> A class representing collection of AutoScaleVCore and their operations over a ResourceGroup. </summary>
    public partial class AutoScaleVCoreCollection : ArmCollection, IEnumerable<AutoScaleVCore>, IAsyncEnumerable<AutoScaleVCore>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AutoScaleVCoresRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="AutoScaleVCoreCollection"/> class for mocking. </summary>
        protected AutoScaleVCoreCollection()
        {
        }

        /// <summary> Initializes a new instance of AutoScaleVCoreCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AutoScaleVCoreCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new AutoScaleVCoresRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        IEnumerator<AutoScaleVCore> IEnumerable<AutoScaleVCore>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutoScaleVCore> IAsyncEnumerable<AutoScaleVCore>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <summary> Provisions the specified auto scale v-core based on the configuration specified in the request. </summary>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="vCoreParameters"> Contains the information used to provision the auto scale v-core. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vcoreName"/> or <paramref name="vCoreParameters"/> is null. </exception>
        public virtual AutoScaleVCoreCreateOperation CreateOrUpdate(string vcoreName, AutoScaleVCoreData vCoreParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (vcoreName == null)
            {
                throw new ArgumentNullException(nameof(vcoreName));
            }
            if (vCoreParameters == null)
            {
                throw new ArgumentNullException(nameof(vCoreParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AutoScaleVCoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Create(Id.ResourceGroupName, vcoreName, vCoreParameters, cancellationToken);
                var operation = new AutoScaleVCoreCreateOperation(Parent, response);
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

        /// <summary> Provisions the specified auto scale v-core based on the configuration specified in the request. </summary>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="vCoreParameters"> Contains the information used to provision the auto scale v-core. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vcoreName"/> or <paramref name="vCoreParameters"/> is null. </exception>
        public async virtual Task<AutoScaleVCoreCreateOperation> CreateOrUpdateAsync(string vcoreName, AutoScaleVCoreData vCoreParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (vcoreName == null)
            {
                throw new ArgumentNullException(nameof(vcoreName));
            }
            if (vCoreParameters == null)
            {
                throw new ArgumentNullException(nameof(vCoreParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AutoScaleVCoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateAsync(Id.ResourceGroupName, vcoreName, vCoreParameters, cancellationToken).ConfigureAwait(false);
                var operation = new AutoScaleVCoreCreateOperation(Parent, response);
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
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<AutoScaleVCore> Get(string vcoreName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoScaleVCoreCollection.Get");
            scope.Start();
            try
            {
                if (vcoreName == null)
                {
                    throw new ArgumentNullException(nameof(vcoreName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, vcoreName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutoScaleVCore(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<AutoScaleVCore>> GetAsync(string vcoreName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoScaleVCoreCollection.Get");
            scope.Start();
            try
            {
                if (vcoreName == null)
                {
                    throw new ArgumentNullException(nameof(vcoreName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, vcoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AutoScaleVCore(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<AutoScaleVCore> GetIfExists(string vcoreName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoScaleVCoreCollection.GetIfExists");
            scope.Start();
            try
            {
                if (vcoreName == null)
                {
                    throw new ArgumentNullException(nameof(vcoreName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, vcoreName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<AutoScaleVCore>(null, response.GetRawResponse())
                    : Response.FromValue(new AutoScaleVCore(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<AutoScaleVCore>> GetIfExistsAsync(string vcoreName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoScaleVCoreCollection.GetIfExists");
            scope.Start();
            try
            {
                if (vcoreName == null)
                {
                    throw new ArgumentNullException(nameof(vcoreName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, vcoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<AutoScaleVCore>(null, response.GetRawResponse())
                    : Response.FromValue(new AutoScaleVCore(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string vcoreName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoScaleVCoreCollection.CheckIfExists");
            scope.Start();
            try
            {
                if (vcoreName == null)
                {
                    throw new ArgumentNullException(nameof(vcoreName));
                }

                var response = GetIfExists(vcoreName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string vcoreName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoScaleVCoreCollection.CheckIfExists");
            scope.Start();
            try
            {
                if (vcoreName == null)
                {
                    throw new ArgumentNullException(nameof(vcoreName));
                }

                var response = await GetIfExistsAsync(vcoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the auto scale v-cores for the given resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutoScaleVCore" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutoScaleVCore> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AutoScaleVCore> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AutoScaleVCoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AutoScaleVCore(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Gets all the auto scale v-cores for the given resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutoScaleVCore" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutoScaleVCore> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AutoScaleVCore>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AutoScaleVCoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AutoScaleVCore(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="AutoScaleVCore" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoScaleVCoreCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AutoScaleVCore.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="AutoScaleVCore" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoScaleVCoreCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AutoScaleVCore.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, AutoScaleVCore, AutoScaleVCoreData> Construct() { }
    }
}
