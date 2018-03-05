
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq.Expressions;

using AssassinCore.Common;
using AssassinCore.Sorting;
using AssassinCore.Where;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    // DefaultEntityStore`Page
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public IPageResult<TEntity> Page(IStorageDbConnection conn, int skip, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause, IDbTransaction tr)
        {
            if (conn == null)
            {
                throw new ArgumentNullException(nameof(conn));
            }

            if (skip < 0)
                skip = 0;

            var result = ConstructPageSql(skip, take, selectFields, whereClause, orderbyClause.IsNull ? CreateDefaultOrderbyClause() : orderbyClause);
            conn.TextWriter.WriteSql(result.CommandText);
            var gridReader = conn.QueryMultiple(result.CommandText, result.Parameters, tr);
            var totalNumberOfRecords = (long)Convert.ChangeType(gridReader.ReadSingle(typeof(long)), typeof(long), CultureInfo.InvariantCulture);
            var list = gridReader.Read<TEntity>().AsList();

            return new PageResult<TEntity>(skip, take, totalNumberOfRecords, list);
        }

        protected CommandTextEventInfo ConstructPageSql(int skip, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause)
            => ConstructService.ConstructPageSql<TKey, TEntity>(LogicFields, skip, take, selectFields, whereClause, orderbyClause);
    }
}