// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlDatabasePatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
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
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode");
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation");
                writer.WriteStringValue(Collation);
            }
            if (Optional.IsDefined(MaxSizeBytes))
            {
                writer.WritePropertyName("maxSizeBytes");
                writer.WriteNumberValue(MaxSizeBytes.Value);
            }
            if (Optional.IsDefined(SampleName))
            {
                writer.WritePropertyName("sampleName");
                writer.WriteStringValue(SampleName.Value.ToString());
            }
            if (Optional.IsDefined(ElasticPoolId))
            {
                writer.WritePropertyName("elasticPoolId");
                writer.WriteStringValue(ElasticPoolId);
            }
            if (Optional.IsDefined(SourceDatabaseId))
            {
                writer.WritePropertyName("sourceDatabaseId");
                writer.WriteStringValue(SourceDatabaseId);
            }
            if (Optional.IsDefined(RestorePointInOn))
            {
                writer.WritePropertyName("restorePointInTime");
                writer.WriteStringValue(RestorePointInOn.Value, "O");
            }
            if (Optional.IsDefined(SourceDatabaseDeletionOn))
            {
                writer.WritePropertyName("sourceDatabaseDeletionDate");
                writer.WriteStringValue(SourceDatabaseDeletionOn.Value, "O");
            }
            if (Optional.IsDefined(RecoveryServicesRecoveryPointId))
            {
                writer.WritePropertyName("recoveryServicesRecoveryPointId");
                writer.WriteStringValue(RecoveryServicesRecoveryPointId);
            }
            if (Optional.IsDefined(LongTermRetentionBackupResourceId))
            {
                writer.WritePropertyName("longTermRetentionBackupResourceId");
                writer.WriteStringValue(LongTermRetentionBackupResourceId);
            }
            if (Optional.IsDefined(RecoverableDatabaseId))
            {
                writer.WritePropertyName("recoverableDatabaseId");
                writer.WriteStringValue(RecoverableDatabaseId);
            }
            if (Optional.IsDefined(RestorableDroppedDatabaseId))
            {
                writer.WritePropertyName("restorableDroppedDatabaseId");
                writer.WriteStringValue(RestorableDroppedDatabaseId);
            }
            if (Optional.IsDefined(CatalogCollation))
            {
                writer.WritePropertyName("catalogCollation");
                writer.WriteStringValue(CatalogCollation.Value.ToString());
            }
            if (Optional.IsDefined(ZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant");
                writer.WriteBooleanValue(ZoneRedundant.Value);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType");
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(ReadScale))
            {
                writer.WritePropertyName("readScale");
                writer.WriteStringValue(ReadScale.Value.ToString());
            }
            if (Optional.IsDefined(HighAvailabilityReplicaCount))
            {
                writer.WritePropertyName("highAvailabilityReplicaCount");
                writer.WriteNumberValue(HighAvailabilityReplicaCount.Value);
            }
            if (Optional.IsDefined(SecondaryType))
            {
                writer.WritePropertyName("secondaryType");
                writer.WriteStringValue(SecondaryType.Value.ToString());
            }
            if (Optional.IsDefined(AutoPauseDelay))
            {
                writer.WritePropertyName("autoPauseDelay");
                writer.WriteNumberValue(AutoPauseDelay.Value);
            }
            if (Optional.IsDefined(RequestedBackupStorageRedundancy))
            {
                writer.WritePropertyName("requestedBackupStorageRedundancy");
                writer.WriteStringValue(RequestedBackupStorageRedundancy.Value.ToString());
            }
            if (Optional.IsDefined(MinCapacity))
            {
                writer.WritePropertyName("minCapacity");
                writer.WriteNumberValue(MinCapacity.Value);
            }
            if (Optional.IsDefined(MaintenanceConfigurationId))
            {
                writer.WritePropertyName("maintenanceConfigurationId");
                writer.WriteStringValue(MaintenanceConfigurationId);
            }
            if (Optional.IsDefined(IsLedgerOn))
            {
                writer.WritePropertyName("isLedgerOn");
                writer.WriteBooleanValue(IsLedgerOn.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
