using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Repository;
using SGL.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Infra.Data.Repository
{
    public class AutorRepository : Repository<Autor>, IAutorRepository
    {
        public AutorRepository(SGLContext context) : base(context)
        {

        }
    }
}
