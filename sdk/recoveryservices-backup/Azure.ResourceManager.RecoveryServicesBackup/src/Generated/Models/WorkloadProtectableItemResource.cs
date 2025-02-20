// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Base class for backup item. Workload-specific backup items are derived from this class. </summary>
    public partial class WorkloadProtectableItemResource : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="WorkloadProtectableItemResource"/>. </summary>
        /// <param name="location"> The location. </param>
        public WorkloadProtectableItemResource(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadProtectableItemResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties">
        /// WorkloadProtectableItemResource properties
        /// Please note <see cref="WorkloadProtectableItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FileShareProtectableItem"/>, <see cref="VmWorkloadProtectableItem"/>, <see cref="VmWorkloadSapHanaHsrProtectableItem"/>, <see cref="IaasVmProtectableItem"/>, <see cref="IaasClassicComputeVmProtectableItem"/>, <see cref="IaasComputeVmProtectableItem"/>, <see cref="VmWorkloadSapAseSystemProtectableItem"/>, <see cref="VmWorkloadSapHanaDBInstance"/>, <see cref="VmWorkloadSapHanaDatabaseProtectableItem"/>, <see cref="VmWorkloadSapHanaSystemProtectableItem"/>, <see cref="VmWorkloadSqlAvailabilityGroupProtectableItem"/>, <see cref="VmWorkloadSqlDatabaseProtectableItem"/> and <see cref="VmWorkloadSqlInstanceProtectableItem"/>.
        /// </param>
        /// <param name="eTag"> Optional ETag. </param>
        internal WorkloadProtectableItemResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, WorkloadProtectableItem properties, ETag? eTag) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ETag = eTag;
        }

        /// <summary>
        /// WorkloadProtectableItemResource properties
        /// Please note <see cref="WorkloadProtectableItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FileShareProtectableItem"/>, <see cref="VmWorkloadProtectableItem"/>, <see cref="VmWorkloadSapHanaHsrProtectableItem"/>, <see cref="IaasVmProtectableItem"/>, <see cref="IaasClassicComputeVmProtectableItem"/>, <see cref="IaasComputeVmProtectableItem"/>, <see cref="VmWorkloadSapAseSystemProtectableItem"/>, <see cref="VmWorkloadSapHanaDBInstance"/>, <see cref="VmWorkloadSapHanaDatabaseProtectableItem"/>, <see cref="VmWorkloadSapHanaSystemProtectableItem"/>, <see cref="VmWorkloadSqlAvailabilityGroupProtectableItem"/>, <see cref="VmWorkloadSqlDatabaseProtectableItem"/> and <see cref="VmWorkloadSqlInstanceProtectableItem"/>.
        /// </summary>
        public WorkloadProtectableItem Properties { get; set; }
        /// <summary> Optional ETag. </summary>
        public ETag? ETag { get; set; }
    }
}
