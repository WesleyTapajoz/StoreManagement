using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Domain.Entity
{
    public class Link
    {
        public int LinkId { get; set; }
        public string Url { get; set; }
        public string Descricao { get; set; }
        public string Icone { get; set; }
        public int? LivroId { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }
    }
}
