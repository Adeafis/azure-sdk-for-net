// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class LicenseProfileArmEsuPropertiesWithoutAssignedLicense : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static LicenseProfileArmEsuPropertiesWithoutAssignedLicense DeserializeLicenseProfileArmEsuPropertiesWithoutAssignedLicense(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EsuServerType> serverType = default;
            Optional<EsuEligibility> esuEligibility = default;
            Optional<EsuKeyState> esuKeyState = default;
            Optional<Guid> assignedLicenseImmutableId = default;
            Optional<IReadOnlyList<EsuKey>> esuKeys = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serverType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serverType = new EsuServerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("esuEligibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    esuEligibility = new EsuEligibility(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("esuKeyState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    esuKeyState = new EsuKeyState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assignedLicenseImmutableId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assignedLicenseImmutableId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("esuKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EsuKey> array = new List<EsuKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EsuKey.DeserializeEsuKey(item));
                    }
                    esuKeys = array;
                    continue;
                }
            }
            return new LicenseProfileArmEsuPropertiesWithoutAssignedLicense(Optional.ToNullable(assignedLicenseImmutableId), Optional.ToList(esuKeys), Optional.ToNullable(serverType), Optional.ToNullable(esuEligibility), Optional.ToNullable(esuKeyState));
        }
    }
}
