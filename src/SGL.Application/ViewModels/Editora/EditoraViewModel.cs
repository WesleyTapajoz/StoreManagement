using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Application.ViewModels
{
    public class EditoraViewModel
    {
        public string Descricao { get; set; }
        public string Email { get; set; }
        public int LivroId { get; set; }
        public virtual IEnumerable<LivroViewModel> Livros { get; set; }
    }
}
