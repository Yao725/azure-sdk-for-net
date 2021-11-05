// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Azurestackhci.Models
{
    /// <summary> Desired state of Windows Server Subscription. </summary>
    public readonly partial struct WindowsServerSubscription : IEquatable<WindowsServerSubscription>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WindowsServerSubscription"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WindowsServerSubscription(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static WindowsServerSubscription Disabled { get; } = new WindowsServerSubscription(DisabledValue);
        /// <summary> Enabled. </summary>
        public static WindowsServerSubscription Enabled { get; } = new WindowsServerSubscription(EnabledValue);
        /// <summary> Determines if two <see cref="WindowsServerSubscription"/> values are the same. </summary>
        public static bool operator ==(WindowsServerSubscription left, WindowsServerSubscription right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WindowsServerSubscription"/> values are not the same. </summary>
        public static bool operator !=(WindowsServerSubscription left, WindowsServerSubscription right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WindowsServerSubscription"/>. </summary>
        public static implicit operator WindowsServerSubscription(string value) => new WindowsServerSubscription(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WindowsServerSubscription other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WindowsServerSubscription other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
