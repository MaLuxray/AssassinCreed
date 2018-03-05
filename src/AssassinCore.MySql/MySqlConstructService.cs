
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using AssassinCore.Common;
using AssassinCore.Sorting;
using AssassinCore.Storage;
using AssassinCore.Where;

namespace AssassinCore.MySql
{
    public class MySqlConstructService : IStorageConstructService
    {
        private readonly StorageDialectSettings _dialectSettings;

        public MySqlConstructService(StorageDialectSettings dialectSettings)
        {
            _dialectSettings = dialectSettings ?? throw new ArgumentNullException(nameof(dialectSettings));
        }

        public CommandTextEventInfo ConstructInsertSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, bool autoIncrement) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            throw new NotImplementedException();
        }

        public CommandTextEventInfo ConstructDeleteSql<TKey, TEntity>(Expression<Func<TEntity, object>> id, TKey value) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            throw new NotImplementedException();
        }

        public CommandTextEventInfo ConstructDeleteSql(Type entityType, WhereClauseResult whereClause)
        {
            throw new NotImplementedException();
        }

        public CommandTextEventInfo ConstructUpdateSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, TEntity entityToUpdate,IEnumerable<Expression<Func<TEntity, object>>> updateFields, Expression<Func<TEntity, object>> id, TKey value) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            throw new NotImplementedException();
        }

        public CommandTextEventInfo ConstructUpdateSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, TEntity entityToUpdate,IEnumerable<Expression<Func<TEntity, object>>> updateFields, WhereClauseResult whereClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            throw new NotImplementedException();
        }

        public CommandTextEventInfo ConstructCountSql<TKey, TEntity>(Expression<Func<TEntity, object>> member, WhereClauseResult whereClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            throw new NotImplementedException();
        }

        public CommandTextEventInfo ConstructExistsSql(Type entityType, WhereClauseResult whereClause)
        {   
            throw new NotImplementedException();
        }

        public CommandTextEventInfo ConstructSingleSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, IEnumerable<Expression<Func<TEntity, object>>> selectFields, Expression<Func<TEntity, object>> id,TKey value) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            throw new NotImplementedException();
        }

        public CommandTextEventInfo ConstructFirstSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            throw new NotImplementedException();
        }

        public CommandTextEventInfo ConstructPageSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, int skip, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields,WhereClauseResult whereClause, OrderbyClauseResult orderbyClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            throw new NotImplementedException();
        }

        public CommandTextEventInfo ConstructSelectSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            throw new NotImplementedException();
        }

        public CommandTextEventInfo ConstructTakeSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields,WhereClauseResult whereClause, OrderbyClauseResult orderbyClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            throw new NotImplementedException();
        }

        public OrderbyClauseResult ConstructOrderbyClause<TKey, TEntity>(Expression<Func<TEntity, object>> member, OrderbyType orderbyType) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            return (OrderbyClauseResult)$"{_dialectSettings.GetEscapeName(member)} {(orderbyType == OrderbyType.Ascending ? "ASC" : "DESC")}";
        }
    }
}