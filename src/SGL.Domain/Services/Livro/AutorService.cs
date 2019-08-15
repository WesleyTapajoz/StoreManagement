using SGL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Repository;

namespace SGL.Domain.Services
{
    public class AutorService : Service<Autor, string>, IAutorService
    {
        private readonly IAutorRepository _autorRepository;

        public AutorService(IAutorRepository autorRepository) : base(autorRepository)
        {
            _autorRepository = autorRepository;
        }
    }
}
