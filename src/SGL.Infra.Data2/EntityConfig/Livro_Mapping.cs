using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace SGL.Infra.Data.EntityConfig
{
    public class Livro_Mapping : EntityTypeConfiguration<Livro>
    {
        public Livro_Mapping()
        {
            ToTable("Livro");

            HasKey(x => x.AutorId);

            Property(p => p.Capa)
                .IsRequired();

            Property(x => x.Descricao)
                .IsRequired();

            Property(x => x.Titulo)
                .IsRequired();

            Property(x => x.DataPublicacao)
                 .IsRequired();

            Property(x => x.EditoraId)
                     .IsRequired();

            Property(x => x.GeneroId)
                   .IsRequired();

            Property(x => x.Sinopse)
                    .IsRequired();
        }
    }
}
