using System;
using System.Collections.Generic;
using System.Linq;
using SGL.Application.Interfaces;
using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Services;
using SGL.Infra.Data;

namespace SGL.Application.Services
{
    public class LivroAppService : ApplicationService, ILivroAppService
    {
        private readonly ILivroService _livroService;

        public LivroAppService(ILivroService livroService, IUnitOfWork uow)
            : base(uow)
        {
            _livroService = livroService;
        }

        public Livro Adicionar(Livro obj)
        {
            BeginTransaction();
            var autorReturn = _livroService.Adicionar(obj);
            Commit();

            return autorReturn;
        }

        public Livro Atualizar(Livro obj)
        {
            BeginTransaction();
            var autorReturn = _livroService.Atualizar(obj);
            Commit();

            return autorReturn;
        }

        public void Dispose()
        {
            _livroService.Dispose();
            GC.SuppressFinalize(this);
        }

        public Livro ObterPorId(int id)
        {
            return  _livroService.ObterPorId(id);

        }

        public IQueryable<Livro> ObterTodos()
        {
            var entity = _livroService.ObterTodos();           
            return entity;
        }

        public void Remover(int id)
        {
            BeginTransaction();
            _livroService.Remover(id);
            Commit();
        }
    }
}
