// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace DataProtectionPlugin.Models
{
    /// <summary> Class used for Kubernetes Storage Class Restore Criteria. </summary>
    public partial class KubernetesStorageClassRestoreCriteria : ItemLevelRestoreCriteria
    {
        /// <summary> Initializes a new instance of KubernetesStorageClassRestoreCriteria. </summary>
        public KubernetesStorageClassRestoreCriteria()
        {
            ObjectType = "KubernetesStorageClassRestoreCriteria";
        }

        /// <summary> Initializes a new instance of KubernetesStorageClassRestoreCriteria. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="selectedStorageClassName"> selected storage class name. </param>
        /// <param name="provisioner"> provisioner for the kubernetes resource. </param>
        internal KubernetesStorageClassRestoreCriteria(string objectType, string selectedStorageClassName, string provisioner) : base(objectType)
        {
            SelectedStorageClassName = selectedStorageClassName;
            Provisioner = provisioner;
            ObjectType = objectType ?? "KubernetesStorageClassRestoreCriteria";
        }

        /// <summary> selected storage class name. </summary>
        public string SelectedStorageClassName { get; set; }
        /// <summary> provisioner for the kubernetes resource. </summary>
        public string Provisioner { get; set; }
    }
}
