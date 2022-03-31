// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace DataProtectionPlugin.Models
{
    /// <summary> The AbsoluteMarker. </summary>
    public readonly partial struct AbsoluteMarker : IEquatable<AbsoluteMarker>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AbsoluteMarker"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AbsoluteMarker(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllBackupValue = "AllBackup";
        private const string FirstOfDayValue = "FirstOfDay";
        private const string FirstOfWeekValue = "FirstOfWeek";
        private const string FirstOfMonthValue = "FirstOfMonth";
        private const string FirstOfYearValue = "FirstOfYear";
        private const string InvalidValue = "Invalid";

        /// <summary> AllBackup. </summary>
        public static AbsoluteMarker AllBackup { get; } = new AbsoluteMarker(AllBackupValue);
        /// <summary> FirstOfDay. </summary>
        public static AbsoluteMarker FirstOfDay { get; } = new AbsoluteMarker(FirstOfDayValue);
        /// <summary> FirstOfWeek. </summary>
        public static AbsoluteMarker FirstOfWeek { get; } = new AbsoluteMarker(FirstOfWeekValue);
        /// <summary> FirstOfMonth. </summary>
        public static AbsoluteMarker FirstOfMonth { get; } = new AbsoluteMarker(FirstOfMonthValue);
        /// <summary> FirstOfYear. </summary>
        public static AbsoluteMarker FirstOfYear { get; } = new AbsoluteMarker(FirstOfYearValue);
        /// <summary> Invalid. </summary>
        public static AbsoluteMarker Invalid { get; } = new AbsoluteMarker(InvalidValue);
        /// <summary> Determines if two <see cref="AbsoluteMarker"/> values are the same. </summary>
        public static bool operator ==(AbsoluteMarker left, AbsoluteMarker right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AbsoluteMarker"/> values are not the same. </summary>
        public static bool operator !=(AbsoluteMarker left, AbsoluteMarker right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AbsoluteMarker"/>. </summary>
        public static implicit operator AbsoluteMarker(string value) => new AbsoluteMarker(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AbsoluteMarker other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AbsoluteMarker other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
