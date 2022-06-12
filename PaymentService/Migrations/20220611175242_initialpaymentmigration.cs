using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentService.Migrations
{
    public partial class initialpaymentmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_On_Card = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expire_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CVC = table.Column<int>(type: "int", nullable: false),
                    Total_Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "CVC", "CardNo", "Expire_Date", "Name_On_Card", "Total_Amount" },
                values: new object[] { 1, 167, "1234 1234 1234 1234", "12-05-2024", "D.S.Perera", 4000 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "CVC", "CardNo", "Expire_Date", "Name_On_Card", "Total_Amount" },
                values: new object[] { 2, 167, "1234 1234 1234 1234", "12-05-2024", "D.S.Perera", 4000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");
        }
    }
}
