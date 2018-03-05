
using System;
using System.Data;
using System.Globalization;

using AssassinCore.Common;
using AssassinCore.Where;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    // DefaultEntityStore`Exists
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public bool Exists(IStorageDbConnection conn, WhereClauseResult whereClause, IDbTransaction tr)
        {
            if (conn == null)
            {
                throw new ArgumentNullException(nameof(conn));
            }

            var result = ConstructExistsSql(whereClause);
            conn.TextWriter.WriteSql(result.CommandText);
            return (bool)Convert.ChangeType(conn.QuerySingle(typeof(int), result.CommandText, result.Parameters, tr), typeof(bool), CultureInfo.InvariantCulture);
        }

        protected CommandTextEventInfo ConstructExistsSql(WhereClauseResult whereClause)
            => ConstructService.ConstructExistsSql(typeof(TEntity), whereClause);
    }
}