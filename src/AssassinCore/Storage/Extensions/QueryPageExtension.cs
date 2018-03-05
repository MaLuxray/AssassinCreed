
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

using AssassinCore.Sorting;
using AssassinCore.Where;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class QueryPageExtension
    {
        public static IPageResult<TEntity> Page<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int skip, int take)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Page(conn, skip, take, null, WhereClauseResult.Null, OrderbyClauseResult.Null, null);
        }

        public static IPageResult<TEntity> Page<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int skip, int take, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Page(conn, skip, take, null, WhereClauseResult.Null, OrderbyClauseResult.Null, tr);
        }

        public static IPageResult<TEntity> Page<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int skip, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Page(conn, skip, take, selectFields, WhereClauseResult.Null, OrderbyClauseResult.Null, null);
        }

        public static IPageResult<TEntity> Page<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int skip, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Page(conn, skip, take, selectFields, WhereClauseResult.Null, OrderbyClauseResult.Null, tr);
        }

        public static IPageResult<TEntity> Page<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int skip, int take, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Page(conn, skip, take, null, WhereClauseResult.Null, orderbyClause, null);
        }

        public static IPageResult<TEntity> Page<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int skip, int take, OrderbyClauseResult orderbyClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Page(conn, skip, take, null, WhereClauseResult.Null, orderbyClause, tr);
        }

        public static IPageResult<TEntity> Page<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int skip, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Page(conn, skip, take, selectFields, WhereClauseResult.Null, orderbyClause, null);
        }

        public static IPageResult<TEntity> Page<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int skip, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, OrderbyClauseResult orderbyClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Page(conn, skip, take, selectFields, WhereClauseResult.Null, orderbyClause, tr);
        }

        public static IPageResult<TEntity> Page<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int skip, int take, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Page(conn, skip, take, null, whereClause, OrderbyClauseResult.Null, null);
        }

        public static IPageResult<TEntity> Page<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int skip, int take, WhereClauseResult whereClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Page(conn, skip, take, null, whereClause, OrderbyClauseResult.Null, tr);
        }

        public static IPageResult<TEntity> Page<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int skip, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Page(conn, skip, take, selectFields, whereClause, OrderbyClauseResult.Null, null);
        }

        public static IPageResult<TEntity> Page<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int skip, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Page(conn, skip, take, selectFields, whereClause, OrderbyClauseResult.Null, tr);
        }

        public static IPageResult<TEntity> Page<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int skip, int take, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Page(conn, skip, take, null, whereClause, orderbyClause, null);
        }

        public static IPageResult<TEntity> Page<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int skip, int take, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Page(conn, skip, take, null, whereClause, orderbyClause, tr);
        }

        public static IPageResult<TEntity> Page<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, int skip, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Page(conn, skip, take, selectFields, whereClause, orderbyClause, null);
        }
    }
}