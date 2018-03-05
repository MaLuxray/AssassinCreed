
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Where;

namespace AssassinCore.Storage
{
    // IQueryStore`Exists`Async
    public partial interface IQueryStore<in TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        Task<bool> ExistsAsync(
            IStorageDbConnection conn,
            WhereClauseResult whereClause,
            IDbTransaction tr,
            CancellationToken cancellationToken);
    }
}