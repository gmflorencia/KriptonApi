using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KriptonApi.Migrations
{
    /// <inheritdoc />
    public partial class kripton : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conversions",
                columns: table => new
                {
                    IdConversion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCuentaOrigen = table.Column<int>(type: "int", nullable: false),
                    IdCuentaDestino = table.Column<int>(type: "int", nullable: false),
                    MontoConvertido = table.Column<decimal>(type: "decimal(38,17)", nullable: false),
                    FechaConversion = table.Column<DateTime>(type: "Date", nullable: false),
                    IdTipoConversion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversions", x => x.IdConversion);
                });

            migrationBuilder.CreateTable(
                name: "Criptomonedas",
                columns: table => new
                {
                    IdCripto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR (100)", nullable: false),
                    TasaConversion = table.Column<decimal>(type: "decimal(38,17)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criptomonedas", x => x.IdCripto);
                });

            migrationBuilder.CreateTable(
                name: "Cuentas",
                columns: table => new
                {
                    IdCuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoCuenta = table.Column<int>(type: "int", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(38,17)", nullable: false),
                    Cbu = table.Column<string>(type: "VARCHAR (100)", nullable: false),
                    NumeroCuenta = table.Column<int>(type: "int", nullable: false),
                    Alias = table.Column<string>(type: "VARCHAR (100)", nullable: false),
                    UUID = table.Column<string>(type: "VARCHAR (100)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.IdCuenta);
                });

            migrationBuilder.CreateTable(
                name: "TipoConversions",
                columns: table => new
                {
                    IdTipoConversion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descr = table.Column<string>(type: "VARCHAR (100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoConversions", x => x.IdTipoConversion);
                });

            migrationBuilder.CreateTable(
                name: "TipoCuentas",
                columns: table => new
                {
                    IdTipoCuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descr = table.Column<string>(type: "VARCHAR (100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCuentas", x => x.IdTipoCuenta);
                });

            migrationBuilder.CreateTable(
                name: "TipoTransaccions",
                columns: table => new
                {
                    IdTipoTransaccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descr = table.Column<string>(type: "VARCHAR (100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTransaccions", x => x.IdTipoTransaccion);
                });

            migrationBuilder.CreateTable(
                name: "Transacciones",
                columns: table => new
                {
                    IdTransacciones = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCuentaOrigen = table.Column<int>(type: "int", nullable: false),
                    IdCuentaDestino = table.Column<int>(type: "int", nullable: false),
                    IdTipoTransaccion = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(38,17)", nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacciones", x => x.IdTransacciones);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR (100)", nullable: false),
                    Apellido = table.Column<string>(type: "VARCHAR (100)", nullable: false),
                    Dni = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR (100)", nullable: false),
                    CLave = table.Column<string>(type: "VARCHAR (100)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "Activo", "Apellido", "CLave", "Dni", "Email", "Nombre" },
                values: new object[,]
                {
                    { 1, true, "Cabrera", "665117e5124b9ff0cc0d4e8d408fdc2c8b9d026d070ccbdd84a0ce8da6285061", 31467581, "martin@gmail.com", "Martin" },
                    { 2, true, "Gonzalez", "23afa0ecff4c3793135f373179c52bcf6ea1ecb9f6a726b59a279f8c07918a09", 37053098, "florencia@gmail.com", "Florencia" },
                    { 3, true, "Cabrera", "90b2b66e3f82349f03f4f8e13083137be8297e1a7bc5e59ffb172003ba717b41", 58706438, "salome@gmail.com", "Salome" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conversions");

            migrationBuilder.DropTable(
                name: "Criptomonedas");

            migrationBuilder.DropTable(
                name: "Cuentas");

            migrationBuilder.DropTable(
                name: "TipoConversions");

            migrationBuilder.DropTable(
                name: "TipoCuentas");

            migrationBuilder.DropTable(
                name: "TipoTransaccions");

            migrationBuilder.DropTable(
                name: "Transacciones");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
