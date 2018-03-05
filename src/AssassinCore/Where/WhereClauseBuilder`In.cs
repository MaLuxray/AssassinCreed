
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using AssassinCore.Common;

namespace AssassinCore.Where
{
    // WhereClauseBuilder`In
    public partial class WhereClauseBuilder<T>
        where T : class
    {
        public IWhereClauseBuilder<T> In<TValue>(Expression<Func<T, object>> member, IEnumerable<TValue> vals) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = vals;
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} {InOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> AndIn<TValue>(Expression<Func<T, object>> member, IEnumerable<TValue> vals) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = vals;
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} {InOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> OrIn<TValue>(Expression<Func<T, object>> member, IEnumerable<TValue> vals) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = vals;
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} {InOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> NotIn<TValue>(Expression<Func<T, object>> member, IEnumerable<TValue> vals) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = vals;
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} {NotInOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> AndNotIn<TValue>(Expression<Func<T, object>> member, IEnumerable<TValue> vals) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = vals;
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} {NotInOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> OrNotIn<TValue>(Expression<Func<T, object>> member, IEnumerable<TValue> vals) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = vals;
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} {NotInOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }
    }
}