
using System;

namespace AssassinCore.Storage
{
    public interface IEntityStore<TKey, TEntity> : INewEntityStore<TKey, TEntity>, IDeleteStore<TKey, TEntity>, IUpdateStore<TKey, TEntity>, IQueryStore<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : class, IEntity<TKey>
    {
    }
}