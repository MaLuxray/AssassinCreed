
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Storage;

using MySql.Data.MySqlClient;

namespace AssassinCore.MySql
{
    public class MySqlConnectionFactory : IDbConnectionFactory
    {
        public MySqlConnectionFactory(IStorageConnectionString connectionString)
        {
            ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public string Identity => "Oracle_MySql.Data.MySqlClient.MySqlConnection";

        public IStorageConnectionString ConnectionString { get; }

        public IDbConnection CreateDbConnection()
        {
            return new MySqlConnection(ConnectionString.Value);
        }

        public Task<IDbConnection> CreateDbConnectionAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return Task.FromResult((IDbConnection)new MySqlConnection(ConnectionString.Value));
        }

        public IDbConnection CreateDbConnectionWithOpen()
        {
            var conn = new MySqlConnection(ConnectionString.Value);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }

        public async Task<IDbConnection> CreateDbConnectionWithOpenAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var conn = new MySqlConnection(ConnectionString.Value);
            if (conn.State != ConnectionState.Open)
            {
                await conn.OpenAsync(cancellationToken);
            }
            return conn;
        }
    }
}