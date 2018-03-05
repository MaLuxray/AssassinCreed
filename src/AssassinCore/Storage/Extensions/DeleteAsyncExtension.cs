


using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Where;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class DeleteAsyncExtension
    {
        public static Task DeleteAsync<TKey, TEntity>(this IDeleteStore<TKey, TEntity> deleteStore, IStorageDbConnection conn, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (deleteStore == null)
            {
                throw new ArgumentNullException(nameof(deleteStore));
            }
            return deleteStore.DeleteAsync(conn, whereClause, null, default(CancellationToken));
        }

        public static Task DeleteAsync<TKey, TEntity>(this IDeleteStore<TKey, TEntity> deleteStore, IStorageDbConnection conn, WhereClauseResult whereClause, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (deleteStore == null)
            {
                throw new ArgumentNullException(nameof(deleteStore));
            }
            return deleteStore.DeleteAsync(conn, whereClause, null, cancellationToken);
        }

        public static Task DeleteAsync<TKey, TEntity>(this IDeleteStore<TKey, TEntity> deleteStore, IStorageDbConnection conn, WhereClauseResult whereClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (deleteStore == null)
            {
                throw new ArgumentNullException(nameof(deleteStore));
            }
            return deleteStore.DeleteAsync(conn, whereClause, tr, default(CancellationToken));
        }
    }
}