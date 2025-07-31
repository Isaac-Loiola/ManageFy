using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManageFyClass.Migrations
{
    /// <inheritdoc />
    public partial class TabelaContas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContaId",
                table: "Transacoes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Conta",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Saldo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conta", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_ContaId",
                table: "Transacoes",
                column: "ContaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transacoes_Conta_ContaId",
                table: "Transacoes",
                column: "ContaId",
                principalTable: "Conta",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacoes_Conta_ContaId",
                table: "Transacoes");

            migrationBuilder.DropTable(
                name: "Conta");

            migrationBuilder.DropIndex(
                name: "IX_Transacoes_ContaId",
                table: "Transacoes");

            migrationBuilder.DropColumn(
                name: "ContaId",
                table: "Transacoes");
        }
    }
}
