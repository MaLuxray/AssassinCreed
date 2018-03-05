
using System;
using System.Data;
using System.Linq.Expressions;

using AssassinCore.Where;

namespace AssassinCore.Storage
{
    public partial interface IDeleteStore<in TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        void Delete(
            IStorageDbConnection conn,
            Expression<Func<TEntity, object>> id, 
            TKey value, 
            IDbTransaction tr);

        void Delete(
            IStorageDbConnection conn,
            WhereClauseResult whereClause, 
            IDbTransaction tr);
    }
}