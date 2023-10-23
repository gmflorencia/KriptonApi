using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KriptonApi.Migrations
{
    /// <inheritdoc />
    public partial class Kripton : Migration
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
                name: "Moneda",
                columns: table => new
                {
                    IdMoneda = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Simbolo = table.Column<string>(type: "VARCHAR(5)", nullable: false),
                    Activo = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moneda", x => x.IdMoneda);
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
                name: "Cotizacion",
                columns: table => new
                {
                    IdCotizacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMoneda = table.Column<int>(type: "int", nullable: false),
                    Compra = table.Column<decimal>(type: "money", nullable: false),
                    Venta = table.Column<decimal>(type: "money", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizacion", x => x.IdCotizacion);
                    table.ForeignKey(
                        name: "FK_Cotizacion_Moneda_IdMoneda",
                        column: x => x.IdMoneda,
                        principalTable: "Moneda",
                        principalColumn: "IdMoneda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cuenta",
                columns: table => new
                {
                    IdCuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoCuenta = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Cuenta_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transaccion",
                columns: table => new
                {
                    IdTransaccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCuentaOrigen = table.Column<int>(type: "int", nullable: false),
                    IdCuentaDestino = table.Column<int>(type: "int", nullable: false),
                    IdTipoTransaccion = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(38,17)", nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaccion", x => x.IdTransaccion);
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
                table: "Criptomoneda",
                columns: new[] { "IdCripto", "Nombre", "TasaConversion" },
                values: new object[,]
                {
                    { 1, "BTC", 0.25m },
                    { 2, "ETH", 0.35m },
                    { 3, "LTC", 0.3m }
                });

            migrationBuilder.InsertData(
                table: "Moneda",
                columns: new[] { "IdMoneda", "Activo", "Descripcion", "Simbolo" },
                values: new object[,]
                {
                    { 1, true, "Dólar", "u$s" },
                    { 2, true, "Euro", "€" }
                });

            migrationBuilder.InsertData(
                table: "TipoCuenta",
                columns: new[] { "IdTipoCuenta", "Descr" },
                values: new object[,]
                {
                    { 1, "pesos" },
                    { 2, "dolares" },
                    { 3, "Criptomoneda" }
                });

            migrationBuilder.InsertData(
                table: "TipoTransaccion",
                columns: new[] { "IdTipoTransaccion", "Descr" },
                values: new object[,]
                {
                    { 1, "Tranferencia" },
                    { 2, "CompraCripto" },
                    { 3, "Deposito" }
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

            migrationBuilder.InsertData(
                table: "Cotizacion",
                columns: new[] { "IdCotizacion", "Activo", "Compra", "IdMoneda", "Venta" },
                values: new object[,]
                {
                    { 1, true, 347.50m, 1, 365.5m },
                    { 2, true, 369.89m, 2, 370.47m }
                });

            migrationBuilder.InsertData(
                table: "Cuenta",
                columns: new[] { "IdCuenta", "Activo", "Alias", "Cbu", "IdTipoCuenta", "IdUsuario", "NumeroCuenta", "Saldo", "UUID" },
                values: new object[,]
                {
                    { 1, true, "Patria.gorro.Caucho", "01702046600000087865", 1, 1, 204878658, 50000m, "12345678123456781234567812345678" },
                    { 2, true, "Raiz.Arbol.Planta", "0290000100000000058382", 2, 2, 5838, 80000m, "123456781234-56781234567812345678" },
                    { 3, true, "Alfil.Oslo.Rima", "0110599520000001235579", 3, 3, 123557, 90000m, "123456781234-56781234567812785643" }
                });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "IdTransaccion", "FechaTransaccion", "IdCuentaDestino", "IdCuentaOrigen", "IdTipoTransaccion", "Monto" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 23, 1, 58, 30, 633, DateTimeKind.Local).AddTicks(6457), 2, 1, 3, 10000m },
                    { 2, new DateTime(2023, 10, 23, 1, 58, 30, 633, DateTimeKind.Local).AddTicks(6473), 3, 2, 1, 20000m },
                    { 3, new DateTime(2023, 10, 23, 1, 58, 30, 633, DateTimeKind.Local).AddTicks(6475), 1, 3, 2, 30000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cotizacion_IdMoneda",
                table: "Cotizacion",
                column: "IdMoneda");

            migrationBuilder.CreateIndex(
                name: "IX_Cuenta_IdTipoCuenta",
                table: "Cuenta",
                column: "IdTipoCuenta");

            migrationBuilder.CreateIndex(
                name: "IX_Cuenta_IdUsuario",
                table: "Cuenta",
                column: "IdUsuario");

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
                name: "Cotizacion");

            migrationBuilder.DropTable(
                name: "Criptomoneda");

            migrationBuilder.DropTable(
                name: "Transaccion");

            migrationBuilder.DropTable(
                name: "Moneda");

            migrationBuilder.DropTable(
                name: "Cuenta");

            migrationBuilder.DropTable(
                name: "TipoTransaccion");

            migrationBuilder.DropTable(
                name: "TipoCuenta");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
