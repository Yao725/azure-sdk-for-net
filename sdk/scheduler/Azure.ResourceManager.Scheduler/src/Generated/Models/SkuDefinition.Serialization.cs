// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Scheduler.Models
{
    internal static partial class SkuDefinitionExtensions
    {
        public static string ToSerialString(this SkuDefinition value) => value switch
        {
            SkuDefinition.Standard => "Standard",
            SkuDefinition.Free => "Free",
            SkuDefinition.P10Premium => "P10Premium",
            SkuDefinition.P20Premium => "P20Premium",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SkuDefinition value.")
        };

        public static SkuDefinition ToSkuDefinition(this string value)
        {
            if (string.Equals(value, "Standard", StringComparison.InvariantCultureIgnoreCase)) return SkuDefinition.Standard;
            if (string.Equals(value, "Free", StringComparison.InvariantCultureIgnoreCase)) return SkuDefinition.Free;
            if (string.Equals(value, "P10Premium", StringComparison.InvariantCultureIgnoreCase)) return SkuDefinition.P10Premium;
            if (string.Equals(value, "P20Premium", StringComparison.InvariantCultureIgnoreCase)) return SkuDefinition.P20Premium;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SkuDefinition value.");
        }
    }
}
