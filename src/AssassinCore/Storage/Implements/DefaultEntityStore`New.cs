
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq.Expressions;

using AssassinCore.Common;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    // DefaultEntityStore`New
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public TEntity Insert(IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, AutoIncrementTransformer<TKey, TEntity> atf, IDbTransaction tr)
        {
            if (conn == null)
            {
                throw new ArgumentNullException(nameof(conn));
            }
            if (entityToInsert == null)
            {
                throw new ArgumentNullException(nameof(entityToInsert));
            }

            var result = ConstructInsertSql(entityToInsert, ignoredFields, atf != null);
            conn.TextWriter.WriteSql(result.CommandText);

            if (atf == null)
            {
                conn.Execute(result.CommandText, result.Parameters, tr);
            }
            else
            {
                var id = (TKey)Convert.ChangeType(conn.QuerySingle(typeof(TKey), result.CommandText, result.Parameters, tr), typeof(TKey), CultureInfo.InvariantCulture);
                atf(id, entityToInsert);
            }

            return entityToInsert;
        }

        protected CommandTextEventInfo ConstructInsertSql(TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, bool autoIncrement)
            => ConstructService.ConstructInsertSql<TKey, TEntity>(LogicFields, entityToInsert, ignoredFields, autoIncrement);
    }
}