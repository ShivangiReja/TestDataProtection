// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace DataProtectionPlugin.Models
{
    /// <summary> CommitOrRollbackBackupStatus for the failed or cancelled CommitOrRollbackBackup operation. </summary>
    public partial class FailedOrCancelledCommitOrRollbackBackupStatus : CommitOrRollbackBackupStatus
    {
        /// <summary> Initializes a new instance of FailedOrCancelledCommitOrRollbackBackupStatus. </summary>
        public FailedOrCancelledCommitOrRollbackBackupStatus()
        {
        }

        /// <summary> Initializes a new instance of FailedOrCancelledCommitOrRollbackBackupStatus. </summary>
        /// <param name="additionalProperties"> Any additional properties that should be returned along with this operation. </param>
        /// <param name="telemetryData"> Additional Json Serialized Telemetry data from the Plugin. This would be logged with BA Telemetry. </param>
        /// <param name="retryAfterOnRetryableErrorInSeconds"> If Plugin terminates with a retryable ErrorCode, it can set this value in Seconds for BA to retry after this. </param>
        /// <param name="datasourceSizeInBytes"> Size of datasource in bytes. </param>
        /// <param name="dataTransferredInBytes"> Size of data transferred as part of backup. </param>
        /// <param name="error"> Embedded Error Object. </param>
        internal FailedOrCancelledCommitOrRollbackBackupStatus(IDictionary<string, string> additionalProperties, string telemetryData, int? retryAfterOnRetryableErrorInSeconds, long? datasourceSizeInBytes, long? dataTransferredInBytes, Error error) : base(additionalProperties, telemetryData, retryAfterOnRetryableErrorInSeconds, datasourceSizeInBytes, dataTransferredInBytes)
        {
            Error = error;
        }

        /// <summary> Embedded Error Object. </summary>
        public Error Error { get; set; }
    }
}
