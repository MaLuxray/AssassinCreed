
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AssassinCore.Where
{
    // IWhereClauseBuilder`In
    public partial interface IWhereClauseBuilder<T>
        where T : class
    {
        IWhereClauseBuilder<T> In<TValue>(Expression<Func<T, object>> member, IEnumerable<TValue> vals) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> AndIn<TValue>(Expression<Func<T, object>> member, IEnumerable<TValue> vals) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> OrIn<TValue>(Expression<Func<T, object>> member, IEnumerable<TValue> vals) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> NotIn<TValue>(Expression<Func<T, object>> member, IEnumerable<TValue> vals) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> AndNotIn<TValue>(Expression<Func<T, object>> member, IEnumerable<TValue> vals) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> OrNotIn<TValue>(Expression<Func<T, object>> member, IEnumerable<TValue> vals) where TValue : IEquatable<TValue>;
    }
}