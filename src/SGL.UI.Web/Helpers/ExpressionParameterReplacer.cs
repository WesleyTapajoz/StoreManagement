using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SGL.UI.Web.Helpers
{
    public class ExpressionParameterReplacer : ExpressionVisitor
    {
        private IDictionary<ParameterExpression, ParameterExpression> ParameterReplacements { get; set; }

        public ExpressionParameterReplacer(IList<ParameterExpression> fromParameters, IList<ParameterExpression> toParameters)
        {
            ParameterReplacements = new Dictionary<ParameterExpression, ParameterExpression>();

            for (int i = 0; i != fromParameters.Count && i != toParameters.Count; i++)
            {
                ParameterReplacements.Add(fromParameters[i], toParameters[i]);
            }
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            ParameterExpression replacement;

            if (ParameterReplacements.TryGetValue(node, out replacement))
            {
                node = replacement;
            }

            return base.VisitParameter(node);
        }

        public static Expression<Func<T, bool>> concatenar<T>(Expression<Func<T, bool>> filtro, Expression<Func<T, bool>> filtro2)
        {
            if (filtro == null)
            {
                return filtro2;
            }
            var body = Expression.And(filtro.Body, new ExpressionParameterReplacer(filtro2.Parameters, filtro.Parameters).Visit(filtro2.Body));
            return Expression.Lambda<Func<T, bool>>(body, filtro.Parameters);
        }

        public static Expression<Func<T, bool>> concatenarOr<T>(Expression<Func<T, bool>> filtro, Expression<Func<T, bool>> filtro2)
        {
            if (filtro == null)
            {
                return filtro2;
            }
            var body = Expression.Or(filtro.Body, new ExpressionParameterReplacer(filtro2.Parameters, filtro.Parameters).Visit(filtro2.Body));
            return Expression.Lambda<Func<T, bool>>(body, filtro.Parameters);
        }
    }
}