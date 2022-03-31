// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace DataProtectionPlugin.Models
{
    public partial class BackupDatasourceParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static BackupDatasourceParameters DeserializeBackupDatasourceParameters(JsonElement element)
        {
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "BlobBackupDatasourceParameters": return BlobBackupDatasourceParameters.DeserializeBlobBackupDatasourceParameters(element);
                }
            }
            string objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new BackupDatasourceParameters(objectType);
        }
    }
}
