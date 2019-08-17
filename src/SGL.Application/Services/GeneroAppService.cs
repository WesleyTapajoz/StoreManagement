using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using SGL.Application.Interfaces;
using SGL.Application.ViewModels;
using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Services;
using SGL.Infra.Data;

namespace SGL.Application.Services
{
    public class GeneroAppService : ApplicationService, IGeneroAppService
    {
        private readonly IGeneroService _generoService;

        public GeneroAppService(IGeneroService generoService, IUnitOfWork uow)
            : base(uow)
        {
            _generoService = generoService;
        }

        public Genero Adicionar(Genero obj)
        {
            BeginTransaction();
            var returno = _generoService.Adicionar(obj);
            Commit();

            return returno;
        }

        public Genero Atualizar(Genero obj)
        {

            BeginTransaction();
            var returno = _generoService.Atualizar(obj);
            Commit();

            return returno;
        }

        public void Dispose()
        {
            _generoService.Dispose();
            GC.SuppressFinalize(this);
        }

        public Genero ObterPorId(int id)
        {
            return _generoService.ObterPorId(id);
        }

        public IQueryable<Genero> ObterTodos()
        {
            return _generoService.ObterTodos();
        }

        public void Remover(int id)
        {
            BeginTransaction();
            _generoService.Remover(id);
            Commit();
        }
    }
}
