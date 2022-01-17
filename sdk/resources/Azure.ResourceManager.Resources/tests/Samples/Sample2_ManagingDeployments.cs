// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#region Snippet:Manage_Deployments_Namespaces
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;
using JsonObject = System.Collections.Generic.Dictionary<string, object>;
#endregion Manage_Deployments_Namespaces

namespace Azure.ResourceManager.Resources.Tests.Samples
{
    public class Sample2_ManagingDeployments
    {
        private ResourceGroup resourceGroup;

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task CreateDeployments()
        {
            #region Snippet:Managing_Deployments_CreateADeployment
            // First we need to get the deployment collection from the resource group
            DeploymentCollection deploymentCollection = resourceGroup.GetDeployments();
            // Use the same location as the resource group
            string deploymentName = "myDeployment";
            var input = new DeploymentInput(new DeploymentProperties(DeploymentMode.Incremental)
            {
                TemplateLink = new TemplateLink()
                {
                    Uri = "https://raw.githubusercontent.com/Azure/azure-quickstart-templates/master/quickstarts/microsoft.storage/storage-account-create/azuredeploy.json"
                },
                Parameters = new JsonObject()
                {
                    {"storageAccountType", new JsonObject()
                        {
                            {"value", "Standard_GRS" }
                        }
                    }
                }
            });
            DeploymentCreateOrUpdateAtScopeOperation lro = await deploymentCollection.CreateOrUpdateAsync(true, deploymentName, input);
            Deployment deployment = lro.Value;
            #endregion Snippet:Managing_Deployments_CreateADeployment
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task CreateDeploymentsUsingJsonObject()
        {
            #region Snippet:Managing_Deployments_CreateADeployment
            // First we need to get the deployment collection from the resource group
            DeploymentCollection deploymentCollection = resourceGroup.GetDeployments();
            // Use the same location as the resource group
            string deploymentName = "myDeployment";
            var input = new DeploymentInput(new DeploymentProperties(DeploymentMode.Incremental)
            {
                Template = new JsonObject()
                {
                    {"$schema", "https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#" },
                    {"contentVersion", "1.0.0.0" },
                    {"metadata", new JsonObject()
                        {
                            {"_generator", new JsonObject()
                                {
                                    {"name", "bicep" },
                                    {"version", "0.4.1008.15138" },
                                    {"templateHash", "104821603399126558" }
                                }
                            }
                        }
                    },
                    {"parameters", new JsonObject()
                        {
                            {"storageAccountType", new JsonObject
                                {
                                    {"type", "string" },
                                    {"defaultValue", "Standard_LRS" },
                                    {"allowedValues", new List<string>{"Premium_LRS", "Premium_ZRS", "Standard_GRS", "Standard_GZRS", "Standard_LRS", "Standard_RAGRS", "Standard_RAGZRS", "Standard_ZRS" } },
                                    {"metadata", new JsonObject
                                        {
                                            {"description", "Storage Account type" }
                                        }
                                    }
                                }
                            },
                            {"location", new JsonObject
                                {
                                    {"type", "string" },
                                    {"defaultValue", "[resourceGroup().location]" },
                                    {"metadata", new JsonObject
                                        {
                                            {"description", "Location for all resources." }
                                        }
                                    }
                                }
                            },
                            {"storageAccountName", new JsonObject
                                {
                                    {"type", "string" },
                                    {"defaultValue", "[format('store{0}', uniqueString(resourceGroup().id))]" },
                                    {"metadata", new JsonObject
                                        {
                                            {"description", "The name of the Storage Account" }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    {"functions", new List<JsonObject>() },
                    {"resources", new List<JsonObject>
                        {
                            new JsonObject()
                            {
                                {"type", "Microsoft.Storage/storageAccounts" },
                                {"apiVersion", "2021-04-01" },
                                {"name", "[parameters('storageAccountName')]" },
                                {"location", "[parameters('location')]" },
                                {"sku", new JsonObject
                                    {
                                        {"name", "[parameters('storageAccountType')]" }
                                    }
                                },
                                {"kind", "StorageV2" },
                                {"properties", new JsonObject() }
                            }
                        }
                    },
                    {"outputs", new JsonObject
                        {
                            {"storageAccountName", new JsonObject
                                {
                                    {"type", "string" },
                                    {"value", "[parameters('storageAccountName')]" }
                                }
                            },
                            {"storageAccountId", new JsonObject
                                {
                                    {"type", "string" },
                                    {"value", "[resourceId('Microsoft.Storage/storageAccounts', parameters('storageAccountName'))]" }
                                }
                            }
                        }
                    }
                },
                Parameters = new JsonObject()
                {
                    {"storageAccountType", new JsonObject()
                        {
                            {"value", "Standard_GRS" }
                        }
                    }
                }
            });
            DeploymentCreateOrUpdateAtScopeOperation lro = await deploymentCollection.CreateOrUpdateAsync(true, deploymentName, input);
            Deployment deployment = lro.Value;
            #endregion Snippet:Managing_Deployments_CreateADeployment
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task ListDeployments()
        {
            #region Snippet:Managing_Deployments_ListAllDeployments
            // First we need to get the deployment collection from the resource group
            DeploymentCollection deploymentCollection = resourceGroup.GetDeployments();
            // With GetAllAsync(), we can get a list of the deployments in the collection
            AsyncPageable<Deployment> response = deploymentCollection.GetAllAsync();
            await foreach (Deployment deployment in response)
            {
                Console.WriteLine(deployment.Data.Name);
            }
            #endregion Snippet:Managing_Deployments_ListAllDeployments
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task DeleteDeployments()
        {
            #region Snippet:Managing_Deployments_DeleteADeployment
            // First we need to get the deployment collection from the resource group
            DeploymentCollection deploymentCollection = resourceGroup.GetDeployments();
            // Now we can get the deployment with GetAsync()
            Deployment deployment = await deploymentCollection.GetAsync("myDeployment");
            // With DeleteAsync(), we can delete the deployment
            await deployment.DeleteAsync(true);
            #endregion Snippet:Managing_Deployments_DeleteADeployment
        }

        [SetUp]
        protected async Task initialize()
        {
            ArmClient armClient = new ArmClient(new DefaultAzureCredential());
            Subscription subscription = await armClient.GetDefaultSubscriptionAsync();

            ResourceGroupCollection rgCollection = subscription.GetResourceGroups();
            // With the collection, we can create a new resource group with an specific name
            string rgName = "myRgName";
            AzureLocation location = AzureLocation.WestUS2;
            ResourceGroupCreateOrUpdateOperation lro = await rgCollection.CreateOrUpdateAsync(rgName, new ResourceGroupData(location));
            ResourceGroup resourceGroup = lro.Value;

            this.resourceGroup = resourceGroup;
        }
    }
}
