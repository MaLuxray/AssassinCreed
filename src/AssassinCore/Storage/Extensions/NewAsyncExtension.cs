
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class NewAsyncExtension
    {
        public static Task<TEntity> InsertAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, null, null, null, default(CancellationToken));
        }

        public static Task<TEntity> InsertAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, null, null, null, cancellationToken);
        }

        public static Task<TEntity> InsertAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, null, null, tr, default(CancellationToken));
        }

        public static Task<TEntity> InsertAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, null, null, tr, cancellationToken);
        }

        public static Task<TEntity> InsertAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, ignoredFields, null, null, default(CancellationToken));
        }

        public static Task<TEntity> InsertAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, ignoredFields, null, null, cancellationToken);
        }

        public static Task<TEntity> InsertAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, ignoredFields, null, tr, default(CancellationToken));
        }

        public static Task<TEntity> InsertAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, ignoredFields, null, tr, cancellationToken);
        }


        public static Task<TEntity> InsertAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, AutoIncrementTransformer<TKey, TEntity> atf)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, null, atf, null, default(CancellationToken));
        }

        public static Task<TEntity> InsertAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, AutoIncrementTransformer<TKey, TEntity> atf, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, null, atf, null, cancellationToken);
        }

        public static Task<TEntity> InsertAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, AutoIncrementTransformer<TKey, TEntity> atf, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, null, atf, tr, default(CancellationToken));
        }

        public static Task<TEntity> InsertAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, AutoIncrementTransformer<TKey, TEntity> atf, IDbTransaction tr, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, null, atf, tr, cancellationToken);
        }

        public static Task<TEntity> InsertAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, AutoIncrementTransformer<TKey, TEntity> atf)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, ignoredFields, atf, null, default(CancellationToken));
        }

        public static Task<TEntity> InsertAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, AutoIncrementTransformer<TKey, TEntity> atf, CancellationToken cancellationToken)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, ignoredFields, atf, null, cancellationToken);
        }

        public static Task<TEntity> InsertAsync<TKey, TEntity>(this INewEntityStore<TKey, TEntity> newStore, IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, AutoIncrementTransformer<TKey, TEntity> atf, IDbTransaction tr)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (newStore == null)
            {
                throw new ArgumentNullException(nameof(newStore));
            }
            return newStore.InsertAsync(conn, entityToInsert, ignoredFields, atf, tr, default(CancellationToken));
        }
    }
}