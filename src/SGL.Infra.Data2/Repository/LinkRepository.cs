using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Repository;
using SGL.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Infra.Data.Repository
{
    public class LinkRepository : Repository<Link>, ILinkRepository
    {
        public LinkRepository(SGLContext context) : base(context)
        {

        }
    }
}
