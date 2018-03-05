
using System.Collections.Generic;

namespace AssassinCore.Storage
{
    public interface IPageResult<out T> : IReadOnlyList<T>
    {
        int Skip { get; }

        int Take { get; }

        long TotalNumberOfRecords { get; }
    }
}