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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Scheduler
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        #region JobCollectionDefinition
        private static JobCollectionsRestOperations GetJobCollectionsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new JobCollectionsRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        /// <summary> Lists the JobCollectionDefinitions for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<JobCollectionDefinition> GetJobCollectionDefinitionsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetJobCollectionsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                async Task<Page<JobCollectionDefinition>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetJobCollectionDefinitions");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.GetAllBySubscriptionAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new JobCollectionDefinition(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<JobCollectionDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetJobCollectionDefinitions");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.GetAllBySubscriptionNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new JobCollectionDefinition(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the JobCollectionDefinitions for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<JobCollectionDefinition> GetJobCollectionDefinitions(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetJobCollectionsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                Page<JobCollectionDefinition> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetJobCollectionDefinitions");
                    scope.Start();
                    try
                    {
                        var response = restOperations.GetAllBySubscription(cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new JobCollectionDefinition(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<JobCollectionDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetJobCollectionDefinitions");
                    scope.Start();
                    try
                    {
                        var response = restOperations.GetAllBySubscriptionNextPage(nextLink, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new JobCollectionDefinition(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Filters the list of JobCollectionDefinitions for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetJobCollectionDefinitionByNameAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(JobCollectionDefinition.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContextAsync(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of JobCollectionDefinitions for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetJobCollectionDefinitionByName(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(JobCollectionDefinition.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContext(subscription, filters, expand, top, cancellationToken);
        }
        #endregion
    }
}
