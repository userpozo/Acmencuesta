using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACMEncuesta.ddd.Infraestructura.Migrations
{
    public partial class MigracionInicial_CreacionBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Encuesta",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encuesta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EncuestaCampo",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requerido = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    TipoCampo = table.Column<int>(type: "int", nullable: false),
                    EncuestaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncuestaCampo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EncuestaCampo_Encuesta_EncuestaId",
                        column: x => x.EncuestaId,
                        principalSchema: "dbo",
                        principalTable: "Encuesta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EncuestaCampo_EncuestaId",
                schema: "dbo",
                table: "EncuestaCampo",
                column: "EncuestaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EncuestaCampo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Encuesta",
                schema: "dbo");
        }
    }
}
