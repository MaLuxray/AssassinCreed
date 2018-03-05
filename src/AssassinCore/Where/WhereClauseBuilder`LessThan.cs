
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using AssassinCore.Common;

namespace AssassinCore.Where
{
    // WhereClauseBuilder`LessThan
    public partial class WhereClauseBuilder<T>
        where T : class
    {
        public IWhereClauseBuilder<T> LessThan<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} {LessThanOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> AndLessThan<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} {LessThanOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> OrLessThan<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} {LessThanOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> LessThanOrEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} {LessThanOrEqualOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> AndLessThanOrEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} {LessThanOrEqualOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> OrLessThanOrEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} {LessThanOrEqualOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }
    }
}