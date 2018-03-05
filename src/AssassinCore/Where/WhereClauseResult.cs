
using System;
using System.Collections.Generic;
using System.Linq;

using Dapper;

namespace AssassinCore.Where
{
    public class WhereClauseResult : IEquatable<WhereClauseResult>
    {
        public static readonly WhereClauseResult Null = null;

        private static readonly IEnumerable<string> EmptyParameterNames = Enumerable.Empty<string>();

        private readonly DynamicParameters _dynParms;

        internal WhereClauseResult(string statement, DynamicParameters dynParms)
        {
            Statement = statement ?? throw new ArgumentNullException(nameof(statement));
            _dynParms = dynParms == null ? null : new DynamicParameters(dynParms);
            Any = (_dynParms?.ParameterNames.Count() ?? 0) > 0;
        }

        public object this[string key] => GetValue(key);

        public string Statement { get; }

        public IEnumerable<string> ParameterNames => _dynParms == null ? EmptyParameterNames : _dynParms.ParameterNames;

        public bool Any { get; }

        public bool Equals(WhereClauseResult other)
            => CompositeEqulas(other);

        public static explicit operator DynamicParameters(WhereClauseResult whereClause)
        {
            return whereClause?._dynParms == null ? null : new DynamicParameters(whereClause._dynParms);
        }

        public override string ToString()
            => Statement;

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = -17;
                if (Statement != null)
                {
                    hash = hash * 3 + Statement.GetHashCode();
                }
                if (_dynParms != null)
                {
                    hash = 397 + hash + _dynParms.GetHashCode();
                }
                return hash;
            }
        }

        public override bool Equals(object obj)
            => CompositeEqulas(obj as WhereClauseResult);

        private object GetValue(string key)
        {
            if (key == null || _dynParms == null)
            {
                return null;
            }
            var value = _dynParms.Get<object>(key);
            return value;
        }

        private bool CompositeEqulas(WhereClauseResult other)
        {
            if (other == null)
            {
                return false;
            }

            if (GetHashCode() != other.GetHashCode())
            {
                return false;
            }
            if (!string.Equals(Statement, other.Statement, StringComparison.Ordinal))
            {
                return false;
            }
            var count = _dynParms?.ParameterNames.Count() ?? 0;
            var count2 = other._dynParms?.ParameterNames.Count() ?? 0;
            if (count == 0 && count2 == 0)
            {
                return true;
            }
            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (count != count2)
            {
                return false;
            }
            else
            {
                // ReSharper disable once PossibleNullReferenceException
                return _dynParms.Equals(other._dynParms);
            }
        }
    }
}