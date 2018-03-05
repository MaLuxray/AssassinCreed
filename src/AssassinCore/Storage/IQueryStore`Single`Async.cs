
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace AssassinCore.Storage
{
    // IQueryStore`Single`Async
    public partial interface IQueryStore<in TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        Task<TEntity> SingleOrDefaultAsync(
            IStorageDbConnection conn,
            IEnumerable<Expression<Func<TEntity, object>>> selectFields,
            Expression<Func<TEntity, object>> id,
            TKey value,
            IDbTransaction tr,
            CancellationToken cancellationToken);
    }
}