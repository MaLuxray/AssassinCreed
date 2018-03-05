
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

using AssassinCore.Common;
using AssassinCore.Where;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    // DefaultEntityStore`Update
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public void Update(IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, Expression<Func<TEntity, object>> id, TKey value, IDbTransaction tr)
        {
            if (conn == null)
            {
                throw new ArgumentNullException(nameof(conn));
            }
            if (entityToUpdate == null)
            {
                throw new ArgumentNullException(nameof(entityToUpdate));
            }
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var result = ConstructUpdateSql(entityToUpdate, updateFields, id, value);
            conn.TextWriter.WriteSql(result.CommandText);
            conn.Execute(result.CommandText, result.Parameters, tr);
        }

        public void Update(IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, WhereClauseResult whereClause, IDbTransaction tr)
        {
            if (conn == null)
            {
                throw new ArgumentNullException(nameof(conn));
            }
            if (entityToUpdate == null)
            {
                throw new ArgumentNullException(nameof(entityToUpdate));
            }

            var result = ConstructUpdateSql(entityToUpdate, updateFields, whereClause);
            conn.TextWriter.WriteSql(result.CommandText);
            conn.Execute(result.CommandText, result.Parameters, tr);
        }

        protected CommandTextEventInfo ConstructUpdateSql(TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, Expression<Func<TEntity, object>> id, TKey value)
            => ConstructService.ConstructUpdateSql(LogicFields, entityToUpdate, updateFields, id, value);

        protected CommandTextEventInfo ConstructUpdateSql(TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, WhereClauseResult whereClause)
            => ConstructService.ConstructUpdateSql<TKey, TEntity>(LogicFields, entityToUpdate, updateFields, whereClause);
    }
}