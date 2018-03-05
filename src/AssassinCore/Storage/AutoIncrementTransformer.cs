namespace AssassinCore.Storage
{
    public delegate void AutoIncrementTransformer<in TKey, in TEntity>(TKey key, TEntity entity);
}