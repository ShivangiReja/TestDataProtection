// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace DataProtectionPlugin.Models
{
    public partial class DataStoreInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dataStoreName");
            writer.WriteStringValue(DataStoreName);
            writer.WritePropertyName("dataStoreId");
            writer.WriteStringValue(DataStoreId);
            writer.WritePropertyName("dataStoreURL");
            writer.WriteStringValue(DataStoreURL);
            if (Optional.IsDefined(StorageTypeFlags))
            {
                writer.WritePropertyName("storageTypeFlags");
                writer.WriteStringValue(StorageTypeFlags);
            }
            if (Optional.IsDefined(AuthorizationTypeFlags))
            {
                writer.WritePropertyName("authorizationTypeFlags");
                writer.WriteStringValue(AuthorizationTypeFlags);
            }
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("dataStoreType");
            writer.WriteStringValue(DataStoreType.ToString());
            writer.WriteEndObject();
        }

        internal static DataStoreInfo DeserializeDataStoreInfo(JsonElement element)
        {
            string dataStoreName = default;
            string dataStoreId = default;
            string dataStoreURL = default;
            Optional<string> storageTypeFlags = default;
            Optional<string> authorizationTypeFlags = default;
            string objectType = default;
            DataStoreTypes dataStoreType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataStoreName"))
                {
                    dataStoreName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataStoreId"))
                {
                    dataStoreId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataStoreURL"))
                {
                    dataStoreURL = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageTypeFlags"))
                {
                    storageTypeFlags = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorizationTypeFlags"))
                {
                    authorizationTypeFlags = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataStoreType"))
                {
                    dataStoreType = new DataStoreTypes(property.Value.GetString());
                    continue;
                }
            }
            return new DataStoreInfo(dataStoreName, dataStoreId, dataStoreURL, storageTypeFlags.Value, authorizationTypeFlags.Value, objectType, dataStoreType);
        }
    }
}
