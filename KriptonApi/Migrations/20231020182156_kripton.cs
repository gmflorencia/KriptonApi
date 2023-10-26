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
                name: "Criptomoneda",
                columns: table => new
                {
                    IdCripto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR (100)", nullable: false),
                    TasaConversion = table.Column<decimal>(type: "decimal(38,17)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criptomoneda", x => x.IdCripto);
                });

            migrationBuilder.CreateTable(
                name: "TipoConversion",
                columns: table => new
                {
                    IdTipoConversion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descr = table.Column<string>(type: "VARCHAR (100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoConversion", x => x.IdTipoConversion);
                });

            migrationBuilder.CreateTable(
                name: "TipoCuenta",
                columns: table => new
                {
                    IdTipoCuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descr = table.Column<string>(type: "VARCHAR (100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCuenta", x => x.IdTipoCuenta);
                });

            migrationBuilder.CreateTable(
                name: "TipoTransaccion",
                columns: table => new
                {
                    IdTipoTransaccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descr = table.Column<string>(type: "VARCHAR (100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTransaccion", x => x.IdTipoTransaccion);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR (100)", nullable: false),
                    Apellido = table.Column<string>(type: "VARCHAR (100)", nullable: false),
                    Dni = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR (100)", nullable: false),
                    Clave = table.Column<string>(type: "VARCHAR (100)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Cuenta",
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
                    table.PrimaryKey("PK_Cuenta", x => x.IdCuenta);
                    table.ForeignKey(
                        name: "FK_Cuenta_TipoCuenta_IdTipoCuenta",
                        column: x => x.IdTipoCuenta,
                        principalTable: "TipoCuenta",
                        principalColumn: "IdTipoCuenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conversion",
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
                    table.PrimaryKey("PK_Conversion", x => x.IdConversion);
                    table.ForeignKey(
                        name: "FK_Conversion_Cuenta_IdCuentaDestino",
                        column: x => x.IdCuentaDestino,
                        principalTable: "Cuenta",
                        principalColumn: "IdCuenta",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Conversion_Cuenta_IdCuentaOrigen",
                        column: x => x.IdCuentaOrigen,
                        principalTable: "Cuenta",
                        principalColumn: "IdCuenta",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Conversion_TipoConversion_IdTipoConversion",
                        column: x => x.IdTipoConversion,
                        principalTable: "TipoConversion",
                        principalColumn: "IdTipoConversion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transaccion",
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
                    table.PrimaryKey("PK_Transaccion", x => x.IdTransacciones);
                    table.ForeignKey(
                        name: "FK_Transaccion_Cuenta_IdCuentaDestino",
                        column: x => x.IdCuentaDestino,
                        principalTable: "Cuenta",
                        principalColumn: "IdCuenta",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Transaccion_Cuenta_IdCuentaOrigen",
                        column: x => x.IdCuentaOrigen,
                        principalTable: "Cuenta",
                        principalColumn: "IdCuenta",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Transaccion_TipoTransaccion_IdTipoTransaccion",
                        column: x => x.IdTipoTransaccion,
                        principalTable: "TipoTransaccion",
                        principalColumn: "IdTipoTransaccion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "IdUsuario", "Activo", "Apellido", "Clave", "Dni", "Email", "Nombre" },
                values: new object[,]
                {
                    { 1, true, "Cabrera", "665117e5124b9ff0cc0d4e8d408fdc2c8b9d026d070ccbdd84a0ce8da6285061", 31467581, "martin@gmail.com", "Martin" },
                    { 2, true, "Gonzalez", "23afa0ecff4c3793135f373179c52bcf6ea1ecb9f6a726b59a279f8c07918a09", 37053098, "florencia@gmail.com", "Florencia" },
                    { 3, true, "Cabrera", "90b2b66e3f82349f03f4f8e13083137be8297e1a7bc5e59ffb172003ba717b41", 58706438, "salome@gmail.com", "Salome" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conversion_IdCuentaDestino",
                table: "Conversion",
                column: "IdCuentaDestino");

            migrationBuilder.CreateIndex(
                name: "IX_Conversion_IdCuentaOrigen",
                table: "Conversion",
                column: "IdCuentaOrigen");

            migrationBuilder.CreateIndex(
                name: "IX_Conversion_IdTipoConversion",
                table: "Conversion",
                column: "IdTipoConversion");

            migrationBuilder.CreateIndex(
                name: "IX_Cuenta_IdTipoCuenta",
                table: "Cuenta",
                column: "IdTipoCuenta");

            migrationBuilder.CreateIndex(
                name: "IX_Transaccion_IdCuentaDestino",
                table: "Transaccion",
                column: "IdCuentaDestino");

            migrationBuilder.CreateIndex(
                name: "IX_Transaccion_IdCuentaOrigen",
                table: "Transaccion",
                column: "IdCuentaOrigen");

            migrationBuilder.CreateIndex(
                name: "IX_Transaccion_IdTipoTransaccion",
                table: "Transaccion",
                column: "IdTipoTransaccion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conversion");

            migrationBuilder.DropTable(
                name: "Criptomoneda");

            migrationBuilder.DropTable(
                name: "Transaccion");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "TipoConversion");

            migrationBuilder.DropTable(
                name: "Cuenta");

            migrationBuilder.DropTable(
                name: "TipoTransaccion");

            migrationBuilder.DropTable(
                name: "TipoCuenta");
        }
    }
}
