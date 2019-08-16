using Autofac;
using SGL.Application.Interfaces;
using SGL.Application.Services;
using SGL.Domain.Interfaces.Repository;
using SGL.Domain.Interfaces.Services;
using SGL.Domain.Services;
using SGL.Infra.Data;
using SGL.Infra.Data.Context;
using SGL.Infra.Data.Repository;

namespace SGL.Infra.IoC
{
  public  class BootStrapper
    {
        public static void RegisterServices(ContainerBuilder builder)
        {
            #region Registra componentes da camada Application

            builder.RegisterType<AutorAppService>().As<IAutorAppService>().InstancePerLifetimeScope();
            builder.RegisterType<EditoraAppService>().As<IEditoraAppService>().InstancePerLifetimeScope();
            builder.RegisterType<GeneroAppService>().As<IGeneroAppService>().InstancePerLifetimeScope();
            builder.RegisterType<LinkAppService>().As<ILinkAppService>().InstancePerLifetimeScope();
            builder.RegisterType<LivroAppService>().As<ILivroAppService>().InstancePerLifetimeScope();

            #endregion

            #region Registra componentes da camada Domain
            builder.RegisterType<AutorService>().As<IAutorService>().InstancePerLifetimeScope();
            builder.RegisterType<EditoraService>().As<IEditoraService>().InstancePerLifetimeScope();
            builder.RegisterType<GeneroService>().As<IGeneroService>().InstancePerLifetimeScope();
            builder.RegisterType<LinkService>().As<ILinkService>().InstancePerLifetimeScope();
            builder.RegisterType<LivroService>().As<ILivroService>().InstancePerLifetimeScope();

            #endregion

            #region Registra componentes da camada Infrastructure -> Data
            builder.RegisterType<AutorRepository>().As<IAutorRepository>().InstancePerLifetimeScope();
            builder.RegisterType<EditoraRepository>().As<IEditoraRepository>().InstancePerLifetimeScope();
            builder.RegisterType<GeneroRepository>().As<IGeneroRepository>().InstancePerLifetimeScope();
            builder.RegisterType<LinkRepository>().As<ILinkRepository>().InstancePerLifetimeScope();
            builder.RegisterType<LivroRepository>().As<ILivroRepository>().InstancePerLifetimeScope();

            builder.RegisterType<SGLContext>().InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

            #endregion
        }
    }
}
