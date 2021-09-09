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
using Azure.ResourceManager.Azurestackhci.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Azurestackhci
{
    internal partial class ExtensionsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of ExtensionsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public ExtensionsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-01-01-preview")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetAllByArcSettingRequest(string resourceGroupName, string clusterName, string arcSettingName)
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
            uri.AppendPath("/providers/Microsoft.AzureStackHCI/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/arcSettings/", false);
            uri.AppendPath(arcSettingName, true);
            uri.AppendPath("/extensions", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> List all Extensions under ArcSetting resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, or <paramref name="arcSettingName"/> is null. </exception>
        public async Task<Response<ExtensionList>> GetAllByArcSettingAsync(string resourceGroupName, string clusterName, string arcSettingName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (arcSettingName == null)
            {
                throw new ArgumentNullException(nameof(arcSettingName));
            }

            using var message = CreateGetAllByArcSettingRequest(resourceGroupName, clusterName, arcSettingName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtensionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExtensionList.DeserializeExtensionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List all Extensions under ArcSetting resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, or <paramref name="arcSettingName"/> is null. </exception>
        public Response<ExtensionList> GetAllByArcSetting(string resourceGroupName, string clusterName, string arcSettingName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (arcSettingName == null)
            {
                throw new ArgumentNullException(nameof(arcSettingName));
            }

            using var message = CreateGetAllByArcSettingRequest(resourceGroupName, clusterName, arcSettingName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtensionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExtensionList.DeserializeExtensionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string clusterName, string arcSettingName, string extensionName)
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
            uri.AppendPath("/providers/Microsoft.AzureStackHCI/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/arcSettings/", false);
            uri.AppendPath(arcSettingName, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(extensionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Get particular Arc Extension of HCI Cluster. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="arcSettingName"/>, or <paramref name="extensionName"/> is null. </exception>
        public async Task<Response<ExtensionData>> GetAsync(string resourceGroupName, string clusterName, string arcSettingName, string extensionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (arcSettingName == null)
            {
                throw new ArgumentNullException(nameof(arcSettingName));
            }
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }

            using var message = CreateGetRequest(resourceGroupName, clusterName, arcSettingName, extensionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtensionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExtensionData.DeserializeExtensionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ExtensionData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get particular Arc Extension of HCI Cluster. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="arcSettingName"/>, or <paramref name="extensionName"/> is null. </exception>
        public Response<ExtensionData> Get(string resourceGroupName, string clusterName, string arcSettingName, string extensionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (arcSettingName == null)
            {
                throw new ArgumentNullException(nameof(arcSettingName));
            }
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }

            using var message = CreateGetRequest(resourceGroupName, clusterName, arcSettingName, extensionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtensionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExtensionData.DeserializeExtensionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ExtensionData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string resourceGroupName, string clusterName, string arcSettingName, string extensionName, ExtensionData extension)
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
            uri.AppendPath("/providers/Microsoft.AzureStackHCI/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/arcSettings/", false);
            uri.AppendPath(arcSettingName, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(extensionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(extension);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Create Extension for HCI cluster. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="extension"> Details of the Machine Extension to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="arcSettingName"/>, <paramref name="extensionName"/>, or <paramref name="extension"/> is null. </exception>
        public async Task<Response> CreateAsync(string resourceGroupName, string clusterName, string arcSettingName, string extensionName, ExtensionData extension, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (arcSettingName == null)
            {
                throw new ArgumentNullException(nameof(arcSettingName));
            }
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }
            if (extension == null)
            {
                throw new ArgumentNullException(nameof(extension));
            }

            using var message = CreateCreateRequest(resourceGroupName, clusterName, arcSettingName, extensionName, extension);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create Extension for HCI cluster. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="extension"> Details of the Machine Extension to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="arcSettingName"/>, <paramref name="extensionName"/>, or <paramref name="extension"/> is null. </exception>
        public Response Create(string resourceGroupName, string clusterName, string arcSettingName, string extensionName, ExtensionData extension, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (arcSettingName == null)
            {
                throw new ArgumentNullException(nameof(arcSettingName));
            }
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }
            if (extension == null)
            {
                throw new ArgumentNullException(nameof(extension));
            }

            using var message = CreateCreateRequest(resourceGroupName, clusterName, arcSettingName, extensionName, extension);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string resourceGroupName, string clusterName, string arcSettingName, string extensionName, ExtensionData extension)
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
            uri.AppendPath("/providers/Microsoft.AzureStackHCI/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/arcSettings/", false);
            uri.AppendPath(arcSettingName, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(extensionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(extension);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Update Extension for HCI cluster. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="extension"> Details of the Machine Extension to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="arcSettingName"/>, <paramref name="extensionName"/>, or <paramref name="extension"/> is null. </exception>
        public async Task<Response> UpdateAsync(string resourceGroupName, string clusterName, string arcSettingName, string extensionName, ExtensionData extension, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (arcSettingName == null)
            {
                throw new ArgumentNullException(nameof(arcSettingName));
            }
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }
            if (extension == null)
            {
                throw new ArgumentNullException(nameof(extension));
            }

            using var message = CreateUpdateRequest(resourceGroupName, clusterName, arcSettingName, extensionName, extension);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Update Extension for HCI cluster. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="extension"> Details of the Machine Extension to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="arcSettingName"/>, <paramref name="extensionName"/>, or <paramref name="extension"/> is null. </exception>
        public Response Update(string resourceGroupName, string clusterName, string arcSettingName, string extensionName, ExtensionData extension, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (arcSettingName == null)
            {
                throw new ArgumentNullException(nameof(arcSettingName));
            }
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }
            if (extension == null)
            {
                throw new ArgumentNullException(nameof(extension));
            }

            using var message = CreateUpdateRequest(resourceGroupName, clusterName, arcSettingName, extensionName, extension);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string clusterName, string arcSettingName, string extensionName)
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
            uri.AppendPath("/providers/Microsoft.AzureStackHCI/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/arcSettings/", false);
            uri.AppendPath(arcSettingName, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(extensionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Delete particular Arc Extension of HCI Cluster. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="arcSettingName"/>, or <paramref name="extensionName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string clusterName, string arcSettingName, string extensionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (arcSettingName == null)
            {
                throw new ArgumentNullException(nameof(arcSettingName));
            }
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, clusterName, arcSettingName, extensionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete particular Arc Extension of HCI Cluster. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="arcSettingName"/>, or <paramref name="extensionName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string clusterName, string arcSettingName, string extensionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (arcSettingName == null)
            {
                throw new ArgumentNullException(nameof(arcSettingName));
            }
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, clusterName, arcSettingName, extensionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllByArcSettingNextPageRequest(string nextLink, string resourceGroupName, string clusterName, string arcSettingName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> List all Extensions under ArcSetting resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, or <paramref name="arcSettingName"/> is null. </exception>
        public async Task<Response<ExtensionList>> GetAllByArcSettingNextPageAsync(string nextLink, string resourceGroupName, string clusterName, string arcSettingName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (arcSettingName == null)
            {
                throw new ArgumentNullException(nameof(arcSettingName));
            }

            using var message = CreateGetAllByArcSettingNextPageRequest(nextLink, resourceGroupName, clusterName, arcSettingName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtensionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExtensionList.DeserializeExtensionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List all Extensions under ArcSetting resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, or <paramref name="arcSettingName"/> is null. </exception>
        public Response<ExtensionList> GetAllByArcSettingNextPage(string nextLink, string resourceGroupName, string clusterName, string arcSettingName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (arcSettingName == null)
            {
                throw new ArgumentNullException(nameof(arcSettingName));
            }

            using var message = CreateGetAllByArcSettingNextPageRequest(nextLink, resourceGroupName, clusterName, arcSettingName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtensionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExtensionList.DeserializeExtensionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
