// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace DataProtectionPlugin.Models
{
    public partial class ItemPathBasedRestoreCriteria : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ItemPath))
            {
                writer.WritePropertyName("itemPath");
                writer.WriteStringValue(ItemPath);
            }
            if (Optional.IsDefined(IsPathRelativeToBackupItem))
            {
                writer.WritePropertyName("isPathRelativeToBackupItem");
                writer.WriteBooleanValue(IsPathRelativeToBackupItem.Value);
            }
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static ItemPathBasedRestoreCriteria DeserializeItemPathBasedRestoreCriteria(JsonElement element)
        {
            Optional<string> itemPath = default;
            Optional<bool> isPathRelativeToBackupItem = default;
            string objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("itemPath"))
                {
                    itemPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPathRelativeToBackupItem"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isPathRelativeToBackupItem = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new ItemPathBasedRestoreCriteria(objectType, itemPath.Value, Optional.ToNullable(isPathRelativeToBackupItem));
        }
    }
}