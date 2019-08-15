using SGL.Application.ViewModels;

namespace SGL.Application.Interfaces
{
    public interface ILivroAppService : IAppService<AdicionarLivroViewModel, LivroViewModel, AtualizarLivroViewModel, int>
    {
    }
}
