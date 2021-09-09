// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Powerbidedicated.Models
{
    public partial class SkuEnumerationForNewResourceResult
    {
        internal static SkuEnumerationForNewResourceResult DeserializeSkuEnumerationForNewResourceResult(JsonElement element)
        {
            Optional<IReadOnlyList<CapacitySku>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CapacitySku> array = new List<CapacitySku>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CapacitySku.DeserializeCapacitySku(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SkuEnumerationForNewResourceResult(Optional.ToList(value));
        }
    }
}
