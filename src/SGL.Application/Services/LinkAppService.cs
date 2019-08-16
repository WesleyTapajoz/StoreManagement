using System.Collections.Generic;
using SGL.Application.Interfaces;
using SGL.Application.ViewModels;
using SGL.Domain.Interfaces.Services;
using SGL.Infra.Data;

namespace SGL.Application.Services
{
    public class LinkAppService : ApplicationService, ILinkAppService
    {
        private readonly ILinkService _generoService;

        public LinkAppService(ILinkService generoService, IUnitOfWork uow)
            : base(uow)
        {
            _generoService = generoService;
        }

        public AdicionarLinkViewModel Adicionar(AdicionarLinkViewModel obj)
        {
            throw new System.NotImplementedException();
        }

        public AtualizarLinkViewModel Atualizar(AtualizarLinkViewModel obj)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public LinkViewModel ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<LinkViewModel> ObterTodos()
        {
            throw new System.NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
