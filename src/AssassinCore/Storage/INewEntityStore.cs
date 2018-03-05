
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

namespace AssassinCore.Storage
{
    public partial interface INewEntityStore<out TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        TEntity Insert(
            IStorageDbConnection conn,
            TEntity entityToInsert,
            IEnumerable<Expression<Func<TEntity, object>>> ignoredFields,
            AutoIncrementTransformer<TKey, TEntity> atf,
            IDbTransaction tr);
    }
}