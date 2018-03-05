
using System;
using System.Data;

namespace AssassinCore.Storage
{
    public partial interface IUnitOfWork
    {
        IDbConnectionFactory ConnectionFactory { get; }

        IStorageLogger Logger { get; }
    }

    public partial interface IUnitOfWork
    {
        void Execute(Action<IStorageDbConnection> command);

        void Execute(Action<IStorageDbConnection, IDbTransaction> command, IsolationLevel il);

        void Execute(Action<IStorageDbConnection, object[]> command, object[] args);

        void Execute(Action<IStorageDbConnection, object[], IDbTransaction> command, object[] args, IsolationLevel il);

        TResult Execute<TResult>(Func<IStorageDbConnection, TResult> command);

        TResult Execute<TResult>(Func<IStorageDbConnection, IDbTransaction, TResult> command, IsolationLevel il);

        TResult Execute<TResult>(Func<IStorageDbConnection, object[], TResult> command, object[] args);

        TResult Execute<TResult>(Func<IStorageDbConnection, object[], IDbTransaction, TResult> command, object[] args, IsolationLevel il);
    }
}