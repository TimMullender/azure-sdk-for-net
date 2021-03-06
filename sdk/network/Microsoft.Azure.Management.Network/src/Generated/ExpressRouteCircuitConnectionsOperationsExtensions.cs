// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExpressRouteCircuitConnectionsOperations.
    /// </summary>
    public static partial class ExpressRouteCircuitConnectionsOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified Express Route Circuit Connection from the specified
            /// express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the express route circuit connection.
            /// </param>
            public static void Delete(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, string connectionName)
            {
                operations.DeleteAsync(resourceGroupName, circuitName, peeringName, connectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Express Route Circuit Connection from the specified
            /// express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the express route circuit connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, string connectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, connectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified Express Route Circuit Connection from the specified
            /// express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the express route circuit connection.
            /// </param>
            public static ExpressRouteCircuitConnection Get(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, string connectionName)
            {
                return operations.GetAsync(resourceGroupName, circuitName, peeringName, connectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Express Route Circuit Connection from the specified
            /// express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the express route circuit connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitConnection> GetAsync(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, string connectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, connectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Express Route Circuit Connection in the specified
            /// express route circuits.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the express route circuit connection.
            /// </param>
            /// <param name='expressRouteCircuitConnectionParameters'>
            /// Parameters supplied to the create or update express route circuit
            /// connection operation.
            /// </param>
            public static ExpressRouteCircuitConnection CreateOrUpdate(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, string connectionName, ExpressRouteCircuitConnection expressRouteCircuitConnectionParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, circuitName, peeringName, connectionName, expressRouteCircuitConnectionParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Express Route Circuit Connection in the specified
            /// express route circuits.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the express route circuit connection.
            /// </param>
            /// <param name='expressRouteCircuitConnectionParameters'>
            /// Parameters supplied to the create or update express route circuit
            /// connection operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitConnection> CreateOrUpdateAsync(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, string connectionName, ExpressRouteCircuitConnection expressRouteCircuitConnectionParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, connectionName, expressRouteCircuitConnectionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all global reach connections associated with a private peering in an
            /// express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            public static IPage<ExpressRouteCircuitConnection> List(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName)
            {
                return operations.ListAsync(resourceGroupName, circuitName, peeringName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all global reach connections associated with a private peering in an
            /// express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExpressRouteCircuitConnection>> ListAsync(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Express Route Circuit Connection from the specified
            /// express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the express route circuit connection.
            /// </param>
            public static void BeginDelete(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, string connectionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, circuitName, peeringName, connectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Express Route Circuit Connection from the specified
            /// express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the express route circuit connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, string connectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, connectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a Express Route Circuit Connection in the specified
            /// express route circuits.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the express route circuit connection.
            /// </param>
            /// <param name='expressRouteCircuitConnectionParameters'>
            /// Parameters supplied to the create or update express route circuit
            /// connection operation.
            /// </param>
            public static ExpressRouteCircuitConnection BeginCreateOrUpdate(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, string connectionName, ExpressRouteCircuitConnection expressRouteCircuitConnectionParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, circuitName, peeringName, connectionName, expressRouteCircuitConnectionParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Express Route Circuit Connection in the specified
            /// express route circuits.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the express route circuit connection.
            /// </param>
            /// <param name='expressRouteCircuitConnectionParameters'>
            /// Parameters supplied to the create or update express route circuit
            /// connection operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitConnection> BeginCreateOrUpdateAsync(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, string connectionName, ExpressRouteCircuitConnection expressRouteCircuitConnectionParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, connectionName, expressRouteCircuitConnectionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all global reach connections associated with a private peering in an
            /// express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ExpressRouteCircuitConnection> ListNext(this IExpressRouteCircuitConnectionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all global reach connections associated with a private peering in an
            /// express route circuit.
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
            public static async Task<IPage<ExpressRouteCircuitConnection>> ListNextAsync(this IExpressRouteCircuitConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
