// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql
{
    internal class PostgreSqlVirtualNetworkRuleOperationSource : IOperationSource<PostgreSqlVirtualNetworkRuleResource>
    {
        private readonly ArmClient _client;

        internal PostgreSqlVirtualNetworkRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        PostgreSqlVirtualNetworkRuleResource IOperationSource<PostgreSqlVirtualNetworkRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PostgreSqlVirtualNetworkRuleData.DeserializePostgreSqlVirtualNetworkRuleData(document.RootElement);
            return new PostgreSqlVirtualNetworkRuleResource(_client, data);
        }

        async ValueTask<PostgreSqlVirtualNetworkRuleResource> IOperationSource<PostgreSqlVirtualNetworkRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PostgreSqlVirtualNetworkRuleData.DeserializePostgreSqlVirtualNetworkRuleData(document.RootElement);
            return new PostgreSqlVirtualNetworkRuleResource(_client, data);
        }
    }
}
