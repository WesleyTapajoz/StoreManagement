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
    public class LinkAppService : ApplicationService, ILinkAppService
    {
        private readonly ILinkService _linkService;

        public LinkAppService(ILinkService linkService, IUnitOfWork uow)
            : base(uow)
        {
            _linkService = linkService;
        }

        public Link Adicionar(Link obj)
        {
          
            BeginTransaction();
            var returno = _linkService.Adicionar(obj);
            Commit();

            return returno;
        }

        public Link Atualizar(Link obj)
        {
            BeginTransaction();
            var returno = _linkService.Atualizar(obj);
            Commit();

            return  returno;
        }

        public void Dispose()
        {
            _linkService.Dispose();
            GC.SuppressFinalize(this);
        }

        public Link ObterPorId(int id)
        {
            return _linkService.ObterPorId(id);
        }

        public IQueryable<Link> ObterTodos()
        {
            return _linkService.ObterTodos();
        }

        public void Remover(int id)
        {
            BeginTransaction();
            _linkService.Remover(id);
            Commit();
        }
    }
}
