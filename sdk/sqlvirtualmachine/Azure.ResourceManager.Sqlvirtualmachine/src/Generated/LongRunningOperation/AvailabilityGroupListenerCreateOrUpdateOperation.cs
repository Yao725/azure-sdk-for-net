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
using Azure.ResourceManager.Sqlvirtualmachine;

namespace Azure.ResourceManager.Sqlvirtualmachine.Models
{
    /// <summary> Creates or updates an availability group listener. </summary>
    public partial class AvailabilityGroupListenerCreateOrUpdateOperation : Operation<AvailabilityGroupListener>, IOperationSource<AvailabilityGroupListener>
    {
        private readonly OperationInternals<AvailabilityGroupListener> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of AvailabilityGroupListenerCreateOrUpdateOperation for mocking. </summary>
        protected AvailabilityGroupListenerCreateOrUpdateOperation()
        {
        }

        internal AvailabilityGroupListenerCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<AvailabilityGroupListener>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "AvailabilityGroupListenerCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AvailabilityGroupListener Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AvailabilityGroupListener>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AvailabilityGroupListener>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        AvailabilityGroupListener IOperationSource<AvailabilityGroupListener>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new AvailabilityGroupListener(_operationBase, AvailabilityGroupListenerData.DeserializeAvailabilityGroupListenerData(document.RootElement));
        }

        async ValueTask<AvailabilityGroupListener> IOperationSource<AvailabilityGroupListener>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new AvailabilityGroupListener(_operationBase, AvailabilityGroupListenerData.DeserializeAvailabilityGroupListenerData(document.RootElement));
        }
    }
}
