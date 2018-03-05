
using System;
using System.Linq.Expressions;

namespace AssassinCore.Where
{
    // IWhereClauseBuilder`Between
    public partial interface IWhereClauseBuilder<T>
        where T : class
    {
        IWhereClauseBuilder<T> Between<TValue>(Expression<Func<T, object>> member, TValue val1, TValue val2) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> AndBetween<TValue>(Expression<Func<T, object>> member, TValue val1, TValue val2) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> OrBetween<TValue>(Expression<Func<T, object>> member, TValue val1, TValue val2) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> NotBetween<TValue>(Expression<Func<T, object>> member, TValue val1, TValue val2) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> AndNotBetween<TValue>(Expression<Func<T, object>> member, TValue val1, TValue val2) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> OrNotBetween<TValue>(Expression<Func<T, object>> member, TValue val1, TValue val2) where TValue : IEquatable<TValue>;
    }
}