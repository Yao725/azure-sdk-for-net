// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Scheduler.Models
{
    public partial class OAuthAuthentication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Secret))
            {
                writer.WritePropertyName("secret");
                writer.WriteStringValue(Secret);
            }
            if (Optional.IsDefined(Tenant))
            {
                writer.WritePropertyName("tenant");
                writer.WriteStringValue(Tenant);
            }
            if (Optional.IsDefined(Audience))
            {
                writer.WritePropertyName("audience");
                writer.WriteStringValue(Audience);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId");
                writer.WriteStringValue(ClientId);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToSerialString());
            writer.WriteEndObject();
        }

        internal static OAuthAuthentication DeserializeOAuthAuthentication(JsonElement element)
        {
            Optional<string> secret = default;
            Optional<string> tenant = default;
            Optional<string> audience = default;
            Optional<string> clientId = default;
            HttpAuthenticationType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secret"))
                {
                    secret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenant"))
                {
                    tenant = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("audience"))
                {
                    audience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString().ToHttpAuthenticationType();
                    continue;
                }
            }
            return new OAuthAuthentication(type, secret.Value, tenant.Value, audience.Value, clientId.Value);
        }
    }
}
