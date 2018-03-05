
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using AssassinCore.Common;

namespace AssassinCore.Where
{
    // WhereClauseBuilder`Between
    public partial class WhereClauseBuilder<T>
        where T : class
    {
        public IWhereClauseBuilder<T> Between<TValue>(Expression<Func<T, object>> member, TValue val1, TValue val2) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn1 = _dialectSettings.GetParameterName();
            var pn2 = _dialectSettings.GetParameterName();
            object pv1 = val1;
            object pv2 = val2;
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} {BetweenOpt} {pn1} AND {pn2}"));
            _dynParms.Add(pn1, pv1);
            _dynParms.Add(pn2, pv2);

            return this;
        }

        public IWhereClauseBuilder<T> AndBetween<TValue>(Expression<Func<T, object>> member, TValue val1, TValue val2) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn1 = _dialectSettings.GetParameterName();
            var pn2 = _dialectSettings.GetParameterName();
            object pv1 = val1;
            object pv2 = val2;
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} {BetweenOpt} {pn1} AND {pn2}"));
            _dynParms.Add(pn1, pv1);
            _dynParms.Add(pn2, pv2);

            return this;
        }

        public IWhereClauseBuilder<T> OrBetween<TValue>(Expression<Func<T, object>> member, TValue val1, TValue val2) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn1 = _dialectSettings.GetParameterName();
            var pn2 = _dialectSettings.GetParameterName();
            object pv1 = val1;
            object pv2 = val2;
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} {BetweenOpt} {pn1} AND {pn2}"));
            _dynParms.Add(pn1, pv1);
            _dynParms.Add(pn2, pv2);

            return this;
        }

        public IWhereClauseBuilder<T> NotBetween<TValue>(Expression<Func<T, object>> member, TValue val1, TValue val2) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn1 = _dialectSettings.GetParameterName();
            var pn2 = _dialectSettings.GetParameterName();
            object pv1 = val1;
            object pv2 = val2;
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} {NotBetweenOpt} {pn1} AND {pn2}"));
            _dynParms.Add(pn1, pv1);
            _dynParms.Add(pn2, pv2);

            return this;
        }

        public IWhereClauseBuilder<T> AndNotBetween<TValue>(Expression<Func<T, object>> member, TValue val1, TValue val2) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn1 = _dialectSettings.GetParameterName();
            var pn2 = _dialectSettings.GetParameterName();
            object pv1 = val1;
            object pv2 = val2;
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} {NotBetweenOpt} {pn1} AND {pn2}"));
            _dynParms.Add(pn1, pv1);
            _dynParms.Add(pn2, pv2);

            return this;
        }

        public IWhereClauseBuilder<T> OrNotBetween<TValue>(Expression<Func<T, object>> member, TValue val1, TValue val2) where TValue : IEquatable<TValue>
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn1 = _dialectSettings.GetParameterName();
            var pn2 = _dialectSettings.GetParameterName();
            object pv1 = val1;
            object pv2 = val2;
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} {NotBetweenOpt} {pn1} AND {pn2}"));
            _dynParms.Add(pn1, pv1);
            _dynParms.Add(pn2, pv2);

            return this;
        }
    }
}