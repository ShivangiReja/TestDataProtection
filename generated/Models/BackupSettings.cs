// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace DataProtectionPlugin.Models
{
    /// <summary> Settings and rules required to take scheduled/adhoc backups. </summary>
    public partial class BackupSettings
    {
        /// <summary> Initializes a new instance of BackupSettings. </summary>
        /// <param name="dataSourceType"> Type of datasource for the backup management. </param>
        /// <param name="rules"> List of Rules. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceType"/> or <paramref name="rules"/> is null. </exception>
        public BackupSettings(string dataSourceType, IEnumerable<BackupRule> rules)
        {
            if (dataSourceType == null)
            {
                throw new ArgumentNullException(nameof(dataSourceType));
            }
            if (rules == null)
            {
                throw new ArgumentNullException(nameof(rules));
            }

            DataSourceType = dataSourceType;
            Rules = rules.ToList();
        }

        /// <summary> Initializes a new instance of BackupSettings. </summary>
        /// <param name="dataSourceType"> Type of datasource for the backup management. </param>
        /// <param name="rules"> List of Rules. </param>
        /// <param name="rawJsonSetting"> this is optional raw json opaque setting for the datasource where mgmt does not understand the backup policy/setting. </param>
        /// <param name="policyName"> Name of the policy used for this backup instance. </param>
        /// <param name="policyParameters"> Policy parameters for the backup instance. </param>
        /// <param name="objectType"> Type of Datasource object, used to initialize the right inherited type. </param>
        internal BackupSettings(string dataSourceType, IList<BackupRule> rules, string rawJsonSetting, string policyName, PolicyParameters policyParameters, string objectType)
        {
            DataSourceType = dataSourceType;
            Rules = rules;
            RawJsonSetting = rawJsonSetting;
            PolicyName = policyName;
            PolicyParameters = policyParameters;
            ObjectType = objectType;
        }

        /// <summary> Type of datasource for the backup management. </summary>
        public string DataSourceType { get; set; }
        /// <summary> List of Rules. </summary>
        public IList<BackupRule> Rules { get; }
        /// <summary> this is optional raw json opaque setting for the datasource where mgmt does not understand the backup policy/setting. </summary>
        public string RawJsonSetting { get; set; }
        /// <summary> Name of the policy used for this backup instance. </summary>
        public string PolicyName { get; set; }
        /// <summary> Policy parameters for the backup instance. </summary>
        public PolicyParameters PolicyParameters { get; set; }
        /// <summary> Type of Datasource object, used to initialize the right inherited type. </summary>
        public string ObjectType { get; set; }
    }
}