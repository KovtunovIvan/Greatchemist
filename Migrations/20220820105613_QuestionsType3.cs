using Microsoft.EntityFrameworkCore.Migrations;

namespace Tmp.Migrations
{
    public partial class QuestionsType3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionsType3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionLink = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn4 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn5 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn6 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn7 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn8 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn9 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn10 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn11 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn12 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn13 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn14 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RightBtn = table.Column<int>(type: "int", nullable: false),
                    Task = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsType3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAnswersType3",
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
                    table.PrimaryKey("PK_UserAnswersType3", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionsType3");

            migrationBuilder.DropTable(
                name: "UserAnswersType3");
        }
    }
}
