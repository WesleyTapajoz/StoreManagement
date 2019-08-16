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
    public class GeneroAppService : ApplicationService, IGeneroAppService
    {
        private readonly IGeneroService _generoService;

        public GeneroAppService(IGeneroService generoService, IUnitOfWork uow)
            : base(uow)
        {
            _generoService = generoService;
        }

        public AdicionarGeneroViewModel Adicionar(AdicionarGeneroViewModel obj)
        {
            var genero = Mapper.Map<AdicionarGeneroViewModel, Genero>(obj);

            BeginTransaction();
            var returno = _generoService.Adicionar(genero);
            Commit();

            return Mapper.Map<Genero, AdicionarGeneroViewModel>(returno);
        }

        public AtualizarGeneroViewModel Atualizar(AtualizarGeneroViewModel obj)
        {
            var genero = Mapper.Map<AtualizarGeneroViewModel, Genero>(obj);

            BeginTransaction();
            var returno = _generoService.Atualizar(genero);
            Commit();

            return Mapper.Map<Genero, AtualizarGeneroViewModel>(returno);
        }

        public void Dispose()
        {
            _generoService.Dispose();
            GC.SuppressFinalize(this);
        }

        public GeneroViewModel ObterPorId(int id)
        {
            return Mapper.Map<Genero, GeneroViewModel>(_generoService.ObterPorId(id));
        }

        public IEnumerable<GeneroViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Genero>, IEnumerable<GeneroViewModel>>(_generoService.ObterTodos());
        }

        public void Remover(int id)
        {
            _generoService.Remover(id);
        }
    }
}
