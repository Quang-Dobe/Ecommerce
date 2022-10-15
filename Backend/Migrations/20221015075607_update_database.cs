using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class update_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_customerAccounts_accountIDid",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_accountIDid",
                table: "customers");

            migrationBuilder.RenameColumn(
                name: "accountIDid",
                table: "customers",
                newName: "accountID");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "customerAccounts",
                newName: "accountID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "accountID",
                table: "customers",
                newName: "accountIDid");

            migrationBuilder.RenameColumn(
                name: "accountID",
                table: "customerAccounts",
                newName: "id");

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
    }
}
