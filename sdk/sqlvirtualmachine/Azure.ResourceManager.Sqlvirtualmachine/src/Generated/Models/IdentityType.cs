// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sqlvirtualmachine.Models
{
    /// <summary> The identity type. Set this to &apos;SystemAssigned&apos; in order to automatically create and assign an Azure Active Directory principal for the resource. </summary>
    public readonly partial struct IdentityType : IEquatable<IdentityType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="IdentityType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SystemAssignedValue = "SystemAssigned";

        /// <summary> SystemAssigned. </summary>
        public static IdentityType SystemAssigned { get; } = new IdentityType(SystemAssignedValue);
        /// <summary> Determines if two <see cref="IdentityType"/> values are the same. </summary>
        public static bool operator ==(IdentityType left, IdentityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IdentityType"/> values are not the same. </summary>
        public static bool operator !=(IdentityType left, IdentityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IdentityType"/>. </summary>
        public static implicit operator IdentityType(string value) => new IdentityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IdentityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IdentityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
