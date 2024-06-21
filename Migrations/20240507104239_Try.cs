using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarExpertise.Migrations
{
    /// <inheritdoc />
    public partial class Try : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TRYs",
                table: "TRYs");

            migrationBuilder.RenameTable(
                name: "TRYs",
                newName: "Trys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trys",
                table: "Trys",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Trys",
                table: "Trys");

            migrationBuilder.RenameTable(
                name: "Trys",
                newName: "TRYs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TRYs",
                table: "TRYs",
                column: "Id");
        }
    }
}
