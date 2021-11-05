// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Extendedlocation.Models
{
    /// <summary> Type of host the Custom Locations is referencing (Kubernetes, etc...). </summary>
    public readonly partial struct HostType : IEquatable<HostType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HostType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HostType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KubernetesValue = "Kubernetes";

        /// <summary> Kubernetes. </summary>
        public static HostType Kubernetes { get; } = new HostType(KubernetesValue);
        /// <summary> Determines if two <see cref="HostType"/> values are the same. </summary>
        public static bool operator ==(HostType left, HostType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HostType"/> values are not the same. </summary>
        public static bool operator !=(HostType left, HostType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HostType"/>. </summary>
        public static implicit operator HostType(string value) => new HostType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HostType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HostType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
