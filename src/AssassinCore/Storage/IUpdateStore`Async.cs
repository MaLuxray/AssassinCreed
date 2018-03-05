
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Where;

namespace AssassinCore.Storage
{
    // IUpdateStore`Async
    public partial interface IUpdateStore<in TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        Task UpdateAsync(
            IStorageDbConnection conn,
            TEntity entityToUpdate,
            IEnumerable<Expression<Func<TEntity, object>>> updateFields,
            Expression<Func<TEntity, object>> id,
            TKey value, 
            IDbTransaction tr, 
            CancellationToken cancellationToken);

        Task UpdateAsync(
            IStorageDbConnection conn,
            TEntity entityToUpdate, 
            IEnumerable<Expression<Func<TEntity, object>>> updateFields,
            WhereClauseResult whereClause,
            IDbTransaction tr,
            CancellationToken cancellationToken);
    }
}