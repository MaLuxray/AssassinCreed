
using System;
using System.Data;
using System.Globalization;
using System.Linq.Expressions;

using AssassinCore.Common;
using AssassinCore.Where;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    // DefaultEntityStore`Count
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public long Count(IStorageDbConnection conn, Expression<Func<TEntity, object>> member, WhereClauseResult whereClause, IDbTransaction tr)
        {
            if (conn == null)
            {
                throw new ArgumentNullException(nameof(conn));
            }

            var result = ConstructCountSql(member, whereClause);
            conn.TextWriter.WriteSql(result.CommandText);
            return (long)Convert.ChangeType(conn.QuerySingle(typeof(long), result.CommandText, result.Parameters, tr), typeof(long), CultureInfo.InvariantCulture);
        }

        protected CommandTextEventInfo ConstructCountSql(Expression<Func<TEntity, object>> member, WhereClauseResult whereClause)
            => ConstructService.ConstructCountSql<TKey, TEntity>(member, whereClause);
    }
}