using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscountService.Migrations
{
    public partial class initialdiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productID = table.Column<int>(type: "int", nullable: false),
                    Discount_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount_amount = table.Column<int>(type: "int", nullable: false),
                    start_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    end_date = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Discount_Type", "Discount_amount", "end_date", "productID", "start_date" },
                values: new object[] { 1, "fixed", 100, "05-07-2022", 3, "05-06-2022" });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Discount_Type", "Discount_amount", "end_date", "productID", "start_date" },
                values: new object[] { 2, "%", 10, "15-07-2022", 4, "15-06-2022" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discounts");
        }
    }
}
