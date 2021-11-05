// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Analysisservices.Models
{
    public partial class GatewayListStatusLive
    {
        internal static GatewayListStatusLive DeserializeGatewayListStatusLive(JsonElement element)
        {
            Optional<int> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = property.Value.GetInt32();
                    continue;
                }
            }
            return new GatewayListStatusLive(Optional.ToNullable(status));
        }
    }
}
