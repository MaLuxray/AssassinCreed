
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class NewExtension
    {
        // auto_increment = true

        public static TEntity Insert<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.Insert(conn, entityToInsert, null, null, null);
        }

        public static TEntity Insert<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.Insert(conn, entityToInsert, null, null, tr);
        }

        public static TEntity Insert<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.Insert(conn, entityToInsert, ignoredFields, null, null);
        }

        public static TEntity Insert<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.Insert(conn, entityToInsert, ignoredFields, null, tr);
        }

        public static TEntity Insert<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, AutoIncrementTransformer<TKey, TEntity> atf)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.Insert(conn, entityToInsert, null, atf, null);
        }

        public static TEntity Insert<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, AutoIncrementTransformer<TKey, TEntity> atf, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.Insert(conn, entityToInsert, null, atf, tr);
        }

        public static TEntity Insert<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, AutoIncrementTransformer<TKey, TEntity> atf)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.Insert(conn, entityToInsert, ignoredFields, atf, null);
        }
    }
}