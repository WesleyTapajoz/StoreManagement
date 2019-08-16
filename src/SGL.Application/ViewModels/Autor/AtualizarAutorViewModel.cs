using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Application.ViewModels
{
    public class AtualizarAutorViewModel
    {
        public int AutorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int LivroId { get; set; }
        public IEnumerable<LivroViewModel> Livros { get; set; }
    }
}
