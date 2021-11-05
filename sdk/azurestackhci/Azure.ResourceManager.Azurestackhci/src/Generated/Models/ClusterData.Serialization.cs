// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Azurestackhci.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Azurestackhci
{
    public partial class ClusterData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(CloudManagementEndpoint))
            {
                writer.WritePropertyName("cloudManagementEndpoint");
                writer.WriteStringValue(CloudManagementEndpoint);
            }
            if (Optional.IsDefined(AadClientId))
            {
                writer.WritePropertyName("aadClientId");
                writer.WriteStringValue(AadClientId);
            }
            if (Optional.IsDefined(AadTenantId))
            {
                writer.WritePropertyName("aadTenantId");
                writer.WriteStringValue(AadTenantId);
            }
            if (Optional.IsDefined(DesiredProperties))
            {
                writer.WritePropertyName("desiredProperties");
                writer.WriteObjectValue(DesiredProperties);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("systemData");
            writer.WriteStartObject();
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy");
                writer.WriteStringValue(CreatedBy);
            }
            if (Optional.IsDefined(CreatedByType))
            {
                writer.WritePropertyName("createdByType");
                writer.WriteStringValue(CreatedByType.Value.ToString());
            }
            if (Optional.IsDefined(CreatedAt))
            {
                writer.WritePropertyName("createdAt");
                writer.WriteStringValue(CreatedAt.Value, "O");
            }
            if (Optional.IsDefined(LastModifiedBy))
            {
                writer.WritePropertyName("lastModifiedBy");
                writer.WriteStringValue(LastModifiedBy);
            }
            if (Optional.IsDefined(LastModifiedByType))
            {
                writer.WritePropertyName("lastModifiedByType");
                writer.WriteStringValue(LastModifiedByType.Value.ToString());
            }
            if (Optional.IsDefined(LastModifiedAt))
            {
                writer.WritePropertyName("lastModifiedAt");
                writer.WriteStringValue(LastModifiedAt.Value, "O");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ClusterData DeserializeClusterData(JsonElement element)
        {
            IDictionary<string, string> tags = default;
            Location location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<Status> status = default;
            Optional<string> cloudId = default;
            Optional<string> cloudManagementEndpoint = default;
            Optional<string> aadClientId = default;
            Optional<string> aadTenantId = default;
            Optional<ClusterDesiredProperties> desiredProperties = default;
            Optional<ClusterReportedProperties> reportedProperties = default;
            Optional<float> trialDaysRemaining = default;
            Optional<string> billingModel = default;
            Optional<DateTimeOffset> registrationTimestamp = default;
            Optional<DateTimeOffset> lastSyncTimestamp = default;
            Optional<DateTimeOffset> lastBillingTimestamp = default;
            Optional<string> createdBy = default;
            Optional<CreatedByType> createdByType = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<string> lastModifiedBy = default;
            Optional<CreatedByType> lastModifiedByType = default;
            Optional<DateTimeOffset> lastModifiedAt = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new Status(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("cloudId"))
                        {
                            cloudId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloudManagementEndpoint"))
                        {
                            cloudManagementEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aadClientId"))
                        {
                            aadClientId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aadTenantId"))
                        {
                            aadTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("desiredProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            desiredProperties = ClusterDesiredProperties.DeserializeClusterDesiredProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("reportedProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            reportedProperties = ClusterReportedProperties.DeserializeClusterReportedProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("trialDaysRemaining"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            trialDaysRemaining = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("billingModel"))
                        {
                            billingModel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("registrationTimestamp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            registrationTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastSyncTimestamp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastSyncTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastBillingTimestamp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastBillingTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("createdBy"))
                        {
                            createdBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdByType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdByType = new CreatedByType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("createdAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"))
                        {
                            lastModifiedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedByType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModifiedByType = new CreatedByType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModifiedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ClusterData(id, name, type, tags, location, Optional.ToNullable(provisioningState), Optional.ToNullable(status), cloudId.Value, cloudManagementEndpoint.Value, aadClientId.Value, aadTenantId.Value, desiredProperties.Value, reportedProperties.Value, Optional.ToNullable(trialDaysRemaining), billingModel.Value, Optional.ToNullable(registrationTimestamp), Optional.ToNullable(lastSyncTimestamp), Optional.ToNullable(lastBillingTimestamp), createdBy.Value, Optional.ToNullable(createdByType), Optional.ToNullable(createdAt), lastModifiedBy.Value, Optional.ToNullable(lastModifiedByType), Optional.ToNullable(lastModifiedAt));
        }
    }
}
