
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Where;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class UpdateAsyncExtension
    {
        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, WhereClauseResult.Null, null, default(CancellationToken));
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, WhereClauseResult.Null, null, cancellationToken);
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, WhereClauseResult.Null, tr, default(CancellationToken));
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, WhereClauseResult.Null, tr, cancellationToken);
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, updateFields, WhereClauseResult.Null, null, default(CancellationToken));
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, updateFields, WhereClauseResult.Null, null, cancellationToken);
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, updateFields, WhereClauseResult.Null, tr, default(CancellationToken));
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, updateFields, WhereClauseResult.Null, tr, cancellationToken);
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, whereClause, null, default(CancellationToken));
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, WhereClauseResult whereClause, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, whereClause, null, cancellationToken);
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, WhereClauseResult whereClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, whereClause, tr, default(CancellationToken));
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, WhereClauseResult whereClause, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, whereClause, tr, cancellationToken);
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, updateFields, whereClause, null, default(CancellationToken));
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, WhereClauseResult whereClause, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, updateFields, whereClause, null, cancellationToken);
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, WhereClauseResult whereClause, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, updateFields, whereClause, tr, default(CancellationToken));
        }
    }
}