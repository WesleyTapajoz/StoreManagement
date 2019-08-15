using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Domain.Entity
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string Descricao { get; set; }
        public ICollection<Livro> Livros { get; set; }
    }
}
