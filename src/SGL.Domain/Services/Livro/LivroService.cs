using SGL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Repository;

namespace SGL.Domain.Services
{
    public class LivroService : Service<Livro, string>, ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository) : base(livroRepository)
        {
            _livroRepository = livroRepository;
        }
    }
}
