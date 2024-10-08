﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend_D_D.Data;

#nullable disable

namespace backend_D_D.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240902161843_Aggiornamento migrazione precedente")]
    partial class Aggiornamentomigrazioneprecedente
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("backend_D_D.Models.Entity.Abilita", b =>
                {
                    b.Property<int>("AbilitaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AbilitaId"));

                    b.Property<bool>("Acrobazia")
                        .HasColumnType("bit");

                    b.Property<bool>("Addestrare_Animali")
                        .HasColumnType("bit");

                    b.Property<bool>("Arcano")
                        .HasColumnType("bit");

                    b.Property<bool>("Atletica")
                        .HasColumnType("bit");

                    b.Property<bool>("Furtivita")
                        .HasColumnType("bit");

                    b.Property<bool>("Indagare")
                        .HasColumnType("bit");

                    b.Property<bool>("Inganno")
                        .HasColumnType("bit");

                    b.Property<bool>("Intimidire")
                        .HasColumnType("bit");

                    b.Property<bool>("Intrattenere")
                        .HasColumnType("bit");

                    b.Property<bool>("Intuizione")
                        .HasColumnType("bit");

                    b.Property<bool>("Medicina")
                        .HasColumnType("bit");

                    b.Property<bool>("Natura")
                        .HasColumnType("bit");

                    b.Property<bool>("Percezione")
                        .HasColumnType("bit");

                    b.Property<int>("PersonaggioID")
                        .HasColumnType("int");

                    b.Property<bool>("Persuasione")
                        .HasColumnType("bit");

                    b.Property<bool>("Rapidita_di_Mano")
                        .HasColumnType("bit");

                    b.Property<bool>("Religione")
                        .HasColumnType("bit");

                    b.Property<bool>("Sopravvivenza")
                        .HasColumnType("bit");

                    b.Property<bool>("Storia")
                        .HasColumnType("bit");

                    b.HasKey("AbilitaId");

                    b.ToTable("Abilita");
                });

            modelBuilder.Entity("backend_D_D.Models.Entity.Armatura", b =>
                {
                    b.Property<int>("ArmaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArmaturaId"));

                    b.Property<int>("CA")
                        .HasColumnType("int");

                    b.Property<string>("Effetto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonaggioID")
                        .HasColumnType("int");

                    b.HasKey("ArmaturaId");

                    b.ToTable("Armatura");
                });

            modelBuilder.Entity("backend_D_D.Models.Entity.Armi", b =>
                {
                    b.Property<int>("ArmaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArmaId"));

                    b.Property<string>("BonusArma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Danno")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonaggioID")
                        .HasColumnType("int");

                    b.HasKey("ArmaId");

                    b.ToTable("Armi");
                });

            modelBuilder.Entity("backend_D_D.Models.Entity.Attributi", b =>
                {
                    b.Property<int>("AttributiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AttributiId"));

                    b.Property<int>("Carisma")
                        .HasColumnType("int");

                    b.Property<int>("Costituzione")
                        .HasColumnType("int");

                    b.Property<int>("Destrezza")
                        .HasColumnType("int");

                    b.Property<int>("Forza")
                        .HasColumnType("int");

                    b.Property<int>("Intelligenza")
                        .HasColumnType("int");

                    b.Property<int>("PersonaggioID")
                        .HasColumnType("int");

                    b.Property<int>("Saggezza")
                        .HasColumnType("int");

                    b.HasKey("AttributiId");

                    b.ToTable("Attributi");
                });

            modelBuilder.Entity("backend_D_D.Models.Entity.Backgound", b =>
                {
                    b.Property<int>("BackgroundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BackgroundId"));

                    b.Property<int>("Difetti")
                        .HasColumnType("int");

                    b.Property<int>("Ideali")
                        .HasColumnType("int");

                    b.Property<int>("Legami")
                        .HasColumnType("int");

                    b.Property<int>("PersonaggioID")
                        .HasColumnType("int");

                    b.Property<int>("TrattiCaratteriali")
                        .HasColumnType("int");

                    b.HasKey("BackgroundId");

                    b.ToTable("Backgound");
                });

            modelBuilder.Entity("backend_D_D.Models.Entity.Classi", b =>
                {
                    b.Property<int>("ClassiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassiId"));

                    b.Property<int>("Livello")
                        .HasColumnType("int");

                    b.Property<int>("PersonaggioID")
                        .HasColumnType("int");

                    b.HasKey("ClassiId");

                    b.ToTable("Classi");
                });

            modelBuilder.Entity("backend_D_D.Models.Entity.Inventario", b =>
                {
                    b.Property<int>("InventarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventarioId"));

                    b.Property<string>("Effetto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonaggioID")
                        .HasColumnType("int");

                    b.HasKey("InventarioId");

                    b.ToTable("Inventario");
                });

            modelBuilder.Entity("backend_D_D.Models.Entity.Personaggio", b =>
                {
                    b.Property<int>("PersonaggioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonaggioID"));

                    b.Property<int>("Allineamento")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("IdUtente")
                        .HasColumnType("int");

                    b.HasKey("PersonaggioID");

                    b.ToTable("Personaggio");
                });

            modelBuilder.Entity("backend_D_D.Models.Entity.Tiri_Salvezza", b =>
                {
                    b.Property<int>("TiriSalvezzaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TiriSalvezzaId"));

                    b.Property<bool>("Carisma")
                        .HasColumnType("bit");

                    b.Property<bool>("Costituzione")
                        .HasColumnType("bit");

                    b.Property<bool>("Destrezza")
                        .HasColumnType("bit");

                    b.Property<bool>("Forza")
                        .HasColumnType("bit");

                    b.Property<bool>("Intelligenza")
                        .HasColumnType("bit");

                    b.Property<int>("PersonaggioID")
                        .HasColumnType("int");

                    b.Property<bool>("Saggezza")
                        .HasColumnType("bit");

                    b.HasKey("TiriSalvezzaId");

                    b.ToTable("Tiri_Salvezza");
                });

            modelBuilder.Entity("backend_D_D.Models.Entity.Utente", b =>
                {
                    b.Property<int>("UtenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UtenteId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeUtente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passoword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UtenteId");

                    b.ToTable("Utente");
                });
#pragma warning restore 612, 618
        }
    }
}
