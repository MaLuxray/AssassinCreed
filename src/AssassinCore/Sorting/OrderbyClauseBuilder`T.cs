
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using AssassinCore.Common;
using AssassinCore.Storage;

namespace AssassinCore.Sorting
{
    public class OrderbyClauseBuilder<T> : IOrderbyClauseBuilder<T>
        where T : class
    {
        private readonly StorageDialectSettings _dialectSettings;
        private readonly IList<KeyValuePair<string, string>> _tuples;

        public OrderbyClauseBuilder(StorageDialectSettings dialectSettings)
        {
            _dialectSettings = dialectSettings ?? throw new ArgumentNullException(nameof(dialectSettings));
            _tuples = new List<KeyValuePair<string, string>>();
        }

        public IOrderbyClauseBuilder<T> Ascending(Expression<Func<T, object>> member)
            => New(member, OrderbyType.Ascending);

        public IOrderbyClauseBuilder<T> Descending(Expression<Func<T, object>> member)
            => New(member, OrderbyType.Descending);

        public IOrderbyClauseBuilder<T> Clear()
        {
            _tuples?.Clear();
            return this;
        }

        public OrderbyClauseResult Build()
        {
            try
            {
                var writer = new StringTextWriter();
                // ReSharper disable once InvertIf
                if (_tuples != null && _tuples.Any())
                {
                    foreach (var tuple in _tuples)
                    {
                        if (writer.Length > 0)
                        {
                            writer.Write(", ");
                        }
                        writer.Write($"{tuple.Key} {tuple.Value}");
                    }
                    var orderbyClause = writer.ToStringWithClear();

                    return (OrderbyClauseResult)orderbyClause;
                }
                // (null)
                return OrderbyClauseResult.Null;
            }
            finally
            {
                Clear();
            }
        }

        public void Dispose()
        {
        }

        private IOrderbyClauseBuilder<T> New(Expression<Func<T, object>> member, OrderbyType type)
        {
            if (member == null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            var mn = _dialectSettings.GetEscapeName(member);
            var rule = type == OrderbyType.Ascending ? "ASC" : "DESC";
            _tuples?.Add(new KeyValuePair<string, string>(mn, rule));

            return this;
        }
    }
}