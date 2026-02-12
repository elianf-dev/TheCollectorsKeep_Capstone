using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheCollectorsKeep_Capstone.Migrations
{
    /// <inheritdoc />
    public partial class Sprint1Fixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantityAvailable",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantityAvailable",
                table: "Products");
        }
    }
}
