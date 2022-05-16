using System;
using System.Collections.Generic;
using System.Text;
using GP.Domain.Entities;
//
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GP.Data.Configurations
{
    public class ContratConfiguration : IEntityTypeConfiguration<Contrat>
    {
        public void Configure(EntityTypeBuilder<Contrat> builder)
        {
            builder.HasKey(f => new
            {
                f.EquipeIdFK,
                f.IdentifiantFK,
                f.DateContrat
            });
            //le nom de la table au niveau de la BD
            //builder.ToTable("MyCategories");
            //builder.HasKey(c => c.CategoryId);//clé primaire
            //builder.Property(c => c.Name).HasMaxLength(50).IsRequired();//
        }
    }
}
