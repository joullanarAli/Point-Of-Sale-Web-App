using Microsoft.EntityFrameworkCore.Migrations;

namespace market.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customer_phoneNumber",
                table: "Customer");

            migrationBuilder.AlterColumn<string>(
                name: "phoneNumber",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "phoneNumber",
                table: "Customer",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Customer_phoneNumber",
                table: "Customer",
                column: "phoneNumber",
                unique: true);
        }
    }
}
