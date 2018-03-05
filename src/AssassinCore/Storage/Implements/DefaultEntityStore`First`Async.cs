
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Common;
using AssassinCore.Sorting;
using AssassinCore.Where;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    // DefaultEntityStore`First`Async
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public async Task<TEntity> FirstOrDefaultAsync(IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause, IDbTransaction tr, CancellationToken cancellationToken)
        {
            if (conn == null)
            {
                throw new ArgumentNullException(nameof(conn));
            }

            var result = ConstructFirstSql(selectFields, whereClause, orderbyClause.IsNull ? CreateDefaultOrderbyClause() : orderbyClause);
            conn.TextWriter.WriteSql(result.CommandText);
            var cmd = CreateDapperCmd(result.CommandText, result.Parameters, tr, cancellationToken);
            return (await conn.QueryAsync<TEntity>(cmd)).FirstOrDefault();
        }
    }
}