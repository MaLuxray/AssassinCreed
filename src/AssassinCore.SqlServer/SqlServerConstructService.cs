
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

using AssassinCore.Common;
using AssassinCore.Sorting;
using AssassinCore.Storage;
using AssassinCore.Where;

using Dapper;

namespace AssassinCore.SqlServer
{
    public class SqlServerConstructService : IStorageConstructService
    {
        private readonly StorageDialectSettings _dialectSettings;

        public SqlServerConstructService(StorageDialectSettings dialectSettings)
        {
            _dialectSettings = dialectSettings ?? throw new ArgumentNullException(nameof(dialectSettings));
        }

        public CommandTextEventInfo ConstructInsertSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, TEntity entityToInsert, IEnumerable<Expression<Func<TEntity, object>>> ignoredFields, bool autoIncrement) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            if (entityToInsert == null)
            {
                throw new ArgumentNullException(nameof(entityToInsert));
            }

            var writer = new StringTextWriter();
            var dynParms = new DynamicParameters();
            var entityType = typeof(TEntity);
            var tableName = _dialectSettings.GetEscapeName(entityType);

            var tp = entityType.GetRuntimeProperties().Where(p => p.PropertyType.IsSimpleType());
            if (logicFields != null)
            {
                tp = tp.Where(p => !logicFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }
            if (ignoredFields != null)
            {
                tp = tp.Where(p => !ignoredFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }

            var properties = tp.ToList();
            var kvps = new List<KeyValuePair<string, string>>(properties.Count);
            foreach (var property in properties)
            {
                var paramName = _dialectSettings.GetParameterName(property);
                dynParms.Add(paramName, property.GetValue(entityToInsert));
                kvps.Add(new KeyValuePair<string, string>(_dialectSettings.GetEscapeName(property), paramName));
            }

            writer.Write($"INSERT INTO {tableName} ({string.Join(", ", kvps.Select(kvp => kvp.Key))}) VALUES ({string.Join(", ", kvps.Select(kvp => kvp.Value))}) ;");
            // ReSharper disable once InvertIf
            if (autoIncrement)
            {
                writer.Write(_dialectSettings.GetIdentitySql);
                writer.Write(" ;");
            }

            return new CommandTextEventInfo(writer.ToStringWithClear(), dynParms);
        }

        public CommandTextEventInfo ConstructDeleteSql<TKey, TEntity>(Expression<Func<TEntity, object>> id, TKey value) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var writer = new StringTextWriter();
            var dynParms = new DynamicParameters();
            var entityType = typeof(TEntity);
            var tableName = _dialectSettings.GetEscapeName(entityType);

            var idParamName = _dialectSettings.GetParameterName(id.GetMemberName());
            dynParms.Add(idParamName, value);
            writer.Write($"DELETE FROM {tableName} WHERE ({_dialectSettings.GetEscapeName(id)} = {idParamName}) ;");

            return new CommandTextEventInfo(writer.ToStringWithClear(), dynParms);
        }

        public CommandTextEventInfo ConstructDeleteSql(Type entityType, WhereClauseResult whereClause)
        {
            if (entityType == null)
            {
                throw new ArgumentNullException(nameof(entityType));
            }

            var writer = new StringTextWriter();
            var dynParms = new DynamicParameters();
            var tableName = _dialectSettings.GetEscapeName(entityType);

            writer.Write($"DELETE FROM {tableName} ");
            if (whereClause != null)
            {
                writer.Write($"WHERE ({whereClause}) ");
                dynParms.AdddWhereClause(whereClause);
            }
            writer.Write(";");

            return new CommandTextEventInfo(writer.ToStringWithClear(), dynParms);
        }

