using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class updateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "accountIDid",
                table: "customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_customers_accountIDid",
                table: "customers",
                column: "accountIDid");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_customerAccounts_accountIDid",
                table: "customers",
                column: "accountIDid",
                principalTable: "customerAccounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_customerAccounts_accountIDid",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_accountIDid",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "accountIDid",
                table: "customers");
        }
    }
}
