using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeMangement.Migrations
{
    public partial class Seeding_Department_Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName", "Email", "PhoneNumber" },
                values: new object[] { 1, "IT", "it@codegym.vn", "0935216417" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName", "Email", "PhoneNumber" },
                values: new object[] { 2, "HR", "hr@codegym.vn", "0935216417" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "DepartmentId",
                value: 2);
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

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "AvatarPath", "Code", "DepartmentId", "Email", "Firstname", "Lastname" },
                values: new object[] { 3, 18, "avatar14.jpg", "CGH00003", 0, "huy.phan@codegym.vn", "Huy", "Phan" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "AvatarPath", "Code", "DepartmentId", "Email", "Firstname", "Lastname" },
                values: new object[] { 2, 18, "avatar10.jpg", "CGH00002", 0, "hung.tran@codegym.vn", "Hung", "Tran" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "AvatarPath", "Code", "DepartmentId", "Email", "Firstname", "Lastname" },
                values: new object[] { 1, 18, "avatar11.jpg", "CGH00001", 0, "khoa.nguyen@codegym.vn", "Khoa", "Nguyen" });
        }
    }
}
