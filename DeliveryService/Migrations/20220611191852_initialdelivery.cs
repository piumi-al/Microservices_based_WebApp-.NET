using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryService.Migrations
{
    public partial class initialdelivery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    Delivery_ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delivery_Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delivery_location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delivery_charge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Deliveries",
                columns: new[] { "Id", "Delivery_Contact", "Delivery_ProductName", "Delivery_charge", "Delivery_location", "OrderID" },
                values: new object[] { 1, "0765645123", "Hanging Wall Art", 250, "Matale", 3 });

            migrationBuilder.InsertData(
                table: "Deliveries",
                columns: new[] { "Id", "Delivery_Contact", "Delivery_ProductName", "Delivery_charge", "Delivery_location", "OrderID" },
                values: new object[] { 2, "0765645444", "Painting Decoration Wall Art", 300, "Kandy", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deliveries");
        }
    }
}
