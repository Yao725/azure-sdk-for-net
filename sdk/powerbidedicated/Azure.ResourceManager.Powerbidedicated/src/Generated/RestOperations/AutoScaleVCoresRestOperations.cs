// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Powerbidedicated.Models;

namespace Azure.ResourceManager.Powerbidedicated
{
    internal partial class AutoScaleVCoresRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of AutoScaleVCoresRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> A unique identifier for a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public AutoScaleVCoresRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-01-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string vcoreName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.PowerBIDedicated/autoScaleVCores/", false);
            uri.AppendPath(vcoreName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets details about the specified auto scale v-core. </summary>
        /// <param name="resourceGroupName"> The name of the Azure Resource group of which a given PowerBIDedicated capacity is part. This name must be at least 1 character in length, and no more than 90. </param>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vcoreName"/> is null. </exception>
        public async Task<Response<AutoScaleVCoreData>> GetAsync(string resourceGroupName, string vcoreName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcoreName == null)
            {
                throw new ArgumentNullException(nameof(vcoreName));
            }

            using var message = CreateGetRequest(resourceGroupName, vcoreName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutoScaleVCoreData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutoScaleVCoreData.DeserializeAutoScaleVCoreData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AutoScaleVCoreData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets details about the specified auto scale v-core. </summary>
        /// <param name="resourceGroupName"> The name of the Azure Resource group of which a given PowerBIDedicated capacity is part. This name must be at least 1 character in length, and no more than 90. </param>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vcoreName"/> is null. </exception>
        public Response<AutoScaleVCoreData> Get(string resourceGroupName, string vcoreName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcoreName == null)
            {
                throw new ArgumentNullException(nameof(vcoreName));
            }

            using var message = CreateGetRequest(resourceGroupName, vcoreName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutoScaleVCoreData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutoScaleVCoreData.DeserializeAutoScaleVCoreData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AutoScaleVCoreData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string resourceGroupName, string vcoreName, AutoScaleVCoreData vCoreParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.PowerBIDedicated/autoScaleVCores/", false);
            uri.AppendPath(vcoreName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(vCoreParameters);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Provisions the specified auto scale v-core based on the configuration specified in the request. </summary>
        /// <param name="resourceGroupName"> The name of the Azure Resource group of which a given PowerBIDedicated capacity is part. This name must be at least 1 character in length, and no more than 90. </param>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="vCoreParameters"> Contains the information used to provision the auto scale v-core. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vcoreName"/>, or <paramref name="vCoreParameters"/> is null. </exception>
        public async Task<Response<AutoScaleVCoreData>> CreateAsync(string resourceGroupName, string vcoreName, AutoScaleVCoreData vCoreParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcoreName == null)
            {
                throw new ArgumentNullException(nameof(vcoreName));
            }
            if (vCoreParameters == null)
            {
                throw new ArgumentNullException(nameof(vCoreParameters));
            }

            using var message = CreateCreateRequest(resourceGroupName, vcoreName, vCoreParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutoScaleVCoreData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutoScaleVCoreData.DeserializeAutoScaleVCoreData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Provisions the specified auto scale v-core based on the configuration specified in the request. </summary>
        /// <param name="resourceGroupName"> The name of the Azure Resource group of which a given PowerBIDedicated capacity is part. This name must be at least 1 character in length, and no more than 90. </param>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="vCoreParameters"> Contains the information used to provision the auto scale v-core. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vcoreName"/>, or <paramref name="vCoreParameters"/> is null. </exception>
        public Response<AutoScaleVCoreData> Create(string resourceGroupName, string vcoreName, AutoScaleVCoreData vCoreParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcoreName == null)
            {
                throw new ArgumentNullException(nameof(vcoreName));
            }
            if (vCoreParameters == null)
            {
                throw new ArgumentNullException(nameof(vCoreParameters));
            }

            using var message = CreateCreateRequest(resourceGroupName, vcoreName, vCoreParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutoScaleVCoreData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutoScaleVCoreData.DeserializeAutoScaleVCoreData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string vcoreName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.PowerBIDedicated/autoScaleVCores/", false);
            uri.AppendPath(vcoreName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Deletes the specified auto scale v-core. </summary>
        /// <param name="resourceGroupName"> The name of the Azure Resource group of which a given PowerBIDedicated capacity is part. This name must be at least 1 character in length, and no more than 90. </param>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vcoreName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string vcoreName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcoreName == null)
            {
                throw new ArgumentNullException(nameof(vcoreName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, vcoreName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the specified auto scale v-core. </summary>
        /// <param name="resourceGroupName"> The name of the Azure Resource group of which a given PowerBIDedicated capacity is part. This name must be at least 1 character in length, and no more than 90. </param>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vcoreName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string vcoreName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcoreName == null)
            {
                throw new ArgumentNullException(nameof(vcoreName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, vcoreName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string resourceGroupName, string vcoreName, AutoScaleVCoreUpdateParameters vCoreUpdateParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.PowerBIDedicated/autoScaleVCores/", false);
            uri.AppendPath(vcoreName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(vCoreUpdateParameters);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Updates the current state of the specified auto scale v-core. </summary>
        /// <param name="resourceGroupName"> The name of the Azure Resource group of which a given PowerBIDedicated capacity is part. This name must be at least 1 character in length, and no more than 90. </param>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="vCoreUpdateParameters"> Request object that contains the updated information for the auto scale v-core. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vcoreName"/>, or <paramref name="vCoreUpdateParameters"/> is null. </exception>
        public async Task<Response<AutoScaleVCoreData>> UpdateAsync(string resourceGroupName, string vcoreName, AutoScaleVCoreUpdateParameters vCoreUpdateParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcoreName == null)
            {
                throw new ArgumentNullException(nameof(vcoreName));
            }
            if (vCoreUpdateParameters == null)
            {
                throw new ArgumentNullException(nameof(vCoreUpdateParameters));
            }

            using var message = CreateUpdateRequest(resourceGroupName, vcoreName, vCoreUpdateParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutoScaleVCoreData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutoScaleVCoreData.DeserializeAutoScaleVCoreData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates the current state of the specified auto scale v-core. </summary>
        /// <param name="resourceGroupName"> The name of the Azure Resource group of which a given PowerBIDedicated capacity is part. This name must be at least 1 character in length, and no more than 90. </param>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="vCoreUpdateParameters"> Request object that contains the updated information for the auto scale v-core. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vcoreName"/>, or <paramref name="vCoreUpdateParameters"/> is null. </exception>
        public Response<AutoScaleVCoreData> Update(string resourceGroupName, string vcoreName, AutoScaleVCoreUpdateParameters vCoreUpdateParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vcoreName == null)
            {
                throw new ArgumentNullException(nameof(vcoreName));
            }
            if (vCoreUpdateParameters == null)
            {
                throw new ArgumentNullException(nameof(vCoreUpdateParameters));
            }

            using var message = CreateUpdateRequest(resourceGroupName, vcoreName, vCoreUpdateParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutoScaleVCoreData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutoScaleVCoreData.DeserializeAutoScaleVCoreData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllByResourceGroupRequest(string resourceGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.PowerBIDedicated/autoScaleVCores", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets all the auto scale v-cores for the given resource group. </summary>
        /// <param name="resourceGroupName"> The name of the Azure Resource group of which a given PowerBIDedicated capacity is part. This name must be at least 1 character in length, and no more than 90. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<AutoScaleVCoreListResult>> GetAllByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateGetAllByResourceGroupRequest(resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutoScaleVCoreListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutoScaleVCoreListResult.DeserializeAutoScaleVCoreListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the auto scale v-cores for the given resource group. </summary>
        /// <param name="resourceGroupName"> The name of the Azure Resource group of which a given PowerBIDedicated capacity is part. This name must be at least 1 character in length, and no more than 90. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public Response<AutoScaleVCoreListResult> GetAllByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateGetAllByResourceGroupRequest(resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutoScaleVCoreListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutoScaleVCoreListResult.DeserializeAutoScaleVCoreListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllBySubscriptionRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.PowerBIDedicated/autoScaleVCores", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists all the auto scale v-cores for the given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<AutoScaleVCoreListResult>> GetAllBySubscriptionAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetAllBySubscriptionRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutoScaleVCoreListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutoScaleVCoreListResult.DeserializeAutoScaleVCoreListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all the auto scale v-cores for the given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<AutoScaleVCoreListResult> GetAllBySubscription(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetAllBySubscriptionRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutoScaleVCoreListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutoScaleVCoreListResult.DeserializeAutoScaleVCoreListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
