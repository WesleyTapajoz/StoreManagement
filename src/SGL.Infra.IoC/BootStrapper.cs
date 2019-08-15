using Autofac;
using SGL.Domain.Interfaces.Repository;
using SGL.Domain.Interfaces.Services;
using SGL.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

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
            builder.RegisterType<LinkAppService>().As<IlinkAppService>().InstancePerLifetimeScope();
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
            builder.RegisterType<IAutorRepository>().As<IAutorRepository>().InstancePerLifetimeScope();
            builder.RegisterType<IEditoraRepository>().As<IEditoraRepository>().InstancePerLifetimeScope();
            builder.RegisterType<IGeneroRepository>().As<IGeneroRepository>().InstancePerLifetimeScope();
            builder.RegisterType<ILinkRepository>().As<ILinkRepository>().InstancePerLifetimeScope();
            builder.RegisterType<ILivroRepository>().As<ILivroRepository>().InstancePerLifetimeScope();
            #endregion
        }
    }
}
