using Microsoft.EntityFrameworkCore.Migrations;

namespace CartService.Migrations
{
    public partial class seedcartdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "Addede_Date", "ProductId", "Quantity", "sub_total" },
                values: new object[] { 1, "12-05-2022", 2, 4, 1200 });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "Addede_Date", "ProductId", "Quantity", "sub_total" },
                values: new object[] { 2, "11-06-2022", 3, 5, 1400 });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "Addede_Date", "ProductId", "Quantity", "sub_total" },
                values: new object[] { 3, "12-06-2022", 4, 2, 1300 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
