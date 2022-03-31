// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace DataProtectionPlugin.Models
{
    /// <summary> Plugin&apos;s Status for validate for restore request. </summary>
    public partial class ValidateForRestoreStatus : BaseStatus
    {
        /// <summary> Initializes a new instance of ValidateForRestoreStatus. </summary>
        public ValidateForRestoreStatus()
        {
        }

        /// <summary> Initializes a new instance of ValidateForRestoreStatus. </summary>
        /// <param name="additionalProperties"> Any additional properties that should be returned along with this operation. </param>
        /// <param name="telemetryData"> Additional Json Serialized Telemetry data from the Plugin. This would be logged with BA Telemetry. </param>
        /// <param name="retryAfterOnRetryableErrorInSeconds"> If Plugin terminates with a retryable ErrorCode, it can set this value in Seconds for BA to retry after this. </param>
        /// <param name="loopBackContext"> Json serialized Loopback Context. </param>
        internal ValidateForRestoreStatus(IDictionary<string, string> additionalProperties, string telemetryData, int? retryAfterOnRetryableErrorInSeconds, string loopBackContext) : base(additionalProperties, telemetryData, retryAfterOnRetryableErrorInSeconds)
        {
            LoopBackContext = loopBackContext;
        }

        /// <summary> Json serialized Loopback Context. </summary>
        public string LoopBackContext { get; set; }
    }
}