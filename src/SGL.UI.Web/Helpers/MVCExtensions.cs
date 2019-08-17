using SGL.Application.Interfaces;
using System.Linq;
using System.Linq.Expressions;

namespace System.Web.Mvc.Html
{
    public static class MVCExtensions
    {
        public static MvcHtmlString DropDownListAutor<TModel, TValue>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TValue>> expression, object htmlAttributes, string optionLabel = null, bool todos = false)
        {
            var lista = GetListaAutor().OrderBy(s => s.Text).ToList();
            if (todos)
            {
                SelectListItem item = new SelectListItem()
                {
                    Value = "-1",
                    Text = "Todos",
                    Selected = true
                };
                lista.Insert(0, item);
            }
            return helper.DropDownListFor(expression, lista, optionLabel, htmlAttributes);
        }

        private static SelectList GetListaAutor()
        {
            var service = DependencyResolver.Current.GetService<IAutorAppService>();
            var entidades = service.ObterTodos();
            return entidades.ToSelectList(el => el.AutorId, el => el.Nome);
        }

        public static MvcHtmlString DropDownListEditora<TModel, TValue>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TValue>> expression, object htmlAttributes, string optionLabel = null, bool todos = false)
        {
            var lista = GetListaEditora().OrderBy(s => s.Text).ToList();
            if (todos)
            {
                SelectListItem item = new SelectListItem()
                {
                    Value = "-1",
                    Text = "Todos",
                    Selected = true
                };
                lista.Insert(0, item);
            }
            return helper.DropDownListFor(expression, lista, optionLabel, htmlAttributes);
        }

        private static SelectList GetListaEditora()
        {
            var service = DependencyResolver.Current.GetService<IEditoraAppService>();
            var entidades = service.ObterTodos();
            return entidades.ToSelectList(el => el.EditoraId, el => el.Descricao);
        }


        public static MvcHtmlString DropDownListGenero<TModel, TValue>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TValue>> expression, object htmlAttributes, string optionLabel = null, bool todos = false)
        {
            var lista = GetListaGenero().OrderBy(s => s.Text).ToList();
            if (todos)
            {
                SelectListItem item = new SelectListItem()
                {
                    Value = "-1",
                    Text = "Todos",
                    Selected = true
                };
                lista.Insert(0, item);
            }
            return helper.DropDownListFor(expression, lista, optionLabel, htmlAttributes);
        }

        private static SelectList GetListaGenero()
        {
            var service = DependencyResolver.Current.GetService<IGeneroAppService>();
            var entidades = service.ObterTodos();
            return entidades.ToSelectList(el => el.GeneroId, el => el.Descricao);
        }

    }
}