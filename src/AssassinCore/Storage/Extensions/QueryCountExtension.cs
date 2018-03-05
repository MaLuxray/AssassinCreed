
using System;
using System.Data;
using System.Linq.Expressions;

using AssassinCore.Where;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class QueryCountExtension
    {
        public static long Count<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Count(conn, null, WhereClauseResult.Null, null);
        }

        public static long Count<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Count(conn, null, WhereClauseResult.Null, tr);
        }

        public static long Count<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, Expression<Func<TEntity, object>> member)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Count(conn, member, WhereClauseResult.Null, null);
        }

        public static long Count<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, Expression<Func<TEntity, object>> member, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Count(conn, member, WhereClauseResult.Null, tr);
        }

        public static long Count<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Count(conn, null, whereClause, null);
        }

        public static long Count<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, WhereClauseResult whereClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Count(conn, null, whereClause, tr);
        }

        public static long Count<TKey, TEntity>(this IQueryStore<TKey, TEntity> queryStore, IStorageDbConnection conn, Expression<Func<TEntity, object>> member, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (queryStore == null)
            {
                throw new ArgumentNullException(nameof(queryStore));
            }
            return queryStore.Count(conn, member, whereClause, null);
        }
    }
}