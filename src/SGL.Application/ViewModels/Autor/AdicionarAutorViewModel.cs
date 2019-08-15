using System.Collections.Generic;

namespace SGL.Application.ViewModels
{
    public class AdicionarAutorViewModel
    {
        public int AutorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int LivroId { get; set; }
        public IEnumerable<LivroViewModel> Livros { get; set; }
    }
}
