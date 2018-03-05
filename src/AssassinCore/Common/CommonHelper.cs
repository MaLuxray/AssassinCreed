
using System;

namespace AssassinCore.Common
{
    public static class CommonHelper
    {
        public static string GetUniqueString(int length = 8, string prefix = "P_")
        {
            var id = Guid.NewGuid().ToString("N").ToUpper();
            return prefix == null ? id.Substring(0, length) : $"{prefix}{id.Substring(0, length)}";
        }
    }
}