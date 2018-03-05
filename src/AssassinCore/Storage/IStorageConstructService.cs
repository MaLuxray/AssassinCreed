
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using AssassinCore.Sorting;
using AssassinCore.Where;

namespace AssassinCore.Storage
{
    public interface IStorageConstructService
    {
        CommandTextEventInfo ConstructInsertSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, bool autoIncrement) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>;

        CommandTextEventInfo ConstructDeleteSql<TKey, TEntity>(Expression<Func<TEntity, object>> id, TKey value) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>;

        CommandTextEventInfo ConstructDeleteSql(Type entityType, WhereClauseResult whereClause);

        CommandTextEventInfo ConstructUpdateSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, Expression<Func<TEntity, object>> id, TKey value) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>;

        CommandTextEventInfo ConstructUpdateSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, WhereClauseResult whereClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>;

        CommandTextEventInfo ConstructCountSql<TKey, TEntity>(Expression<Func<TEntity, object>> member, WhereClauseResult whereClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>;

        CommandTextEventInfo ConstructExistsSql(Type entityType, WhereClauseResult whereClause);

        CommandTextEventInfo ConstructSingleSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, IEnumerable<Expression<Func<TEntity, object>>> selectFields, Expression<Func<TEntity, object>> id, TKey value) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>;

        CommandTextEventInfo ConstructFirstSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>;

        CommandTextEventInfo ConstructPageSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, int skip, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>;

        CommandTextEventInfo ConstructSelectSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>;

        CommandTextEventInfo ConstructTakeSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>;

        OrderbyClauseResult ConstructOrderbyClause<TKey, TEntity>(Expression<Func<TEntity, object>> member, OrderbyType orderbyType) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>;
    }
}