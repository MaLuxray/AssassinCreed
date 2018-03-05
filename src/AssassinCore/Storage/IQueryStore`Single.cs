
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

namespace AssassinCore.Storage
{
    // IQueryStore`Single
    public partial interface IQueryStore<in TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        TEntity SingleOrDefault(
            IStorageDbConnection conn,
            IEnumerable<Expression<Func<TEntity, object>>> selectFields,
            Expression<Func<TEntity, object>> id,
            TKey value,
            IDbTransaction tr);
    }
}