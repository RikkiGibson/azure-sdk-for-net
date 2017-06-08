// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.StreamAnalytics
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for InputsOperations.
    /// </summary>
    public static partial class InputsOperationsExtensions
    {
            /// <summary>
            /// Creates an input or replaces an already existing input under an existing
            /// streaming job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// The definition of the input that will be used to create a new input or
            /// replace the existing one under the streaming job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='inputName'>
            /// The name of the input.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the input. Omit this value to always overwrite the current
            /// input. Specify the last-seen ETag value to prevent accidentally
            /// overwritting concurrent changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new input to be created, but to prevent updating an
            /// existing input. Other values will result in a 412 Pre-condition Failed
            /// response.
            /// </param>
            public static Input CreateOrReplace(this IInputsOperations operations, Input input, string resourceGroupName, string jobName, string inputName, string ifMatch = default(string), string ifNoneMatch = default(string))
            {
                return operations.CreateOrReplaceAsync(input, resourceGroupName, jobName, inputName, ifMatch, ifNoneMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an input or replaces an already existing input under an existing
            /// streaming job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// The definition of the input that will be used to create a new input or
            /// replace the existing one under the streaming job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='inputName'>
            /// The name of the input.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the input. Omit this value to always overwrite the current
            /// input. Specify the last-seen ETag value to prevent accidentally
            /// overwritting concurrent changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new input to be created, but to prevent updating an
            /// existing input. Other values will result in a 412 Pre-condition Failed
            /// response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Input> CreateOrReplaceAsync(this IInputsOperations operations, Input input, string resourceGroupName, string jobName, string inputName, string ifMatch = default(string), string ifNoneMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrReplaceWithHttpMessagesAsync(input, resourceGroupName, jobName, inputName, ifMatch, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing input under an existing streaming job. This can be used
            /// to partially update (ie. update one or two properties) an input without
            /// affecting the rest the job or input definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// An Input object. The properties specified here will overwrite the
            /// corresponding properties in the existing input (ie. Those properties will
            /// be updated). Any properties that are set to null here will mean that the
            /// corresponding property in the existing input will remain the same and not
            /// change as a result of this PATCH operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='inputName'>
            /// The name of the input.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the input. Omit this value to always overwrite the current
            /// input. Specify the last-seen ETag value to prevent accidentally
            /// overwritting concurrent changes.
            /// </param>
            public static Input Update(this IInputsOperations operations, Input input, string resourceGroupName, string jobName, string inputName, string ifMatch = default(string))
            {
                return operations.UpdateAsync(input, resourceGroupName, jobName, inputName, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing input under an existing streaming job. This can be used
            /// to partially update (ie. update one or two properties) an input without
            /// affecting the rest the job or input definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='input'>
            /// An Input object. The properties specified here will overwrite the
            /// corresponding properties in the existing input (ie. Those properties will
            /// be updated). Any properties that are set to null here will mean that the
            /// corresponding property in the existing input will remain the same and not
            /// change as a result of this PATCH operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='inputName'>
            /// The name of the input.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the input. Omit this value to always overwrite the current
            /// input. Specify the last-seen ETag value to prevent accidentally
            /// overwritting concurrent changes.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Input> UpdateAsync(this IInputsOperations operations, Input input, string resourceGroupName, string jobName, string inputName, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(input, resourceGroupName, jobName, inputName, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an input from the streaming job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='inputName'>
            /// The name of the input.
            /// </param>
            public static void Delete(this IInputsOperations operations, string resourceGroupName, string jobName, string inputName)
            {
                operations.DeleteAsync(resourceGroupName, jobName, inputName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an input from the streaming job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='inputName'>
            /// The name of the input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IInputsOperations operations, string resourceGroupName, string jobName, string inputName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, jobName, inputName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets details about the specified input.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='inputName'>
            /// The name of the input.
            /// </param>
            public static Input Get(this IInputsOperations operations, string resourceGroupName, string jobName, string inputName)
            {
                return operations.GetAsync(resourceGroupName, jobName, inputName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets details about the specified input.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='inputName'>
            /// The name of the input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Input> GetAsync(this IInputsOperations operations, string resourceGroupName, string jobName, string inputName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, jobName, inputName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the inputs under the specified streaming job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='select'>
            /// The $select OData query parameter. This is a comma-separated list of
            /// structural properties to include in the response, or “*” to include all
            /// properties. By default, all properties are returned except diagnostics.
            /// Currently only accepts '*' as a valid value.
            /// </param>
            public static IPage<Input> ListByStreamingJob(this IInputsOperations operations, string resourceGroupName, string jobName, string select = default(string))
            {
                return operations.ListByStreamingJobAsync(resourceGroupName, jobName, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the inputs under the specified streaming job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='select'>
            /// The $select OData query parameter. This is a comma-separated list of
            /// structural properties to include in the response, or “*” to include all
            /// properties. By default, all properties are returned except diagnostics.
            /// Currently only accepts '*' as a valid value.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Input>> ListByStreamingJobAsync(this IInputsOperations operations, string resourceGroupName, string jobName, string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByStreamingJobWithHttpMessagesAsync(resourceGroupName, jobName, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Tests whether an input’s datasource is reachable and usable by the Azure
            /// Stream Analytics service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='inputName'>
            /// The name of the input.
            /// </param>
            /// <param name='input'>
            /// If the input specified does not already exist, this parameter must contain
            /// the full input definition intended to be tested. If the input specified
            /// already exists, this parameter can be left null to test the existing input
            /// as is or if specified, the properties specified will overwrite the
            /// corresponding properties in the existing input (exactly like a PATCH
            /// operation) and the resulting input will be tested.
            /// </param>
            public static ResourceTestStatus Test(this IInputsOperations operations, string resourceGroupName, string jobName, string inputName, Input input = default(Input))
            {
                return operations.TestAsync(resourceGroupName, jobName, inputName, input).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Tests whether an input’s datasource is reachable and usable by the Azure
            /// Stream Analytics service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='inputName'>
            /// The name of the input.
            /// </param>
            /// <param name='input'>
            /// If the input specified does not already exist, this parameter must contain
            /// the full input definition intended to be tested. If the input specified
            /// already exists, this parameter can be left null to test the existing input
            /// as is or if specified, the properties specified will overwrite the
            /// corresponding properties in the existing input (exactly like a PATCH
            /// operation) and the resulting input will be tested.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceTestStatus> TestAsync(this IInputsOperations operations, string resourceGroupName, string jobName, string inputName, Input input = default(Input), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.TestWithHttpMessagesAsync(resourceGroupName, jobName, inputName, input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Tests whether an input’s datasource is reachable and usable by the Azure
            /// Stream Analytics service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='inputName'>
            /// The name of the input.
            /// </param>
            /// <param name='input'>
            /// If the input specified does not already exist, this parameter must contain
            /// the full input definition intended to be tested. If the input specified
            /// already exists, this parameter can be left null to test the existing input
            /// as is or if specified, the properties specified will overwrite the
            /// corresponding properties in the existing input (exactly like a PATCH
            /// operation) and the resulting input will be tested.
            /// </param>
            public static ResourceTestStatus BeginTest(this IInputsOperations operations, string resourceGroupName, string jobName, string inputName, Input input = default(Input))
            {
                return operations.BeginTestAsync(resourceGroupName, jobName, inputName, input).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Tests whether an input’s datasource is reachable and usable by the Azure
            /// Stream Analytics service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='inputName'>
            /// The name of the input.
            /// </param>
            /// <param name='input'>
            /// If the input specified does not already exist, this parameter must contain
            /// the full input definition intended to be tested. If the input specified
            /// already exists, this parameter can be left null to test the existing input
            /// as is or if specified, the properties specified will overwrite the
            /// corresponding properties in the existing input (exactly like a PATCH
            /// operation) and the resulting input will be tested.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceTestStatus> BeginTestAsync(this IInputsOperations operations, string resourceGroupName, string jobName, string inputName, Input input = default(Input), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginTestWithHttpMessagesAsync(resourceGroupName, jobName, inputName, input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the inputs under the specified streaming job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Input> ListByStreamingJobNext(this IInputsOperations operations, string nextPageLink)
            {
                return operations.ListByStreamingJobNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the inputs under the specified streaming job.
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
            public static async Task<IPage<Input>> ListByStreamingJobNextAsync(this IInputsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByStreamingJobNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
