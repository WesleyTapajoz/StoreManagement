using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace SGL.Infra.Data.EntityConfig
{
    public class Editora_Mapping : EntityTypeConfiguration<Editora>
    {

        public Editora_Mapping()
        {
            ToTable("Editora");

            HasKey(x => x.EditoraId);

            Property(p => p.Descricao)
                .IsRequired();

            Property(x => x.Email)
                .IsRequired();

            HasMany(x => x.Livros)
                .WithRequired(x => x.Editora)
                .HasForeignKey(x => x.EditoraId);
        }
    }
}
