using System.Collections.Generic;
using SGL.Application.Interfaces;
using SGL.Application.ViewModels;
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
            throw new System.NotImplementedException();
        }

        public AtualizarLivroViewModel Atualizar(AtualizarLivroViewModel obj)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public LivroViewModel ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<LivroViewModel> ObterTodos()
        {
            throw new System.NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
