
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Sorting;
using AssassinCore.Where;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class QuerySelectAsyncExtension
    {
        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, WhereClauseResult.Null, OrderbyClauseResult.Null, null, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, WhereClauseResult.Null, OrderbyClauseResult.Null, null, cancellationToken);
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, WhereClauseResult.Null, OrderbyClauseResult.Null, tr, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, WhereClauseResult.Null, OrderbyClauseResult.Null, tr, cancellationToken);
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, selectFields, WhereClauseResult.Null, OrderbyClauseResult.Null, null, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, selectFields, WhereClauseResult.Null, OrderbyClauseResult.Null, null, cancellationToken);
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, selectFields, WhereClauseResult.Null, OrderbyClauseResult.Null, tr, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, selectFields, WhereClauseResult.Null, OrderbyClauseResult.Null, tr, cancellationToken);
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, WhereClauseResult.Null, orderbyClause, null, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, OrderbyClauseResult orderbyClause, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, WhereClauseResult.Null, orderbyClause, null, cancellationToken);
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, OrderbyClauseResult orderbyClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, WhereClauseResult.Null, orderbyClause, tr, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, OrderbyClauseResult orderbyClause, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, WhereClauseResult.Null, orderbyClause, tr, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, selectFields, WhereClauseResult.Null, orderbyClause, null, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, OrderbyClauseResult orderbyClause, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, selectFields, WhereClauseResult.Null, orderbyClause, null, cancellationToken);
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, OrderbyClauseResult orderbyClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, selectFields, WhereClauseResult.Null, orderbyClause, tr, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, OrderbyClauseResult orderbyClause, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, selectFields, WhereClauseResult.Null, orderbyClause, tr, cancellationToken);
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, whereClause, OrderbyClauseResult.Null, null, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, whereClause, OrderbyClauseResult.Null, null, cancellationToken);
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, whereClause, OrderbyClauseResult.Null, tr, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, whereClause, OrderbyClauseResult.Null, tr, cancellationToken);
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, selectFields, whereClause, OrderbyClauseResult.Null, null, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, selectFields, whereClause, OrderbyClauseResult.Null, null, cancellationToken);
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, selectFields, whereClause, OrderbyClauseResult.Null, tr, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, selectFields, whereClause, OrderbyClauseResult.Null, tr, cancellationToken);
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, whereClause, orderbyClause, null, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, whereClause, orderbyClause, null, cancellationToken);
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, whereClause, orderbyClause, tr, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, null, whereClause, orderbyClause, tr, cancellationToken);
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, selectFields, whereClause, orderbyClause, null, default(CancellationToken));
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, selectFields, whereClause, orderbyClause, null, cancellationToken);
        }

        public static Task<IEnumerable<TEntity>> SelectAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SelectAsync(conn, selectFields, whereClause, orderbyClause, tr, default(CancellationToken));
        }
    }
}