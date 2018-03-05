
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using AssassinCore.Common;

namespace AssassinCore.Where
{
    // WhereClauseBuilder`Like
    public partial class WhereClauseBuilder<T>
        where T : class
    {
        public IWhereClauseBuilder<T> Like(Expression<Func<T, object>> member, string val)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} {LikeOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> AndLike(Expression<Func<T, object>> member, string val)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} {LikeOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> OrLike(Expression<Func<T, object>> member, string val)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = val;
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} {LikeOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> StartsWith(Expression<Func<T, object>> member, string val)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = $"{val}%";
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} {LikeOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> AndStartsWith(Expression<Func<T, object>> member, string val)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = $"{val}%";
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} {LikeOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> OrStartsWith(Expression<Func<T, object>> member, string val)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = $"{val}%";
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} {LikeOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> EndsWith(Expression<Func<T, object>> member, string val)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = $"%{val}";
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} {LikeOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> AndEndsWith(Expression<Func<T, object>> member, string val)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = $"%{val}";
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} {LikeOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> OrEndsWith(Expression<Func<T, object>> member, string val)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = $"%{val}";
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} {LikeOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> Contains(Expression<Func<T, object>> member, string val)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = $"%{val}%";
            _tuples.Add(new KeyValuePair<string, string>(null, $"{mn} {LikeOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> AndContains(Expression<Func<T, object>> member, string val)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = $"%{val}%";
            _tuples.Add(new KeyValuePair<string, string>("AND", $"{mn} {LikeOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }

        public IWhereClauseBuilder<T> OrContains(Expression<Func<T, object>> member, string val)
        {
            var mn = _dialectSettings.GetEscapeName(member);
            var pn = _dialectSettings.GetParameterName();
            object pv = $"%{val}%";
            _tuples.Add(new KeyValuePair<string, string>("OR", $"{mn} {LikeOpt} {pn}"));
            _dynParms.Add(pn, pv);

            return this;
        }
    }
}