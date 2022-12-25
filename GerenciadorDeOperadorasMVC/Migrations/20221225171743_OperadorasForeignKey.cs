using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciadorDeOperadorasMVC.Migrations
{
    public partial class OperadorasForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beneficiario_Operadora_OperadoraId",
                table: "Beneficiario");

            migrationBuilder.AlterColumn<int>(
                name: "OperadoraId",
                table: "Beneficiario",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Beneficiario_Operadora_OperadoraId",
                table: "Beneficiario",
                column: "OperadoraId",
                principalTable: "Operadora",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beneficiario_Operadora_OperadoraId",
                table: "Beneficiario");

            migrationBuilder.AlterColumn<int>(
                name: "OperadoraId",
                table: "Beneficiario",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Beneficiario_Operadora_OperadoraId",
                table: "Beneficiario",
                column: "OperadoraId",
                principalTable: "Operadora",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
