
using System;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Where;

namespace AssassinCore.Storage
{
    // IDeleteStore`Async
    public partial interface IDeleteStore<in TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        Task DeleteAsync(
            IStorageDbConnection conn,
            Expression<Func<TEntity, object>> id,
            TKey value,
            IDbTransaction tr,
            CancellationToken cancellationToken);

        Task DeleteAsync(
            IStorageDbConnection conn,
            WhereClauseResult whereClause,
            IDbTransaction tr,
            CancellationToken cancellationToken);
    }
}