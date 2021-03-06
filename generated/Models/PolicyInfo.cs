// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace DataProtectionPlugin.Models
{
    /// <summary> Policy Info for the backups. </summary>
    public partial class PolicyInfo
    {
        /// <summary> Initializes a new instance of PolicyInfo. </summary>
        public PolicyInfo()
        {
        }

        /// <summary> Initializes a new instance of PolicyInfo. </summary>
        /// <param name="policyName"> Name of the policy that pit should be tagged with. </param>
        /// <param name="policyVersion"> Version of policy that pit should be tagged with. </param>
        internal PolicyInfo(string policyName, string policyVersion)
        {
            PolicyName = policyName;
            PolicyVersion = policyVersion;
        }

        /// <summary> Name of the policy that pit should be tagged with. </summary>
        public string PolicyName { get; set; }
        /// <summary> Version of policy that pit should be tagged with. </summary>
        public string PolicyVersion { get; set; }
    }
}
