// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PlaybookActionProperties
    {
        /// <summary>
        /// Initializes a new instance of the PlaybookActionProperties class.
        /// </summary>
        public PlaybookActionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PlaybookActionProperties class.
        /// </summary>
        /// <param name="logicAppResourceId">The resource id of the playbook
        /// resource</param>
        /// <param name="tenantId">The tenant id of the playbook
        /// resource</param>
        public PlaybookActionProperties(string logicAppResourceId = default(string), System.Guid? tenantId = default(System.Guid?))
        {
            LogicAppResourceId = logicAppResourceId;
            TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource id of the playbook resource
        /// </summary>
        [JsonProperty(PropertyName = "logicAppResourceId")]
        public string LogicAppResourceId { get; set; }

        /// <summary>
        /// Gets or sets the tenant id of the playbook resource
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid? TenantId { get; set; }

    }
}
