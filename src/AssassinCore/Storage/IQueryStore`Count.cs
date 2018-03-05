
using System;
using System.Data;
using System.Linq.Expressions;

using AssassinCore.Where;

namespace AssassinCore.Storage
{
    // IQueryStore`Count
    public partial interface IQueryStore<in TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        long Count(
            IStorageDbConnection conn,
            Expression<Func<TEntity, object>> member, 
            WhereClauseResult whereClause, 
            IDbTransaction tr);
    }
}