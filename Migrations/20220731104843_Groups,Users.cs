using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tmp.Migrations
{
    public partial class GroupsUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Patronymic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<bool>(type: "bit", nullable: false),
                    MainHand = table.Column<bool>(type: "bit", nullable: false),
                    WritingHand = table.Column<bool>(type: "bit", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdditionalInf = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                name: "Users");
        }
    }
}
