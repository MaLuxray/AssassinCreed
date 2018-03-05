
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading;

using AssassinCore.Sorting;

using Dapper;

namespace AssassinCore.Storage.Implements
{
    public abstract partial class DefaultEntityStore<TKey, TEntity> : IEntityStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
        protected DefaultEntityStore(IStorageConstructService constructService)
        {
            ConstructService = constructService ?? throw new ArgumentNullException(nameof(constructService));
            LogicFields = new List<Expression<Func<TEntity, object>>>();
        }

        protected IStorageConstructService ConstructService { get; }

        protected IList<Expression<Func<TEntity, object>>> LogicFields { get; }

        protected abstract Expression<Func<TEntity, object>> DefaultOrderbyField { get; }

        protected abstract OrderbyType DefaultOrderbyType { get; }

        protected OrderbyClauseResult CreateDefaultOrderbyClause()
            => ConstructService.ConstructOrderbyClause<TKey, TEntity>(DefaultOrderbyField, DefaultOrderbyType);

        protected CommandDefinition CreateDapperCmd(string commandText, object parameters, IDbTransaction transaction, CancellationToken cancellationToken = default(CancellationToken))
            => new CommandDefinition(commandText, parameters, transaction, cancellationToken: cancellationToken);
    }
}