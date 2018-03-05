
using System;
using System.Linq.Expressions;

namespace AssassinCore.Common
{
    public static class ExpressionExtension
    {
        public static string GetMemberName<T>(this Expression<Func<T, object>> member)
        {
            if (member == null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            Expression exp = member;
            while (true)
            {
                // ReSharper disable once SwitchStatementMissingSomeCases
                switch (exp.NodeType)
                {
                    case ExpressionType.Lambda:
                        exp = ((LambdaExpression)exp).Body;
                        break;
                    case ExpressionType.Convert:
                        exp = ((UnaryExpression)exp).Operand;
                        break;
                    case ExpressionType.Parameter:
                        return ((ParameterExpression)exp).Name;
                    case ExpressionType.MemberAccess:
                        return ((MemberExpression)exp).Member.Name;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
    }
}