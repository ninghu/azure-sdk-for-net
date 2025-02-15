// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Mesh revision profile properties for a mesh. </summary>
    internal partial class MeshRevisionProfileProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MeshRevisionProfileProperties"/>. </summary>
        public MeshRevisionProfileProperties()
        {
            MeshRevisions = new ChangeTrackingList<MeshRevision>();
        }

        /// <summary> Initializes a new instance of <see cref="MeshRevisionProfileProperties"/>. </summary>
        /// <param name="meshRevisions"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MeshRevisionProfileProperties(IList<MeshRevision> meshRevisions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MeshRevisions = meshRevisions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the mesh revisions. </summary>
        public IList<MeshRevision> MeshRevisions { get; }
    }
}
