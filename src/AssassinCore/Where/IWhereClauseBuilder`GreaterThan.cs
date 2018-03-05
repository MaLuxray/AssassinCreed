
using System;
using System.Linq.Expressions;

namespace AssassinCore.Where
{
    // IWhereClauseBuilder`GreaterThan
    public partial interface IWhereClauseBuilder<T>
        where T : class
    {
        IWhereClauseBuilder<T> GreaterThan<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> AndGreaterThan<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> OrGreaterThan<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> GreaterThanOrEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> AndGreaterThanOrEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> OrGreaterThanOrEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;
    }
}