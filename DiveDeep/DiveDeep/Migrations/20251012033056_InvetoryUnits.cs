using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiveDeep.Migrations
{
    /// <inheritdoc />
    public partial class InvetoryUnits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InventoryUnitId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "InventoryUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    Gender = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryUnits_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_InventoryUnitId",
                table: "OrderItems",
                column: "InventoryUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryUnits_ProductId_Size_Gender",
                table: "InventoryUnits",
                columns: new[] { "ProductId", "Size", "Gender" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_InventoryUnits_InventoryUnitId",
                table: "OrderItems",
                column: "InventoryUnitId",
                principalTable: "InventoryUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_InventoryUnits_InventoryUnitId",
                table: "OrderItems");

            migrationBuilder.DropTable(
                name: "InventoryUnits");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_InventoryUnitId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "InventoryUnitId",
                table: "OrderItems");
        }
    }
}
