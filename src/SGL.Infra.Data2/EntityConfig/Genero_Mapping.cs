using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace SGL.Infra.Data.EntityConfig
{
    public class Genero_Mapping : EntityTypeConfiguration<Genero>
    {
        public Genero_Mapping()
        {
            ToTable("Genero");

            HasKey(x => x.GeneroId);

            Property(p => p.Descricao)
                .IsRequired();

            HasMany(x => x.Livros)
                   .WithRequired(x => x.Genero)
                   .HasForeignKey(x => x.GeneroId);
        }
    }
}
