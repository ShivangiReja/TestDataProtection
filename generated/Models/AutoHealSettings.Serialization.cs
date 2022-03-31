// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace DataProtectionPlugin.Models
{
    public partial class AutoHealSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoHealStatus))
            {
                writer.WritePropertyName("autoHealStatus");
                writer.WriteStringValue(AutoHealStatus.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AutoHealSettings DeserializeAutoHealSettings(JsonElement element)
        {
            Optional<AutoHealStatus> autoHealStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("autoHealStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    autoHealStatus = new AutoHealStatus(property.Value.GetString());
                    continue;
                }
            }
            return new AutoHealSettings(Optional.ToNullable(autoHealStatus));
        }
    }
}