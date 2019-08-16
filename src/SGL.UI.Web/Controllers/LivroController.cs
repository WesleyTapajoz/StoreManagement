using SGL.Application.Interfaces;
using SGL.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
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

        // GET: Livro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Filtrar(LivroViewModel search)
        {
            var query = _livroAppService.ObterTodos();
            return PartialView("_Resultado", query.ToList());
        }


    }
}