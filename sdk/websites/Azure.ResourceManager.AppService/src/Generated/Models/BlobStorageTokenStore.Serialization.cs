// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class BlobStorageTokenStore : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SasUrlSettingName))
            {
                writer.WritePropertyName("sasUrlSettingName");
                writer.WriteStringValue(SasUrlSettingName);
            }
            writer.WriteEndObject();
        }

        internal static BlobStorageTokenStore DeserializeBlobStorageTokenStore(JsonElement element)
        {
            Optional<string> sasUrlSettingName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasUrlSettingName"))
                {
                    sasUrlSettingName = property.Value.GetString();
                    continue;
                }
            }
            return new BlobStorageTokenStore(sasUrlSettingName.Value);
        }
    }
}
