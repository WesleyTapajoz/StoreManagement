﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Application.ViewModels
{
    public class RemoverGeneroViewModel
    {
        public int GeneroId { get; set; }
        public string Descricao { get; set; }
        public int LivroId { get; set; }
        public virtual ICollection<LivroViewModel> Livros { get; set; }
    }
}
