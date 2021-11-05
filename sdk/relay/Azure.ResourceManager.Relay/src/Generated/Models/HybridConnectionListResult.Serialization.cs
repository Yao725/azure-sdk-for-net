// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Relay;

namespace Azure.ResourceManager.Relay.Models
{
    internal partial class HybridConnectionListResult
    {
        internal static HybridConnectionListResult DeserializeHybridConnectionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<HybridConnectionData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HybridConnectionData> array = new List<HybridConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HybridConnectionData.DeserializeHybridConnectionData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new HybridConnectionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
