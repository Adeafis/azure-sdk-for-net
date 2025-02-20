// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Represents an Active Directory administrator. </summary>
    public partial class PostgreSqlFlexibleServerActiveDirectoryAdministratorCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerActiveDirectoryAdministratorCreateOrUpdateContent"/>. </summary>
        public PostgreSqlFlexibleServerActiveDirectoryAdministratorCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerActiveDirectoryAdministratorCreateOrUpdateContent"/>. </summary>
        /// <param name="principalType"> The principal type used to represent the type of Active Directory Administrator. </param>
        /// <param name="principalName"> Active Directory administrator principal name. </param>
        /// <param name="tenantId"> The tenantId of the Active Directory administrator. </param>
        internal PostgreSqlFlexibleServerActiveDirectoryAdministratorCreateOrUpdateContent(PostgreSqlFlexibleServerPrincipalType? principalType, string principalName, Guid? tenantId)
        {
            PrincipalType = principalType;
            PrincipalName = principalName;
            TenantId = tenantId;
        }

        /// <summary> The principal type used to represent the type of Active Directory Administrator. </summary>
        public PostgreSqlFlexibleServerPrincipalType? PrincipalType { get; set; }
        /// <summary> Active Directory administrator principal name. </summary>
        public string PrincipalName { get; set; }
        /// <summary> The tenantId of the Active Directory administrator. </summary>
        public Guid? TenantId { get; set; }
    }
}
