// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace DataProtectionPlugin.Models
{
    /// <summary> Information of Datastore. </summary>
    public partial class DataStoreInfo
    {
        /// <summary> Initializes a new instance of DataStoreInfo. </summary>
        /// <param name="dataStoreName"> Name of DataStore. </param>
        /// <param name="dataStoreId"> UniqueId of DataStore. </param>
        /// <param name="dataStoreURL"> endpoint url of datastore. </param>
        /// <param name="objectType"> Type of Datasource object, used to initialize the right inherited type. </param>
        /// <param name="dataStoreType"> type of datastore; SnapShot/Hot/Archive. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataStoreName"/>, <paramref name="dataStoreId"/>, <paramref name="dataStoreURL"/> or <paramref name="objectType"/> is null. </exception>
        public DataStoreInfo(string dataStoreName, string dataStoreId, string dataStoreURL, string objectType, DataStoreTypes dataStoreType)
        {
            if (dataStoreName == null)
            {
                throw new ArgumentNullException(nameof(dataStoreName));
            }
            if (dataStoreId == null)
            {
                throw new ArgumentNullException(nameof(dataStoreId));
            }
            if (dataStoreURL == null)
            {
                throw new ArgumentNullException(nameof(dataStoreURL));
            }
            if (objectType == null)
            {
                throw new ArgumentNullException(nameof(objectType));
            }

            DataStoreName = dataStoreName;
            DataStoreId = dataStoreId;
            DataStoreURL = dataStoreURL;
            ObjectType = objectType;
            DataStoreType = dataStoreType;
        }

        /// <summary> Initializes a new instance of DataStoreInfo. </summary>
        /// <param name="dataStoreName"> Name of DataStore. </param>
        /// <param name="dataStoreId"> UniqueId of DataStore. </param>
        /// <param name="dataStoreURL"> endpoint url of datastore. </param>
        /// <param name="storageTypeFlags"> Type of storage to be used for storing backup data. Passed as input to datastore. </param>
        /// <param name="authorizationTypeFlags"> Type of storage to be used for storing backup data. Passed as input to datastore. </param>
        /// <param name="objectType"> Type of Datasource object, used to initialize the right inherited type. </param>
        /// <param name="dataStoreType"> type of datastore; SnapShot/Hot/Archive. </param>
        internal DataStoreInfo(string dataStoreName, string dataStoreId, string dataStoreURL, string storageTypeFlags, string authorizationTypeFlags, string objectType, DataStoreTypes dataStoreType)
        {
            DataStoreName = dataStoreName;
            DataStoreId = dataStoreId;
            DataStoreURL = dataStoreURL;
            StorageTypeFlags = storageTypeFlags;
            AuthorizationTypeFlags = authorizationTypeFlags;
            ObjectType = objectType;
            DataStoreType = dataStoreType;
        }

        /// <summary> Name of DataStore. </summary>
        public string DataStoreName { get; set; }
        /// <summary> UniqueId of DataStore. </summary>
        public string DataStoreId { get; set; }
        /// <summary> endpoint url of datastore. </summary>
        public string DataStoreURL { get; set; }
        /// <summary> Type of storage to be used for storing backup data. Passed as input to datastore. </summary>
        public string StorageTypeFlags { get; set; }
        /// <summary> Type of storage to be used for storing backup data. Passed as input to datastore. </summary>
        public string AuthorizationTypeFlags { get; set; }
        /// <summary> Type of Datasource object, used to initialize the right inherited type. </summary>
        public string ObjectType { get; set; }
        /// <summary> type of datastore; SnapShot/Hot/Archive. </summary>
        public DataStoreTypes DataStoreType { get; set; }
    }
}