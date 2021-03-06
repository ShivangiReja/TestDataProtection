// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace DataProtectionPlugin.Models
{
    /// <summary> Parameters for Operational-Tier DataStore. </summary>
    public partial class AzureOperationalStoreParameters : DataStoreParameters
    {
        /// <summary> Initializes a new instance of AzureOperationalStoreParameters. </summary>
        /// <param name="dataStoreType"> type of datastore; SnapShot/Hot/Archive. </param>
        public AzureOperationalStoreParameters(DataStoreTypes dataStoreType) : base(dataStoreType)
        {
            ObjectType = "AzureOperationalStoreParameters";
        }

        /// <summary> Initializes a new instance of AzureOperationalStoreParameters. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="dataStoreType"> type of datastore; SnapShot/Hot/Archive. </param>
        /// <param name="resourceGroupId"> Gets or sets the Resource Group Uri. </param>
        internal AzureOperationalStoreParameters(string objectType, DataStoreTypes dataStoreType, string resourceGroupId) : base(objectType, dataStoreType)
        {
            ResourceGroupId = resourceGroupId;
            ObjectType = objectType ?? "AzureOperationalStoreParameters";
        }

        /// <summary> Gets or sets the Resource Group Uri. </summary>
        public string ResourceGroupId { get; set; }
    }
}
