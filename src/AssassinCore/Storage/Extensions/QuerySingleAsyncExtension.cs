
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class QuerySingleAsyncExtension
    {
        public static Task<TEntity> SingleOrDefaultAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefaultAsync(conn, null, _ => _.Id, value, null, default(CancellationToken));
        }

        public static Task<TEntity> SingleOrDefaultAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, TKey value, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefaultAsync(conn, null, _ => _.Id, value, null, cancellationToken);
        }

        public static Task<TEntity> SingleOrDefaultAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefaultAsync(conn, null, _ => _.Id, value, tr, default(CancellationToken));
        }

        public static Task<TEntity> SingleOrDefaultAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, TKey value, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefaultAsync(conn, null, _ => _.Id, value, tr, cancellationToken);
        }

        public static Task<TEntity> SingleOrDefaultAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, Expression<Func<TEntity, object>> id, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefaultAsync(conn, null, id, value, null, default(CancellationToken));
        }

        public static Task<TEntity> SingleOrDefaultAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, Expression<Func<TEntity, object>> id, TKey value, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefaultAsync(conn, null, id, value, null, cancellationToken);
        }

        public static Task<TEntity> SingleOrDefaultAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, Expression<Func<TEntity, object>> id, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefaultAsync(conn, null, id, value, tr, default(CancellationToken));
        }

        public static Task<TEntity> SingleOrDefaultAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, Expression<Func<TEntity, object>> id, TKey value, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefaultAsync(conn, null, id, value, tr, cancellationToken);
        }

        public static Task<TEntity> SingleOrDefaultAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefaultAsync(conn, selectFields, _ => _.Id, value, null, default(CancellationToken));
        }

        public static Task<TEntity> SingleOrDefaultAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, TKey value, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefaultAsync(conn, selectFields, _ => _.Id, value, null, cancellationToken);
        }

        public static Task<TEntity> SingleOrDefaultAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefaultAsync(conn, selectFields, _ => _.Id, value, tr, default(CancellationToken));
        }

        public static Task<TEntity> SingleOrDefaultAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, TKey value, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefaultAsync(conn, selectFields, _ => _.Id, value, tr, cancellationToken);
        }

        public static Task<TEntity> SingleOrDefaultAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, Expression<Func<TEntity, object>> id, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefaultAsync(conn, selectFields, id, value, null, default(CancellationToken));
        }

        public static Task<TEntity> SingleOrDefaultAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, Expression<Func<TEntity, object>> id, TKey value, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefaultAsync(conn, selectFields, id, value, null, cancellationToken);
        }

        public static Task<TEntity> SingleOrDefaultAsync<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, Expression<Func<TEntity, object>> id, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.SingleOrDefaultAsync(conn, selectFields, id, value, tr, default(CancellationToken));
        }
    }
}