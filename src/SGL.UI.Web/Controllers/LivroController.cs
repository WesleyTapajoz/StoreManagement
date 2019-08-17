using SGL.Application.Interfaces;
using SGL.Application.ViewModels;
using SGL.Domain.Entity;
using SGL.UI.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace SGL.UI.Web.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroAppService _livroAppService;

        public LivroController(ILivroAppService livroAppService)
        {
            _livroAppService = livroAppService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Filtrar(LivroViewModel search)
        {
            Expression<Func<Livro, bool>> filtro = null;
            Expression<Func<Livro, bool>> filtro2;

            if (search.Titulo != null)
            {
                var criterio = search.Titulo.ToLower() + "%";
                filtro2 = ent => (DbFunctions.Like(ent.Titulo.ToLower(), criterio));
                filtro = ExpressionParameterReplacer.concatenar(filtro, filtro2);
            }

            if (search.GeneroId != null)
            {
                var criterio = search.GeneroId + "%";
                filtro2 = ent => (DbFunctions.Like(ent.GeneroId.ToString(), criterio));
                filtro = ExpressionParameterReplacer.concatenar(filtro, filtro2);
            }

            if (search.EditoraId != null)
            {
                var criterio = search.EditoraId + "%";
                filtro2 = ent => (DbFunctions.Like(ent.EditoraId.ToString(), criterio));
                filtro = ExpressionParameterReplacer.concatenar(filtro, filtro2);
            }

            var query = _livroAppService.ObterTodos().Where(filtro ?? (u => true));

            return PartialView("_Resultado", query.ToList());
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        public ActionResult AdicionarConfirmar(Livro entity)
        {
            _livroAppService.Adicionar(entity);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int livroId)
        {
            var entity = _livroAppService.ObterPorId(livroId);
            return View(entity);
        }

        public ActionResult EditarConfirmar(Livro entity)
        {
            _livroAppService.Atualizar(entity);
            return RedirectToAction("Index");
        }
        public ActionResult Detalhes(int livroId)
        {
            var entity = _livroAppService.ObterPorId(livroId);
            return View(entity);
        }

        public ActionResult Remover(int livroId)
        {
            _livroAppService.Remover(livroId);
            return RedirectToAction("Index");
        }

    }
}