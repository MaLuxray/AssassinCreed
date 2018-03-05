
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Common;
using AssassinCore.Where;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public async Task UpdateAsync(IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, Expression<Func<TEntity, object>> id, TKey value, IDbTransaction tr, CancellationToken cancellationToken)
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
            var cmd = CreateDapperCmd(result.CommandText, result.Parameters, tr, cancellationToken);
            await conn.ExecuteAsync(cmd);
        }

        public async Task UpdateAsync(IStorageDbConnection conn, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, WhereClauseResult whereClause, IDbTransaction tr, CancellationToken cancellationToken)
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
            var cmd = CreateDapperCmd(result.CommandText, result.Parameters, tr, cancellationToken);
            await conn.ExecuteAsync(cmd);
        }
    }
}