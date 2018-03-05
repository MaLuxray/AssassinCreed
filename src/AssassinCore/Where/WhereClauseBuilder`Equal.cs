
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using AssassinCore.Common;

namespace AssassinCore.Where
{
    // WhereClauseBuilder`Equal
    public partial class WhereClauseBuilder<T>
        where T : class
    {
        public IWhereClauseBuilder<T> Equal<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} {EqualOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> AndEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} {EqualOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> OrEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} {EqualOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> NotEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} {NotEqualOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> AndNotEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} {NotEqualOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> OrNotEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} {NotEqualOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }
    }
}