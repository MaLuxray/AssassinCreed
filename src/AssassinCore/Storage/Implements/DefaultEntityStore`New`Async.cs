
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Common;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    // DefaultEntityStore`New`Async
    public abstract partial class DefaultEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        public async Task<TEntity> InsertAsync(IStorageDbConnection conn, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, AutoIncrementTransformer<TKey, TEntity> atf, IDbTransaction tr, CancellationToken cancellationToken)
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
            var cmd = CreateDapperCmd(result.CommandText, result.Parameters, tr, cancellationToken);

            if (atf == null)
            {
                await conn.ExecuteAsync(cmd);
            }
            else
            {
                var id = (TKey)Convert.ChangeType(await conn.QuerySingleAsync(typeof(TKey), cmd), typeof(TKey), CultureInfo.InvariantCulture);
                atf(id, entityToInsert);
            }

            return entityToInsert;
        }
    }
}