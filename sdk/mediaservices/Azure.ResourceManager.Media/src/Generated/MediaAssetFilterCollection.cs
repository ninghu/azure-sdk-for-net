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

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing a collection of <see cref="MediaAssetFilterResource"/> and their operations.
    /// Each <see cref="MediaAssetFilterResource"/> in the collection will belong to the same instance of <see cref="MediaAssetResource"/>.
    /// To get a <see cref="MediaAssetFilterCollection"/> instance call the GetMediaAssetFilters method from an instance of <see cref="MediaAssetResource"/>.
    /// </summary>
    public partial class MediaAssetFilterCollection : ArmCollection, IEnumerable<MediaAssetFilterResource>, IAsyncEnumerable<MediaAssetFilterResource>
    {
        private readonly ClientDiagnostics _mediaAssetFilterAssetFiltersClientDiagnostics;
        private readonly AssetFiltersRestOperations _mediaAssetFilterAssetFiltersRestClient;

        /// <summary> Initializes a new instance of the <see cref="MediaAssetFilterCollection"/> class for mocking. </summary>
        protected MediaAssetFilterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MediaAssetFilterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MediaAssetFilterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mediaAssetFilterAssetFiltersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", MediaAssetFilterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MediaAssetFilterResource.ResourceType, out string mediaAssetFilterAssetFiltersApiVersion);
            _mediaAssetFilterAssetFiltersRestClient = new AssetFiltersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mediaAssetFilterAssetFiltersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MediaAssetResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MediaAssetResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an Asset Filter associated with the specified Asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MediaAssetFilterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string filterName, MediaAssetFilterData data, CancellationToken cancellationToken = default)
        {
            if (filterName == null)
            {
                throw new ArgumentNullException(nameof(filterName));
            }
            if (filterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(filterName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _mediaAssetFilterAssetFiltersClientDiagnostics.CreateScope("MediaAssetFilterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mediaAssetFilterAssetFiltersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filterName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation<MediaAssetFilterResource>(Response.FromValue(new MediaAssetFilterResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an Asset Filter associated with the specified Asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MediaAssetFilterResource> CreateOrUpdate(WaitUntil waitUntil, string filterName, MediaAssetFilterData data, CancellationToken cancellationToken = default)
        {
            if (filterName == null)
            {
                throw new ArgumentNullException(nameof(filterName));
            }
            if (filterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(filterName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _mediaAssetFilterAssetFiltersClientDiagnostics.CreateScope("MediaAssetFilterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mediaAssetFilterAssetFiltersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filterName, data, cancellationToken);
                var operation = new MediaArmOperation<MediaAssetFilterResource>(Response.FromValue(new MediaAssetFilterResource(Client, response), response.GetRawResponse()));
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
        /// Get the details of an Asset Filter associated with the specified Asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> is null. </exception>
        public virtual async Task<Response<MediaAssetFilterResource>> GetAsync(string filterName, CancellationToken cancellationToken = default)
        {
            if (filterName == null)
            {
                throw new ArgumentNullException(nameof(filterName));
            }
            if (filterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(filterName));
            }

            using var scope = _mediaAssetFilterAssetFiltersClientDiagnostics.CreateScope("MediaAssetFilterCollection.Get");
            scope.Start();
            try
            {
                var response = await _mediaAssetFilterAssetFiltersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaAssetFilterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of an Asset Filter associated with the specified Asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> is null. </exception>
        public virtual Response<MediaAssetFilterResource> Get(string filterName, CancellationToken cancellationToken = default)
        {
            if (filterName == null)
            {
                throw new ArgumentNullException(nameof(filterName));
            }
            if (filterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(filterName));
            }

            using var scope = _mediaAssetFilterAssetFiltersClientDiagnostics.CreateScope("MediaAssetFilterCollection.Get");
            scope.Start();
            try
            {
                var response = _mediaAssetFilterAssetFiltersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaAssetFilterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Asset Filters associated with the specified Asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MediaAssetFilterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MediaAssetFilterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mediaAssetFilterAssetFiltersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mediaAssetFilterAssetFiltersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MediaAssetFilterResource(Client, MediaAssetFilterData.DeserializeMediaAssetFilterData(e)), _mediaAssetFilterAssetFiltersClientDiagnostics, Pipeline, "MediaAssetFilterCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// List Asset Filters associated with the specified Asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MediaAssetFilterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MediaAssetFilterResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mediaAssetFilterAssetFiltersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mediaAssetFilterAssetFiltersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MediaAssetFilterResource(Client, MediaAssetFilterData.DeserializeMediaAssetFilterData(e)), _mediaAssetFilterAssetFiltersClientDiagnostics, Pipeline, "MediaAssetFilterCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string filterName, CancellationToken cancellationToken = default)
        {
            if (filterName == null)
            {
                throw new ArgumentNullException(nameof(filterName));
            }
            if (filterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(filterName));
            }

            using var scope = _mediaAssetFilterAssetFiltersClientDiagnostics.CreateScope("MediaAssetFilterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mediaAssetFilterAssetFiltersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> is null. </exception>
        public virtual Response<bool> Exists(string filterName, CancellationToken cancellationToken = default)
        {
            if (filterName == null)
            {
                throw new ArgumentNullException(nameof(filterName));
            }
            if (filterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(filterName));
            }

            using var scope = _mediaAssetFilterAssetFiltersClientDiagnostics.CreateScope("MediaAssetFilterCollection.Exists");
            scope.Start();
            try
            {
                var response = _mediaAssetFilterAssetFiltersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filterName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> is null. </exception>
        public virtual async Task<NullableResponse<MediaAssetFilterResource>> GetIfExistsAsync(string filterName, CancellationToken cancellationToken = default)
        {
            if (filterName == null)
            {
                throw new ArgumentNullException(nameof(filterName));
            }
            if (filterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(filterName));
            }

            using var scope = _mediaAssetFilterAssetFiltersClientDiagnostics.CreateScope("MediaAssetFilterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mediaAssetFilterAssetFiltersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MediaAssetFilterResource>(response.GetRawResponse());
                return Response.FromValue(new MediaAssetFilterResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> is null. </exception>
        public virtual NullableResponse<MediaAssetFilterResource> GetIfExists(string filterName, CancellationToken cancellationToken = default)
        {
            if (filterName == null)
            {
                throw new ArgumentNullException(nameof(filterName));
            }
            if (filterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(filterName));
            }

            using var scope = _mediaAssetFilterAssetFiltersClientDiagnostics.CreateScope("MediaAssetFilterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mediaAssetFilterAssetFiltersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filterName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MediaAssetFilterResource>(response.GetRawResponse());
                return Response.FromValue(new MediaAssetFilterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MediaAssetFilterResource> IEnumerable<MediaAssetFilterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MediaAssetFilterResource> IAsyncEnumerable<MediaAssetFilterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