        public CommandTextEventInfo ConstructUpdateSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, Expression<Func<TEntity, object>> id, TKey value) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            if (entityToUpdate == null)
            {
                throw new ArgumentNullException(nameof(entityToUpdate));
            }
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var writer = new StringTextWriter();
            var dynParms = new DynamicParameters();
            var entityType = typeof(TEntity);
            var tableName = _dialectSettings.GetEscapeName(entityType);

            var tp = entityType.GetRuntimeProperties().Where(p => p.PropertyType.IsSimpleType());
            if (logicFields != null)
            {
                tp = tp.Where(p => !logicFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }
            if (updateFields != null)
            {
                tp = tp.Where(p => updateFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }

            var properties = tp.ToList();
            var kvps = new List<KeyValuePair<string, string>>(properties.Count);
            foreach (var property in properties)
            {
                var paramName = _dialectSettings.GetParameterName(property);
                dynParms.Add(paramName, property.GetValue(entityToUpdate));
                kvps.Add(new KeyValuePair<string, string>(_dialectSettings.GetEscapeName(property), paramName));
            }

            var idParamName = _dialectSettings.GetParameterName(id.GetMemberName());
            dynParms.Add(idParamName, value);
            writer.Write($"UPDATE {tableName} SET {string.Join(", ", kvps.Select(kvp => $"{kvp.Key} = {kvp.Value}"))} WHERE ({_dialectSettings.GetEscapeName(id.GetMemberName())} = {idParamName}) ;");

            return new CommandTextEventInfo(writer.ToStringWithClear(), dynParms);
        }

        public CommandTextEventInfo ConstructUpdateSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, TEntity entityToUpdate, IEnumerable<Expression<Func<TEntity, object>>> updateFields, WhereClauseResult whereClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            if (entityToUpdate == null)
            {
                throw new ArgumentNullException(nameof(entityToUpdate));
            }

            var writer = new StringTextWriter();
            var dynParms = new DynamicParameters();
            var entityType = typeof(TEntity);
            var tableName = _dialectSettings.GetEscapeName(entityType);

            var tp = entityType.GetRuntimeProperties().Where(p => p.PropertyType.IsSimpleType());
            if (logicFields != null)
            {
                tp = tp.Where(p => !logicFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }
            if (updateFields != null)
            {
                tp = tp.Where(p => updateFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }

            var properties = tp.ToList();
            var kvps = new List<KeyValuePair<string, string>>(properties.Count);
            foreach (var property in properties)
            {
                var paramName = _dialectSettings.GetParameterName(property);
                dynParms.Add(paramName, property.GetValue(entityToUpdate));
                kvps.Add(new KeyValuePair<string, string>(_dialectSettings.GetEscapeName(property), paramName));
            }

            writer.Write($"UPDATE {tableName} SET {string.Join(", ", kvps.Select(kvp => $"{kvp.Key} = {kvp.Value}"))} ");
            if (whereClause != null)
            {
                writer.Write($"WHERE ({whereClause}) ");
                dynParms.AdddWhereClause(whereClause);
            }
            writer.Write(";");

            return new CommandTextEventInfo(writer.ToStringWithClear(), dynParms);
        }

        public CommandTextEventInfo ConstructCountSql<TKey, TEntity>(Expression<Func<TEntity, object>> member, WhereClauseResult whereClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            var writer = new StringTextWriter();
            var dynParms = new DynamicParameters();
            var entityType = typeof(TEntity);
            var tableName = _dialectSettings.GetEscapeName(entityType);

            writer.Write($"SELECT COUNT({(member == null ? "1" : _dialectSettings.GetEscapeName(member))}) AS _TotalNumberOfRecords FROM {tableName} ");
            if (whereClause != null)
            {
                writer.Write($"WHERE ({whereClause}) ");
                dynParms.AdddWhereClause(whereClause);
            }
            writer.Write(";");

            return new CommandTextEventInfo(writer.ToStringWithClear(), dynParms);
        }

        public CommandTextEventInfo ConstructExistsSql(Type entityType, WhereClauseResult whereClause)
        {
            var writer = new StringTextWriter();
            var dynParms = new DynamicParameters();
            var tableName = _dialectSettings.GetEscapeName(entityType);

            writer.Write("SELECT ISNULL(");
            writer.Write("(");
            writer.Write($"SELECT TOP(1) 1 FROM {tableName}");
            if (whereClause != null)
            {
                writer.Write($"WHERE ({whereClause}) ");
                dynParms.AdddWhereClause(whereClause);
            }
            writer.Write("),0");
            writer.Write(") AS _ExistsFlag ;");

            return new CommandTextEventInfo(writer.ToStringWithClear(), dynParms);
        }

        public CommandTextEventInfo ConstructSingleSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, IEnumerable<Expression<Func<TEntity, object>>> selectFields, Expression<Func<TEntity, object>> id, TKey value) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var writer = new StringTextWriter();
            var dynParms = new DynamicParameters();
            var entityType = typeof(TEntity);
            var tableName = _dialectSettings.GetEscapeName(entityType);

            var tp = entityType.GetRuntimeProperties().Where(p => p.PropertyType.IsSimpleType());
            if (logicFields != null)
            {
                tp = tp.Where(p => !logicFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }
            if (selectFields != null)
            {
                tp = tp.Where(p => selectFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }

            var idParamName = _dialectSettings.GetParameterName(id.GetMemberName());
            dynParms.Add(idParamName, value);
            writer.Write($"SELECT TOP(1) {string.Join(", ", tp.Select(p => _dialectSettings.GetEscapeName(p)))} FROM {tableName} ");
            writer.Write($" WHERE ({_dialectSettings.GetEscapeName(id)} = {idParamName}) ");
            writer.Write(";");

            return new CommandTextEventInfo(writer.ToStringWithClear(), dynParms);
        }

        public CommandTextEventInfo ConstructFirstSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            var writer = new StringTextWriter();
            var dynParms = new DynamicParameters();
            var entityType = typeof(TEntity);
            var tableName = _dialectSettings.GetEscapeName(entityType);

            var tp = entityType.GetRuntimeProperties().Where(p => p.PropertyType.IsSimpleType());
            if (logicFields != null)
            {
                tp = tp.Where(p => !logicFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }
            if (selectFields != null)
            {
                tp = tp.Where(p => selectFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }

            writer.Write($"SELECT TOP(1) {string.Join(", ", tp.Select(p => _dialectSettings.GetEscapeName(p)))} FROM {tableName} ");
            if (whereClause != null)
            {
                writer.Write($"WHERE ({whereClause}) ");
                dynParms.AdddWhereClause(whereClause);
            }
            if (!orderbyClause.IsNull)
            {
                writer.Write($"ORDER BY {orderbyClause} ");
            }
            writer.Write(";");

            return new CommandTextEventInfo(writer.ToStringWithClear(), dynParms);
        }

        public CommandTextEventInfo ConstructPageSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, int skip, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            var writer = new StringTextWriter();
            var dynParms = new DynamicParameters();
            var entityType = typeof(TEntity);
            var tableName = _dialectSettings.GetEscapeName(entityType);

            var tp = entityType.GetRuntimeProperties().Where(p => p.PropertyType.IsSimpleType());
            if (logicFields != null)
            {
                tp = tp.Where(p => !logicFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }
            if (selectFields != null)
            {
                tp = tp.Where(p => selectFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }

            // _TotalNumberOfRecords
            writer.Write($"SELECT COUNT(1) AS _TotalNumberOfRecords FROM {tableName} ");
            if (whereClause != null)
            {
                writer.Write($"WHERE ({whereClause})");
            }
            writer.Write("; ");
            // PagedResult
            var propeerties = tp.ToList();
            writer.Write($"SELECT {string.Join(", ", propeerties.Select(p => $"PagedResult.{_dialectSettings.GetEscapeName(p)}"))} FROM (");
            writer.Write($"SELECT TOP({skip + take}) ROW_NUMBER() OVER(ORDER BY {orderbyClause}) AS _PagedNumber, {string.Join(", ", propeerties.Select(p => _dialectSettings.GetEscapeName(p)))} FROM {tableName}");
            if (whereClause != null)
            {
                writer.Write($" WHERE ({whereClause})");
                dynParms.AdddWhereClause(whereClause);
            }
            writer.Write($") AS PagedResult WHERE (PagedResult._PagedNumber > {skip}) ");
            writer.Write(";");

            return new CommandTextEventInfo(writer.ToStringWithClear(), dynParms);
        }

        public CommandTextEventInfo ConstructSelectSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            var writer = new StringTextWriter();
            var dynParms = new DynamicParameters();
            var entityType = typeof(TEntity);
            var tableName = _dialectSettings.GetEscapeName(entityType);

            var tp = entityType.GetRuntimeProperties().Where(p => p.PropertyType.IsSimpleType());
            if (logicFields != null)
            {
                tp = tp.Where(p => !logicFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }
            if (selectFields != null)
            {
                tp = tp.Where(p => selectFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }

            writer.Write($"SELECT {string.Join(", ", tp.Select(p => _dialectSettings.GetEscapeName(p)))} FROM {tableName} ");
            if (whereClause != null)
            {
                writer.Write($"WHERE ({whereClause}) ");
                dynParms.AdddWhereClause(whereClause);
            }
            if (!orderbyClause.IsNull)
            {
                writer.Write($"ORDER BY {orderbyClause} ");
            }
            writer.Write(";");

            return new CommandTextEventInfo(writer.ToStringWithClear(), dynParms);
        }

        public CommandTextEventInfo ConstructTakeSql<TKey, TEntity>(IList<Expression<Func<TEntity, object>>> logicFields, int take, IEnumerable<Expression<Func<TEntity, object>>> selectFields, WhereClauseResult whereClause, OrderbyClauseResult orderbyClause) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            var writer = new StringTextWriter();
            var dynParms = new DynamicParameters();
            var entityType = typeof(TEntity);
            var tableName = _dialectSettings.GetEscapeName(entityType);

            var tp = entityType.GetRuntimeProperties().Where(p => p.PropertyType.IsSimpleType());
            if (logicFields != null)
            {
                tp = tp.Where(p => !logicFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }
            if (selectFields != null)
            {
                tp = tp.Where(p => selectFields.Any(exp => string.Equals(p.Name, exp.GetMemberName(), StringComparison.Ordinal)));
            }

            writer.Write($"SELECT TOP({take}) {string.Join(", ", tp.Select(p => _dialectSettings.GetEscapeName(p)))} FROM {tableName} ");
            if (whereClause != null)
            {
                writer.Write($"WHERE ({whereClause}) ");
                dynParms.AdddWhereClause(whereClause);
            }
            if (!orderbyClause.IsNull)
            {
                writer.Write($"ORDER BY {orderbyClause} ");
            }
            writer.Write(";");

            return new CommandTextEventInfo(writer.ToStringWithClear(), dynParms);
        }

        public OrderbyClauseResult ConstructOrderbyClause<TKey, TEntity>(Expression<Func<TEntity, object>> member, OrderbyType orderbyType) where TKey : IEquatable<TKey> where TEntity : class, IEntity<TKey>
        {
            return (OrderbyClauseResult)$"{_dialectSettings.GetEscapeName(member)} {(orderbyType == OrderbyType.Ascending ? "ASC" : "DESC")}";
        }
    }
}