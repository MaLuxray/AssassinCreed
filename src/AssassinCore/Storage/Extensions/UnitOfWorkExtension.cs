
using System;
using System.Data;

// ReSharper disable once CheckNamespace
namespace AssassinCore.Storage
{
    public static class UnitOfWorkExtension
    {
        public static void Execute(this IUnitOfWork unitOfWork, Action<IStorageDbConnection, IDbTransaction> command)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            unitOfWork.Execute(command, IsolationLevel.ReadCommitted);
        }

        public static void Execute(this IUnitOfWork unitOfWork, Action<IStorageDbConnection, object[], IDbTransaction> command, object[] args)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            unitOfWork.Execute(command, args, IsolationLevel.ReadCommitted);
        }

        public static TResult Execute<TResult>(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, IDbTransaction, TResult> command)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.Execute(command, IsolationLevel.ReadCommitted);
        }

        public static TResult Execute<TResult>(this IUnitOfWork unitOfWork, Func<IStorageDbConnection, object[], IDbTransaction, TResult> command, object[] args)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            return unitOfWork.Execute(command, args, IsolationLevel.ReadCommitted);
        }
    }
}