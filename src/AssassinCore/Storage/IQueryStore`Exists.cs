
using System;
using System.Data;

using AssassinCore.Where;

namespace AssassinCore.Storage
{
    // IQueryStore`Exists
    public partial interface IQueryStore<in TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        bool Exists(
            IStorageDbConnection conn,
            WhereClauseResult whereClause,
            IDbTransaction tr);
    }
}