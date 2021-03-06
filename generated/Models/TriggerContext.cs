// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace DataProtectionPlugin.Models
{
    /// <summary> Contains the context of a backup trigger - whether it is event based, ad-hoc, etc. </summary>
    public partial class TriggerContext
    {
        /// <summary> Initializes a new instance of TriggerContext. </summary>
        public TriggerContext()
        {
        }

        /// <summary> Initializes a new instance of TriggerContext. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        internal TriggerContext(string objectType)
        {
            ObjectType = objectType;
        }

        /// <summary> Type of the specific object - used for deserializing. </summary>
        internal string ObjectType { get; set; }
    }
}
