// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Policy Info in backupInstance. </summary>
    public partial class BackupInstancePolicyInfo
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

        /// <summary> Initializes a new instance of <see cref="BackupInstancePolicyInfo"/>. </summary>
        /// <param name="policyId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyId"/> is null. </exception>
        public BackupInstancePolicyInfo(ResourceIdentifier policyId)
        {
            if (policyId == null)
            {
                throw new ArgumentNullException(nameof(policyId));
            }

            PolicyId = policyId;
        }

        /// <summary> Initializes a new instance of <see cref="BackupInstancePolicyInfo"/>. </summary>
        /// <param name="policyId"></param>
        /// <param name="policyVersion"></param>
        /// <param name="policyParameters"> Policy parameters for the backup instance. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupInstancePolicyInfo(ResourceIdentifier policyId, string policyVersion, BackupInstancePolicySettings policyParameters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PolicyId = policyId;
            PolicyVersion = policyVersion;
            PolicyParameters = policyParameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BackupInstancePolicyInfo"/> for deserialization. </summary>
        internal BackupInstancePolicyInfo()
        {
        }

        /// <summary> Gets or sets the policy id. </summary>
        public ResourceIdentifier PolicyId { get; set; }
        /// <summary> Gets the policy version. </summary>
        public string PolicyVersion { get; }
        /// <summary> Policy parameters for the backup instance. </summary>
        public BackupInstancePolicySettings PolicyParameters { get; set; }
    }
}
