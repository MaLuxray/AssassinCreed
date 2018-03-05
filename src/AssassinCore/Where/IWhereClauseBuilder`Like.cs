
using System;
using System.Linq.Expressions;

namespace AssassinCore.Where
{
    // IWhereClauseBuilder`Like
    public partial interface IWhereClauseBuilder<T>
        where T : class
    {
        IWhereClauseBuilder<T> Like(Expression<Func<T, object>> member, string val);

        IWhereClauseBuilder<T> AndLike(Expression<Func<T, object>> member, string val);

        IWhereClauseBuilder<T> OrLike(Expression<Func<T, object>> member, string val);

        IWhereClauseBuilder<T> StartsWith(Expression<Func<T, object>> member, string val);

        IWhereClauseBuilder<T> AndStartsWith(Expression<Func<T, object>> member, string val);

        IWhereClauseBuilder<T> OrStartsWith(Expression<Func<T, object>> member, string val);

        IWhereClauseBuilder<T> EndsWith(Expression<Func<T, object>> member, string val);

        IWhereClauseBuilder<T> AndEndsWith(Expression<Func<T, object>> member, string val);

        IWhereClauseBuilder<T> OrEndsWith(Expression<Func<T, object>> member, string val);

        IWhereClauseBuilder<T> Contains(Expression<Func<T, object>> member, string val);

        IWhereClauseBuilder<T> AndContains(Expression<Func<T, object>> member, string val);

        IWhereClauseBuilder<T> OrContains(Expression<Func<T, object>> member, string val);
    }
}