
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using AssassinCore.Common;

namespace AssassinCore.Where
{
    // WhereClauseBuilder`Is
    public partial class WhereClauseBuilder<T>
        where T : class
    {
        public IWhereClauseBuilder<T> IsNull(Expression<Func<T, object>> member)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} IS NULL"));

            return this;
        }

        public IWhereClauseBuilder<T> AndIsNull(Expression<Func<T, object>> member)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} IS NULL"));

            return this;
        }

        public IWhereClauseBuilder<T> OrIsNull(Expression<Func<T, object>> member)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} IS NULL"));

            return this;
        }

        public IWhereClauseBuilder<T> IsNotNull(Expression<Func<T, object>> member)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} IS NOT NULL"));

            return this;
        }

        public IWhereClauseBuilder<T> AndIsNotNull(Expression<Func<T, object>> member)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} IS NOT NULL"));

            return this;
        }

        public IWhereClauseBuilder<T> OrIsNotNull(Expression<Func<T, object>> member)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} IS NOT NULL"));

            return this;
        }
    }
}