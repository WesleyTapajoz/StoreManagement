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
        public AdicionarAutorViewModel Adicionar(AdicionarAutorViewModel obj)
        {
            var autor = Mapper.Map<AdicionarAutorViewModel, Autor>(obj);

            BeginTransaction();
            var returno = _autorService.Adicionar(autor);
            Commit();

            return Mapper.Map<Autor, AdicionarAutorViewModel>(returno);
        }

        public AtualizarAutorViewModel Atualizar(AtualizarAutorViewModel obj)
        {
            BeginTransaction();
            var autorReturn = _autorService.Atualizar(Mapper.Map<AtualizarAutorViewModel, Autor>(obj));
            Commit();

            return Mapper.Map<Autor, AtualizarAutorViewModel>(autorReturn);
        }

        public void Dispose()
        {
            _autorService.Dispose();
            GC.SuppressFinalize(this);
        }

        public AutorViewModel ObterPorId(int id)
        {
            return Mapper.Map<Autor, AutorViewModel>(_autorService.ObterPorId(id));
        }

        public IEnumerable<AutorViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Autor>, IEnumerable<AutorViewModel>>(_autorService.ObterTodos());
        }

        public void Remover(int id)
        {
            _autorService.Remover(id);
        }
    }
}
