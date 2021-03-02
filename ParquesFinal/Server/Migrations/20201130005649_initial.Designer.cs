﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParquesFinal.Server;

namespace ParquesFinal.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201130005649_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.ActividadIlicita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("TipoActividadIlicita")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ActividadesIlicitas");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParqueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParqueId")
                        .IsUnique();

                    b.ToTable("Administrador");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("FCreacion")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.Ecosistema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCientifico")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ecosistemas");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.Parque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaCreacion")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Parques");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.ParqueEcosistema", b =>
                {
                    b.Property<int>("EcosistemaId")
                        .HasColumnType("int");

                    b.Property<int>("ParqueId")
                        .HasColumnType("int");

                    b.HasKey("EcosistemaId", "ParqueId");

                    b.HasIndex("ParqueId");

                    b.ToTable("ParqueEcosistemas");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.ParqueIlicito", b =>
                {
                    b.Property<int>("ActividadIlicitaId")
                        .HasColumnType("int");

                    b.Property<int>("ParqueId")
                        .HasColumnType("int");

                    b.HasKey("ActividadIlicitaId", "ParqueId");

                    b.HasIndex("ParqueId");

                    b.ToTable("ParqueIlicitos");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.Personal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdParque")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParqueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParqueId");

                    b.ToTable("Personales");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CantidadPersonas")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaSalida")
                        .HasColumnType("datetime2");

                    b.Property<int>("VisitanteId")
                        .HasColumnType("int");

                    b.Property<int>("ZonaAlojamientoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VisitanteId");

                    b.HasIndex("ZonaAlojamientoId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.Visitante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Visitantes");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.ZonaAlojamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<int>("Costo")
                        .HasColumnType("int");

                    b.Property<int>("ParqueId")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParqueId");

                    b.ToTable("ZonasDeAlojamiento");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.Administrador", b =>
                {
                    b.HasOne("ParquesFinal.Shared.Entidades.Parque", null)
                        .WithOne("Administrador")
                        .HasForeignKey("ParquesFinal.Shared.Entidades.Administrador", "ParqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.Parque", b =>
                {
                    b.HasOne("ParquesFinal.Shared.Entidades.Car", null)
                        .WithMany("Parques")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.ParqueEcosistema", b =>
                {
                    b.HasOne("ParquesFinal.Shared.Entidades.Ecosistema", "Ecosistema")
                        .WithMany("ParqueEcosistemas")
                        .HasForeignKey("EcosistemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParquesFinal.Shared.Entidades.Parque", "Parque")
                        .WithMany("ParqueEcosistemas")
                        .HasForeignKey("ParqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ecosistema");

                    b.Navigation("Parque");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.ParqueIlicito", b =>
                {
                    b.HasOne("ParquesFinal.Shared.Entidades.ActividadIlicita", "ActividadIlicita")
                        .WithMany("ParqueIlicitos")
                        .HasForeignKey("ActividadIlicitaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParquesFinal.Shared.Entidades.Parque", "Parque")
                        .WithMany("ParqueIlicitos")
                        .HasForeignKey("ParqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActividadIlicita");

                    b.Navigation("Parque");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.Personal", b =>
                {
                    b.HasOne("ParquesFinal.Shared.Entidades.Parque", null)
                        .WithMany("Personales")
                        .HasForeignKey("ParqueId");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.Reserva", b =>
                {
                    b.HasOne("ParquesFinal.Shared.Entidades.Visitante", null)
                        .WithMany("Reservas")
                        .HasForeignKey("VisitanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParquesFinal.Shared.Entidades.ZonaAlojamiento", null)
                        .WithMany("Reservas")
                        .HasForeignKey("ZonaAlojamientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.ZonaAlojamiento", b =>
                {
                    b.HasOne("ParquesFinal.Shared.Entidades.Parque", null)
                        .WithMany("ZonasDeAlojamiento")
                        .HasForeignKey("ParqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.ActividadIlicita", b =>
                {
                    b.Navigation("ParqueIlicitos");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.Car", b =>
                {
                    b.Navigation("Parques");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.Ecosistema", b =>
                {
                    b.Navigation("ParqueEcosistemas");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.Parque", b =>
                {
                    b.Navigation("Administrador");

                    b.Navigation("ParqueEcosistemas");

                    b.Navigation("ParqueIlicitos");

                    b.Navigation("Personales");

                    b.Navigation("ZonasDeAlojamiento");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.Visitante", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("ParquesFinal.Shared.Entidades.ZonaAlojamiento", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}