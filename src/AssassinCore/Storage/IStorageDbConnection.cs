
using System.Data;

using AssassinCore.Common;

namespace AssassinCore.Storage
{
    public interface IStorageDbConnection : IDbConnection
    {
        StringTextWriter TextWriter { get; }
    }
}