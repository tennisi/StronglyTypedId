    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1036:Override methods on comparable types")]
    readonly partial struct TESTID : INTERFACES
    {
        public long Value { get; }

        public TESTID(long value)
        {
            Value = value;
        }

        public static readonly TESTID Empty = new TESTID(0);

        public bool Equals(TESTID other) => this.Value.Equals(other.Value);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is TESTID other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

        public static bool operator ==(TESTID a, TESTID b) => a.Equals(b);

        public static bool operator !=(TESTID a, TESTID b) => !(a == b);

        public static implicit operator long(TESTID customId)
        {
            return customId.Value;
        }

        public static implicit operator TESTID(long value)
        {
            return new TESTID(value);
        }

        public static implicit operator decimal(TESTID customId)
        {
            return customId.Value;
        }

        public static implicit operator TESTID(decimal value)
        {
            return new TESTID((long)value);
        }
