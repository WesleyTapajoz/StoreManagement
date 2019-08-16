using AutoMapper;
using SGL.Application.ViewModels;
using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Application.AutoMapper
{
    public class Autor_Profile : Profile
    {
        public Autor_Profile()
        {
            CreateMap<Autor, AutorViewModel>()
                .ReverseMap()

              .PreserveReferences();

            CreateMap<Autor, AdicionarAutorViewModel>()
                .ReverseMap()

             .PreserveReferences();

            CreateMap<Autor, AtualizarAutorViewModel>()
                .ReverseMap()

            .PreserveReferences();

            CreateMap<Autor, RemoverAutorViewModel>()
                .PreserveReferences();
        }
    }
}
