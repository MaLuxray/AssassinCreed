
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace AssassinCore.Storage
{
    public interface IDbConnectionFactory
    {
        string Identity { get; }

        IStorageConnectionString ConnectionString { get; }

        IDbConnection CreateDbConnection();

        Task<IDbConnection> CreateDbConnectionAsync(CancellationToken cancellationToken = default(CancellationToken));

        IDbConnection CreateDbConnectionWithOpen();

        Task<IDbConnection> CreateDbConnectionWithOpenAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}