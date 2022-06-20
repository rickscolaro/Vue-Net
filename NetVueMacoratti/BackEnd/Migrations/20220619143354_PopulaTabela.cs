using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Migrations
{
    public partial class PopulaTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "AlunoId", "Email", "Idade", "Nome" },
                values: new object[] { 1, "mariaPeenha@yahoo.com", 23, "Maria da Penha" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "AlunoId", "Email", "Idade", "Nome" },
                values: new object[] { 2, "manuelBoeno@yahoo.com", 22, "Manuel Boeno" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "AlunoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "AlunoId",
                keyValue: 2);
        }
    }
}
