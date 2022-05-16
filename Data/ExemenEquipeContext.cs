using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

using GP.Domain.Entities;
using GP.Data.Configurations;
using System.Linq;

namespace GP.Data
{
    public class ExamenContext : DbContext
    {
        public ExamenContext()
        {
            //this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public ExamenContext(DbContextOptions<ExamenContext> options) : base(options)
        {

        }

     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContratConfiguration());
            modelBuilder.ApplyConfiguration(new TropheConfiguration());
            //table d'heritage
            modelBuilder.Entity<Membre>()
                .HasDiscriminator<string>("Type")
                .HasValue<Entraineur>("E")
                .HasValue<Joueur>("J")
                .HasValue<Membre>("M");


           // modelBuilder.ApplyConfiguration(new ContratConfiguration());
            base.OnModelCreating(modelBuilder);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
               .UseSqlServer(@"Server=localhost;Database=FederationBD;Trusted_Connection=True;");
        }

        //  public DbSet<Category> Categories { get; set; }
        public DbSet<Trophe> Trophes { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<Entraineur> Entraineurs { get; set; }
        public DbSet<Contrat> Contrats { get; set; }
        public DbSet<Membre> Membres { get; set; }




    }
}
