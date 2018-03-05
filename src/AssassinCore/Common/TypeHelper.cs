
using System;

#if NETSTANDARD1_3
using System.Reflection;
#endif

namespace AssassinCore.Common
{
    public static class TypeHelper
    {
        private static readonly Type[] Types = new Type[]
        {
            typeof(byte[]),
            typeof(ushort),
            typeof(uint),
            typeof(ulong),
            typeof(byte),
            typeof(short),
            typeof(int),
            typeof(long),
            typeof(sbyte),
            typeof(float),
            typeof(double),
            typeof(decimal),
            typeof(char),
            typeof(string),
            typeof(bool),
            typeof(DateTime),
            typeof(DateTimeOffset),
            typeof(TimeSpan),
            typeof(Guid),
        };

        public static bool IsSimpleType(this Type src)
        {
            if (src == null)
            {
                throw new ArgumentNullException(nameof(src));
            }

            var srcTemp = Nullable.GetUnderlyingType(src) ?? src;
            if (Array.IndexOf(Types, srcTemp) > 0)
            {
                return true;
            }
#if NETSTANDARD1_3
            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (srcTemp.GetTypeInfo().IsEnum)
            {
                return true;
            }
#else
            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (srcTemp.IsEnum)
            {
                return true;
            }
#endif
            return false;
        }
    }
}