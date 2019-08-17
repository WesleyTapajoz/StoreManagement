using SGL.Domain.Interfaces.Services;
using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace SGL.Domain.Services
{
    public class LinkService : ILinkService
    {
        private readonly ILinkRepository _linkRepository;

        public LinkService(ILinkRepository linkRepository)  
        {
            _linkRepository = linkRepository;
        }

        public Link Adicionar(Link obj)
        {
            return _linkRepository.Adicionar(obj);
        }

        public Link Atualizar(Link obj)
        {
            return _linkRepository.Atualizar(obj);
        }

        public void Dispose()
        {
            _linkRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Link ObterPorId(int id)
        {
            return _linkRepository.ObterPorId(id);
        }

        public IQueryable<Link> ObterTodos()
        {
            return _linkRepository.ObterTodos();
        }

        public void Remover(int id)
        {
              _linkRepository.Remover(id);
        }
    }
}
