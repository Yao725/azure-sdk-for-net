// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sqlvirtualmachine.Models
{
    /// <summary> SQL image sku. </summary>
    public readonly partial struct SqlVmGroupImageSku : IEquatable<SqlVmGroupImageSku>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SqlVmGroupImageSku"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlVmGroupImageSku(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeveloperValue = "Developer";
        private const string EnterpriseValue = "Enterprise";

        /// <summary> Developer. </summary>
        public static SqlVmGroupImageSku Developer { get; } = new SqlVmGroupImageSku(DeveloperValue);
        /// <summary> Enterprise. </summary>
        public static SqlVmGroupImageSku Enterprise { get; } = new SqlVmGroupImageSku(EnterpriseValue);
        /// <summary> Determines if two <see cref="SqlVmGroupImageSku"/> values are the same. </summary>
        public static bool operator ==(SqlVmGroupImageSku left, SqlVmGroupImageSku right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlVmGroupImageSku"/> values are not the same. </summary>
        public static bool operator !=(SqlVmGroupImageSku left, SqlVmGroupImageSku right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlVmGroupImageSku"/>. </summary>
        public static implicit operator SqlVmGroupImageSku(string value) => new SqlVmGroupImageSku(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlVmGroupImageSku other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlVmGroupImageSku other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
