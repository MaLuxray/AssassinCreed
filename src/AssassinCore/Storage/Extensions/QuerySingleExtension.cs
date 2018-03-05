
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class QuerySingleExtension
    {
        public static TEntity SingleOrDefault<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefault(conn, null, _ => _.Id, value, null);
        }

        public static TEntity SingleOrDefault<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefault(conn, null, _ => _.Id, value, tr);
        }

        public static TEntity SingleOrDefault<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, Expression<Func<TEntity, object>> id, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefault(conn, null, id, value, null);
        }

        public static TEntity SingleOrDefault<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, Expression<Func<TEntity, object>> id, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefault(conn, null, id, value, tr);
        }

        public static TEntity SingleOrDefault<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefault(conn, selectFields, _ => _.Id, value, null);
        }

        public static TEntity SingleOrDefault<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefault(conn, selectFields, _ => _.Id, value, tr);
        }

        public static TEntity SingleOrDefault<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, Expression<Func<TEntity, object>> id, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefault(conn, selectFields, id, value, null);
        }
    }
}