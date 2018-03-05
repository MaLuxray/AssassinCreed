
using System;

using AssassinCore.Where;

using Dapper;

namespace AssassinCore.Common
{
    public static class DynamicParametersExtensions
    {
        public static DynamicParameters AdddWhereClause(this DynamicParameters dynParms, WhereClauseResult whereClause)
        {
            if (dynParms == null)
            {
                throw new ArgumentNullException(nameof(dynParms));
            }
            if (whereClause != null && whereClause.Any)
            {
                dynParms.AddDynamicParams((DynamicParameters)whereClause);
            }
            return dynParms;
        }
    }
}