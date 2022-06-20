using Microsoft.EntityFrameworkCore.Migrations;

namespace ACMEncuesta.ddd.Infraestructura.Migrations
{
    public partial class Creacion2Tablas_EncValor_EncCod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EncuestaCamposValor",
                schema: "dbo",
                columns: table => new
                {
                    EncuestaId = table.Column<int>(type: "int", nullable: false),
                    CodigoPK = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CampoId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EncuestaCamposId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncuestaCamposValor", x => new { x.EncuestaId, x.CampoId, x.CodigoPK });
                    table.ForeignKey(
                        name: "FK_EncuestaCamposValor_Encuesta_EncuestaId",
                        column: x => x.EncuestaId,
                        principalSchema: "dbo",
                        principalTable: "Encuesta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EncuestaCamposValor_EncuestaCampo_EncuestaCamposId",
                        column: x => x.EncuestaCamposId,
                        principalSchema: "dbo",
                        principalTable: "EncuestaCampo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EncuestaCodigos",
                schema: "dbo",
                columns: table => new
                {
                    EncuestaId = table.Column<int>(type: "int", nullable: false),
                    CodigoPK = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncuestaCodigos", x => new { x.EncuestaId, x.CodigoPK });
                    table.ForeignKey(
                        name: "FK_EncuestaCodigos_Encuesta_EncuestaId",
                        column: x => x.EncuestaId,
                        principalSchema: "dbo",
                        principalTable: "Encuesta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EncuestaCamposValor_EncuestaCamposId",
                schema: "dbo",
                table: "EncuestaCamposValor",
                column: "EncuestaCamposId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EncuestaCamposValor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "EncuestaCodigos",
                schema: "dbo");
        }
    }
}
