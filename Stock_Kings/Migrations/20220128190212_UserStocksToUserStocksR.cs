using Microsoft.EntityFrameworkCore.Migrations;

namespace Stock_Kings.Migrations
{
    public partial class UserStocksToUserStocksR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserStocks",
                table: "UserStocks");

            migrationBuilder.RenameTable(
                name: "UserStocks",
                newName: "UserStocksR");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserStocksR",
                table: "UserStocksR",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserStocksR",
                table: "UserStocksR");

            migrationBuilder.RenameTable(
                name: "UserStocksR",
                newName: "UserStocks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserStocks",
                table: "UserStocks",
                column: "Id");
        }
    }
}
