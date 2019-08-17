using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace SGL.Infra.Data.EntityConfig
{
    public class Link_Mapping : EntityTypeConfiguration<Link>
    {
        public Link_Mapping()
        {
            ToTable("Link");

            HasKey(x => x.LinkId);

            Property(p => p.Icone)
                .IsOptional();

            Property(p => p.Url)
                .IsRequired();

            Property(p => p.Descricao)
                .IsRequired();

         
        }
    }
}
