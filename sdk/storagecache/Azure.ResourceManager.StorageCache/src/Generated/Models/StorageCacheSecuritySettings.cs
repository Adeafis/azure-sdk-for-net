// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Cache security settings. </summary>
    internal partial class StorageCacheSecuritySettings
    {
        /// <summary> Initializes a new instance of <see cref="StorageCacheSecuritySettings"/>. </summary>
        public StorageCacheSecuritySettings()
        {
            AccessPolicies = new ChangeTrackingList<NfsAccessPolicy>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheSecuritySettings"/>. </summary>
        /// <param name="accessPolicies"> NFS access policies defined for this cache. </param>
        internal StorageCacheSecuritySettings(IList<NfsAccessPolicy> accessPolicies)
        {
            AccessPolicies = accessPolicies;
        }

        /// <summary> NFS access policies defined for this cache. </summary>
        public IList<NfsAccessPolicy> AccessPolicies { get; }
    }
}
