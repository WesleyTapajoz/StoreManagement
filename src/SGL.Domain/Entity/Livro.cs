using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Domain.Entity
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }      
        public DateTime DataPublicacao { get; set; }
        public int Paginas { get; set; }
        public int GeneroId { get; set; }
        public virtual Genero Genero { get; set; }
        public int AutorId { get; set; }
        public virtual Autor Autor { get; set; }
        public int EditoraId { get; set; }
        public virtual Editora Editora { get; set; }
        public string Descricao { get; set; }
        public string Sinopse { get; set; }
        public string Capa { get; set; }
        public int? LinkId { get; set; }
        public virtual Link Link { get; set; }
    }
}
