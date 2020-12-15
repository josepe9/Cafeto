﻿// <auto-generated />
using System;
using Cafeto.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cafeto.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201215215126_InitialDb")]
    partial class InitialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cafeto.Common.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Codigo");

                    b.Property<int>("DepartamentoId");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("Cafeto.Common.Entities.Corregimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CiudadId");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("CiudadId");

                    b.ToTable("Corregimiento");
                });

            modelBuilder.Entity("Cafeto.Common.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Codigo");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("Cafeto.Common.Entities.Finca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(40);

                    b.Property<int>("Hectareas");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Propietario")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Telefono")
                        .HasMaxLength(20);

                    b.Property<int>("VeredaId");

                    b.HasKey("Id");

                    b.HasIndex("VeredaId");

                    b.ToTable("Fincas");
                });

            modelBuilder.Entity("Cafeto.Common.Entities.Hectarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Arrobas");

                    b.Property<int>("CantidadKF");

                    b.Property<int>("CantidadKN");

                    b.Property<int>("CantidadKP");

                    b.Property<string>("Descripcion");

                    b.Property<int?>("LoteId");

                    b.Property<int>("Menores");

                    b.Property<int>("Palos");

                    b.Property<decimal>("Ph");

                    b.Property<DateTime>("Siembra");

                    b.HasKey("Id");

                    b.HasIndex("LoteId");

                    b.ToTable("Hectareas");
                });

            modelBuilder.Entity("Cafeto.Common.Entities.Lote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FincaId");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("FincaId");

                    b.ToTable("Lotes");
                });

            modelBuilder.Entity("Cafeto.Common.Entities.Parafertil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadKF");

                    b.Property<int>("CantidadKN");

                    b.Property<int>("CantidadKP");

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Menores");

                    b.Property<int>("Meses");

                    b.Property<int>("PalosDesde");

                    b.Property<int>("PalosHasta");

                    b.Property<int>("PhHasta");

                    b.Property<int>("Phdesde");

                    b.HasKey("Id");

                    b.ToTable("Parafertils");
                });

            modelBuilder.Entity("Cafeto.Common.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadKF");

                    b.Property<int>("CantidadKN");

                    b.Property<int>("CantidadKP");

                    b.Property<string>("Detalle")
                        .HasMaxLength(100);

                    b.Property<int>("Menores");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Cafeto.Common.Entities.Vereda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CorregimientoId");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("CorregimientoId");

                    b.ToTable("Veredas");
                });

            modelBuilder.Entity("Cafeto.Common.Entities.Ciudad", b =>
                {
                    b.HasOne("Cafeto.Common.Entities.Departamento", "Departamento")
                        .WithMany("Ciudades")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cafeto.Common.Entities.Corregimiento", b =>
                {
                    b.HasOne("Cafeto.Common.Entities.Ciudad", "Ciudad")
                        .WithMany("Corregimientos")
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cafeto.Common.Entities.Finca", b =>
                {
                    b.HasOne("Cafeto.Common.Entities.Vereda", "Vereda")
                        .WithMany("Fincas")
                        .HasForeignKey("VeredaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cafeto.Common.Entities.Hectarea", b =>
                {
                    b.HasOne("Cafeto.Common.Entities.Lote", "Lote")
                        .WithMany("Hectareas")
                        .HasForeignKey("LoteId");
                });

            modelBuilder.Entity("Cafeto.Common.Entities.Lote", b =>
                {
                    b.HasOne("Cafeto.Common.Entities.Finca", "Finca")
                        .WithMany("Lotes")
                        .HasForeignKey("FincaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cafeto.Common.Entities.Vereda", b =>
                {
                    b.HasOne("Cafeto.Common.Entities.Corregimiento", "Corregimiento")
                        .WithMany("Veredas")
                        .HasForeignKey("CorregimientoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
