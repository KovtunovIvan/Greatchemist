using Microsoft.EntityFrameworkCore.Migrations;

namespace Tmp.Migrations
{
    public partial class QuestionsType2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionsType2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionLink = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn4 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RightBtn = table.Column<int>(type: "int", nullable: false),
                    Task = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsType2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAnswersType2",
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
                    table.PrimaryKey("PK_UserAnswersType2", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionsType2");

            migrationBuilder.DropTable(
                name: "UserAnswersType2");
        }
    }
}
