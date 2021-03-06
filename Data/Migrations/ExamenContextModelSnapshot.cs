// <auto-generated />
using System;
using GP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GP.Data.Migrations
{
    [DbContext(typeof(ExamenContext))]
    partial class ExamenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GP.Domain.Entities.Contrat", b =>
                {
                    b.Property<int>("EquipeIdFK")
                        .HasColumnType("int");

                    b.Property<int>("IdentifiantFK")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateContrat")
                        .HasColumnType("datetime2");

                    b.Property<int>("DureeMois")
                        .HasColumnType("int");

                    b.Property<double>("Salaire")
                        .HasColumnType("float");

                    b.HasKey("EquipeIdFK", "IdentifiantFK", "DateContrat");

                    b.HasIndex("IdentifiantFK");

                    b.ToTable("Contrats");
                });

            modelBuilder.Entity("GP.Domain.Entities.Equipe", b =>
                {
                    b.Property<int>("EquipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AdresseLocal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomEquipe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TropheIdFK")
                        .HasColumnType("int");

                    b.HasKey("EquipeId");

                    b.ToTable("Equipes");
                });

            modelBuilder.Entity("GP.Domain.Entities.Membre", b =>
                {
                    b.Property<int>("Identifiant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Identifiant");

                    b.ToTable("Membres");

                    b.HasDiscriminator<string>("Type").HasValue("M");
                });

            modelBuilder.Entity("GP.Domain.Entities.Trophe", b =>
                {
                    b.Property<int>("TropheeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateTrophe")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EquipeIdFK")
                        .HasColumnType("int");

                    b.Property<double>("Recompense")
                        .HasColumnType("float");

                    b.Property<string>("TypeTrophee")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TropheeId");

                    b.HasIndex("EquipeIdFK");

                    b.ToTable("Trophes");
                });

            modelBuilder.Entity("GP.Domain.Entities.Entraineur", b =>
                {
                    b.HasBaseType("GP.Domain.Entities.Membre");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("E");
                });

            modelBuilder.Entity("GP.Domain.Entities.Joueur", b =>
                {
                    b.HasBaseType("GP.Domain.Entities.Membre");

                    b.Property<string>("Poste")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("J");
                });

            modelBuilder.Entity("GP.Domain.Entities.Contrat", b =>
                {
                    b.HasOne("GP.Domain.Entities.Equipe", "Equipe")
                        .WithMany("Contracts")
                        .HasForeignKey("EquipeIdFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GP.Domain.Entities.Membre", "Membre")
                        .WithMany("Contracts")
                        .HasForeignKey("IdentifiantFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipe");

                    b.Navigation("Membre");
                });

            modelBuilder.Entity("GP.Domain.Entities.Trophe", b =>
                {
                    b.HasOne("GP.Domain.Entities.Equipe", "Equipe")
                        .WithMany("Trophes")
                        .HasForeignKey("EquipeIdFK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Equipe");
                });

            modelBuilder.Entity("GP.Domain.Entities.Equipe", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("Trophes");
                });

            modelBuilder.Entity("GP.Domain.Entities.Membre", b =>
                {
                    b.Navigation("Contracts");
                });
#pragma warning restore 612, 618
        }
    }
}
