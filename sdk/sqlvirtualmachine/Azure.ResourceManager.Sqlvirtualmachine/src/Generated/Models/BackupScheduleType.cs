// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sqlvirtualmachine.Models
{
    /// <summary> Backup schedule type. </summary>
    public readonly partial struct BackupScheduleType : IEquatable<BackupScheduleType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="BackupScheduleType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BackupScheduleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ManualValue = "Manual";
        private const string AutomatedValue = "Automated";

        /// <summary> Manual. </summary>
        public static BackupScheduleType Manual { get; } = new BackupScheduleType(ManualValue);
        /// <summary> Automated. </summary>
        public static BackupScheduleType Automated { get; } = new BackupScheduleType(AutomatedValue);
        /// <summary> Determines if two <see cref="BackupScheduleType"/> values are the same. </summary>
        public static bool operator ==(BackupScheduleType left, BackupScheduleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BackupScheduleType"/> values are not the same. </summary>
        public static bool operator !=(BackupScheduleType left, BackupScheduleType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BackupScheduleType"/>. </summary>
        public static implicit operator BackupScheduleType(string value) => new BackupScheduleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BackupScheduleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BackupScheduleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
