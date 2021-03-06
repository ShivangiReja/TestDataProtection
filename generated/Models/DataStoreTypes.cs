// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace DataProtectionPlugin.Models
{
    /// <summary> type of datastore; SnapShot/Hot/Archive. </summary>
    public readonly partial struct DataStoreTypes : IEquatable<DataStoreTypes>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataStoreTypes"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataStoreTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OperationalStoreValue = "OperationalStore";
        private const string VaultStoreValue = "VaultStore";
        private const string ArchiveStoreValue = "ArchiveStore";

        /// <summary> OperationalStore. </summary>
        public static DataStoreTypes OperationalStore { get; } = new DataStoreTypes(OperationalStoreValue);
        /// <summary> VaultStore. </summary>
        public static DataStoreTypes VaultStore { get; } = new DataStoreTypes(VaultStoreValue);
        /// <summary> ArchiveStore. </summary>
        public static DataStoreTypes ArchiveStore { get; } = new DataStoreTypes(ArchiveStoreValue);
        /// <summary> Determines if two <see cref="DataStoreTypes"/> values are the same. </summary>
        public static bool operator ==(DataStoreTypes left, DataStoreTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataStoreTypes"/> values are not the same. </summary>
        public static bool operator !=(DataStoreTypes left, DataStoreTypes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataStoreTypes"/>. </summary>
        public static implicit operator DataStoreTypes(string value) => new DataStoreTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataStoreTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataStoreTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
