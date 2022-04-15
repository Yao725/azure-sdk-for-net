// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the VirtualMachineScaleSetVm data model. </summary>
    public partial class VirtualMachineScaleSetVmData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetVmData. </summary>
        /// <param name="location"> The location. </param>
        public VirtualMachineScaleSetVmData(AzureLocation location) : base(location)
        {
            Resources = new ChangeTrackingList<VirtualMachineExtensionData>();
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVmData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="instanceId"> The virtual machine instance ID. </param>
        /// <param name="sku"> The virtual machine SKU. </param>
        /// <param name="plan"> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**. </param>
        /// <param name="resources"> The virtual machine child extension resources. </param>
        /// <param name="zones"> The virtual machine zones. </param>
        /// <param name="latestModelApplied"> Specifies whether the latest model has been applied to the virtual machine. </param>
        /// <param name="vmId"> Azure VM unique ID. </param>
        /// <param name="instanceView"> The virtual machine instance view. </param>
        /// <param name="hardwareProfile"> Specifies the hardware settings for the virtual machine. </param>
        /// <param name="storageProfile"> Specifies the storage settings for the virtual machine disks. </param>
        /// <param name="additionalCapabilities"> Specifies additional capabilities enabled or disabled on the virtual machine in the scale set. For instance: whether the virtual machine has the capability to support attaching managed data disks with UltraSSD_LRS storage account type. </param>
        /// <param name="osProfile"> Specifies the operating system settings for the virtual machine. </param>
        /// <param name="securityProfile"> Specifies the Security related profile settings for the virtual machine. </param>
        /// <param name="networkProfile"> Specifies the network interfaces of the virtual machine. </param>
        /// <param name="networkProfileConfiguration"> Specifies the network profile configuration of the virtual machine. </param>
        /// <param name="diagnosticsProfile"> Specifies the boot diagnostic settings state. &lt;br&gt;&lt;br&gt;Minimum api-version: 2015-06-15. </param>
        /// <param name="availabilitySet"> Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Availability sets overview](https://docs.microsoft.com/azure/virtual-machines/availability-set-overview). &lt;br&gt;&lt;br&gt; For more information on Azure planned maintenance, see [Maintenance and updates for Virtual Machines in Azure](https://docs.microsoft.com/azure/virtual-machines/maintenance-and-updates) &lt;br&gt;&lt;br&gt; Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="licenseType"> Specifies that the image or disk that is being used was licensed on-premises. &lt;br&gt;&lt;br&gt; Possible values for Windows Server operating system are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; Possible values for Linux Server operating system are: &lt;br&gt;&lt;br&gt; RHEL_BYOS (for RHEL) &lt;br&gt;&lt;br&gt; SLES_BYOS (for SUSE) &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing) &lt;br&gt;&lt;br&gt; [Azure Hybrid Use Benefit for Linux Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </param>
        /// <param name="modelDefinitionApplied"> Specifies whether the model applied to the virtual machine is the model of the virtual machine scale set or the customized model for the virtual machine. </param>
        /// <param name="protectionPolicy"> Specifies the protection policy of the virtual machine. </param>
        /// <param name="userData"> UserData for the VM, which must be base-64 encoded. Customer should not pass any secrets in here. &lt;br&gt;&lt;br&gt;Minimum api-version: 2021-03-01. </param>
        internal VirtualMachineScaleSetVmData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string instanceId, ComputeSku sku, ComputePlan plan, IReadOnlyList<VirtualMachineExtensionData> resources, IReadOnlyList<string> zones, bool? latestModelApplied, string vmId, VirtualMachineScaleSetVmInstanceView instanceView, HardwareProfile hardwareProfile, StorageProfile storageProfile, AdditionalCapabilities additionalCapabilities, OSProfile osProfile, SecurityProfile securityProfile, NetworkProfile networkProfile, VirtualMachineScaleSetVmNetworkProfileConfiguration networkProfileConfiguration, DiagnosticsProfile diagnosticsProfile, WritableSubResource availabilitySet, string provisioningState, string licenseType, string modelDefinitionApplied, VirtualMachineScaleSetVmProtectionPolicy protectionPolicy, string userData) : base(id, name, resourceType, systemData, tags, location)
        {
            InstanceId = instanceId;
            Sku = sku;
            Plan = plan;
            Resources = resources;
            Zones = zones;
            LatestModelApplied = latestModelApplied;
            VmId = vmId;
            InstanceView = instanceView;
            HardwareProfile = hardwareProfile;
            StorageProfile = storageProfile;
            AdditionalCapabilities = additionalCapabilities;
            OSProfile = osProfile;
            SecurityProfile = securityProfile;
            NetworkProfile = networkProfile;
            NetworkProfileConfiguration = networkProfileConfiguration;
            DiagnosticsProfile = diagnosticsProfile;
            AvailabilitySet = availabilitySet;
            ProvisioningState = provisioningState;
            LicenseType = licenseType;
            ModelDefinitionApplied = modelDefinitionApplied;
            ProtectionPolicy = protectionPolicy;
            UserData = userData;
        }

        /// <summary> The virtual machine instance ID. </summary>
        public string InstanceId { get; }
        /// <summary> The virtual machine SKU. </summary>
        public ComputeSku Sku { get; }
        /// <summary> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**. </summary>
        public ComputePlan Plan { get; set; }
        /// <summary> The virtual machine child extension resources. </summary>
        public IReadOnlyList<VirtualMachineExtensionData> Resources { get; }
        /// <summary> The virtual machine zones. </summary>
        public IReadOnlyList<string> Zones { get; }
        /// <summary> Specifies whether the latest model has been applied to the virtual machine. </summary>
        public bool? LatestModelApplied { get; }
        /// <summary> Azure VM unique ID. </summary>
        public string VmId { get; }
        /// <summary> The virtual machine instance view. </summary>
        public VirtualMachineScaleSetVmInstanceView InstanceView { get; }
        /// <summary> Specifies the hardware settings for the virtual machine. </summary>
        public HardwareProfile HardwareProfile { get; set; }
        /// <summary> Specifies the storage settings for the virtual machine disks. </summary>
        public StorageProfile StorageProfile { get; set; }
        /// <summary> Specifies additional capabilities enabled or disabled on the virtual machine in the scale set. For instance: whether the virtual machine has the capability to support attaching managed data disks with UltraSSD_LRS storage account type. </summary>
        public AdditionalCapabilities AdditionalCapabilities { get; set; }
        /// <summary> Specifies the operating system settings for the virtual machine. </summary>
        public OSProfile OSProfile { get; set; }
        /// <summary> Specifies the Security related profile settings for the virtual machine. </summary>
        public SecurityProfile SecurityProfile { get; set; }
        /// <summary> Specifies the network interfaces of the virtual machine. </summary>
        public NetworkProfile NetworkProfile { get; set; }
        /// <summary> Specifies the network profile configuration of the virtual machine. </summary>
        internal VirtualMachineScaleSetVmNetworkProfileConfiguration NetworkProfileConfiguration { get; set; }
        /// <summary> The list of network configurations. </summary>
        public IList<VirtualMachineScaleSetNetworkConfiguration> NetworkInterfaceConfigurations
        {
            get
            {
                if (NetworkProfileConfiguration is null)
                    NetworkProfileConfiguration = new VirtualMachineScaleSetVmNetworkProfileConfiguration();
                return NetworkProfileConfiguration.NetworkInterfaceConfigurations;
            }
        }

        /// <summary> Specifies the boot diagnostic settings state. &lt;br&gt;&lt;br&gt;Minimum api-version: 2015-06-15. </summary>
        internal DiagnosticsProfile DiagnosticsProfile { get; set; }
        /// <summary> Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. &lt;br&gt;**NOTE**: If storageUri is being specified then ensure that the storage account is in the same region and subscription as the VM. &lt;br&gt;&lt;br&gt; You can easily view the output of your console log. &lt;br&gt;&lt;br&gt; Azure also enables you to see a screenshot of the VM from the hypervisor. </summary>
        public BootDiagnostics BootDiagnostics
        {
            get => DiagnosticsProfile is null ? default : DiagnosticsProfile.BootDiagnostics;
            set
            {
                if (DiagnosticsProfile is null)
                    DiagnosticsProfile = new DiagnosticsProfile();
                DiagnosticsProfile.BootDiagnostics = value;
            }
        }

        /// <summary> Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Availability sets overview](https://docs.microsoft.com/azure/virtual-machines/availability-set-overview). &lt;br&gt;&lt;br&gt; For more information on Azure planned maintenance, see [Maintenance and updates for Virtual Machines in Azure](https://docs.microsoft.com/azure/virtual-machines/maintenance-and-updates) &lt;br&gt;&lt;br&gt; Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set. </summary>
        internal WritableSubResource AvailabilitySet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier AvailabilitySetId
        {
            get => AvailabilitySet is null ? default : AvailabilitySet.Id;
            set
            {
                if (AvailabilitySet is null)
                    AvailabilitySet = new WritableSubResource();
                AvailabilitySet.Id = value;
            }
        }

        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> Specifies that the image or disk that is being used was licensed on-premises. &lt;br&gt;&lt;br&gt; Possible values for Windows Server operating system are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; Possible values for Linux Server operating system are: &lt;br&gt;&lt;br&gt; RHEL_BYOS (for RHEL) &lt;br&gt;&lt;br&gt; SLES_BYOS (for SUSE) &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing) &lt;br&gt;&lt;br&gt; [Azure Hybrid Use Benefit for Linux Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </summary>
        public string LicenseType { get; set; }
        /// <summary> Specifies whether the model applied to the virtual machine is the model of the virtual machine scale set or the customized model for the virtual machine. </summary>
        public string ModelDefinitionApplied { get; }
        /// <summary> Specifies the protection policy of the virtual machine. </summary>
        public VirtualMachineScaleSetVmProtectionPolicy ProtectionPolicy { get; set; }
        /// <summary> UserData for the VM, which must be base-64 encoded. Customer should not pass any secrets in here. &lt;br&gt;&lt;br&gt;Minimum api-version: 2021-03-01. </summary>
        public string UserData { get; set; }
    }
}
