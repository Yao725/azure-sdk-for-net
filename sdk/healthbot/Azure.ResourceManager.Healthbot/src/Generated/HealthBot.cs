// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Healthbot.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Healthbot
{
    /// <summary> A Class representing a HealthBot along with the instance operations that can be performed on it. </summary>
    public partial class HealthBot : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly BotsRestOperations _restClient;
        private readonly HealthBotData _data;

        /// <summary> Initializes a new instance of the <see cref="HealthBot"/> class for mocking. </summary>
        protected HealthBot()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "HealthBot"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal HealthBot(ArmResource options, HealthBotData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new BotsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="HealthBot"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HealthBot(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new BotsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HealthBot/healthBots";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HealthBotData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Get a HealthBot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<HealthBot>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HealthBot.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new HealthBot(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a HealthBot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HealthBot> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HealthBot.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HealthBot(this, response.Value), response.GetRawResponse());
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

        /// <summary> Delete a HealthBot. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<BotDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HealthBot.Delete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new BotDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Delete a HealthBot. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual BotDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("HealthBot.Delete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new BotDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
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
        public async virtual Task<Response<HealthBot>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("HealthBot.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagContainer.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new HealthBot(this, originalResponse.Value), originalResponse.GetRawResponse());
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
        public virtual Response<HealthBot> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("HealthBot.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagContainer.CreateOrUpdate(originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new HealthBot(this, originalResponse.Value), originalResponse.GetRawResponse());
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
        public async virtual Task<Response<HealthBot>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("HealthBot.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagContainer.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new HealthBot(this, originalResponse.Value), originalResponse.GetRawResponse());
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
        public virtual Response<HealthBot> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("HealthBot.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagContainer.CreateOrUpdate(originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new HealthBot(this, originalResponse.Value), originalResponse.GetRawResponse());
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
        public async virtual Task<Response<HealthBot>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("HealthBot.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagContainer.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new HealthBot(this, originalResponse.Value), originalResponse.GetRawResponse());
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
        public virtual Response<HealthBot> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("HealthBot.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagContainer.CreateOrUpdate(originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new HealthBot(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Patch a HealthBot. </summary>
        /// <param name="parameters"> The parameters to provide for the required Azure Health Bot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<Response<HealthBot>> UpdateAsync(HealthBotUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("HealthBot.Update");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateAsync(Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new HealthBot(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Patch a HealthBot. </summary>
        /// <param name="parameters"> The parameters to provide for the required Azure Health Bot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<HealthBot> Update(HealthBotUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("HealthBot.Update");
            scope.Start();
            try
            {
                var response = _restClient.Update(Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                return Response.FromValue(new HealthBot(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
