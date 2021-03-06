﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

using AssassinCore.Sorting;
using AssassinCore.Where;

namespace AssassinCore.Storage
{
    // IQueryStore`Page
    public partial interface IQueryStore<in TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        IPageResult<TEntity> Page(
            IStorageDbConnection conn,
            int skip,
            int take,
            IEnumerable<Expression<Func<TEntity, object>>> selectFields,
            WhereClauseResult whereClause,
            OrderbyClauseResult orderbyClause,
            IDbTransaction tr);
    }
}