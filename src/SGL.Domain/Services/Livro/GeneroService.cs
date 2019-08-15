using SGL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Repository;

namespace SGL.Domain.Services
{
    public class GeneroService : Service<Genero, string>, IGeneroService
    {
        private readonly IGeneroRepository _generoRepository;

        public GeneroService(IGeneroRepository generoRepository) : base(generoRepository)
        {
            _generoRepository = generoRepository;
        }
    }
}
