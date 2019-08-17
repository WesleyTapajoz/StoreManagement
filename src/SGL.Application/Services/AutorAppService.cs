using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using SGL.Application.Interfaces;
using SGL.Application.ViewModels;
using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Services;
using SGL.Infra.Data;

namespace SGL.Application.Services
{
    public class AutorAppService : ApplicationService, IAutorAppService
    {
        private readonly IAutorService _autorService;

        public AutorAppService(IAutorService autorService, IUnitOfWork uow)
            : base(uow)
        {
            _autorService = autorService;
        }
        public Autor Adicionar(Autor obj)
        {

            BeginTransaction();
            var returno = _autorService.Adicionar(obj);
            Commit();

            return  returno;
        }

        public Autor Atualizar(Autor obj)
        {
            BeginTransaction();
            var autorReturn = _autorService.Atualizar(obj);
            Commit();

            return autorReturn;
        }

        public void Dispose()
        {
            _autorService.Dispose();
            GC.SuppressFinalize(this);
        }

        public Autor ObterPorId(int id)
        {
            return  _autorService.ObterPorId(id);
        }

        public IQueryable<Autor> ObterTodos()
        {
            return _autorService.ObterTodos();
        }

        public void Remover(int id)
        {
            BeginTransaction();
            _autorService.Remover(id);
            Commit();

        }
    }
}
