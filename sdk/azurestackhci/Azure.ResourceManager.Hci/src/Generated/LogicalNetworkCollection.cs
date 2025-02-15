// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing a collection of <see cref="LogicalNetworkResource"/> and their operations.
    /// Each <see cref="LogicalNetworkResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="LogicalNetworkCollection"/> instance call the GetLogicalNetworks method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class LogicalNetworkCollection : ArmCollection, IEnumerable<LogicalNetworkResource>, IAsyncEnumerable<LogicalNetworkResource>
    {
        private readonly ClientDiagnostics _logicalNetworkClientDiagnostics;
        private readonly LogicalNetworksRestOperations _logicalNetworkRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogicalNetworkCollection"/> class for mocking. </summary>
        protected LogicalNetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LogicalNetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LogicalNetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicalNetworkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", LogicalNetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LogicalNetworkResource.ResourceType, out string logicalNetworkApiVersion);
            _logicalNetworkRestClient = new LogicalNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicalNetworkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update a logical network. Please note some properties can be set only during logical network creation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks/{logicalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicalNetworks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="logicalNetworkName"> Name of the logical network. </param>
        /// <param name="data"> The <see cref="LogicalNetworkData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicalNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LogicalNetworkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string logicalNetworkName, LogicalNetworkData data, CancellationToken cancellationToken = default)
        {
            if (logicalNetworkName == null)
            {
                throw new ArgumentNullException(nameof(logicalNetworkName));
            }
            if (logicalNetworkName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(logicalNetworkName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _logicalNetworkClientDiagnostics.CreateScope("LogicalNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _logicalNetworkRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, logicalNetworkName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation<LogicalNetworkResource>(new LogicalNetworkOperationSource(Client), _logicalNetworkClientDiagnostics, Pipeline, _logicalNetworkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, logicalNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to create or update a logical network. Please note some properties can be set only during logical network creation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks/{logicalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicalNetworks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="logicalNetworkName"> Name of the logical network. </param>
        /// <param name="data"> The <see cref="LogicalNetworkData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicalNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LogicalNetworkResource> CreateOrUpdate(WaitUntil waitUntil, string logicalNetworkName, LogicalNetworkData data, CancellationToken cancellationToken = default)
        {
            if (logicalNetworkName == null)
            {
                throw new ArgumentNullException(nameof(logicalNetworkName));
            }
            if (logicalNetworkName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(logicalNetworkName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _logicalNetworkClientDiagnostics.CreateScope("LogicalNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _logicalNetworkRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, logicalNetworkName, data, cancellationToken);
                var operation = new HciArmOperation<LogicalNetworkResource>(new LogicalNetworkOperationSource(Client), _logicalNetworkClientDiagnostics, Pipeline, _logicalNetworkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, logicalNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks/{logicalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicalNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logicalNetworkName"> Name of the logical network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicalNetworkName"/> is null. </exception>
        public virtual async Task<Response<LogicalNetworkResource>> GetAsync(string logicalNetworkName, CancellationToken cancellationToken = default)
        {
            if (logicalNetworkName == null)
            {
                throw new ArgumentNullException(nameof(logicalNetworkName));
            }
            if (logicalNetworkName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(logicalNetworkName));
            }

            using var scope = _logicalNetworkClientDiagnostics.CreateScope("LogicalNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _logicalNetworkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, logicalNetworkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicalNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks/{logicalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicalNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logicalNetworkName"> Name of the logical network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicalNetworkName"/> is null. </exception>
        public virtual Response<LogicalNetworkResource> Get(string logicalNetworkName, CancellationToken cancellationToken = default)
        {
            if (logicalNetworkName == null)
            {
                throw new ArgumentNullException(nameof(logicalNetworkName));
            }
            if (logicalNetworkName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(logicalNetworkName));
            }

            using var scope = _logicalNetworkClientDiagnostics.CreateScope("LogicalNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _logicalNetworkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, logicalNetworkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicalNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the logical networks in the specified resource group. Use the nextLink property in the response to get the next page of logical networks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicalNetworks_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogicalNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogicalNetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicalNetworkRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logicalNetworkRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LogicalNetworkResource(Client, LogicalNetworkData.DeserializeLogicalNetworkData(e)), _logicalNetworkClientDiagnostics, Pipeline, "LogicalNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the logical networks in the specified resource group. Use the nextLink property in the response to get the next page of logical networks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicalNetworks_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogicalNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogicalNetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicalNetworkRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logicalNetworkRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LogicalNetworkResource(Client, LogicalNetworkData.DeserializeLogicalNetworkData(e)), _logicalNetworkClientDiagnostics, Pipeline, "LogicalNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks/{logicalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicalNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logicalNetworkName"> Name of the logical network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicalNetworkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string logicalNetworkName, CancellationToken cancellationToken = default)
        {
            if (logicalNetworkName == null)
            {
                throw new ArgumentNullException(nameof(logicalNetworkName));
            }
            if (logicalNetworkName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(logicalNetworkName));
            }

            using var scope = _logicalNetworkClientDiagnostics.CreateScope("LogicalNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _logicalNetworkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, logicalNetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks/{logicalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicalNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logicalNetworkName"> Name of the logical network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicalNetworkName"/> is null. </exception>
        public virtual Response<bool> Exists(string logicalNetworkName, CancellationToken cancellationToken = default)
        {
            if (logicalNetworkName == null)
            {
                throw new ArgumentNullException(nameof(logicalNetworkName));
            }
            if (logicalNetworkName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(logicalNetworkName));
            }

            using var scope = _logicalNetworkClientDiagnostics.CreateScope("LogicalNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _logicalNetworkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, logicalNetworkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks/{logicalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicalNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logicalNetworkName"> Name of the logical network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicalNetworkName"/> is null. </exception>
        public virtual async Task<NullableResponse<LogicalNetworkResource>> GetIfExistsAsync(string logicalNetworkName, CancellationToken cancellationToken = default)
        {
            if (logicalNetworkName == null)
            {
                throw new ArgumentNullException(nameof(logicalNetworkName));
            }
            if (logicalNetworkName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(logicalNetworkName));
            }

            using var scope = _logicalNetworkClientDiagnostics.CreateScope("LogicalNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _logicalNetworkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, logicalNetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LogicalNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new LogicalNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks/{logicalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogicalNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogicalNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logicalNetworkName"> Name of the logical network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logicalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logicalNetworkName"/> is null. </exception>
        public virtual NullableResponse<LogicalNetworkResource> GetIfExists(string logicalNetworkName, CancellationToken cancellationToken = default)
        {
            if (logicalNetworkName == null)
            {
                throw new ArgumentNullException(nameof(logicalNetworkName));
            }
            if (logicalNetworkName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(logicalNetworkName));
            }

            using var scope = _logicalNetworkClientDiagnostics.CreateScope("LogicalNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _logicalNetworkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, logicalNetworkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LogicalNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new LogicalNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LogicalNetworkResource> IEnumerable<LogicalNetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LogicalNetworkResource> IAsyncEnumerable<LogicalNetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
