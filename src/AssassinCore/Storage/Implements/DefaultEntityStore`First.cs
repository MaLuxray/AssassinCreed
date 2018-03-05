
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

using AssassinCore.Common;
using AssassinCore.Sorting;
using AssassinCore.Where;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    // DefaultEntityStore`First
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public TEntity FirstOrDefault(IStorageDbConnection conn, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause, IDbTransaction tr)
        {
            if (conn == null)
            {
                throw new ArgumentNullException(nameof(conn));
            }

            var result = ConstructFirstSql(selectFields, whereClause, orderbyClause.IsNull ? CreateDefaultOrderbyClause() : orderbyClause);
            conn.TextWriter.WriteSql(result.CommandText);
            return conn.Query<TEntity>(result.CommandText, result.Parameters, tr).FirstOrDefault();
        }

        protected CommandTextEventInfo ConstructFirstSql(IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause)
            => ConstructService.ConstructFirstSql<TKey, TEntity>(LogicFields, selectFields, whereClause, orderbyClause);
    }
}