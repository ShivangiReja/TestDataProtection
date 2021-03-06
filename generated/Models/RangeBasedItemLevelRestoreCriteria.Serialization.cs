// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace DataProtectionPlugin.Models
{
    public partial class RangeBasedItemLevelRestoreCriteria : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MinMatchingValue))
            {
                writer.WritePropertyName("minMatchingValue");
                writer.WriteStringValue(MinMatchingValue);
            }
            if (Optional.IsDefined(MaxMatchingValue))
            {
                writer.WritePropertyName("maxMatchingValue");
                writer.WriteStringValue(MaxMatchingValue);
            }
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static RangeBasedItemLevelRestoreCriteria DeserializeRangeBasedItemLevelRestoreCriteria(JsonElement element)
        {
            Optional<string> minMatchingValue = default;
            Optional<string> maxMatchingValue = default;
            string objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minMatchingValue"))
                {
                    minMatchingValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxMatchingValue"))
                {
                    maxMatchingValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new RangeBasedItemLevelRestoreCriteria(objectType, minMatchingValue.Value, maxMatchingValue.Value);
        }
    }
}
