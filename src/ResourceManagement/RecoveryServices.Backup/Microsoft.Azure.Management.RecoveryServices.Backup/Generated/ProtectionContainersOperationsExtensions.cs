// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ProtectionContainersOperations.
    /// </summary>
    public static partial class ProtectionContainersOperationsExtensions
    {
            /// <summary>
            /// Gets details of the specific container registered to your Recovery
            /// Services Vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Name of the fabric where the container belongs.
            /// </param>
            /// <param name='containerName'>
            /// Name of the container whose details need to be fetched.
            /// </param>
            public static ProtectionContainerResource Get(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectionContainersOperations)s).GetAsync(vaultName, resourceGroupName, fabricName, containerName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets details of the specific container registered to your Recovery
            /// Services Vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Name of the fabric where the container belongs.
            /// </param>
            /// <param name='containerName'>
            /// Name of the container whose details need to be fetched.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ProtectionContainerResource> GetAsync(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, containerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the containers registered to Recovery Services Vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ProtectionContainerResource> List(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, Microsoft.Rest.Azure.OData.ODataQuery<BMSContainerQueryObject> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<BMSContainerQueryObject>))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectionContainersOperations)s).ListAsync(vaultName, resourceGroupName, odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the containers registered to Recovery Services Vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ProtectionContainerResource>> ListAsync(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, Microsoft.Rest.Azure.OData.ODataQuery<BMSContainerQueryObject> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<BMSContainerQueryObject>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(vaultName, resourceGroupName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Discovers all the containers in the subscription that can be backed up to
            /// Recovery Services Vault. This is an asynchronous operation. To know the
            /// status of the operation, call GetRefreshOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated the container.
            /// </param>
            public static void Refresh(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, string fabricName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectionContainersOperations)s).RefreshAsync(vaultName, resourceGroupName, fabricName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Discovers all the containers in the subscription that can be backed up to
            /// Recovery Services Vault. This is an asynchronous operation. To know the
            /// status of the operation, call GetRefreshOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated the container.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task RefreshAsync(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, string fabricName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.RefreshWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Unregisters the given container from your Recovery Services Vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='identityName'>
            /// Name of the protection container to unregister.
            /// </param>
            public static void Unregister(this IProtectionContainersOperations operations, string resourceGroupName, string vaultName, string identityName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectionContainersOperations)s).UnregisterAsync(resourceGroupName, vaultName, identityName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Unregisters the given container from your Recovery Services Vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='identityName'>
            /// Name of the protection container to unregister.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task UnregisterAsync(this IProtectionContainersOperations operations, string resourceGroupName, string vaultName, string identityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.UnregisterWithHttpMessagesAsync(resourceGroupName, vaultName, identityName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Lists the containers registered to Recovery Services Vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ProtectionContainerResource> ListNext(this IProtectionContainersOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectionContainersOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the containers registered to Recovery Services Vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ProtectionContainerResource>> ListNextAsync(this IProtectionContainersOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}