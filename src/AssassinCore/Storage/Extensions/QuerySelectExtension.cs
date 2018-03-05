
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

using AssassinCore.Sorting;
using AssassinCore.Where;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class QuerySelectExtension
    {
        public static IEnumerable<TEntity> Select<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Select(conn, null, WhereClauseResult.Null, OrderbyClauseResult.Null, null);
        }

        public static IEnumerable<TEntity> Select<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Select(conn, null, WhereClauseResult.Null, OrderbyClauseResult.Null, tr);
        }

        public static IEnumerable<TEntity> Select<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Select(conn, selectFields, WhereClauseResult.Null, OrderbyClauseResult.Null, null);
        }

        public static IEnumerable<TEntity> Select<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Select(conn, selectFields, WhereClauseResult.Null, OrderbyClauseResult.Null, tr);
        }

        public static IEnumerable<TEntity> Select<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Select(conn, null, WhereClauseResult.Null, orderbyClause, null);
        }

        public static IEnumerable<TEntity> Select<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, OrderbyClauseResult orderbyClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Select(conn, null, WhereClauseResult.Null, orderbyClause, tr);
        }

        public static IEnumerable<TEntity> Select<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Select(conn, selectFields, WhereClauseResult.Null, orderbyClause, null);
        }

        public static IEnumerable<TEntity> Select<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, OrderbyClauseResult orderbyClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Select(conn, selectFields, WhereClauseResult.Null, orderbyClause, tr);
        }

        public static IEnumerable<TEntity> Select<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Select(conn, null, whereClause, OrderbyClauseResult.Null, null);
        }

        public static IEnumerable<TEntity> Select<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Select(conn, null, whereClause, OrderbyClauseResult.Null, tr);
        }

        public static IEnumerable<TEntity> Select<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Select(conn, selectFields, whereClause, OrderbyClauseResult.Null, null);
        }

        public static IEnumerable<TEntity> Select<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Select(conn, selectFields, whereClause, OrderbyClauseResult.Null, tr);
        }

        public static IEnumerable<TEntity> Select<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Select(conn, null, whereClause, orderbyClause, null);
        }

        public static IEnumerable<TEntity> Select<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Select(conn, null, whereClause, orderbyClause, tr);
        }

        public static IEnumerable<TEntity> Select<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Select(conn, selectFields, whereClause, orderbyClause, null);
        }
    }
}