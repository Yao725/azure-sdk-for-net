// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Virtual Network Rule State. </summary>
    public readonly partial struct VirtualNetworkRuleState : IEquatable<VirtualNetworkRuleState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkRuleState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualNetworkRuleState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InitializingValue = "Initializing";
        private const string InProgressValue = "InProgress";
        private const string ReadyValue = "Ready";
        private const string FailedValue = "Failed";
        private const string DeletingValue = "Deleting";
        private const string UnknownValue = "Unknown";

        /// <summary> Initializing. </summary>
        public static VirtualNetworkRuleState Initializing { get; } = new VirtualNetworkRuleState(InitializingValue);
        /// <summary> InProgress. </summary>
        public static VirtualNetworkRuleState InProgress { get; } = new VirtualNetworkRuleState(InProgressValue);
        /// <summary> Ready. </summary>
        public static VirtualNetworkRuleState Ready { get; } = new VirtualNetworkRuleState(ReadyValue);
        /// <summary> Failed. </summary>
        public static VirtualNetworkRuleState Failed { get; } = new VirtualNetworkRuleState(FailedValue);
        /// <summary> Deleting. </summary>
        public static VirtualNetworkRuleState Deleting { get; } = new VirtualNetworkRuleState(DeletingValue);
        /// <summary> Unknown. </summary>
        public static VirtualNetworkRuleState Unknown { get; } = new VirtualNetworkRuleState(UnknownValue);
        /// <summary> Determines if two <see cref="VirtualNetworkRuleState"/> values are the same. </summary>
        public static bool operator ==(VirtualNetworkRuleState left, VirtualNetworkRuleState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualNetworkRuleState"/> values are not the same. </summary>
        public static bool operator !=(VirtualNetworkRuleState left, VirtualNetworkRuleState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualNetworkRuleState"/>. </summary>
        public static implicit operator VirtualNetworkRuleState(string value) => new VirtualNetworkRuleState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualNetworkRuleState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualNetworkRuleState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
