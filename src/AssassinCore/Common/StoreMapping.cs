
using System;
using System.Linq.Expressions;
using System.Reflection;

using AssassinCore.Storage;

namespace AssassinCore.Common
{
    public static class StoreMapping
    {
        public static string GetEscapeName(this StorageDialectSettings dialectSettings, string name)
        {
            if (dialectSettings == null)
            {
                throw new ArgumentNullException(nameof(dialectSettings));
            }
            return $"{dialectSettings.LeadingEscape}{name}{dialectSettings.TailingEscape}";
        }

        public static string GetEscapeName<T>(this StorageDialectSettings dialectSettings, Expression<Func<T, object>> member)
            => GetEscapeName(dialectSettings, member.GetMemberName());

        public static string GetEscapeName(this StorageDialectSettings dialectSettings, Type type)
            => GetEscapeName(dialectSettings, type.Name);

        public static string GetEscapeName(this StorageDialectSettings dialectSettings, MemberInfo member)
            => GetEscapeName(dialectSettings, member.Name);

        public static string GetParameterName(this StorageDialectSettings dialectSettings, MemberInfo member)
            => GetParameterName(dialectSettings, member.Name);

        public static string GetParameterName(this StorageDialectSettings dialectSettings)
            => GetParameterName(dialectSettings, CommonHelper.GetUniqueString());

        public static string GetParameterName(this StorageDialectSettings dialectSettings, string name)
        {
            if (dialectSettings == null)
            {
                throw new ArgumentNullException(nameof(dialectSettings));
            }
            return $"{dialectSettings.ParameterPrefix}{name}";
        }
    }
}