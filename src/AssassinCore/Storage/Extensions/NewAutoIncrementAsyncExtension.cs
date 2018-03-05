
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class NewAutoIncrementAsyncExtension
    {
        public static Task<TEntity> InsertAutoIncrementAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, new Expression<Func<TEntity, object>>[] { _ => _.Id, }, (a, b) => b.Id = a, null, default(CancellationToken));
        }

        public static Task<TEntity> InsertAutoIncrementAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, new Expression<Func<TEntity, object>>[] { _ => _.Id, }, (a, b) => b.Id = a, null, cancellationToken);
        }

        public static Task<TEntity> InsertAutoIncrementAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, new Expression<Func<TEntity, object>>[] { _ => _.Id, }, (a, b) => b.Id = a, tr, default(CancellationToken));
        }

        public static Task<TEntity> InsertAutoIncrementAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, new Expression<Func<TEntity, object>>[] { _ => _.Id, }, (a, b) => b.Id = a, tr, cancellationToken);
        }

        public static Task<TEntity> InsertAutoIncrementAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, ignoredFields, (a, b) => b.Id = a, null, default(CancellationToken));
        }

        public static Task<TEntity> InsertAutoIncrementAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, ignoredFields, (a, b) => b.Id = a, null, cancellationToken);
        }

        public static Task<TEntity> InsertAutoIncrementAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, ignoredFields, (a, b) => b.Id = a, tr, default(CancellationToken));
        }

        public static Task<TEntity> InsertAutoIncrementAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, ignoredFields, (a, b) => b.Id = a, tr, cancellationToken);
        }
    }
}