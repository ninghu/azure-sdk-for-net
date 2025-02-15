// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The details of the test notification results. </summary>
    public partial class NotificationStatus
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

        /// <summary> Initializes a new instance of <see cref="NotificationStatus"/>. </summary>
        /// <param name="state"> The overall state. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="state"/> is null. </exception>
        internal NotificationStatus(string state)
        {
            if (state == null)
            {
                throw new ArgumentNullException(nameof(state));
            }

            State = state;
            ActionDetails = new ChangeTrackingList<NotificationActionDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="NotificationStatus"/>. </summary>
        /// <param name="context"> The context info. </param>
        /// <param name="state"> The overall state. </param>
        /// <param name="completedOn"> The completed time. </param>
        /// <param name="createdOn"> The created time. </param>
        /// <param name="actionDetails"> The list of action detail. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationStatus(NotificationContext context, string state, DateTimeOffset? completedOn, DateTimeOffset? createdOn, IReadOnlyList<NotificationActionDetail> actionDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Context = context;
            State = state;
            CompletedOn = completedOn;
            CreatedOn = createdOn;
            ActionDetails = actionDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NotificationStatus"/> for deserialization. </summary>
        internal NotificationStatus()
        {
        }

        /// <summary> The context info. </summary>
        public NotificationContext Context { get; }
        /// <summary> The overall state. </summary>
        public string State { get; }
        /// <summary> The completed time. </summary>
        public DateTimeOffset? CompletedOn { get; }
        /// <summary> The created time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The list of action detail. </summary>
        public IReadOnlyList<NotificationActionDetail> ActionDetails { get; }
    }
}
