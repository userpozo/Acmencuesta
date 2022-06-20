using Microsoft.EntityFrameworkCore.Migrations;

namespace ACMEncuesta.ddd.Infraestructura.Migrations
{
    public partial class Mod_LlaveComp_EncuestaCamposValor_HasOneWithMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EncuestaCampo_Encuesta_EncuestaId",
                schema: "dbo",
                table: "EncuestaCampo");

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
                name: "EncuestaId",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.DropColumn(
                name: "CodigoPK",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.AlterColumn<int>(
                name: "EncuestaCodigosEncuestaId",
                schema: "dbo",
                table: "EncuestaCamposValor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EncuestaCodigosCodigoPK",
                schema: "dbo",
                table: "EncuestaCamposValor",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EncuestaCamposValor",
                schema: "dbo",
                table: "EncuestaCamposValor",
                columns: new[] { "EncuestaCodigosEncuestaId", "EncuestaCodigosCodigoPK", "EncuestaCamposId" });

            migrationBuilder.AddForeignKey(
                name: "FK_EncuestaCampo_Encuesta_EncuestaId",
                schema: "dbo",
                table: "EncuestaCampo",
                column: "EncuestaId",
                principalSchema: "dbo",
                principalTable: "Encuesta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EncuestaCamposValor_EncuestaCodigos_EncuestaCodigosEncuestaId_EncuestaCodigosCodigoPK",
                schema: "dbo",
                table: "EncuestaCamposValor",
                columns: new[] { "EncuestaCodigosEncuestaId", "EncuestaCodigosCodigoPK" },
                principalSchema: "dbo",
                principalTable: "EncuestaCodigos",
                principalColumns: new[] { "EncuestaId", "CodigoPK" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EncuestaCampo_Encuesta_EncuestaId",
                schema: "dbo",
                table: "EncuestaCampo");

            migrationBuilder.DropForeignKey(
                name: "FK_EncuestaCamposValor_EncuestaCodigos_EncuestaCodigosEncuestaId_EncuestaCodigosCodigoPK",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EncuestaCamposValor",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.AlterColumn<string>(
                name: "EncuestaCodigosCodigoPK",
                schema: "dbo",
                table: "EncuestaCamposValor",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "EncuestaCodigosEncuestaId",
                schema: "dbo",
                table: "EncuestaCamposValor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EncuestaId",
                schema: "dbo",
                table: "EncuestaCamposValor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CodigoPK",
                schema: "dbo",
                table: "EncuestaCamposValor",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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
                name: "FK_EncuestaCampo_Encuesta_EncuestaId",
                schema: "dbo",
                table: "EncuestaCampo",
                column: "EncuestaId",
                principalSchema: "dbo",
                principalTable: "Encuesta",
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
    }
}
