// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace DataProtectionPlugin.Models
{
    public partial class KubernetesStorageClassRestoreCriteria : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SelectedStorageClassName))
            {
                writer.WritePropertyName("selectedStorageClassName");
                writer.WriteStringValue(SelectedStorageClassName);
            }
            if (Optional.IsDefined(Provisioner))
            {
                writer.WritePropertyName("provisioner");
                writer.WriteStringValue(Provisioner);
            }
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static KubernetesStorageClassRestoreCriteria DeserializeKubernetesStorageClassRestoreCriteria(JsonElement element)
        {
            Optional<string> selectedStorageClassName = default;
            Optional<string> provisioner = default;
            string objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedStorageClassName"))
                {
                    selectedStorageClassName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioner"))
                {
                    provisioner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new KubernetesStorageClassRestoreCriteria(objectType, selectedStorageClassName.Value, provisioner.Value);
        }
    }
}
