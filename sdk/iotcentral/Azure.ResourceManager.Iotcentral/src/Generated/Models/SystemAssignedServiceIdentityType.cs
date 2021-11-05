// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Iotcentral.Models
{
    /// <summary> Type of managed service identity (either system assigned, or none). </summary>
    public readonly partial struct SystemAssignedServiceIdentityType : IEquatable<SystemAssignedServiceIdentityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SystemAssignedServiceIdentityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SystemAssignedServiceIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string SystemAssignedValue = "SystemAssigned";

        /// <summary> None. </summary>
        public static SystemAssignedServiceIdentityType None { get; } = new SystemAssignedServiceIdentityType(NoneValue);
        /// <summary> SystemAssigned. </summary>
        public static SystemAssignedServiceIdentityType SystemAssigned { get; } = new SystemAssignedServiceIdentityType(SystemAssignedValue);
        /// <summary> Determines if two <see cref="SystemAssignedServiceIdentityType"/> values are the same. </summary>
        public static bool operator ==(SystemAssignedServiceIdentityType left, SystemAssignedServiceIdentityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SystemAssignedServiceIdentityType"/> values are not the same. </summary>
        public static bool operator !=(SystemAssignedServiceIdentityType left, SystemAssignedServiceIdentityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SystemAssignedServiceIdentityType"/>. </summary>
        public static implicit operator SystemAssignedServiceIdentityType(string value) => new SystemAssignedServiceIdentityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SystemAssignedServiceIdentityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SystemAssignedServiceIdentityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
