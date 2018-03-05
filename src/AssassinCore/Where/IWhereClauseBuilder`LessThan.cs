
using System;
using System.Linq.Expressions;

namespace AssassinCore.Where
{
    // IWhereClauseBuilder`LessThan
    public partial interface IWhereClauseBuilder<T>
        where T : class
    {
        IWhereClauseBuilder<T> LessThan<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> AndLessThan<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> OrLessThan<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> LessThanOrEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> AndLessThanOrEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;

        IWhereClauseBuilder<T> OrLessThanOrEqual<TValue>(Expression<Func<T, object>> member, TValue val) where TValue : IEquatable<TValue>;
    }
}