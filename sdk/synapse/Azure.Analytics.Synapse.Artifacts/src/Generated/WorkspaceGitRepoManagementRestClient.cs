// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    internal partial class WorkspaceGitRepoManagementRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of WorkspaceGitRepoManagementRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        public WorkspaceGitRepoManagementRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
        }

        internal HttpMessage CreateGetGitHubAccessTokenRequest(GitHubAccessTokenRequest gitHubAccessTokenRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/getGitHubAccessToken", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(gitHubAccessTokenRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Get the GitHub access token. </summary>
        /// <param name="gitHubAccessTokenRequest"> The GitHubAccessTokenRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubAccessTokenRequest"/> is null. </exception>
        public async Task<Response<GitHubAccessTokenResponse>> GetGitHubAccessTokenAsync(GitHubAccessTokenRequest gitHubAccessTokenRequest, CancellationToken cancellationToken = default)
        {
            if (gitHubAccessTokenRequest == null)
            {
                throw new ArgumentNullException(nameof(gitHubAccessTokenRequest));
            }

            using var message = CreateGetGitHubAccessTokenRequest(gitHubAccessTokenRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GitHubAccessTokenResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GitHubAccessTokenResponse.DeserializeGitHubAccessTokenResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get the GitHub access token. </summary>
        /// <param name="gitHubAccessTokenRequest"> The GitHubAccessTokenRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubAccessTokenRequest"/> is null. </exception>
        public Response<GitHubAccessTokenResponse> GetGitHubAccessToken(GitHubAccessTokenRequest gitHubAccessTokenRequest, CancellationToken cancellationToken = default)
        {
            if (gitHubAccessTokenRequest == null)
            {
                throw new ArgumentNullException(nameof(gitHubAccessTokenRequest));
            }

            using var message = CreateGetGitHubAccessTokenRequest(gitHubAccessTokenRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GitHubAccessTokenResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GitHubAccessTokenResponse.DeserializeGitHubAccessTokenResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
