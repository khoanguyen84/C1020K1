using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeMangement.Migrations
{
    public partial class Create_Product_Table_and_Seeding_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, "Số 1 cao 40cm rộng 20cm dày 20cm màu xanh lá cây đậm", 1000000m, "Đá phong thuỷ tự nhiên" },
                    { 2, "Trang trí trong nhà Chất liệu : • Đá muối", 1500000m, "Đèn đá muối hình tròn" },
                    { 3, "Tranh sơn mài loại nhỏ 15x 15 giá 50.000", 50000m, "Tranh sơn mài" },
                    { 4, "Nguyên liệu thể hiện :    Sơn dầu", 450000m, "Tranh sơn dầu - Ngựa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
