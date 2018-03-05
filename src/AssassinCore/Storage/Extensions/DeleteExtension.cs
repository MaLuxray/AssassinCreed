
using System;

using AssassinCore.Where;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class DeleteExtension
    {
        public static void Delete<TKey, TEntity>(this IDeleteStore<TKey, TEntity> deleteStore, IStorageDbConnection conn, WhereClauseResult whereClause)
            where TKey : IEquatable<TKey>
            where TEntity : class, IEntity<TKey>
        {
            if (deleteStore == null)
            {
                throw new ArgumentNullException(nameof(deleteStore));
            }
            deleteStore.Delete(conn, whereClause, null);
        }
    }
}