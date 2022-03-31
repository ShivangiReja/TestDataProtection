// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace DataProtectionPlugin.Models
{
    /// <summary> BackupRequest for the backup operation. </summary>
    public partial class BackupRequest : BackupRequestBase
    {
        /// <summary> Initializes a new instance of BackupRequest. </summary>
        /// <param name="datasource"> Datasource object. </param>
        /// <param name="rpCatalogInitializeParams"> The dictionary required to initialize the RPCatalog client library. </param>
        /// <param name="datastoreInitializeParams"> The dictionary required to initialize the Datastore client library. </param>
        /// <param name="backupParameters"> List of properties with values that the Backup should honour, for a given BackupRule. Like Tags, Exclusion rules etc. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasource"/>, <paramref name="rpCatalogInitializeParams"/>, <paramref name="datastoreInitializeParams"/> or <paramref name="backupParameters"/> is null. </exception>
        public BackupRequest(Datasource datasource, IDictionary<string, string> rpCatalogInitializeParams, IDictionary<string, string> datastoreInitializeParams, AzureBackupParamsForPlugin backupParameters) : base(datasource, rpCatalogInitializeParams, datastoreInitializeParams, backupParameters)
        {
            if (datasource == null)
            {
                throw new ArgumentNullException(nameof(datasource));
            }
            if (rpCatalogInitializeParams == null)
            {
                throw new ArgumentNullException(nameof(rpCatalogInitializeParams));
            }
            if (datastoreInitializeParams == null)
            {
                throw new ArgumentNullException(nameof(datastoreInitializeParams));
            }
            if (backupParameters == null)
            {
                throw new ArgumentNullException(nameof(backupParameters));
            }
        }

        /// <summary> Initializes a new instance of BackupRequest. </summary>
        /// <param name="jobLibraryInitializationParams"> The initialization params of the Job Client Lib. The plugin needs this to do progress updates on Jobs. </param>
        /// <param name="datasourceAccessToken"> Access token for the Datasource Mgmt and Data plane. This is an MSI token (in almost all cases). </param>
        /// <param name="additionalProperties"> Additional Properties for extensibility. </param>
        /// <param name="datasourceSet"> DatasourceSet object. </param>
        /// <param name="datasource"> Datasource object. </param>
        /// <param name="rpCatalogInitializeParams"> The dictionary required to initialize the RPCatalog client library. </param>
        /// <param name="datastoreInitializeParams"> The dictionary required to initialize the Datastore client library. </param>
        /// <param name="backupParameters"> List of properties with values that the Backup should honour, for a given BackupRule. Like Tags, Exclusion rules etc. </param>
        /// <param name="loopBackContext"> LoopbackContext returned from previous plugin calls, to be sent again. </param>
        internal BackupRequest(string jobLibraryInitializationParams, DatasourceTokens datasourceAccessToken, IDictionary<string, string> additionalProperties, DatasourceSet datasourceSet, Datasource datasource, IDictionary<string, string> rpCatalogInitializeParams, IDictionary<string, string> datastoreInitializeParams, AzureBackupParamsForPlugin backupParameters, string loopBackContext) : base(jobLibraryInitializationParams, datasourceAccessToken, additionalProperties, datasourceSet, datasource, rpCatalogInitializeParams, datastoreInitializeParams, backupParameters)
        {
            LoopBackContext = loopBackContext;
        }

        /// <summary> LoopbackContext returned from previous plugin calls, to be sent again. </summary>
        public string LoopBackContext { get; set; }
    }
}