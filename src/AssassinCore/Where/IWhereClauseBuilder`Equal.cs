
using System;
using System.Linq.Expressions;

namespace AssassinCore.Where
{
    // IWhereClauseBuilder`Equal
    public partial interface IWhereClauseBuilder<T>
        where T : class
    {
        IWhereClauseBuilder<T> Equal<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> AndEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> OrEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> NotEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> AndNotEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> OrNotEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;
    }
}