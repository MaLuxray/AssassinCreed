
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

using AssassinCore.Common;
using AssassinCore.Sorting;
using AssassinCore.Where;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    // DefaultEntityStore`Take
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public IEnumerable<TEntity> Take(IStorageDbConnection conn, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause, IDbTransaction tr)
        {
            if (conn == null)
            {
                throw new ArgumentNullException(nameof(conn));
            }

            var result = ConstructTakeSql(take, selectFields, whereClause, orderbyClause.IsNull ? CreateDefaultOrderbyClause() : orderbyClause);
            conn.TextWriter.WriteSql(result.CommandText);
            return conn.Query<TEntity>(result.CommandText, result.Parameters, tr).AsList();
        }

        protected CommandTextEventInfo ConstructTakeSql(int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause)
            => ConstructService.ConstructTakeSql<TKey, TEntity>(LogicFields, take, selectFields, whereClause, orderbyClause);
    }
}