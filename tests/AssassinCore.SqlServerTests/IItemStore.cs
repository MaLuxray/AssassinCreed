
using AssassinCore.Storage;

namespace AssassinCore.SqlServerTests
{
    public interface IItemStore : IEntityStore<int, Item>
    {
    }
}