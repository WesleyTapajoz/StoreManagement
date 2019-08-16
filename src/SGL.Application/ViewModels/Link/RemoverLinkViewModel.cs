using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Application.ViewModels
{
    public class RemoverLinkViewModel
    {
        public int LinkId { get; set; }
        public string Url { get; set; }
        public string Descricao { get; set; }
        public string Icone { get; set; }
        public int? LivroId { get; set; }
        public virtual LivroViewModel Livro { get; set; }
    }
}
