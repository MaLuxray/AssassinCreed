
using System;
using System.Data;

using AssassinCore.Common;

namespace AssassinCore.Storage.Implements
{
    public class StorageDbConnection : IStorageDbConnection
    {
        private readonly IDbConnection _conn;

        public StorageDbConnection(IDbConnection conn, StringTextWriter textWriter)
        {
            _conn = conn ?? throw new ArgumentNullException(nameof(conn));
            TextWriter = textWriter ?? throw new ArgumentNullException(nameof(textWriter));
        }

        public StringTextWriter TextWriter { get; }

        public string ConnectionString { get => _conn.ConnectionString; set => _conn.ConnectionString = value; }

        public int ConnectionTimeout => _conn.ConnectionTimeout;

        public string Database => _conn.Database;

        public ConnectionState State => _conn.State;

        public IDbTransaction BeginTransaction()
            => _conn.BeginTransaction();

        public IDbTransaction BeginTransaction(IsolationLevel il)
            => _conn.BeginTransaction(il);

        public void ChangeDatabase(string databaseName)
            => _conn.ChangeDatabase(databaseName);

        public void Close()
            => _conn.Close();

        public IDbCommand CreateCommand()
            => _conn.CreateCommand();

        public void Dispose()
            => _conn.Dispose();

        public void Open()
            => _conn.Open();
    }
}