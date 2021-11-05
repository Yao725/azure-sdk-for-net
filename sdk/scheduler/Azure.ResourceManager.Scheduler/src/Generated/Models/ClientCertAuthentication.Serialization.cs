// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Scheduler.Models
{
    public partial class ClientCertAuthentication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(Pfx))
            {
                writer.WritePropertyName("pfx");
                writer.WriteStringValue(Pfx);
            }
            if (Optional.IsDefined(CertificateThumbprint))
            {
                writer.WritePropertyName("certificateThumbprint");
                writer.WriteStringValue(CertificateThumbprint);
            }
            if (Optional.IsDefined(CertificateExpirationDate))
            {
                writer.WritePropertyName("certificateExpirationDate");
                writer.WriteStringValue(CertificateExpirationDate.Value, "O");
            }
            if (Optional.IsDefined(CertificateSubjectName))
            {
                writer.WritePropertyName("certificateSubjectName");
                writer.WriteStringValue(CertificateSubjectName);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToSerialString());
            writer.WriteEndObject();
        }

        internal static ClientCertAuthentication DeserializeClientCertAuthentication(JsonElement element)
        {
            Optional<string> password = default;
            Optional<string> pfx = default;
            Optional<string> certificateThumbprint = default;
            Optional<DateTimeOffset> certificateExpirationDate = default;
            Optional<string> certificateSubjectName = default;
            HttpAuthenticationType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("password"))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pfx"))
                {
                    pfx = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateThumbprint"))
                {
                    certificateThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateExpirationDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    certificateExpirationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("certificateSubjectName"))
                {
                    certificateSubjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString().ToHttpAuthenticationType();
                    continue;
                }
            }
            return new ClientCertAuthentication(type, password.Value, pfx.Value, certificateThumbprint.Value, Optional.ToNullable(certificateExpirationDate), certificateSubjectName.Value);
        }
    }
}
