using AutoMapper;
using SGL.Application.ViewModels;
using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Application.AutoMapper
{
    public class Livro_Profile : Profile
    {
        public Livro_Profile()
        {
            CreateMap<Livro, LivroViewModel>()
                .ReverseMap()
             .PreserveReferences();


            CreateMap<Livro, AdicionarLivroViewModel>()
                .ReverseMap()

             .PreserveReferences();

            CreateMap<Livro, AtualizarLivroViewModel>()
                .ReverseMap()
            .PreserveReferences();

            CreateMap<Livro, RemoverLivroViewModel>()
                .PreserveReferences();
        }
    }
}
