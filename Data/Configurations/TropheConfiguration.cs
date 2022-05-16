using System;
using System.Collections.Generic;
using System.Text;
using GP.Domain.Entities;
//
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GP.Data.Configurations
{
    public class TropheConfiguration : IEntityTypeConfiguration<Trophe>
    {
        public void Configure(EntityTypeBuilder<Trophe> builder)
        {
            builder.HasOne(trophe => trophe.Equipe)
                .WithMany(equipe => equipe.Trophes)
                //.HasForeignKey("EquipeIdFK")
                .OnDelete(DeleteBehavior.Cascade);
        }
        }
}
