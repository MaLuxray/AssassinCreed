
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

using AssassinCore.Where;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class UpdateExtension
    {
        public static void Update<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            updateStore.Update(conn, entityToUpdate, null, WhereClauseResult.Null, null);
        }

        public static void Update<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            updateStore.Update(conn, entityToUpdate, null, WhereClauseResult.Null, tr);
        }

        public static void Update<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            updateStore.Update(conn, entityToUpdate, updateFields, WhereClauseResult.Null, null);
        }

        public static void Update<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            updateStore.Update(conn, entityToUpdate, updateFields, WhereClauseResult.Null, tr);
        }

        public static void Update<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            updateStore.Update(conn, entityToUpdate, null, whereClause, null);
        }

        public static void Update<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, WhereClauseResult whereClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            updateStore.Update(conn, entityToUpdate, null, whereClause, tr);
        }

        public static void Update<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            updateStore.Update(conn, entityToUpdate, updateFields, whereClause, null);
        }
    }
}