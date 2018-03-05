
using System;
using System.Linq.Expressions;

namespace AssassinCore.Where
{
    // IWhereClauseBuilder`Is
    public partial interface IWhereClauseBuilder<T>
        where T : class
    {
        IWhereClauseBuilder<T> IsNull(Expression<Func<T, object>> member);

        IWhereClauseBuilder<T> AndIsNull(Expression<Func<T, object>> member);

        IWhereClauseBuilder<T> OrIsNull(Expression<Func<T, object>> member);

        IWhereClauseBuilder<T> IsNotNull(Expression<Func<T, object>> member);

        IWhereClauseBuilder<T> AndIsNotNull(Expression<Func<T, object>> member);

        IWhereClauseBuilder<T> OrIsNotNull(Expression<Func<T, object>> member);
    }
}