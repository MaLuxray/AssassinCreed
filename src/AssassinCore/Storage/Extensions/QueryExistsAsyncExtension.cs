

using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Where;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class QueryExistsAsyncExtension
    {
        public static Task<bool> ExistsAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.ExistsAsync(conn, WhereClauseResult.Null, null, default(CancellationToken));
        }

        public static Task<bool> ExistsAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.ExistsAsync(conn, WhereClauseResult.Null, null, cancellationToken);
        }

        public static Task<bool> ExistsAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.ExistsAsync(conn, WhereClauseResult.Null, tr, default(CancellationToken));
        }

        public static Task<bool> ExistsAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.ExistsAsync(conn, WhereClauseResult.Null, tr, cancellationToken);
        }

        public static Task<bool> ExistsAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.ExistsAsync(conn, whereClause, null, default(CancellationToken));
        }

        public static Task<bool> ExistsAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.ExistsAsync(conn, whereClause, null, cancellationToken);
        }

        public static Task<bool> ExistsAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.ExistsAsync(conn, whereClause, tr, default(CancellationToken));
        }
    }
}