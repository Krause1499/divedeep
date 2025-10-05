using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiveDeep.Migrations
{
    /// <inheritdoc />
    public partial class SuitTypeAsString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SuitType",
                table: "DivingSuitSpecs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "SuitType",
                value: "Våddragt");

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "SuitType",
                value: "Tørdragt");

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "SuitType",
                value: "Tørdragt");

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "SuitType",
                value: "Tørdragt");

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 30,
                column: "SuitType",
                value: "Våddragt");

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 31,
                column: "SuitType",
                value: "Våddragt");

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "SuitType",
                value: "Våddragt");

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "SuitType",
                value: "Våddragt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SuitType",
                table: "DivingSuitSpecs",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "SuitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "SuitType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "SuitType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "SuitType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 30,
                column: "SuitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 31,
                column: "SuitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "SuitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DivingSuitSpecs",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "SuitType",
                value: 0);
        }
    }
}
