
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

using AssassinCore.Common;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    // DefaultEntityStore`Single
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public TEntity SingleOrDefault(IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, Expression<Func<TEntity, object>> id, TKey value, IDbTransaction tr)
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
            return conn.Query<TEntity>(result.CommandText, result.Parameters, tr).SingleOrDefault();
        }

        protected CommandTextEventInfo ConstructSingleSql(IEnumerable<Expression<Func<TEntity, object>>> selectFields, Expression<Func<TEntity, object>> id, TKey value)
            => ConstructService.ConstructSingleSql(LogicFields, selectFields, id, value);
    }
}