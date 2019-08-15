using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace SGL.Infra.Data.EntityConfig
{
    public class Autor_Mapping : EntityTypeConfiguration<Autor>
    {
        public Autor_Mapping()
        {
            ToTable("Autor");

            HasKey(x => x.AutorId);

            Property(p => p.Nome)
                .IsRequired();

            Property(p => p.Email)
                .IsRequired();

            HasMany(x => x.Livros)
               .WithRequired(x => x.Autor)
               .HasForeignKey(x => x.AutorId);
        }
    }
}
