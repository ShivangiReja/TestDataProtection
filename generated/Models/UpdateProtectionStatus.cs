// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace DataProtectionPlugin.Models
{
    /// <summary> UpdateProtectionStatus for the Update Protection operation. </summary>
    public partial class UpdateProtectionStatus : BaseStatus
    {
        /// <summary> Initializes a new instance of UpdateProtectionStatus. </summary>
        public UpdateProtectionStatus()
        {
        }

        /// <summary> Initializes a new instance of UpdateProtectionStatus. </summary>
        /// <param name="additionalProperties"> Any additional properties that should be returned along with this operation. </param>
        /// <param name="telemetryData"> Additional Json Serialized Telemetry data from the Plugin. This would be logged with BA Telemetry. </param>
        /// <param name="retryAfterOnRetryableErrorInSeconds"> If Plugin terminates with a retryable ErrorCode, it can set this value in Seconds for BA to retry after this. </param>
        internal UpdateProtectionStatus(IDictionary<string, string> additionalProperties, string telemetryData, int? retryAfterOnRetryableErrorInSeconds) : base(additionalProperties, telemetryData, retryAfterOnRetryableErrorInSeconds)
        {
        }
    }
}
