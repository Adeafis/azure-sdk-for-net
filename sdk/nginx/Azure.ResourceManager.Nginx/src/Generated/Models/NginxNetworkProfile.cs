// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxNetworkProfile. </summary>
    public partial class NginxNetworkProfile
    {
        /// <summary> Initializes a new instance of <see cref="NginxNetworkProfile"/>. </summary>
        public NginxNetworkProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NginxNetworkProfile"/>. </summary>
        /// <param name="frontEndIPConfiguration"></param>
        /// <param name="networkInterfaceConfiguration"></param>
        internal NginxNetworkProfile(NginxFrontendIPConfiguration frontEndIPConfiguration, NginxNetworkInterfaceConfiguration networkInterfaceConfiguration)
        {
            FrontEndIPConfiguration = frontEndIPConfiguration;
            NetworkInterfaceConfiguration = networkInterfaceConfiguration;
        }

        /// <summary> Gets or sets the front end ip configuration. </summary>
        public NginxFrontendIPConfiguration FrontEndIPConfiguration { get; set; }
        /// <summary> Gets or sets the network interface configuration. </summary>
        internal NginxNetworkInterfaceConfiguration NetworkInterfaceConfiguration { get; set; }
        /// <summary> Gets or sets the network interface subnet id. </summary>
        public ResourceIdentifier NetworkInterfaceSubnetId
        {
            get => NetworkInterfaceConfiguration is null ? default : NetworkInterfaceConfiguration.SubnetId;
            set
            {
                if (NetworkInterfaceConfiguration is null)
                    NetworkInterfaceConfiguration = new NginxNetworkInterfaceConfiguration();
                NetworkInterfaceConfiguration.SubnetId = value;
            }
        }
    }
}
