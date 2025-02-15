// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.IoT.Hub.Service;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class ConfigurationQueriesTestInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetCondition))
            {
                writer.WritePropertyName("targetCondition"u8);
                writer.WriteStringValue(TargetCondition);
            }
            if (Optional.IsCollectionDefined(CustomMetricQueries))
            {
                writer.WritePropertyName("customMetricQueries"u8);
                writer.WriteStartObject();
                foreach (var item in CustomMetricQueries)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }
    }
}
