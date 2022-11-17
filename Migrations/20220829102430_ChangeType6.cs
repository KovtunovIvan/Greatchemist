using Microsoft.EntityFrameworkCore.Migrations;

namespace Tmp.Migrations
{
    public partial class ChangeType6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "UserAnswer3",
                table: "UserAnswersType6",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Description3",
                table: "QuestionsType6",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Right3",
                table: "QuestionsType6",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "SubTask",
                table: "QuestionsType6",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserAnswer3",
                table: "UserAnswersType6");

            migrationBuilder.DropColumn(
                name: "Description3",
                table: "QuestionsType6");

            migrationBuilder.DropColumn(
                name: "Right3",
                table: "QuestionsType6");

            migrationBuilder.DropColumn(
                name: "SubTask",
                table: "QuestionsType6");
        }
    }
}
