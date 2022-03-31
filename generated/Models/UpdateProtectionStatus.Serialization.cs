// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace DataProtectionPlugin.Models
{
    public partial class UpdateProtectionStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AdditionalProperties))
            {
                writer.WritePropertyName("additionalProperties");
                writer.WriteStartObject();
                foreach (var item in AdditionalProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TelemetryData))
            {
                writer.WritePropertyName("telemetryData");
                writer.WriteStringValue(TelemetryData);
            }
            if (Optional.IsDefined(RetryAfterOnRetryableErrorInSeconds))
            {
                writer.WritePropertyName("retryAfterOnRetryableErrorInSeconds");
                writer.WriteNumberValue(RetryAfterOnRetryableErrorInSeconds.Value);
            }
            writer.WriteEndObject();
        }

        internal static UpdateProtectionStatus DeserializeUpdateProtectionStatus(JsonElement element)
        {
            Optional<IDictionary<string, string>> additionalProperties = default;
            Optional<string> telemetryData = default;
            Optional<int> retryAfterOnRetryableErrorInSeconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    additionalProperties = dictionary;
                    continue;
                }
                if (property.NameEquals("telemetryData"))
                {
                    telemetryData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retryAfterOnRetryableErrorInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retryAfterOnRetryableErrorInSeconds = property.Value.GetInt32();
                    continue;
                }
            }
            return new UpdateProtectionStatus(Optional.ToDictionary(additionalProperties), telemetryData.Value, Optional.ToNullable(retryAfterOnRetryableErrorInSeconds));
        }
    }
}
