using Microsoft.EntityFrameworkCore.Migrations;

namespace ACMEncuesta.ddd.Infraestructura.Migrations
{
    public partial class Mod_AgregarEncuestaCamposId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EncuestaCamposValor_Encuesta_EncuestaId",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.DropForeignKey(
                name: "FK_EncuestaCamposValor_EncuestaCampo_EncuestaCamposId",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EncuestaCamposValor",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.DropColumn(
                name: "CampoId",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.AlterColumn<int>(
                name: "EncuestaCamposId",
                schema: "dbo",
                table: "EncuestaCamposValor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EncuestaCodigosCodigoPK",
                schema: "dbo",
                table: "EncuestaCamposValor",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EncuestaCodigosEncuestaId",
                schema: "dbo",
                table: "EncuestaCamposValor",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EncuestaCamposValor",
                schema: "dbo",
                table: "EncuestaCamposValor",
                columns: new[] { "EncuestaId", "EncuestaCamposId", "CodigoPK" });

            migrationBuilder.CreateIndex(
                name: "IX_EncuestaCamposValor_EncuestaCodigosEncuestaId_EncuestaCodigosCodigoPK",
                schema: "dbo",
                table: "EncuestaCamposValor",
                columns: new[] { "EncuestaCodigosEncuestaId", "EncuestaCodigosCodigoPK" });

            migrationBuilder.AddForeignKey(
                name: "FK_EncuestaCamposValor_EncuestaCampo_EncuestaCamposId",
                schema: "dbo",
                table: "EncuestaCamposValor",
                column: "EncuestaCamposId",
                principalSchema: "dbo",
                principalTable: "EncuestaCampo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EncuestaCamposValor_EncuestaCodigos_EncuestaCodigosEncuestaId_EncuestaCodigosCodigoPK",
                schema: "dbo",
                table: "EncuestaCamposValor",
                columns: new[] { "EncuestaCodigosEncuestaId", "EncuestaCodigosCodigoPK" },
                principalSchema: "dbo",
                principalTable: "EncuestaCodigos",
                principalColumns: new[] { "EncuestaId", "CodigoPK" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EncuestaCamposValor_EncuestaCampo_EncuestaCamposId",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.DropForeignKey(
                name: "FK_EncuestaCamposValor_EncuestaCodigos_EncuestaCodigosEncuestaId_EncuestaCodigosCodigoPK",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EncuestaCamposValor",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.DropIndex(
                name: "IX_EncuestaCamposValor_EncuestaCodigosEncuestaId_EncuestaCodigosCodigoPK",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.DropColumn(
                name: "EncuestaCodigosCodigoPK",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.DropColumn(
                name: "EncuestaCodigosEncuestaId",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.AlterColumn<int>(
                name: "EncuestaCamposId",
                schema: "dbo",
                table: "EncuestaCamposValor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CampoId",
                schema: "dbo",
                table: "EncuestaCamposValor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EncuestaCamposValor",
                schema: "dbo",
                table: "EncuestaCamposValor",
                columns: new[] { "EncuestaId", "CampoId", "CodigoPK" });

            migrationBuilder.AddForeignKey(
                name: "FK_EncuestaCamposValor_Encuesta_EncuestaId",
                schema: "dbo",
                table: "EncuestaCamposValor",
                column: "EncuestaId",
                principalSchema: "dbo",
                principalTable: "Encuesta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EncuestaCamposValor_EncuestaCampo_EncuestaCamposId",
                schema: "dbo",
                table: "EncuestaCamposValor",
                column: "EncuestaCamposId",
                principalSchema: "dbo",
                principalTable: "EncuestaCampo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
