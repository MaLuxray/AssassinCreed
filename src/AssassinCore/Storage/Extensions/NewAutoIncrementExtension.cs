
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class NewAutoIncrementExtension
    {
        // auto_increment
        public static TEntity InsertAutoIncrement<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.Insert(conn, entityToInsert, new Expression<Func<TEntity, object>>[] { _ => _.Id, }, (a, b) => b.Id = a, null);
        }

        public static TEntity InsertAutoIncrement<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.Insert(conn, entityToInsert, new Expression<Func<TEntity, object>>[] { _ => _.Id, }, (a, b) => b.Id = a, tr);
        }

        public static TEntity InsertAutoIncrement<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.Insert(conn, entityToInsert, ignoredFields, (a, b) => b.Id = a, null);
        }

        public static TEntity InsertAutoIncrement<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.Insert(conn, entityToInsert, ignoredFields, (a, b) => b.Id = a, tr);
        }
    }
}