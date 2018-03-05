
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class UnitOfWorkAsyncExtension
    {
        // Task ExecuteAsync(Func<IStorageDbConnection, CancellationToken, Task> command, CancellationToken cancellationToken)
        public static Task ExecuteAsync(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, CancellationToken, Task> command)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, default(CancellationToken));
        }

        // Task ExecuteAsync(Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task> command, IsolationLevel il, CancellationToken cancellationToken)
        public static Task ExecuteAsync(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task> command)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, IsolationLevel.ReadCommitted, default(CancellationToken));
        }

        // Task ExecuteAsync(Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task> command, IsolationLevel il, CancellationToken cancellationToken)
        public static Task ExecuteAsync(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task> command, IsolationLevel il)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, il, default(CancellationToken));
        }

        // Task ExecuteAsync(Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task> command, IsolationLevel il, CancellationToken cancellationToken)
        public static Task ExecuteAsync(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task> command, CancellationToken cancellationToken)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, IsolationLevel.ReadCommitted, cancellationToken);
        }

        //  Task ExecuteAsync(Func<IStorageDbConnection, object[], CancellationToken, Task> command, object[] args, CancellationToken cancellationToken)
        public static Task ExecuteAsync(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, object[], CancellationToken, Task> command, object[] args)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, args, default(CancellationToken));
        }

        // Task ExecuteAsync(Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task> command, object[] args, IsolationLevel il, CancellationToken cancellationToken)
        public static Task ExecuteAsync(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task> command, object[] args)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, args, IsolationLevel.ReadCommitted, default(CancellationToken));
        }

        // Task ExecuteAsync(Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task> command, object[] args, IsolationLevel il, CancellationToken cancellationToken)
        public static Task ExecuteAsync(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task> command, object[] args, IsolationLevel il)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, args, il, default(CancellationToken));
        }

        // Task ExecuteAsync(Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task> command, object[] args, IsolationLevel il, CancellationToken cancellationToken)
        public static Task ExecuteAsync(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task> command, object[] args, CancellationToken cancellationToken)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, args, IsolationLevel.ReadCommitted, cancellationToken);
        }

        // Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, CancellationToken, Task<TResult>> command, CancellationToken cancellationToken)
        public static Task<TResult> ExecuteAsync<TResult>(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, CancellationToken, Task<TResult>> command)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, default(CancellationToken));
        }

        // Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task<TResult>> command, IsolationLevel il, CancellationToken cancellationToken)
        public static Task<TResult> ExecuteAsync<TResult>(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task<TResult>> command)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, IsolationLevel.ReadCommitted, default(CancellationToken));
        }

        // Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task<TResult>> command, IsolationLevel il, CancellationToken cancellationToken)
        public static Task<TResult> ExecuteAsync<TResult>(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task<TResult>> command, IsolationLevel il)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, il, default(CancellationToken));
        }

        // Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task<TResult>> command, IsolationLevel il, CancellationToken cancellationToken)
        public static Task<TResult> ExecuteAsync<TResult>(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task<TResult>> command, CancellationToken cancellationToken)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, IsolationLevel.ReadCommitted, cancellationToken);
        }

        // Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, object[], CancellationToken, Task<TResult>> command, object[] args, CancellationToken cancellationToken)
        public static Task<TResult> ExecuteAsync<TResult>(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, object[], CancellationToken, Task<TResult>> command, object[] args)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, args, default(CancellationToken));
        }

        // Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task<TResult>> command, object[] args, IsolationLevel il, CancellationToken cancellationToken)
        public static Task<TResult> ExecuteAsync<TResult>(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task<TResult>> command, object[] args)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, args, IsolationLevel.ReadCommitted, default(CancellationToken));
        }

        // Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task<TResult>> command, object[] args, IsolationLevel il, CancellationToken cancellationToken)
        public static Task<TResult> ExecuteAsync<TResult>(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task<TResult>> command, object[] args, IsolationLevel il)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, args, il, default(CancellationToken));
        }

        // Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task<TResult>> command, object[] args, IsolationLevel il, CancellationToken cancellationToken)
        public static Task<TResult> ExecuteAsync<TResult>(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task<TResult>> command, object[] args, CancellationToken cancellationToken)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.ExecuteAsync(command, args, IsolationLevel.ReadCommitted, cancellationToken);
        }
    }
}