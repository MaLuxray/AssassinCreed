
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace AssassinCore.Storage
{
    // INewEntityStore`Async
    public partial interface INewEntityStore<out TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        Task<TEntity> InsertAsync(
            IStorageDbConnection conn,
            TEntity entityToInsert,
            IEnumerable<Expression<Func<TEntity, object>>> ignoredFields,
            AutoIncrementTransformer<TKey, TEntity> atf,
            IDbTransaction tr, 
            CancellationToken cancellationToken);
    }
}