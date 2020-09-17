using Microsoft.EntityFrameworkCore.Migrations;

namespace Padawan.ControleFinanceiro.Context.Migrations
{
    public partial class segundoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Descricao",
                table: "Carteiras",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Carteiras");
        }
    }
}
