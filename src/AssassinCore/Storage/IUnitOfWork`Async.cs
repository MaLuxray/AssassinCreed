
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace AssassinCore.Storage
{
    // IUnitOfWork`Async
    public partial interface IUnitOfWork
    {
        Task ExecuteAsync(Func<IStorageDbConnection, CancellationToken, Task> command, CancellationToken cancellationToken);

        Task ExecuteAsync(Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task> command, IsolationLevel il, CancellationToken cancellationToken);

        Task ExecuteAsync(Func<IStorageDbConnection, object[], CancellationToken, Task> command, object[] args, CancellationToken cancellationToken);

        Task ExecuteAsync(Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task> command, object[] args, IsolationLevel il, CancellationToken cancellationToken);

        Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, CancellationToken, Task<TResult>> command, CancellationToken cancellationToken);

        Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task<TResult>> command, IsolationLevel il, CancellationToken cancellationToken);

        Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, object[], CancellationToken, Task<TResult>> command, object[] args, CancellationToken cancellationToken);

        Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task<TResult>> command, object[] args, IsolationLevel il, CancellationToken cancellationToken);
    }
}