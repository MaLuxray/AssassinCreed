
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Storage;

namespace AssassinCore.SqlServer
{
    public class SqlServerConnectionFactory : IDbConnectionFactory
    {
        public SqlServerConnectionFactory(IStorageConnectionString connectionString)
        {
            ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public string Identity => "Microsoft_System.Data.SqlClient.SqlConnection";

        public IStorageConnectionString ConnectionString { get; }

        public IDbConnection CreateDbConnection()
        {
            return new SqlConnection(ConnectionString.Value);
        }

        public Task<IDbConnection> CreateDbConnectionAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return Task.FromResult((IDbConnection)new SqlConnection(ConnectionString.Value));
        }

        public IDbConnection CreateDbConnectionWithOpen()
        {
            var conn = new SqlConnection(ConnectionString.Value);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }

        public async Task<IDbConnection> CreateDbConnectionWithOpenAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var conn = new SqlConnection(ConnectionString.Value);
            if (conn.State != ConnectionState.Open)
            {
                await conn.OpenAsync(cancellationToken);
            }
            return conn;
        }
    }
}