// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Personalizer
{
    /// <summary> Learning Modes for Personalizer. </summary>
    public readonly partial struct PersonalizerLearningMode : IEquatable<PersonalizerLearningMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PersonalizerLearningMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PersonalizerLearningMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnlineValue = "Online";
        private const string ApprenticeValue = "Apprentice";
        private const string LoggingOnlyValue = "LoggingOnly";

        /// <summary> Online. </summary>
        public static PersonalizerLearningMode Online { get; } = new PersonalizerLearningMode(OnlineValue);
        /// <summary> Apprentice. </summary>
        public static PersonalizerLearningMode Apprentice { get; } = new PersonalizerLearningMode(ApprenticeValue);
        /// <summary> LoggingOnly. </summary>
        public static PersonalizerLearningMode LoggingOnly { get; } = new PersonalizerLearningMode(LoggingOnlyValue);
        /// <summary> Determines if two <see cref="PersonalizerLearningMode"/> values are the same. </summary>
        public static bool operator ==(PersonalizerLearningMode left, PersonalizerLearningMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PersonalizerLearningMode"/> values are not the same. </summary>
        public static bool operator !=(PersonalizerLearningMode left, PersonalizerLearningMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PersonalizerLearningMode"/>. </summary>
        public static implicit operator PersonalizerLearningMode(string value) => new PersonalizerLearningMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PersonalizerLearningMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PersonalizerLearningMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
