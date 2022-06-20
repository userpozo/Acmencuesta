using Microsoft.EntityFrameworkCore.Migrations;

namespace ACMEncuesta.ddd.Infraestructura.Migrations
{
    public partial class Mod_ChangeName_CantUsuarios_A_cantCodigos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CantidadUsuarios",
                schema: "dbo",
                table: "Encuesta",
                newName: "CantidadCodigos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CantidadCodigos",
                schema: "dbo",
                table: "Encuesta",
                newName: "CantidadUsuarios");
        }
    }
}
