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
                name: "Usuarios");
        }
    }
}
