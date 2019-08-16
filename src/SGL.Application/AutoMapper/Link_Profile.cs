using AutoMapper;
using SGL.Application.ViewModels;
using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Application.AutoMapper
{
    public class Link_Profile : Profile
    {
        public Link_Profile()
        {
            CreateMap<Link, LinkViewModel>()
                .ReverseMap()

              .PreserveReferences();

            CreateMap<Link, AdicionarLinkViewModel>()
                .ReverseMap()

             .PreserveReferences();

            CreateMap<Link, AtualizarLinkViewModel>()
                .ReverseMap()

            .PreserveReferences();

            CreateMap<Link, RemoverLinkViewModel>()
                .PreserveReferences();
        }
    }
}
