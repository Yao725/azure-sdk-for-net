// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations
{
    /// <summary> The entity resolution object kind. </summary>
    public readonly partial struct ResolutionKind : IEquatable<ResolutionKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResolutionKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResolutionKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BooleanValue = "Boolean";
        private const string DateTimeValue = "DateTime";
        private const string NumberValue = "Number";
        private const string OrdinalValue = "Ordinal";
        private const string SpeedValue = "Speed";
        private const string WeightValue = "Weight";
        private const string LengthValue = "Length";
        private const string VolumeValue = "Volume";
        private const string AreaValue = "Area";
        private const string AgeValue = "Age";
        private const string InformationValue = "Information";
        private const string TemperatureValue = "Temperature";
        private const string CurrencyValue = "Currency";
        private const string NumericRangeValue = "NumericRange";
        private const string TemporalSpanValue = "TemporalSpan";

        /// <summary> Boolean. </summary>
        public static ResolutionKind Boolean { get; } = new ResolutionKind(BooleanValue);
        /// <summary> DateTime. </summary>
        public static ResolutionKind DateTime { get; } = new ResolutionKind(DateTimeValue);
        /// <summary> Number. </summary>
        public static ResolutionKind Number { get; } = new ResolutionKind(NumberValue);
        /// <summary> Ordinal. </summary>
        public static ResolutionKind Ordinal { get; } = new ResolutionKind(OrdinalValue);
        /// <summary> Speed. </summary>
        public static ResolutionKind Speed { get; } = new ResolutionKind(SpeedValue);
        /// <summary> Weight. </summary>
        public static ResolutionKind Weight { get; } = new ResolutionKind(WeightValue);
        /// <summary> Length. </summary>
        public static ResolutionKind Length { get; } = new ResolutionKind(LengthValue);
        /// <summary> Volume. </summary>
        public static ResolutionKind Volume { get; } = new ResolutionKind(VolumeValue);
        /// <summary> Area. </summary>
        public static ResolutionKind Area { get; } = new ResolutionKind(AreaValue);
        /// <summary> Age. </summary>
        public static ResolutionKind Age { get; } = new ResolutionKind(AgeValue);
        /// <summary> Information. </summary>
        public static ResolutionKind Information { get; } = new ResolutionKind(InformationValue);
        /// <summary> Temperature. </summary>
        public static ResolutionKind Temperature { get; } = new ResolutionKind(TemperatureValue);
        /// <summary> Currency. </summary>
        public static ResolutionKind Currency { get; } = new ResolutionKind(CurrencyValue);
        /// <summary> NumericRange. </summary>
        public static ResolutionKind NumericRange { get; } = new ResolutionKind(NumericRangeValue);
        /// <summary> TemporalSpan. </summary>
        public static ResolutionKind TemporalSpan { get; } = new ResolutionKind(TemporalSpanValue);
        /// <summary> Determines if two <see cref="ResolutionKind"/> values are the same. </summary>
        public static bool operator ==(ResolutionKind left, ResolutionKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResolutionKind"/> values are not the same. </summary>
        public static bool operator !=(ResolutionKind left, ResolutionKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResolutionKind"/>. </summary>
        public static implicit operator ResolutionKind(string value) => new ResolutionKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResolutionKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResolutionKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
