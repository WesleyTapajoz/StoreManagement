using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Repository;
using SGL.Infra.Data.Context;

namespace SGL.Infra.Data.Repository
{
    public class LivroRepository : Repository<Livro>, ILivroRepository
    {
        public LivroRepository(SGLContext context) : base(context)
        {

        }
    }
}
