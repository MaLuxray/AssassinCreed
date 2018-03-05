
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

using AssassinCore.Common;

namespace AssassinCore.Storage.Implements
{
    // UnitOfWork`Async
    public partial class UnitOfWork
    {
        public async Task ExecuteAsync(Func<IStorageDbConnection, CancellationToken, Task> command, CancellationToken cancellationToken)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            var writer = new StringTextWriter();
            writer.WriteAa();
            var conn = new StorageDbConnection(await CreateDbConnectionWithOpenAsync(cancellationToken), writer);
            writer.WriteBb(Identity);

            try
            {
                await command(conn, cancellationToken);
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

        public async Task ExecuteAsync(Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task> command, IsolationLevel il, CancellationToken cancellationToken)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            var writer = new StringTextWriter();
            writer.WriteAa();
            var conn = new StorageDbConnection(await CreateDbConnectionWithOpenAsync(cancellationToken), writer);
            writer.WriteBb(Identity);

            var tr = conn.BeginTransaction(il);
            writer.WriteFf();

            try
            {
                await command(conn, tr, cancellationToken);
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

        public async Task ExecuteAsync(Func<IStorageDbConnection, object[], CancellationToken, Task> command, object[] args, CancellationToken cancellationToken)
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
            var conn = new StorageDbConnection(await CreateDbConnectionWithOpenAsync(cancellationToken), writer);
            writer.WriteBb(Identity);

            try
            {
                await command(conn, args, cancellationToken);
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

        public async Task ExecuteAsync(Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task> command, object[] args, IsolationLevel il, CancellationToken cancellationToken)
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
            var conn = new StorageDbConnection(await CreateDbConnectionWithOpenAsync(cancellationToken), writer);
            writer.WriteBb(Identity);

            var tr = conn.BeginTransaction(il);
            writer.WriteFf();

            try
            {
                await command(conn, args, tr, cancellationToken);
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

        public async Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, CancellationToken, Task<TResult>> command, CancellationToken cancellationToken)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            var writer = new StringTextWriter();
            writer.WriteAa();
            var conn = new StorageDbConnection(await CreateDbConnectionWithOpenAsync(cancellationToken), writer);
            writer.WriteBb(Identity);

            try
            {
                var result = await command(conn, cancellationToken);
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

        public async Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, IDbTransaction, CancellationToken, Task<TResult>> command, IsolationLevel il, CancellationToken cancellationToken)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            var writer = new StringTextWriter();
            writer.WriteAa();
            var conn = new StorageDbConnection(await CreateDbConnectionWithOpenAsync(cancellationToken), writer);
            writer.WriteBb(Identity);

            var tr = conn.BeginTransaction(il);
            writer.WriteFf();

            try
            {
                var result = await command(conn, tr, cancellationToken);
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

        public async Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, object[], CancellationToken, Task<TResult>> command, object[] args, CancellationToken cancellationToken)
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
            var conn = new StorageDbConnection(await CreateDbConnectionWithOpenAsync(cancellationToken), writer);
            writer.WriteBb(Identity);

            try
            {
                var result = await command(conn, args, cancellationToken);
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

        public async Task<TResult> ExecuteAsync<TResult>(Func<IStorageDbConnection, object[], IDbTransaction, CancellationToken, Task<TResult>> command, object[] args, IsolationLevel il, CancellationToken cancellationToken)
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
            var conn = new StorageDbConnection(await CreateDbConnectionWithOpenAsync(cancellationToken), writer);
            writer.WriteBb(Identity);

            var tr = conn.BeginTransaction(il);
            writer.WriteFf();

            try
            {
                var result = await command(conn, args, tr, cancellationToken);
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