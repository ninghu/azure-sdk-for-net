// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The AssetSecurityPolicy. </summary>
    public partial class AssetSecurityPolicy
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

        /// <summary> Initializes a new instance of <see cref="AssetSecurityPolicy"/>. </summary>
        internal AssetSecurityPolicy()
        {
            Sources = new ChangeTrackingList<SourceDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="AssetSecurityPolicy"/>. </summary>
        /// <param name="policyName"></param>
        /// <param name="isAffected"></param>
        /// <param name="description"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="recent"></param>
        /// <param name="sources"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssetSecurityPolicy(string policyName, bool? isAffected, string description, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, bool? recent, IReadOnlyList<SourceDetails> sources, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PolicyName = policyName;
            IsAffected = isAffected;
            Description = description;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            Recent = recent;
            Sources = sources;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the policy name. </summary>
        public string PolicyName { get; }
        /// <summary> Gets the is affected. </summary>
        public bool? IsAffected { get; }
        /// <summary> Gets the description. </summary>
        public string Description { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
        /// <summary> Gets the recent. </summary>
        public bool? Recent { get; }
        /// <summary> Gets the sources. </summary>
        public IReadOnlyList<SourceDetails> Sources { get; }
    }
}
