
using System;
using System.Collections.Generic;

using AssassinCore.Common;
using AssassinCore.Storage;

using Dapper;

namespace AssassinCore.Where
{
    // WhereClauseBuilder`T
    public partial class WhereClauseBuilder<T> : IWhereClauseBuilder<T>
        where T : class
    {
        private readonly StorageDialectSettings _dialectSettings;
        private readonly IList<KeyValuePair<string, string>> _tuples;
        private DynamicParameters _dynParms;
        private readonly WhereClauseBuilder<T> _root;

        public WhereClauseBuilder(StorageDialectSettings dialectSettings)
        {
            _dialectSettings = dialectSettings ?? throw new ArgumentNullException(nameof(dialectSettings));
            _tuples = new List<KeyValuePair<string, string>>();
            _dynParms = new DynamicParameters();
            _root = null;
        }

        private WhereClauseBuilder(WhereClauseBuilder<T> root)
        {
            _dialectSettings = root.DialectSettings;
            _tuples = new List<KeyValuePair<string, string>>();
            _dynParms = new DynamicParameters();
            _root = root;
        }

        // ReSharper disable once ConvertToAutoPropertyWhenPossible
        protected StorageDialectSettings DialectSettings => _dialectSettings;

        protected string EqualOpt => _dialectSettings.Equal;

        protected string NotEqualOpt => _dialectSettings.NotEqual;

        protected string GreaterThanOpt => _dialectSettings.GreaterThan;

        protected string GreaterThanOrEqualOpt => _dialectSettings.GreaterThanOrEqual;

        protected string LessThanOpt => _dialectSettings.LessThan;

        protected string LessThanOrEqualOpt => _dialectSettings.LessThanOrEqual;

        protected string LikeOpt => "LIKE";

        protected string InOpt => "IN";

        protected string NotInOpt => "NOT IN";

        protected string BetweenOpt => "BETWEEN";

        protected string NotBetweenOpt => "NOT BETWEEN";

        public IWhereClauseBuilder<T> And()
        {
            _tuples.Add(new KeyValuePair<string, string>("AND", null));
            return this;
        }

        public IWhereClauseBuilder<T> Or()
        {
            _tuples.Add(new KeyValuePair<string, string>("OR", null));
            return this;
        }

        public IWhereClauseBuilder<T> StartEscape()
        {
            _tuples.Add(new KeyValuePair<string, string>(null, "("));
            return new WhereClauseBuilder<T>(this);
        }

        public IWhereClauseBuilder<T> AndStartEscape()
        {
            _tuples.Add(new KeyValuePair<string, string>("AND", "("));
            return new WhereClauseBuilder<T>(this);
        }

        public IWhereClauseBuilder<T> OrStartEscape()
        {
            _tuples.Add(new KeyValuePair<string, string>("OR", "("));
            return new WhereClauseBuilder<T>(this);
        }

        public IWhereClauseBuilder<T> EndEscape()
        {
            if (_root == null)
            {
                throw new InvalidOperationException();
            }

            var whereClause = Build();
            if (whereClause == null)
            {
                _root._tuples.Add(new KeyValuePair<string, string>(null, ")"));
                return _root;
            }
            _root._tuples.Add(new KeyValuePair<string, string>(null, $"{whereClause.Statement})"));
            _root._dynParms.AddDynamicParams((DynamicParameters)whereClause);

            return _root;
        }

        public IWhereClauseBuilder<T> Clear()
        {
            _tuples.Clear();
            _dynParms = new DynamicParameters();
            return this;
        }

        public WhereClauseResult Build()
        {
            try
            {
                if (_tuples.Count == 0)
                {
                    return WhereClauseResult.Null;
                }

                var writer = new StringTextWriter();

                foreach (var tuple in _tuples)
                {
                    writer.Write(writer.Length > 0 ? $" {tuple.Key} {tuple.Value}" : tuple.Value);
                }

                var statement = writer.ToStringWithClear();
                var dynParms = _dynParms;

                return new WhereClauseResult(statement, dynParms);
            }
            finally
            {
                Clear();
            }
        }
    }
}