// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace DataProtectionPlugin.Models
{
    /// <summary> Backup Parameters that need to be sent for plugin. </summary>
    public partial class AzureBackupParamsForPlugin : AzureBackupParams
    {
        /// <summary> Initializes a new instance of AzureBackupParamsForPlugin. </summary>
        /// <param name="backupType"> BackupType ; Full/Incremental etc. </param>
        /// <param name="retentionTag"> Retention tag that the backup must be marked with. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupType"/> or <paramref name="retentionTag"/> is null. </exception>
        public AzureBackupParamsForPlugin(string backupType, RetentionTag retentionTag) : base(backupType)
        {
            if (backupType == null)
            {
                throw new ArgumentNullException(nameof(backupType));
            }
            if (retentionTag == null)
            {
                throw new ArgumentNullException(nameof(retentionTag));
            }

            RetentionTag = retentionTag;
            ObjectType = "AzureBackupParamsForPlugin";
        }

        /// <summary> Initializes a new instance of AzureBackupParamsForPlugin. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="backupType"> BackupType ; Full/Incremental etc. </param>
        /// <param name="retentionTag"> Retention tag that the backup must be marked with. </param>
        /// <param name="policyInfo"> Policy Info that is required while creating the pit by plugin. </param>
        /// <param name="policyParameters"> BackupInstance policy-parameters containing DataStore parameters etc. </param>
        /// <param name="triggerType"> Trigger Type ? Adhoc/Scheduled/Custom event etc. </param>
        /// <param name="autoHealSettings"> Setting for autoHeal. </param>
        internal AzureBackupParamsForPlugin(string objectType, string backupType, RetentionTag retentionTag, PolicyInfo policyInfo, PolicyParameters policyParameters, TriggerType? triggerType, AutoHealSettings autoHealSettings) : base(objectType, backupType)
        {
            RetentionTag = retentionTag;
            PolicyInfo = policyInfo;
            PolicyParameters = policyParameters;
            TriggerType = triggerType;
            AutoHealSettings = autoHealSettings;
            ObjectType = objectType ?? "AzureBackupParamsForPlugin";
        }

        /// <summary> Retention tag that the backup must be marked with. </summary>
        public RetentionTag RetentionTag { get; set; }
        /// <summary> Policy Info that is required while creating the pit by plugin. </summary>
        public PolicyInfo PolicyInfo { get; set; }
        /// <summary> BackupInstance policy-parameters containing DataStore parameters etc. </summary>
        public PolicyParameters PolicyParameters { get; set; }
        /// <summary> Trigger Type ? Adhoc/Scheduled/Custom event etc. </summary>
        public TriggerType? TriggerType { get; set; }
        /// <summary> Setting for autoHeal. </summary>
        public AutoHealSettings AutoHealSettings { get; set; }
    }
}
