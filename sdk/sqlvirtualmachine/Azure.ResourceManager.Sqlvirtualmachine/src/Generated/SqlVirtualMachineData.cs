// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sqlvirtualmachine.Models;

namespace Azure.ResourceManager.Sqlvirtualmachine
{
    /// <summary> A class representing the SqlVirtualMachine data model. </summary>
    public partial class SqlVirtualMachineData : TrackedResource
    {
        /// <summary> Initializes a new instance of SqlVirtualMachineData. </summary>
        /// <param name="location"> The location. </param>
        public SqlVirtualMachineData(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of SqlVirtualMachineData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Azure Active Directory identity of the server. </param>
        /// <param name="virtualMachineResourceId"> ARM Resource id of underlying virtual machine created from SQL marketplace image. </param>
        /// <param name="provisioningState"> Provisioning state to track the async operation status. </param>
        /// <param name="sqlImageOffer"> SQL image offer. Examples include SQL2016-WS2016, SQL2017-WS2016. </param>
        /// <param name="sqlServerLicenseType"> SQL Server license type. </param>
        /// <param name="sqlManagement"> SQL Server Management type. </param>
        /// <param name="sqlImageSku"> SQL Server edition type. </param>
        /// <param name="sqlVirtualMachineGroupResourceId"> ARM resource id of the SQL virtual machine group this SQL virtual machine is or will be part of. </param>
        /// <param name="wsfcDomainCredentials"> Domain credentials for setting up Windows Server Failover Cluster for SQL availability group. </param>
        /// <param name="autoPatchingSettings"> Auto patching settings for applying critical security updates to SQL virtual machine. </param>
        /// <param name="autoBackupSettings"> Auto backup settings for SQL Server. </param>
        /// <param name="keyVaultCredentialSettings"> Key vault credential settings. </param>
        /// <param name="serverConfigurationsManagementSettings"> SQL Server configuration management settings. </param>
        /// <param name="storageConfigurationSettings"> Storage Configuration Settings. </param>
        internal SqlVirtualMachineData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, Models.ResourceIdentity identity, string virtualMachineResourceId, string provisioningState, string sqlImageOffer, SqlServerLicenseType? sqlServerLicenseType, SqlManagementMode? sqlManagement, SqlImageSku? sqlImageSku, string sqlVirtualMachineGroupResourceId, WsfcDomainCredentials wsfcDomainCredentials, AutoPatchingSettings autoPatchingSettings, AutoBackupSettings autoBackupSettings, KeyVaultCredentialSettings keyVaultCredentialSettings, ServerConfigurationsManagementSettings serverConfigurationsManagementSettings, StorageConfigurationSettings storageConfigurationSettings) : base(id, name, type, tags, location)
        {
            Identity = identity;
            VirtualMachineResourceId = virtualMachineResourceId;
            ProvisioningState = provisioningState;
            SqlImageOffer = sqlImageOffer;
            SqlServerLicenseType = sqlServerLicenseType;
            SqlManagement = sqlManagement;
            SqlImageSku = sqlImageSku;
            SqlVirtualMachineGroupResourceId = sqlVirtualMachineGroupResourceId;
            WsfcDomainCredentials = wsfcDomainCredentials;
            AutoPatchingSettings = autoPatchingSettings;
            AutoBackupSettings = autoBackupSettings;
            KeyVaultCredentialSettings = keyVaultCredentialSettings;
            ServerConfigurationsManagementSettings = serverConfigurationsManagementSettings;
            StorageConfigurationSettings = storageConfigurationSettings;
        }

        /// <summary> Azure Active Directory identity of the server. </summary>
        public Models.ResourceIdentity Identity { get; set; }
        /// <summary> ARM Resource id of underlying virtual machine created from SQL marketplace image. </summary>
        public string VirtualMachineResourceId { get; set; }
        /// <summary> Provisioning state to track the async operation status. </summary>
        public string ProvisioningState { get; }
        /// <summary> SQL image offer. Examples include SQL2016-WS2016, SQL2017-WS2016. </summary>
        public string SqlImageOffer { get; set; }
        /// <summary> SQL Server license type. </summary>
        public SqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary> SQL Server Management type. </summary>
        public SqlManagementMode? SqlManagement { get; set; }
        /// <summary> SQL Server edition type. </summary>
        public SqlImageSku? SqlImageSku { get; set; }
        /// <summary> ARM resource id of the SQL virtual machine group this SQL virtual machine is or will be part of. </summary>
        public string SqlVirtualMachineGroupResourceId { get; set; }
        /// <summary> Domain credentials for setting up Windows Server Failover Cluster for SQL availability group. </summary>
        public WsfcDomainCredentials WsfcDomainCredentials { get; set; }
        /// <summary> Auto patching settings for applying critical security updates to SQL virtual machine. </summary>
        public AutoPatchingSettings AutoPatchingSettings { get; set; }
        /// <summary> Auto backup settings for SQL Server. </summary>
        public AutoBackupSettings AutoBackupSettings { get; set; }
        /// <summary> Key vault credential settings. </summary>
        public KeyVaultCredentialSettings KeyVaultCredentialSettings { get; set; }
        /// <summary> SQL Server configuration management settings. </summary>
        public ServerConfigurationsManagementSettings ServerConfigurationsManagementSettings { get; set; }
        /// <summary> Storage Configuration Settings. </summary>
        public StorageConfigurationSettings StorageConfigurationSettings { get; set; }
    }
}
