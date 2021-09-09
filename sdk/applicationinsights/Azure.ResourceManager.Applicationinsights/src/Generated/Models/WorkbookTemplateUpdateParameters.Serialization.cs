// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Applicationinsights.Models
{
    public partial class WorkbookTemplateUpdateParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(Author))
            {
                writer.WritePropertyName("author");
                writer.WriteStringValue(Author);
            }
            if (Optional.IsDefined(TemplateData))
            {
                writer.WritePropertyName("templateData");
                writer.WriteObjectValue(TemplateData);
            }
            if (Optional.IsCollectionDefined(Galleries))
            {
                writer.WritePropertyName("galleries");
                writer.WriteStartArray();
                foreach (var item in Galleries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Localized))
            {
                writer.WritePropertyName("localized");
                writer.WriteStartObject();
                foreach (var item in Localized)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStartArray();
                    foreach (var item0 in item.Value)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
