using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Domain.Entity
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int LivroId { get; set; }
        public ICollection<Livro> Livros { get; set; }
    }
}
