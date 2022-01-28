using Microsoft.EntityFrameworkCore.Migrations;

namespace Stock_Kings.Migrations
{
    public partial class UserStockUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserStocks",
                table: "UserStocks");

            migrationBuilder.AlterColumn<int>(
                name: "StockId",
                table: "UserStocks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserStocks",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserStocks",
                table: "UserStocks",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserStocks",
                table: "UserStocks");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserStocks");

            migrationBuilder.AlterColumn<int>(
                name: "StockId",
                table: "UserStocks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserStocks",
                table: "UserStocks",
                column: "StockId");
        }
    }
}
