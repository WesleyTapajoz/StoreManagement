using AutoMapper;
using SGL.Application.ViewModels;
using SGL.Domain.Entity;

namespace SGL.Application.AutoMapper
{
    public class Editora_Profile : Profile
    {
        public Editora_Profile()
        {
            CreateMap<Editora, EditoraViewModel>()
                .ReverseMap()

            .PreserveReferences();

            CreateMap<Editora, AdicionarEditoraViewModel>()
                .ReverseMap()

             .PreserveReferences();

            CreateMap<Editora, AtualizarEditoraViewModel>()
                .ReverseMap()

            .PreserveReferences();

            CreateMap<Editora, RemoverEditoraViewModel>()
                .PreserveReferences();
        }
    }
}
