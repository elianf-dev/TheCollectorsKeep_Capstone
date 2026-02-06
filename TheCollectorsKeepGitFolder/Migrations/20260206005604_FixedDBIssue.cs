using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheCollectorsKeep_Capstone.Migrations
{
    /// <inheritdoc />
    public partial class FixedDBIssue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_ProductID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_ProductID1",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItems_Products_ProductID1",
                table: "WishlistItems");

            migrationBuilder.DropIndex(
                name: "IX_WishlistItems_ProductID1",
                table: "WishlistItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_ProductID1",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ProductID1",
                table: "WishlistItems");

            migrationBuilder.DropColumn(
                name: "ProductID1",
                table: "OrderItems");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_ProductID",
                table: "OrderItems",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_ProductID",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "ProductID1",
                table: "WishlistItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductID1",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_ProductID1",
                table: "WishlistItems",
                column: "ProductID1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductID1",
                table: "OrderItems",
                column: "ProductID1");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_ProductID",
                table: "OrderItems",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_ProductID1",
                table: "OrderItems",
                column: "ProductID1",
                principalTable: "Products",
                principalColumn: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItems_Products_ProductID1",
                table: "WishlistItems",
                column: "ProductID1",
                principalTable: "Products",
                principalColumn: "ProductID");
        }
    }
}
