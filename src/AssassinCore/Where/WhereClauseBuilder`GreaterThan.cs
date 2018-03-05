
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using AssassinCore.Common;

namespace AssassinCore.Where
{
    // WhereClauseBuilder`GreaterThan
    public partial class WhereClauseBuilder<T>
        where T : class
    {
        public IWhereClauseBuilder<T> GreaterThan<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} {GreaterThanOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> AndGreaterThan<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} {GreaterThanOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> OrGreaterThan<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} {GreaterThanOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> GreaterThanOrEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} {GreaterThanOrEqualOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> AndGreaterThanOrEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} {GreaterThanOrEqualOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> OrGreaterThanOrEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} {GreaterThanOrEqualOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }
    }
}