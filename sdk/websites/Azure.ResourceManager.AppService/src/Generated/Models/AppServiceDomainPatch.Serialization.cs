// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceDomainPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ContactAdmin))
            {
                writer.WritePropertyName("contactAdmin");
                writer.WriteObjectValue(ContactAdmin);
            }
            if (Optional.IsDefined(ContactBilling))
            {
                writer.WritePropertyName("contactBilling");
                writer.WriteObjectValue(ContactBilling);
            }
            if (Optional.IsDefined(ContactRegistrant))
            {
                writer.WritePropertyName("contactRegistrant");
                writer.WriteObjectValue(ContactRegistrant);
            }
            if (Optional.IsDefined(ContactTech))
            {
                writer.WritePropertyName("contactTech");
                writer.WriteObjectValue(ContactTech);
            }
            if (Optional.IsDefined(Privacy))
            {
                writer.WritePropertyName("privacy");
                writer.WriteBooleanValue(Privacy.Value);
            }
            if (Optional.IsDefined(AutoRenew))
            {
                writer.WritePropertyName("autoRenew");
                writer.WriteBooleanValue(AutoRenew.Value);
            }
            if (Optional.IsDefined(Consent))
            {
                writer.WritePropertyName("consent");
                writer.WriteObjectValue(Consent);
            }
            if (Optional.IsDefined(DnsType))
            {
                writer.WritePropertyName("dnsType");
                writer.WriteStringValue(DnsType.Value.ToSerialString());
            }
            if (Optional.IsDefined(DnsZoneId))
            {
                writer.WritePropertyName("dnsZoneId");
                writer.WriteStringValue(DnsZoneId);
            }
            if (Optional.IsDefined(TargetDnsType))
            {
                writer.WritePropertyName("targetDnsType");
                writer.WriteStringValue(TargetDnsType.Value.ToSerialString());
            }
            if (Optional.IsDefined(AuthCode))
            {
                writer.WritePropertyName("authCode");
                writer.WriteStringValue(AuthCode);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AppServiceDomainPatch DeserializeAppServiceDomainPatch(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<ContactInformation> contactAdmin = default;
            Optional<ContactInformation> contactBilling = default;
            Optional<ContactInformation> contactRegistrant = default;
            Optional<ContactInformation> contactTech = default;
            Optional<DomainStatus> registrationStatus = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<IReadOnlyList<string>> nameServers = default;
            Optional<bool> privacy = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<DateTimeOffset> expirationTime = default;
            Optional<DateTimeOffset> lastRenewedTime = default;
            Optional<bool> autoRenew = default;
            Optional<bool> readyForDnsRecordManagement = default;
            Optional<IReadOnlyList<HostName>> managedHostNames = default;
            Optional<DomainPurchaseConsent> consent = default;
            Optional<IReadOnlyList<DomainNotRenewableReasons>> domainNotRenewableReasons = default;
            Optional<DnsType> dnsType = default;
            Optional<string> dnsZoneId = default;
            Optional<DnsType> targetDnsType = default;
            Optional<string> authCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
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
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("contactAdmin"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            contactAdmin = ContactInformation.DeserializeContactInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("contactBilling"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            contactBilling = ContactInformation.DeserializeContactInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("contactRegistrant"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            contactRegistrant = ContactInformation.DeserializeContactInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("contactTech"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            contactTech = ContactInformation.DeserializeContactInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("registrationStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            registrationStatus = property0.Value.GetString().ToDomainStatus();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("nameServers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            nameServers = array;
                            continue;
                        }
                        if (property0.NameEquals("privacy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            privacy = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("createdTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expirationTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            expirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastRenewedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastRenewedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("autoRenew"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoRenew = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("readyForDnsRecordManagement"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            readyForDnsRecordManagement = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("managedHostNames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<HostName> array = new List<HostName>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HostName.DeserializeHostName(item));
                            }
                            managedHostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("consent"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            consent = DomainPurchaseConsent.DeserializeDomainPurchaseConsent(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("domainNotRenewableReasons"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DomainNotRenewableReasons> array = new List<DomainNotRenewableReasons>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new DomainNotRenewableReasons(item.GetString()));
                            }
                            domainNotRenewableReasons = array;
                            continue;
                        }
                        if (property0.NameEquals("dnsType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dnsType = property0.Value.GetString().ToDnsType();
                            continue;
                        }
                        if (property0.NameEquals("dnsZoneId"))
                        {
                            dnsZoneId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetDnsType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            targetDnsType = property0.Value.GetString().ToDnsType();
                            continue;
                        }
                        if (property0.NameEquals("authCode"))
                        {
                            authCode = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AppServiceDomainPatch(id, name, type, systemData, kind.Value, contactAdmin.Value, contactBilling.Value, contactRegistrant.Value, contactTech.Value, Optional.ToNullable(registrationStatus), Optional.ToNullable(provisioningState), Optional.ToList(nameServers), Optional.ToNullable(privacy), Optional.ToNullable(createdTime), Optional.ToNullable(expirationTime), Optional.ToNullable(lastRenewedTime), Optional.ToNullable(autoRenew), Optional.ToNullable(readyForDnsRecordManagement), Optional.ToList(managedHostNames), consent.Value, Optional.ToList(domainNotRenewableReasons), Optional.ToNullable(dnsType), dnsZoneId.Value, Optional.ToNullable(targetDnsType), authCode.Value);
        }
    }
}
