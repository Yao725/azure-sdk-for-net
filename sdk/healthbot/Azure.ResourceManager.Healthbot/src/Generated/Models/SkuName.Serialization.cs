// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Healthbot.Models
{
    internal static partial class SkuNameExtensions
    {
        public static string ToSerialString(this SkuName value) => value switch
        {
            SkuName.F0 => "F0",
            SkuName.S1 => "S1",
            SkuName.C0 => "C0",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SkuName value.")
        };

        public static SkuName ToSkuName(this string value)
        {
            if (string.Equals(value, "F0", StringComparison.InvariantCultureIgnoreCase)) return SkuName.F0;
            if (string.Equals(value, "S1", StringComparison.InvariantCultureIgnoreCase)) return SkuName.S1;
            if (string.Equals(value, "C0", StringComparison.InvariantCultureIgnoreCase)) return SkuName.C0;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SkuName value.");
        }
    }
}
