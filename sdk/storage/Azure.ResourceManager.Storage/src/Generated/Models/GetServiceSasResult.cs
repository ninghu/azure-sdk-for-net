// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The List service SAS credentials operation response. </summary>
    public partial class GetServiceSasResult
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

        /// <summary> Initializes a new instance of <see cref="GetServiceSasResult"/>. </summary>
        internal GetServiceSasResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GetServiceSasResult"/>. </summary>
        /// <param name="serviceSasToken"> List service SAS credentials of specific resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GetServiceSasResult(string serviceSasToken, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ServiceSasToken = serviceSasToken;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List service SAS credentials of specific resource. </summary>
        public string ServiceSasToken { get; }
    }
}
