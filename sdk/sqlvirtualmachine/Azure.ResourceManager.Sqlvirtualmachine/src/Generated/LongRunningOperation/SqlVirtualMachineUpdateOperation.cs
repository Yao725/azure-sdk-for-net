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
    /// <summary> Updates a SQL virtual machine. </summary>
    public partial class SqlVirtualMachineUpdateOperation : Operation<SqlVirtualMachine>, IOperationSource<SqlVirtualMachine>
    {
        private readonly OperationInternals<SqlVirtualMachine> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of SqlVirtualMachineUpdateOperation for mocking. </summary>
        protected SqlVirtualMachineUpdateOperation()
        {
        }

        internal SqlVirtualMachineUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<SqlVirtualMachine>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "SqlVirtualMachineUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SqlVirtualMachine Value => _operation.Value;

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
        public override ValueTask<Response<SqlVirtualMachine>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SqlVirtualMachine>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SqlVirtualMachine IOperationSource<SqlVirtualMachine>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new SqlVirtualMachine(_operationBase, SqlVirtualMachineData.DeserializeSqlVirtualMachineData(document.RootElement));
        }

        async ValueTask<SqlVirtualMachine> IOperationSource<SqlVirtualMachine>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new SqlVirtualMachine(_operationBase, SqlVirtualMachineData.DeserializeSqlVirtualMachineData(document.RootElement));
        }
    }
}
