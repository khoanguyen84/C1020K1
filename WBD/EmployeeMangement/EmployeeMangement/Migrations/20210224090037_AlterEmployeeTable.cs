using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeMangement.Migrations
{
    public partial class AlterEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AvatarPath",
                table: "Employees",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Employees",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employees",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AvatarPath",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employees");
        }
    }
}
