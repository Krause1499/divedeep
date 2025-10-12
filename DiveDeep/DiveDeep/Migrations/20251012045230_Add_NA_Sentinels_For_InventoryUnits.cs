using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiveDeep.Migrations
{
    /// <inheritdoc />
    public partial class Add_NA_Sentinels_For_InventoryUnits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1) Opdater eksisterende NULL-data til NA (-1), før vi gør kolonnerne NOT NULL
            migrationBuilder.Sql(@"
        UPDATE [dbo].[InventoryUnits] SET [Size] = -1   WHERE [Size]   IS NULL;
        UPDATE [dbo].[InventoryUnits] SET [Gender] = -1 WHERE [Gender] IS NULL;
    ");

            // 2) Gør kolonnerne ikke-nullable og sæt DB-default = -1 (NA)
            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "InventoryUnits",
                type: "int",
                nullable: false,
                defaultValue: -1,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "InventoryUnits",
                type: "int",
                nullable: false,
                defaultValue: -1,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            // (Valgfrit) Hvis EF genererede et drop/create af jeres unikke indeks, behold det.
            // Ellers er der intet at gøre her.
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Fjern NOT NULL og default igen (tilbage til nullable ints)
            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "InventoryUnits",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "InventoryUnits",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            // (Valgfrit) Genskab evt. indeks hvis EF droppede dem i Up.
        }

    }
}
