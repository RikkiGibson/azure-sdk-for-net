// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AnalysisServices.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AnalysisServices;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServersOperations.
    /// </summary>
    public static partial class ServersOperationsExtensions
    {
            /// <summary>
            /// Gets details about the specified Analysis Services server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be a minimum of 3
            /// characters, and a maximum of 63.
            /// </param>
            public static AnalysisServicesServerInner GetDetails(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                return operations.GetDetailsAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets details about the specified Analysis Services server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be a minimum of 3
            /// characters, and a maximum of 63.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AnalysisServicesServerInner> GetDetailsAsync(this IServersOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDetailsWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Provisions the specified Analysis Services server based on the
            /// configuration specified in the request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be a minimum of 3
            /// characters, and a maximum of 63.
            /// </param>
            /// <param name='serverParameters'>
            /// Contains the information used to provision the Analysis Services server.
            /// </param>
            public static AnalysisServicesServerInner Create(this IServersOperations operations, string resourceGroupName, string serverName, AnalysisServicesServerInner serverParameters)
            {
                return operations.CreateAsync(resourceGroupName, serverName, serverParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provisions the specified Analysis Services server based on the
            /// configuration specified in the request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be a minimum of 3
            /// characters, and a maximum of 63.
            /// </param>
            /// <param name='serverParameters'>
            /// Contains the information used to provision the Analysis Services server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AnalysisServicesServerInner> CreateAsync(this IServersOperations operations, string resourceGroupName, string serverName, AnalysisServicesServerInner serverParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, serverName, serverParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Analysis Services server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            public static void Delete(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                operations.DeleteAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Analysis Services server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServersOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates the current state of the specified Analysis Services server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            /// <param name='serverUpdateParameters'>
            /// Request object that contains the updated information for the server.
            /// </param>
            public static AnalysisServicesServerInner Update(this IServersOperations operations, string resourceGroupName, string serverName, AnalysisServicesServerUpdateParametersInner serverUpdateParameters)
            {
                return operations.UpdateAsync(resourceGroupName, serverName, serverUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the current state of the specified Analysis Services server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            /// <param name='serverUpdateParameters'>
            /// Request object that contains the updated information for the server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AnalysisServicesServerInner> UpdateAsync(this IServersOperations operations, string resourceGroupName, string serverName, AnalysisServicesServerUpdateParametersInner serverUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serverName, serverUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Supends operation of the specified Analysis Services server instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            public static void Suspend(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                operations.SuspendAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Supends operation of the specified Analysis Services server instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SuspendAsync(this IServersOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SuspendWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Resumes operation of the specified Analysis Services server instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            public static void Resume(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                operations.ResumeAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resumes operation of the specified Analysis Services server instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ResumeAsync(this IServersOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ResumeWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all the Analysis Services servers for the given resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            public static IEnumerable<AnalysisServicesServerInner> ListByResourceGroup(this IServersOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the Analysis Services servers for the given resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<AnalysisServicesServerInner>> ListByResourceGroupAsync(this IServersOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the Analysis Services servers for the given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<AnalysisServicesServerInner> List(this IServersOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the Analysis Services servers for the given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<AnalysisServicesServerInner>> ListAsync(this IServersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists eligible SKUs for Analysis Services resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static SkuEnumerationForNewResourceResultInner ListSkusForNew(this IServersOperations operations)
            {
                return operations.ListSkusForNewAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists eligible SKUs for Analysis Services resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SkuEnumerationForNewResourceResultInner> ListSkusForNewAsync(this IServersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSkusForNewWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists eligible SKUs for an Analysis Services resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            public static SkuEnumerationForExistingResourceResultInner ListSkusForExisting(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListSkusForExistingAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists eligible SKUs for an Analysis Services resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SkuEnumerationForExistingResourceResultInner> ListSkusForExistingAsync(this IServersOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSkusForExistingWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Provisions the specified Analysis Services server based on the
            /// configuration specified in the request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be a minimum of 3
            /// characters, and a maximum of 63.
            /// </param>
            /// <param name='serverParameters'>
            /// Contains the information used to provision the Analysis Services server.
            /// </param>
            public static AnalysisServicesServerInner BeginCreate(this IServersOperations operations, string resourceGroupName, string serverName, AnalysisServicesServerInner serverParameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, serverName, serverParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provisions the specified Analysis Services server based on the
            /// configuration specified in the request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be a minimum of 3
            /// characters, and a maximum of 63.
            /// </param>
            /// <param name='serverParameters'>
            /// Contains the information used to provision the Analysis Services server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AnalysisServicesServerInner> BeginCreateAsync(this IServersOperations operations, string resourceGroupName, string serverName, AnalysisServicesServerInner serverParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, serverName, serverParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Analysis Services server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            public static void BeginDelete(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Analysis Services server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IServersOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates the current state of the specified Analysis Services server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            /// <param name='serverUpdateParameters'>
            /// Request object that contains the updated information for the server.
            /// </param>
            public static AnalysisServicesServerInner BeginUpdate(this IServersOperations operations, string resourceGroupName, string serverName, AnalysisServicesServerUpdateParametersInner serverUpdateParameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, serverName, serverUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the current state of the specified Analysis Services server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            /// <param name='serverUpdateParameters'>
            /// Request object that contains the updated information for the server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AnalysisServicesServerInner> BeginUpdateAsync(this IServersOperations operations, string resourceGroupName, string serverName, AnalysisServicesServerUpdateParametersInner serverUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, serverName, serverUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Supends operation of the specified Analysis Services server instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            public static void BeginSuspend(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                operations.BeginSuspendAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Supends operation of the specified Analysis Services server instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginSuspendAsync(this IServersOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginSuspendWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Resumes operation of the specified Analysis Services server instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            public static void BeginResume(this IServersOperations operations, string resourceGroupName, string serverName)
            {
                operations.BeginResumeAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resumes operation of the specified Analysis Services server instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource group of which a given Analysis Services
            /// server is part. This name must be at least 1 character in length, and no
            /// more than 90.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Analysis Services server. It must be at least 3 characters
            /// in length, and no more than 63.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginResumeAsync(this IServersOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginResumeWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}