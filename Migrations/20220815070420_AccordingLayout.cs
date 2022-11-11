using Microsoft.EntityFrameworkCore.Migrations;

namespace Tmp.Migrations
{
    public partial class AccordingLayout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WritingHand",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Patronymic",
                table: "Users",
                newName: "Email");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "Patronymic");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Sex",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WritingHand",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
