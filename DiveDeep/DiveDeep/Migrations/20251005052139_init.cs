using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiveDeep.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DailyPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BCDSpecs",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sizes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BCDSpecs", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_BCDSpecs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DivingSuitSpecs",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sizes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuitType = table.Column<int>(type: "int", nullable: true),
                    Genders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThicknessInMm = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivingSuitSpecs", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_DivingSuitSpecs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinsSpecs",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sizes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinsSpecs", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_FinsSpecs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaskSnorkelSpecs",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaskSnorkelSpecs", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_MaskSnorkelSpecs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OxygenTankSpecs",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    VolumeInL = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OxygenTankSpecs", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_OxygenTankSpecs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegulatorSpecs",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    StageOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Octopus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegulatorSpecs", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_RegulatorSpecs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "DailyPrice", "Description", "FilePath", "ProductType" },
                values: new object[,]
                {
                    { 1, "Scubapro", 125, null, "https://scubadirect.dk/cdn/shop/files/SP_21770X00_Navigator_Lite_BLK_Left34-View.webp?v=1747051445", "BCD" },
                    { 2, "Scubapro", 140, null, "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/scubapro-bcd-glide-1.w1200.jpg", "BCD" },
                    { 3, "Scubapro", 200, null, "https://dykker-butikken.dk/cdn/shop/files/scubapro-hydros-pro-m_nd-3.jpg?v=1730217105", "BCD" },
                    { 4, "Seac", 145, null, "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/seac-bcd-modular-one-size-1.w610.h610.fill.jpg", "BCD" },
                    { 5, "Fourth Element", 120, null, "https://jettydive.com.au/wp-content/uploads/2022/02/PROTEUS-II-e1492122864772.jpg", "DivingSuit" },
                    { 6, "Scubapro", 300, null, "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/EXODRY_4_MN_60.853.000.w1200.jpg", "DivingSuit" },
                    { 7, "Waterproof", 320, null, "https://www.sublub.nl/resize/waterproofd7-evo_10013765071715.png/0/1100/True/waterproof-d7-evo-drysuit-men-size-l-plus.png", "DivingSuit" },
                    { 8, "Santi", 350, null, "https://shop11921.sfstatic.io/upload_dir/shop/elite-plus_01-kolor.jpg", "DivingSuit" },
                    { 9, "Scubapro", 125, null, "https://johnsonoutdoors.widen.net/content/rpvygpvdbi/jpeg/SP_12971965_MKEVODIN_S600_R105.jpg", "Regulator" },
                    { 10, "Scubapro", 100, null, "https://shop11921.sfstatic.io/upload_dir/shop/MK17Evo_C370_R095_DIN.webp", "Regulator" },
                    { 11, "Scubapro", 150, null, "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/mk25-bt-a700carbon-s270.w1200.jpg", "Regulator" },
                    { 12, "Scubapro", 150, null, "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/n_p1eee6v6q25m2120k16duojq6774-2.w1200.jpg", "OxygenTank" },
                    { 13, "Scubapro", 160, null, "https://scubadirect.dk/cdn/shop/products/Flaske1udtag-p.jpg?v=1617200377", "OxygenTank" },
                    { 14, "Scubapro", 170, null, "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/18-012-121.w1200.jpg", "OxygenTank" },
                    { 15, "Scubapro", 180, null, "https://www.edyk.dk/cdn/shop/products/Dykkerflaske15Liter.jpg?v=1666609081", "OxygenTank" },
                    { 16, "Scubapro", 50, null, "https://aquashoppen.dk/files/products/S-25365400.jpg", "Fins" },
                    { 17, "Scubapro", 50, null, "https://www.kingfish.dk/media/catalog/product/cache/c1c0e1fb1ecf4dd56138fa5b5577c9ad/s/c/scubapro-go-travel-finner-dykning-2-2.jpg", "Fins" },
                    { 18, "Scubapro", 60, null, "https://shop11921.sfstatic.io/upload_dir/shop/SP_25505X00_Seawing_Supernova_2.jpg", "Fins" },
                    { 19, "Seac", 50, null, "https://shop11921.sfstatic.io/upload_dir/shop/seac-finne-propulsion-s-hvid-1.jpg", "Fins" },
                    { 20, "Seac", 50, null, "https://www.kids-world.dk/images/YP436.jpg", "Fins" },
                    { 21, "Fourth Element", 75, null, "https://www.onlinedivegear.com.au/cdn/shop/products/Fourth-Element-Tech-Fins-Grey_500x.jpg?v=1655305970", "Fins" },
                    { 22, "Fourth Element", 80, null, "https://shop11921.sfstatic.io/upload_dir/shop/fnrec02.jpg", "Fins" },
                    { 23, "Scubapro", 50, null, "https://m.media-amazon.com/images/I/519C84G2uYL._UF1000,1000_QL80_.jpg", "Snorkel" },
                    { 24, "Scubapro", 60, null, "https://scubadirect.dk/cdn/shop/products/24.250.200-p.jpg?v=1616663057&width=360", "Snorkel" },
                    { 25, "Scubapro", 50, null, "https://shop11921.sfstatic.io/upload_dir/shop/scubapro-spectra-mini-sort-soelv.jpg", "Snorkel" },
                    { 26, "Scubapro", 75, null, "https://www.edyk.dk/cdn/shop/products/Scubapro-Crystal-VU-dykkermaske-sort-s_C3_B8lv-p.jpg?v=1684326130&width=1080", "Snorkel" },
                    { 27, "Scubapro", 75, null, "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/dykkermaske-fourth-element-scout-sort-enhance-1-1.w1200.jpg", "Snorkel" },
                    { 28, "Scubapro", 75, null, "https://shop11921.sfstatic.io/upload_dir/shop/_thumbs/dykkermaske-fourth-element-scout-sort-kontrast-1-1.w610.h610.fill.jpg", "Snorkel" },
                    { 29, "Scubapro", 75, null, "https://scubaevolution.co.za/cdn/shop/files/SP_24108100_Steel_Comp_Mask_1.webp?v=1747029931", "Snorkel" },
                    { 30, "Scubapro", 100, null, "https://scubadirect.dk/cdn/shop/products/DEFINITION-STMR-3MM-B-ZIP-MAN-63.930.X.jpg?v=1656951438", "DivingSuit" },
                    { 31, "Scubapro", 100, null, "https://shop11921.sfstatic.io/upload_dir/shop/definition-stmr-5mm-b-zip-man-63.932.x.png", "DivingSuit" },
                    { 32, "Scubapro", 100, null, "https://aquaholics.co.uk/cdn/shop/products/scubapro-definition-7mm-woman.jpg?v=1541519476", "DivingSuit" },
                    { 33, "Waterproof", 100, null, "https://www.mikesdivestore.com/cdn/shop/products/W7_male_new_9cbb2496-b304-4daa-ad92-fc0dc822eb51.jpg?v=1672042321&width=1214", "DivingSuit" }
                });

            migrationBuilder.InsertData(
                table: "BCDSpecs",
                columns: new[] { "ProductId", "Model", "Sizes" },
                values: new object[,]
                {
                    { 1, "Navigator Lite BCD", "S,M,L" },
                    { 2, "BCD Glide", "S,M,L" },
                    { 3, "BCD Hydros Pro", "S,M,L" },
                    { 4, "BCD Modular", "S,M,L" }
                });

            migrationBuilder.InsertData(
                table: "DivingSuitSpecs",
                columns: new[] { "ProductId", "Genders", "Model", "Sizes", "SuitType", "ThicknessInMm" },
                values: new object[,]
                {
                    { 5, "Herre,Dame", "Proteus", "XS,S,M,L,XL", 0, 5.0 },
                    { 6, "Herre,Dame", "Exodry 4.0", "XS,S,M,L,XL", 1, null },
                    { 7, "Herre,Dame", "D7 Evo", "XS,S,M,L,XL", 1, null },
                    { 8, "Herre,Dame", "E.Lite Plus", "XS,S,M,L,XL", 1, null },
                    { 30, "Herre,Dame", "Definition", "XS,S,M,L,XL", 0, 3.0 },
                    { 31, "Herre,Dame", "Definition", "XS,S,M,L,XL", 0, 5.0 },
                    { 32, "Herre,Dame", "Definition", "XS,S,M,L,XL", 0, 7.0 },
                    { 33, "Herre,Dame", "W5", "XS,S,M,L,XL", 0, 3.5 }
                });

            migrationBuilder.InsertData(
                table: "FinsSpecs",
                columns: new[] { "ProductId", "Model", "Sizes" },
                values: new object[,]
                {
                    { 16, "Jet Fin", "XS,S,M,L,XL" },
                    { 17, "GO Travel", "XS,S,M,L,XL" },
                    { 18, "Seawing Supernova", "XS,S,M,L,XL" },
                    { 19, "Propulsion", "XS,S,M,L,XL" },
                    { 20, "ALA", "XS,S,M,L,XL" },
                    { 21, "Tech", "XS,S,M,L,XL" },
                    { 22, "Rec Fin", "XS,S,M,L,XL" }
                });

            migrationBuilder.InsertData(
                table: "MaskSnorkelSpecs",
                columns: new[] { "ProductId", "Model" },
                values: new object[,]
                {
                    { 23, "Ghost" },
                    { 24, "D-Mask" },
                    { 25, "Spectra Mini" },
                    { 26, "Crystal VU" },
                    { 27, "Scout Kontrast" },
                    { 28, "Scout Enhance" },
                    { 29, "Element" }
                });

            migrationBuilder.InsertData(
                table: "OxygenTankSpecs",
                columns: new[] { "ProductId", "VolumeInL" },
                values: new object[,]
                {
                    { 12, 5 },
                    { 13, 10 },
                    { 14, 12 },
                    { 15, 15 }
                });

            migrationBuilder.InsertData(
                table: "RegulatorSpecs",
                columns: new[] { "ProductId", "Octopus", "StageOne", "StageTwo" },
                values: new object[,]
                {
                    { 9, "R105", "MK25EVO", "S600" },
                    { 10, "R095", "MK17EVO", "C370" },
                    { 11, "S270", "MK25EVO BT", "A700 Carbon BT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BCDSpecs");

            migrationBuilder.DropTable(
                name: "DivingSuitSpecs");

            migrationBuilder.DropTable(
                name: "FinsSpecs");

            migrationBuilder.DropTable(
                name: "MaskSnorkelSpecs");

            migrationBuilder.DropTable(
                name: "OxygenTankSpecs");

            migrationBuilder.DropTable(
                name: "RegulatorSpecs");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
