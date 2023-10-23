﻿// <auto-generated />
using System;
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

            modelBuilder.Entity("KriptonApi.Entities.Cotizacion", b =>
                {
                    b.Property<int>("IdCotizacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCotizacion");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCotizacion"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit")
                        .HasColumnName("Activo");

                    b.Property<decimal>("Compra")
                        .HasColumnType("money")
                        .HasColumnName("Compra");

                    b.Property<int>("IdMoneda")
                        .HasColumnType("int")
                        .HasColumnName("IdMoneda");

                    b.Property<decimal>("Venta")
                        .HasColumnType("money")
                        .HasColumnName("Venta");

                    b.HasKey("IdCotizacion");

                    b.HasIndex("IdMoneda");

                    b.ToTable("Cotizacion");

                    b.HasData(
                        new
                        {
                            IdCotizacion = 1,
                            Activo = true,
                            Compra = 347.50m,
                            IdMoneda = 1,
                            Venta = 365.5m
                        },
                        new
                        {
                            IdCotizacion = 2,
                            Activo = true,
                            Compra = 369.89m,
                            IdMoneda = 2,
                            Venta = 370.47m
                        });
                });

            modelBuilder.Entity("KriptonApi.Entities.Criptomoneda", b =>
                {
                    b.Property<int>("IdCripto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCripto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCripto"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR (100)")
                        .HasColumnName("Nombre");

                    b.Property<decimal>("TasaConversion")
                        .HasColumnType("decimal")
                        .HasColumnName("TasaConversion");

                    b.HasKey("IdCripto");

                    b.ToTable("Criptomoneda");

                    b.HasData(
                        new
                        {
                            IdCripto = 1,
                            Nombre = "BTC",
                            TasaConversion = 0.25m
                        },
                        new
                        {
                            IdCripto = 2,
                            Nombre = "ETH",
                            TasaConversion = 0.35m
                        },
                        new
                        {
                            IdCripto = 3,
                            Nombre = "LTC",
                            TasaConversion = 0.3m
                        });
                });

            modelBuilder.Entity("KriptonApi.Entities.Cuenta", b =>
                {
                    b.Property<int>("IdCuenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCuenta");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCuenta"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit")
                        .HasColumnName("Activo");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("VARCHAR (100)")
                        .HasColumnName("Alias");

                    b.Property<string>("Cbu")
                        .IsRequired()
                        .HasColumnType("VARCHAR (100)")
                        .HasColumnName("Cbu");

                    b.Property<int>("IdTipoCuenta")
                        .HasColumnType("int")
                        .HasColumnName("IdTipoCuenta");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("IdUsuario");

                    b.Property<int>("NumeroCuenta")
                        .HasColumnType("int")
                        .HasColumnName("NumeroCuenta");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal")
                        .HasColumnName("Saldo");

                    b.Property<string>("UUID")
                        .IsRequired()
                        .HasColumnType("VARCHAR (100)")
                        .HasColumnName("UUID");

                    b.HasKey("IdCuenta");

                    b.HasIndex("IdTipoCuenta");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Cuenta");

                    b.HasData(
                        new
                        {
                            IdCuenta = 1,
                            Activo = true,
                            Alias = "Patria.gorro.Caucho",
                            Cbu = "01702046600000087865",
                            IdTipoCuenta = 1,
                            IdUsuario = 1,
                            NumeroCuenta = 204878658,
                            Saldo = 50000m,
                            UUID = "12345678123456781234567812345678"
                        },
                        new
                        {
                            IdCuenta = 2,
                            Activo = true,
                            Alias = "Raiz.Arbol.Planta",
                            Cbu = "0290000100000000058382",
                            IdTipoCuenta = 2,
                            IdUsuario = 2,
                            NumeroCuenta = 5838,
                            Saldo = 80000m,
                            UUID = "123456781234-56781234567812345678"
                        },
                        new
                        {
                            IdCuenta = 3,
                            Activo = true,
                            Alias = "Alfil.Oslo.Rima",
                            Cbu = "0110599520000001235579",
                            IdTipoCuenta = 3,
                            IdUsuario = 3,
                            NumeroCuenta = 123557,
                            Saldo = 90000m,
                            UUID = "123456781234-56781234567812785643"
                        });
                });

            modelBuilder.Entity("KriptonApi.Entities.Moneda", b =>
                {
                    b.Property<int>("IdMoneda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("IdMoneda");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMoneda"));

                    b.Property<bool>("Activo")
                        .HasColumnType("BIT")
                        .HasColumnName("Activo");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("Simbolo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(5)")
                        .HasColumnName("Simbolo");

                    b.HasKey("IdMoneda");

                    b.ToTable("Moneda");

                    b.HasData(
                        new
                        {
                            IdMoneda = 1,
                            Activo = true,
                            Descripcion = "Dólar",
                            Simbolo = "u$s"
                        },
                        new
                        {
                            IdMoneda = 2,
                            Activo = true,
                            Descripcion = "Euro",
                            Simbolo = "€"
                        });
                });

            modelBuilder.Entity("KriptonApi.Entities.TipoCuenta", b =>
                {
                    b.Property<int>("IdTipoCuenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdTipoCuenta");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoCuenta"));

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("VARCHAR (100)")
                        .HasColumnName("Descr");

                    b.HasKey("IdTipoCuenta");

                    b.ToTable("TipoCuenta");

                    b.HasData(
                        new
                        {
                            IdTipoCuenta = 1,
                            Descr = "pesos"
                        },
                        new
                        {
                            IdTipoCuenta = 2,
                            Descr = "dolares"
                        },
                        new
                        {
                            IdTipoCuenta = 3,
                            Descr = "Criptomoneda"
                        });
                });

            modelBuilder.Entity("KriptonApi.Entities.TipoTransaccion", b =>
                {
                    b.Property<int>("IdTipoTransaccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdTipoTransaccion");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoTransaccion"));

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("VARCHAR (100)")
                        .HasColumnName("Descr");

                    b.HasKey("IdTipoTransaccion");

                    b.ToTable("TipoTransaccion");

                    b.HasData(
                        new
                        {
                            IdTipoTransaccion = 1,
                            Descr = "Tranferencia"
                        },
                        new
                        {
                            IdTipoTransaccion = 2,
                            Descr = "CompraCripto"
                        },
                        new
                        {
                            IdTipoTransaccion = 3,
                            Descr = "Deposito"
                        });
                });

            modelBuilder.Entity("KriptonApi.Entities.Transaccion", b =>
                {
                    b.Property<int>("IdTransaccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdTransaccion");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTransaccion"));

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("Date")
                        .HasColumnName("FechaTransaccion");

                    b.Property<int>("IdCuentaDestino")
                        .HasColumnType("int")
                        .HasColumnName("IdCuentaDestino");

                    b.Property<int>("IdCuentaOrigen")
                        .HasColumnType("int")
                        .HasColumnName("IdCuentaOrigen");

                    b.Property<int>("IdTipoTransaccion")
                        .HasColumnType("int")
                        .HasColumnName("IdTipoTransaccion");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal")
                        .HasColumnName("Monto");

                    b.HasKey("IdTransaccion");

                    b.HasIndex("IdCuentaDestino");

                    b.HasIndex("IdCuentaOrigen");

                    b.HasIndex("IdTipoTransaccion");

                    b.ToTable("Transaccion");

                    b.HasData(
                        new
                        {
                            IdTransaccion = 1,
                            FechaTransaccion = new DateTime(2023, 10, 23, 1, 58, 30, 633, DateTimeKind.Local).AddTicks(6457),
                            IdCuentaDestino = 2,
                            IdCuentaOrigen = 1,
                            IdTipoTransaccion = 3,
                            Monto = 10000m
                        },
                        new
                        {
                            IdTransaccion = 2,
                            FechaTransaccion = new DateTime(2023, 10, 23, 1, 58, 30, 633, DateTimeKind.Local).AddTicks(6473),
                            IdCuentaDestino = 3,
                            IdCuentaOrigen = 2,
                            IdTipoTransaccion = 1,
                            Monto = 20000m
                        },
                        new
                        {
                            IdTransaccion = 3,
                            FechaTransaccion = new DateTime(2023, 10, 23, 1, 58, 30, 633, DateTimeKind.Local).AddTicks(6475),
                            IdCuentaDestino = 1,
                            IdCuentaOrigen = 3,
                            IdTipoTransaccion = 2,
                            Monto = 30000m
                        });
                });

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
                        .HasColumnName("Clave");

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

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            IdUsuario = 1,
                            Activo = true,
                            Apellido = "Cabrera",
                            Clave = "665117e5124b9ff0cc0d4e8d408fdc2c8b9d026d070ccbdd84a0ce8da6285061",
                            Dni = 31467581,
                            Email = "martin@gmail.com",
                            Nombre = "Martin"
                        },
                        new
                        {
                            IdUsuario = 2,
                            Activo = true,
                            Apellido = "Gonzalez",
                            Clave = "23afa0ecff4c3793135f373179c52bcf6ea1ecb9f6a726b59a279f8c07918a09",
                            Dni = 37053098,
                            Email = "florencia@gmail.com",
                            Nombre = "Florencia"
                        },
                        new
                        {
                            IdUsuario = 3,
                            Activo = true,
                            Apellido = "Cabrera",
                            Clave = "90b2b66e3f82349f03f4f8e13083137be8297e1a7bc5e59ffb172003ba717b41",
                            Dni = 58706438,
                            Email = "salome@gmail.com",
                            Nombre = "Salome"
                        });
                });

            modelBuilder.Entity("KriptonApi.Entities.Cotizacion", b =>
                {
                    b.HasOne("KriptonApi.Entities.Moneda", "Moneda")
                        .WithMany()
                        .HasForeignKey("IdMoneda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Moneda");
                });

            modelBuilder.Entity("KriptonApi.Entities.Cuenta", b =>
                {
                    b.HasOne("KriptonApi.Entities.TipoCuenta", "TipoCuenta")
                        .WithMany()
                        .HasForeignKey("IdTipoCuenta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KriptonApi.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoCuenta");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("KriptonApi.Entities.Transaccion", b =>
                {
                    b.HasOne("KriptonApi.Entities.Cuenta", "CuentaDestino")
                        .WithMany()
                        .HasForeignKey("IdCuentaDestino")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KriptonApi.Entities.Cuenta", "CuentaOrigen")
                        .WithMany()
                        .HasForeignKey("IdCuentaOrigen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KriptonApi.Entities.TipoTransaccion", "TipoTransaccion")
                        .WithMany()
                        .HasForeignKey("IdTipoTransaccion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CuentaDestino");

                    b.Navigation("CuentaOrigen");

                    b.Navigation("TipoTransaccion");
                });
#pragma warning restore 612, 618
        }
    }
}
