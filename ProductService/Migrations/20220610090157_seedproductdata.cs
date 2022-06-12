using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductService.Migrations
{
    public partial class seedproductdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Code", "Product_Name", "Quantity_In_Stock", "Unit_Price" },
                values: new object[] { 1, "P001", "Hanging Wall Art", 50, 1500 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Code", "Product_Name", "Quantity_In_Stock", "Unit_Price" },
                values: new object[] { 2, "P002", "Painting Decoration Wall Art", 25, 2000 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Code", "Product_Name", "Quantity_In_Stock", "Unit_Price" },
                values: new object[] { 3, "P003", "Indoor Wall Plants", 30, 890 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
