// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Analysisservices.Models
{
    internal static partial class ManagedModeExtensions
    {
        public static int ToSerialString(this ManagedMode value) => value switch
        {
            ManagedMode.Zero => 0,
            ManagedMode.One => 1,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ManagedMode value.")
        };

        public static ManagedMode ToManagedMode(this int value)
        {
            if (Equals(value, 0)) return ManagedMode.Zero;
            if (Equals(value, 1)) return ManagedMode.One;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ManagedMode value.");
        }
    }
}
