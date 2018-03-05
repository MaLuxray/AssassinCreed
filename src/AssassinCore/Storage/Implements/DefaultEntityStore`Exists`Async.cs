
using System;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Common;
using AssassinCore.Where;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    // DefaultEntityStore`Exists`Async
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public async Task<bool> ExistsAsync(IStorageDbConnection conn, WhereClauseResult whereClause, IDbTransaction tr, CancellationToken cancellationToken)
        {
            if (conn == null)
            {
                throw new ArgumentNullException(nameof(conn));
            }

            var result = ConstructExistsSql(whereClause);
            conn.TextWriter.WriteSql(result.CommandText);
            var cmd = CreateDapperCmd(result.CommandText, result.Parameters, tr, cancellationToken);
            return (bool)Convert.ChangeType(await conn.QuerySingleAsync(typeof(int), cmd), typeof(bool), CultureInfo.InvariantCulture);
        }
    }
}