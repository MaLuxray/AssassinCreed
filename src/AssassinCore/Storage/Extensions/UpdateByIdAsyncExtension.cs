
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class UpdateByIdAsyncExtension
    {
        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, _ => _.Id, value, null, default(CancellationToken));
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, TKey value, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, _ => _.Id, value, null, cancellationToken);
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, _ => _.Id, value, tr, default(CancellationToken));
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, TKey value, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, _ => _.Id, value, tr, cancellationToken);
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, updateFields, _ => _.Id, value, null, default(CancellationToken));
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, TKey value, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, updateFields, _ => _.Id, value, null, cancellationToken);
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, updateFields, _ => _.Id, value, tr, default(CancellationToken));
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, TKey value, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, updateFields, _ => _.Id, value, tr, cancellationToken);
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, Expression<Func<TEntity, object>> id, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, id, value, null, default(CancellationToken));
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, Expression<Func<TEntity, object>> id, TKey value, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, id, value, null, cancellationToken);
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, Expression<Func<TEntity, object>> id, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, id, value, tr, default(CancellationToken));
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, Expression<Func<TEntity, object>> id, TKey value, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, null, id, value, tr, cancellationToken);
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, Expression<Func<TEntity, object>> id, TKey value)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, updateFields, id, value, null, default(CancellationToken));
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, Expression<Func<TEntity, object>> id, TKey value, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, updateFields, id, value, null, cancellationToken);
        }

        public static Task UpdateAsync<TKey, TEntity>(this IUpdateStore<TKey, TEntity> updateStore, IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, Expression<Func<TEntity, object>> id, TKey value, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (updateStore == null)
            {
                throw new ArgumentNullException(nameof(updateStore));
            }
            return updateStore.UpdateAsync(conn, entityToUpdate, updateFields, id, value, tr, default(CancellationToken));
        }
    }
}