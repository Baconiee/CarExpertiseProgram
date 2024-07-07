using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class CustomerControllerUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerModel",
                table: "CustomerModel");

            migrationBuilder.RenameTable(
                name: "CustomerModel",
                newName: "CustomerTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerTable",
                table: "CustomerTable",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerTable",
                table: "CustomerTable");

            migrationBuilder.RenameTable(
                name: "CustomerTable",
                newName: "CustomerModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerModel",
                table: "CustomerModel",
                column: "Id");
        }
    }
}
