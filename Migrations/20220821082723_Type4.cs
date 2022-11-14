using Microsoft.EntityFrameworkCore.Migrations;

namespace Tmp.Migrations
{
    public partial class Type4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionsType4",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionLink = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RightBtn = table.Column<int>(type: "int", nullable: false),
                    Task = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsType4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAnswersType4",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IterationId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    UserAnswer = table.Column<int>(type: "int", nullable: false),
                    Parallel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswersType4", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionsType4");

            migrationBuilder.DropTable(
                name: "UserAnswersType4");
        }
    }
}
