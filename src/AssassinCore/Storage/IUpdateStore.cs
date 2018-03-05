
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

using AssassinCore.Where;

namespace AssassinCore.Storage
{
    public partial interface IUpdateStore<in TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    { 
        void Update(
            IStorageDbConnection conn,
            TEntity entityToUpdate,
            IEnumerable<Expression<Func<TEntity, object>>> updateFields, 
            Expression<Func<TEntity, object>> id,
            TKey value, 
            IDbTransaction tr);

        void Update(
            IStorageDbConnection conn,
            TEntity entityToUpdate, 
            IEnumerable<Expression<Func<TEntity, object>>> updateFields, 
            WhereClauseResult whereClause,
            IDbTransaction tr);
    }
}