using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Repository;
using SGL.Infra.Data.Context;
 

namespace SGL.Infra.Data.Repository
{
    public class GeneroRepository : Repository<Genero>, IGeneroRepository
    {
        public GeneroRepository(SGLContext context) : base(context)
        {

        }
    }
}
