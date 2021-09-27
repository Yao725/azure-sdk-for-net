// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sqlvirtualmachine.Models
{
    /// <summary> Set workload type to optimize storage for SQL Server. </summary>
    public partial class SqlWorkloadTypeUpdateSettings
    {
        /// <summary> Initializes a new instance of SqlWorkloadTypeUpdateSettings. </summary>
        public SqlWorkloadTypeUpdateSettings()
        {
        }

        /// <summary> Initializes a new instance of SqlWorkloadTypeUpdateSettings. </summary>
        /// <param name="sqlWorkloadType"> SQL Server workload type. </param>
        internal SqlWorkloadTypeUpdateSettings(SqlWorkloadType? sqlWorkloadType)
        {
            SqlWorkloadType = sqlWorkloadType;
        }

        /// <summary> SQL Server workload type. </summary>
        public SqlWorkloadType? SqlWorkloadType { get; set; }
    }
}
