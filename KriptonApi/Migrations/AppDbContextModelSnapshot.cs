﻿// <auto-generated />
using KriptonApi.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KriptonApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KriptonApi.Entities.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdUsuario");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit")
                        .HasColumnName("Activo");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("VARCHAR (100)")
                        .HasColumnName("Apellido");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("VARCHAR (100)")
                        .HasColumnName("CLave");

                    b.Property<int>("Dni")
                        .HasColumnType("int")
                        .HasColumnName("Dni");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR (100)")
                        .HasColumnName("Email");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR (100)")
                        .HasColumnName("Nombre");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            IdUsuario = 1,
                            Activo = true,
                            Apellido = "Cabrera",
                            Clave = "12345",
                            Dni = 31467581,
                            Email = "martin@gmail.com",
                            Nombre = "Martin"
                        },
                        new
                        {
                            IdUsuario = 2,
                            Activo = true,
                            Apellido = "Gonzalez",
                            Clave = "12345",
                            Dni = 37053098,
                            Email = "florencia@gmail.com",
                            Nombre = "Florencia"
                        },
                        new
                        {
                            IdUsuario = 3,
                            Activo = true,
                            Apellido = "Cabrera",
                            Clave = "12345",
                            Dni = 58706438,
                            Email = "salome@gmail.com",
                            Nombre = "Salome"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
