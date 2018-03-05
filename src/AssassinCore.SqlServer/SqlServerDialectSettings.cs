
using AssassinCore.Storage;

namespace AssassinCore.SqlServer
{
    public class SqlServerDialectSettings : StorageDialectSettings
    {
        public override string Name { get; } = "Microsoft SQL Server";

        public override string ParameterPrefix { get; } = "@";

        public override string GetIdentitySql { get; } = "SELECT @@IDENTITY AS _IdentityId";

        public override string LeadingEscape { get; } = "[";

        public override string TailingEscape { get; } = "]";
    }
}