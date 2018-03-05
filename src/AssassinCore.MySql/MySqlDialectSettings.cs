
using AssassinCore.Storage;

namespace AssassinCore.MySql
{
    public class MySqlDialectSettings : StorageDialectSettings
    {
        public override string Name { get; } = "Oracle MySQL";

        public override string ParameterPrefix { get; } = "?";

        public override string GetIdentitySql { get; } = "SELECT @@IDENTITY AS _IdnetityId";

        public override string LeadingEscape { get; } = "`";

        public override string TailingEscape { get; } = "`";
    }
}