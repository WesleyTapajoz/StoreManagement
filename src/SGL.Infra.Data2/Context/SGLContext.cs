using SGL.Domain.Entity;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;

namespace SGL.Infra.Data.Context
{
    public class SGLContext : DbContext
    {
        public SGLContext() : base("name=strConexaoSGL")
        {
           
        }

        #region 1. Entities
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Livro> Livros { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modeBuilder)
        {
            modeBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modeBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modeBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            var targetAssembly = Assembly.GetExecutingAssembly();
            var subtypes = targetAssembly.GetTypes().Where(t => t.Name.EndsWith("_Mapping"));
            foreach (var item in subtypes)
            {
                dynamic configurationInstance = Activator.CreateInstance(item);
                modeBuilder.Configurations.Add(configurationInstance);
            }

            modeBuilder.Properties<string>().Configure(e => e.HasColumnType("varchar"));

        }
    }
}
