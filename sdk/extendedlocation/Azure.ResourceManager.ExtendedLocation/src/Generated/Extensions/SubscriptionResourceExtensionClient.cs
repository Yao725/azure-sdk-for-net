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

namespace Azure.ResourceManager.ExtendedLocation
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _customLocationClientDiagnostics;
        private CustomLocationsRestOperations _customLocationRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics CustomLocationClientDiagnostics => _customLocationClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ExtendedLocation", CustomLocationResource.ResourceType.Namespace, Diagnostics);
        private CustomLocationsRestOperations CustomLocationRestClient => _customLocationRestClient ??= new CustomLocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(CustomLocationResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets a list of Custom Locations in the specified subscription. The operation returns properties of each Custom Location
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ExtendedLocation/customLocations
        /// Operation Id: CustomLocations_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CustomLocationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CustomLocationResource> GetCustomLocationsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CustomLocationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = CustomLocationClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCustomLocations");
                scope.Start();
                try
                {
                    var response = await CustomLocationRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomLocationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CustomLocationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = CustomLocationClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCustomLocations");
                scope.Start();
                try
                {
                    var response = await CustomLocationRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomLocationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of Custom Locations in the specified subscription. The operation returns properties of each Custom Location
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ExtendedLocation/customLocations
        /// Operation Id: CustomLocations_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CustomLocationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CustomLocationResource> GetCustomLocations(CancellationToken cancellationToken = default)
        {
            Page<CustomLocationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = CustomLocationClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCustomLocations");
                scope.Start();
                try
                {
                    var response = CustomLocationRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomLocationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CustomLocationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = CustomLocationClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCustomLocations");
                scope.Start();
                try
                {
                    var response = CustomLocationRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomLocationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
