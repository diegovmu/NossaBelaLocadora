using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.Migrations
{
    public partial class PrimeiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabelaDeContas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Saldo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaDeContas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabelaDeFilmes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Valor = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Duracao = table.Column<int>(nullable: false),
                    QuantidadeDeOscars = table.Column<int>(nullable: false),
                    IdFilme = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaDeFilmes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabelaDeSeries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Valor = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Temporadas = table.Column<int>(nullable: false),
                    Emmies = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaDeSeries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabelaDeUsuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Idade = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    ContaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaDeUsuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabelaDeUsuarios_TabelaDeContas_ContaId",
                        column: x => x.ContaId,
                        principalTable: "TabelaDeContas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TabelaDeUsuarios_ContaId",
                table: "TabelaDeUsuarios",
                column: "ContaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabelaDeFilmes");

            migrationBuilder.DropTable(
                name: "TabelaDeSeries");

            migrationBuilder.DropTable(
                name: "TabelaDeUsuarios");

            migrationBuilder.DropTable(
                name: "TabelaDeContas");
        }
    }
}
