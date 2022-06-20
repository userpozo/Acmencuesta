using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ACMEncuesta.ddd.Infraestructura.Migrations
{
    public partial class Mod_CodigoEncuestaSeraTipoGUID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EncuestaCamposValor_EncuestaCodigos_EncuestaCodigosEncuestaId_EncuestaCodigosCodigoPK",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EncuestaCodigos",
                schema: "dbo",
                table: "EncuestaCodigos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EncuestaCamposValor",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.AlterColumn<string>(
                name: "CodigoPK",
                schema: "dbo",
                table: "EncuestaCodigos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "CodigoPK1",
                schema: "dbo",
                table: "EncuestaCodigos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "EncuestaCodigosCodigoPK",
                schema: "dbo",
                table: "EncuestaCamposValor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "EncuestaCodigosCodigoPK1",
                schema: "dbo",
                table: "EncuestaCamposValor",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_EncuestaCodigos",
                schema: "dbo",
                table: "EncuestaCodigos",
                columns: new[] { "EncuestaId", "CodigoPK1" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_EncuestaCamposValor",
                schema: "dbo",
                table: "EncuestaCamposValor",
                columns: new[] { "EncuestaCodigosEncuestaId", "EncuestaCodigosCodigoPK1", "EncuestaCamposId" });

            migrationBuilder.AddForeignKey(
                name: "FK_EncuestaCamposValor_EncuestaCodigos_EncuestaCodigosEncuestaId_EncuestaCodigosCodigoPK1",
                schema: "dbo",
                table: "EncuestaCamposValor",
                columns: new[] { "EncuestaCodigosEncuestaId", "EncuestaCodigosCodigoPK1" },
                principalSchema: "dbo",
                principalTable: "EncuestaCodigos",
                principalColumns: new[] { "EncuestaId", "CodigoPK1" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EncuestaCamposValor_EncuestaCodigos_EncuestaCodigosEncuestaId_EncuestaCodigosCodigoPK1",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EncuestaCodigos",
                schema: "dbo",
                table: "EncuestaCodigos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EncuestaCamposValor",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.DropColumn(
                name: "CodigoPK1",
                schema: "dbo",
                table: "EncuestaCodigos");

            migrationBuilder.DropColumn(
                name: "EncuestaCodigosCodigoPK1",
                schema: "dbo",
                table: "EncuestaCamposValor");

            migrationBuilder.AlterColumn<string>(
                name: "CodigoPK",
                schema: "dbo",
                table: "EncuestaCodigos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EncuestaCodigosCodigoPK",
                schema: "dbo",
                table: "EncuestaCamposValor",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EncuestaCodigos",
                schema: "dbo",
                table: "EncuestaCodigos",
                columns: new[] { "EncuestaId", "CodigoPK" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_EncuestaCamposValor",
                schema: "dbo",
                table: "EncuestaCamposValor",
                columns: new[] { "EncuestaCodigosEncuestaId", "EncuestaCodigosCodigoPK", "EncuestaCamposId" });

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
    }
}
