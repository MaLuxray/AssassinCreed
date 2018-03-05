
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Common;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    // DefaultEntityStore`Single`Async
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public async Task<TEntity> SingleOrDefaultAsync(IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, Expression<Func<TEntity, object>> id, TKey value, IDbTransaction tr, CancellationToken cancellationToken)
        {
            if (conn == null)
            {
                throw new ArgumentNullException(nameof(conn));
            }
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var result = ConstructSingleSql(selectFields, id, value);
            conn.TextWriter.WriteSql(result.CommandText);
            var cmd = CreateDapperCmd(result.CommandText, result.Parameters, tr, cancellationToken);
            return (await conn.QueryAsync<TEntity>(cmd)).SingleOrDefault();
        }
    }
}