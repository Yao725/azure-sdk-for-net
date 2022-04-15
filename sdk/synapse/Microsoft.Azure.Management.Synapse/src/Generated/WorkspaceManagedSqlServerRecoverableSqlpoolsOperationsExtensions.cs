// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WorkspaceManagedSqlServerRecoverableSqlPoolsOperations.
    /// </summary>
    public static partial class WorkspaceManagedSqlServerRecoverableSqlPoolsOperationsExtensions
    {
            /// <summary>
            /// Get list of recoverable sql pools for the server.
            /// </summary>
            /// <remarks>
            /// Get list of recoverable sql pools for workspace managed sql server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            public static IPage<RecoverableSqlPool> List(this IWorkspaceManagedSqlServerRecoverableSqlPoolsOperations operations, string resourceGroupName, string workspaceName)
            {
                return operations.ListAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get list of recoverable sql pools for the server.
            /// </summary>
            /// <remarks>
            /// Get list of recoverable sql pools for workspace managed sql server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecoverableSqlPool>> ListAsync(this IWorkspaceManagedSqlServerRecoverableSqlPoolsOperations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get recoverable sql pools for the server.
            /// </summary>
            /// <remarks>
            /// Get recoverable sql pools for workspace managed sql server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool
            /// </param>
            public static RecoverableSqlPool Get(this IWorkspaceManagedSqlServerRecoverableSqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get recoverable sql pools for the server.
            /// </summary>
            /// <remarks>
            /// Get recoverable sql pools for workspace managed sql server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecoverableSqlPool> GetAsync(this IWorkspaceManagedSqlServerRecoverableSqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get list of recoverable sql pools for the server.
            /// </summary>
            /// <remarks>
            /// Get list of recoverable sql pools for workspace managed sql server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RecoverableSqlPool> ListNext(this IWorkspaceManagedSqlServerRecoverableSqlPoolsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get list of recoverable sql pools for the server.
            /// </summary>
            /// <remarks>
            /// Get list of recoverable sql pools for workspace managed sql server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecoverableSqlPool>> ListNextAsync(this IWorkspaceManagedSqlServerRecoverableSqlPoolsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
