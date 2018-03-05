
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

using AssassinCore.Sorting;
using AssassinCore.Where;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class QueryTakeExtension
    {
        public static IEnumerable<TEntity> Take<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int take)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Take(conn, take, null, WhereClauseResult.Null, OrderbyClauseResult.Null, null);
        }

        public static IEnumerable<TEntity> Take<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int take, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Take(conn, take, null, WhereClauseResult.Null, OrderbyClauseResult.Null, tr);
        }

        public static IEnumerable<TEntity> Take<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Take(conn, take, selectFields, WhereClauseResult.Null, OrderbyClauseResult.Null, null);
        }

        public static IEnumerable<TEntity> Take<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Take(conn, take, selectFields, WhereClauseResult.Null, OrderbyClauseResult.Null, tr);
        }

        public static IEnumerable<TEntity> Take<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int take, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Take(conn, take, null, WhereClauseResult.Null, orderbyClause, null);
        }

        public static IEnumerable<TEntity> Take<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int take, OrderbyClauseResult orderbyClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Take(conn, take, null, WhereClauseResult.Null, orderbyClause, tr);
        }

        public static IEnumerable<TEntity> Take<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Take(conn, take, selectFields, WhereClauseResult.Null, orderbyClause, null);
        }

        public static IEnumerable<TEntity> Take<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, OrderbyClauseResult orderbyClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Take(conn, take, selectFields, WhereClauseResult.Null, orderbyClause, tr);
        }

        public static IEnumerable<TEntity> Take<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int take, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Take(conn, take, null, whereClause, OrderbyClauseResult.Null, null);
        }

        public static IEnumerable<TEntity> Take<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int take, WhereClauseResult whereClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Take(conn, take, null, whereClause, OrderbyClauseResult.Null, tr);
        }

        public static IEnumerable<TEntity> Take<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Take(conn, take, selectFields, whereClause, OrderbyClauseResult.Null, null);
        }

        public static IEnumerable<TEntity> Take<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Take(conn, take, selectFields, whereClause, OrderbyClauseResult.Null, tr);
        }

        public static IEnumerable<TEntity> Take<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int take, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Take(conn, take, null, whereClause, orderbyClause, null);
        }

        public static IEnumerable<TEntity> Take<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int take, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Take(conn, take, null, whereClause, orderbyClause, tr);
        }

        public static IEnumerable<TEntity> Take<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Take(conn, take, selectFields, whereClause, orderbyClause, null);
        }
    }
}