// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxConfigurationPackage. </summary>
    public partial class NginxConfigurationPackage
    {
        /// <summary> Initializes a new instance of <see cref="NginxConfigurationPackage"/>. </summary>
        public NginxConfigurationPackage()
        {
            ProtectedFiles = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NginxConfigurationPackage"/>. </summary>
        /// <param name="data"></param>
        /// <param name="protectedFiles"></param>
        internal NginxConfigurationPackage(string data, IList<string> protectedFiles)
        {
            Data = data;
            ProtectedFiles = protectedFiles;
        }

        /// <summary> Gets or sets the data. </summary>
        public string Data { get; set; }
        /// <summary> Gets the protected files. </summary>
        public IList<string> ProtectedFiles { get; }
    }
}
