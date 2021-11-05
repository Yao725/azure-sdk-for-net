// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Iotcentral.Models
{
    /// <summary> The name of the SKU. </summary>
    public readonly partial struct AppSku : IEquatable<AppSku>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppSku"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppSku(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ST0Value = "ST0";
        private const string ST1Value = "ST1";
        private const string ST2Value = "ST2";

        /// <summary> ST0. </summary>
        public static AppSku ST0 { get; } = new AppSku(ST0Value);
        /// <summary> ST1. </summary>
        public static AppSku ST1 { get; } = new AppSku(ST1Value);
        /// <summary> ST2. </summary>
        public static AppSku ST2 { get; } = new AppSku(ST2Value);
        /// <summary> Determines if two <see cref="AppSku"/> values are the same. </summary>
        public static bool operator ==(AppSku left, AppSku right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppSku"/> values are not the same. </summary>
        public static bool operator !=(AppSku left, AppSku right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AppSku"/>. </summary>
        public static implicit operator AppSku(string value) => new AppSku(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppSku other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppSku other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
