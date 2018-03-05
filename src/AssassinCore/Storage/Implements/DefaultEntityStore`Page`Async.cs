
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Common;
using AssassinCore.Sorting;
using AssassinCore.Where;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    // DefaultEntityStore`Page`Async
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public async Task<IPageResult<TEntity>> PageAsync(IStorageDbConnection conn, int skip, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause, IDbTransaction tr, CancellationToken cancellationToken)
        {
            if (conn == null)
            {
                throw new ArgumentNullException(nameof(conn));
            }

            if (skip < 0)
                skip = 0;

            var result = ConstructPageSql(skip, take, selectFields, whereClause, orderbyClause.IsNull ? CreateDefaultOrderbyClause() : orderbyClause);
            conn.TextWriter.WriteSql(result.CommandText);
            var cmd = CreateDapperCmd(result.CommandText, result.Parameters, tr, cancellationToken);
            var gridReader = await conn.QueryMultipleAsync(cmd);
            var totalNumberOfRecords = (long)Convert.ChangeType(await gridReader.ReadSingleAsync(typeof(long)), typeof(long), CultureInfo.InvariantCulture);
            var list = (await gridReader.ReadAsync<TEntity>()).AsList();

            return new PageResult<TEntity>(skip, take, totalNumberOfRecords, list);
        }
    }
}