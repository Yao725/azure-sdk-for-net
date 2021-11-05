// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Extendedlocation.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Extendedlocation
{
    /// <summary> A Class representing a CustomLocation along with the instance operations that can be performed on it. </summary>
    public partial class CustomLocation : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CustomLocationsRestOperations _restClient;
        private readonly CustomLocationData _data;

        /// <summary> Initializes a new instance of the <see cref="CustomLocation"/> class for mocking. </summary>
        protected CustomLocation()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CustomLocation"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal CustomLocation(ArmResource options, CustomLocationData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new CustomLocationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="CustomLocation"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CustomLocation(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new CustomLocationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="CustomLocation"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CustomLocation(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new CustomLocationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ExtendedLocation/customLocations";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CustomLocationData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets the details of the customLocation with a specified resource group and name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<CustomLocation>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomLocation.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CustomLocation(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the details of the customLocation with a specified resource group and name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CustomLocation> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomLocation.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomLocation(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes the Custom Location with the specified Resource Name, Resource Group, and Subscription Id. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<CustomLocationDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomLocation.Delete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CustomLocationDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the Custom Location with the specified Resource Name, Resource Group, and Subscription Id. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual CustomLocationDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomLocation.Delete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new CustomLocationDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public async virtual Task<Response<CustomLocation>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomLocation.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CustomLocation(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public virtual Response<CustomLocation> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomLocation.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new CustomLocation(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public async virtual Task<Response<CustomLocation>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomLocation.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CustomLocation(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public virtual Response<CustomLocation> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomLocation.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new CustomLocation(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public async virtual Task<Response<CustomLocation>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomLocation.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CustomLocation(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public virtual Response<CustomLocation> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomLocation.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new CustomLocation(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Updates a Custom Location with the specified Resource Name in the specified Resource Group and Subscription. </summary>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="authentication"> This is optional input that contains the authentication that should be used to generate the namespace. </param>
        /// <param name="clusterExtensionIds"> Contains the reference to the add-on that contains charts to deploy CRDs and operators. </param>
        /// <param name="displayName"> Display name for the Custom Locations location. </param>
        /// <param name="hostResourceId"> Connected Cluster or AKS Cluster. The Custom Locations RP will perform a checkAccess API for listAdminCredentials permissions. </param>
        /// <param name="hostType"> Type of host the Custom Locations is referencing (Kubernetes, etc...). </param>
        /// <param name="namespace"> Kubernetes namespace that will be created on the specified cluster. </param>
        /// <param name="provisioningState"> Provisioning State for the Custom Location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CustomLocation>> UpdateAsync(Identity identity = null, IDictionary<string, string> tags = null, CustomLocationPropertiesAuthentication authentication = null, IEnumerable<string> clusterExtensionIds = null, string displayName = null, string hostResourceId = null, HostType? hostType = null, string @namespace = null, string provisioningState = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomLocation.Update");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateAsync(Id.ResourceGroupName, Id.Name, identity, tags, authentication, clusterExtensionIds, displayName, hostResourceId, hostType, namespace, provisioningState, cancellationToken).ConfigureAwait(false);
return Response.FromValue(new CustomLocation(this, response.Value), response.GetRawResponse());
    }
catch (Exception e)
{
scope.Failed(e);
throw;
}
}

/// <summary> Updates a Custom Location with the specified Resource Name in the specified Resource Group and Subscription. </summary>
/// <param name="identity"> Identity for the resource. </param>
/// <param name="tags"> Resource tags. </param>
/// <param name="authentication"> This is optional input that contains the authentication that should be used to generate the namespace. </param>
/// <param name="clusterExtensionIds"> Contains the reference to the add-on that contains charts to deploy CRDs and operators. </param>
/// <param name="displayName"> Display name for the Custom Locations location. </param>
/// <param name="hostResourceId"> Connected Cluster or AKS Cluster. The Custom Locations RP will perform a checkAccess API for listAdminCredentials permissions. </param>
/// <param name="hostType"> Type of host the Custom Locations is referencing (Kubernetes, etc...). </param>
/// <param name="namespace"> Kubernetes namespace that will be created on the specified cluster. </param>
/// <param name="provisioningState"> Provisioning State for the Custom Location. </param>
/// <param name="cancellationToken"> The cancellation token to use. </param>
public virtual Response<Azure.ResourceManager.Extendedlocation.CustomLocation> Update(Identity identity = null, IDictionary<string, string> tags = null, CustomLocationPropertiesAuthentication authentication = null, IEnumerable<string> clusterExtensionIds = null, string displayName = null, string hostResourceId = null, HostType? hostType = null, string @namespace = null, string provisioningState = null, CancellationToken cancellationToken = default)
{
    using var scope = _clientDiagnostics.CreateScope("CustomLocation.Update");
    scope.Start();
    try
    {
        var response = _restClient.Update(Id.ResourceGroupName, Id.Name, identity, tags, authentication, clusterExtensionIds, displayName, hostResourceId, hostType, namespace, provisioningState, cancellationToken);
return Response.FromValue(new Azure.ResourceManager.Extendedlocation.CustomLocation(this, response.Value), response.GetRawResponse());
}
catch (Exception e)
{
scope.Failed(e);
throw;
}
}

/// <summary> Lists all available Custom Locations operations. </summary>
/// <param name="cancellationToken"> The cancellation token to use. </param>
/// <returns> A collection of <see cref="CustomLocationOperation" /> that may take multiple service requests to iterate over. </returns>
public virtual Pageable<CustomLocationOperation> GetOperations(CancellationToken cancellationToken = default)
{
    Page<CustomLocationOperation> FirstPageFunc(int? pageSizeHint)
    {
        using var scope = _clientDiagnostics.CreateScope("CustomLocation.GetOperations");
        scope.Start();
        try
        {
            var response = _restClient.GetOperations(cancellationToken: cancellationToken);
            return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
        }
        catch (Exception e)
        {
            scope.Failed(e);
            throw;
        }
    }
    Page<CustomLocationOperation> NextPageFunc(string nextLink, int? pageSizeHint)
    {
        using var scope = _clientDiagnostics.CreateScope("CustomLocation.GetOperations");
        scope.Start();
        try
        {
            var response = _restClient.GetOperationsNextPage(nextLink, cancellationToken: cancellationToken);
            return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
        }
        catch (Exception e)
        {
            scope.Failed(e);
            throw;
        }
    }
    return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
}

/// <summary> Lists all available Custom Locations operations. </summary>
/// <param name="cancellationToken"> The cancellation token to use. </param>
/// <returns> An async collection of <see cref="CustomLocationOperation" /> that may take multiple service requests to iterate over. </returns>
public virtual AsyncPageable<CustomLocationOperation> GetOperationsAsync(CancellationToken cancellationToken = default)
{
    async Task<Page<CustomLocationOperation>> FirstPageFunc(int? pageSizeHint)
    {
        using var scope = _clientDiagnostics.CreateScope("CustomLocation.GetOperations");
        scope.Start();
        try
        {
            var response = await _restClient.GetOperationsAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
        }
        catch (Exception e)
        {
            scope.Failed(e);
            throw;
        }
    }
    async Task<Page<CustomLocationOperation>> NextPageFunc(string nextLink, int? pageSizeHint)
    {
        using var scope = _clientDiagnostics.CreateScope("CustomLocation.GetOperations");
        scope.Start();
        try
        {
            var response = await _restClient.GetOperationsNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
            return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
        }
        catch (Exception e)
        {
            scope.Failed(e);
            throw;
        }
    }
    return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
}

/// <summary> Gets the list of the Enabled Resource Types. </summary>
/// <param name="cancellationToken"> The cancellation token to use. </param>
/// <returns> A collection of <see cref="EnabledResourceType" /> that may take multiple service requests to iterate over. </returns>
public virtual Pageable<EnabledResourceType> GetEnabledResourceTypes(CancellationToken cancellationToken = default)
{
    Page<EnabledResourceType> FirstPageFunc(int? pageSizeHint)
    {
        using var scope = _clientDiagnostics.CreateScope("CustomLocation.GetEnabledResourceTypes");
        scope.Start();
        try
        {
            var response = _restClient.GetEnabledResourceTypes(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
            return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
        }
        catch (Exception e)
        {
            scope.Failed(e);
            throw;
        }
    }
    Page<EnabledResourceType> NextPageFunc(string nextLink, int? pageSizeHint)
    {
        using var scope = _clientDiagnostics.CreateScope("CustomLocation.GetEnabledResourceTypes");
        scope.Start();
        try
        {
            var response = _restClient.GetEnabledResourceTypesNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
            return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
        }
        catch (Exception e)
        {
            scope.Failed(e);
            throw;
        }
    }
    return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
}

/// <summary> Gets the list of the Enabled Resource Types. </summary>
/// <param name="cancellationToken"> The cancellation token to use. </param>
/// <returns> An async collection of <see cref="EnabledResourceType" /> that may take multiple service requests to iterate over. </returns>
public virtual AsyncPageable<EnabledResourceType> GetEnabledResourceTypesAsync(CancellationToken cancellationToken = default)
{
    async Task<Page<EnabledResourceType>> FirstPageFunc(int? pageSizeHint)
    {
        using var scope = _clientDiagnostics.CreateScope("CustomLocation.GetEnabledResourceTypes");
        scope.Start();
        try
        {
            var response = await _restClient.GetEnabledResourceTypesAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
            return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
        }
        catch (Exception e)
        {
            scope.Failed(e);
            throw;
        }
    }
    async Task<Page<EnabledResourceType>> NextPageFunc(string nextLink, int? pageSizeHint)
    {
        using var scope = _clientDiagnostics.CreateScope("CustomLocation.GetEnabledResourceTypes");
        scope.Start();
        try
        {
            var response = await _restClient.GetEnabledResourceTypesNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
            return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
        }
        catch (Exception e)
        {
            scope.Failed(e);
            throw;
        }
    }
    return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
}
}
}
