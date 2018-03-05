
using System;
using System.Linq.Expressions;

namespace AssassinCore.Sorting
{
    public interface IOrderbyClauseBuilder<T> : IDisposable
        where T : class
    {
        IOrderbyClauseBuilder<T> Ascending(Expression<Func<T, object>> member);

        IOrderbyClauseBuilder<T> Descending(Expression<Func<T, object>> member);

        IOrderbyClauseBuilder<T> Clear();

        OrderbyClauseResult Build();
    }
}