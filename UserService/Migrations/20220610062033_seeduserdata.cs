using Microsoft.EntityFrameworkCore.Migrations;

namespace UserService.Migrations
{
    public partial class seeduserdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Contact", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "Matale", "0760563211", "palu@gmail.com", "Piumi", "Aluvihare" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Contact", "Email", "FirstName", "LastName" },
                values: new object[] { 2, "Malabe", "0762345661", "mayat@gmail.com", "Mayangi", "Dassanayake" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Contact", "Email", "FirstName", "LastName" },
                values: new object[] { 3, "Kandy", "072345678", "thawe@gmail.com", "Tharindu", "Weerasooriya" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
