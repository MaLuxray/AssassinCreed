
using System;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class DeleteByIdAsyncExtension
    {
        public static Task DeleteAsync<TKey, TEntity>(this IDeleteStore<TKey, TEntity> deleteStore, IStorageDbConnection conn, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (deleteStore == null)
            {
                throw new ArgumentNullException(nameof(deleteStore));
            }
            return deleteStore.DeleteAsync(conn, _ => _.Id, value, null, default(CancellationToken));
        }

        public static Task DeleteAsync<TKey, TEntity>(this IDeleteStore<TKey, TEntity> deleteStore, IStorageDbConnection conn, TKey value, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (deleteStore == null)
            {
                throw new ArgumentNullException(nameof(deleteStore));
            }
            return deleteStore.DeleteAsync(conn, _ => _.Id, value, null, cancellationToken);
        }

        public static Task DeleteAsync<TKey, TEntity>(this IDeleteStore<TKey, TEntity> deleteStore, IStorageDbConnection conn, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (deleteStore == null)
            {
                throw new ArgumentNullException(nameof(deleteStore));
            }
            return deleteStore.DeleteAsync(conn, _ => _.Id, value, tr, default(CancellationToken));
        }

        public static Task DeleteAsync<TKey, TEntity>(this IDeleteStore<TKey, TEntity> deleteStore, IStorageDbConnection conn, TKey value, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (deleteStore == null)
            {
                throw new ArgumentNullException(nameof(deleteStore));
            }
            return deleteStore.DeleteAsync(conn, _ => _.Id, value, tr, cancellationToken);
        }

        public static Task DeleteAsync<TKey, TEntity>(this IDeleteStore<TKey, TEntity> deleteStore, IStorageDbConnection conn, Expression<Func<TEntity, object>> id, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (deleteStore == null)
            {
                throw new ArgumentNullException(nameof(deleteStore));
            }
            return deleteStore.DeleteAsync(conn, id, value, null, default(CancellationToken));
        }

        public static Task DeleteAsync<TKey, TEntity>(this IDeleteStore<TKey, TEntity> deleteStore, IStorageDbConnection conn, Expression<Func<TEntity, object>> id, TKey value, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (deleteStore == null)
            {
                throw new ArgumentNullException(nameof(deleteStore));
            }
            return deleteStore.DeleteAsync(conn, id, value, null, cancellationToken);
        }

        public static Task DeleteAsync<TKey, TEntity>(this IDeleteStore<TKey, TEntity> deleteStore, IStorageDbConnection conn, Expression<Func<TEntity, object>> id, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (deleteStore == null)
            {
                throw new ArgumentNullException(nameof(deleteStore));
            }
            return deleteStore.DeleteAsync(conn, id, value, tr, default(CancellationToken));
        }
    }
}