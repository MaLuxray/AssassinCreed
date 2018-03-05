
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class UpdateByIdExtension
    {
        public static void Update<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            updateStore.Update(conn, entityToUpdate, null, _ => _.Id, value, null);
        }

        public static void Update<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            updateStore.Update(conn, entityToUpdate, null, _ => _.Id, value, tr);
        }

        public static void Update<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            updateStore.Update(conn, entityToUpdate, updateFields, _ => _.Id, value, null);
        }

        public static void Update<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            updateStore.Update(conn, entityToUpdate, updateFields, _ => _.Id, value, tr);
        }

        public static void Update<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, Expression<Func<TEntity, object>> id, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            updateStore.Update(conn, entityToUpdate, null, id, value, null);
        }

        public static void Update<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, Expression<Func<TEntity, object>> id, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            updateStore.Update(conn, entityToUpdate, null, id, value, tr);
        }

        public static void Update<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, Expression<Func<TEntity, object>> id, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            updateStore.Update(conn, entityToUpdate, updateFields, id, value, null);
        }
    }
}