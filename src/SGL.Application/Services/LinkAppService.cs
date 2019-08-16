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
    public class LinkAppService : ApplicationService, ILinkAppService
    {
        private readonly ILinkService _linkService;

        public LinkAppService(ILinkService linkService, IUnitOfWork uow)
            : base(uow)
        {
            _linkService = linkService;
        }

        public AdicionarLinkViewModel Adicionar(AdicionarLinkViewModel obj)
        {
            var link = Mapper.Map<AdicionarLinkViewModel, Link>(obj);

            BeginTransaction();
            var returno = _linkService.Adicionar(link);
            Commit();

            return Mapper.Map<Link, AdicionarLinkViewModel>(returno);
        }

        public AtualizarLinkViewModel Atualizar(AtualizarLinkViewModel obj)
        {
            var link = Mapper.Map<AtualizarLinkViewModel, Link>(obj);

            BeginTransaction();
            var returno = _linkService.Atualizar(link);
            Commit();

            return Mapper.Map<Link, AtualizarLinkViewModel>(returno);
        }

        public void Dispose()
        {
            _linkService.Dispose();
            GC.SuppressFinalize(this);
        }

        public LinkViewModel ObterPorId(int id)
        {
            return Mapper.Map<Link, LinkViewModel>(_linkService.ObterPorId(id));
        }

        public IEnumerable<LinkViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Link>, IEnumerable<LinkViewModel>>(_linkService.ObterTodos());
        }

        public void Remover(int id)
        {
            _linkService.Remover(id);
        }
    }
}
