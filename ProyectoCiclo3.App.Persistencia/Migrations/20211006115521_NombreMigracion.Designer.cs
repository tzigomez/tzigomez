﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoCiclo3.App.Persistencia;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211006115521_NombreMigracion")]
    partial class NombreMigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Aeropuertos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("coord_x")
                        .HasColumnType("int");

                    b.Property<int>("coord_y")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pais")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Aeropuertos");
                });

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Aviones", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("capacidad_maxima")
                        .HasColumnType("int");

                    b.Property<string>("marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("modelo")
                        .HasColumnType("int");

                    b.Property<int>("numero_asientos")
                        .HasColumnType("int");

                    b.Property<int>("numero_banos")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Aviones");
                });

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Rutas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("destino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("origen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tiempo_estimado")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Rutas");
                });
#pragma warning restore 612, 618
        }
    }
}
