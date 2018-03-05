
using System.Collections;
using System.Collections.Generic;

namespace AssassinCore.Storage.Implements
{
    public class PageResult<T> : IPageResult<T>
    {
        private readonly IList<T> _list;

        public PageResult(int skip, int take, long totalNumberOfRecoreds, IList<T> list)
        {
            Skip = skip;
            Take = take;
            TotalNumberOfRecords = totalNumberOfRecoreds;
            _list = list == null ? new List<T>(0) : new List<T>(list);
        }

        public int Skip { get; }

        public int Take { get; }

        public long TotalNumberOfRecords { get; }

        public int Count => _list.Count;

        public T this[int index] => _list[index];

        public IEnumerator<T> GetEnumerator()
            => _list.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => _list.GetEnumerator();
    }
}