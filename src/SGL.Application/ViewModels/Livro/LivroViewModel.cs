using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGL.Application.ViewModels
{
    public class LivroViewModel
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DataPublicacao { get; set; }
        public int Paginas { get; set; }
        public int GeneroId { get; set; }
        public virtual GeneroViewModel Genero { get; set; }
        public int AutorId { get; set; }
        public virtual AutorViewModel Autor { get; set; }
        public int EditoraId { get; set; }
        public virtual EditoraViewModel Editora { get; set; }
        public string Descricao { get; set; }
        public string Sinopse { get; set; }
        public string Capa { get; set; }
        public int? LinkId { get; set; }
        public virtual ICollection<LinkViewModel> Links { get; set; }
    }
}
