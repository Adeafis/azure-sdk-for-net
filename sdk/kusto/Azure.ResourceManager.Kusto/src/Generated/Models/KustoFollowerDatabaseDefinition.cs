// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> A class representing follower database request. </summary>
    public partial class KustoFollowerDatabaseDefinition
    {
        /// <summary> Initializes a new instance of <see cref="KustoFollowerDatabaseDefinition"/>. </summary>
        /// <param name="clusterResourceId"> Resource id of the cluster that follows a database owned by this cluster. </param>
        /// <param name="attachedDatabaseConfigurationName"> Resource name of the attached database configuration in the follower cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterResourceId"/> or <paramref name="attachedDatabaseConfigurationName"/> is null. </exception>
        public KustoFollowerDatabaseDefinition(ResourceIdentifier clusterResourceId, string attachedDatabaseConfigurationName)
        {
            Argument.AssertNotNull(clusterResourceId, nameof(clusterResourceId));
            Argument.AssertNotNull(attachedDatabaseConfigurationName, nameof(attachedDatabaseConfigurationName));

            ClusterResourceId = clusterResourceId;
            AttachedDatabaseConfigurationName = attachedDatabaseConfigurationName;
        }

        /// <summary> Initializes a new instance of <see cref="KustoFollowerDatabaseDefinition"/>. </summary>
        /// <param name="clusterResourceId"> Resource id of the cluster that follows a database owned by this cluster. </param>
        /// <param name="attachedDatabaseConfigurationName"> Resource name of the attached database configuration in the follower cluster. </param>
        /// <param name="databaseName"> The database name owned by this cluster that was followed. * in case following all databases. </param>
        /// <param name="tableLevelSharingProperties"> Table level sharing specifications. </param>
        /// <param name="databaseShareOrigin"> The origin of the following setup. </param>
        internal KustoFollowerDatabaseDefinition(ResourceIdentifier clusterResourceId, string attachedDatabaseConfigurationName, string databaseName, KustoDatabaseTableLevelSharingProperties tableLevelSharingProperties, KustoDatabaseShareOrigin? databaseShareOrigin)
        {
            ClusterResourceId = clusterResourceId;
            AttachedDatabaseConfigurationName = attachedDatabaseConfigurationName;
            DatabaseName = databaseName;
            TableLevelSharingProperties = tableLevelSharingProperties;
            DatabaseShareOrigin = databaseShareOrigin;
        }

        /// <summary> Resource id of the cluster that follows a database owned by this cluster. </summary>
        public ResourceIdentifier ClusterResourceId { get; set; }
        /// <summary> Resource name of the attached database configuration in the follower cluster. </summary>
        public string AttachedDatabaseConfigurationName { get; set; }
        /// <summary> The database name owned by this cluster that was followed. * in case following all databases. </summary>
        public string DatabaseName { get; }
        /// <summary> Table level sharing specifications. </summary>
        public KustoDatabaseTableLevelSharingProperties TableLevelSharingProperties { get; }
        /// <summary> The origin of the following setup. </summary>
        public KustoDatabaseShareOrigin? DatabaseShareOrigin { get; }
    }
}
