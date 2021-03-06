﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Sorting;
using AssassinCore.Where;

namespace AssassinCore.Storage
{
    // IQueryStore`Page`Async
    public partial interface IQueryStore<in TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        Task<IPageResult<TEntity>> PageAsync(
            IStorageDbConnection conn,
            int skip,
            int take,
            IEnumerable<Expression<Func<TEntity, object>>> selectFields,
            WhereClauseResult whereClause,
            OrderbyClauseResult orderbyClause,
            IDbTransaction tr,
            CancellationToken cancellationToken);
    }
}