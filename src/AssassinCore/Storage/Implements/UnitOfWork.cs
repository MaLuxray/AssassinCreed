
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Common;

namespace AssassinCore.Storage.Implements
{
    public partial class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IDbConnectionFactory connectionFactory, IStorageLogger logger = null)
        {
            ConnectionFactory = connectionFactory ?? throw new ArgumentNullException(nameof(connectionFactory));
            Logger = logger ?? new NullStorageLogger();
        }

        public string Identity => ConnectionFactory.Identity;

        public IDbConnectionFactory ConnectionFactory { get; }

        public IStorageLogger Logger { get; }

        public override string ToString()
            => Identity;

        private IDbConnection CreateDbConnectionWithOpen()
            => ConnectionFactory.CreateDbConnectionWithOpen();

        private Task<IDbConnection> CreateDbConnectionWithOpenAsync(CancellationToken cancellationToken = default(CancellationToken))
            => ConnectionFactory.CreateDbConnectionWithOpenAsync(cancellationToken);
    }

    public partial class UnitOfWork
    {
        public void Execute(Action<IStorageDbConnection> command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            var writer = new StringTextWriter();
            writer.WriteAa();
            var conn = new StorageDbConnection(CreateDbConnectionWithOpen(), writer);
            writer.WriteBb(Identity);

            try
            {
                command(conn);
                writer.WriteCc();
            }
            catch (Exception e)
            {
                writer.WriteError(e.Message);
                throw new InvalidOperationException("Command failed to execute!", e);
            }
            finally
            {
                conn.Close();
                conn.Dispose();

                writer.WriteDd(Identity);
                writer.WriteEe();

                var message = writer.ToStringWithClear();
                Logger.Write(message);
            }
        }

        public void Execute(Action<IStorageDbConnection, IDbTransaction> command, IsolationLevel il)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            var writer = new StringTextWriter();
            writer.WriteAa();
            var conn = new StorageDbConnection(CreateDbConnectionWithOpen(), writer);
            writer.WriteBb(Identity);

            var tr = conn.BeginTransaction(il);
            writer.WriteFf();

            try
            {
                command(conn, tr);
                tr.Commit();

                writer.WriteGg();
                writer.WriteCc();
            }
            catch (Exception e)
            {
                writer.WriteError(e.Message);
                tr.Rollback();
                writer.WriteHh();

                throw new InvalidOperationException("Command failed to execute!", e);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                tr.Dispose();

                writer.WriteDd(Identity);
                writer.WriteEe();

                var message = writer.ToStringWithClear();
                Logger.Write(message);
            }
        }

        public void Execute(Action<IStorageDbConnection, object[]> command, object[] args)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            var writer = new StringTextWriter();
            writer.WriteAa();
            var conn = new StorageDbConnection(CreateDbConnectionWithOpen(), writer);
            writer.WriteBb(Identity);

            try
            {
                command(conn, args);
                writer.WriteCc();
            }
            catch (Exception e)
            {
                writer.WriteError(e.Message);
                throw new InvalidOperationException("Command failed to execute!", e);
            }
            finally
            {
                conn.Close();
                conn.Dispose();

                writer.WriteDd(Identity);
                writer.WriteEe();

                var message = writer.ToStringWithClear();
                Logger.Write(message);
            }
        }

        public void Execute(Action<IStorageDbConnection, object[], IDbTransaction> command, object[] args, IsolationLevel il)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            var writer = new StringTextWriter();
            writer.WriteAa();
            var conn = new StorageDbConnection(CreateDbConnectionWithOpen(), writer);
            writer.WriteBb(Identity);

            var tr = conn.BeginTransaction(il);
            writer.WriteFf();

            try
            {
                command(conn, args, tr);
                tr.Commit();

                writer.WriteGg();
                writer.WriteCc();
            }
            catch (Exception e)
            {
                writer.WriteError(e.Message);
                tr.Rollback();
                writer.WriteHh();

                throw new InvalidOperationException("Command failed to execute!", e);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                tr.Dispose();

                writer.WriteDd(Identity);
                writer.WriteEe();

                var message = writer.ToStringWithClear();
                Logger.Write(message);
            }
        }

        public TResult Execute<TResult>(Func<IStorageDbConnection, TResult> command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            var writer = new StringTextWriter();
            writer.WriteAa();
            var conn = new StorageDbConnection(CreateDbConnectionWithOpen(), writer);
            writer.WriteBb(Identity);

            try
            {
                var result = command(conn);
                writer.WriteCc();

                return result;
            }
            catch (Exception e)
            {
                writer.WriteError(e.Message);
                throw new InvalidOperationException("Command failed to execute!", e);
            }
            finally
            {
                conn.Close();
                conn.Dispose();

                writer.WriteDd(Identity);
                writer.WriteEe();

                var message = writer.ToStringWithClear();
                Logger.Write(message);
            }
        }

        public TResult Execute<TResult>(Func<IStorageDbConnection, IDbTransaction, TResult> command, IsolationLevel il)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            var writer = new StringTextWriter();
            writer.WriteAa();
            var conn = new StorageDbConnection(CreateDbConnectionWithOpen(), writer);
            writer.WriteBb(Identity);

            var tr = conn.BeginTransaction(il);
            writer.WriteFf();

            try
            {
                var result = command(conn, tr);
                tr.Commit();

                writer.WriteGg();
                writer.WriteCc();

                return result;
            }
            catch (Exception e)
            {
                writer.WriteError(e.Message);
                tr.Rollback();
                writer.WriteHh();

                throw new InvalidOperationException("Command failed to execute!", e);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                tr.Dispose();

                writer.WriteDd(Identity);
                writer.WriteEe();

                var message = writer.ToStringWithClear();
                Logger.Write(message);
            }
        }

        public TResult Execute<TResult>(Func<IStorageDbConnection, object[], TResult> command, object[] args)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            var writer = new StringTextWriter();
            writer.WriteAa();
            var conn = new StorageDbConnection(CreateDbConnectionWithOpen(), writer);
            writer.WriteBb(Identity);

            try
            {
                var result = command(conn, args);
                writer.WriteCc();

                return result;
            }
            catch (Exception e)
            {
                writer.WriteError(e.Message);
                throw new InvalidOperationException("Command failed to execute!", e);
            }
            finally
            {
                conn.Close();
                conn.Dispose();

                writer.WriteDd(Identity);
                writer.WriteEe();

                var message = writer.ToStringWithClear();
                Logger.Write(message);
            }
        }

        public TResult Execute<TResult>(Func<IStorageDbConnection, object[], IDbTransaction, TResult> command, object[] args, IsolationLevel il)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            var writer = new StringTextWriter();
            writer.WriteAa();
            var conn = new StorageDbConnection(CreateDbConnectionWithOpen(), writer);
            writer.WriteBb(Identity);

            var tr = conn.BeginTransaction(il);
            writer.WriteFf();

            try
            {
                var result = command(conn, args, tr);
                tr.Commit();

                writer.WriteGg();
                writer.WriteCc();

                return result;
            }
            catch (Exception e)
            {
                writer.WriteError(e.Message);
                tr.Rollback();
                writer.WriteHh();

                throw new InvalidOperationException("Command failed to execute!", e);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                tr.Dispose();

                writer.WriteDd(Identity);
                writer.WriteEe();

                var message = writer.ToStringWithClear();
                Logger.Write(message);
            }
        }
    }
}