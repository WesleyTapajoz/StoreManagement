using AutoMapper;
using SGL.Application.ViewModels;
using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Application.AutoMapper
{
  public  class Genero_Profile : Profile
    {

        public Genero_Profile()
        {
            CreateMap<Genero, GeneroViewModel>()
                .ReverseMap()

              .PreserveReferences();

            CreateMap<Genero, AdicionarGeneroViewModel>()
                .ReverseMap()

             .PreserveReferences();

            CreateMap<Genero, AtualizarGeneroViewModel>()
                .ReverseMap()

            .PreserveReferences();

            CreateMap<Genero, RemoverGeneroViewModel>()
                .PreserveReferences();
        }
    }
}
