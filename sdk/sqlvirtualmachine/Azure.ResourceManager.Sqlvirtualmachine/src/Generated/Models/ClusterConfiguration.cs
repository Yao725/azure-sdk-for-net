// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sqlvirtualmachine.Models
{
    /// <summary> Cluster type. </summary>
    public readonly partial struct ClusterConfiguration : IEquatable<ClusterConfiguration>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterConfiguration"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterConfiguration(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DomainfulValue = "Domainful";

        /// <summary> Domainful. </summary>
        public static ClusterConfiguration Domainful { get; } = new ClusterConfiguration(DomainfulValue);
        /// <summary> Determines if two <see cref="ClusterConfiguration"/> values are the same. </summary>
        public static bool operator ==(ClusterConfiguration left, ClusterConfiguration right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterConfiguration"/> values are not the same. </summary>
        public static bool operator !=(ClusterConfiguration left, ClusterConfiguration right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClusterConfiguration"/>. </summary>
        public static implicit operator ClusterConfiguration(string value) => new ClusterConfiguration(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterConfiguration other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterConfiguration other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
