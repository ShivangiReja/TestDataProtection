// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace DataProtectionPlugin.Models
{
    /// <summary> CommitOrRollbackBackupStatus for the CommitOrRollbackBackup operation. </summary>
    public partial class CommitOrRollbackBackupStatus : BaseStatus
    {
        /// <summary> Initializes a new instance of CommitOrRollbackBackupStatus. </summary>
        public CommitOrRollbackBackupStatus()
        {
        }

        /// <summary> Initializes a new instance of CommitOrRollbackBackupStatus. </summary>
        /// <param name="additionalProperties"> Any additional properties that should be returned along with this operation. </param>
        /// <param name="telemetryData"> Additional Json Serialized Telemetry data from the Plugin. This would be logged with BA Telemetry. </param>
        /// <param name="retryAfterOnRetryableErrorInSeconds"> If Plugin terminates with a retryable ErrorCode, it can set this value in Seconds for BA to retry after this. </param>
        /// <param name="datasourceSizeInBytes"> Size of datasource in bytes. </param>
        /// <param name="dataTransferredInBytes"> Size of data transferred as part of backup. </param>
        internal CommitOrRollbackBackupStatus(IDictionary<string, string> additionalProperties, string telemetryData, int? retryAfterOnRetryableErrorInSeconds, long? datasourceSizeInBytes, long? dataTransferredInBytes) : base(additionalProperties, telemetryData, retryAfterOnRetryableErrorInSeconds)
        {
            DatasourceSizeInBytes = datasourceSizeInBytes;
            DataTransferredInBytes = dataTransferredInBytes;
        }

        /// <summary> Size of datasource in bytes. </summary>
        public long? DatasourceSizeInBytes { get; set; }
        /// <summary> Size of data transferred as part of backup. </summary>
        public long? DataTransferredInBytes { get; set; }
    }
}
