
using System;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Where;

namespace AssassinCore.Storage
{
    // IQueryStore`Count`Async
    public partial interface IQueryStore<in TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        Task<long> CountAsync(
            IStorageDbConnection conn,
            Expression<Func<TEntity, object>> member,
            WhereClauseResult whereClause,
            IDbTransaction tr,
            CancellationToken cancellationToken);
    }
}