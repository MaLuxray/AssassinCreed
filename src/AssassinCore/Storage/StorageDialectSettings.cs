namespace AssassinCore.Storage
{
    public abstract class StorageDialectSettings
    {
        public abstract string Name { get; }

        public abstract string ParameterPrefix { get; }

        public abstract string GetIdentitySql { get; } // 仅适用于 auto_increment

        public virtual string LeadingEscape { get; } = string.Empty;

        public virtual string TailingEscape { get; } = string.Empty;

        public virtual string Equal { get; } = "=";

        public virtual string NotEqual { get; } = "<>";

        public virtual string GreaterThan { get; } = ">";

        public virtual string GreaterThanOrEqual { get; } = ">=";

        public virtual string LessThan { get; } = "<";

        public virtual string LessThanOrEqual { get; } = "<=";
    }
}