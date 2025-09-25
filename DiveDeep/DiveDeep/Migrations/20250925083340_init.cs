using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiveDeep.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductType = table.Column<int>(type: "int", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DailyPrice = table.Column<int>(type: "int", nullable: false),
                    BCD_Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BCD_Size = table.Column<int>(type: "int", nullable: false),
                    DivingSuit_Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DivingSuit_Size = table.Column<int>(type: "int", nullable: false),
                    DivingSuit_SuitType = table.Column<int>(type: "int", nullable: true),
                    DivingSuit_Gender = table.Column<int>(type: "int", nullable: false),
                    DivingSuit_ThicknessInMm = table.Column<double>(type: "float", nullable: true),
                    Fins_Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fins_Size = table.Column<int>(type: "int", nullable: false),
                    OxygenTank_VolumeInL = table.Column<int>(type: "int", nullable: true),
                    Regulator_StageOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Regulator_StageTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Regulator_Octopus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaskSnorkel_Model = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
