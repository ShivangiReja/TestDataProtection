// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace DataProtectionPlugin.Models
{
    public partial class UpdateProtectionRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DatasourceSet))
            {
                writer.WritePropertyName("datasourceSet");
                writer.WriteObjectValue(DatasourceSet);
            }
            writer.WritePropertyName("datasource");
            writer.WriteObjectValue(Datasource);
            writer.WritePropertyName("backupSettings");
            writer.WriteObjectValue(BackupSettings);
            if (Optional.IsDefined(JobLibraryInitializationParams))
            {
                writer.WritePropertyName("jobLibraryInitializationParams");
                writer.WriteStringValue(JobLibraryInitializationParams);
            }
            if (Optional.IsDefined(DatasourceAccessToken))
            {
                writer.WritePropertyName("datasourceAccessToken");
                writer.WriteObjectValue(DatasourceAccessToken);
            }
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
            writer.WriteEndObject();
        }

        internal static UpdateProtectionRequest DeserializeUpdateProtectionRequest(JsonElement element)
        {
            Optional<DatasourceSet> datasourceSet = default;
            Datasource datasource = default;
            BackupSettings backupSettings = default;
            Optional<string> jobLibraryInitializationParams = default;
            Optional<DatasourceTokens> datasourceAccessToken = default;
            Optional<IDictionary<string, string>> additionalProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datasourceSet"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    datasourceSet = DatasourceSet.DeserializeDatasourceSet(property.Value);
                    continue;
                }
                if (property.NameEquals("datasource"))
                {
                    datasource = Datasource.DeserializeDatasource(property.Value);
                    continue;
                }
                if (property.NameEquals("backupSettings"))
                {
                    backupSettings = BackupSettings.DeserializeBackupSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("jobLibraryInitializationParams"))
                {
                    jobLibraryInitializationParams = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datasourceAccessToken"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    datasourceAccessToken = DatasourceTokens.DeserializeDatasourceTokens(property.Value);
                    continue;
                }
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
            }
            return new UpdateProtectionRequest(jobLibraryInitializationParams.Value, datasourceAccessToken.Value, Optional.ToDictionary(additionalProperties), datasourceSet.Value, datasource, backupSettings);
        }
    }
}
