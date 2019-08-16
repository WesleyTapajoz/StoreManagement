using System;
using System.Collections.Generic;
using AutoMapper;
using SGL.Application.Interfaces;
using SGL.Application.ViewModels;
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

        public AdicionarLivroViewModel Adicionar(AdicionarLivroViewModel obj)
        {
            BeginTransaction();
            var autorReturn = _livroService.Adicionar(Mapper.Map<AdicionarLivroViewModel, Livro>(obj));
            Commit();

            return Mapper.Map<Livro, AdicionarLivroViewModel>(autorReturn);
        }

        public AtualizarLivroViewModel Atualizar(AtualizarLivroViewModel obj)
        {
            BeginTransaction();
            var autorReturn = _livroService.Atualizar(Mapper.Map<AtualizarLivroViewModel, Livro>(obj));
            Commit();

            return Mapper.Map<Livro, AtualizarLivroViewModel>(autorReturn);
        }

        public void Dispose()
        {
            _livroService.Dispose();
            GC.SuppressFinalize(this);
        }

        public LivroViewModel ObterPorId(int id)
        {
            return Mapper.Map<Livro, LivroViewModel>(_livroService.ObterPorId(id));

        }

        public IEnumerable<Livro> ObterTodos()
        {
            var entity = _livroService.ObterTodos();
            //var retorno = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(entity);
            return entity;
        }

        public void Remover(int id)
        {
            _livroService.Remover(id);
        }
    }
}
