// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The Pipeline service client. </summary>
    public partial class PipelineClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PipelineRestClient RestClient { get; }

        /// <summary> Initializes a new instance of PipelineClient for mocking. </summary>
        protected PipelineClient()
        {
        }

        /// <summary> Initializes a new instance of PipelineClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public PipelineClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ArtifactsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://dev.azuresynapse.net/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new PipelineRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of PipelineClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        internal PipelineClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            RestClient = new PipelineRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a pipeline. </summary>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="ifNoneMatch"> ETag of the pipeline entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PipelineResource>> GetPipelineAsync(string pipelineName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PipelineClient.GetPipeline");
            scope.Start();
            try
            {
                return await RestClient.GetPipelineAsync(pipelineName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a pipeline. </summary>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="ifNoneMatch"> ETag of the pipeline entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PipelineResource> GetPipeline(string pipelineName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PipelineClient.GetPipeline");
            scope.Start();
            try
            {
                return RestClient.GetPipeline(pipelineName, ifNoneMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a run of a pipeline. </summary>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="referencePipelineRunId"> The pipeline run identifier. If run ID is specified the parameters of the specified run will be used to create a new run. </param>
        /// <param name="isRecovery"> Recovery mode flag. If recovery mode is set to true, the specified referenced pipeline run and the new run will be grouped under the same groupId. </param>
        /// <param name="startActivityName"> In recovery mode, the rerun will start from this activity. If not specified, all activities will run. </param>
        /// <param name="parameters"> Parameters of the pipeline run. These parameters will be used only if the runId is not specified. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CreateRunResponse>> CreatePipelineRunAsync(string pipelineName, string referencePipelineRunId = null, bool? isRecovery = null, string startActivityName = null, IDictionary<string, object> parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PipelineClient.CreatePipelineRun");
            scope.Start();
            try
            {
                return await RestClient.CreatePipelineRunAsync(pipelineName, referencePipelineRunId, isRecovery, startActivityName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a run of a pipeline. </summary>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="referencePipelineRunId"> The pipeline run identifier. If run ID is specified the parameters of the specified run will be used to create a new run. </param>
        /// <param name="isRecovery"> Recovery mode flag. If recovery mode is set to true, the specified referenced pipeline run and the new run will be grouped under the same groupId. </param>
        /// <param name="startActivityName"> In recovery mode, the rerun will start from this activity. If not specified, all activities will run. </param>
        /// <param name="parameters"> Parameters of the pipeline run. These parameters will be used only if the runId is not specified. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CreateRunResponse> CreatePipelineRun(string pipelineName, string referencePipelineRunId = null, bool? isRecovery = null, string startActivityName = null, IDictionary<string, object> parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PipelineClient.CreatePipelineRun");
            scope.Start();
            try
            {
                return RestClient.CreatePipelineRun(pipelineName, referencePipelineRunId, isRecovery, startActivityName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists pipelines. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<PipelineResource> GetPipelinesByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PipelineResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PipelineClient.GetPipelinesByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.GetPipelinesByWorkspaceAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PipelineResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PipelineClient.GetPipelinesByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.GetPipelinesByWorkspaceNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Lists pipelines. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<PipelineResource> GetPipelinesByWorkspace(CancellationToken cancellationToken = default)
        {
            Page<PipelineResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PipelineClient.GetPipelinesByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.GetPipelinesByWorkspace(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PipelineResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PipelineClient.GetPipelinesByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.GetPipelinesByWorkspaceNextPage(nextLink, cancellationToken);
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

        /// <summary> Creates or updates a pipeline. </summary>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="pipeline"> Pipeline resource definition. </param>
        /// <param name="ifMatch"> ETag of the pipeline entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipelineName"/> or <paramref name="pipeline"/> is null. </exception>
        public virtual async Task<PipelineCreateOrUpdatePipelineOperation> StartCreateOrUpdatePipelineAsync(string pipelineName, PipelineResource pipeline, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (pipelineName == null)
            {
                throw new ArgumentNullException(nameof(pipelineName));
            }
            if (pipeline == null)
            {
                throw new ArgumentNullException(nameof(pipeline));
            }

            using var scope = _clientDiagnostics.CreateScope("PipelineClient.StartCreateOrUpdatePipeline");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdatePipelineAsync(pipelineName, pipeline, ifMatch, cancellationToken).ConfigureAwait(false);
                return new PipelineCreateOrUpdatePipelineOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdatePipelineRequest(pipelineName, pipeline, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a pipeline. </summary>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="pipeline"> Pipeline resource definition. </param>
        /// <param name="ifMatch"> ETag of the pipeline entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipelineName"/> or <paramref name="pipeline"/> is null. </exception>
        public virtual PipelineCreateOrUpdatePipelineOperation StartCreateOrUpdatePipeline(string pipelineName, PipelineResource pipeline, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (pipelineName == null)
            {
                throw new ArgumentNullException(nameof(pipelineName));
            }
            if (pipeline == null)
            {
                throw new ArgumentNullException(nameof(pipeline));
            }

            using var scope = _clientDiagnostics.CreateScope("PipelineClient.StartCreateOrUpdatePipeline");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdatePipeline(pipelineName, pipeline, ifMatch, cancellationToken);
                return new PipelineCreateOrUpdatePipelineOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdatePipelineRequest(pipelineName, pipeline, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a pipeline. </summary>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipelineName"/> is null. </exception>
        public virtual async Task<PipelineDeletePipelineOperation> StartDeletePipelineAsync(string pipelineName, CancellationToken cancellationToken = default)
        {
            if (pipelineName == null)
            {
                throw new ArgumentNullException(nameof(pipelineName));
            }

            using var scope = _clientDiagnostics.CreateScope("PipelineClient.StartDeletePipeline");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeletePipelineAsync(pipelineName, cancellationToken).ConfigureAwait(false);
                return new PipelineDeletePipelineOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeletePipelineRequest(pipelineName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a pipeline. </summary>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipelineName"/> is null. </exception>
        public virtual PipelineDeletePipelineOperation StartDeletePipeline(string pipelineName, CancellationToken cancellationToken = default)
        {
            if (pipelineName == null)
            {
                throw new ArgumentNullException(nameof(pipelineName));
            }

            using var scope = _clientDiagnostics.CreateScope("PipelineClient.StartDeletePipeline");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DeletePipeline(pipelineName, cancellationToken);
                return new PipelineDeletePipelineOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeletePipelineRequest(pipelineName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Renames a pipeline. </summary>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipelineName"/> or <paramref name="request"/> is null. </exception>
        public virtual async Task<PipelineRenamePipelineOperation> StartRenamePipelineAsync(string pipelineName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (pipelineName == null)
            {
                throw new ArgumentNullException(nameof(pipelineName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("PipelineClient.StartRenamePipeline");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.RenamePipelineAsync(pipelineName, request, cancellationToken).ConfigureAwait(false);
                return new PipelineRenamePipelineOperation(_clientDiagnostics, _pipeline, RestClient.CreateRenamePipelineRequest(pipelineName, request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Renames a pipeline. </summary>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipelineName"/> or <paramref name="request"/> is null. </exception>
        public virtual PipelineRenamePipelineOperation StartRenamePipeline(string pipelineName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (pipelineName == null)
            {
                throw new ArgumentNullException(nameof(pipelineName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("PipelineClient.StartRenamePipeline");
            scope.Start();
            try
            {
                var originalResponse = RestClient.RenamePipeline(pipelineName, request, cancellationToken);
                return new PipelineRenamePipelineOperation(_clientDiagnostics, _pipeline, RestClient.CreateRenamePipelineRequest(pipelineName, request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
