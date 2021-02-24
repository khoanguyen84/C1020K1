using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeMangement.Migrations
{
    public partial class SeedingEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "AvatarPath", "Code", "Email", "Firstname", "Lastname" },
                values: new object[] { 1, 18, "avatar11.jpg", "CGH00001", "khoa.nguyen@codegym.vn", "Khoa", "Nguyen" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "AvatarPath", "Code", "Email", "Firstname", "Lastname" },
                values: new object[] { 2, 18, "avatar10.jpg", "CGH00002", "hung.tran@codegym.vn", "Hung", "Tran" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "AvatarPath", "Code", "Email", "Firstname", "Lastname" },
                values: new object[] { 3, 18, "avatar14.jpg", "CGH00003", "huy.phan@codegym.vn", "Huy", "Phan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);
        }
    }
}
