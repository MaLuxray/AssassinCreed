
using System;

namespace AssassinCore.Sorting
{
    public struct OrderbyClauseResult : IEquatable<OrderbyClauseResult>
    {
        public static readonly OrderbyClauseResult Null = new OrderbyClauseResult(null);
        public static readonly OrderbyClauseResult Empty = new OrderbyClauseResult(string.Empty);

        private readonly string _value;

        private OrderbyClauseResult(string value)
        {
            _value = value;
        }

        public bool IsNull => _value == null;

        public bool IsEmpty => _value != null && _value.Length == 0;

        public bool IsNullOrEmpty => IsNull || IsEmpty;

        public bool Equals(OrderbyClauseResult other)
            => CompositeEquals(other);

        public static implicit operator string(OrderbyClauseResult result)
            => result._value;

        public static explicit operator OrderbyClauseResult(string result)
        {
            if (result == null)
            {
                return Null;
            }
            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (result == string.Empty)
            {
                return Empty;
            }
            return new OrderbyClauseResult(result);
        }

        public override string ToString()
                => this;

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = -17;
                if (IsNull)
                {
                    return hash;
                }
                hash = hash * 3 + _value.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
            => obj is OrderbyClauseResult && CompositeEquals((OrderbyClauseResult)obj);

        private bool CompositeEquals(OrderbyClauseResult other)
            => string.Equals(this, other, StringComparison.Ordinal);
    }
}