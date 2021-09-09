// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Scheduler.Models
{
    public partial class RetryPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RetryType))
            {
                writer.WritePropertyName("retryType");
                writer.WriteStringValue(RetryType.Value.ToSerialString());
            }
            if (Optional.IsDefined(RetryInterval))
            {
                writer.WritePropertyName("retryInterval");
                writer.WriteStringValue(RetryInterval.Value, "P");
            }
            if (Optional.IsDefined(RetryCount))
            {
                writer.WritePropertyName("retryCount");
                writer.WriteNumberValue(RetryCount.Value);
            }
            writer.WriteEndObject();
        }

        internal static RetryPolicy DeserializeRetryPolicy(JsonElement element)
        {
            Optional<RetryType> retryType = default;
            Optional<TimeSpan> retryInterval = default;
            Optional<int> retryCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("retryType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retryType = property.Value.GetString().ToRetryType();
                    continue;
                }
                if (property.NameEquals("retryInterval"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retryInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("retryCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retryCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new RetryPolicy(Optional.ToNullable(retryType), Optional.ToNullable(retryInterval), Optional.ToNullable(retryCount));
        }
    }
}
