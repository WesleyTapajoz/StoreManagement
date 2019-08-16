using System.Collections.Generic;
using SGL.Application.Interfaces;
using SGL.Application.ViewModels;
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
            throw new System.NotImplementedException();
        }

        public AtualizarGeneroViewModel Atualizar(AtualizarGeneroViewModel obj)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public GeneroViewModel ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<GeneroViewModel> ObterTodos()
        {
            throw new System.NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
