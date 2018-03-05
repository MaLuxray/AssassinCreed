
using System;
using System.Data;
using System.Linq.Expressions;

using AssassinCore.Common;
using AssassinCore.Where;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    // DefaultEntityStore`Delete
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public void Delete(IStorageDbConnection conn, Expression<Func<TEntity, object>> id, TKey value, IDbTransaction tr)
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
            conn.Execute(result.CommandText, result.Parameters, tr);
        }

        public void Delete(IStorageDbConnection conn, WhereClauseResult whereClause, IDbTransaction tr)
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
            conn.Execute(result.CommandText, result.Parameters, tr);
        }

        protected CommandTextEventInfo ConstructDeleteSql(Expression<Func<TEntity, object>> id, TKey value)
            => ConstructService.ConstructDeleteSql(id, value);

        protected CommandTextEventInfo ConstructDeleteSql(WhereClauseResult whereClause)
            => ConstructService.ConstructDeleteSql(typeof(TEntity), whereClause);
    }
}