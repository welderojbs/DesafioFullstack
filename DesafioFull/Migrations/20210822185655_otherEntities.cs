using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioFull.Migrations
{
    public partial class otherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Parcelasid",
                table: "Titulos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Parcelas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PcNumTitulo = table.Column<int>(nullable: false),
                    NumeroParcela = table.Column<int>(nullable: false),
                    VencimentoParcela = table.Column<DateTime>(nullable: false),
                    ValorParcela = table.Column<decimal>(nullable: false),
                    ValorTotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcelas", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Titulos_Parcelasid",
                table: "Titulos",
                column: "Parcelasid");

            migrationBuilder.AddForeignKey(
                name: "FK_Titulos_Parcelas_Parcelasid",
                table: "Titulos",
                column: "Parcelasid",
                principalTable: "Parcelas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titulos_Parcelas_Parcelasid",
                table: "Titulos");

            migrationBuilder.DropTable(
                name: "Parcelas");

            migrationBuilder.DropIndex(
                name: "IX_Titulos_Parcelasid",
                table: "Titulos");

            migrationBuilder.DropColumn(
                name: "Parcelasid",
                table: "Titulos");
        }
    }
}
