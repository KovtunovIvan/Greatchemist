using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tmp.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Iterations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iterations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionsType1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionLink = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Btn2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RightBtn = table.Column<int>(type: "int", nullable: false),
                    Task = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsType1", x => x.Id);
                });

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
                name: "QuestionsType5",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionLink = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Task = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsType5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionsType6",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionLink = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Right1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Right2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Right3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Task = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsType6", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfficialNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Time = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IterationId = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Parallel = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAnswersType1",
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
                    table.PrimaryKey("PK_UserAnswersType1", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "UserAnswersType6",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IterationId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    UserAnswer1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserAnswer2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserAnswer3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Parallel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswersType6", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    MainHand = table.Column<bool>(type: "bit", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdditionalInf = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsTeacher = table.Column<bool>(type: "bit", nullable: false),
                    IsManager = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Iterations");

            migrationBuilder.DropTable(
                name: "QuestionsType1");

            migrationBuilder.DropTable(
                name: "QuestionsType2");

            migrationBuilder.DropTable(
                name: "QuestionsType3");

            migrationBuilder.DropTable(
                name: "QuestionsType4");

            migrationBuilder.DropTable(
                name: "QuestionsType5");

            migrationBuilder.DropTable(
                name: "QuestionsType6");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "TaskTimes");

            migrationBuilder.DropTable(
                name: "UserAnswersType1");

            migrationBuilder.DropTable(
                name: "UserAnswersType2");

            migrationBuilder.DropTable(
                name: "UserAnswersType3");

            migrationBuilder.DropTable(
                name: "UserAnswersType4");

            migrationBuilder.DropTable(
                name: "UserAnswersType6");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
