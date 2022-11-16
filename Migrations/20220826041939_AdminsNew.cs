using Microsoft.EntityFrameworkCore.Migrations;

namespace Tmp.Migrations
{
    public partial class AdminsNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsSuperAdmin",
                table: "Users",
                newName: "IsTeacher");

            migrationBuilder.RenameColumn(
                name: "IsAdmin",
                table: "Users",
                newName: "IsManager");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsTeacher",
                table: "Users",
                newName: "IsSuperAdmin");

            migrationBuilder.RenameColumn(
                name: "IsManager",
                table: "Users",
                newName: "IsAdmin");
        }
    }
}
