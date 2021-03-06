// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace DataProtectionPlugin.Models
{
    /// <summary> CommitOrRollbackRestoreStatus for the CommitOrRollbackRestore status. </summary>
    public partial class CommitOrRollbackRestoreStatus : BaseStatus
    {
        /// <summary> Initializes a new instance of CommitOrRollbackRestoreStatus. </summary>
        public CommitOrRollbackRestoreStatus()
        {
        }

        /// <summary> Initializes a new instance of CommitOrRollbackRestoreStatus. </summary>
        /// <param name="additionalProperties"> Any additional properties that should be returned along with this operation. </param>
        /// <param name="telemetryData"> Additional Json Serialized Telemetry data from the Plugin. This would be logged with BA Telemetry. </param>
        /// <param name="retryAfterOnRetryableErrorInSeconds"> If Plugin terminates with a retryable ErrorCode, it can set this value in Seconds for BA to retry after this. </param>
        /// <param name="originalDatasourceSizeInBytes"> Size of original datasource when the backup was created. </param>
        /// <param name="dataTransferredInBytes"> Size of data transferred as part of backup. </param>
        internal CommitOrRollbackRestoreStatus(IDictionary<string, string> additionalProperties, string telemetryData, int? retryAfterOnRetryableErrorInSeconds, long? originalDatasourceSizeInBytes, long? dataTransferredInBytes) : base(additionalProperties, telemetryData, retryAfterOnRetryableErrorInSeconds)
        {
            OriginalDatasourceSizeInBytes = originalDatasourceSizeInBytes;
            DataTransferredInBytes = dataTransferredInBytes;
        }

        /// <summary> Size of original datasource when the backup was created. </summary>
        public long? OriginalDatasourceSizeInBytes { get; set; }
        /// <summary> Size of data transferred as part of backup. </summary>
        public long? DataTransferredInBytes { get; set; }
    }
}
