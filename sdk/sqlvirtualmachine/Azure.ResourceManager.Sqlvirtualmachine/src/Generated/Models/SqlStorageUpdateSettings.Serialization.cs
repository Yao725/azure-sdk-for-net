// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sqlvirtualmachine.Models
{
    public partial class SqlStorageUpdateSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DiskCount))
            {
                writer.WritePropertyName("diskCount");
                writer.WriteNumberValue(DiskCount.Value);
            }
            if (Optional.IsDefined(StartingDeviceId))
            {
                writer.WritePropertyName("startingDeviceId");
                writer.WriteNumberValue(StartingDeviceId.Value);
            }
            if (Optional.IsDefined(DiskConfigurationType))
            {
                writer.WritePropertyName("diskConfigurationType");
                writer.WriteStringValue(DiskConfigurationType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static SqlStorageUpdateSettings DeserializeSqlStorageUpdateSettings(JsonElement element)
        {
            Optional<int> diskCount = default;
            Optional<int> startingDeviceId = default;
            Optional<DiskConfigurationType> diskConfigurationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startingDeviceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startingDeviceId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("diskConfigurationType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskConfigurationType = new DiskConfigurationType(property.Value.GetString());
                    continue;
                }
            }
            return new SqlStorageUpdateSettings(Optional.ToNullable(diskCount), Optional.ToNullable(startingDeviceId), Optional.ToNullable(diskConfigurationType));
        }
    }
}
