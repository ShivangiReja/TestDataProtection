// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace DataProtectionPlugin.Models
{
    /// <summary> Tokens to be sent by Backup Agent to plugin host. </summary>
    public partial class DatasourceTokens
    {
        /// <summary> Initializes a new instance of DatasourceTokens. </summary>
        public DatasourceTokens()
        {
        }

        /// <summary> Initializes a new instance of DatasourceTokens. </summary>
        /// <param name="dataPlaneToken"> Token associated with accessing the data plane of datasource. </param>
        /// <param name="mgmtPlaneToken"> Access token for the Datasource  management plane. This is an MSI token (in almost all cases). </param>
        /// <param name="dataPlanePrincipalId"> PrincipalId of the identity which is providing DataPlaneToken. </param>
        /// <param name="mgmtPlanePrincipalId"> PrincipalId of the identity which is providing DataPlaneToken. Typically Vault MSI PrincipalId. </param>
        /// <param name="dataPlaneTokenType"> Gets or sets the type of DataPlaneToken. One of values defined in enum DataPlaneTokenType. </param>
        internal DatasourceTokens(string dataPlaneToken, string mgmtPlaneToken, string dataPlanePrincipalId, string mgmtPlanePrincipalId, string dataPlaneTokenType)
        {
            DataPlaneToken = dataPlaneToken;
            MgmtPlaneToken = mgmtPlaneToken;
            DataPlanePrincipalId = dataPlanePrincipalId;
            MgmtPlanePrincipalId = mgmtPlanePrincipalId;
            DataPlaneTokenType = dataPlaneTokenType;
        }

        /// <summary> Token associated with accessing the data plane of datasource. </summary>
        public string DataPlaneToken { get; set; }
        /// <summary> Access token for the Datasource  management plane. This is an MSI token (in almost all cases). </summary>
        public string MgmtPlaneToken { get; set; }
        /// <summary> PrincipalId of the identity which is providing DataPlaneToken. </summary>
        public string DataPlanePrincipalId { get; set; }
        /// <summary> PrincipalId of the identity which is providing DataPlaneToken. Typically Vault MSI PrincipalId. </summary>
        public string MgmtPlanePrincipalId { get; set; }
        /// <summary> Gets or sets the type of DataPlaneToken. One of values defined in enum DataPlaneTokenType. </summary>
        public string DataPlaneTokenType { get; set; }
    }
}
