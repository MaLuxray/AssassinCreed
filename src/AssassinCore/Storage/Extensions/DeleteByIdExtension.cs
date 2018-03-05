
using System;
using System.Data;
using System.Linq.Expressions;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class DeleteByIdExtension
    {
        public static void Delete<TKey, TEntity>(this IDeleteStore<TKey, TEntity> deleteStore, IStorageDbConnection conn, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (deleteStore == null)
            {
                throw new ArgumentNullException(nameof(deleteStore));
            }
            deleteStore.Delete(conn, _ => _.Id, value, null);
        }

        public static void Delete<TKey, TEntity>(this IDeleteStore<TKey, TEntity> deleteStore, IStorageDbConnection conn, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (deleteStore == null)
            {
                throw new ArgumentNullException(nameof(deleteStore));
            }
            deleteStore.Delete(conn, _ => _.Id, value, tr);
        }

        public static void Delete<TKey, TEntity>(this IDeleteStore<TKey, TEntity> deleteStore, IStorageDbConnection conn, Expression<Func<TEntity, object>> id, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (deleteStore == null)
            {
                throw new ArgumentNullException(nameof(deleteStore));
            }
            deleteStore.Delete(conn, id, value, null);
        }
    }
}