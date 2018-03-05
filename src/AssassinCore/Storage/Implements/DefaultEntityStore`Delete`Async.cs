
using System;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Common;
using AssassinCore.Where;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    // DefaultEntityStore`Delete`Async
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public async Task DeleteAsync(IStorageDbConnection conn, Expression<Func<TEntity, object>> id, TKey value, IDbTransaction tr, CancellationToken cancellationToken)
        {
            if (conn == null)
            {
                throw new ArgumentNullException(nameof(conn));
            }
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var result = ConstructDeleteSql(id, value);
            conn.TextWriter.WriteSql(result.CommandText);
            var cmd = CreateDapperCmd(result.CommandText, result.Parameters, tr, cancellationToken);
            await conn.ExecuteAsync(cmd);
        }

        public async Task DeleteAsync(IStorageDbConnection conn, WhereClauseResult whereClause, IDbTransaction tr, CancellationToken cancellationToken)
        {
            if (conn == null)
            {
                throw new ArgumentNullException(nameof(conn));
            }
            if (whereClause == null)
            {
                throw new ArgumentNullException(nameof(whereClause));
            }

            var result = ConstructDeleteSql(whereClause);
            conn.TextWriter.WriteSql(result.CommandText);
            var cmd = CreateDapperCmd(result.CommandText, result.Parameters, tr, cancellationToken);
            await conn.ExecuteAsync(cmd);
        }
    }
}