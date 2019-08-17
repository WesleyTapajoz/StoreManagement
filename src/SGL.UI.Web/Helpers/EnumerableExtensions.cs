using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace System
{
    public static class EnumerableExtensions
    {
        public static SelectList ToSelectList<TSource>(this IEnumerable<TSource> enumerable, Expression<Func<TSource, object>> value, Expression<Func<TSource, object>> text, object selected = null)
        {
            string _value = value.GetValue() as string;
            string _text = text.GetValue() as string;

            var selectList = new SelectList(enumerable, _value, _text);

            if (selected != null)
                selectList = new SelectList(enumerable, _value, _text, selected);

            return selectList;
        }

        private static object GetValue<TSource>(this Expression<Func<TSource, object>> exp)
        {
            var _exp = (exp.Body as MemberExpression ?? ((UnaryExpression)exp.Body).Operand as MemberExpression);

            return _exp.Member.Name;
        }
    }
}