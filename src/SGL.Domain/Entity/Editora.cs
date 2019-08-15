using System.Collections.Generic;

namespace SGL.Domain.Entity
{
    public class Editora
    {
        public int EditoraId { get; set; }
        public string Descricao { get; set; }
        public string Email { get; set; }
        public int LivroId { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }
    }
}
