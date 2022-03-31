// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace DataProtectionPlugin.Models
{
    public partial class AdhocBasedTaggingCriteria : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TagInfo))
            {
                writer.WritePropertyName("tagInfo");
                writer.WriteObjectValue(TagInfo);
            }
            writer.WriteEndObject();
        }

        internal static AdhocBasedTaggingCriteria DeserializeAdhocBasedTaggingCriteria(JsonElement element)
        {
            Optional<RetentionTag> tagInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tagInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tagInfo = RetentionTag.DeserializeRetentionTag(property.Value);
                    continue;
                }
            }
            return new AdhocBasedTaggingCriteria(tagInfo.Value);
        }
    }
}