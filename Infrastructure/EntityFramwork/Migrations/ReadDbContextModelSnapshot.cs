﻿// <auto-generated />
using System;
using Infrastructure.EntityFramwork.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.EntityFramwork.Migrations
{
    [DbContext(typeof(ReadDbContext))]
    partial class ReadDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Infrastructure.EntityFramwork.ReadModel.Categorias.CategoriaReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("usuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Categoria", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EntityFramwork.ReadModel.Cuentas.CuentaReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.Property<decimal>("Saldo")
                        .HasPrecision(20, 2)
                        .HasColumnType("decimal(20,2)")
                        .HasColumnName("saldo");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("usuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Cuenta", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EntityFramwork.ReadModel.Movimientos.MovimientoReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("categoriaId");

                    b.Property<Guid>("CuentaId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("cuentaId");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descripcion");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha");

                    b.Property<decimal>("Saldo")
                        .HasPrecision(20, 2)
                        .HasColumnType("decimal(20,2)")
                        .HasColumnName("saldo");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tipo");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("CuentaId");

                    b.ToTable("Movimiento", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EntityFramwork.ReadModel.Usuarios.UsuarioReadModel", b =>
                {
                    b.Property<Guid>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("usuarioId");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("firstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("lastName");

                    b.Property<decimal>("MontoTotal")
                        .HasPrecision(20, 2)
                        .HasColumnType("decimal(20,2)")
                        .HasColumnName("montoTotal");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EntityFramwork.ReadModel.Categorias.CategoriaReadModel", b =>
                {
                    b.HasOne("Infrastructure.EntityFramwork.ReadModel.Usuarios.UsuarioReadModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Infrastructure.EntityFramwork.ReadModel.Cuentas.CuentaReadModel", b =>
                {
                    b.HasOne("Infrastructure.EntityFramwork.ReadModel.Usuarios.UsuarioReadModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Infrastructure.EntityFramwork.ReadModel.Movimientos.MovimientoReadModel", b =>
                {
                    b.HasOne("Infrastructure.EntityFramwork.ReadModel.Categorias.CategoriaReadModel", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Infrastructure.EntityFramwork.ReadModel.Cuentas.CuentaReadModel", "Cuenta")
                        .WithMany()
                        .HasForeignKey("CuentaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Cuenta");
                });
#pragma warning restore 612, 618
        }
    }
}
